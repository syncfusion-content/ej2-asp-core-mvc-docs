---
title: "DropDownButton Popup Items"
component: "DropDownButton"
description: "DropDownButton allows the end user to customize the whole popup or action items in popup using templates, navigate to other pages on action item click."
---

# Popup items

## Icons

The popup action item have an icon or image to provide visual representation of the action. To place the icon on a popup item,
set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconCss) property to `e-icons` with the required icon CSS. By default, the icon is
positioned to the left side of the popup action item.

In the following sample, the icons for edit, delete, mark as read  and like message menu items are
added using the iconCss property.

{% aspTab template="dropdownbutton/popup-items/icons", sourceFiles="popupicons.cs" %}

{% endaspTab %}

## Navigations

Actions in DropDownButton can be used to navigate to the other web
page when action item is clicked. This can be achieved by
Popup items can be customized using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeItemRender) event. The item render event
providing link to the action item using `url` property.

In the following sample, navigation URL for Flipkart, Amazon, and
Snapdeal action items are added using the `url` property:

{% aspTab template="dropdownbutton/popup-items/navigation", sourceFiles="navigation.cs" %}

{% endaspTab %}

## Template

### Item templating

Popup items can be customized using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeItemRender) event. The item render event
triggers while rendering each popup action item. The event argument will be used to identify the action item and
customize based on the requirement.

In the following example, the icons in each li items is right aligned by appending span element in li rendering:

{% aspTab template="dropdownbutton/popup-items/item-template", sourceFiles="itemtemplate.cs" %}

{% endaspTab %}

### Popup Templating

The whole popup can be customized as per the requirement. In the following example, the popup can be
customized by handling it in [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Target) property.

{% aspTab template="dropdownbutton/popup-items/popup-template", sourceFiles="popuptemplate.cs" %}

{% endaspTab %}

## See Also

* [Integration with ListView component](./how-to/group-popup-items-with-listview-component)
