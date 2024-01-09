---
layout: post
title: Stacked column chart in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about stacked column chart in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Stacked column chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Stacked column chart in ##Platform_Name## 3D Chart Component

## Stacked column chart

To render a stacked column series, use series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Type) as [`StackingColumn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeriesType.html#Syncfusion_EJ2_Charts_Chart3DSeriesType_StackingColumn).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn.cs" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn/stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn.cs" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn/stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Stacking group

To group the stacked columns, the [`StackingGroup`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_StackingGroup) property can be used. The columns with same group name are stacked on top of each other.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/group-stackedcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-stackedcolumn.cs" %}
{% include code-snippet/3d-chart/series/column-charts/group-stackedcolumn/group-stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/group-stackedcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-stackedcolumn.cs" %}
{% include code-snippet/3d-chart/series/column-charts/group-stackedcolumn/group-stackedcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cylindrical stacked column chart

To render a cylindrical stacked column chart, set the [`ColumnFacet`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_ColumnFacet) property to `Cylinder` in the chart series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-cylinder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-cylinder.cs" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-cylinder/stackedcolumn-cylinder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-cylinder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-cylinder.cs" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-cylinder/stackedcolumn-cylinder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series customization

The following properties can be used to customize the [`Stacked Column`]((https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeriesType.html#Syncfusion_EJ2_Charts_Chart3DSeriesType_StackingColumn)) series.

* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Fill) – Specifies the color of the series.
* [Opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Opacity) – Specifies the opacity of the [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Fill) color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-series.cs" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-series/stackedcolumn-series.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedcolumn-series.cs" %}
{% include code-snippet/3d-chart/series/column-charts/stackedcolumn-series/stackedcolumn-series.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


