---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Prevent Closing Of Modal Dialog of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Prevent Closing Of Modal Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent closing of modal Dialog

You can prevent closing of modal dialog by setting the [`beforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeClose) event argument cancel value to true.
In the following sample, the dialog is closed when you enter the username value with minimum 4 characters. Otherwise, it will not be closed.

{% aspTab template="dialog/how-to/validation", sourceFiles="controller.cs" %}

{% endaspTab %}