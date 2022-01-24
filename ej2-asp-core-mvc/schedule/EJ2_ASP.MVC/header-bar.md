---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Header Bar of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Header Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Header customization

The header part of Scheduler can be customized easily with the built-in options available.

## Show or Hide header bar

By default, the header bar holds the date and view navigation options, through which the user can switch between the dates and various views. This header bar can be hidden from the UI by setting `false` to the `ShowHeaderBar` property. It's default value is `true`.

{% aspTab template="schedule/header-bar/show-hide", sourceFiles="data.cs"  %}

{% endaspTab %}

## Customizing header bar

Apart from the default date navigation and view options available on the header bar, you can add custom items into the Scheduler header bar by making use of the `ActionBegin` event. Here, an employee image is added to the header bar, clicking on which will open the popup showing that person's short profile information.

{% aspTab template="schedule/header-bar/custom-header-bar", sourceFiles="data.cs"  %}

{% endaspTab %}

## How to display the view options within the header bar popup

By default, the header bar holds the view navigation options, through which the user can switch between various views. You can move this view options to the header bar popup by setting `true` to the `EnableAdaptiveUI` property.

{% aspTab template="schedule/header-bar/adaptive-ui", sourceFiles="data.cs"  %}

{% endaspTab %}

> Refer [here](./resources/#adaptive-ui-in-desktop) to know more about adaptive UI in resources scheduler.

## Date header customization

The Scheduler UI that displays the date text on all views are considered as the date header cells. You can customize the date header cells of Scheduler either using `DateHeaderTemplate` or `RenderCell` event.

### Using date header template

The `DateHeaderTemplate` option is used to customize the date header cells of day, week and work-week views.

{% aspTab template="schedule/header-bar/custom-date-header", sourceFiles="data.cs"  %}

{% endaspTab %}

### Using renderCell event

In month view, the date header template is not applicable and therefore the same customization can be added beside the date text in month cells by making use of the `RenderCell` event.

{% aspTab template="schedule/header-bar/render-cell", sourceFiles="data.cs"  %}

{% endaspTab %}

> You can refer to our [ASP.NET MVC Scheduler](https://www.syncfusion.com/aspnet-mvc-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Scheduler](https://ej2.syncfusion.com/aspnetmvc/Schedule/Overview#/material) example to knows how to present and manipulate data.
