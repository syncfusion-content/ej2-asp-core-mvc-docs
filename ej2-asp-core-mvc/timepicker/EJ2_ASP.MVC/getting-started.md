---
layout: post
title: Getting Started with ASP.NET MVC TimePicker Control | Syncfusion
description: Checkout and learn about getting started with ASP.NET MVC TimePicker control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ej2-asp-core-mvc
documentation: ug
---


# Getting Started with ASP.NET MVC TimePicker Control

This section briefly explains about how to include [ASP.NET MVC TimePicker](https://www.syncfusion.com/aspnet-mvc-ui-controls/timepicker) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC TimePicker control

Now, add the Syncfusion ASP.NET MVC TimePicker control in `~/Views/Home/Index.cshtml` page.

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
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC TimePicker control will be rendered in the default web browser.

![ASP.NET MVC TimePicker Control](images/timepicker-control.png)

## Setting the value within min and max time

The following example demonstrates how to set the value, min and max time on initializing the TimePicker. The TimePicker allows you to select the time value within a range from `1:00 AM` to `11:00 AM`.

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
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    ViewBag.minVal = new DateTime(2022, 05, 07, 1, 00, 00);
    ViewBag.maxVal = new DateTime(2022, 05, 07, 11, 00, 00);
    ViewBag.value = new DateTime(2022, 05, 07, 4, 00, 00);
    return View();
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC TimePicker with Minimum and Maximum Values](images/timepicker-with-min-and-max-time.png)

## Setting the time format

Time formats is a way of representing the time value in different string format in textbox and popup list. By default, the TimePicker's format is based on the culture. You can also customize the format by using the [Format](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Format) property. To know more about the time format standards, refer to the [Date and Time Format](../../common/internationalization#custom-formats) section.

The following example demonstrates the TimePicker control in 24 hours format with 60 minutes interval. The time interval is set to 60 minutes by using the [Step](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_Step) property.

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
{% endtabs %}
{% endif %}

![ASP.NET MVC TimePicker with Time Format](images/timepicker-with-format.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/TimePicker/ASP.NET%20MVC%20Razor%20Examples).

## See also

* [Render TimePicker with min and max time](./time-range)
* [How to achieve validation with TimePicker](./how-to/client-side-validation-using-form-validator)
* [Render TimePicker with specific culture](./globalization)
* [How to get and set value in TimePickerFor](./how-to/timepicker-for-mvc)

N> You can also explore our [ASP.NET MVC TimePicker Example](https://ej2.syncfusion.com/aspnetmvc/TimePicker/DefaultFunctionalities#/bootstrap5) that shows you how to render the TimePicker in ASP.NET MVC.