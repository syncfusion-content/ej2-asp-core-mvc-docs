---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Header Rows of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Header Rows
publishingplatform: ##Platform_Name##
documentation: ug
---


# Timeline header rows

The Timeline views can have additional header rows other than its default date and time header rows. It is possible to show individual header rows for displaying year, month and week separately using the `HeaderRows` property. This property is applicable only on the timeline views. The possible rows which can be added using `HeaderRows` property are as follows.

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

To display the timeline Scheduler simply with year and month names alone, define the option `Year` and `Month` within the `HeaderRows` property.

{% aspTab template="schedule/header-rows/year-month", sourceFiles="data.cs"  %}

{% endaspTab %}

## Display week numbers in timeline views

The week number can be displayed in a separate header row of the timeline Scheduler by setting `Week` option within `HeaderRows` property.

{% aspTab template="schedule/header-rows/week-number", sourceFiles="data.cs"  %}

{% endaspTab %}

## Timeline view displaying dates of a complete year

It is possible to display a complete year in a timeline view by setting `Interval` value as 12 and defining **TimelineMonth** view option within the `Views` property of Scheduler.

{% aspTab template="schedule/header-rows/complete-year", sourceFiles="data.cs"  %}

{% endaspTab %}

## Customizing the header rows using template

You can customize the text of the header rows and display any images or formatted text on each individual header rows using the built-in `Template` option available within the `HeaderRows` property.

{% aspTab template="schedule/header-rows/header-row-template", sourceFiles="data.cs"  %}

{% endaspTab %}

> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.
