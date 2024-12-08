---
layout: post
title: Getting Started with ##Platform_Name## Sparkline Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Sparkline control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Sparkline Control

This section briefly explains about how to include [ASP.NET MVC Sparkline](https://www.syncfusion.com/aspnet-mvc-ui-controls/sparkline) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started#create-your-first-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

To add `ASP.NET MVC` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.MVC5 -Version {{ site.ej2version }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it.

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add script resources

Here, the script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetmvc/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET MVC application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> script manager

Also, register the script manager `EJS().ScriptManager()` at the end of `<body>` in the `~/Pages/Shared/_Layout.cshtml` file as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Sparkline control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sparkline control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<h2> Essential JS 2 for ASP.NET MVC Sparkline </h2>
@Html.EJS().Sparkline("spark").DataSource(Model).XName("xval").YName("yval").Height("100").Width("70").Render()

{% endhighlight %}
{% highlight cs tabtitle="HomeController.cs" %}
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(DataSource.GetData());
    }
}
public class DataSource
{
    public int x;
    public string xval;
    public double yval;
    public static List<DataSource> GetData()
    {
        List<DataSource> data1 = new List<DataSource>();
        data1.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
        data1.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
        data1.Add(new DataSource() { x = 2, xval = "2007", yval = 20434180 });
        data1.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
        data1.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
        data1.Add(new DataSource() { x = 5, xval = "2010", yval = 21515750 });
        data1.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
        data1.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
        data1.Add(new DataSource() { x = 8, xval = "2013", yval = 22262500 });
        data1.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
        return data1;
    }
}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Sparkline control will be rendered in the default web browser.

![ASP.NET MVC Sparkline Control](images/sparkline.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/Sparkline/ASP.NET%20MVC%20Razor%20Examples).