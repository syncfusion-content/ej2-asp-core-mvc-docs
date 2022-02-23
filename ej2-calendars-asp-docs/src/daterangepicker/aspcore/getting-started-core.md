---
title: "Getting Started"
component: "DateRangePicker"
description: "This getting started section briefly explains how to create a date range picker component in an application."
---

# Getting Started

This section briefly explains how to include a simple DateRangePicker control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-core) to know about registering Syncfusion license key in your ASP.NET Core application to use our controls.

## Initialize DateRangePicker control to the Application

DateRangePicker control can be rendered by using the `ejs-daterangepicker` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DateRangePicker.

The following example shows a basic DateRangePicker control

{% aspTab template="daterangepicker/getting-started/getting-started" %}

{% endaspTab %}

> Running the above code will display the basic DateRangePicker on the browser.

## Setting the start and end date

The start and end date in a range can be defined with the help of startDate and endDate property.
The following example demonstrates to set the start and end date on initializing the
DateRangePicker.

{% aspTab template="daterangepicker/getting-started/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}

## See Also

* [Render DateRangePicker with range restriction](./range-restriction)
* [Render DateRangePicker with specific culture](./globalization)
