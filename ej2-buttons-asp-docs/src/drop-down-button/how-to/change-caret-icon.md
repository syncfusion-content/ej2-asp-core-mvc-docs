---
title: "Change caret icon"
component: "DropDownButton"
description: "DropDownButton how to section, hide drop down arrow, group popup items using list view component, dialog open on popup item click."
---

# Change caret icon

Dropdown arrow can be customized on popup open and close. It can be handled in
[`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeOpen) and
[`beforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeClose) event.

In the following example, the up arrow is updated on popup close and down arrow is updated
on popup open using `beforeOpen` and `beforeClose` event by adding and removing
`e-caret-up` class.

{% aspTab template="dropdownbutton/updown", sourceFiles="updown.cs" %}

{% endaspTab %}