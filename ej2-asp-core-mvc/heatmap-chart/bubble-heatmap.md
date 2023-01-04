---
layout: post
title: Bubble Heatmap in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Bubble Heatmap in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bubble Heatmap
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bubble heatmap in ##Platform_Name## HeatMap Chart Component

Data points represent the data source values with **Gradient** or **Fixed** colors in the heatmap. You can customize the appearance of these data points by changing the `color` and `shape` to the cells in the heatmap.

{% if page.publishingplatform == "aspnet-core" %}

The data points can be represented as bubble shape by defining the [tileType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapCellSettings~TileType.html) property. By default, the data points are represented as **Rect** in the [tileType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileTypel) property and it is filled with **Gradient** or **Fixed** colors.

The cell customization and color mapping for the `tileType` as **Rect** is briefly explained in [appearance](https://ej2.syncfusion.com/aspnetcore/documentation/heatmap-chart/appearance) and [palette](https://ej2.syncfusion.com/aspnetcore/documentation/heatmap-chart/palette) section.

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data points can be represented as bubble shape by defining the [TileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property. By default, the data points are represented as **Rect** in the [TileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property and it is filled with **gradient** or **fixed** colors.

The cell customization and color mapping for the `TileType` as **Rect** is briefly explained in [appearance](https://ej2.syncfusion.com/aspnetmvc/documentation/heatmap-chart/appearance) and [palette](https://ej2.syncfusion.com/aspnetmvc/documentation/heatmap-chart/palette) section.

{% endif %}


## Bubble attributes

{% if page.publishingplatform == "aspnet-core" %}

The data points can be represented as bubble shape by setting the [tileType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property to **Bubble**. You can customize the appearance of the bubble shape by using the [BubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data points can be represented as bubble shape by setting the [TileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property to **Bubble**. You can customize the appearance of the bubble shape by using the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property.

{% endif %}

In bubble heatmap, you can display the data points with bubble size, bubble colors, and sector.

### Bubble size

When the heatmap tile type is **Bubble** and the bubble type is **Size**, the factor size of the bubble is used to denote the data variations. The radius of the bubble varies according to data values.

{% if page.publishingplatform == "aspnet-core" %}

By default, the bubble with small size denotes the data value with small magnitude and the larger bubble size denotes the data value with larger magnitude. This behavior can be inversed by using the [isInversedbubblesize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_IsInversedBubbleSize) property.

To render a bubble heatmap with size series, set the [bubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Size**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/size-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

By default, the bubble with small size denotes the data value with small magnitude and the larger bubble size denotes the data value with larger magnitude. This behavior can be inversed by using the [IsInversedbubblesize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_IsInversedBubbleSize) property.

To render a bubble heatmap with size series, set the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Size**.

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

When the heatmap tile type is **Bubble** and the bubble type is **Color**, the data points will be represented with same sized bubbles and the data value variations are represented with the bubble colors.

{% if page.publishingplatform == "aspnet-core" %}

To represent the data points with variations in bubble colors, set the [bubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Color**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/color-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/color-bubble/color-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

To represent the data points with variations in bubble colors, set the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Color**.

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

When the heatmap tile type is **Bubble** and the bubble type is **Sector**, the sector of the bubble decides the magnitude of data point. If the sector is large, then the data point value will be high.

{% if page.publishingplatform == "aspnet-core" %}

To render the data points with bubble sector, set the [bubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Sector**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/sector-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sector-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/sector-bubble/sector-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

To render the data points with bubble sector, set the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Sector**.

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

When the heatmap tile type is **Bubble** and the bubble type is **Sector**, you can bind the two data source fields to a single data point. Thereby, each data point represents the two data values with bubble size and bubble color attributes, where the bubble size denotes the magnitude of one data source field and the bubble color denotes the magnitude of another data source field.

{% if page.publishingplatform == "aspnet-core" %}

To render a bubble heatmap with size and color series, set the [bubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **SizeAndColor**.

{% elsif page.publishingplatform == "aspnet-mvc" %}

To render a bubble heatmap with size and color series, set the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **SizeAndColor**.

{% endif %}

#### Binding data for bubble heatmap with size and color attributes

##### Array binding - Table

{% if page.publishingplatform == "aspnet-core" %}

The data is represented using array table binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-table.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-table/size-color-table.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data is represented using array table binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

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

The data is represented using array cell binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-cell/size-color-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data is represented using array cell binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

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

The data is represented using JSON table binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-table.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-table/size-color-json-table.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data is represented using JSON table binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

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

The data is represented using JSON cell binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [cellSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/size-color-json-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data is represented using JSON cell binding with the bubble type is **SizeAndColor** and the tile type is **Bubble** in the [CellSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/size-color-json-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

