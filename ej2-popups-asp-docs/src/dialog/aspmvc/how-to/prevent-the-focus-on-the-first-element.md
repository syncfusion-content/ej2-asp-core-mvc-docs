---
title: "Prevent the focus on the first element"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Prevent the focus on the first element

By default, the dialog focuses on the first elements of the content area which can be active and focusable. You can prevent this default focusing behavior using the [`Open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Open) event and by enabling the `preventFocus` argument.

Bind the open event and enable the preventFocus argument within an event like the below example.

{% aspTab template="dialog/how-to/dlg-focus", sourceFiles="controller.cs" %}

{% endaspTab %}