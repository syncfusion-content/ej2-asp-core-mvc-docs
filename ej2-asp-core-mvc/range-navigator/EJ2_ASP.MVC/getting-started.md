---
layout: post
title: Getting Started with ##Platform_Name## Range Navigator Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Range Navigator control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Range Navigator Control

This section briefly explains about how to include [ASP.NET MVC Range Navigator](https://www.syncfusion.com/aspnet-mvc-ui-controls/range-selector) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC Range Navigator control

Now, add the Syncfusion ASP.NET MVC Range Navigator control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@(Html.EJS().RangeNavigator("container").Render())

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Range Navigator control will be rendered in the default web browser.

![ASP.NET MVC Range Navigator Control](images/rangenavigator-control.png)

## Populate range navigator with data

Now, we are going to provide data to the range navigator. Add a series object to the range navigator by using series property. Now map the field names x and y in the JSON data to the [xName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_XName) and [yName](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_YName) properties of the [series](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_Series), then set the JSON data to dataSource property. Since the JSON contains Datetime data, set the [valueType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.RangeNavigator.html#Syncfusion_EJ2_Charts_RangeNavigator_ValueType) as `DateTime`. By default, the axis valueType is Numeric.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/range-navigator/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<data> dataSource = new List<data>
        {
            new data { x = new DateTime(2005, 01, 01), y = 21, y1 = 28 },
            new data { x = new DateTime(2006, 01, 01), y = 24, y1 = 44 },
            new data { x = new DateTime(2007, 01, 01), y = 36, y1 = 48 },
            new data { x = new DateTime(2008, 01, 01), y = 38, y1 = 50 },
            new data { x = new DateTime(2009, 01, 01), y = 54, y1 = 66 },
            new data { x = new DateTime(2010, 01, 01), y = 57, y1 = 78 },
            new data { x = new DateTime(2011, 01, 01), y = 70, y1 = 84 },
        };
        return View(dataSource);
    }
}
public class data
{
    public DateTime x;
    public double y;
    public double y1;
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Range Navigator Control](images/rn.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/RangeNavigator/ASP.NET%20MVC%20Razor%20Examples).