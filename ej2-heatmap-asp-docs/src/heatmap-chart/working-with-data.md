---
title: "Working with data"
component: "Heatmap"
description: "This section describes the data binding options available in heatmap. User can bind either two-dimensional array or JSON data to the heatmap."
---

# Working with data

Heat map visualizes the JSON data and two-dimensional array data. Using the data adaptor support, data can be bound to the heat map.

## Data adaptor

Heat map supports the following types of data binding with the adaptor support.

* Array
    * Table Binding
    * Cell Binding
* JSON data
    * Table Binding
    * Cell Binding

### Array - table binding

This data type is a collection of one dimensional array objects, at which each inner array contains data points for an X-axis data label. This is the default data binding type for heat map. You can also directly bind the array object to the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) property.

{% aspTab template="heatmap/working-with-data/array-row", sourceFiles="array-row.cs" %}

{% endaspTab %}

### Array - cell binding

This data type is a collection of array objects that contain information about the row index, column index, and data value for each cell. You can bind the data to heat map by using the `data` property in the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html) and setting the `adaptorType` property to `Cell`.

{% aspTab template="heatmap/working-with-data/array-cell", sourceFiles="array-cell.cs" %}

{% endaspTab %}

### JSON data - table binding

In JSON table data binding, each JSON object contains an X-axis data point as row header and all the corresponding Y-axis data values. You can bind the JSON table data to the heat map using the `data` property in [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html). To achieve this, you should enable the `isJsonData` property and  define the `adaptorType` property as `Table`. The `xDataMapping` property is used to map the row header in JSON data.

{% aspTab template="heatmap/working-with-data/json-row", sourceFiles="json-row.cs" %}

{% endaspTab %}

### JSON data - Cell binding

In JSON cell data binding, each JSON object consists a value for each cell along with a mapping value for row and column. You can bind the JSON cell data having information for each cell to the heat map using the `data` property in [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~DataSource.html). To achieve this, you should define the `adaptorType` property as `Cell`. and enable the `isJsonData` property. Now, map the fields of data by using the `valueMapping`,
`xDataMapping` and `yDataMapping` properties.

{% aspTab template="heatmap/working-with-data/json-cell", sourceFiles="json-cell.cs" %}

{% endaspTab %}

## Empty points

The data points that use the `null` or `""` or `undefined` as value are considered as empty points. Empty data points are ignored and not displayed in the heat map, and these points are rendered with default palette. You can customize the empty data point color value using the [`emptyPointColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~EmptyPointColor.html) property.

{% aspTab template="heatmap/working-with-data/empty-points", sourceFiles="empty-points.cs" %}

{% endaspTab %}

## Binding nested JSON data

In complex data binding, you can bind the nested JSON data to the data points in the heat map.
The nested data can be mapped using the `xDataMapping`, `yDataMapping`, `valueMapping`
and `bubbleDataMapping` properties as string value concatenated by a dot.

{% aspTab template="heatmap/working-with-data/nested-json-cell", sourceFiles="nested-json-cell.cs" %}

{% endaspTab %}

## See Also

* [To bind data for bubble heat map with size and color attributes](./bubble-heatmap/#binding-data-for-bubble-heat-map-with-size-and-color-attributes)
