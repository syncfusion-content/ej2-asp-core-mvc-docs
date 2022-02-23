# Command Column Editing

The command column provides an option to add CRUD action buttons in a column. This can be defined by the [`commands`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Commands) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper.

The available built-in command buttons are:

| Command Button | Actions |
|----------------|---------|
| Edit | Edit the current row.|
| Delete | Delete the current row.|
| Save | Update the edited row.|
| Cancel | Cancel the edited state. |

{% aspTab template="grid/edit/commandcolumn", sourceFiles="commandcolumn.cs" %}

{% endaspTab %}

## Custom command column

The custom command buttons can be added in a column by using the [`commands`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Commands) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper and
the action for the custom buttons can be defined using **commandClick** event.

{% aspTab template="grid/edit/customcommand", sourceFiles="customcommand.cs" %}

{% endaspTab %}