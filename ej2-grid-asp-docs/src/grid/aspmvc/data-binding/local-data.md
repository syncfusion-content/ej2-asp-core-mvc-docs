# Local Data

## List binding

To bind list binding to the grid, you can assign a JavaScript object array to the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. The list data source can also be provided as an instance of the DataManager.

{% aspTab template="grid/data-binding/localdata", sourceFiles="local.cs" %}

{% endaspTab %}

> By default, DataManager uses **JsonAdaptor** for list data-binding.

## Refresh the data source

You can add/delete the data source records through an external button. To reflect the data source changes in the grid, invoke the [`refresh`](https://ej2.syncfusion.com/documentation/api/grid/#refresh) method.

To refresh the data source:

**Step 1**:

Add/delete the data source record by using the following code.

```typescript
    grid.dataSource.unshift(data); // add a new record.

    grid.dataSource.splice(selectedRow, 1); // delete a record.

```

**Step 2**:

Refresh the grid after the data source change by using the `refresh` method.

```typescript
    grid.refresh(); // refresh the Grid.

```

{% aspTab template="grid/how-to/refresh-datasource", sourceFiles="refresh-datasource.cs" %}

{% endaspTab %}