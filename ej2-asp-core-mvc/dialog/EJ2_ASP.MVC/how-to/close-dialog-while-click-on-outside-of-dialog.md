---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Close Dialog While Click On Outside Of Dialog of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Close Dialog While Click On Outside Of Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Close Dialog when click outside of its region

By default, dialog can be closed by pressing Esc key and clicking the close icon on the right of dialog header. It can also be closed by clicking outside of the dialog using hide method.
Set the [`CloseOnEscape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_CloseOnEscape) property value to false to prevent closing of the dialog when pressing Esc key.

In the following sample, dialog is closed when clicking outside the dialog area using `hide` method.

{% aspTab template="dialog/how-to/outside-click", sourceFiles="controller.cs" %}

{% endaspTab %}