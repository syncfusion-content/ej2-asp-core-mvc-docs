---
title: "Prevent duplicate ASP.NET MVC Toast display"
component: "Toast"
description: "This example demonstrates how to prevent the identical same Syncfusion ASP.NET MVC Toast is displayed on a screen."
---

# Prevent duplicate toast display

You can prevent identical same toast displaying in a screen by the event function and terminate the toast displaying process by setting the cancel event property in the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

The following sample demonstrates preventing duplicate title toast element displaying with custom code blocks.

{% aspTab template="toast/duplicate", sourceFiles="controller.cs" %}

{% endaspTab %}