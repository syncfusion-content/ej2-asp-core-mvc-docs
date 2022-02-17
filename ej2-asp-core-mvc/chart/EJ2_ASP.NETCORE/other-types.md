---
layout: post
title: Other Types in ##Platform_Name## Chart Component
description: Learn here all about Other Types in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Other Types
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Box and whisker

To render a box and whisker chart, use series[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `BoxAndWhisker`.
The field y requires n number of data or it should contains minimum of five values to plot a segment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/box/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Box.cs" %}
{% include code-snippet/chart/series/other-types/box/box.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/box/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Box.cs" %}
{% include code-snippet/chart/series/other-types/box/box.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization of Box and Whisker series

### boxPlotMode

You can change the rendering mode of the Box and Whisker series using the `boxPlotMode` property.
The default boxPlotMode is `exclusive`.The other boxPlotMode available are `inclusive` and `normal`.

To render a box and whisker chart, use series[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `BoxAndWhisker`.
The field y requires n number of data or it should contains minimum of five values to plot a segment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/box-plot/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Box-plot.cs" %}
{% include code-snippet/chart/series/other-types/box-plot/box-plot.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/box-plot/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Box-plot.cs" %}
{% include code-snippet/chart/series/other-types/box-plot/box-plot.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### showMean

In Box and Whisker series `showMean` property is used to show the box and whisker average value. The default value of `showMean` is false.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/box-mean/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Box-mean.cs" %}
{% include code-snippet/chart/series/other-types/box-mean/box-mean.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/box-mean/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Box-mean.cs" %}
{% include code-snippet/chart/series/other-types/box-mean/box-mean.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Waterfall Chart

Waterfall chart helps to understand the cumulative effect of the sequentially introduced positive
and negative values. To render a Waterfall series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as
`Waterfall`. [`intermediateSumIndexes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_IntermediateSumIndexes)
property of waterfall is used to represent the in between the sum values and
[`sumIndexes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SumIndexes)
is used to represent the cumulative sum values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/waterfall/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Waterfall.cs" %}
{% include code-snippet/chart/series/other-types/waterfall/waterfall.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/waterfall/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Waterfall.cs" %}
{% include code-snippet/chart/series/other-types/waterfall/waterfall.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customization of Waterfall Series**

The negative changes of waterfall charts is
represented by using [`negativeFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_NegativeFillColor)
and the summary changes are represented by using [`summaryFillColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SummaryFillColor)
properties.

By default, the negativeFillColor as ‘#E94649’ and the summaryFillColor as ‘#4E81BC’.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-waterfall.cs" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/custom-waterfall.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-waterfall.cs" %}
{% include code-snippet/chart/series/other-types/custom-waterfall/custom-waterfall.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Error Bar Chart

Error bars are graphical representations of the variability of data and used on graphs to indicate the error or uncertainty in a reported
measurement. To render the error bar for the series, set [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Visible)
as `true` in error bar object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/errorbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar.cs" %}
{% include code-snippet/chart/series/other-types/errorbar/errorbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/errorbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Errorbar.cs" %}
{% include code-snippet/chart/series/other-types/errorbar/errorbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Changing Error Bar Type**

To change the error bar rendering type using [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type)
option of error bar. To change the error bar line length you can use [`verticalError`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-type.cs" %}
{% include code-snippet/chart/series/other-types/error-type/error-type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-type.cs" %}
{% include code-snippet/chart/series/other-types/error-type/error-type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customizing Error Bar Type**

To customize the error bar type, set error bar [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Custom` and
then change the horizontal/vertical positive and negative error of error bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-error/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-error.cs" %}
{% include code-snippet/chart/series/other-types/custom-error/custom-error.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/custom-error/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-error.cs" %}
{% include code-snippet/chart/series/other-types/custom-error/custom-error.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Changing Error Bar Mode**

Error bar mode is used to define whether the error bar line has to be drawn horizontally, vertically or in both side.
To change the error bar mode use [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html) option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-mode.cs" %}
{% include code-snippet/chart/series/other-types/error-mode/error-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-mode.cs" %}
{% include code-snippet/chart/series/other-types/error-mode/error-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Changing Error Bar Direction**

To change the error bar direction to plus, minus or both side using [`direction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html) option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-direction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-direction.cs" %}
{% include code-snippet/chart/series/other-types/error-direction/error-direction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-direction.cs" %}
{% include code-snippet/chart/series/other-types/error-direction/error-direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customizing Error Bar Cap**

To customize the error bar cap length, width and fill color, you can use [`errorBarCap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html) option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-cap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Error-cap.cs" %}
{% include code-snippet/chart/series/other-types/error-cap/error-cap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/error-cap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Error-cap.cs" %}
{% include code-snippet/chart/series/other-types/error-cap/error-cap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Vertical Chart

In EJ2 chart, you can draw a chart in vertical manner by changing orientation of the axis. All series types support this feature.
You can use `isTransposed` property in chart to render a chart in vertical manner.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/vertical/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vertical.cs" %}
{% include code-snippet/chart/series/other-types/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/vertical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vertical.cs" %}
{% include code-snippet/chart/series/other-types/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pareto chart

Pareto charts are used to find the cumulative values of data in different categories. It is a combination of Column and Line series.
The initial values are represented by column chart and the cumulative values are represented by Line chart.
To render a pareto chart, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `Pareto`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/pareto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/other-types/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/series/other-types/pareto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pareto.cs" %}
{% include code-snippet/chart/series/other-types/pareto/pareto.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)
