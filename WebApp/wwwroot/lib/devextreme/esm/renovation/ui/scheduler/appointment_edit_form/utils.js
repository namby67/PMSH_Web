/**
 * DevExtreme (esm/renovation/ui/scheduler/appointment_edit_form/utils.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import {
    isDefined
} from "../../../../core/utils/type";
import dateLocalization from "../../../../localization/date";
export var getFirstDayOfWeek = firstDayOfWeek => isDefined(firstDayOfWeek) ? firstDayOfWeek : dateLocalization.firstDayOfWeekIndex();
