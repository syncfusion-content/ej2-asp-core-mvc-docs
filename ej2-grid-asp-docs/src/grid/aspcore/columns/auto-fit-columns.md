# AutoFit Specific Columns

The **autoFitColumns** method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the **autoFitColumns** method in [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_DataBound_System_String_) event.

To use the **autoFitColumns** method, inject the **Resize** module in the grid.

{% aspTab template="grid/columns/autofit", sourceFiles="autofit.cs" %}

{% endaspTab %}

> You can autofit all the columns by invoking the **autoFitColumns** method without column names.