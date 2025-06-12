---
layout: post
title: Area Chart in ##Platform_Name## Charts
description: Learn here all about Area Chart in Syncfusion ##Platform_Name## Charts component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Area Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Area Chart in ##Platform_Name## Charts

## Area

To render an [area](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts/chart-types/area-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `Type` as **Area** in your chart configuration. This indicates that the data should be represented as an area chart, which is ideal for showing trends over time or across categories, with filled areas beneath the lines representing data points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/area/area/area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/area/area/area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `DataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `XName` and `YName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/area/area/area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/area/area/area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `area` series.

**Fill**

The `Fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area-fill.cs" %}
{% include code-snippet/chart/series/area/area-fill/area-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area-fill.cs" %}
{% include code-snippet/chart/series/area/area-fill/area-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `Fill` property can be used to apply a gradient color to the area series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area-grad.cs" %}
{% include code-snippet/chart/series/area/area-grad/area-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area-grad.cs" %}
{% include code-snippet/chart/series/area/area-grad/area-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `Opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/area/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/area/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Area border

Use the `Border` property to customize the width, color and dasharray of the series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area-border.cs" %}
{% include code-snippet/chart/series/area/area-border/area-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/area-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area-border.cs" %}
{% include code-snippet/chart/series/area/area-border/area-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Multicolored area

To render a multicolored area series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `Type` as **MultiColoredArea** in your chart configuration. This specifies that the series should be rendered as a multicolored area chart, with different segments of the area having distinct colors.

* **Customize the Segments:** Define the segments of the series using the segments property. Each segment can be customized with properties such as value, color, and dashArray.

    * `Value` - Specifies the endpoint of the segment.
    * `Color` - Defines the color of the segment.
    * `DashArray` - Defines the dashes or gaps in the segment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/multicolor-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multicolor-area.cs" %}
{% include code-snippet/chart/series/area-charts/multicolor-area/multicolor-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/multicolor-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multicolor-area.cs" %}
{% include code-snippet/chart/series/area-charts/multicolor-area/multicolor-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Empty points

Data points with **null** or **undefined** values are considered empty. Empty data points are ignored and not plotted on the chart.

**Mode**

Use the `Mode` property to define how empty or missing data points are handled in the series. The default mode for empty points is **Gap**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/area/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/area/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `Fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/area/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/area/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/area/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/area/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### Series render

The `SeriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/area/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/area/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `PointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/area/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/area/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)