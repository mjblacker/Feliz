namespace Feliz

open System
open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop

[<EditorBrowsable(EditorBrowsableState.Never); Erase>]
[<RequireQualifiedAccess>]
module Helpers =
    let optDispose (disposeOption: #IDisposable option) =
        { new IDisposable with member _.Dispose () = disposeOption |> Option.iter (fun d -> d.Dispose()) }


[<RequireQualifiedAccess>]
module Interop =

    open Fable.Core
    open Fable.React

    [<Emit "undefined">]
    let undefined: obj = jsNative

    let inline svgAttribute (key: string) (value: obj) : ISvgAttribute = unbox (key, value)

    [<Emit "typeof $0 === 'number'">]
    let isTypeofNumber (x: obj) : bool = jsNative

    [<Emit("typeof $0[Symbol.iterator] === 'function'")>]
    let isIterable (x: obj): bool = jsNative

    [<Emit("""typeof $0 === "string" || $0 instanceof String""")>]
    let isString (value: obj): bool = jsNative
