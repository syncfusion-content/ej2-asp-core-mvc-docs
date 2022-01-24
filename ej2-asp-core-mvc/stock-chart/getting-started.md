---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

## ASP.NET Core 1.0 Application Using Visual Studio 2017

## System Requirements

To work with ASP.NET Core 1.0, you need to make sure is whether you have installed the following software on your machine

* Visual Studio 2017

* DotNetCore 2.0

## Configure Syncfusion UI Components in ASP.NET Core Application

The following steps helps to create a ASP.NET Core web application to configure our components.

* Open Visual Studio 2017  to create ASP.NET Core web application.

* After project creation, install the Syncfusion Packages in your application.

* Select the Tools->Nuget Package Manager->Package Manager settings the dialog window will open.

* Navigate to the Nuget Package Manager->Package Sources from the options dialog.

* Click the Add button to create the new package sources.

* Select the newly created Package Source and rename the source name using the Name input box.

     Name: Name of the package that listed in Available package sources

     Source: Syncfusion ASP.NET Core NuGet Package feed URL

     <https://api.nuget.org/v3/index.json>

## Adding TagHelpers

* Now open `_viewImports.cshtml` file from the views folder and add the following namespace for components references and Tag Helper support.

```javascript
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper *, Syncfusion.EJ2
```

## Adding ScriptManager

* Add ScriptManager to the bottom of the `layout.cshtml` page. The ScriptManager used to place our control initialization script in the page.

```javascript
<ej-scripts> </ej-scripts>

```

## Adding component to the Application

* Now open your view page to render our Syncfusion components.

{% aspCodeBlock  razorTemplate="stock-chart/getting-started/datalabel/razor" %}

```cs

            <ejs-stockchart id="container">
                <e-stockchart-series-collection>
                    <e-stockchart-series> </e-stockchart-series>
                </e-stockchart-series-collection>
            </ejs-stockchart>

```

{% endaspCodeBlock %}

## Populate Stock Chart With Data

This section explains how to plot below JSON data to the  Stock Chart.Please find the below imported datasource.

{% aspTab template=stock-chart/getting-started/populateData", sourceFiles="populateData.cs" %}

Add a series object to the chart by using [`series`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartAxis.html) property and then set the JSON data to [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_DataSource) property.

Since the JSON contains DateTime data, set the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) for
horizontal axis to DateTime. By default, the axis valueType is Numeric.

{% aspTab template="stock-chart/getting-started/populateData", sourceFiles="populateData.cs" %}

{% endaspTab %}

## Add Stock Chart Title

You can add a title using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Title) property to the Stock Chart to provide quick
information to the user about the data plotted in the Stock Chart.

{% aspTab template="stock-chart/getting-started/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Add Crosshair

Crosshair has a vertical and horizontal line to view the value of the axis at mouse or touch position.

Crosshair lines can be enabled by using [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html#Syncfusion_EJ2_Charts_ChartCrosshairSettings_Enable) property in the `crosshair`. Likewise tooltip label for an axis can be enabled by using [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairTooltip.html#Syncfusion_EJ2_Charts_ChartCrosshairTooltip_Enable) property of `crosshairTooltip` in the corresponding axis.

{% aspTab template="stock-chart/getting-started/crosshair", sourceFiles="crosshair.cs" %}

{% endaspTab %}

## Add Trackball

Trackball is used to track a data point closest to the mouse or touch position. Trackball marker indicates the
closest point and trackball tooltip displays the information about the point.

Trackball can be enabled by setting the [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property of the crosshair to true and
[`shared`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartCrosshairSettings.html) property in `tooltip` to true in chart.

{% aspTab template="stock-chart/getting-started/trackball", sourceFiles="trackball.cs" %}

{% endaspTab %}
