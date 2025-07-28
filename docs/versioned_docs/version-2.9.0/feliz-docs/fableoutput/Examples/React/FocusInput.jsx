import React from "react";
import { reactElement, reactApi } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import { ofArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/List.js";

export function FullFocusInputExample() {
    const inputRef = reactApi.useRef(undefined);
    const focusTextInput = () => {
        const matchValue = inputRef.current;
        if (matchValue != null) {
            const element = matchValue;
            const inputElement = element;
            inputElement.focus();
        }
    };
    const children = ofArray([reactElement("input", {
        ref: inputRef,
        type: "text",
    }), reactElement("button", {
        onClick: (_arg) => {
            focusTextInput();
        },
        children: "Focus Input",
    })]);
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

export default FullFocusInputExample;

