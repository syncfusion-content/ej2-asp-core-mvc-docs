---
title: "How To"
component: "Calendar"
description: "Miscellaneous aspects of customizing the calendar"
---

# Set clear button

To configure `clear` button in Calendar UI, do the following:

1. To the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Created)
 event of the Calendar, add the required elements to make clear button visible. In the following example, div with Essential JS 2 button control is used.

2. When the `e-footer` class is used, the div tag acts as the footer.

3. Using these button, selected date can be cleared.

4. Bind the required event handler to the button tag to update the value.

{% aspTab template="calendar/howto/settoday" %}

{% endaspTab %}
