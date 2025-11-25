/**
 * DevExtreme (esm/renovation/ui/scheduler/appointment_edit_form/edit_form/layout_items/description.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import {
    getRenderEditorTemplate
} from "../utils/renderTemplate";
export var getDescriptionLayoutItemConfig = (editorTemplate, dataField, label) => ({
    dataField: dataField,
    colSpan: 2,
    label: {
        text: label
    },
    template: getRenderEditorTemplate(editorTemplate)
});
