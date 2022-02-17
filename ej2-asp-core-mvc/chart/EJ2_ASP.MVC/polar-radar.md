---
layout: post
title: Polar Radar in ##Platform_Name## Chart Component
description: Learn here all about Polar Radar in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Polar Radar
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Polar Chart and Radar Chart

## Polar Chart

To render a polar series, use series[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Polar`.

### Draw Types

Polar drawType property is used to change the series plotting type to line, column, area, range column, spline,
scatter, stacking area and stacking column. The default value of drawType is `Line`.

**Line**

To render a line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Line`.
[`IsClosed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IsClosed) property specifies whether to join start and end point of
 a line series used in polar chart to form a closed path. Default value of isClosed is true.

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



**Spline**

To render a spline line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Spline`.

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



**Area**

To render a area line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Area`.

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



**Stacked Area**

To render a stacked area draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `StackingArea`.

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



**Column**

To render a column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Column`.

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



**Stacked Column**

To render a stacked column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `StackingColumn`.

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



**Range Column**

To render a range column draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `RangeColumn`.

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



**Scatter**

To render a scatter draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Scatter`.

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



## Radar Chart

To render a radar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Radar`.

### Draw Type

**Line**

To render a line draw type, use series [`DrawType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DrawType) as `Line`.
[`IsClosed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IsClosed) property specifies whether to join start and end point of
a line series used in polar chart to form a closed path. Default value of isClosed is true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/radar-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radar-line.cs" %}
{% include code-snippet/chart/series/polar-radar/radar-line/radar-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/polar-radar/radar-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radar-line.cs" %}
{% include code-snippet/chart/series/polar-radar/radar-line/radar-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customization

**Start Angle**

You can customize the start angle of the polar series using
[`StartAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_StartAngle) property. By default, `StartAngle` is 0 degree.

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



**Coefficient in axis**

You can customize the radius of the polar series and radar series using
[`Coefficient`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Coefficient) property. By default, `Coefficient` is 100.

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

* [Data label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)
