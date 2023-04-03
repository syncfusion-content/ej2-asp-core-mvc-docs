---
layout: post
title: Box and Whisker Chart in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Box and Whisker Chart in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Box and Whisker Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Box and Whisker in ##Platform_Name## Charts Component

## Box and whisker

To render a box and whisker chart, use series[`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `BoxAndWhisker`. The field y requires n number of data or it should contains minimum of five values to plot a segment.

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



## Box Plot

You can change the rendering mode of the Box and Whisker series using the `BoxPlotMode` property. The default boxPlotMode is `Exclusive`.The other boxPlotMode available are `Inclusive` and `Normal`.

To render a box and whisker chart, use series[`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Type) as `BoxAndWhisker`. The field y requires n number of data or it should contains minimum of five values to plot a segment.

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



## Show mean

In Box and Whisker series `ShowMean` property is used to show the box and whisker average value. The default value of `ShowMean` is false.

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



## See Also

* [Data Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html)
* [Tooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html)