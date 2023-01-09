---
layout: post
title: Working With Data in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Working With Data in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Working With Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with data in ##Platform_Name## HeatMap Chart Component

Heatmap visualizes the JSON data and two-dimensional array data. Using the data adaptor support, data can be bound to the heatmap.

## Data adaptor

Heatmap supports the following types of data binding with the adaptor support.

* Array
    * Table binding
    * Cell binding
* JSON data
    * Table binding
    * Cell binding

### Array - Table binding

{% if page.publishingplatform == "aspnet-core" %}

Each inner array of an array table binding data contains data points for an X-axis data label, which is a collection of one dimensional array objects.
This is the default data binding type for heatmap. You can also directly bind the array object to the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/array-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Array-row.cs" %}
{% include code-snippet/heatmap/working-with-data/array-row/array-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Each inner array of an array table binding data contains data points for an X-axis data label, which is a collection of one dimensional array objects.
This is the default data binding type for heatmap. You can also directly bind the array object to the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.heatmap.heatmap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSource) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/array-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Array-row.cs" %}
{% include code-snippet/heatmap/working-with-data/array-row/array-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Array - Cell binding

{% if page.publishingplatform == "aspnet-core" %}

Each cell in an array cell binding data contain information about the row index, column index, and data value, which is a collection of array object. To bind the data to the heatmap, you can use the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) property and set the [adaptorType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_AdaptorType) property to **Cell** in the [dataSourceSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSourceSettings).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/array-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Array-cell.cs" %}
{% include code-snippet/heatmap/working-with-data/array-cell/array-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Each cell in an array cell binding data contain information about the row index, column index, and data value, which is a collection of array object. To bind the data to the heatmap, you can use the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.heatmap.heatmap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSource) property and set the [AdaptorType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_AdaptorType) property to **Cell** in the [DataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.heatmap.heatmap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSourceSettings).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/array-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Array-cell.cs" %}
{% include code-snippet/heatmap/working-with-data/array-cell/array-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### JSON data - Table binding

{% if page.publishingplatform == "aspnet-core" %}

In JSON table data binding, each JSON object contains an X-axis data point as row header and all the corresponding Y-axis data values. You can bind the JSON table data to the heatmap using the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) property. To achieve this, you should enable the [isJsonData](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_IsJsonData) property and  define the [adaptorType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_AdaptorType) property as **Table** in the [dataSourceSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSourceSettings). The [xDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_XDataMapping) property is used to map the row header in JSON data.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/json-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Json-row.cs" %}
{% include code-snippet/heatmap/working-with-data/json-row/json-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In JSON table data binding, each JSON object contains an X-axis data point as row header and all the corresponding Y-axis data values. You can bind the JSON table data to the heatmap using the [DataSource]((https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) property. To achieve this, you should enable the [IsJsonData](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_IsJsonData) property and  define the [AdaptorType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_AdaptorType) property as **Table** in the [DataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.heatmap.heatmap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSourceSettings). The [XDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_XDataMapping) property is used to map the row header in JSON data.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/json-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Json-row.cs" %}
{% include code-snippet/heatmap/working-with-data/json-row/json-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### JSON data - Cell binding

{% if page.publishingplatform == "aspnet-core" %}

In JSON cell data binding, each JSON object consists a value for each cell along with a mapping value for row and column. You can bind the JSON cell data having information for each cell to the heatmap using the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) property. To achieve this, you should define the [adaptorType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_AdaptorType) property as **Cell**, and enable the [isJsonData](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_IsJsonData) property in the [dataSourceSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSourceSettings). Now, map the fields of data by using the [valueMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_ValueMapping), [xDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_XDataMapping) and [yDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_YDataMapping) properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/json-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Json-cell.cs" %}
{% include code-snippet/heatmap/working-with-data/json-cell/json-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In JSON cell data binding, each JSON object consists a value for each cell along with a mapping value for row and column. You can bind the JSON cell data having information for each cell to the heatmap using the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.heatmap.heatmap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSource). To achieve this, you should define the [AdaptorType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_AdaptorType) property as **Cell**, and enable the [IsJsonData](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_IsJsonData) property in the [DataSourceSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.heatmap.heatmap.html#Syncfusion_EJ2_HeatMap_HeatMap_DataSourceSettings). Now, map the fields of data by using the [ValueMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_ValueMapping), [XDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_XDataMapping) and [YDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_YDataMapping) properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/json-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Json-cell.cs" %}
{% include code-snippet/heatmap/working-with-data/json-cell/json-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Empty points

{% if page.publishingplatform == "aspnet-core" %}

The data points that use the **null** or **undefined** or empty string as value are considered as empty points. Empty data points are ignored and not displayed in the heatmap, and these points are rendered with default palette. You can customize the empty data point color value using the [emptyPointColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~EmptyPointColor.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/empty-points/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/heatmap/working-with-data/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The data points that use the **null** or **undefined** or empty string as value are considered as empty points. Empty data points are ignored and not displayed in the heatmap, and these points are rendered with default palette. You can customize the empty data point color value using the [EmptyPointColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html#Syncfusion_EJ2_HeatMap_HeatMapPaletteSettings_EmptyPointColor) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/empty-points/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Empty-points.cs" %}
{% include code-snippet/heatmap/working-with-data/empty-points/empty-points.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding nested JSON data

{% if page.publishingplatform == "aspnet-core" %}

In complex data binding, you can bind the nested JSON data to the data points in the heatmap. The nested data can be mapped using the [xDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_XDataMapping), [yDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_YDataMapping), [valueMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_ValueMapping) and [bubbleDataMapping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_BubbleDataMapping) properties as string value concatenated by a dot.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/nested-json-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nested-json-cell.cs" %}
{% include code-snippet/heatmap/working-with-data/nested-json-cell/nested-json-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In complex data binding, you can bind the nested JSON data to the data points in the heatmap. The nested data can be mapped using the [XDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_XDataMapping), [YDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_YDataMapping), [ValueMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_ValueMapping) and [BubbleDataMapping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapData.html#Syncfusion_EJ2_HeatMap_HeatMapData_BubbleDataMapping) properties as string value concatenated by a dot.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/working-with-data/nested-json-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nested-json-cell.cs" %}
{% include code-snippet/heatmap/working-with-data/nested-json-cell/nested-json-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [To bind data for bubble heatmap with size and color attributes](./bubble-heatmap/#binding-data-for-bubble-heat-map-with-size-and-color-attributes)
