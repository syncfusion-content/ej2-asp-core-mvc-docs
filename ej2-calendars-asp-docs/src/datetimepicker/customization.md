---
title: "Customization"
component: "DateTimePicker"
description: "Date time picker gives complete control to the user to customize overall appearance of the date time picker in their application."
---

# Customization

The DateTimePicker is available for UI customization that can be achieved by using available properties and events in the component.

## Day and Time Cell format

The DateTimePicker is available for UI customization based on your application requirements.
It can be achieved by using [renderDayCell](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_RenderDayCell)
event that provides an option to customize each day cell on rendering.

The following example disables the weekends of every month by using `renderDayCell` event.

{% aspTab template="datetimepicker/daytimecellformat" %}

{% endaspTab %}

## See Also

* [How to disable the DateTimePicker control](./how-to/disable-the-datetimepicker-component)
* [How to customize the DateTimePicker day header](./how-to/customize-the-datetimepicker-day-header)