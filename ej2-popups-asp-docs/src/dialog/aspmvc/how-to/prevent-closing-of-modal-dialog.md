---
title: "Prevent closing of modal Dialog"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Prevent closing of modal Dialog

You can prevent closing of modal dialog by setting the [`BeforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_BeforeClose) event argument cancel value to true.
In the following sample, the dialog is closed when you enter the username value with minimum 4 characters. Otherwise, it will not be closed.

{% aspTab template="dialog/how-to/validation", sourceFiles="controller.cs" %}

{% endaspTab %}