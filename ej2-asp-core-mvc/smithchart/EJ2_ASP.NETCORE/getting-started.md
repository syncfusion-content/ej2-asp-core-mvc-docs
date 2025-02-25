---
layout: post
title: Getting Started with ##Platform_Name## Smithchart Control
description: Checkout and learn about getting started with ##Platform_Name## Smithchart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core SmithChart Control

This section briefly explains about how to include [ASP.NET Core SmithChart](https://www.syncfusion.com/aspnet-core-ui-controls/smith-chart) control in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template)

## Install ASP.NET Core package in the application

To add `ASP.NET Core` controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.  Alternatively, you can utilize the following package manager command to achieve the same.

{% tabs %}
{% highlight C# tabtitle="Package Manager" %}

Install-Package Syncfusion.EJ2.AspNet.Core -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

N> Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion<sup style="font-size:70%">&reg;</sup> license key.

## Add Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Tag Helper

Open `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add script resources

Here, script is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

N> Checkout the [Adding Script Reference](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) topic to learn different approaches for adding script references in your ASP.NET Core application.

## Register Syncfusion<sup style="font-size:70%">&reg;</sup> Script Manager

Also, register the script manager `<ejs-script>` at the end of `<body>` in the ASP.NET Core application as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core SmithChart Control

Now, add the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core SmithChart tag helper in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<ejs-smithchart id="smithchart">
</ejs-smithchart>

{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core SmithChart control will be rendered in the default web browser.

![ASP.NET Core SmithChart Control](images/smithchart-control.png)

## Add series to Smith chart

The Smith chart has the following two type of specification for adding series:

* dataSource - Data object can be bound directly by specifying the resistance and reactance values.
* points - Collection of resistance and reactance values can be bound directly to render the series.

The following two ways demonstrate adding two series to the Smith chart.

* First series Transmission1 shows dataSource bound series.
* Second series Transmission2 shows points bound series.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/getting-started/series/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SmithChart with Series](images/smithchart-series.png)

## Add title to SmithChart

smithchart `title` API used to add title for smithchart. In that `text` API used to set text of the title. API `visible` used to toggle the title.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/getting-started/title/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SmithChart with Title](images/smithchart-with-title.png)

## Enable marker to the Smith chart

To use marker in series and its customization in Smith chart, use series `marker` API. To display marker for a particular series, specify the `marker visible` to true. The following sample marker is enabled for the first series only.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/getting-started/marker/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SmithChart with Marker](images/smithchart-with-marker.png)

## Enable data label to marker

To use marker data label and its customization in Smith chart, use marker `dataLabel`. To display data label for a particular series marker, specify the `dataLabel visible` to true in that series `marker`. The following sample data label is enabled for the first series.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/getting-started/data-label/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SmithChart with DataLabel](images/smithchart-with-datalabel.png)

## Enable legend for Smith chart

The legend feature is used to denote the corresponding series. You can enable the legend for the smithchart by setting the [`visible`] property to true in [`legendSettings`] object. The following sample shows enabling legend for Smith chart. The series name can be customized using the series `name`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/getting-started/legend/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Enable tooltip for the Smith chart series

The tooltip feature is used to show the values of the current point. You can enable tooltip by setting the [`visible`] property to true in [`tooltipSettings`] object. The following sample shows enabling tooltip for Smith chart series collection.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core SmithChart with Tooltip](images/smithchart-with-tooltip.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/SmithChart/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)