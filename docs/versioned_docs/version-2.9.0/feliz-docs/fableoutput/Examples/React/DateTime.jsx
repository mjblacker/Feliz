import React from "react";
import { reactElement, reactApi } from "../../fable_modules/Feliz.2.9.0/Interop.fs.js";
import { toString } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Date.js";
import { iterate, singleton, append, delay, toList } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Seq.js";
import { createObj } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Util.js";
import { toArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/Option.js";
import { parse } from "../../fable_modules/Feliz.2.9.0/DateParsing.fs.js";
import { ofArray } from "../../fable_modules/fable-library-js.5.0.0-alpha.13/List.js";

export function SwitchingBetweenDateAndDateTime() {
    const patternInput = reactApi.useState(undefined);
    const setDate = patternInput[1];
    const date = patternInput[0];
    const patternInput_1 = reactApi.useState(false);
    const toggleDateAndTime = patternInput_1[1];
    const dateAndTime = patternInput_1[0];
    let formattedDate;
    if (date != null) {
        const date_1 = date;
        formattedDate = ("Input: " + toString(date_1, "yyyy-MM-dd hh:mm"));
    }
    else {
        formattedDate = "No date selected yet";
    }
    const children = toList(delay(() => append(singleton(reactElement("h3", {
        children: [formattedDate],
    })), delay(() => {
        let value_1, date_2, value_8, date_3;
        return append(dateAndTime ? singleton(reactElement("input", createObj(ofArray([(value_1 = date, (value_1 != null) ? ((date_2 = value_1, dateAndTime ? ["value", toString(date_2, "yyyy-MM-ddThh:mm")] : ["value", toString(date_2, "yyyy-MM-dd")])) : ["value", ""]), ["type", "datetime-local"], ["onChange", (ev) => {
            const value_6 = ev.target.value;
            iterate((newValue) => {
                setDate(newValue);
            }, toArray(parse(value_6)));
        }]])))) : singleton(reactElement("input", createObj(ofArray([(value_8 = date, (value_8 != null) ? ((date_3 = value_8, dateAndTime ? ["value", toString(date_3, "yyyy-MM-ddThh:mm")] : ["value", toString(date_3, "yyyy-MM-dd")])) : ["value", ""]), ["type", "date"], ["onChange", (ev_1) => {
            const value_13 = ev_1.target.value;
            iterate((newValue_1) => {
                setDate(newValue_1);
            }, toArray(parse(value_13)));
        }]])))), delay(() => append(singleton(reactElement("button", {
            children: "Reset selected date",
            disabled: date == null,
            onClick: (_arg) => {
                setDate(undefined);
            },
        })), delay(() => singleton(reactElement("button", {
            children: "Toggle date and time",
            disabled: date == null,
            onClick: (_arg_1) => {
                toggleDateAndTime(!dateAndTime);
            },
        }))))));
    }))));
    return reactElement("div", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

export default SwitchingBetweenDateAndDateTime;

