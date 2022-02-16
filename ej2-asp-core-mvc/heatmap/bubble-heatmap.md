---
layout: post
title: Bubble Heatmap in ##Platform_Name## Heatmap Component
description: Learn here all about Bubble Heatmap in Syncfusion ##Platform_Name## Heatmap component and more.
platform: ej2-asp-core-mvc
control: Bubble Heatmap
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bubble heat map

Data points represent the data source values with `gradient` or `fixed` colors in the heat map.
You can customize the appearance of these data points by changing the `color` and `shape` attributes.

The data points can be represented in color fill or bubble shape by defining the [`tileType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~TileType.html) property.
By default, the data points are color filled with `gradient` or `fixed` and this depiction of data points is defined as `rect` in the [`tileType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~TileType.html) property.

The cell customizations and color mapping for `rect` tile type is defined in [`appearance`](./appearance/) and [`palette`](./palette/) sections in detail.

## Bubble attributes

The data points can be represented in the bubble along with its attributes by setting the [`tileType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~TileType.html) property to `bubble`.

In bubble heat map, you can display the data points with bubble size, bubble colors, and sector attributes of the bubble.

### Bubble size

In this bubble heat map type, the size factor of the bubble is used to denote the data variations. The radius of the bubble varies according to data values.

By default, the bubble with small size denotes the data value with small magnitude and the larger bubble size denotes the data value with larger magnitude. This behavior can be inversed by using the [`isinversedbubblesize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~IsInversedBubbleSize.html) property.

To render a bubble heat map with size series, set the [`bubbleType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~BubbleType.html) property to `Size`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/size-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/size-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Bubble color

In heat map, defined with this tile type, the data points will be represented with same sized bubbles and the data value variations are represented with the bubble colors.

To represent the data points with variations in bubble colors, set the [`bubbleType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~BubbleType.html) property to `Color`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/color-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/color-bubble/color-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/color-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/color-bubble/color-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Bubble sector

In this bubble heat map type, the sector of the bubble decides the magnitude of data point. If the sector is large, then the data point value will be high.

To render the data points with bubble sector, set the [`bubbleType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~BubbleType.html) property to `Sector`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/sector-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sector-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/sector-bubble/sector-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/sector-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sector-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/sector-bubble/sector-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Combining size and color bubble attributes

In this bubble heat map type, you can bind the two data source fields to a single data point. Thereby, each data point represents the two data values with bubble size and bubble color attributes, where the bubble size denotes the magnitude of one data source field and the bubble color denotes the magnitude of another data source field.

To render a bubble heat map with size and color series, set the [`bubbleType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~BubbleType.html) property to `SizeAndColor`.

#### Binding data for bubble heat map with size and color attributes

##### Array binding - Table

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-table.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-table/size-color-table.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-table.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-table/size-color-table.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



##### Array binding - Cell

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-cell/size-color-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-cell/size-color-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



##### JSON binding - Table

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-table.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-table/size-color-json-table.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-table.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-table/size-color-json-table.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



##### JSON binding - Cell

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/size-color-json-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/size-color-json-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

