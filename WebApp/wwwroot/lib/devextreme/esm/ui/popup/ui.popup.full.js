/**
 * DevExtreme (esm/ui/popup/ui.popup.full.js)
 * Version: 22.2.3
 * Build date: Mon Dec 05 2022
 *
 * Copyright (c) 2012 - 2022 Developer Express Inc. ALL RIGHTS RESERVED
 * Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
 */
import "../toolbar";
import Popup from "../popup/ui.popup";
import registerComponent from "../../core/component_registrator";
export default class PopupFull extends Popup {
    _getToolbarName() {
        return "dxToolbar"
    }
}
registerComponent("dxPopup", PopupFull);
