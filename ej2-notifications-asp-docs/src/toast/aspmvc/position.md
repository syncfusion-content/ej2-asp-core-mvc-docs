---
title: " ASP.NET MVC Toast Positions"
component: "Toast"
description: "The Toast control position section explains how to customize the toast position or update the toast predefined position."
---

# Positions

The toast position can be updated based on predefined positions or customizable positions. The predefined position combinations are updated in the `X` and `Y` [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Position) properties.

## Predefined

`X` Positions

* Left
* Center
* Right

`Y` Positions

* Top
* Bottom

> In multiple toast display, the new toast position will not be updated on dynamic change of property values until the old toast messages removed.
> The toast occupies full width when you set the width to '100%', so the X positions will not affect the changes when the width is '100%'.

## Custom

Custom `X` and `Y` positions can be given as pixels/numbers/percentage. The number value is considered as pixels based on the top and left values updated in the toast.

{% aspTab template="toast/positions", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [How to add dynamic template](./how-to/add-dynamic-template/)