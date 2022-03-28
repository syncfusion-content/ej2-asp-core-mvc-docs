---
layout: post
title: Getting Started with ##Platform_Name## Sparkline Control
description: Checkout and learn about getting started with ##Platform_Name## Sparkline control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include [ASP.NET Core Sparkline](https://www.syncfusion.com/aspnet-core-ui-controls/sparkline) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Sparkline Control

Now, add the Syncfusion ASP.NET Core Sparkline tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-sparkline id="sparkline">
</ejs-sparkline>

{% endhighlight %}
{% endtabs %}

## Bind data source to Sparkline

The `dataSource` property is used for binding data source to the sparkline. This property takes the collection value as input. For example, the list of objects can be provided as input.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/data-source/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/data-source/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-source.cs" %}
{% include code-snippet/sparkline/getting-started/data-source/data-source.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Sparkline control will be rendered in the default web browser.

![ASP.NET Core Sparkline Control](images/sparkline-control.png)

## Change the type of Sparkline

You can change the sparkline type by setting the `type` property to `Line`, `Column`, `WinLoss`, `Pie`, or `Area`. Here, the sparkline type has been set to `area`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Type.cs" %}
{% include code-snippet/sparkline/getting-started/type/type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core Area Sparkline](images/area-sparkline.png)

## Enable tooltip for Sparkline

The sparkline displays additional information through tooltip when the mouse is hovered over the sparkline. You can enable tooltip by setting the `visible` property to true in `tooltipSettings` object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
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

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/getting-started/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/sparkline/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core Sparkline with Tooltip](images/sparkline-with-tooltip.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/SparkLine/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)