[<RequireQualifiedAccess>]
module Feliz.Interop

open Fable.Core
open Fable.React

// let reactApi : IReactApi = importDefault "react"
// #if FABLE_COMPILER_3 || FABLE_COMPILER_4
// let inline reactElement (name: string) (props: 'a) : ReactElement = import "createElement" "react"
// #else
// let reactElement (name: string) (props: 'a) : ReactElement = import "createElement" "react"
// #endif


[<Emit "undefined">]
let undefined: obj = jsNative

let inline mkAttr (key: string) (value: obj) : IReactProperty = key, value

let inline createElement (tag: string) (props: IReactProperty list) : ReactElement =
    JSX.create tag props |> unbox

let inline createElementWithChildren (name: string) (child: #seq<ReactElement>) : ReactElement = 
    JSX.create name ["children", child] |> unbox

let inline createElementWithChild (name: string) (child: 'a) : ReactElement =
    JSX.create name ["children", box child] |> unbox


let inline mkStyle (key: string) (value: obj) : IStyleAttribute = unbox (key, value)

let inline svgAttribute (key: string) (value: obj) : ISvgAttribute = key, value

let inline createSvgElement name (properties: ISvgAttribute list) : ReactElement =
    JSX.create name properties |> unbox

[<Emit "typeof $0 === 'number'">]
let isTypeofNumber (x: obj) : bool = jsNative
