---
title: "Custom animation for popup mode"
component: "In-place Editor"
description: "Learn how to configure custom animation for popup and customize it dynamically in the Syncfusion ASP.NET MVC In-place Editor control."
---

# Set custom animation for popup mode

In popup mode, the In-place Editor rendered with the Syncfusion ASP.NET MVC `Tooltip` control. You can use tooltip properties and events to customize the popup by configure properties into the [`Model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property inside the [`PopupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_PopupSettings) API.

In the following sample, popup animation can be customized by passing animation effect using the `Model` property and the dynamic animation effect changes configured from the Syncfusion ASP.NET MVC `DropDownList` control `change` event.

{% aspTab template="in-place-editor/custom-animation", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![custom-animation](../../in-place-editor/images/custom-animation.PNG)