---
layout: post
title: Stacked Bar Chart in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about Stacked Bar Chart in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked bar chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked Bar Chart in ##Platform_Name## 3D Charts Component

## Stacked bar chart

To render a stacked bar series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Type) as [`StackingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeriesType.html#Syncfusion_EJ2_Charts_Chart3DSeriesType_StackingBar).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar/stackedbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar/stackedbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stacking group

To group the stacked bar, the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_StackingGroup) property can be used. Bars with same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/group-stackedbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-stackedbar.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/group-stackedbar/group-stackedbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/group-stackedbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-stackedbar.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/group-stackedbar/group-stackedbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cylindrical stacked bar chart

To render a cylindrical stacked bar chart, set the [`ColumnFacet`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_ColumnFacet) property to `Cylinder` in the chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-cylinder.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-cylinder/stackedbar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-cylinder.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-cylinder/stackedbar-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Stacked Bar`]((https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeriesType.html#Syncfusion_EJ2_Charts_Chart3DSeriesType_StackingBar)) series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Opacity) – Specifies the opacity of [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Fill).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-series.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-series/stackedbar-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedbar-series.cs" %}
{% include code-snippet/3d-chart/series/bar-charts/stackedbar-series/stackedbar-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


