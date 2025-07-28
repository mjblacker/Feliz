import { forwardRef } from "../../fable_modules/Feliz.2.9.0/Internal.fs.js";
import { reactApi, reactElement } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import React from "react";
import { iterate } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Seq.js";
import { toArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Option.js";
import { ofArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/List.js";

export const ForwardRefChild = forwardRef((tupledArg) => {
    const ref = tupledArg[1];
    return reactElement("input", {
        type: "text",
        ref: ref,
    });
});

export function ForwardRefParent() {
    const inputRef = reactApi.useRef(undefined);
    const children = ofArray([ForwardRefChild([undefined, inputRef]), reactElement("button", {
        children: "Focus Input",
        onClick: (ev) => {
            iterate((elem) => {
                elem.focus();
            }, toArray(inputRef.current));
        },
    })]);
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

export default ForwardRefParent;

