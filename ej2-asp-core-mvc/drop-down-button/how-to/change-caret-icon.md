---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Change Caret Icon of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Change Caret Icon
publishingplatform: ##Platform_Name##
documentation: ug
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