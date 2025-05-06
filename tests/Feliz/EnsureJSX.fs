module Tests.EnsureJSX

open Fable.Core
open Feliz

[<Erase>]
type Components =

    [<ReactComponent>]
    static member DivWithClassesAndChildren() =
        Html.div [
            prop.className "simple-div"
            prop.style [ style.backgroundColor "lightblue" ]
            prop.id "simpleDiv"
            prop.onClick (fun _ -> Browser.Dom.console.log("Div clicked!"))
            prop.children [
                Html.h1 "Hello, World!"
                Html.p "This is a simple div component."
            ]
        ]
