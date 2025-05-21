module LazyComponent

open Fable.Core
open Feliz

[<ReactComponentAttribute(true)>]
let Main(text: string) =
    Html.div [
        prop.id "lazyComponent"
        prop.testId "lazyComponent"
        prop.children [
            Html.h1 text
        ]
    ]
