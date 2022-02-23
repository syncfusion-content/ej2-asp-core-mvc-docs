---
title: "SplitButton Popup Items"
component: "SplitButton"
description: "SplitButton allows the end user to customize the whole popup or action items in popup using templates, and to place icons in popup items."
---

# Popup Items

## Icons

The Popup action item have an icon or image to provide visual representation of the action. To place the icon on a popup
item, set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_IconCss) property to `e-icons` with the required icon CSS. By default, the icon is positioned to the left side of the popup action item.

In the following sample, the icons for Cut, Copy, Paste, Undo and Redo menu items are
added using the iconCss property.

{% aspTab template="split-button/popup-items/icons", sourceFiles="popupicons.cs" %}

{% endaspTab %}

## Template

### Item Templating

Popup items can be customized by using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_BeforeItemRender) event. The item render event triggers while rendering each Popup
action item. The event argument will be used to identify the action item and customize it based on the requirement.

{% aspTab template="split-button/popup-items/item-template", sourceFiles="itemtemplate.cs" %}

{% endaspTab %}

### Popup Templating

The whole popup can be customized as per the requirement. In the following example, the popup can be
customized by handling it in [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Target) property.

{% aspTab template="split-button/popup-items/popup-template", sourceFiles="popuptemplate.cs" %}

{% endaspTab %}

## See Also

* [Popup items grouping](./how-to/group-items-in-popup)