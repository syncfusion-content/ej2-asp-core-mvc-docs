---
layout: post
title: Getting Started with ##Platform_Name## Heatmap Chart Component
description: Checkout and learn about getting started with ##Platform_Name## Heatmap Chart component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

## Prerequisites

To get start with ASP.NET MVC application, need to ensure the following software to be installed on the machine.

1. .Net Framework 4.5 and above.
2. ASP.NET MVC 4 or ASP.NET MVC 5
3. Visual Studio

## Preparing ASP.NET MVC application

The following steps to create ASP.NET MVC Application.

**Step 1:** Create ASP.NET MVC Application with default template project in Visual Studio.

![Default Template](./images/default-template-mvc.png)

**Step 2:** Once your project created. We need to add Syncfusion EJ2 package into your application by using `NuGet Package Manager`.

Open the `NuGet` package manager.

![Solution Explorer](./images/solution-explorer-mvc.png)

Install the **Syncfusion.EJ2.MVC4** package to the application.

![Nuget Demo](./images/nuget-demo-mvc.png)

After installation complete, this will be included in the project. You can refer it from the Project Assembly Reference.

> We need to install **NewtonSoft.JSON** as a dependency, since **Syncfusion.EJ2** dependent to `NewtonSoft.JSON` package.

**Step 3:** Add `Syncfusion.EJ2` namespace reference in `Web.config`

```cs
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>

```

```cs
<system.web>
    <compilation>
      <assemblies>
        <add assembly="Syncfusion.EJ2"/>
      </assemblies>
    </compilation>
  </system.web>
```

**Step 4:** Add client side resource through [`CDN`](http://ej2.syncfusion.com/15.4.23/documentation/base/deployment.html?lang=typescript#cdn) or local [`package`](https://www.npmjs.com/package/@syncfusion/ej2) in the layout page `_Layout.cshtml`.

```html
<head>
  @* Syncfusion Essential JS 2 Styles *@
  <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

  @* Syncfusion Essential JS 2 Scripts *@
  <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
</head>

```

**Step 5:** Adding Script Manager in layout page `_Layout.cshtml`.

```cs
@Html.EJS().ScriptManager()
```

**Step 6:**

Add the below code to your Index.cshtml view page which is present under Views/Home folder, to initialize the heatmap.

```cs

@using Syncfusion.EJ2;
@Html.EJS().HeatMap("container").Render()

```

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
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/heatmap/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable axis labels

You can add axis labels to the heat map and format those labels using the [`xAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~XAxis.html) and [`yAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~YAxis.html) properties. Axis labels provide additional information about the data points populated in the heat map.

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
{% highlight c# tabtitle="Axis.cs" %}
{% include code-snippet/heatmap/getting-started/axis/axis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add heat map title

Add a title using the [`titleSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~TitleSettings.html) property to the heat map to provide quick information to the user about the data populated in the heat map.

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
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/heatmap/getting-started/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable legend

Use a legend for the heat map in the [`legendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~LegendSettings.html) object by setting the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Visible.html) property to true.

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
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/heatmap/getting-started/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add data label

Add data labels to improve the readability of the heat map. This can be achieved by setting the [`showLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~ShowLabel.html) property to true in the [`cellSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSettings.html) object.

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
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/heatmap/getting-started/label/label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add custom cell palette

The default palette settings of the heat map cells can be customized by using the [`paletteSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~PaletteSettings.html) property.
Using the [`palette`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPalette.html) property in `paletteSettings` object, you can change the color set for the cells. You can change the color mode of the cells to fixed or gradient mode using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property.

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
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/heatmap/getting-started/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable tooltip

The tooltip is used when you cannot display information by using the data labels due to space constraints. You can enable the tooltip by setting the [`showTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~ShowTooltip.html) property to `true`.

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
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/heatmap/getting-started/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

