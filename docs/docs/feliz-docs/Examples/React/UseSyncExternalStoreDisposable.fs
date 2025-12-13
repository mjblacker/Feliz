module Example.UseSyncExternalStoreDisposable

open Feliz
open Browser

let getSnapshot() = 
    window.innerWidth

let subscribe callback =
    let handler = fun (_: Browser.Types.Event) -> callback()
    window.addEventListener("resize", handler)
    // Feliz helper to create IDisposable
    FsReact.createDisposable(fun () -> window.removeEventListener("resize", handler))
    // same as:
    // { new IDisposable with member _.Dispose() = window.removeEventListener("resize", handler)} 

[<ReactComponent(true)>]
let UseSyncExternalStoreDisposable() =
    let currentWidth = React.useSyncExternalStore(subscribe, getSnapshot)

    Html.h3 $"Window width: {currentWidth}px"
    