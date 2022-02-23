---
title: "Get specific row and cell index in Grid"
component: "Grid"
description: "Learn how to get specific row and cell index in Grid."
---

# Get specific row and cell index in Grid

You can get the specific row and cell index of the grid by using [`RowSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected) event of the grid. Here, we can get the row and cell index by using **aria-rowindex**(get row Index from **tr** element) and **aria-colindex**(column index from **td** element) attribute.

{% aspTab template="grid/how-to/row-cell-index", sourceFiles="rowcellidx.cs" %}

{% endaspTab %}