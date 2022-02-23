---
title: "Grouping"
component: "Grid"
description: "Learn how to group rows, apply initial groups, customize caption templates, and group by format in the Essential JS 2 DataGrid control."
---

# Grouping

The Grid has options to group records by dragging and dropping the column header to the group drop area. When grouping is applied, grid records are organized into a hierarchical structure to facilitate easier expansion and collapse of records.

To enable grouping in the grid, set the [`AllowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) as true. Grouping options can be configured through the [`GroupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html).

{% aspTab template="grid/grouping/group", sourceFiles="group.cs" %}

{% endaspTab %}

> You can group and ungroup columns by using the [`groupColumn`](https://ej2.syncfusion.com/documentation/api/grid/#groupcolumn) and
[`ungroupColumn`](https://ej2.syncfusion.com/documentation/api/grid/#ungroupcolumn) methods.
> To disable grouping for a particular column, set
[`AllowGrouping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowGrouping) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to false.

## Initial group

To apply group at initial rendering, set the column field name in the [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_Columns) property of [`GroupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html).

{% aspTab template="grid/grouping/initial-group", sourceFiles="initial-group.cs" %}

{% endaspTab %}

## Hide drop area

To avoid ungrouping or further grouping of a column after initial column
grouping, define the [`ShowDropArea`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowDropArea) of [`GroupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html) as false.

{% aspTab template="grid/grouping/hide-drop-area", sourceFiles="hide-drop-area.cs" %}

{% endaspTab %}

## Group with paging

On grouping columns with paging feature, the aggregated information and total items are displayed based on the current page. The grid does not consider aggregated information and total items from other pages. To get additional details (aggregated information and total items) from other pages, set the [`DisablePageWiseAggregates`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_DisablePageWiseAggregates) of [`GroupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html) to false.

> If remote data is bound to grid dataSource, two requests will be sent when performing grouping action; one for getting the grouped data and another for getting aggregate details and total items count.

## Group by format

By default, a column will be grouped by the data or value present for the particular row. To group the numeric
or datetime column based on the mentioned format, you have to enable the
[`EnableGroupByFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EnableGroupByFormat) property of the corresponding
grid columns.

{% aspTab template="grid/grouping/group-format", sourceFiles="group-format.cs" %}

{% endaspTab %}

## Grouping events

During the group action, the grid component triggers two events. The [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event
triggers before the group action starts and the [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event triggers after the group action is completed. Using these events you can perform any action.

{% aspTab template="grid/grouping/grouping-events", sourceFiles="grouping-events.cs" %}

{% endaspTab %}

> The **args.requestType** is based on the current action name. For example, when grouping, the **args.requestType** value will be grouping.

## Collapse by external button

You can collapse the selected group from an external button by invoking the expandCollapseRows method.

{% aspTab template="grid/grouping/collapse", sourceFiles="collapse.cs" %}

{% endaspTab %}

## See Also

* [Exporting grouped records](../excel-exporting#Exporting-grouped-records)