---
title: "ASP.NET MVC Toast Time out"
component: "Toast"
description: "This section explains how to set time-out value for the Toast control, which is used to display toast till the time-out reaches without user interaction."
---

# Time out

The toast can be expired based on the [`TimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) property. The toast can live till the time out reaches without user interaction, a time out value is considered as a millisecond.

* The `TimeOut` delay can be visually represented using `Progress Bar`.

* The [`ExtendedTimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ExtendedTimeout) property determines how long the toast should be displayed after a user hovers over it.

> You can terminate the process by using the [`ShowCloseButton`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ShowCloseButton) property for destroying the toast at any time.

{% aspTab template="toast/timeout", sourceFiles="controller.cs" %}

{% endaspTab %}

## Static toast

You can prevent auto hiding in a toast as visible like static by setting zero (`0`) value in the [`TimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) Property.

{% aspTab template="toast/static", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [How to close the toast with click/tab](./how-to/close-the-toast-with-click-tap/)
