---
title: "Date Formats"
component: "DatePicker"
description: "Date picker supports to format date object into specific string format to simplify the date representation. It adapts to any culture specific date formats when it is globalized."
---

# Date Format

Date format is a way of representing the date value in different string format in textbox.

By default the DatePicker's format is based on the culture. You can also set the own
custom format by using the
[format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Format)
property.

> Once the date format property has been defined it will be common to all the cultures.

To know more about the date format standards, refer to the
[`Internationalization Date Format`](../common/internationalization/) section.

The following example demonstrates the DatePicker with the custom format (`yyyy-MM-dd`).

{% aspTab template="datepicker/date-format", sourceFiles="date-format.cs" %}

{% endaspTab %}