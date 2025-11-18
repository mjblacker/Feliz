module Tests.FsReactTests

open Fable.Core
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser
open Vitest
open ReactBindings

describe "TokenCancellation" <| fun _ ->
    testPromise "Do not cancel, let async complete" <| fun _ -> promise {
        let render = RTL.render (FsReact.TokenCancellation.Main(false))
        let resultText = RTL.screen.getByTestId "result-text"

        expect(resultText).toHaveTextContent "Initial"
        do! RTL.waitFor((fun () ->
            expect(resultText).toHaveTextContent "Async Completed"
        ), RTLWaitForOptions(timeout=2000))
    }

    testPromise "Cancel, stop async complete" <| fun _ -> promise {
        let render = RTL.render (FsReact.TokenCancellation.Main(true))
        let resultText = RTL.screen.getByTestId "result-text"

        expect(resultText).toHaveTextContent "Initial"
        do! RTL.waitFor((fun () ->
            let resultText = RTL.screen.getByTestId "result-text"
            expect(resultText).toHaveTextContent "Disposed"
        ), RTLWaitForOptions(timeout=2000))

        do! RTL.act(fun () ->
            Promise.sleep 1000
        )

        do! RTL.waitFor((fun () ->
            let resultText = RTL.screen.getByTestId "result-text"
            expect(resultText).not.toHaveTextContent "Async Completed"
        ), RTLWaitForOptions(timeout=2000))
    }
