module Components 

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Shared


[<ReactComponent>]
let LogBtn (nb:int, children: ReactElement, props: seq<IReactProperty>) =
    Html.button [
        for prop in props do prop // same as yield! props
        prop.onClick (fun _ -> printfn $"You clicked me {nb}") 
        prop.children children
    ]


[<ReactComponent>]
let Main() =
    Html.div [
        Html.h1 "Welcome to the Fable Playground!"
        Html.p "This is a simple playground for experimenting with Fable and Feliz."
        LogBtn(12, Html.text "Click me", [ prop.style [style.backgroundColor.green; style.color.white]])
    ]
