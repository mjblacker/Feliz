import React from "react";
import { reactElement, reactApi } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import { singleton } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/AsyncBuilder.js";
import { startImmediate, sleep } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Async.js";
import { singleton as singleton_1, delay, toList } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Seq.js";

export function EffectWithAsyncOnce() {
    const patternInput = reactApi.useState(false);
    const setLoading = patternInput[1];
    const isLoading = patternInput[0];
    const patternInput_1 = reactApi.useState("");
    const setContent = patternInput_1[1];
    const content = patternInput_1[0];
    const loadData = () => singleton.Delay(() => {
        setLoading(true);
        return singleton.Bind(sleep(1500), () => {
            setLoading(false);
            setContent("Content");
            return singleton.Zero();
        });
    });
    reactApi.useEffect(() => {
        startImmediate(loadData());
    }, []);
    const children = toList(delay(() => (isLoading ? singleton_1(reactElement("h1", {
        children: ["Loading..."],
    })) : singleton_1(reactElement("h1", {
        children: [content],
    })))));
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

export default EffectWithAsyncOnce;

