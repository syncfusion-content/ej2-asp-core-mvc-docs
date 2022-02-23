# Column Chooser

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the
[`showColumnChooser`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ShowColumnChooser) property as true.

{% aspTab template="grid/columns/columnchooser", sourceFiles="columnchooser.cs" %}

{% endaspTab %}

> You can hide the column names in column chooser by defining the [`showInColumnChooser`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ShowInColumnChooser) property as false in **e-grid-column** tag helper of particular column.

## Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking
the **openColumnChooser** method with **X** and **Y** axis positions.

{% aspTab template="grid/columns/externalbutton", sourceFiles="externalbutton.cs" %}

{% endaspTab %}