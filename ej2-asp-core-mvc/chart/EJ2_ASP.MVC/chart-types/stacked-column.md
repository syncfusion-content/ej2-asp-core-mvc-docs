---
layout: post
title: Stacked Column Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Stacked Column Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked column chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked column in ##Platform_Name## Charts Component

## Stacked column

To render a [stacked column](https://www.syncfusion.com/aspnet-mvc-ui-controls/charts/chart-types/stacked-column-chart) series in your chart, you need to follow a few steps to configure it correctly. Here’s a concise guide on how to do this:

* **Set the series type:** Define the series `Type` as **StackingColumn** in your chart configuration. This indicates that the data should be represented as a stacked column chart, where each column consists of multiple segments stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/stacked-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/stacked-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding data with series

You can bind data to the chart using the `DataSource` property within the series configuration. This allows you to connect a JSON dataset or remote data to your chart. To display the data correctly, map the fields from the data to the chart series `XName` and `YName` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/stacked-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column/stacked-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Series customization

The following properties can be used to customize the `stacked column` series.

**Fill**

The `Fill` property determines the color applied to the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column-fill.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-fill/stacked-column-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column-fill.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-fill/stacked-column-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The `Fill` property can be used to apply a gradient color to the stacked column series. By configuring this property with gradient values, you can create a visually appealing effect in which the color transitions smoothly from one shade to another.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-grad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column-grad.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-grad/stacked-column-grad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-grad/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-column-grad.cs" %}
{% include code-snippet/chart/series/stacked-column/stacked-column-grad/stacked-column-grad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Opacity**

The `Opacity` property specifies the transparency level of the fill. Adjusting this property allows you to control how opaque or transparent the fill color of the series appears.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/opacity/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/stacked-column/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/opacity/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opacity.cs" %}
{% include code-snippet/chart/series/stacked-column/opacity/opacity.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width, color and dasharray of the series border.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/stacked-column/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/series/stacked-column/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Stacking group

Use the `StackingGroup` property to group stacked columns and 100% stacked columns. Columns with the same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/stacked-column/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/stacked-column/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Cylindrical stacked column chart

To render a cylindrical stacked column chart, set the `ColumnFacet` property to **Cylinder** in the chart series. This property transforms the regular stacked columns into cylindrical shapes, enhancing the visual representation of the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stackedcolumn-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-cylinder.cs" %}
{% include code-snippet/chart/series/stacked-column/stackedcolumn-cylinder/stackedcolumn-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stackedcolumn-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-cylinder.cs" %}
{% include code-snippet/chart/series/stacked-column/stackedcolumn-cylinder/stackedcolumn-cylinder.cs %}
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
{% include code-snippet/chart/series/stacked-column/empty/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-column/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/empty/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty.cs" %}
{% include code-snippet/chart/series/stacked-column/empty/empty.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Fill**

Use the `Fill` property to customize the fill color of empty points in the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/empty-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-column/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/empty-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-fill.cs" %}
{% include code-snippet/chart/series/stacked-column/empty-fill/empty-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Border**

Use the `Border` property to customize the width and color of the border for empty points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/empty-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-column/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/empty-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-border.cs" %}
{% include code-snippet/chart/series/stacked-column/empty-border/empty-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Events

### Series render

The `SeriesRender` event allows you to customize series properties, such as data, fill, and name, before they are rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/series-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-column/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/series-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-render.cs" %}
{% include code-snippet/chart/series/stacked-column/series-render/series-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Point render

The `PointRender` event allows you to customize each data point before it is rendered on the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/point-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-column/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/point-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-render.cs" %}
{% include code-snippet/chart/series/stacked-column/point-render/point-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stack labels

The stack labels in stacked charts display cumulative total values for stack segments directly using data labels. If a stacked point has negative values, the stack labels are displayed below the point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stack-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels.cs" %}
{% include code-snippet/chart/series/stacked-column/stack-labels/stack-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stack-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels.cs" %}
{% include code-snippet/chart/series/stacked-column/stack-labels/stack-labels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Stack labels customization

Stack labels have various properties for customization to enhance the visual based on your requirements:

* [`Visible`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Visible) - Specifies whether stack labels are visible. Setting to true will display the labels. Default is false.
* [`Fill`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Fill) - Defines the background color of the stack labels. Accepts valid CSS color strings (hex, RGBA, etc.). Default is transparent.
* [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Format) - Formats the text displayed in the stack labels. Supports placeholders like {value}. Default is null.
* [`Angle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Angle) - Specifies the rotation angle for stack labels in degrees. Default is 0.
* [`Rx`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Rx) - Defines the rounded corner radius along the X-axis (horizontal direction) for the stack label background. Default is 5.
* [`Ry`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Ry) - Defines the rounded corner radius along the Y-axis (vertical direction) for the stack label background. Default is 5.
* [`Margin`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Margin) - Configures the margin around the stack label (left, right, top, and bottom).
* [`Border`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Border) - Configures the appearance of the stack label's border.
* [`Font`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartStackLabelSettings.html#Syncfusion_EJ2_Charts_ChartStackLabelSettings_Font) - Customizes the stack label text, including font size, color, style, weight, and family.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stack-labels-cus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels-cus.cs" %}
{% include code-snippet/chart/series/stacked-column/stack-labels-cus/stack-labels-cus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/stacked-column/stack-labels-cus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stack-labels-cus.cs" %}
{% include code-snippet/chart/series/stacked-column/stack-labels-cus/stack-labels-cus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)