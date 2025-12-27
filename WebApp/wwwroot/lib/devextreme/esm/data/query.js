/**
 * DevExtreme (esm/data/query.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import {
    queryImpl
} from "./query_implementation";
var query = function() {
    var impl = Array.isArray(arguments[0]) ? "array" : "remote";
    return queryImpl[impl].apply(this, arguments)
};
export default query;
