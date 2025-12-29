/**
 * DevExtreme (cjs/ui/scheduler/utils/isSchedulerComponent.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
"use strict";
exports.isSchedulerComponent = isSchedulerComponent;
var schedulerComponentName = "dxScheduler";

function isSchedulerComponent(component) {
    return component.NAME === schedulerComponentName
}
