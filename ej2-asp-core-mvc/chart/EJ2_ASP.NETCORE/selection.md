---
layout: post
title: Selection in ##Platform_Name## Chart Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Selection

Chart provides selection support for the series and its data points on mouse click.

>When Mouse is clicked on the data points, the corresponding series legend will also be selected.

We have different type of selection mode for selecting the data. They are,

* None
* Point
* Series
* Cluster
* DragXY
* DragX
* DragY

## Point

 You can select a point, by setting `selectionMode` to point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/point-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/point-selection/point-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/point-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/point-selection/point-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series

 You can select a series, by setting `selectionMode` to series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/series-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/series-selection/series-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/series-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/series-selection/series-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Cluster

You can select the points that corresponds to the same index in all the series, by setting `selectionMode` to
cluster.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/cluster-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cluster-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/cluster-selection/cluster-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/cluster-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cluster-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/cluster-selection/cluster-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Rectangular selection

**DragXY, DragX and DragY**

To fetch the collection of data under a particular region, you have to set `selectionMode` as `DragXY`.

* DragXY - Allows us to select data with respect to horizontal and vertical axis.
* DragX - Allows us to select data with respect to horizontal axis.
* DragY - Allows us to select data with respect to vertical axis.

The selected data’s are returned as an array collection in the [`dragComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_DragComplete)
event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/drag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drag.cs" %}
{% include code-snippet/chart/user-interaction/selection/drag/drag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/drag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drag.cs" %}
{% include code-snippet/chart/user-interaction/selection/drag/drag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection type

You can select multiple points or series, by enabling the [`isMultiSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_IsMultiSelect) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/selection-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-type.cs" %}
{% include code-snippet/chart/user-interaction/selection/selection-type/selection-type.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/selection-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-type.cs" %}
{% include code-snippet/chart/user-interaction/selection/selection-type/selection-type.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection on load

You can able to select a point or series programmatically on a chart using
[`selectedDataIndexes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_SelectedDataIndexes)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/onload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Onload.cs" %}
{% include code-snippet/chart/user-interaction/selection/onload/onload.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/onload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Onload.cs" %}
{% include code-snippet/chart/user-interaction/selection/onload/onload.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection through on legend

You can able to select a point or series through on legend using
[`toggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ToggleVisibility) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/selection-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-legend.cs" %}
{% include code-snippet/chart/user-interaction/selection/selection-legend/selection-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/selection-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-legend.cs" %}
{% include code-snippet/chart/user-interaction/selection/selection-legend/selection-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization for selection

You can apply custom style to selected points or series with [`selectionStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_SelectionStyle)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/custom-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/custom-selection/custom-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/selection/custom-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-selection.cs" %}
{% include code-snippet/chart/user-interaction/selection/custom-selection/custom-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

