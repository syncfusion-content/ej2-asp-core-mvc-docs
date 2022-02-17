---
layout: post
title: Chart Types in ##Platform_Name## Chart Component
description: Learn here all about Chart Types in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Chart Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Chart Types

Essential JS 2 Chart supports 32 types of series.

<!-- markdownlint-disable MD036 -->

## Line Charts

<!-- markdownlint-disable MD036 -->

**Line**

To render a line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Line`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Line.cs" %}
{% include code-snippet/chart/series/line-charts/line/line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Line.cs" %}
{% include code-snippet/chart/series/line-charts/line/line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Step Line**

To render a step line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StepLine`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stepline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stepline.cs" %}
{% include code-snippet/chart/series/line-charts/stepline/stepline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stepline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stepline.cs" %}
{% include code-snippet/chart/series/line-charts/stepline/stepline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacked Line**

To render a stacked line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingLine`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line/stacked-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**100% Stacked Line**

To render a 100% stacked line series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingLine100`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-100.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/stacked-line-100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-line-100.cs" %}
{% include code-snippet/chart/series/line-charts/stacked-line-100/stacked-line-100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Spline**

To render a spline series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Spline`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/spline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spline.cs" %}
{% include code-snippet/chart/series/line-charts/spline/spline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/spline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spline.cs" %}
{% include code-snippet/chart/series/line-charts/spline/spline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Spline Area**

To render a spline series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Spline`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/splinearea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Splinearea.cs" %}
{% include code-snippet/chart/series/line-charts/splinearea/splinearea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/splinearea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Splinearea.cs" %}
{% include code-snippet/chart/series/line-charts/splinearea/splinearea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Multicolored Line**

To render a multicolored line series, use the series type as `MultiColoredLine`.
Here, the individual colors to the data can be mapped by using `PointColorMapping`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/multi-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-line.cs" %}
{% include code-snippet/chart/series/line-charts/multi-line/multi-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/multi-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-line.cs" %}
{% include code-snippet/chart/series/line-charts/multi-line/multi-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Line Charts**

`stroke`, `stroke-width` and `dashArray` of all line type series can be customized by using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill),
[`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) and [`DashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/custom-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-line.cs" %}
{% include code-snippet/chart/series/line-charts/custom-line/custom-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/line-charts/custom-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-line.cs" %}
{% include code-snippet/chart/series/line-charts/custom-line/custom-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Area Charts

**Area**

To render a area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Area`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/area-charts/area/area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Area.cs" %}
{% include code-snippet/chart/series/area-charts/area/area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Range Area**

To render a range area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type)
as `RangeArea`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/rangearea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangearea.cs" %}
{% include code-snippet/chart/series/area-charts/rangearea/rangearea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/rangearea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangearea.cs" %}
{% include code-snippet/chart/series/area-charts/rangearea/rangearea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Spline Range Area**

The Spline Range Area Chart is used to display continuous data points as a set of splines that vary between high and low values over intervals of time and across different categories.

To render a spline range area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeriesType.html) as `SplineRangeArea`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/splinerangearea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Splinerangearea.cs" %}
{% include code-snippet/chart/series/area-charts/splinerangearea/splinerangearea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/splinerangearea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Splinerangearea.cs" %}
{% include code-snippet/chart/series/area-charts/splinerangearea/splinerangearea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacked Area**

To render a stacked area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingArea`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stackedarea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedarea.cs" %}
{% include code-snippet/chart/series/area-charts/stackedarea/stackedarea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stackedarea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedarea.cs" %}
{% include code-snippet/chart/series/area-charts/stackedarea/stackedarea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**100% Stacked Area**

To render a 100% stacked area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingArea100`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/100perstackedarea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedarea100.cs" %}
{% include code-snippet/chart/series/area-charts/100perstackedarea/stackedarea100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/100perstackedarea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedarea100.cs" %}
{% include code-snippet/chart/series/area-charts/100perstackedarea/stackedarea100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Step Area**

To render a step area series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StepArea`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/steparea/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Steparea.cs" %}
{% include code-snippet/chart/series/area-charts/steparea/steparea.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/steparea/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Steparea.cs" %}
{% include code-snippet/chart/series/area-charts/steparea/steparea.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacked Step Area**

To render a stacked step area series, use series `Type` as `StackingStepArea`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-step-area.cs" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/stacked-step-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stacked-step-area.cs" %}
{% include code-snippet/chart/series/area-charts/stacked-step-area/stacked-step-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Multicolored area**

To render a multicolored area series, use the series type as `MultiColoredArea`.
The required `Segments` of the series can be customized using the `Value`, `Color`, and `DashArray`.

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



**Customization of Area Charts**

fill, width and dashArray properties can be customized by [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill),
[`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Width) and [`DashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_DashArray) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/custom-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-area.cs" %}
{% include code-snippet/chart/series/area-charts/custom-area/custom-area.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/area-charts/custom-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-area.cs" %}
{% include code-snippet/chart/series/area-charts/custom-area/custom-area.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column Charts

**Column**

To render a column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Column`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/series/column-charts/column/column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/chart/series/column-charts/column/column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Range Column**

To render a range column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `RangeColumn`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/rangecolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn.cs" %}
{% include code-snippet/chart/series/column-charts/rangecolumn/rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/rangecolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rangecolumn.cs" %}
{% include code-snippet/chart/series/column-charts/rangecolumn/rangecolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacked Column**

To render a stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingColumn`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn.cs" %}
{% include code-snippet/chart/series/column-charts/stackedcolumn/stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**100% Stacked Column**

To render a 100% stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingColumn100`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100.cs" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/stackedcolumn100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn100.cs" %}
{% include code-snippet/chart/series/column-charts/100perstackedcolumn/stackedcolumn100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacking Group**

You can use the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_StackingGroup) property to group the stacked columns and 100% stacked columns.
Columns with same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/column-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/column-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Grouped Column**

You can use the [`GroupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_GroupName) property to group the data points in the column type charts.
Data points with same group name are grouped together.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-column.cs" %}
{% include code-snippet/chart/series/column-charts/group-column/group-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/group-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-column.cs" %}
{% include code-snippet/chart/series/column-charts/group-column/group-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Column Charts**

<!-- markdownlint-disable MD013 -->
`Fill` and `Border` of all column type series can be
customized using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Border) properties.
Width of the column and space between each column can be customized using [`columnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidth) and [`columnSpacing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnSpacing) properties respectively. The [`columnWidthInPixel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidthInPixel) property allows to specify the column width in pixel unit.
For customizing a specify point, please refer the
[`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/custom-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-column.cs" %}
{% include code-snippet/chart/series/column-charts/custom-column/custom-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/column-charts/custom-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-column.cs" %}
{% include code-snippet/chart/series/column-charts/custom-column/custom-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Bar Charts

**Bar**

To render a bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Bar`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar-charts/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bar.cs" %}
{% include code-snippet/chart/series/bar-charts/bar/bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacked bar**

To render a stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingBar`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/stackedbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar.cs" %}
{% include code-snippet/chart/series/bar-charts/stackedbar/stackedbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**100% Stacked Bar**

To render a 100% stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `StackingBar100`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/100perstackedbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100.cs" %}
{% include code-snippet/chart/series/bar-charts/100perstackedbar/stackedbar100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/100perstackedbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100.cs" %}
{% include code-snippet/chart/series/bar-charts/100perstackedbar/stackedbar100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Stacking Group**

You can use the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_StackingGroup) property to group the stacked
bar and 100% stacked bar. Columns with same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/bar-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/chart/series/bar-charts/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Grouped Bar**

You can use the [`GroupName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_GroupName) property to group the data points in the bar type charts.
Data points with same group name are grouped together.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-bar.cs" %}
{% include code-snippet/chart/series/bar-charts/group-bar/group-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/group-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-bar.cs" %}
{% include code-snippet/chart/series/bar-charts/group-bar/group-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Bar Charts**

`Fill` and `Border` of all bar type series can be
customized using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Border).
Width of the bar and space between each bar can be customized using [`columnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidth) and [`columnSpacing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnSpacing) properties respectively. The [`columnWidthInPixel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_ColumnWidthInPixel) property allows to specify the bar width in pixel unit.
For customizing a specify point, please refer the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/custom-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-bar.cs" %}
{% include code-snippet/chart/series/bar-charts/custom-bar/custom-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/bar-charts/custom-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-bar.cs" %}
{% include code-snippet/chart/series/bar-charts/custom-bar/custom-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Scatter Charts

To render a scatter series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Scatter`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scatter.cs" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/scatter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scatter.cs" %}
{% include code-snippet/chart/series/scatter-bubble/scatter/scatter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD018 -->

##Bubble Chart

To render a bubble series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Bubble`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble/bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Bubble Size Mapping**

`Size` property can be used to map the size value specified in data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-size.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/bubble-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-size.cs" %}
{% include code-snippet/chart/series/scatter-bubble/bubble-size/bubble-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

