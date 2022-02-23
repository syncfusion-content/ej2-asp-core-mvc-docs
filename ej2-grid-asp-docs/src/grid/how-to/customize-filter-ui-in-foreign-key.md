---
title: "Customize filter UI in foreign key column"
component: "Grid"
description: "Learn how to customize filter UI in foreign key column."
---

# Customize filter UI in foreign key column

You can create your own filtering UI by using [`Filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html). The following example demonstrates the way to create a custom filtering UI in the foreign column.

In the following example, The **Employee Name** is a foreign key column. DropDownList is rendered using Filter UI.

{% aspTab template="grid/how-to/filter-ui-foreign", sourceFiles="filter-ui-foreign.cs" %}

{% endaspTab %}
