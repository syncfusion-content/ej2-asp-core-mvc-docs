---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize The Datepicker Day Header of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize The Datepicker Day Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the datepicker day header

You can change the format of the day that to be displayed in header using [dayHeaderFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_DayHeaderFormat) property.

> By default, the format is `Short`.

You can find the possible formats on below.

| **Name** | **Description** |
|------|---------------------|
| `Short` | Sets the short format of day name (like Su ) in day header. |
| `Narrow` | Sets the single character of day name (like S ) in day header. |
| `Abbreviated` | Sets the min format of day name (like Sun ) in day header. |
| `Wide` | Sets the long format of day name (like Sunday ) in day header. |

{% aspTab template="datepicker/how-to/headerformat"%}

{% endaspTab %}

Output be like the below.

![datepicker](../images/narrow.png)

![datepicker](../images/abbreviated.png)