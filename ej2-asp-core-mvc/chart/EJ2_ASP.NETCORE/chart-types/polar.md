---
layout: post
title: Polar Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Polar Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Polar Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Polar in ##Platform_Name## Charts Component

## Polar

To render a polar series, use series[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as [`Polar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html#Syncfusion_EJ2_Charts_ChartSeriesType_Polar).

## Draw Types

Polar drawType property is used to change the series plotting type to line, column, area, range column, spline, scatter, stacking area and stacking column. The default value of drawType is [`Line`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_Line).

### Line

To render a line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`Line`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_Line). [`IsClosed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IsClosed) property specifies whether to join start and end point of a line series used in polar chart to form a closed path. Default value of isClosed is true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-line.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-line/polar-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-line.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-line/polar-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Spline

To render a spline line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`Spline`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_Spline).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-spline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-spline.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-spline/polar-spline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-spline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-spline.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-spline/polar-spline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Area

To render a area line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`Area`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_Area).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-area.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-area/polar-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-area.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-area/polar-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Stacked Area

To render a stacked area draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`StackingArea`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_StackingArea).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedarea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-stackedarea.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedarea/polar-stackedarea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedarea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-stackedarea.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedarea/polar-stackedarea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Column

To render a column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_Column).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-column.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-column/polar-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-column.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-column/polar-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Stacked Column

To render a stacked column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`StackingColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_StackingColumn).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-stackedcolumn.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedcolumn/polar-stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-stackedcolumn.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-stackedcolumn/polar-stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Range Column

To render a range column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`RangeColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_RangeColumn).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-rangecolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-rangecolumn.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-rangecolumn/polar-rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-rangecolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-rangecolumn.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-rangecolumn/polar-rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Scatter

To render a scatter draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as [`Scatter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDrawType.html#Syncfusion_EJ2_Charts_ChartDrawType_Scatter).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-scatter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-scatter.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-scatter/polar-scatter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/polar-scatter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polar-scatter.cs" %}
{% include code-snippet/chart/series/polar-radar/polar-scatter/polar-scatter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

### Start Angle

You can customize the start angle of the polar series using [`StartAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_StartAngle) property. By default, `StartAngle` is 0 degree.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/start-angle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Start-angle.cs" %}
{% include code-snippet/chart/series/polar-radar/start-angle/start-angle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/start-angle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Start-angle.cs" %}
{% include code-snippet/chart/series/polar-radar/start-angle/start-angle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Coefficient in axis

You can customize the radius of the polar series using [`Coefficient`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Coefficient) property. By default, `Coefficient` is 100.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Co-efficient.cs" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/co-efficient.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Co-efficient.cs" %}
{% include code-snippet/chart/series/polar-radar/co-efficient/co-efficient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data Label](../data-labels)
* [Tooltip](../tool-tip)