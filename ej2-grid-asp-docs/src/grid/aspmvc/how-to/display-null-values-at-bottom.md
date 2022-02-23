---
title: "Display null date values at always"
component: "Grid"
description: "Learn how to display null date values at always."
---

# Display the null date values at bottom of the Grid while perform sorting

By default the null values are displayed at bottom of the Grid row while perform sorting in ascending order. As well as this values are displayed at top of the Grid row while perform sorting with descending order. But you can customize this default order to display the null values at always bottom row of the Grid by using [`SortComparer`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_SortComparer) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

In the below code we have displayed the null date values at bottom of the Grid row while sorting the **OrderDate** column in both ways.

{% aspTab template="grid/how-to/sort-comparer", sourceFiles="sort-comparer.cs" %}

{% endaspTab %}
