module Components 

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type IReactApi =
    static member inline lazy' (import: (unit -> JS.Promise<'t>)) : 't = 
        emitJsExpr (import) """import {lazy} from 'react'
lazy($0)"""

type Test =
    // gets transpiled to: get_LazyLoadMember() -> does not work
    static member LazyLoadMember : obj = IReactApi.lazy'(fun () ->
        importDynamic "./LazyComponent.jsx"
    )

[<JSX.ComponentAttribute>]
let ComponentLazy: obj = 
    IReactApi.lazy'(fun () ->
        importDynamic "./LazyComponent.jsx"
    )

[<JSX.ComponentAttribute>]
let inline ComponentLazyLoaded(text: string) = 
    JSX.create ComponentLazy [
        "text", text
    ]

[<Erase; Mangle(false)>]
type Components =

    [<ReactComponent>]
    static member ComponentWithArgs(idBase: string, initCount: int, ?text: string, ?onClick: unit -> unit) =
        let count, setCount = React.useStateWithUpdater(initCount)
        let text = defaultArg text "Default Text"
        let onClick = defaultArg onClick (fun () -> ())
        Html.div [
            prop.id (idBase + "simpleDiv")
            prop.testId (idBase + "simpleDiv")
            prop.children [
                Html.h1 text
                Html.button [
                    prop.text "Increment"
                    prop.onClick (fun _ ->
                        setCount(fun c -> c + 1)
                        onClick())
                ]
                Html.p $"Count: {count}"
            ]
        ]

    [<ReactComponent>]
    static member LazyLoad() =
        let showPreview, setShowPreview = React.useState(false)
        let text, setText = React.useState("start")
        Html.div [
            // Html.input [
            //     prop.testId "input"
            //     prop.value text
            //     prop.onChange (fun (e: string) -> setText(e))
            // ]
            // Html.label [
            //     Html.input [
            //         prop.testId "checkbox"
            //         prop.type' "checkbox"
            //         prop.onChange (fun (e: bool) -> setShowPreview(e))
            //     ]
            //     Html.text "Load Component"
            // ]
            // if showPreview then
            React.Suspense(
                fallback = Html.div [ prop.testId "loading"; prop.text "Loading..." ],
                children = [
                    // Html.h1 "Preview"
                    unbox ComponentLazyLoaded text
                ]
            )
        ]
