---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Prevent Duplicate Toast Display of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Prevent Duplicate Toast Display
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent duplicate toast display

You can prevent identical same toast displaying in a screen by the event function and terminate the toast displaying process by setting the cancel event property in the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

The following sample demonstrates preventing duplicate title toast element displaying with custom code blocks.

{% aspTab template="toast/duplicate", sourceFiles="controller.cs" %}

{% endaspTab %}