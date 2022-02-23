# Reorder

Reordering can be done by drag and drop of a particular column header from one index to another index within the grid. To enable reordering, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowReordering) to true.

{% aspTab template="grid/columns/reorder", sourceFiles="reorder.cs" %}

{% endaspTab %}

> You can disable reordering a particular column by setting the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowReordering) property of [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to false.

## Reorder single column

Grid have option to reorder Columns either by Interaction or by using the **reorderColumns** method. In the below sample, **Name** column is reordered to last column position by using the method.

{% aspTab template="grid/columns/reordercols", sourceFiles="reordercols.cs" %}

{% endaspTab %}

## Reorder multiple columns

User can reorder a single column at a time by Interaction. Sometimes we need to have reorder multiple columns at the same time, It can be achieved through programmatically by using **reorderColumns** method.

In the below sample, **Ship City** and **Ship Region** column is reordered to last column position.

{% aspTab template="grid/columns/reordercolumns", sourceFiles="reordercols.cs" %}

{% endaspTab %}

## Reorder events

During the reorder action, the grid component triggers the below three events.

1. The [`ColumnDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDragStart) event triggers when column header element drag (move) starts.
2. The [`ColumnDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDrag) event triggers when column header element is dragged (moved) continuously.
3. The [`ColumnDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDrop) event triggers when a column header element is dropped on the target column.

{% aspTab template="grid/columns/reorderevents", sourceFiles="reorderevents.cs" %}

{% endaspTab %}