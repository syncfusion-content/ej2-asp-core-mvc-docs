---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Restrict The Maximum Toast To Show of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Restrict The Maximum Toast To Show
publishingplatform: ##Platform_Name##
documentation: ug
---


# Restrict the maximum toast to show

You can restrict the maximum toast count by using the event callback function and terminate the toast displaying process by setting the cancel event property in the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

The following sample demonstrates restricting toast displaying up to 3. You can restrict by your own count with custom code blocks.

{% aspTab template="toast/maximum", sourceFiles="controller.cs" %}

{% endaspTab %}