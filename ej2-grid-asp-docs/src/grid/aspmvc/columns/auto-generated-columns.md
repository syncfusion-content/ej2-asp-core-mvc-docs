# Auto Generated Columns

The [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) are automatically generated when
[`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) declaration is empty or undefined while initializing the grid. All the columns in the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) are bound as grid columns.

{% aspTab template="grid/columns/auto", sourceFiles="auto.cs" %}

{% endaspTab %}

> When columns are auto-generated, the column [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) will be determined from the first record of the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource).

## Set Primary key column for auto generated columns when editing is enabled

Primary key can be defined in the declaration of column object of the grid. When you did not declare the columns, the grid will generate the columns automatically. For these auto generated columns, you can set [`IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) column property as true by using the following ways,

If Primary key "column index" is known then refer the following example

{% aspTab template="grid/columns/primary", sourceFiles="primary.cs" %}

{% endaspTab %}

> If Primary key "column fieldname" is known then you can get the column by using **var column = grid.getColumnByField('OrderID')** and then set primary key by defining **Column.IsPrimaryKey = 'true'**

## Set column options to auto generated columns

You can set column options such as [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Format), [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) to the auto generated columns by using [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the grid.

In the below example, [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) is set for **OrderID** column, date type is set for **OrderDate** column and numeric type is set for **Freight** column.

{% aspTab template="grid/columns/autocolumnformat", sourceFiles="autocolumnformat.cs" %}

{% endaspTab %}