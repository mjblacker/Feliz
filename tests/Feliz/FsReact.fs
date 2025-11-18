module Tests.FsReact

open Fable.Core
open Feliz

module TokenCancellation =
    /// <summary>
    /// A component that uses a cancellation token to cancel an async operation when unmounted.
    /// </summary>
    [<ReactComponent>]
    let private CancelAsyncWithUnmountElement (callback: unit -> unit) =
        let token = FsReact.useCancellationToken()

        React.useEffectOnce(fun () ->
            async {
                do! Async.Sleep 500
                callback()
            }
            |> fun a -> Async.StartImmediate(a,token.current)
        )

        Html.none

    [<ReactComponent>]
    let Main (unmount: bool) =
        let renderChild,setRenderChild = React.useState true
        let resultText,setResultText = React.useState "Initial"

        let setTextCallback = React.useCallback <| fun () -> setResultText "Async Completed"

        React.useLayoutEffectOnce(fun () ->
            async {
                do! Async.Sleep 100

                if unmount then
                    setResultText "Disposed"
                    setRenderChild false
            }
            |> Async.StartImmediate
        )

        Html.div [
            if renderChild then
                CancelAsyncWithUnmountElement(setTextCallback)
            Html.div [
                prop.testId "result-text"
                prop.text resultText
            ]
        ]

