/**
 * DevExtreme (renovation/utils/type_conversion.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
"use strict";
exports.toNumber = toNumber;

function toNumber(attribute) {
    return attribute ? Number(attribute.replace("px", "")) : 0
}
