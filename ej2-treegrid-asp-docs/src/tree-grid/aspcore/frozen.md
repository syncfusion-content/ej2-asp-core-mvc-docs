---
title: "Frozen"
component: "TreeGrid"
description: "Learn how to freeze the tree grid columns at left or right side and how to freeze the tree grid rows at top."
---

# Frozen rows and columns

## Frozen rows and columns

Frozen rows and columns provides an option to make rows and columns always visible in the top and left side of the tree grid while scrolling.

In this demo, the [`frozenColumns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~FrozenColumns.html) is set as '2' and the [`frozenRows`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~FrozenRows.html)
is set as '3'. Hence, the left two columns and top three rows are frozen.

{% aspTab template="tree-grid/scrolling/frozencolumn", sourceFiles="freezecolumn.cs" %}

{% endaspTab %}

### Freeze particular columns

To freeze particular column in the tree grid, the [`isFrozen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsFrozen.html) property of **e-treegrid-column** tag helper can be used.

In this demo, the columns with field name **TaskName** and **StartDate** is frozen using
the [`isFrozen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsFrozen.html) property of **e-treegrid-column**.

{% aspTab template="tree-grid/scrolling/isfreezecol", sourceFiles="isfreeze.cs" %}

{% endaspTab %}

### Freeze direction

You can freeze the tree grid columns on the left or right side by using the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Freeze) property and the remaining columns will be movable. The tree grid will automatically move the columns to the left or right position based on the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Freeze) value.

Types of the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Freeze) directions:

* **`Left`**: Allows you to freeze the columns at the left.
* **`Right`**: Allows you to freeze the columns at the right.

In this demo, the **Task Name** column is frozen at the left and the **Priority** column is frozen at the right side of the content table.

{% aspTab template="tree-grid/scrolling/freeze-direction", sourceFiles="freeze-direction.cs" %}

{% endaspTab %}

> * Freeze Direction is not compatible with the `isFrozen` and `frozenColumns` properties.

### Limitations of frozen tree grid

The following features are not supported in frozen rows and columns:

* Row Template
* Detail Template
* Cell Editing

Freeze Direction feature has the below limitations, along with the above mentioned limitations.

* Infinite scroll cache mode
* Freeze direction in the stacked header is not compatible with column reordering.

> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core tree grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.
