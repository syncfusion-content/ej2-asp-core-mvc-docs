---
layout: post
title: Getting Started with ASP.NET Core Smith Chart Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Smith Chart control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Smith Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Smith Charts Control

This section briefly explains how to include the [ASP.NET Core Smith Chart](https://www.syncfusion.com/aspnet-core-ui-controls/smith-chart) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add **ASP.NET Core Smith Chart** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.Smithchart](https://www.nuget.org/packages/Syncfusion.AspNetCore.Smithchart/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Smithchart -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Charts` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Charts

{% endhighlight %}
{% endtabs %}

## Add script resources

The script can be referenced using the [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references). Include the script reference inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** 

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.Charts/scripts/sf-smithchart.min.js"></script>
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

## Add ASP.NET Core Smith Chart control

Add the [ASP.NET Core Smith Chart](https://www.syncfusion.com/aspnet-core-ui-controls/smith-chart) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-smithchart id="smithchart">
</ejs-smithchart>

{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Smith Chart](https://www.syncfusion.com/aspnet-core-ui-controls/smith-chart) control will render in your default web browser.

![ASP.NET Core SmithChart Control](images/smithchart-control.webp)

## Add series to Smith Chart

The Smith Chart has the following two type of specification for adding series:

* dataSource - Data object can be bound directly by specifying the resistance and reactance values.
* points - Collection of resistance and reactance values can be bound directly to render the series.

The following two ways demonstrate adding two series to the Smith Chart.

* First series Transmission1 shows dataSource bound series.
* Second series Transmission2 shows points bound series.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/smithchart/getting-started/series/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Smith Chart with Series](images/smithchart-series.webp)

## Add title to Smith Chart

Smith Chart `title` API used to add title for Smith Chart. In that `text` API used to set text of the title. API `visible` used to toggle the title.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/smithchart/getting-started/title/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Smith Chart with Title](images/smithchart-with-title.webp)

## Enable marker to the Smith Chart

To use marker in series and its customization in Smith Chart, use series `marker` API. To display marker for a particular series, specify the `marker visible` to true. In the following sample, markers are enabled only for the first series.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/smithchart/getting-started/marker/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Smith Chart with Marker](images/smithchart-with-marker.webp)

## Enable data label to marker

To use marker data label and its customization in Smith Chart, use marker `dataLabel`. To display data label for a particular series marker, specify the `dataLabel visible` to true in that series `marker`. In the following sample, data labels are enabled for the first series.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/smithchart/getting-started/data-label/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Smith Chart with DataLabel](images/smithchart-with-datalabel.webp)

## Enable legend for Smith Chart

The legend feature is used to denote the corresponding series. You can enable the legend for the Smith Chart by setting the [`visible`] property to true in [`legendSettings`] object. The following sample shows enabling legend for Smith chart. The series name can be customized using the series `name`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/smithchart/getting-started/legend/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Enable tooltip for the Smith Chart series

The tooltip feature is used to show the values of the current point. You can enable tooltip by setting the [`visible`] property to true in [`tooltipSettings`] object. The following sample shows enabling tooltip for Smith Chart series collection.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/smithchart/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Smith Chart with Tooltip](images/smithchart-with-tooltip.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/SmithChart/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
