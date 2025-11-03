module App

open Feliz
open Browser.Dom
open Fable.Core
open Fable.Core.JsInterop

[<ReactComponent>]
let App() =
    Html.div [
        prop.children [
            Html.div "Hello, Feliz!"
        ]
    ]
