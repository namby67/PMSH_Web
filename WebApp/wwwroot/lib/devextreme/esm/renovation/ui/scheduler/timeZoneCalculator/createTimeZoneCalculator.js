/**
 * DevExtreme (esm/renovation/ui/scheduler/timeZoneCalculator/createTimeZoneCalculator.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import {
    TimeZoneCalculator
} from "./utils";
import timeZoneUtils from "../../../../ui/scheduler/utils.timeZone";
export var createTimeZoneCalculator = currentTimeZone => new TimeZoneCalculator({
    getClientOffset: date => timeZoneUtils.getClientTimezoneOffset(date),
    tryGetCommonOffset: date => timeZoneUtils.calculateTimezoneByValue(currentTimeZone, date),
    tryGetAppointmentOffset: (date, appointmentTimezone) => timeZoneUtils.calculateTimezoneByValue(appointmentTimezone, date)
});
