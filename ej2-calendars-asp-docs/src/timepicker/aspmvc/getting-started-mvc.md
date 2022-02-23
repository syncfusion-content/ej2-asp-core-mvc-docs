---
title: "Getting Started"
component: "TimePicker"
description: "This getting started section briefly explains how to create a time picker component in an application."
---

# Getting Started

This section briefly explains about how to include a simple TimePicker control in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../../getting-started/) page for introduction part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-mvc) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Initialize TimePicker control to the Application

TimePicker control can be rendered by using the `EJS().TimePicker()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the TimePicker.

The following example shows a basic TimePicker control.

{% aspTab template="timepicker/getting-started/getting-started" %}

{% endaspTab %}

> Running the above code will display the basic TimePicker on the browser.

## Setting the value within min and max time

The following example demonstrates how to set the value, min and max time on initializing
the TimePicker. The TimePicker allows you to select the time value within a range from `1:00 AM` to `11:00 AM`.

{% aspTab template="timepicker/getting-started/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}

## Setting the time format

Time formats is a way of representing the time value in different string format in textbox and popup
list. By default, the TimePicker's format is based on the culture. You can also customize the format by using the
[format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Format)
property. To know more about the time format standards, refer to the
[Date and Time Format](../../common/internationalization#custom-formats) section.

The following example demonstrates the TimePicker control in 24 hours format with 60 minutes
interval. The time interval is set to
60 minutes by using the [step](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Step) property..

{% aspTab template="timepicker/getting-started/format/", sourceFiles="format.cs" %}

{% endaspTab %}

## See Also

* [Render TimePicker with min and max time](./time-range)
* [How to achieve validation with TimePicker](./how-to/client-side-validation-using-form-validator)
* [Render TimePicker with specific culture](./globalization)
