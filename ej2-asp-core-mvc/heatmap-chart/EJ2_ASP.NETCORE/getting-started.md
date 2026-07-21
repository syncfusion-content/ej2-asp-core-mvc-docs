---
layout: post
title: Getting Started with ASP.NET Core HeatMap Chart Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core HeatMap Chart control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: HeatMap Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core HeatMap Chart Control

This section briefly explains how to include the [ASP.NET Core HeatMap Chart](https://www.syncfusion.com/aspnet-core-ui-controls/heatmap-chart) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor Pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core package

To add **ASP.NET Core HeatMap Chart** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.HeatMap](https://www.nuget.org/packages/Syncfusion.AspNetCore.HeatMap/) package. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.HeatMap -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helpers

After the package is installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.HeatMap` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.HeatMap

{% endhighlight %}
{% endtabs %}

## Add script resources

The theme stylesheet and script can be referenced from the [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** 

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    <!-- ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.HeatMap/scripts/sf-heatmap.min.js"></script>
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

## Add ASP.NET Core HeatMap Chart control

Add the [ASP.NET Core HeatMap Chart](https://www.syncfusion.com/aspnet-core-ui-controls/heatmap-chart) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-heatmap id="heatmap">
</ejs-heatmap>

{% endhighlight %}
{% endtabs %}

## Populate heat map with data

This section explains how to populate the following two-dimensional array data to the heat map.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/data/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core HeatMap Chart](https://www.syncfusion.com/aspnet-core-ui-controls/heatmap-chart) will render in your default web browser.

![ASP.NET Core HeatMap Chart with Data](images/heatmap-with-data.webp)

## Enable axis labels

You can add axis labels to the heat map and format those labels using the [xAxis](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~XAxis.html) and [yAxis](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~YAxis.html) properties. Axis labels provide additional information about the data points populated in the heat map.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/axis/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap Chart with Axis Labels](images/heatmap-with-axis-labels.webp)

## Add heat map title

Add a title using the [titleSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~TitleSettings.html) property to the heat map to provide quick information to the user about the data populated in the heat map.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/title/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap Chart with Title](images/heatmap-with-title.webp)

## Enable legend

Use a legend for the heat map in the [legendSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~LegendSettings.html) object by setting the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Visible.html) property to **true**.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/legend/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap Chart with Legend](images/heatmap-with-legend.webp)

## Add data label

Add data labels to improve the readability of the heat map. This can be achieved by setting the [showLabel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~ShowLabel.html) property to **true** in the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) object.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/label/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap Chart with DataLabel](images/heatmap-with-datalabel.webp)

## Add custom cell palette

The default palette settings of the heat map cells can be customized by using the [paletteSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~PaletteSettings.html) property. Using the [palette](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPalette.html) property in `paletteSettings` object, you can change the color set for the cells. You can change the color mode of the cells to fixed or gradient mode using the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/palette/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap Chart with Custom Palette](images/heatmap-with-palette.webp)

## Enable tooltip

The tooltip is used when you cannot display information by using the data labels due to space constraints. You can enable the tooltip by setting the [showTooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~ShowTooltip.html) property to **true**.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/heatmap/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core HeatMap Chart with Tooltip](images/heatmap-with-tooltip.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/HeatMap/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)