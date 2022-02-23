---
title: "Read all values of Dialog on button click"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Read all values of Dialog on button click

You can read the dialog element values by binding the action handler to the footer buttons. The [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Buttons) property provides the options to bind events to the action buttons.
For detailed information about buttons , refer to the [`footer`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_FooterTemplate) section.
In the below sample, value of input elements within the dialog has been checked in the footer button click event and send the values as the content of confirmation dialog.

{% aspTab template="dialog/how-to/read-all", sourceFiles="controller.cs" %}

{% endaspTab %}