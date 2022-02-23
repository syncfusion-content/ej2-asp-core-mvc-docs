---
title: "Editing"
component: "Grid"
description: "Learn how to perform CRUD operations in various edit modes, use different cell editors, and persist data on the server side in the Essential JS 2 DataGrid control."
---

# Editing

The Grid component has options to dynamically insert, delete and update records.
Editing feature requires a primary key column for CRUD operations.
To define the primary key, set [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper as **true** in particular column.

You can start the edit action either by double clicking the particular row or by selecting the required row and click on **Edit** button in the toolbar. Similarly, you can add a new record to grid either by clicking on **Add** button in the toolbar or an external button which is bound to invoke the **addRecord** method of the grid, **Save** and **Cancel** while in edit mode is possible using respective toolbar icon in grid.

Deletion of the record is possible by selecting the required row and click on **Delete** button in the toolbar.

{% aspTab template="grid/edit/edit", sourceFiles="edit.cs" %}

{% endaspTab %}

> * If [`isIdentity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsIdentity) property of **e-grid-column** is enabled, then it will be considered as a read-only column when editing and adding a record.
> * You can disable editing for a particular column, by specifying
[`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) property of **e-grid-column** to **false**.

## Toolbar with edit option

The grid toolbar has the [Built-in items](./tool-bar/#built-in-toolbar-items) to execute Editing actions.
You can define this by using the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property.

{% aspTab template="grid/edit/edittoolbar", sourceFiles="edittoolbar.cs" %}

{% endaspTab %}

## Disable editing for particular column

You can disable editing for particular columns by using the [`allowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowEditing) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper.

In the following demo, editing is disabled for the **CustomerID** column.

{% aspTab template="grid/edit/disableeditforcolumn", sourceFiles="disableeditforcolumn.cs" %}

{% endaspTab %}

## Disable editing for a particular row or cell

You can disable the editing for a particular row by using the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of Grid.

In the below demo, the rows which are having the value for **ShipCountry** column as **Denmark** is prevented from editing.

{% aspTab template="grid/how-to/disable-edit", sourceFiles="disable-edit.cs" %}

{% endaspTab %}

For batch mode of editing, you can use **CellEdit** event of Grid. In the below demo, the cells which are having the value as "Denmark" is prevented from editing.

{% aspTab template="grid/how-to/disable-edit-batch", sourceFiles="disable-edit-batch.cs" %}

{% endaspTab %}

## Editing template column

You can edit the template column value by defining the **Field** for that particular column.

In the below demo, the **ShipCountry** column is rendered with the template.

{% aspTab template="grid/how-to/edit-temp", sourceFiles="edit-temp.cs" %}

{% endaspTab %}

## Troubleshoot editing works only for first row

The Editing functionalities can be performed based upon the primary key value of the selected row.
If **primaryKey** is not defined in the grid, then edit or delete action take places the first row.

## See Also

* [How to set custom format in edit state of Grid](https://www.syncfusion.com/kb/11319/how-to-set-custom-format-in-edit-state-of-grid)