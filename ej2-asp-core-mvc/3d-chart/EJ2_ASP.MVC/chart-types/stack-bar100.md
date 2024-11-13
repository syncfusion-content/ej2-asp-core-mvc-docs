---
layout: post
title: 100% Stacked bar chart in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about 100% stacked bar chart in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: 100% Stacked bar chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# 100% Stacked bar chart in ##Platform_Name## 3D Chart Component

## 100% Stacked bar chart

To render a 100% stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Type) as [`StackingBar100`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeriesType.html#Syncfusion_EJ2_Charts_Chart3DSeriesType_StackingBar100).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/100perstackedbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/100perstackedbar/stackedbar100.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/100perstackedbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/100perstackedbar/stackedbar100.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## 100% Cylindrical stacked bar chart

To render a cylindrical 100% stacked bar chart, set the [`ColumnFacet`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_ColumnFacet) property to `Cylinder` in the chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar100-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100-cylinder.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar100-cylinder/stackedbar100-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar100-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar100-cylinder.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar100-cylinder/stackedbar100-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`100% Stacked Bar`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeriesType.html#Syncfusion_EJ2_Charts_Chart3DSeriesType_StackingBar100) series.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Opacity) – Specifies the opacity of the [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Fill) color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-100-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-100-series.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-100-series/stackedbar-100-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-100-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-100-series.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-100-series/stackedbar-100-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


