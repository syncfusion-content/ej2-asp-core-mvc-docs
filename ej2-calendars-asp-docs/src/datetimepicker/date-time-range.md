---
title: "Date Time Range"
component: "DateTimePicker"
description: "Date time picker has `min` and `max` properties which restricts the user from selecting a value out of given min/max datetime range"
---

# DateTime Range

DateTimePicker provides an option to select a date and time value within a specified range
by using the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Min)
and [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Max)properties.
Always the min value has to be lesser than the max value.

When the min and max properties are configured and the selected datetime value is out-of-range
or invalid, then the model value will be set to `out of range` datetime value or `null`
respectively with highlighted `error` class to indicates the datetime is out of range or invalid

The value property depends
on the min/max with respect to [strictMode](./strict-mode/) property.

The below example allows selecting a
date within the range from 7th to 27th day in
a month.

{% aspTab template="datetimepicker/datetime-range", sourceFiles="datetimerange.cs" %}

{% endaspTab %}

> If the value of `min` or `max` properties
changed through code behind, then you have to
update the `value` property to set within the
range.