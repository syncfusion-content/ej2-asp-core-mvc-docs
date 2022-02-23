---
title: "ASP.NET Core Toast Time out"
component: "Toast"
description: "This section explains how to set time-out value for the Toast control, which is used to display toast till the time-out reaches without user interaction."
---

# Time out

The toast can be expired based on the [`timeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) property. The toast can live till the time out reaches without user interaction, a time out value is considered as a millisecond.

* The `timeOut` delay can be visually represented using `Progress Bar`.

* The [`extendedTimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ExtendedTimeout) property determines how long the toast should be displayed after a user hovers over it.

> You can terminate the process by using the [`showCloseButton`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ShowCloseButton) property for destroying the toast at any time.

{% aspTab template="toast/timeout", sourceFiles="controller.cs" %}

{% endaspTab %}

## Static toast

You can prevent auto hiding in a toast as visible like static by setting zero (`0`) value in the [`timeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) Property.

{% aspTab template="toast/static", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [Hide the toast on click](./how-to/close-the-toast-with-click-tap/)