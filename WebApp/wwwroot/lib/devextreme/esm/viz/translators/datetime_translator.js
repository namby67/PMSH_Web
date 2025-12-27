/**
 * DevExtreme (esm/viz/translators/datetime_translator.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import dateUtils from "../../core/utils/date";

function parse(value) {
    return null !== value ? new Date(value) : value
}
export default {
    fromValue: parse,
    toValue: parse,
    _add: dateUtils.addDateInterval,
    convert: dateUtils.dateToMilliseconds
};
