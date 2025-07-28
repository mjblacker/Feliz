import { forwardRef } from "../../fable_modules/Feliz.2.9.0/Internal.fs.js";
import { reactElement, reactApi } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import { toArray, map } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Option.js";
import { ofArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/List.js";
import React from "react";
import { iterate } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Seq.js";

export const ForwardRefImperativeChild = forwardRef((tupledArg) => {
    const ref = tupledArg[1];
    const patternInput = reactApi.useState("");
    const setDivText = patternInput[1];
    const divText = patternInput[0];
    const inputRef = reactApi.useRef(undefined);
    reactApi.useImperativeHandle(ref, (() => map((innerRef) => ({
        focus: () => {
            setDivText(innerRef.className);
        },
    }), inputRef.current)));
    const children = ofArray([reactElement("input", {
        className: "Howdy!",
        type: "text",
        ref: inputRef,
    }), reactElement("div", {
        children: divText,
    })]);
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
});

export function ForwardRefImperativeParent() {
    const ref = reactApi.useRef(undefined);
    const children = ofArray([ForwardRefImperativeChild([undefined, ref]), reactElement("button", {
        children: "Focus Input",
        onClick: (ev) => {
            iterate((elem) => {
                elem.focus();
            }, toArray(ref.current));
        },
    })]);
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

export default ForwardRefImperativeParent;

