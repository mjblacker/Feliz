module LazyComponent

open Fable.Core
open Feliz

[<ReactComponentAttribute(true)>]
let Main(text: string) =
    React.useEffectOnce(fun () ->
        // Simulate a delay to mimic lazy loading
        Browser.Dom.console.log("Lazy component loading...")
    )
    Html.div [
        prop.id "lazyComponent"
        prop.testId "lazyComponent"
        prop.children [
            Html.h1 text
        ]
    ]
