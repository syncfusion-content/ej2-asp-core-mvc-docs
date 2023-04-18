---
layout: post
title: Bubble Heatmap in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Bubble Heatmap in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bubble Heatmap
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bubble HeatMap in ##Platform_Name## HeatMap Chart Component

{% if page.publishingplatform == "aspnet-core" %}

Data points represent the data source values with **gradient** or **fixed** colors in the HeatMap. You can customize the appearance of these data points by changing the `color` and `size` attributes.

The data points can be represented in color fill or bubble shape by defining the [tileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property. By default, the data points are color filled with gradient or fixed colors and this depiction of data points is defined as `Rect` in the `tileType` property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Data points represent the data source values with **gradient** or **fixed** colors in the HeatMap. You can customize the appearance of these data points by changing the `Color` and `Size` attributes.

The data points can be represented in color fill or bubble shape by defining the [TileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property. By default, the data points are color filled with gradient or fixed colors and this depiction of data points is defined as `Rect` in the `TileType` property.

{% endif %}

The cell customizations and color mapping for rect tile type is defined in [appearance](./appearance/) and [palette](./palette/) sections in detail.

## Bubble types

{% if page.publishingplatform == "aspnet-core" %}

The data points can be represented in the bubble along with its attributes by setting the [tileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property to **Bubble**.

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data points can be represented in the bubble along with its attributes by setting the [TileType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_TileType) property to **Bubble**.

{% endif %}

In bubble HeatMap, you can display the data points with bubble size, bubble colors, and sector attributes of the bubble.

### Bubble size

In this bubble HeatMap type, the size factor of the bubble is used to denote the data variations. The radius of the bubble varies according to data values.

{% if page.publishingplatform == "aspnet-core" %}

By default, the bubble with small size denotes the data value with small magnitude and the larger bubble size denotes the data value with larger magnitude. This behavior can be inversed by using the [isInversedbubblesize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_IsInversedBubbleSize) property.

To render a bubble HeatMap with size series, set the [bubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Size**.

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

To render a bubble HeatMap with size series, set the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **Size**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-bubble.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-bubble/size-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatMap chart with Size bubble type](./images/bubble-heatmap/heatmap-with-bubble-size-type.png)

### Bubble color

In HeatMap, defined with this tile type, the data points will be represented with same sized bubbles and the data value variations are represented with the bubble colors.

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

![ASP.NET Core HeatMap chart with Color bubble type](./images/bubble-heatmap/heatmap-with-bubble-color-type.png)

### Bubble sector

In this bubble HeatMap type, the sector of the bubble decides the magnitude of data point. If the sector is large, then the data point value will be high.

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

![ASP.NET Core HeatMap chart with Sector bubble type](./images/bubble-heatmap/heatmap-with-bubble-sector-type.png)

### Combining size and color bubble types

{% if page.publishingplatform == "aspnet-core" %}

In this bubble HeatMap type, size and color of the bubble represents the data value variation. To render this bubble HeatMap type, set the [bubbleType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **SizeAndColor**.

{% elsif page.publishingplatform == "aspnet-mvc" %}

In this bubble HeatMap type, size and color of the bubble represents the data value variation. To render this bubble HeatMap type, set the [BubbleType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapCellSettings.html#Syncfusion_EJ2_HeatMap_HeatMapCellSettings_BubbleType) property to **SizeAndColor**.

{% endif %}

The following examples demonstrate different data binding with the **SizeAndColor** bubble type set in the HeatMap.

<!-- markdownlint-disable MD036 -->
**Array binding**

When an array of numbers is specified as the data source, the bubble HeatMap can be rendered with different sizes and colors depending on the bound data.

<!-- markdownlint-disable MD036 -->
**Table**

The following example illustrates how to render a bubble HeatMap with different sizes and colors using array table binding.

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

![Bubble HeatMap with size and color combined and rendered with array data and table adaptor type](./images/bubble-heatmap/heatmap-with-size-color-table.png)

<!-- markdownlint-disable MD036 -->
**Cell**

The following example illustrates how to render a bubble HeatMap with different sizes and colors using array cell binding.

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

![Bubble HeatMap with size and color combined and rendered with array data and cell adaptor type](./images/bubble-heatmap/heatmap-with-size-color-cell.png)

<!-- markdownlint-disable MD036 -->
**JSON binding**

When a list of JSON objects are specified as data source, the bubble HeatMap can be rendered with different sizes and colors depending on the bound data.

<!-- markdownlint-disable MD036 -->
**Table**

The following example illustrates how to render a bubble HeatMap with different sizes and colors using JSON table binding.

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

![Bubble HeatMap with size and color combined and rendered with JSON data and table adaptor type](./images/bubble-heatmap/heatmap-with-size-color-json-table.png)

<!-- markdownlint-disable MD036 -->
**Cell**

The following example illustrates how to render a bubble HeatMap with different sizes and colors using JSON cell binding.

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

![Bubble HeatMap with size and color combined and rendered with JSON data and cell adaptor type](./images/bubble-heatmap/heatmap-with-size-color-json-cell.png)

<!-- markdownlint-disable MD036 -->
**Binding size and color values from datasource**

{% if page.publishingplatform == "aspnet-core" %}

The size and color of the bubbles in the **SizeAndColor** bubble HeatMap type can be customized by binding the datasource field name that holds the size and color values to the [size](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapBubbleData.html#Syncfusion_EJ2_HeatMap_HeatMapBubbleData_Size) and [color](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapBubbleData.html#Syncfusion_EJ2_HeatMap_HeatMapBubbleData_Color) properties in the [bubbleDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_BubbleDataMapping).

>The `bubbleDataMapping` supports only for the JSON data with cell adaptor type.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/size-color-json-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The size and color of the bubbles in the **SizeAndColor** bubble HeatMap type can be customized by binding the datasource field name that holds the size and color values to the [Size](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapBubbleData.html#Syncfusion_EJ2_HeatMap_HeatMapBubbleData_Size) and [Color](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapBubbleData.html#Syncfusion_EJ2_HeatMap_HeatMapBubbleData_Color) properties in the [BubbleDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_BubbleDataMapping).

>The `BubbleDataMapping` supports only for the JSON data with cell adaptor type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-color-json-cell.cs" %}
{% include code-snippet/heatmap/bubble-heatmap/size-color-json-cell/size-color-json-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Bubble HeatMap with size and color type and bubble attributes](./images/bubble-heatmap/heatmap-with-size-color-json-cell.png)