---
title: "Illustrations"
component: "Spreadsheet"
description: "This section shows how to insert a image, shapes and graphic objects in the Essential JS 2 spreadsheet."
---

# Illustrations

Illustrations helps you to insert a image, shapes and graphic objects in the Essential JS 2 spreadsheet.

## Image

Adding images to a spreadsheet can enhance the visual appeal and help convey information more clearly.

> * The default value for `allowImage` property is `true`.

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

> * In spreadsheet, you can add many types of image files, including IMAGE, JPG, PNG, GIF and JPEG files.

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

{% aspTab template="spreadsheet/image", sourceFiles="imageController.cs" %}

{% endaspTab %}

### Limitations of Image

The following features have some limitations in Image:

* Corner resizing option in the image element.
* Copy and paste the external image.

## Chart

A chart is a graphical representation of data, that organizes and represents a set of numerical or qualitative data. It mostly displays the selected range of data in terms of `x`-axis and `y`-axis. You can use the [`allowChart`](../api/spreadsheet/#allowChart) property to enable or disable the chart functionality.

>* The default value for the [`allowChart`](../api/spreadsheet/#allowChart) property is `true`.

### Types of chart

The following types of charts are available in the Spreadsheet.

>* Column Chart
>* Bar Chart
>* Area Chart
>* Line Chart
>* Pie Chart
>* Scatter Chart

### Insert Chart

You can insert the chart by using one of the following ways,

* Select the chart icon in the Ribbon toolbar under the Insert Tab.
* Use the [`insertChart()`](../api/spreadsheet/#insertChart) method programmatically.

The available parameter in the [`insertChart()`](../api/spreadsheet/#insertChart) method is,

| Parameter | Type | Description |
|-----|------|----|
| chart | `ChartModel` | Specifies the options to insert a chart in the spreadsheet. |

The available arguments in the `ChartModel` are:

* type: Specifies the type of chart.
* theme: Specifies the theme of a chart.
* isSeriesInRows: Specifies to switch the row or a column.
* range: Specifies the selected range or specified range.
* id: Specifies the chart element id.

### Delete Chart

* If you want to delete the chart, just select the chart, and then press the Delete key.
* Use the [`deleteChart()`](../api/spreadsheet/#deleteChart) method programmatically.

The available parameter in the [`deleteChart()`](../api/spreadsheet/#deleteChart) method is,

| Parameter | Type | Description |
|-----|------|----|
| id | `string` | Specifies the id of the chart element to be deleted. |

### Chart Customization

Chart feature allows you to view and insert a chart in a spreadsheet, and you can change the height and width of the chart by resizing and moving it to another position.

* You can change the height and width of the chart by resizing.

* You can change the position of the chart by drag and drop.

{% aspTab template="spreadsheet/chart", sourceFiles="chartController.cs" %}

{% endaspTab %}

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
