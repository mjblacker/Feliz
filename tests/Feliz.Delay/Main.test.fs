module DelayTests

open Fable.Core
open Feliz.Vitest
open Fable.ReactTestingLibrary
open Feliz
open Feliz.Delay
open Browser

[<ReactComponent>]
let DelayComp () =
    React.delay [
        delay.fallback [
            Html.div [
                prop.testId "fallback"
            ]
        ]

        delay.children [
            Html.div [
                prop.testId "render"
            ]
        ]
    ]

[<ReactComponent>]
let DuspenseCompInner() =
    Html.div [
        prop.testId "suspense-child"
    ]

let asyncComponent : JS.Promise<unit -> ReactElement> = JsInterop.importDynamic "./CodeSplitting.fs"

[<ReactComponent>]
let DelaySuspenseComp () =
    React.delaySuspense [
        delaySuspense.delay [
            delay.fallback [
                Html.div [
                    prop.testId "fallback"
                ]
            ]

            delay.children [
                Html.div [
                    prop.testId "render"
                ]
            ]
        ]

        delaySuspense.children [
            React.lazy'(fun () -> promise {
                do! Promise.sleep 1000
                return! asyncComponent
            }) ()
        ]
    ]

describe "Feliz.Delay Tests" <| fun _ ->
    testPromise "delay does not render until after time has passed" <| fun () -> promise {
        let render = RTL.render(DelayComp())
        
        Expect.toBeTruthy (render.queryByTestId "fallback" |> Option.isSome) // "Fallback is rendered initially"
        Expect.toBeTruthy (render.queryByTestId "render" |> Option.isNone) // "Child is not rendered initially"

        do!
            RTL.waitFor <| fun () ->
                Expect.toBeTruthy (render.queryByTestId "fallback" |> Option.isNone) // "Fallback is no longer rendered"
                Expect.toBeTruthy (render.queryByTestId "render" |> Option.isSome) // "Child is now rendered"
    }

    testPromise "delaySuspense does not render until after time has passed" <| fun () -> promise {

        let render = RTL.render(DelaySuspenseComp())
    
        Expect.toBeTruthy (render.queryByTestId "fallback" |> Option.isSome) //"Delay fallback is rendered initially"
        Expect.toBeTruthy (render.queryByTestId "render" |> Option.isNone) //"Delay child is not rendered initially"
        Expect.toBeTruthy (render.queryByTestId "async-load" |> Option.isNone) // "Suspense child is not rendered initially"

        // do!
        //     RTL.waitFor <| fun () ->
        //         Expect.toBeTruthy (render.queryByTestId "fallback" |> Option.isNone) // "Fallback is no longer rendered"
        //         Expect.toBeTruthy (render.queryByTestId "render" |> Option.isSome) //"Child is now rendered"
        //         Expect.toBeTruthy (render.queryByTestId "async-load" |> Option.isNone) // "Suspense child is still not rendered"

        // do! Promise.sleep 1000

        // do!
        //     RTL.waitFor <| fun () ->
        //         Expect.toBeTruthy (render.queryByTestId "fallback" |> Option.isNone)  //"delay fallback is no longer rendered"
        //         Expect.toBeTruthy (render.queryByTestId "render" |> Option.isNone) //"delay child is no longer rendered"
        //         Expect.toBeTruthy (render.queryByTestId "async-load" |> Option.isSome) //"Suspense child is now rendered"
                
    }
