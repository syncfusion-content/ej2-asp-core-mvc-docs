---
title: "Getting Started"
component: "DatePicker"
description: "This getting started section briefly explains how to create a date picker component in an application."
---

# Getting Started

This section briefly explains how to include simple DatePicker control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-mvc) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Initialize DatePicker control to the Application

DatePicker control can be rendered by using the `EJS().DatePicker()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DatePicker.

The following example shows a basic DatePicker control.

{% aspTab template="datepicker/getting-started/getting-started" %}

{% endaspTab %}

> Running the above code will display the basic DatePicker on the browser.

## Setting the value within min and max dates

To restrict the selection of date within a specified range, use the min and max properties.

The below example demonstrates the DatePicker to select a date within a range from 5 to 27 in a current month.

{% aspTab template="datepicker/getting-started/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}

## See Also

* [Change the format of selected date](./date-format)
* [Render DatePicker with specific culture](./globalization)
* [How to change the initial view of the DatePicker](./view)
* [How to achieve validation with DatePicker](./how-to/client-side-validation)
