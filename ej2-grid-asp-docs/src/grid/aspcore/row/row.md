---
title: "Row"
component: "Grid"
description: "Documentation for row templates (custom row content), detail templates, and DataGrid row styles."
---

# Row

The row represents record details fetched from data source.

## Row Customization

### Using event

You can customize the appearance of a row by using the [`rowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.
The [`rowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event triggers for every row. In the event handler, you can get the
**rowDataBoundEventArgs** that contains details of the row.

{% aspTab template="grid/row/custom-rows", sourceFiles="custom-rows.cs" %}

{% endaspTab %}

### Using CSS customize alternate rows

 You can change the grid's alternative rows' background color by overriding the **.e-altrow** class.

```css
.e-grid .e-altrow {
    background-color: #fafafa;
}
```

Please refer to the following example.

{% aspTab template="grid/row/style-alt-row", sourceFiles="style-alt-row.cs" %}

{% endaspTab %}