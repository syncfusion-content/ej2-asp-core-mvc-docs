# Inline Editing

In Normal edit mode, when you start editing the currently selected record is changed to edit state.
You can change the cell values and save edited data to the data source.
To enable Normal edit, set the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Normal**.

{% aspTab template="grid/edit/inline", sourceFiles="inline.cs" %}

{% endaspTab %}

> Normal edit mode is default mode of editing.

## Automatically update the column based on another column edited value

You can update the column value based on another column edited value by using the Cell Edit Template feature.

In the below demo, we have update the `TotalCost` column value based on the `UnitPrice` and `UnitInStock` column value while editing.

{% aspTab template="grid/edit/autoupdate", sourceFiles="autoupdate.cs" %}

{% endaspTab %}

## Cancel edit based on condition

You can prevent the CRUD operations of the Grid by using condition in the `actionBegin` event with requestType as `beginEdit` for editing, `add` for adding and `delete` for deleting actions.

In the below demo, we prevent the CRUD operation based on the `Role` column value. If the Role Column is `Employee`, we are unable to edit/delete that row.

{% aspTab template="grid/edit/cancel-edit-inline", sourceFiles="canceleditinline.cs" %}

{% endaspTab %}

## Perform CRUD action programmatically

Grid methods can be used to perform CRUD operations programmatically. The `addRecord`, `deleteRecord`, and `startEdit` methods are used to perform CRUD operations in the following demo.

* To add a new record to the Grid, use the `addRecord` method. In this method, you can pass the data parameter to add a new record to the Grid, and the index parameter to add a record at a specific index. If you call this method with no parameters, it will create an empty row in the Grid.

* To change the selected row to the edit state, use the `startEdit` method.

* If you need to update the row data in the Grid’s datasource, you can use the `updateRow` method. In this method, you need to pass the index value of the row to be updated along with the updated data.

* If you need to update the particular cell in the row, you can use the `setCellValue` method. In this method, you need to pass the primary key value of the data source, field name, and new value for the particular cell.

* To remove a selected row from the Grid, use the `deleteRecord` method. For both edit and delete operations, you must select a row first.

> **Note:** In both normal and dialog editing modes, these methods can be used.

{% aspTab template="grid/edit/programmatic", sourceFiles="programmatic.cs" %}

{% endaspTab %}

## Confirmation dialog

The delete confirm dialog can be shown when deleting a record by defining the [`ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) as **true**.

{% aspTab template="grid/edit/deleteconfirm", sourceFiles="deleteconfirm.cs" %}

{% endaspTab %}

> The [`ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_ShowDeleteConfirmDialog) supports all type of edit modes.

## Default column values on add new row

The grid provides an option to set the default value for the columns when adding a new record in it.
To set a default value for the particular column by defining the [`DefaultValue`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DefaultValue) of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

{% aspTab template="grid/edit/defaultcolumnvalue", sourceFiles="defaultcolumnvalue.cs" %}

{% endaspTab %}

## Adding a new row at the bottom of the Grid

By default, a new row will be added at the top of the grid. You can change it by setting [`NewRowPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_NewRowPosition) of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Bottom**.

{% aspTab template="grid/edit/rowposition", sourceFiles="rowposition.cs" %}

{% endaspTab %}

> Add newRowPostion is supported for **Normal** and **Batch** editing modes.