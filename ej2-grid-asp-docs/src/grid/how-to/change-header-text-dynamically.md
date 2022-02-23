---
title: "Change Change Column Header Text Dynamically"
component: "Grid"
description: "Learn how to change column header text dynamically."
---

# Change Column Header Text Dynamically

You can change the column [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderText) dynamically through an external button.

Follow the given steps to change the header text dynamically:

**Step 1**:

Get the column object corresponding to the field name by using the [`getColumnByField`](https://ej2.syncfusion.com/documentation/api/grid/#getcolumnbyfield) method.
Then, change the header text value.

```typescript
var column = grid.getColumnByField("ShipCity"); // Get column object.
column.headerText = 'Changed Text';

```

**Step 2**:

To reflect the changes in the grid header, invoke the [`refreshHeader`](https://ej2.syncfusion.com/documentation/api/grid/#refreshheader) method.

```typescript
grid.refreshHeader();

```

{% aspTab template="grid/how-to/column-header-text", sourceFiles="column-header-text.cs" %}

{% endaspTab %}
