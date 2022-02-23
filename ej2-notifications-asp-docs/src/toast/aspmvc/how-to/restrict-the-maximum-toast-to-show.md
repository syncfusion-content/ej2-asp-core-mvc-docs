---
title: "Restrict the maximum ASP.NET MVC Toast to show"
component: "Toast"
description: "This example demonstrates how to restrict the maximum Syncfusion ASP.NET MVC Toast count is displayed on a screen."
---

# Restrict the maximum toast to show

You can restrict the maximum toast count by using the event callback function and terminate the toast displaying process by setting the cancel event property in the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

The following sample demonstrates restricting toast displaying up to 3. You can restrict by your own count with custom code blocks.

{% aspTab template="toast/maximum", sourceFiles="controller.cs" %}

{% endaspTab %}