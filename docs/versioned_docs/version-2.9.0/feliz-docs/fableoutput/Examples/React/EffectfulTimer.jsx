import { useState } from "react";
import React from "react";
import { reactElement, reactApi } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import { useEffectWithDeps } from "../../fable_modules/Feliz.2.9.0/ReactInterop.js";
import { createObj } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Util.js";
import { singleton, delay, toList } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Seq.js";
import { ofArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/List.js";

export function EffectfulTimer() {
    const patternInput = reactApi.useState(false);
    const setPaused = patternInput[1];
    const paused = patternInput[0];
    const patternInput_1 = useState(0);
    const value = patternInput_1[0] | 0;
    const setValue = patternInput_1[1];
    const subscribeToTimer = () => {
        const subscriptionId = setInterval(() => {
            if (!paused) {
                setValue((prev) => ((prev + 1) | 0));
            }
        }, 1000) | 0;
        return {
            Dispose() {
                clearInterval(subscriptionId);
            },
        };
    };
    useEffectWithDeps(subscribeToTimer, [paused]);
    const children = ofArray([reactElement("h1", {
        children: [value],
    }), reactElement("button", {
        style: createObj(toList(delay(() => (paused ? singleton(["backgroundColor", "yellow"]) : singleton(["backgroundColor", "green"]))))),
        onClick: (_arg_1) => {
            setPaused(!paused);
        },
        children: paused ? "Resume" : "Pause",
    })]);
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

export default EffectfulTimer;

