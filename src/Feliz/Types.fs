namespace Feliz

open Fable.Core

/// Describes an element property
type IReactProperty = Fable.Core.JSX.Prop

/// Describes style attribute
type IStyleAttribute = interface end

/// Describes an SVG attribute
type ISvgAttribute = Fable.Core.JSX.Prop

type ReactElement = Fable.React.ReactElement

type IRefValue<'T> = Fable.React.IRefValue<'T>
