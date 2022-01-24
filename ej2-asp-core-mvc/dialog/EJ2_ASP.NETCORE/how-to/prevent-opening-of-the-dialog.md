---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Prevent Opening Of The Dialog of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Prevent Opening Of The Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent opening of the Dialog

You can prevent opening of the dialog by setting the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeOpen) event argument cancel value to true.
In the following sample, the success dialog is opened when you enter the username value with minimum 4 characters. Otherwise, it will not be opened.

{% aspTab template="dialog/how-to/dialog-check", sourceFiles="controller.cs" %}

{% endaspTab %}