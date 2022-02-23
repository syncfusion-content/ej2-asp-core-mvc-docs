---
title: "Play an audio before open the ASP.NET MVC Toast"
component: "Toast"
description: "This example demonstrates how to play audio in the background while opening the Syncfusion ASP.NET MVC Toast control."
---

# Play an audio before open the toast

The following sample demonstrates how to play an audio in background while opening the toast by including audio play codes into the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event function.

> To stop the audio after displaying the toast, use the [`Open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Open) event in toast. For further customization, check the Toast Events APIs.

{% aspTab template="toast/audio", sourceFiles="controller.cs" %}

{% endaspTab %}
