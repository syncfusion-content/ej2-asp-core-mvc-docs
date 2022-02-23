---
title: "Dynamically move input to edit mode"
component: "In-place Editor"
description: "Learn how to dynamically move input to edit mode in the Syncfusion ASP.NET MVC In-place Editor control."
---

# Dynamically move input to edit mode

At control initial load, if you want to open editor state without interacting In-place Editor input element, it can be achieved by configuring the [`EnableEditMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_EnableEditMode) property to `true`.

In the following sample, editor opened at initial load and when toggling a checkbox, it will remove or open the editor.

{% aspTab template="in-place-editor/dynamic-edit", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![dynamic-edit](../../in-place-editor/images/dynamic-edit.PNG)