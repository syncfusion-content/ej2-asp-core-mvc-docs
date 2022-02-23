---
title: "Choose a date in range"
component: "DatePicker"
description: "Date picker has `min` and `max` properties which restricts the user from selecting a value out of given min/max date range"
---

# Date Range

DatePicker provides an option to select a date value within a specified range by using the
[min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Min)
and
[max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Max)
properties. Always the min value has to be
lesser than the max value.

When the min and max properties are configured and the selected date value is out-of-range or
invalid, then the model value will be set to `out of range` date value or `null` respectively
with highlighted `error` class to indicates the date is out of range or invalid.

The value property depends
on the min/max with respect to [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_StrictMode) property.

The below example allows selecting a
date within the range from 7th to 27th day in
a month.

{% aspTab template="datepicker/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}

> If the value of `min` or `max` properties
changed through code behind, then you have to
update the `value` property to set within the
range.