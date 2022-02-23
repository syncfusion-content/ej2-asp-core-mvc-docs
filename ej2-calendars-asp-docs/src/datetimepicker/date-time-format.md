---
title: "DateTime Formats"
component: "DateTimePicker"
description: "Date time picker supports to format date object into specific string format to simplify the date and time representation. It adapts to any culture specific date and time formats when it is globalized."
---

# DateTime Format

DateTime format is a way of representing the date and time value in different string format in textbox.

By default the DateTimePicker's format is based on the culture. You can also set the own
custom format by using the
[`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Format)
property.

> Once the date format property has been defined it will be common to all the cultures.

To know more about the date and time format standards, refer to the
[`Internationalization Date Time Format`](/common/internationalization/) section.

The following example demonstrates the DateTimePicker with the custom format (`yyyy-MM-dd hh:mm`).

{% aspTab template="datetimepicker/date-time-format", sourceFiles="date-time-format.cs" %}

{% endaspTab %}