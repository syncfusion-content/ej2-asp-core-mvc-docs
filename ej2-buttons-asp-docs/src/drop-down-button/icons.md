---
title: "DropDownButton Icons"
component: "DropDownButton"
description: "DropDownButton allows the end user to place the icons/sprite images in DropDownButton."
---

# Icons and Styles

## DropDownButton icons

DropDownButton can have an icon to provide the visual representation of the action. To place the icon on a DropDownButton,
set the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconCss) property to `e-icons` with the required icon CSS. By default,
the icon is positioned to the left side of the DropDownButton. You can customize the icon's position using
the [`iconPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconPosition) property.

In the following example, the DropDownButton with default iconPosition and iconPosition as `Top` is showcased:

{% aspTab template="dropdownbutton/icons/icon-btn", sourceFiles="iconbutton.cs" %}

{% endaspTab %}

> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element.
You can also use third party icons on the DropDownButton using the [`iconCss`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_IconCss) property.

### Vertical button

Vertical button in DropDownButton can be achieved by adding `e-vertical` class using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_CssClass) property.

{% aspTab template="dropdownbutton/icons/vertical-btn", sourceFiles="verticalbutton.cs" %}

{% endaspTab %}

## See Also

* [Dropdown popup with icons](./popup-items#icons)
* [Customized icon size](./how-to/customize-icon-and-width)