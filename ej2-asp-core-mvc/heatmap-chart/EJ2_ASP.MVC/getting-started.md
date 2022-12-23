---
layout: post
title: Getting Started with ##Platform_Name## HeatmapChart Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## HeatmapChart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC HeatMapChart Control

This section briefly explains about how to include [ASP.NET MVC HeatMapChart](https://www.syncfusion.com/aspnet-mvc-ui-controls/heatmap-chart) control in your ASP.NET MVC application using Visual Studio.

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

## Add ASP.NET MVC HeatMapChart control

Now, add the Syncfusion ASP.NET MVC HeatMapChart control in `~/Views/Home/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().HeatMap("container").Render()

{% endhighlight %}
{% endtabs %}

## Populate heat map with data

This section explains how to populate the following two-dimensional array data to the heat map.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/heatmap/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    string[] xlabels = new string[12] { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne", "Paul", "Karin", "Mario" };
    ViewBag.xLabels = xlabels;
    string[] yLabels = new string[6] { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    ViewBag.yLabels = yLabels;
    int[,] data = new int[,]
    {
        {73, 39, 26, 39, 94, 0},
        {93, 58, 53, 38, 26, 68},
        {99, 28, 22, 4, 66, 90},
        {14, 26, 97, 69, 69, 3},
        {7, 46, 47, 47, 88, 6},
        {41, 55, 73, 23, 3, 79},
        {56, 69, 21, 86, 3, 33},
        {45, 7, 53, 81, 95, 79},
        {60, 77, 74, 68, 88, 51},
        {25, 25, 10, 12, 78, 14},
        {25, 56, 55, 58, 12, 82},
        {74, 33, 88, 23, 86, 59}
    };
    return View(data);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC HeatMapChart control will be rendered in the default web browser.

![ASP.NET MVC HeatMap Chart with Data](images/heatmap-with-data.png)

## Enable axis labels

You can add axis labels to the heat map and format those labels using the [xAxis](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_XAxis) and [yAxis](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_YAxis) properties. Axis labels provide additional information about the data points populated in the heat map.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/axis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/heatmap/getting-started/axis/axis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/axis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    string[] xlabels = new string[12] { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne", "Paul", "Karin", "Mario" };
    ViewBag.xLabels = xlabels;
    string[] yLabels = new string[6] { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    ViewBag.yLabels = yLabels;
    int[,] data = new int[,]
    {
        {73, 39, 26, 39, 94, 0},
        {93, 58, 53, 38, 26, 68},
        {99, 28, 22, 4, 66, 90},
        {14, 26, 97, 69, 69, 3},
        {7, 46, 47, 47, 88, 6},
        {41, 55, 73, 23, 3, 79},
        {56, 69, 21, 86, 3, 33},
        {45, 7, 53, 81, 95, 79},
        {60, 77, 74, 68, 88, 51},
        {25, 25, 10, 12, 78, 14},
        {25, 56, 55, 58, 12, 82},
        {74, 33, 88, 23, 86, 59}
    };
    return View(data);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC HeatMapChart with Axis](images/heatmap-with-axis-labels.png)

## Add heat map title

Add a title using the [TitleSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_TitleSettings) property to the heat map to provide quick information to the user about the data populated in the heat map.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/heatmap/getting-started/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    ViewBag.textStyle = new
    {
        size = "15px",
        fontWeight = "500",
        fontStyle = "Normal",
        fontFamily = "Segoe UI"
    };
    string[] xlabels = new string[12] { "Nancy", "Andrew", "Janet", "Margaret", "Steven", "Michael", "Robert", "Laura", "Anne", "Paul", "Karin", "Mario" };
    ViewBag.xLabels = xlabels;
    string[] yLabels = new string[6] { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    ViewBag.yLabels = yLabels;
    int[,] data = new int[,]
    {
        {73, 39, 26, 39, 94, 0},
        {93, 58, 53, 38, 26, 68},
        {99, 28, 22, 4, 66, 90},
        {14, 26, 97, 69, 69, 3},
        {7, 46, 47, 47, 88, 6},
        {41, 55, 73, 23, 3, 79},
        {56, 69, 21, 86, 3, 33},
        {45, 7, 53, 81, 95, 79},
        {60, 77, 74, 68, 88, 51},
        {25, 25, 10, 12, 78, 14},
        {25, 56, 55, 58, 12, 82},
        {74, 33, 88, 23, 86, 59}
    };
    return View(data);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC HeatMapChart with Title](images/heatmap-with-title.png)

## Enable legend

Use a legend for the heat map in the [LegendSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_LegendSettings) object by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Visible) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/heatmap/getting-started/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/legend/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC HeatMapChart with Legend](images/heatmap-with-legend.png)

## Add data label

Add data labels to improve the readability of the heat map. This can be achieved by setting the [ShowLabel](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_ShowLabel) property to **true** in the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellSettings) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/heatmap/getting-started/label/label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/label/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC HeatMapChart with DataLabel](images/heatmap-with-datalabel.png)

## Add custom cell palette

The default palette settings of the heat map cells can be customized by using the [PaletteSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_PaletteSettings) property. Using the [Palette](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html) property in `paletteSettings` object, you can change the color set for the cells. You can change the color mode of the cells to fixed or gradient mode using the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html#Syncfusion_EJ2_HeatMap_HeatMapPaletteSettings_Type) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/palette/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/heatmap/getting-started/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/palette/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC HeatMapChart with Custom Cell Palette](images/heatmap-with-palette.png)

## Enable tooltip

The tooltip is used when you cannot display information by using the data labels due to space constraints. You can enable the tooltip by setting the [ShowTooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_ShowTooltip) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/heatmap/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/getting-started/tooltip/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC HeatMapChart with Tooltip](images/heatmap-with-tooltip.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-MVC-Getting-Started-Examples/tree/main/HeatMap/ASP.NET%20MVC%20Razor%20Examples).