---
title: "Disable editing for a particular row/cell"
component: "Grid"
description: "Learn how to disable editing for a particular row/cell."
---

# Disable editing for a particular row/cell

You can disable the editing for a particular row by using the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of Grid.

In the below demo, the rows which are having the value for **ShipCountry** column as Denmark is prevented from editing.

{% aspTab template="grid/how-to/disable-edit", sourceFiles="disable-edit.cs" %}

{% endaspTab %}

For batch mode of editing, you can use [`CellEdit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event of Grid. In the below demo, the cells which are having the value as Denmark is prevented from editing.

{% aspTab template="grid/how-to/disable-edit-batch", sourceFiles="disable-edit-batch.cs" %}

{% endaspTab %}
