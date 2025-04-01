---
layout: post
title: Bar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Bar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bar chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bar Charts in ##Platform_Name## Charts Component

## Bar

To render a [bar](https://www.syncfusion.com/aspnet-core-ui-controls/charts/chart-types/bar-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `type` as **Bar** in your chart configuration. This indicates that the data should be represented as a bar chart, which makes it easy to compare values across categories.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `dataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `xName` and `yName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `bar` series.

**Fill**

The `fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-fill.cs" %}
{% include code-snippet/chart/series/bar/bar-fill/bar-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-fill.cs" %}
{% include code-snippet/chart/series/bar/bar-fill/bar-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `fill` property can be used to apply a gradient color to the bar series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-grad.cs" %}
{% include code-snippet/chart/series/bar/bar-grad/bar-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-grad.cs" %}
{% include code-snippet/chart/series/bar/bar-grad/bar-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/bar/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/bar/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width, color and dasharray of the series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/bar/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/bar/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Bar space and width

### Bar space

Use the `columnSpacing` property in the series to adjust the space between bars.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-space/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-space.cs" %}
{% include code-snippet/chart/series/bar/bar-space/bar-space.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-space/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-space.cs" %}
{% include code-snippet/chart/series/bar/bar-space/bar-space.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Bar width

Use the `columnWidth` property in the series to adjust the width of the bars.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-width.cs" %}
{% include code-snippet/chart/series/bar/bar-width/bar-width.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-width.cs" %}
{% include code-snippet/chart/series/bar/bar-width/bar-width.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Bar width in pixel

Use the `columnWidthInPixel` property in the series to define the exact width of the bars in pixels. This property ensures that each bar maintains the specified width, providing a uniform appearance throughout the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-pixel.cs" %}
{% include code-snippet/chart/series/bar/bar-pixel/bar-pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-pixel.cs" %}
{% include code-snippet/chart/series/bar/bar-pixel/bar-pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Grouped bar

Use the `groupName` property to group the data points in bar type charts. Data points with the same group name will be grouped together in the chart, making it easy to compare different sets of data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/group-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-bar.cs" %}
{% include code-snippet/chart/series/bar/group-bar/group-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/group-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-bar.cs" %}
{% include code-snippet/chart/series/bar/group-bar/group-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Cylindrical bar chart

To render a cylindrical bar chart, set the `columnFacet` property to **Cylinder** in the chart series. This property transforms the regular bars into cylindrical shapes, enhancing the visual representation of the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-cylinder.cs" %}
{% include code-snippet/chart/series/bar/bar-cylinder/bar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/bar-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar-cylinder.cs" %}
{% include code-snippet/chart/series/bar/bar-cylinder/bar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Empty points

Data points with **null** or **undefined** values are considered empty. Empty data points are ignored and not plotted on the chart.

**Mode**

Use the `mode` property to define how empty or missing data points are handled in the series. The default mode for empty points is **Gap**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/bar/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/bar/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/bar/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/bar/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/bar/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/bar/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### Series render

The `seriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/bar/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/bar/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `pointRender` event allows you to customize each data point before it is rendered on the chart.
 
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/bar/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/bar/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Corner radius

The [`CornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in the chart series is used to customize the corner radius for bar series. This allows you to create bars with rounded corners, giving your chart a more polished appearance. You can customize each corner of the bars using the topLeft, topRight, bottomLeft, and bottomRight properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/bar/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Corner-radius.cs" %}
{% include code-snippet/chart/series/bar/corner-radius/corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Point corner radius

We can customize the corner radius for individual points in the chart series using the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) event by setting the [`CornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_CornerRadius) property in its event argument.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/point-corner-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/bar/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar/point-corner-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-corner-radius.cs" %}
{% include code-snippet/chart/series/bar/point-corner-radius/point-corner-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)