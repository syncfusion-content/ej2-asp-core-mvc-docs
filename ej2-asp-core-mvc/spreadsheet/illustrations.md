---
layout: post
title: Illustrations in ##Platform_Name## Syncfusion Spreadsheet Component
description: Learn here all about Illustrations in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Illustrations
publishingplatform: ##Platform_Name##
documentation: ug
---


# Illustrations in Spreadsheet control

Illustrations helps you to insert a image, shapes and graphic objects in the Essential JS 2 spreadsheet.

## Image

Adding images to a spreadsheet can enhance the visual appeal and help convey information more clearly.

N> * The default value for [`allowImage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowImage) property is `true`.

### Insert Image

You can insert the image by using one of the following ways,

* Selecting the Insert tab in the Ribbon toolbar, and then choose the Image tab.
* Use the `insertImage()` method programmatically.

The available parameters in `insertImage()` method are,

| Parameter | Type | Description |
|-----|------|----|
| images | `ImageModel` | Specifies the options to insert image in spreadsheet. |
| range(optional) | `string` | Specifies the range in spreadsheet. |

The available arguments in `ImageModel` are:

* src: Specifies the image source.
* id: Specifies image element id.
* height: Specifies the height of the image.
* width: Specifies the width of the image.
* top: Specifies the height of the image.
* left: Specifies the width of the image.

N> * In spreadsheet, you can add many types of image files, including IMAGE, JPG, PNG, GIF and JPEG files.

### Delete Image

* If you want to delete the image, just select the image firstly, and then press the Delete key.
* Use the `deleteImage()` method programmatically.

The available parameters in `deleteImage()` method are,

| Parameter | Type | Description |
|-----|------|----|
| id | `string` | Specifies the id of the image element to be deleted. |
| range(optional) | `string` | Specifies the range in spreadsheet. |

### Image Customization

Image feature allows you to view and insert a image in a spreadsheet and you can change the height and width of the image by resizing and move it to another position.

#### Height and Width

* You can change the height and width of the image by resizing.
* Use the `height` and `width` property in the `insertImage()` method programmatically.

#### Top and Left

* You can change the position of the image by drag and drop.
* Use the `top` and `left` property in the `insertImage()` method programmatically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ImageController.cs" %}
{% include code-snippet/spreadsheet/image/imageController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ImageController.cs" %}
{% include code-snippet/spreadsheet/image/imageController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Limitations of Image

The following features have some limitations in Image:

* Corner resizing option in the image element.
* Copy and paste the external image.

## Chart

A chart is a graphical representation of data, that organizes and represents a set of numerical or qualitative data. It mostly displays the selected range of data in terms of `x`-axis and `y`-axis. You can use the [`allowChart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowChart) property to enable or disable the chart functionality.

N> * The default value for the [`allowChart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowChart) property is `true`.

### Types of chart

The following types of charts are available in the Spreadsheet.

N>* Column Chart
<br/>* Bar Chart
<br/>* Area Chart
<br/>* Line Chart
<br/>* Pie Chart
<br/>* Scatter Chart

### Insert Chart

You can insert the chart by using one of the following ways,

* Select the chart icon in the Ribbon toolbar under the Insert Tab.
* Use the `insertChart()`method programmatically.

The available parameter in the `insertChart()` method is,

| Parameter | Type | Description |
|-----|------|----|
| chart | `ChartModel` | Specifies the options to insert a chart in the spreadsheet. |

The available arguments in the `ChartModel` are:

* type: Specifies the type of chart.
* theme: Specifies the theme of a chart.
* isSeriesInRows: Specifies to switch the row or a column.
* range: Specifies the selected range or specified range.
* id: Specifies the chart element id.
* markerSettings: Specifies the marker settings. The marker is used to provide information about the data points in the series and is currently only applicable to the line chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/chart-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartController.cs" %}
{% include code-snippet/spreadsheet/chart-cs1/chartController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/chart-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartController.cs" %}
{% include code-snippet/spreadsheet/chart-cs1/chartController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Delete Chart

* If you want to delete the chart, just select the chart, and then press the Delete key.
* Use the `deleteChart()`method programmatically.

The available parameter in the `deleteChart()` method is,

| Parameter | Type | Description |
|-----|------|----|
| id | `string` | Specifies the id of the chart element to be deleted. |

### Chart Customization

Chart feature allows you to view and insert a chart in a spreadsheet, and you can change the height and width of the chart by resizing and moving it to another position.

* You can change the height and width of the chart by resizing.

* You can change the position of the chart by drag and drop.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartController.cs" %}
{% include code-snippet/spreadsheet/chart/chartController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartController.cs" %}
{% include code-snippet/spreadsheet/chart/chartController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

#### Customization of line chart markers

Using the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_ActionBegin) event, you can change the shape, size, fill color, and border of the line chart marker. In the following example, you can see the modified marker appearance, such as shape and size, while creating the line chart with UI interaction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/chart-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartController.cs" %}
{% include code-snippet/spreadsheet/chart-cs2/chartController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/chart-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartController.cs" %}
{% include code-snippet/spreadsheet/chart-cs2/chartController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Limitations of Chart

The following features have some limitations in the Chart:

* Insert row/delete row between the chart data source will not reflect the chart.
* Copy/paste into the chart data source will not reflect the chart.
* Corner resizing option in chart element.

## See Also

* [Formatting](./formatting)
* [Rows and columns](./rows-and-columns)
* [Hyperlink](./link)
* [Sorting](./sort)
