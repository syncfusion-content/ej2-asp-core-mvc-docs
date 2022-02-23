---
title: "Selection"
component: "Grid"
description: "Learn how to select rows and cells, use range selection, and use check box selection in the Essential JS 2 DataGrid control."
---

# Selection

Selection provides an option to highlight a row or a cell. It can be done through simple mouse down or arrow keys. To disable selection in the Grid, set the [`allowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSelection) property to false.

The grid supports two types of selection that can be set by using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property of **e-grid-selectionsettings** tag helper. They are:

* **Single**: The **Single** value is set by default, and it only allows selection of a single row or a cell or a column.
* **Multiple**: Allows you to select multiple rows or cells or columns.
To perform the multi-selection, press and hold CTRL key and click the desired rows or cells or columns. To select range of rows or cells or columns, press and hold the SHIFT key and click the rows or cells or columns.

{% aspTab template="grid/selection/selection", sourceFiles="selection.cs" %}

{% endaspTab %}

## Selection mode

The grid supports three types of selection mode that can be set by using
the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) property of **e-grid-selectionsettings** tag helper. They are:

* **Row**: The **Row** value is set by default, and allows you to select only rows.
* **Cell**: Allows you to select only cells.
* **Both**: Allows you to select rows and cells at the same time.

{% aspTab template="grid/selection/selection-mode", sourceFiles="selection-mode.cs" %}

{% endaspTab %}

## Touch interaction

When you tap a grid row on touchscreen device, the tapped row is selected.
It also shows a popup ![selection](../../images/selection.jpg)  for multi-row selection.
To select multiple rows or cells, tap the popup![mselection](../../images/mselection.jpg)  and then tap the desired rows or cells.

> Multi-selection requires the selection **type** to be **Multiple**.

The following screenshot represents a grid touch selection in the device.

![Touch interaction](../../images/touch-selection.jpg)