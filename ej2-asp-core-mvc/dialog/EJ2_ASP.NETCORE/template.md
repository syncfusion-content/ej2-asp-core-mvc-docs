---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Template of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template

In Dialog the template support is provided to the header, footer and content sections. So any text or HTML content can be appending in these sections.

## Header

The Dialog header content can be provided through the
[`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property, and it will allow both text and any HTML content as a string.
Also in header, close button is provided as built-in support, and this can be enabled through
the [`showCloseIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ShowCloseIcon) property.

## Footer

The Dialog footer can be enabled by adding built-in [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) or providing any HTML string through the [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate).

> The [`buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) and [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) properties can't be used at the same time.

## Content

The Dialog content can be provided through the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property, and it accepts both text and HTML string as content
by using `e-content-template` tag helper.

The below example demonstrates the usage of header, footer and content templates in the Dialog control.

{% aspTab template="dialog/template/footer", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](./images/dialog-template.png)

## See Also

* [How to add an icon to dialog buttons](./how-to/add-an-icons-to-dialog-buttons)
* [How to customize the dialog appearance](./how-to/customize-the-dialog-appearance)
