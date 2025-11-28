module Components

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom
open Shared

type jsx = JSX.Html

// let private areEqualFn = fun prop1 prop2 -> prop1 = prop2

// [<Emit("\"use memo\"")>]
// let use_memo: unit = jsNative



module Components =

    // Memo using F# structural equality (deep equality)
    [<ReactMemoComponent(AreEqualFn.FsEquals)>]
    let MemoFsEquals (values: int list) =
        let renderCount = React.useRef 0
        renderCount.current <- renderCount.current + 1
        Html.div [ prop.testId "memo-fs-count"; prop.text (string renderCount.current) ]

    // Memo using shallow (JS) equality
    [<ReactMemoComponent()>]
    let MemoShallow (values: int list) =
        let renderCount = React.useRef 0
        renderCount.current <- renderCount.current + 1
        Html.div [ prop.testId "memo-shallow-count"; prop.text (string renderCount.current) ]

    // Memo using F# equality and a function prop (for testing function handling)
    [<ReactMemoComponent(AreEqualFn.FsEquals)>]
    let MemoFsEqualsWithFn (values: int list, fn: int -> int) =
        let renderCount = React.useRef 0
        renderCount.current <- renderCount.current + 1
        Html.div [ prop.testId "memo-fs-fn-count"; prop.text (string renderCount.current) ]

    // Memo using F# equality but ignoring function properties
    [<ReactMemoComponent(AreEqualFn.FsEqualsButFunctions)>]
    let MemoFsEqualsButFunctions (values: int list, fn: int -> int) =
        let renderCount = React.useRef 0
        renderCount.current <- renderCount.current + 1
        Html.div [ prop.testId "memo-fs-bf-count"; prop.text (string renderCount.current) ]

    // Parent components used by tests to trigger re-renders with new prop instances
    [<ReactComponent>]
    let ParentListFsEquals() =
        let state, setState = React.useState 0
        let values = [ 1; 2 ] // recreated each render (new instance)
        Html.div [
            Html.button [ prop.testId "btn-list-fs"; prop.onClick (fun _ -> setState(state + 1)); prop.text "Tick" ]
            MemoFsEquals values
        ]

    [<ReactComponent>]
    let ParentListShallow() =
        let state, setState = React.useState 0
        let values = [ 1; 2 ]
        Html.div [
            Html.button [ prop.testId "btn-list-shallow"; prop.onClick (fun _ -> setState(state + 1)); prop.text "Tick" ]
            MemoShallow values
        ]

    [<ReactComponent>]
    let ParentWithFnFs() =
        let state, setState = React.useState 0
        // create a new function each render (captures state) so its reference is different
        let fn = fun x -> x + state
        let values = [ 1; 2 ]
        Html.div [
            Html.button [ prop.testId "btn-fn-fs"; prop.onClick (fun _ -> setState(state + 1)); prop.text "Tick" ]
            MemoFsEqualsWithFn (values, fn)
        ]

    [<ReactComponent>]
    let ParentWithFnFsButFunctions() =
        let state, setState = React.useState 0
        let fn = fun x -> x + state
        let values = [ 1; 2 ]
        Html.div [
            Html.button [ prop.testId "btn-fn-bf"; prop.onClick (fun _ -> setState(state + 1)); prop.text "Tick" ]
            MemoFsEqualsButFunctions (values, fn)
        ]



[<ReactComponent>]
let Main () =
    let fruitArray, setFruitArray = React.useState ([| "Apple"; "Banana"; "Orange" |]) // This stays the same array
    let sortedFruits = Array.sort fruitArray // this creates a new array instance on each render
    let theme, setTheme = React.useState "light"
    Html.div [
        prop.style [ 
            if theme = "light" then 
                style.backgroundColor "white"
                style.color "black"
            else 
                style.backgroundColor "black"
                style.color "white"
        ]
        prop.children [
            // Html.button [
            //     prop.testId "change-fruit-array"
            //     prop.text "Change Fruit Array"
            //     prop.onClick (fun _ -> setFruitArray [| "Apple"; "Banana"; "Orange"; "Cherry" |])
            // ]
            // Html.button [
            //     prop.testId "change-theme"
            //     prop.text "Change Theme"
            //     prop.onClick (fun _ -> 
            //         if theme = "light" then 
            //             setTheme "dark" 
            //         else 
            //             setTheme "light")
            // ]
            Components.ParentWithFnFsButFunctions()
        ]
    ]
