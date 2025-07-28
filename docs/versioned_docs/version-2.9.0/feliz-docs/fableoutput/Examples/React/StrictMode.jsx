import { reactApi, reactElement } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import { Component } from "react";
import React from "react";
import { class_type, obj_type } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Reflection.js";
import { createObj } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Util.js";
import { ofArray, singleton } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/List.js";

export class StrictModeWarning extends Component {
    constructor() {
        super(undefined);
    }
    componentWillMount() {
    }
    render() {
        return reactElement("div", {
            children: "I cause a warning!",
        });
    }
}

export function StrictModeWarning_$reflection() {
    return class_type("Example.StrictMode.StrictModeWarning", undefined, StrictModeWarning, class_type("Fable.React.Component`2", [obj_type, obj_type], Component));
}

export function StrictModeWarning_$ctor() {
    return new StrictModeWarning();
}

export function StrictModeExample() {
    let elems, children;
    return reactElement("div", createObj(ofArray([["style", {
        display: "inherit",
    }], (elems = [(children = singleton((() => {
        throw 1;
    })()), reactApi.createElement(reactApi.StrictMode, undefined, ...children))], ["children", reactApi.Children.toArray(Array.from(elems))])])));
}

export default StrictModeExample;

