/**
 * DevExtreme (esm/renovation/ui/scheduler/appointment_edit_form/edit_form/layout_items/dateBox.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import {
    getRenderEditorTemplate
} from "../utils/renderTemplate";
export var getDateBoxLayoutItemConfig = (editorTemplate, dataField, colSpan, labelText) => ({
    dataField: dataField,
    colSpan: colSpan,
    label: {
        text: labelText
    },
    validationRules: [{
        type: "required"
    }],
    template: getRenderEditorTemplate(editorTemplate)
});
