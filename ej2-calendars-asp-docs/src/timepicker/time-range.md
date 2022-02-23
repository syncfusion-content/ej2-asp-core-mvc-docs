---
title: "Time Range"
component: "TimePicker"
description: "Time picker has `min` and `max` properties which restricts the user from selecting a value out of given time range"
---

# Time Range

TimePicker provides an option to select a time value within a specified range by using the
[min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Min)
and
[max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Max)
properties. The min value should always be
lesser than the max value.

When the min and max properties are configured and the selected time value is out-of-range or
invalid, then the model value will be set to `out of range` time value or `null` respectively
with highlighted `error` class to indicates the time is out of range or invalid.

The value property depends on the min/max with respect to [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_StrictMode) property.
The following example allows you to select a time value within a range of `9:00 AM` to `11:30 AM`.

{% aspTab template="timepicker/time-range/", sourceFiles="timerange.cs" %}

{% endaspTab %}

> If the value of `min` or `max` property is changed through code behind you have to
update the `value` property to set within the range.

## Time Range customization using two TimePicker components

Here, two TimePicker components are used to select the start and end time. The below sample illustrates the appointment time selection scenario with the start and end time option.

Before the start time selection, the end time TimePicker is in disable state. When the start time is selected, then you will be able to select the end time or else, need to select the entire business hours 9:00 to 18:00 from the Business Hours option. Once the options are checked, both the TimePicker components goes to readonly state.

{% aspTab template="timepicker/time-range-customization/", sourceFiles="timerange-customization.cs" %}

{% endaspTab %}