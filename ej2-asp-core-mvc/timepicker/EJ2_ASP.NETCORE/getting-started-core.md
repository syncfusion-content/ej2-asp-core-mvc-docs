---
layout: post
title: Getting Started with ##Platform_Name## Timepicker Component
description: Checkout and learn about getting started with ##Platform_Name## Timepicker component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include a simple TimePicker control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-core) to know about registering Syncfusion license key in your ASP.NET Core application to use our controls.

## Initialize TimePicker control to the Application

TimePicker control can be rendered by using the `ejs-timepicker` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the TimePicker.

The following example shows a basic TimePicker control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/getting-started/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> Running the above code will display the basic TimePicker on the browser.

## Setting the value within min and max time

The following example demonstrates how to set the value, min and max time on initializing
the TimePicker. The TimePicker allows you to select the time value within a range from `1:00 AM` to `11:00 AM`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/getting-started/daterange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/timepicker/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/getting-started/daterange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/timepicker/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Setting the time format

Time formats is a way of representing the time value in different string format in textbox and popup
list. By default, the TimePicker's format is based on the culture. You can also customize the format by using the
[format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Format)
property. To know more about the time format standards, refer to the
[Date and Time Format](../../common/internationalization#custom-formats) section.

The following example demonstrates the TimePicker control in 24 hours format with 60 minutes
interval. The time interval is set to
60 minutes by using the [step](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Step) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/getting-started/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/timepicker/getting-started/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/getting-started/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/timepicker/getting-started/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Render TimePicker with min and max time](./time-range)
* [How to achieve validation with TimePicker](./how-to/client-side-validation-using-form-validator)
* [Render TimePicker with specific culture](./globalization)
