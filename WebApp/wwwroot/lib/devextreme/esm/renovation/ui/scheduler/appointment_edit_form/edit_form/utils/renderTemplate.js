/**
 * DevExtreme (esm/renovation/ui/scheduler/appointment_edit_form/edit_form/utils/renderTemplate.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import {
    renderTemplate
} from "@devextreme/runtime/inferno";
export var getRenderEditorTemplate = editorTemplate => (item, container) => {
    renderTemplate(() => editorTemplate, {
        item: item,
        container: container
    }, null)
};
