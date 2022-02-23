---
title: "Hide the expand/collapse icon in parent row with no record in child grid"
component: "Grid"
description: "Learn how to hide the expand/collapse icon in parent row with no record in child grid."
---

# Hide the expand/collapse icon in parent row with no record in child grid

By default, the expand/collapse icon will be visible even if the child grid is empty.

You can use `rowDataBound` event to hide the icon when there are no records in child grid.

To hide the expand/collapse icon in parent row when no records in child grid, follow the given steps:

**Step 1**:

Create CSS class with custom style to override the default style of Grid.

```css
    .e-row[aria-selected="true"] .e-customizedExpandcell {
        background-color: #e0e0e0;
    }

    .e-grid.e-gridhover tr[role='row']:hover {
        background-color: #eee;
    }

```

**Step 2**:

Add the CSS class to the Grid in the `rowDataBound` event handler of Grid.

```typescript

    function rowDataBound(args) {
        var filter = args.data.EmployeeID;
        var data = new ej.data.DataManager(this.childGrid.dataSource).executeLocal(new ej.data.Query().where("EmployeeID", "equal", parseInt(filter), true));
        if (data.length == 0) {
            //here hide which parent row has no child records
            args.row.querySelector('td').innerHTML = " ";
            args.row.querySelector('td').className = "e-customizedExpandcell";
        }
    }

```

In the below demo, the expand/collapse icon in the row with `EmployeeID` as `1` is hidden as it does not have record in child Grid.

{% aspTab template="grid/how-to/hidearrow", sourceFiles="hidearrow.cs" %}

{% endaspTab %}
