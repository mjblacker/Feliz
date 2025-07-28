import { iterate } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Seq.js";
import { disposeSafe } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Util.js";
import { toArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Option.js";

export function optDispose(disposeOption) {
    return {
        Dispose() {
            iterate((d) => {
                let copyOfStruct = d;
                disposeSafe(copyOfStruct);
            }, toArray(disposeOption));
        },
    };
}

