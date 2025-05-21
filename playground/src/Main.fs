module Main

open Feliz
open Browser.Dom

[<ReactComponent>]
let View() =
    Html.div [
        Components.Components.LazyLoad()
    ]

let root = ReactDOM.createRoot(document.getElementById "root")
root.render(View())


