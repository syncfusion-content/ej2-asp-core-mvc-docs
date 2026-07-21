---
layout: post
title: Getting Started with ASP.NET Core Linear Gauge Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Linear Gauge control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Linear Gauge
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Linear Gauge Control

This section briefly explains how to include the [ASP.NET Core Linear Gauge](https://www.syncfusion.com/aspnet-core-ui-controls/linear-gauge) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add **ASP.NET Core Linear Gauge** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.LinearGauge](https://www.nuget.org/packages/Syncfusion.AspNetCore.LinearGauge/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.LinearGauge -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.LinearGauge` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.LinearGauge

{% endhighlight %}
{% endtabs %}

## Add script resources

The theme stylesheet and script can be referenced from the [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** 

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.LinearGauge/scripts/sf-linear-gauge.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the script manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    <!-- ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Linear Gauge control

Add the [ASP.NET Core Linear Gauge](https://www.syncfusion.com/aspnet-core-ui-controls/linear-gauge) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-lineargauge id="linear">
</ejs-lineargauge>

{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Linear Gauge](https://www.syncfusion.com/aspnet-core-ui-controls/linear-gauge) will render in your default web browser.

![ASP.NET Core Linear Gauge Control](images/lineargauge-control.webp)

## Add Gauge Title

The title for the Linear Gauge can be rendered using the `title` property in the `ejs-lineargauge` tag.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-lineargauge id="linear" title="Temperature Measure">
</ejs-lineargauge>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Linear Gauge with Title](images/lineargauge-with-title.webp)

## Axis

The start value and end value of the Linear Gauge axis can be added using the `minimum` and `maximum` property in the `e-axis` tag.

Refer below code snippet to add the axis range to Linear Gauge.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-lineargauge id="linear" orientation="Horizontal">
    <e-lineargauge-axes>
        <e-lineargauge-axis minimum="0" maximum="200">
        </e-lineargauge-axis>
    </e-lineargauge-axes>
</ejs-lineargauge>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Linear Gauge with Axis](images/lineargauge-with-axis.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/LinearGauge/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
