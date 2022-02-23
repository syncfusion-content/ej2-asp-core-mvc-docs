---
title: "Date Range"
component: "Calendar"
description: "Calendar has `min` and `max` properties which restricts the user from selecting a value out of given min/max date range"
---

# Date Range

Calendar provides an option to select a date value within a specified range by defining the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Min)  and [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Max) properties. The min date should always be lesser than the max date. If the value of `min` or `max` properties are changed
through code behind, then update the `value` property to be set within the  specified range. Or else, if the value is out of specified date range and less than `min` date, value property will be updated with min date or the value is higher than max date, value property will be updated with `max` date.

The following example allows you to select a date within the range of 7th to 27th days in a month.

{% aspTab template="calendar/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}