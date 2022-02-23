---
title: "Calendar Views"
component: "Calendar"
description: "Pre-defined views in calendar allows to perform easy navigation to select any date."
---

# Calendar Views

The Calendar has the following pre-defined views
that provide a flexible way to navigate back and forth when selecting dates.

| **View** | **Description** |
| --- | --- |
| month (default) | Displays the days in a month. |
| year | Displays the months in a year. |
| decade | Displays the years in a decade. |

When view is defined to the [start](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Start)
property of the Calendar, it allows you to set the initial view on rendering.

The following example demonstrates how to set the `year` as the start view of the Calendar.

{% aspTab template="calendar/calendar-view/views", sourceFiles="views.cs" %}

{% endaspTab %}

## View restriction

By defining the start and depth property with the different view, drill-
down and drill-up views navigation can be limited to the user. Calendar views will be drill-down up to the view which is set in [depth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Depth) property and drill-up up to the view which is set in [start](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Start) property.

The following example displays the Calendar in `decade` view, and allows you to select a date in `month` view.

> Depth view should always be smaller than the start view. If the `depth` and `start` views are the same, then the Calendar view remains unchanged.

{% aspTab template="calendar/calendar-view/restriction", sourceFiles="restriction.cs" %}

{% endaspTab %}
