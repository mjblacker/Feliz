module Components 

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Dom

// [<Erase>]
// type IReactApi =
//     [<Import("lazy", "react")>]
//     static member inline lazy' (import: (unit -> JS.Promise<'t>)) : 't = jsNative

// type Test =
//     // gets transpiled to: get_LazyLoadMember() -> does not work
//     static member LazyLoadMember : obj = IReactApi.lazy'(fun () ->
//         importDynamic "./LazyComponent.jsx"
//     )

// ---- Working but unclean -----

// [<JSX.ComponentAttribute>]
// let ComponentLazy: obj = 
//     IReactApi.lazy'(fun () ->
//         importDynamic "./LazyComponent.jsx"
//     )

// [<JSX.ComponentAttribute>]
// let inline ComponentLazyLoaded(text: string) = 
//     JSX.create ComponentLazy [
//         "text", text
//     ]

// -------------------------------


// ---- 2. Does not work -----

// let inline lazyCombined(props, dynImport) =
//     ReactLegacy.createElement(
//         IReactApi.lazy' dynImport,
//         props
//     )

// [<JSX.ComponentAttribute>]
// let ComponentLazy(text: string) = 
//     // console.log("ComponentLazy called with text:", props)
//     lazyCombined(text, fun () ->
//         importDynamic "./LazyComponent.jsx"
//     )


// -------------------------------


// ---- 3. Does not work -----
//
// ```jsx
// export function ComponentLazy($props) {
//     return lazy(() => import("./LazyComponent.jsx"));
// }
// ```
// This is not allowed, it must be used as ``const``
// [<JSX.ComponentAttribute>]
// let ComponentLazy(text: string): ReactElement = 
//     // console.log("ComponentLazy called with text:", props)
//     IReactApi.lazy'(fun () ->
//         importDynamic "./LazyComponent.jsx"
//     )

// -------------------------------

// ---- 4. Does not work -----
//
// ```jsx
// {ComponentLazy({
//     text: text,
// })}
// ```
// This is not allowed, it must be used called with jsx syntax
[<JSX.ComponentAttribute>]
let ComponentLazy: {|text: string|} -> ReactElement = 
    // console.log("ComponentLazy called with text:", props)
    React.lazy'(fun () ->
        importDynamic "./LazyComponent.jsx"
    )

// -------------------------------


[<Erase>]
type IReactTest =
    [<ReactComponent(import="StrictMode", from="react")>]
    static member StrictMode (children: ReactElement list) : ReactElement = React.Imported()

[<Erase; Mangle(false)>]
type Components =

    [<ReactComponent>]
    static member LazyLoad() =
        let text, setText = React.useState("loading finished")
        React.StrictMode [
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
                        // Works
                        // unbox ComponentLazyLoaded text
                        unbox (JSX.create ComponentLazy ["text", text])
                    ]
                )
            ]
        ]
