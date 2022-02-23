# Row Selection

## Select row at initial rendering

To select a row at initial rendering, set the [`SelectedRowIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_SelectedRowIndex) value.

{% aspTab template="grid/selection/select-row", sourceFiles="select-row.cs" %}

{% endaspTab %}

## Get selected row indexes

You can get the selected row indexes by using the [`getSelectedRowIndexes`](https://ej2.syncfusion.com/documentation/api/grid/#getselectedrowindexes) method.

{% aspTab template="grid/selection/selected-row-index", sourceFiles="selected-row-index.cs" %}

{% endaspTab %}

## Simple multiple row selection

You can select multiple rows by clicking on rows one by one. This will not deselect the previously selected rows. To deselect the previously selected row, you can click on the  selected row. You can enable this behavior by using [`EnableSimpleMultiRowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_EnableSimpleMultiRowSelection) property of [`SelectionSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html).

{% aspTab template="grid/selection/simplemultiselect", sourceFiles="multiselection.cs" %}

{% endaspTab %}

## Toggle selection

The Toggle selection allows to perform selection and unselection of the particular row or cell or column. To enable toggle selection, set [`EnableToggle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_EnableToggle) property of the [`SelectionSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html) as true. If you click on the selected row or cell or column then it will be unselected and vice versa.

{% aspTab template="grid/selection/toggleselection", sourceFiles="toggleselection.cs" %}

{% endaspTab %}

> If multi selection is enabled, then first click on any selected row (without pressing Ctrl key), it will clear the multi selection and in second click on the same row, it will be unselected.