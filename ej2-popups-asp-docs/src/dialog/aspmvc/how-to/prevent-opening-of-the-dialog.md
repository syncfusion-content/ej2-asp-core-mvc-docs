---
title: "Prevent opening of the dialog"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Prevent opening of the dialog

You can prevent opening of the dialog by setting the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeOpen) event argument cancel value to true.
In the following sample, the success dialog is opened when you enter the username value with minimum 4 characters. Otherwise, it will not be opened.

{% aspTab template="dialog/how-to/dialog-check", sourceFiles="controller.cs" %}

{% endaspTab %}