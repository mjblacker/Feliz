namespace Feliz

open Fable.React
open Fable.Core
open Fable.Core.JsInterop
open System

[<Erase>]
type Html =
    static member inline a xs = Interop.createElement "a" xs
    static member inline a (children: #seq<ReactElement>) = Interop.createElementWithChildren "a" children

    static member inline abbr xs = Interop.createElement "abbr" xs
    static member inline abbr (value: float) = Interop.createElementWithChild "abbr" value
    static member inline abbr (value: int) = Interop.createElementWithChild "abbr" value
    static member inline abbr (value: ReactElement) = Interop.createElementWithChild "abbr" value
    static member inline abbr (value: string) = Interop.createElementWithChild "abbr" value
    static member inline abbr (children: #seq<ReactElement>) = Interop.createElementWithChildren "abbr" children

    static member inline address xs = Interop.createElement "address" xs
    static member inline address (value: float) = Interop.createElementWithChild "address" value
    static member inline address (value: int) = Interop.createElementWithChild "address" value
    static member inline address (value: ReactElement) = Interop.createElementWithChild "address" value
    static member inline address (value: string) = Interop.createElementWithChild "address" value
    static member inline address (children: #seq<ReactElement>) = Interop.createElementWithChildren "address" children

    static member inline anchor xs = Interop.createElement "a" xs
    static member inline anchor (children: #seq<ReactElement>) = Interop.createElementWithChildren "a" children

    static member inline animate xs = Interop.createElement "animate" xs

    static member inline animateMotion xs = Interop.createElement "animateMotion" xs
    static member inline animateMotion (children: #seq<ReactElement>) = Interop.createElementWithChildren "animateMotion" children

    static member inline animateTransform xs = Interop.createElement "animateTransform" xs
    static member inline animateTransform (children: #seq<ReactElement>) = Interop.createElementWithChildren "animateTransform" children

    static member inline area xs = Interop.createElement "area" xs

    static member inline article xs = Interop.createElement "article" xs
    static member inline article (children: #seq<ReactElement>) = Interop.createElementWithChildren "article" children

    static member inline aside xs = Interop.createElement "aside" xs
    static member inline aside (children: #seq<ReactElement>) = Interop.createElementWithChildren "aside" children

    static member inline audio xs = Interop.createElement "audio" xs
    static member inline audio (children: #seq<ReactElement>) = Interop.createElementWithChildren "audio" children

    static member inline b xs = Interop.createElement "b" xs
    static member inline b (value: float) = Interop.createElementWithChild "b" value
    static member inline b (value: int) = Interop.createElementWithChild "b" value
    static member inline b (value: ReactElement) = Interop.createElementWithChild "b" value
    static member inline b (value: string) = Interop.createElementWithChild "b" value
    static member inline b (children: #seq<ReactElement>) = Interop.createElementWithChildren "b" children

    static member inline base' xs = Interop.createElement "base" xs

    static member inline bdi xs = Interop.createElement "bdi" xs
    static member inline bdi (value: float) = Interop.createElementWithChild "bdi" value
    static member inline bdi (value: int) = Interop.createElementWithChild "bdi" value
    static member inline bdi (value: ReactElement) = Interop.createElementWithChild "bdi" value
    static member inline bdi (value: string) = Interop.createElementWithChild "bdi" value
    static member inline bdi (children: #seq<ReactElement>) = Interop.createElementWithChildren "bdi" children

    static member inline bdo xs = Interop.createElement "bdo" xs
    static member inline bdo (value: float) = Interop.createElementWithChild "bdo" value
    static member inline bdo (value: int) = Interop.createElementWithChild "bdo" value
    static member inline bdo (value: ReactElement) = Interop.createElementWithChild "bdo" value
    static member inline bdo (value: string) = Interop.createElementWithChild "bdo" value
    static member inline bdo (children: #seq<ReactElement>) = Interop.createElementWithChildren "bdo" children

    static member inline blockquote xs = Interop.createElement "blockquote" xs
    static member inline blockquote (value: float) = Interop.createElementWithChild "blockquote" value
    static member inline blockquote (value: int) = Interop.createElementWithChild "blockquote" value
    static member inline blockquote (value: ReactElement) = Interop.createElementWithChild "blockquote" value
    static member inline blockquote (value: string) = Interop.createElementWithChild "blockquote" value
    static member inline blockquote (children: #seq<ReactElement>) = Interop.createElementWithChildren "blockquote" children

    static member inline body xs = Interop.createElement "body" xs
    static member inline body (value: float) = Interop.createElementWithChild "body" value
    static member inline body (value: int) = Interop.createElementWithChild "body" value
    static member inline body (value: ReactElement) = Interop.createElementWithChild "body" value
    static member inline body (value: string) = Interop.createElementWithChild "body" value
    static member inline body (children: #seq<ReactElement>) = Interop.createElementWithChildren "body" children

    static member inline br xs = Interop.createElement "br" xs

    static member inline button xs = Interop.createElement "button" xs
    static member inline button (children: #seq<ReactElement>) = Interop.createElementWithChildren "button" children

    static member inline canvas xs = Interop.createElement "canvas" xs

    static member inline caption xs = Interop.createElement "caption" xs
    static member inline caption (value: float) = Interop.createElementWithChild "caption" value
    static member inline caption (value: int) = Interop.createElementWithChild "caption" value
    static member inline caption (value: ReactElement) = Interop.createElementWithChild "caption" value
    static member inline caption (value: string) = Interop.createElementWithChild "caption" value
    static member inline caption (children: #seq<ReactElement>) = Interop.createElementWithChildren "caption" children

    static member inline cite xs = Interop.createElement "cite" xs
    static member inline cite (value: float) = Interop.createElementWithChild "cite" value
    static member inline cite (value: int) = Interop.createElementWithChild "cite" value
    static member inline cite (value: ReactElement) = Interop.createElementWithChild "cite" value
    static member inline cite (value: string) = Interop.createElementWithChild "cite" value
    static member inline cite (children: #seq<ReactElement>) = Interop.createElementWithChildren "cite" children
    [<Obsolete "Html.circle is obsolete, use Svg.circle instead">]
    static member inline circle xs = Interop.createElement "circle" xs
    [<Obsolete "Html.circle is obsolete, use Svg.circle instead">]
    static member inline circle (children: #seq<ReactElement>) = Interop.createElementWithChildren "circle" children
    [<Obsolete "Html.clipPath is obsolete, use Svg.clipPath instead">]
    static member inline clipPath xs = Interop.createElement "clipPath" xs
    [<Obsolete "Html.clipPath is obsolete, use Svg.clipPath instead">]
    static member inline clipPath (children: #seq<ReactElement>) = Interop.createElementWithChildren "clipPath" children

    static member inline code xs = Interop.createElement "code" xs
    static member inline code (value: bool) = Interop.createElementWithChild "code" value
    static member inline code (value: float) = Interop.createElementWithChild "code" value
    static member inline code (value: int) = Interop.createElementWithChild "code" value
    static member inline code (value: ReactElement) = Interop.createElementWithChild "code" value
    static member inline code (value: string) = Interop.createElementWithChild "code" value
    static member inline code (children: #seq<ReactElement>) = Interop.createElementWithChildren "code" children

    static member inline col xs = Interop.createElement "col" xs

    static member inline colgroup xs = Interop.createElement "colgroup" xs
    static member inline colgroup (children: #seq<ReactElement>) = Interop.createElementWithChildren "colgroup" children

    [<Obsolete("This deprecated API should no longer be used, but will probably still work.")>]
    static member inline content (value: float) : ReactElement = unbox value
    [<Obsolete("This deprecated API should no longer be used, but will probably still work.")>]
    static member inline content (value: int) : ReactElement = unbox value
    [<Obsolete("This deprecated API should no longer be used, but will probably still work.")>]
    static member inline content (value: string) : ReactElement = unbox value

    static member inline data xs = Interop.createElement "data" xs
    static member inline data (value: float) = Interop.createElementWithChild "data" value
    static member inline data (value: int) = Interop.createElementWithChild "data" value
    static member inline data (value: ReactElement) = Interop.createElementWithChild "data" value
    static member inline data (value: string) = Interop.createElementWithChild "data" value
    static member inline data (children: #seq<ReactElement>) = Interop.createElementWithChildren "data" children

    static member inline datalist xs = Interop.createElement "datalist" xs
    static member inline datalist (value: float) = Interop.createElementWithChild "datalist" value
    static member inline datalist (value: int) = Interop.createElementWithChild "datalist" value
    static member inline datalist (value: ReactElement) = Interop.createElementWithChild "datalist" value
    static member inline datalist (value: string) = Interop.createElementWithChild "datalist" value
    static member inline datalist (children: #seq<ReactElement>) = Interop.createElementWithChildren "datalist" children

    static member inline dd xs = Interop.createElement "dd" xs
    static member inline dd (value: float) = Interop.createElementWithChild "dd" value
    static member inline dd (value: int) = Interop.createElementWithChild "dd" value
    static member inline dd (value: ReactElement) = Interop.createElementWithChild "dd" value
    static member inline dd (value: string) = Interop.createElementWithChild "dd" value
    static member inline dd (children: #seq<ReactElement>) = Interop.createElementWithChildren "dd" children
    [<Obsolete "Html.defs is obsolete, use Svg.defs instead">]
    static member inline defs xs = Interop.createElement "defs" xs
    [<Obsolete "Html.defs is obsolete, use Svg.defs instead">]
    static member inline defs (children: #seq<ReactElement>) = Interop.createElementWithChildren "defs" children
    static member inline del xs = Interop.createElement "del" xs
    static member inline del (value: float) = Interop.createElementWithChild "del" value
    static member inline del (value: int) = Interop.createElementWithChild "del" value
    static member inline del (value: ReactElement) = Interop.createElementWithChild "del" value
    static member inline del (value: string) = Interop.createElementWithChild "del" value
    static member inline del (children: #seq<ReactElement>) = Interop.createElementWithChildren "del" children

    static member inline details xs = Interop.createElement "details" xs
    static member inline details (children: #seq<ReactElement>) = Interop.createElementWithChildren "details" children

    [<Obsolete "Html.desc is obsolete, use Svg.desc instead">]
    static member inline desc xs = Interop.createElement "desc" xs
    [<Obsolete "Html.desc is obsolete, use Svg.desc instead">]
    static member inline desc (value: float) = Interop.createElementWithChild "desc" value
    [<Obsolete "Html.desc is obsolete, use Svg.desc instead">]
    static member inline desc (value: int) = Interop.createElementWithChild "desc" value
    [<Obsolete "Html.desc is obsolete, use Svg.desc instead">]
    static member inline desc (value: string) = Interop.createElementWithChild "desc" value

    static member inline dfn xs = Interop.createElement "ins" xs
    static member inline dfn (value: float) = Interop.createElementWithChild "dfn" value
    static member inline dfn (value: int) = Interop.createElementWithChild "dfn" value
    static member inline dfn (value: ReactElement) = Interop.createElementWithChild "dfn" value
    static member inline dfn (value: string) = Interop.createElementWithChild "dfn" value
    static member inline dfn (children: #seq<ReactElement>) = Interop.createElementWithChildren "dfn" children

    static member inline dialog xs = Interop.createElement "dialog" xs
    static member inline dialog (value: float) = Interop.createElementWithChild "dialog" value
    static member inline dialog (value: int) = Interop.createElementWithChild "dialog" value
    static member inline dialog (value: ReactElement) = Interop.createElementWithChild "dialog" value
    static member inline dialog (value: string) = Interop.createElementWithChild "dialog" value
    static member inline dialog (children: #seq<ReactElement>) = Interop.createElementWithChildren "dialog" children

    /// The `<div>` tag defines a division or a section in an HTML document
    static member inline div xs = Interop.createElement "div" xs
    static member inline div (value: float) = Interop.createElementWithChild "div" value
    static member inline div (value: int) = Interop.createElementWithChild "div" value
    static member inline div (value: ReactElement) = Interop.createElementWithChild "div" value
    static member inline div (value: string) = Interop.createElementWithChild "div" value
    static member inline div (children: #seq<ReactElement>) = Interop.createElementWithChildren "div" children

    static member inline dl xs = Interop.createElement "dl" xs
    static member inline dl (children: #seq<ReactElement>) = Interop.createElementWithChildren "dl" children

    static member inline dt xs = Interop.createElement "dt" xs
    static member inline dt (value: float) = Interop.createElementWithChild "dt" value
    static member inline dt (value: int) = Interop.createElementWithChild "dt" value
    static member inline dt (value: ReactElement) = Interop.createElementWithChild "dt" value
    static member inline dt (value: string) = Interop.createElementWithChild "dt" value
    static member inline dt (children: #seq<ReactElement>) = Interop.createElementWithChildren "dt" children

    [<Obsolete "Html.ellipse is obsolete, use Svg.ellipse instead">]
    static member inline ellipse xs = Interop.createElement "ellipse" xs
    [<Obsolete "Html.ellipse is obsolete, use Svg.ellipse instead">]
    static member inline ellipse (children: #seq<ReactElement>) = Interop.createElementWithChildren "ellipse" children

    static member inline em xs = Interop.createElement "em" xs
    static member inline em (value: float) = Interop.createElementWithChild "em" value
    static member inline em (value: int) = Interop.createElementWithChild "em" value
    static member inline em (value: ReactElement) = Interop.createElementWithChild "em" value
    static member inline em (value: string) = Interop.createElementWithChild "em" value
    static member inline em (children: #seq<ReactElement>) = Interop.createElementWithChildren "em" children

    static member inline embed xs = Interop.createElement "embed" xs
    [<Obsolete "Html.feBlend is obsolete, use Svg.feBlend instead">]
    static member inline feBlend xs = Interop.createElement "feBlend" xs
    [<Obsolete "Html.feBlend is obsolete, use Svg.feBlend instead">]
    static member inline feBlend (children: #seq<ReactElement>) = Interop.createElementWithChildren "feBlend" children
    [<Obsolete "Html.feColorMatrix is obsolete, use Svg.feColorMatrix instead">]
    static member inline feColorMatrix xs = Interop.createElement "feColorMatrix" xs
    [<Obsolete "Html.feColorMatrix is obsolete, use Svg.feColorMatrix instead">]
    static member inline feColorMatrix (children: #seq<ReactElement>) = Interop.createElementWithChildren "feColorMatrix" children
    [<Obsolete "Html.feComponentTransfer is obsolete, use Svg.feComponentTransfer instead">]
    static member inline feComponentTransfer xs = Interop.createElement "feComponentTransfer" xs
    [<Obsolete "Html.feComponentTransfer is obsolete, use Svg.feComponentTransfer instead">]
    static member inline feComponentTransfer (children: #seq<ReactElement>) = Interop.createElementWithChildren "feComponentTransfer" children
    [<Obsolete "Html.feComposite is obsolete, use Svg.feComposite instead">]
    static member inline feComposite xs = Interop.createElement "feComposite" xs
    [<Obsolete "Html.feComposite is obsolete, use Svg.feComposite instead">]
    static member inline feComposite (children: #seq<ReactElement>) = Interop.createElementWithChildren "feComposite" children
    [<Obsolete "Html.feConvolveMatrix is obsolete, use Svg.feConvolveMatrix instead">]
    static member inline feConvolveMatrix xs = Interop.createElement "feConvolveMatrix" xs
    [<Obsolete "Html.feConvolveMatrix is obsolete, use Svg.feConvolveMatrix instead">]
    static member inline feConvolveMatrix (children: #seq<ReactElement>) = Interop.createElementWithChildren "feConvolveMatrix" children
    [<Obsolete "Html.feDiffuseLighting is obsolete, use Svg.feDiffuseLighting instead">]
    static member inline feDiffuseLighting xs = Interop.createElement "feDiffuseLighting" xs
    [<Obsolete "Html.feDiffuseLighting is obsolete, use Svg.feDiffuseLighting instead">]
    static member inline feDiffuseLighting (children: #seq<ReactElement>) = Interop.createElementWithChildren "feDiffuseLighting" children
    [<Obsolete "Html.feDisplacementMap is obsolete, use Svg.feDisplacementMap instead">]
    static member inline feDisplacementMap xs = Interop.createElement "feDisplacementMap" xs
    [<Obsolete "Html.feDisplacementMap is obsolete, use Svg.feDisplacementMap instead">]
    static member inline feDisplacementMap (children: #seq<ReactElement>) = Interop.createElementWithChildren "feDisplacementMap" children
    [<Obsolete "Html.feDistantLight is obsolete, use Svg.feDistantLight instead">]
    static member inline feDistantLight xs = Interop.createElement "feDistantLight" xs
    [<Obsolete "Html.feDistantLight is obsolete, use Svg.feDistantLight instead">]
    static member inline feDistantLight (children: #seq<ReactElement>) = Interop.createElementWithChildren "feDistantLight" children
    [<Obsolete "Html.feDropShadow is obsolete, use Svg.feDropShadow instead">]
    static member inline feDropShadow xs = Interop.createElement "feDropShadow" xs
    [<Obsolete "Html.feDropShadow is obsolete, use Svg.feDropShadow instead">]
    static member inline feDropShadow (children: #seq<ReactElement>) = Interop.createElementWithChildren "feDropShadow" children
    [<Obsolete "Html.feFlood is obsolete, use Svg.feFlood instead">]
    static member inline feFlood xs = Interop.createElement "feFlood" xs
    [<Obsolete "Html.feFlood is obsolete, use Svg.feFlood instead">]
    static member inline feFlood (children: #seq<ReactElement>) = Interop.createElementWithChildren "feFlood" children
    [<Obsolete "Html.feFuncA is obsolete, use Svg.feFuncA instead">]
    static member inline feFuncA xs = Interop.createElement "feFuncA" xs
    [<Obsolete "Html.feFuncA is obsolete, use Svg.feFuncA instead">]
    static member inline feFuncA (children: #seq<ReactElement>) = Interop.createElementWithChildren "feFuncA" children
    [<Obsolete "Html.feFuncB is obsolete, use Svg.feFuncB instead">]
    static member inline feFuncB xs = Interop.createElement "feFuncB" xs
    [<Obsolete "Html.feFuncB is obsolete, use Svg.feFuncB instead">]
    static member inline feFuncB (children: #seq<ReactElement>) = Interop.createElementWithChildren "feFuncB" children
    [<Obsolete "Html.feFuncG is obsolete, use Svg.feFuncG instead">]
    static member inline feFuncG xs = Interop.createElement "feFuncG" xs
    [<Obsolete "Html.feFuncG is obsolete, use Svg.feFuncG instead">]
    static member inline feFuncG (children: #seq<ReactElement>) = Interop.createElementWithChildren "feFuncG" children
    [<Obsolete "Html.feFuncR is obsolete, use Svg.feFuncR instead">]
    static member inline feFuncR xs = Interop.createElement "feFuncR" xs
    [<Obsolete "Html.feFuncR is obsolete, use Svg.feFuncR instead">]
    static member inline feFuncR (children: #seq<ReactElement>) = Interop.createElementWithChildren "feFuncR" children
    [<Obsolete "Html.feGaussianBlur is obsolete, use Svg.feGaussianBlur instead">]
    static member inline feGaussianBlur xs = Interop.createElement "feGaussianBlur" xs
    [<Obsolete "Html.feGaussianBlur is obsolete, use Svg.feGaussianBlur instead">]
    static member inline feGaussianBlur (children: #seq<ReactElement>) = Interop.createElementWithChildren "feGaussianBlur" children
    [<Obsolete "Html.feImage is obsolete, use Svg.feImage instead">]
    static member inline feImage xs = Interop.createElement "feImage" xs
    [<Obsolete "Html.feImage is obsolete, use Svg.feImage instead">]
    static member inline feImage (children: #seq<ReactElement>) = Interop.createElementWithChildren "feImage" children
    [<Obsolete "Html.feMerge is obsolete, use Svg.feMerge instead">]
    static member inline feMerge xs = Interop.createElement "feMerge" xs
    [<Obsolete "Html.feMerge is obsolete, use Svg.feMerge instead">]
    static member inline feMerge (children: #seq<ReactElement>) = Interop.createElementWithChildren "feMerge" children
    [<Obsolete "Html.feMergeNode is obsolete, use Svg.feMergeNode instead">]
    static member inline feMergeNode xs = Interop.createElement "feMergeNode" xs
    [<Obsolete "Html.feMergeNode is obsolete, use Svg.feMergeNode instead">]
    static member inline feMergeNode (children: #seq<ReactElement>) = Interop.createElementWithChildren "feMergeNode" children
    [<Obsolete "Html.feMorphology is obsolete, use Svg.feMorphology instead">]
    static member inline feMorphology xs = Interop.createElement "feMorphology" xs
    [<Obsolete "Html.feMorphology is obsolete, use Svg.feMorphology instead">]
    static member inline feMorphology (children: #seq<ReactElement>) = Interop.createElementWithChildren "feMorphology" children
    [<Obsolete "Html.feOffset is obsolete, use Svg.feOffset instead">]
    static member inline feOffset xs = Interop.createElement "feOffset" xs
    [<Obsolete "Html.feOffset is obsolete, use Svg.feOffset instead">]
    static member inline feOffset (children: #seq<ReactElement>) = Interop.createElementWithChildren "feOffset" children
    [<Obsolete "Html.fePointLight is obsolete, use Svg.fePointLight instead">]
    static member inline fePointLight xs = Interop.createElement "fePointLight" xs
    [<Obsolete "Html.fePointLight is obsolete, use Svg.fePointLight instead">]
    static member inline fePointLight (children: #seq<ReactElement>) = Interop.createElementWithChildren "fePointLight" children
    [<Obsolete "Html.feSpecularLighting is obsolete, use Svg.feSpecularLighting instead">]
    static member inline feSpecularLighting xs = Interop.createElement "feSpecularLighting" xs
    [<Obsolete "Html.feSpecularLighting is obsolete, use Svg.feSpecularLighting instead">]
    static member inline feSpecularLighting (children: #seq<ReactElement>) = Interop.createElementWithChildren "feSpecularLighting" children
    [<Obsolete "Html.feSpotLight is obsolete, use Svg.feSpotLight instead">]
    static member inline feSpotLight xs = Interop.createElement "feSpotLight" xs
    [<Obsolete "Html.feSpotLight is obsolete, use Svg.feSpotLight instead">]
    static member inline feSpotLight (children: #seq<ReactElement>) = Interop.createElementWithChildren "feSpotLight" children
    [<Obsolete "Html.feTile is obsolete, use Svg.feTile instead">]
    static member inline feTile xs = Interop.createElement "feTile" xs
    [<Obsolete "Html.feTile is obsolete, use Svg.feTile instead">]
    static member inline feTile (children: #seq<ReactElement>) = Interop.createElementWithChildren "feTile" children
    [<Obsolete "Html.feTurbulence is obsolete, use Svg.feTurbulence instead">]
    static member inline feTurbulence xs = Interop.createElement "feTurbulence" xs
    [<Obsolete "Html.feTurbulence is obsolete, use Svg.feTurbulence instead">]
    static member inline feTurbulence (children: #seq<ReactElement>) = Interop.createElementWithChildren "feTurbulence" children
    static member inline fieldSet xs = Interop.createElement "fieldset" xs
    static member inline fieldSet (children: #seq<ReactElement>) = Interop.createElementWithChildren "fieldset" children

    static member inline figcaption xs = Interop.createElement "figcaption" xs
    static member inline figcaption (children: #seq<ReactElement>) = Interop.createElementWithChildren "figcaption" children

    static member inline figure xs = Interop.createElement "figure" xs
    static member inline figure (children: #seq<ReactElement>) = Interop.createElementWithChildren "figure" children
    [<Obsolete "Html.filter is obsolete, use Svg.filter instead">]
    static member inline filter xs = Interop.createElement "filter" xs
    [<Obsolete "Html.filter is obsolete, use Svg.filter instead">]
    static member inline filter (children: #seq<ReactElement>) = Interop.createElementWithChildren "filter" children

    static member inline footer xs = Interop.createElement "footer" xs
    static member inline footer (children: #seq<ReactElement>) = Interop.createElementWithChildren "footer" children
    [<Obsolete "Html.foreignObject is obsolete, use Svg.foreignObject instead">]
    static member inline foreignObject xs = Interop.createElement "foreignObject" xs
    [<Obsolete "Html.foreignObject is obsolete, use Svg.foreignObject instead">]
    static member inline foreignObject (children: #seq<ReactElement>) = Interop.createElementWithChildren "foreignObject" children

    static member inline form xs = Interop.createElement "form" xs
    static member inline form (children: #seq<ReactElement>) = Interop.createElementWithChildren "form" children

    // [<Obsolete("Html.fragment is obsolete, use React.fragment instead. This function will be removed in the coming v1.0 release")>]
    // static member inline fragment xs = Fable.React.Helpers.fragment [] xs
    [<Obsolete "Html.g is obsolete, use Svg.g instead">]
    static member inline g xs = Interop.createElement "g" xs
    [<Obsolete "Html.g is obsolete, use Svg.g instead">]
    static member inline g (children: #seq<ReactElement>) = Interop.createElementWithChildren "g" children

    static member inline h1 xs = Interop.createElement "h1" xs
    static member inline h1 (value: float) = Interop.createElementWithChild "h1" value
    static member inline h1 (value: int) = Interop.createElementWithChild "h1" value
    static member inline h1 (value: ReactElement) = Interop.createElementWithChild "h1" value
    static member inline h1 (value: string) = Interop.createElementWithChild "h1" value
    static member inline h1 (children: #seq<ReactElement>) = Interop.createElementWithChildren "h1" children
    static member inline h2 xs = Interop.createElement "h2" xs
    static member inline h2 (value: float) =  Interop.createElementWithChild "h2" value
    static member inline h2 (value: int) =  Interop.createElementWithChild "h2" value
    static member inline h2 (value: ReactElement) =  Interop.createElementWithChild "h2" value
    static member inline h2 (value: string) =  Interop.createElementWithChild "h2" value
    static member inline h2 (children: #seq<ReactElement>) = Interop.createElementWithChildren "h2" children

    static member inline h3 xs = Interop.createElement "h3" xs
    static member inline h3 (value: float) =  Interop.createElementWithChild "h3" value
    static member inline h3 (value: int) =  Interop.createElementWithChild "h3" value
    static member inline h3 (value: ReactElement) =  Interop.createElementWithChild "h3" value
    static member inline h3 (value: string) =  Interop.createElementWithChild "h3" value
    static member inline h3 (children: #seq<ReactElement>) = Interop.createElementWithChildren "h3" children

    static member inline h4 xs = Interop.createElement "h4" xs
    static member inline h4 (value: float) = Interop.createElementWithChild "h4" value
    static member inline h4 (value: int) = Interop.createElementWithChild "h4" value
    static member inline h4 (value: ReactElement) = Interop.createElementWithChild "h4" value
    static member inline h4 (value: string) = Interop.createElementWithChild "h4" value
    static member inline h4 (children: #seq<ReactElement>) = Interop.createElementWithChildren "h4" children

    static member inline h5 xs = Interop.createElement "h5" xs
    static member inline h5 (value: float) = Interop.createElementWithChild "h5" value
    static member inline h5 (value: int) = Interop.createElementWithChild "h5" value
    static member inline h5 (value: ReactElement) = Interop.createElementWithChild "h5" value
    static member inline h5 (value: string) = Interop.createElementWithChild "h5" value
    static member inline h5 (children: #seq<ReactElement>) = Interop.createElementWithChildren "h5" children

    static member inline h6 xs = Interop.createElement "h6" xs
    static member inline h6 (value: float) = Interop.createElementWithChild "h6" value
    static member inline h6 (value: int) = Interop.createElementWithChild "h6" value
    static member inline h6 (value: ReactElement) = Interop.createElementWithChild "h6" value
    static member inline h6 (value: string) = Interop.createElementWithChild "h6" value
    static member inline h6 (children: #seq<ReactElement>) = Interop.createElementWithChildren "h6" children

    static member inline head xs = Interop.createElement "head" xs
    static member inline head (children: #seq<ReactElement>) = Interop.createElementWithChildren "head" children

    static member inline header xs = Interop.createElement "header" xs
    static member inline header (children: #seq<ReactElement>) = Interop.createElementWithChildren "header" children

    static member inline hr xs = Interop.createElement "hr" xs

    static member inline html xs = Interop.createElement "html" xs
    static member inline html (children: #seq<ReactElement>) = Interop.createElementWithChildren "html" children

    static member inline i xs = Interop.createElement "i" xs
    static member inline i (value: float) = Interop.createElementWithChild "i" value
    static member inline i (value: int) = Interop.createElementWithChild "i" value
    static member inline i (value: ReactElement) = Interop.createElementWithChild "i" value
    static member inline i (value: string) = Interop.createElementWithChild "i" value
    static member inline i (children: #seq<ReactElement>) = Interop.createElementWithChildren "i" children

    static member inline iframe xs = Interop.createElement "iframe" xs

    static member inline img xs = Interop.createElement "img" xs
    /// SVG Image element, not to be confused with HTML img alias.
    static member inline image xs = Interop.createElement "image" xs
    /// SVG Image element, not to be confused with HTML img alias.
    static member inline image (children: #seq<ReactElement>) = Interop.createElementWithChildren "image" children

    static member inline input xs = Interop.createElement "input" xs

    static member inline ins xs = Interop.createElement "ins" xs
    static member inline ins (value: float) = Interop.createElementWithChild "ins" value
    static member inline ins (value: int) = Interop.createElementWithChild "ins" value
    static member inline ins (value: ReactElement) = Interop.createElementWithChild "ins" value
    static member inline ins (value: string) = Interop.createElementWithChild "ins" value
    static member inline ins (children: #seq<ReactElement>) = Interop.createElementWithChildren "ins" children

    static member inline kbd xs = Interop.createElement "kbd" xs
    static member inline kbd (value: float) = Interop.createElementWithChild "kbd" value
    static member inline kbd (value: int) = Interop.createElementWithChild "kbd" value
    static member inline kbd (value: ReactElement) = Interop.createElementWithChild "kbd" value
    static member inline kbd (value: string) = Interop.createElementWithChild "kbd" value
    static member inline kbd (children: #seq<ReactElement>) = Interop.createElementWithChildren "kbd" children

    static member inline label xs = Interop.createElement "label" xs
    static member inline label (children: #seq<ReactElement>) = Interop.createElementWithChildren "label" children

    static member inline legend xs = Interop.createElement "legend" xs
    static member inline legend (value: float) = Interop.createElementWithChild "legend" value
    static member inline legend (value: int) = Interop.createElementWithChild "legend" value
    static member inline legend (value: ReactElement) = Interop.createElementWithChild "legend" value
    static member inline legend (value: string) = Interop.createElementWithChild "legend" value
    static member inline legend (children: #seq<ReactElement>) = Interop.createElementWithChildren "legend" children

    static member inline li xs = Interop.createElement "li" xs
    static member inline li (value: float) = Interop.createElementWithChild "li" value
    static member inline li (value: int) = Interop.createElementWithChild "li" value
    static member inline li (value: ReactElement) = Interop.createElementWithChild "li" value
    static member inline li (value: string) = Interop.createElementWithChild "li" value
    static member inline li (children: #seq<ReactElement>) = Interop.createElementWithChildren "li" children
    [<Obsolete "Html.line is obsolete, use Svg.line instead">]
    static member inline line xs = Interop.createElement "line" xs
    [<Obsolete "Html.line is obsolete, use Svg.line instead">]
    static member inline line (children: #seq<ReactElement>) = Interop.createElementWithChildren "line" children
    [<Obsolete "Html.linearGradient is obsolete, use Svg.linearGradient instead">]
    static member inline linearGradient xs = Interop.createElement "linearGradient" xs
    [<Obsolete "Html.linearGradient is obsolete, use Svg.linearGradient instead">]
    static member inline linearGradient (children: #seq<ReactElement>) = Interop.createElementWithChildren "linearGradient" children

    static member inline link xs = Interop.createElement "link" xs

    static member inline listItem xs = Interop.createElement "li" xs
    static member inline listItem (value: float) = Interop.createElementWithChild "li" value
    static member inline listItem (value: int) = Interop.createElementWithChild "li" value
    static member inline listItem (value: ReactElement) = Interop.createElementWithChild "li" value
    static member inline listItem (value: string) = Interop.createElementWithChild "li" value
    static member inline listItem (children: #seq<ReactElement>) = Interop.createElementWithChildren "li" children

    static member inline main xs = Interop.createElement "main" xs
    static member inline main (children: #seq<ReactElement>) = Interop.createElementWithChildren "main" children

    static member inline map xs = Interop.createElement "map" xs
    static member inline map (children: #seq<ReactElement>) = Interop.createElementWithChildren "map" children

    static member inline mark xs = Interop.createElement "mark" xs
    static member inline mark (value: float) = Interop.createElementWithChild "mark" value
    static member inline mark (value: int) = Interop.createElementWithChild "mark" value
    static member inline mark (value: ReactElement) = Interop.createElementWithChild "mark" value
    static member inline mark (value: string) = Interop.createElementWithChild "mark" value
    static member inline mark (children: #seq<ReactElement>) = Interop.createElementWithChildren "mark" children
    [<Obsolete "Html.marker is obsolete, use Svg.marker instead">]
    static member inline marker xs = Interop.createElement "marker" xs
    [<Obsolete "Html.marker is obsolete, use Svg.marker instead">]
    static member inline marker (children: #seq<ReactElement>) = Interop.createElementWithChildren "marker" children
    [<Obsolete "Html.mask is obsolete, use Svg.mask instead">]
    static member inline mask xs = Interop.createElement "mask" xs
    [<Obsolete "Html.mask is obsolete, use Svg.mask instead">]
    static member inline mask (children: #seq<ReactElement>) = Interop.createElementWithChildren "mask" children

    static member inline meta xs = Interop.createElement "meta" xs

    static member inline metadata xs = Interop.createElement "metadata" xs
    static member inline metadata (children: #seq<ReactElement>) = Interop.createElementWithChildren "metadata" children

    static member inline meter xs = Interop.createElement "meter" xs
    static member inline meter (value: float) = Interop.createElementWithChild "meter" value
    static member inline meter (value: int) = Interop.createElementWithChild "meter" value
    static member inline meter (value: ReactElement) = Interop.createElementWithChild "meter" value
    static member inline meter (value: string) = Interop.createElementWithChild "meter" value
    static member inline meter (children: #seq<ReactElement>) = Interop.createElementWithChildren "meter" children
    [<Obsolete "Html.mpath is obsolte, use Svg.mpath instead">]
    static member inline mpath xs = Interop.createElement "mpath" xs
    [<Obsolete "Html.mpath is obsolte, use Svg.mpath instead">]
    static member inline mpath (children: #seq<ReactElement>) = Interop.createElementWithChildren "mpath" children
    static member inline nav xs = Interop.createElement "nav" xs
    static member inline nav (children: #seq<ReactElement>) = Interop.createElementWithChildren "nav" children

    /// The empty element, renders nothing on screen
    static member inline none : ReactElement = unbox null

    static member inline noscript xs = Interop.createElement "noscript" xs
    static member inline noscript (children: #seq<ReactElement>) = Interop.createElementWithChildren "noscript" children

    static member inline object xs = Interop.createElement "object" xs
    static member inline object (children: #seq<ReactElement>) = Interop.createElementWithChildren "object" children

    static member inline ol xs = Interop.createElement "ol" xs
    static member inline ol (children: #seq<ReactElement>) = Interop.createElementWithChildren "ol" children

    static member inline option xs = Interop.createElement "option" xs
    static member inline option (value: float) = Interop.createElementWithChild "option" value
    static member inline option (value: int) = Interop.createElementWithChild "option" value
    static member inline option (value: ReactElement) = Interop.createElementWithChild "option" value
    static member inline option (value: string) = Interop.createElementWithChild "option" value
    static member inline option (children: #seq<ReactElement>) = Interop.createElementWithChildren "option" children

    static member inline optgroup xs = Interop.createElement "optgroup" xs
    static member inline optgroup (children: #seq<ReactElement>) = Interop.createElementWithChildren "optgroup" children

    static member inline orderedList xs = Interop.createElement "ol" xs
    static member inline orderedList (children: #seq<ReactElement>) = Interop.createElementWithChildren "ol" children

    static member inline output xs = Interop.createElement "output" xs
    static member inline output (value: float) = Interop.createElementWithChild "output" value
    static member inline output (value: int) = Interop.createElementWithChild "output" value
    static member inline output (value: ReactElement) = Interop.createElementWithChild "output" value
    static member inline output (value: string) = Interop.createElementWithChild "output" value
    static member inline output (children: #seq<ReactElement>) = Interop.createElementWithChildren "output" children

    static member inline p xs = Interop.createElement "p" xs
    static member inline p (value: float) = Interop.createElementWithChild "p" value
    static member inline p (value: int) = Interop.createElementWithChild "p" value
    static member inline p (value: ReactElement) = Interop.createElementWithChild "p" value
    static member inline p (value: string) = Interop.createElementWithChild "p" value
    static member inline p (children: #seq<ReactElement>) = Interop.createElementWithChildren "p" children

    static member inline paragraph xs = Interop.createElement "p" xs
    static member inline paragraph (value: float) = Interop.createElementWithChild "p" value
    static member inline paragraph (value: int) = Interop.createElementWithChild "p" value
    static member inline paragraph (value: ReactElement) = Interop.createElementWithChild "p" value
    static member inline paragraph (value: string) = Interop.createElementWithChild "p" value
    static member inline paragraph (children: #seq<ReactElement>) = Interop.createElementWithChildren "p" children

    static member inline param xs = Interop.createElement "param" xs
    [<Obsolete "Html.path is obsolete, use Svg.path instead">]
    static member inline path xs = Interop.createElement "path" xs
    [<Obsolete "Html.path is obsolete, use Svg.path instead">]
    static member inline path (children: #seq<ReactElement>) = Interop.createElementWithChildren "path" children
    [<Obsolete "Html.pattern is obsolete, use Svg.pattern instead">]
    static member inline pattern xs = Interop.createElement "pattern" xs
    [<Obsolete "Html.pattern is obsolete, use Svg.pattern instead">]
    static member inline pattern (children: #seq<ReactElement>) = Interop.createElementWithChildren "pattern" children
    static member inline picture xs = Interop.createElement "picture" xs
    static member inline picture (children: #seq<ReactElement>) = Interop.createElementWithChildren "picture" children
    [<Obsolete "Html.polygon is obsolete, use Svg.polygon instead">]
    static member inline polygon xs = Interop.createElement "polygon" xs
    [<Obsolete "Html.polygon is obsolete, use Svg.polygon instead">]
    static member inline polygon (children: #seq<ReactElement>) = Interop.createElementWithChildren "polygon" children
    [<Obsolete "Html.polyline is obsolete, use Svg.polyline instead">]
    static member inline polyline xs = Interop.createElement "polyline" xs
    [<Obsolete "Html.polyline is obsolete, use Svg.polyline instead">]
    static member inline polyline (children: #seq<ReactElement>) = Interop.createElementWithChildren "polyline" children
    static member inline pre xs = Interop.createElement "pre" xs
    static member inline pre (value: bool) = Interop.createElementWithChild "pre" value
    static member inline pre (value: float) = Interop.createElementWithChild "pre" value
    static member inline pre (value: int) = Interop.createElementWithChild "pre" value
    static member inline pre (value: ReactElement) = Interop.createElementWithChild "pre" value
    static member inline pre (value: string) = Interop.createElementWithChild "pre" value
    static member inline pre (children: #seq<ReactElement>) = Interop.createElementWithChildren "pre" children

    static member inline progress xs = Interop.createElement "progress" xs
    static member inline progress (children: #seq<ReactElement>) = Interop.createElementWithChildren "progress" children

    static member inline q xs = Interop.createElement "q" xs
    static member inline q (children: #seq<ReactElement>) = Interop.createElementWithChildren "q" children
    [<Obsolete "Html.radialGradient is obsolete, use Svg.radialGradient instead">]
    static member inline radialGradient xs = Interop.createElement "radialGradient" xs
    [<Obsolete "Html.radialGradient is obsolete, use Svg.radialGradient instead">]
    static member inline radialGradient (children: #seq<ReactElement>) = Interop.createElementWithChildren "radialGradient" children

    static member inline rb xs = Interop.createElement "rb" xs
    static member inline rb (value: float) = Interop.createElementWithChild "rb" value
    static member inline rb (value: int) = Interop.createElementWithChild "rb" value
    static member inline rb (value: ReactElement) = Interop.createElementWithChild "rb" value
    static member inline rb (value: string) = Interop.createElementWithChild "rb" value
    static member inline rb (children: #seq<ReactElement>) = Interop.createElementWithChildren "rb" children
    [<Obsolete "Html.rect is obsolete, use Svg.rect instead">]
    static member inline rect xs = Interop.createElement "rect" xs
    [<Obsolete "Html.rect is obsolete, use Svg.rect instead">]
    static member inline rect (children: #seq<ReactElement>) = Interop.createElementWithChildren "rect" children

    static member inline rp xs = Interop.createElement "rp" xs
    static member inline rp (value: float) = Interop.createElementWithChild "rp" value
    static member inline rp (value: int) = Interop.createElementWithChild "rp" value
    static member inline rp (value: ReactElement) = Interop.createElementWithChild "rp" value
    static member inline rp (value: string) = Interop.createElementWithChild "rp" value
    static member inline rp (children: #seq<ReactElement>) = Interop.createElementWithChildren "rp" children

    static member inline rt xs = Interop.createElement "rt" xs
    static member inline rt (value: float) = Interop.createElementWithChild "rt" value
    static member inline rt (value: int) = Interop.createElementWithChild "rt" value
    static member inline rt (value: ReactElement) = Interop.createElementWithChild "rt" value
    static member inline rt (value: string) = Interop.createElementWithChild "rt" value
    static member inline rt (children: #seq<ReactElement>) = Interop.createElementWithChildren "rt" children

    static member inline rtc xs = Interop.createElement "rtc" xs
    static member inline rtc (value: float) = Interop.createElementWithChild "rtc" value
    static member inline rtc (value: int) = Interop.createElementWithChild "rtc" value
    static member inline rtc (value: ReactElement) = Interop.createElementWithChild "rtc" value
    static member inline rtc (value: string) = Interop.createElementWithChild "rtc" value
    static member inline rtc (children: #seq<ReactElement>) = Interop.createElementWithChildren "rtc" children

    static member inline ruby xs = Interop.createElement "ruby" xs
    static member inline ruby (value: float) = Interop.createElementWithChild "ruby" value
    static member inline ruby (value: int) = Interop.createElementWithChild "ruby" value
    static member inline ruby (value: ReactElement) = Interop.createElementWithChild "ruby" value
    static member inline ruby (value: string) = Interop.createElementWithChild "ruby" value
    static member inline ruby (children: #seq<ReactElement>) = Interop.createElementWithChildren "ruby" children

    static member inline s xs = Interop.createElement "s" xs
    static member inline s (value: float) = Interop.createElementWithChild "s" value
    static member inline s (value: int) = Interop.createElementWithChild "s" value
    static member inline s (value: ReactElement) = Interop.createElementWithChild "s" value
    static member inline s (value: string) = Interop.createElementWithChild "s" value
    static member inline s (children: #seq<ReactElement>) = Interop.createElementWithChildren "s" children

    static member inline samp xs = Interop.createElement "samp" xs
    static member inline samp (value: float) = Interop.createElementWithChild "samp" value
    static member inline samp (value: int) = Interop.createElementWithChild "samp" value
    static member inline samp (value: ReactElement) = Interop.createElementWithChild "samp" value
    static member inline samp (value: string) = Interop.createElementWithChild "samp" value
    static member inline samp (children: #seq<ReactElement>) = Interop.createElementWithChildren "samp" children

    static member inline script xs = Interop.createElement "script" xs
    static member inline script (children: #seq<ReactElement>) = Interop.createElementWithChildren "script" children

    static member inline section xs = Interop.createElement "section" xs
    static member inline section (children: #seq<ReactElement>) = Interop.createElementWithChildren "section" children

    static member inline select xs = Interop.createElement "select" xs
    static member inline select (children: #seq<ReactElement>) = Interop.createElementWithChildren "select" children
    [<Obsolete "Html.set is obsolete, use Svg.set instead">]
    static member inline set xs = Interop.createElement "set" xs
    [<Obsolete "Html.set is obsolete, use Svg.set instead">]
    static member inline set (children: #seq<ReactElement>) = Interop.createElementWithChildren "set" children

    static member inline small xs = Interop.createElement "small" xs
    static member inline small (value: float) = Interop.createElementWithChild "small" value
    static member inline small (value: int) = Interop.createElementWithChild "small" value
    static member inline small (value: ReactElement) = Interop.createElementWithChild "small" value
    static member inline small (value: string) = Interop.createElementWithChild "small" value
    static member inline small (children: #seq<ReactElement>) = Interop.createElementWithChildren "small" children

    static member inline source xs = Interop.createElement "source" xs

    static member inline span xs = Interop.createElement "span" xs
    static member inline span (value: float) = Interop.createElementWithChild "span" value
    static member inline span (value: int) = Interop.createElementWithChild "span" value
    static member inline span (value: ReactElement) = Interop.createElementWithChild "span" value
    static member inline span (value: string) = Interop.createElementWithChild "span" value
    static member inline span (children: #seq<ReactElement>) = Interop.createElementWithChildren "span" children
    [<Obsolete "Html.stop is obsolete, use Svg.stop instead">]
    static member inline stop xs = Interop.createElement "stop" xs
    [<Obsolete "Html.stop is obsolete, use Svg.stop instead">]
    static member inline stop (children: #seq<ReactElement>) = Interop.createElementWithChildren "stop" children

    static member inline strong xs = Interop.createElement "strong" xs
    static member inline strong (value: float) = Interop.createElementWithChild "strong" value
    static member inline strong (value: int) = Interop.createElementWithChild "strong" value
    static member inline strong (value: ReactElement) = Interop.createElementWithChild "strong" value
    static member inline strong (value: string) = Interop.createElementWithChild "strong" value
    static member inline strong (children: #seq<ReactElement>) = Interop.createElementWithChildren "strong" children

    static member inline style xs = Interop.createElement "style" xs
    static member inline style (value: string) = Interop.createElementWithChild "style" value

    static member inline sub xs = Interop.createElement "sub" xs
    static member inline sub (value: float) = Interop.createElementWithChild "sub" value
    static member inline sub (value: int) = Interop.createElementWithChild "sub" value
    static member inline sub (value: ReactElement) = Interop.createElementWithChild "sub" value
    static member inline sub (value: string) = Interop.createElementWithChild "sub" value
    static member inline sub (children: #seq<ReactElement>) = Interop.createElementWithChildren "sub" children

    static member inline summary xs = Interop.createElement "summary" xs
    static member inline summary (value: float) = Interop.createElementWithChild "summary" value
    static member inline summary (value: int) = Interop.createElementWithChild "summary" value
    static member inline summary (value: ReactElement) = Interop.createElementWithChild "summary" value
    static member inline summary (value: string) = Interop.createElementWithChild "summary" value
    static member inline summary (children: #seq<ReactElement>) = Interop.createElementWithChildren "summary" children

    static member inline sup xs = Interop.createElement "sup" xs
    static member inline sup (value: float) = Interop.createElementWithChild "sup" value
    static member inline sup (value: int) = Interop.createElementWithChild "sup" value
    static member inline sup (value: ReactElement) = Interop.createElementWithChild "sup" value
    static member inline sup (value: string) = Interop.createElementWithChild "sup" value
    static member inline sup (children: #seq<ReactElement>) = Interop.createElementWithChildren "sup" children

    [<Obsolete "Html.svg is obsolete, use Svg.svg instead where Svg is the entry point to all SVG related elements">]
    static member inline svg xs = Interop.createElement "svg" xs
    [<Obsolete "Html.svg is obsolete, use Svg.svg instead where Svg is the entry point to all SVG related elements">]
    static member inline svg (children: #seq<ReactElement>) = Interop.createElementWithChildren "svg" children
    [<Obsolete "Html.switch is obsolete, use Svg.switch instead">]
    static member inline switch xs = Interop.createElement "switch" xs
    [<Obsolete "Html.switch is obsolete, use Svg.switch instead">]
    static member inline switch (children: #seq<ReactElement>) = Interop.createElementWithChildren "switch" children
    [<Obsolete "Html.symbol is obsolete, use Svg.symbol instead">]
    static member inline symbol xs = Interop.createElement "symbol" xs
    [<Obsolete "Html.symbol is obsolete, use Svg.symbol instead">]
    static member inline symbol (children: #seq<ReactElement>) = Interop.createElementWithChildren "symbol" children

    static member inline table xs = Interop.createElement "table" xs
    static member inline table (children: #seq<ReactElement>) = Interop.createElementWithChildren "table" children

    static member inline tableBody xs = Interop.createElement "tbody" xs
    static member inline tableBody (children: #seq<ReactElement>) = Interop.createElementWithChildren "tbody" children

    static member inline tableCell xs = Interop.createElement "td" xs
    static member inline tableCell (children: #seq<ReactElement>) = Interop.createElementWithChildren "td" children

    static member inline tableHeader xs = Interop.createElement "th" xs
    static member inline tableHeader (children: #seq<ReactElement>) = Interop.createElementWithChildren "th" children

    static member inline tableRow xs = Interop.createElement "tr" xs
    static member inline tableRow (children: #seq<ReactElement>) = Interop.createElementWithChildren "tr" children

    static member inline tbody xs = Interop.createElement "tbody" xs
    static member inline tbody (children: #seq<ReactElement>) = Interop.createElementWithChildren "tbody" children

    static member inline td xs = Interop.createElement "td" xs
    static member inline td (value: float) = Interop.createElementWithChild "td" value
    static member inline td (value: int) = Interop.createElementWithChild "td" value
    static member inline td (value: ReactElement) = Interop.createElementWithChild "td" value
    static member inline td (value: string) = Interop.createElementWithChild "td" value
    static member inline td (children: #seq<ReactElement>) = Interop.createElementWithChildren "td" children

    static member inline template xs = Interop.createElement "template" xs
    static member inline template (children: #seq<ReactElement>) = Interop.createElementWithChildren "template" children

    [<Obsolete "Html.text is obsolete for creating <text> SVG elements. Use Svg.text instead">]
    static member inline text xs = Interop.createElement "text" xs
    static member inline text (value: float) : ReactElement = unbox value
    static member inline text (value: int) : ReactElement = unbox value
    static member inline text (value: string) : ReactElement = unbox value
    static member inline text (value: System.Guid) : ReactElement = unbox (string value)

    static member inline textf fmt = Printf.kprintf Html.text fmt

    static member inline textarea xs = Interop.createElement "textarea" xs
    static member inline textarea (children: #seq<ReactElement>) = Interop.createElementWithChildren "textarea" children
    [<Obsolete "Html.textPath is obsolete, use Svg.textPath instead">]
    static member inline textPath xs = Interop.createElement "textPath" xs
    [<Obsolete "Html.textPath is obsolete, use Svg.textPath instead">]
    static member inline textPath (children: #seq<ReactElement>) = Interop.createElementWithChildren "textPath" children

    static member inline tfoot xs = Interop.createElement "tfoot" xs
    static member inline tfoot (children: #seq<ReactElement>) = Interop.createElementWithChildren "tfoot" children

    static member inline th xs = Interop.createElement "th" xs
    static member inline th (value: float) = Interop.createElementWithChild "th" value
    static member inline th (value: int) = Interop.createElementWithChild "th" value
    static member inline th (value: ReactElement) = Interop.createElementWithChild "th" value
    static member inline th (value: string) = Interop.createElementWithChild "th" value
    static member inline th (children: #seq<ReactElement>) = Interop.createElementWithChildren "th" children

    static member inline thead xs = Interop.createElement "thead" xs
    static member inline thead (children: #seq<ReactElement>) = Interop.createElementWithChildren "thead" children

    static member inline time xs = Interop.createElement "time" xs
    static member inline time (children: #seq<ReactElement>) = Interop.createElementWithChildren "time" children
    static member inline title xs = Interop.createElement "title" xs
    static member inline title (value: float) = Interop.createElementWithChild "title" value
    static member inline title (value: int) = Interop.createElementWithChild "title" value
    static member inline title (value: ReactElement) = Interop.createElementWithChild "title" value
    static member inline title (value: string) = Interop.createElementWithChild "title" value
    static member inline title (children: #seq<ReactElement>) = Interop.createElementWithChildren "title" children
    static member inline tr xs = Interop.createElement "tr" xs
    static member inline tr (children: #seq<ReactElement>) = Interop.createElementWithChildren "tr" children

    static member inline track xs = Interop.createElement "track" xs
    [<Obsolete "Html.tspan is obsolete, use Svg.tspan instead">]
    static member inline tspan xs = Interop.createElement "tspan" xs
    [<Obsolete "Html.tspan is obsolete, use Svg.tspan instead">]
    static member inline tspan (children: #seq<ReactElement>) = Interop.createElementWithChildren "tspan" children

    static member inline u xs = Interop.createElement "u" xs
    static member inline u (value: float) = Interop.createElementWithChild "u" value
    static member inline u (value: int) = Interop.createElementWithChild "u" value
    static member inline u (value: ReactElement) = Interop.createElementWithChild "u" value
    static member inline u (value: string) = Interop.createElementWithChild "u" value
    static member inline u (children: #seq<ReactElement>) = Interop.createElementWithChildren "u" children

    static member inline ul xs = Interop.createElement "ul" xs
    static member inline ul (children: #seq<ReactElement>) = Interop.createElementWithChildren "ul" children

    static member inline unorderedList xs = Interop.createElement "ul" xs
    static member inline unorderedList (children: #seq<ReactElement>) = Interop.createElementWithChildren "ul" children
    [<Obsolete "Html.use is obsolete, use Svg.use instead">]
    static member inline use' xs = Interop.createElement "use" xs
    [<Obsolete "Html.use is obsolete, use Svg.use instead">]
    static member inline use' (children: #seq<ReactElement>) = Interop.createElementWithChildren "use" children
    static member inline var xs = Interop.createElement "var" xs
    static member inline var (value: float) = Interop.createElementWithChild "var" value
    static member inline var (value: int) = Interop.createElementWithChild "var" value
    static member inline var (value: ReactElement) = Interop.createElementWithChild "var" value
    static member inline var (value: string) = Interop.createElementWithChild "var" value
    static member inline var (children: #seq<ReactElement>) = Interop.createElementWithChildren "var" children

    static member inline video xs = Interop.createElement "video" xs
    static member inline video (children: #seq<ReactElement>) = Interop.createElementWithChildren "video" children
    [<Obsolete "Html.view is obsolete, use Svg.view instead">]
    static member inline view xs = Interop.createElement "view" xs
    [<Obsolete "Html.view is obsolete, use Svg.view instead">]
    static member inline view (children: #seq<ReactElement>) = Interop.createElementWithChildren "view" children

    static member inline wbr xs = Interop.createElement "wbr" xs
