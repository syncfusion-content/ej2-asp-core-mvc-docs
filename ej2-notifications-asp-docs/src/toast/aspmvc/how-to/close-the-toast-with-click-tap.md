---
title: "Close the ASP.NET MVC Toast with click/tap"
component: "Toast"
description: "This example demonstrates how to close the Syncfusion ASP.NET Core Toast control with a click or tap operation."
---

# Close the toast with click/tap

By default, the toasts are expired based on the [`TimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) value. You can customize the toast hiding process with `click/tap` action by setting the event args in the `clicked` callback function with `static Toast`.

{% aspTab template="toast/click", sourceFiles="controller.cs" %}

{% endaspTab %}