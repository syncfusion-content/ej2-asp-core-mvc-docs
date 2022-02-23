---
title: "Cell"
component: "Grid"
description: "Learn how to customize the Essential JS 2 DataGrid cells with styling, text wrapping, adding custom attributes and tooltips."
---

# Cell

## Cell customization

The appearance of cells can be customized by using the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event.
The [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event triggers for every cell. In that event handler, you can get **QueryCellInfoEventArgs** that contains the details of the cell.

{% aspTab template="grid/cell/customize", sourceFiles="customize.cs" %}

{% endaspTab %}

## Custom attributes

You can customize the grid cells by adding a CSS class to the [`customAttribute`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property of the column.

```CSS
.e-attr {
    background: #d7f0f4;
}
```

In the below example, we have customized the cells of **OrderID** and **ShipCity** columns.

{% aspTab template="grid/cell/customAttribute", sourceFiles="customStyle.cs" %}

{% endaspTab %}

## Grid lines

The [`GridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GridLines) have option to display cell border and it can be defined by the
[`GridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GridLines) property.

The available modes of grid lines are:

| Modes | Actions |
|-------|---------|
| Both | Displays both the horizontal and vertical grid lines.|
| None | No grid lines are displayed.|
| Horizontal | Displays the horizontal grid lines only.|
| Vertical | Displays the vertical grid lines only.|
| Default | Displays grid lines based on the theme.|

{% aspTab template="grid/cell/gridlines", sourceFiles="gridlines.cs" %}

{% endaspTab %}

> By default, the grid renders with **Default** mode.