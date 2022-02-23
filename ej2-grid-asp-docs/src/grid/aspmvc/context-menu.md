---
title: "Context Menu"
component: "Grid"
description: "Learn how to use the context menu and add custom context menu items in the Essential JS 2 DataGrid control."
---

# Context menu

The Grid has options to show the context menu when right clicked on it. To enable this feature, you need to define either default or custom item in the [`ContextMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems).

The default items are in the following table.

Items| Description
----|----
`AutoFit`|  Auto fit the current column.
`AutoFitAll` | Auto fit all columns.
`Edit`|  Edit the current record.
`Delete` | Delete the current record.
`Save` | Save the edited record.
`Cancel` | Cancel the edited state.
`Copy` | Copy the selected records.
`PdfExport` | Export the grid data as Pdf document.
`ExcelExport` | Export the grid data as Excel document.
`CsvExport` | Export the grid data as CSV document.
`Group` | Group the current column.
`Ungroup` | Ungroup the current column.
`SortAscending` | Sort the current column in ascending order.
`SortDescending` | Sort the current column in descending order.
`FirstPage` | Go to the first page.
`PrevPage` | Go to the previous page.
`LastPage` | Go to the last page.
`NextPage` | Go to the next page.

{% aspTab template="grid/context-menu/contextmenu", sourceFiles="contextmenu.cs" %}

{% endaspTab %}

## Custom context menu items

The custom context menu items can be added by defining the [`ContextMenuItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuItems) as a collection of
**ContextMenuItemModel**.
Actions for this customized items can be defined in the [`ContextMenuClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ContextMenuClick) event.

{% aspTab template="grid/context-menu/customcontextmenu", sourceFiles="customcontextmenu.cs" %}

{% endaspTab %}

> You can hide or show an item in context menu for specific area inside of grid by defining the **Target** property.
