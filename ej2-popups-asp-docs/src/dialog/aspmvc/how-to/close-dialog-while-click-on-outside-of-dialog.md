---
title: "Close ASP.NET MVC Dialog when click outside of its region"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Close Dialog when click outside of its region

By default, dialog can be closed by pressing Esc key and clicking the close icon on the right of dialog header. It can also be closed by clicking outside of the dialog using hide method.
Set the [`CloseOnEscape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_CloseOnEscape) property value to false to prevent closing of the dialog when pressing Esc key.

In the following sample, dialog is closed when clicking outside the dialog area using `hide` method.

{% aspTab template="dialog/how-to/outside-click", sourceFiles="controller.cs" %}

{% endaspTab %}