---
title: "Timeline header rows in ASP.Net Core Scheduler"
component: "Scheduler"
description: "This section explains how to display the additional header rows on timeline view of Scheduler."
---

# Timeline header rows

The Timeline views can have additional header rows other than its default date and time header rows. It is possible to show individual header rows for displaying year, month and week separately using the `headerRows` property. This property is applicable only on the timeline views. The possible rows which can be added using `headerRows` property are as follows.

* `Year`
* `Month`
* `Week`
* `Date`
* `Hour`

> The `Hour` row is not applicable for Timeline month view.

The following example shows the Scheduler displaying all the available header rows on timeline views.

{% aspTab template="schedule/header-rows/all-option", sourceFiles="data.cs"  %}

{% endaspTab %}

## Display year and month rows in timeline views

To display the timeline Scheduler simply with year and month names alone, define the option `Year` and `Month` within the `headerRows` property.

{% aspTab template="schedule/header-rows/year-month", sourceFiles="data.cs"  %}

{% endaspTab %}

## Display week numbers in timeline views

The week number can be displayed in a separate header row of the timeline Scheduler by setting `Week` option within `headerRows` property.

{% aspTab template="schedule/header-rows/week-number", sourceFiles="data.cs"  %}

{% endaspTab %}

## Timeline view displaying dates of a complete year

It is possible to display a complete year in a timeline view by setting `interval` value as 12 and defining **TimelineMonth** view option within the `e-schedule-views` tag helper of Scheduler.

{% aspTab template="schedule/header-rows/complete-year", sourceFiles="data.cs"  %}

{% endaspTab %}

## Customizing the header rows using template

You can customize the text of the header rows and display any images or formatted text on each individual header rows using the built-in `template` option available within the `headerRows` property.

{% aspTab template="schedule/header-rows/header-row-template", sourceFiles="data.cs"  %}

{% endaspTab %}

> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
