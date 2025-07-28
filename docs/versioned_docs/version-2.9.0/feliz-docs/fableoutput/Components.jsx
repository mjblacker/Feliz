import { useState } from "react";
import React from "react";
import { defaultArg } from "./fable_modules/fable-library-js.5.0.0-alpha.13/Option.js";
import { printf, toText } from "./fable_modules/fable-library-js.5.0.0-alpha.13/String.js";

export function Counter(counterInputProps) {
    const init = counterInputProps.init;
    const init_1 = defaultArg(init, 0) | 0;
    const patternInput = useState(init_1);
    const setCounter = patternInput[1];
    const counter = patternInput[0] | 0;
    return <div>
        <h1>
            Counter
        </h1>
        <p>
            {toText(printf("Current count: %d"))(counter)}
        </p>
        <button onClick={(_arg) => {
                setCounter(counter + 1);
            }}>
            Increment
        </button>
        <button onClick={(_arg_1) => {
                setCounter(counter - 1);
            }}>
            Decrement
        </button>
    </div>;
}

