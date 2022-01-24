---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include a simple DateTimePicker control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-core) to know about registering Syncfusion license key in your ASP.NET Core application to use our controls.

## Initialize DateTimePicker control to the Application

DateTimePicker control can be rendered by using the `ejs-datetimepicker` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DateTimePicker.

The following example shows a basic DateTimePicker control

{% aspTab template="datetimepicker/getting-started/getting-started" %}

{% endaspTab %}

> Running the above code will display the basic DateTimePicker on the browser.

## Setting the min and max

The minimum and maximum date time can be defined with the help of `min` and `max` property.
The following example demonstrates to set the `min` and `max` on initializing the
DateTimePicker.

{% aspTab template="datetimepicker/getting-started/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}

## See Also

* [Render DateTimePicker with specific culture](./globalization)
* [How to get and set value in DateTimePickerFor](./how-to/datetimepicker-for-core)
