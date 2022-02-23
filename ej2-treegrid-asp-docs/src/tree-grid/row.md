---
title: "Row"
component: "TreeGrid"
description: "Documentation for row customizations in TreeGrid."
---

# Row

The row represents record details fetched from data source.

## Customize rows

You can customize the appearance of a row by using the [`RowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event.
The [`RowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event triggers for every row. In the event handler, you can get the
`args` which contains details of the row.

{% aspTab template="tree-grid/row/customize-rows", sourceFiles="CustomizeRows.cs" %}

{% endaspTab %}

## Styling alternate rows

 You can change the treegrid's alternative rows' background color by overriding the `.e-altrow` class.

```css
.e-treegrid .e-altrow {
    background-color: #fafafa;
}
```

Please refer to the following example.

{% aspTab template="tree-grid/row/alternate-rows", sourceFiles="alternateRows.cs" %}

{% endaspTab %}

## Row height

You can customize the row height of treegrid rows through the [`RowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) property. The `RowHeight` property is used to change the row height of entire treegrid rows.

In the below example, the `RowHeight` is set as '60px'.

{% aspTab template="tree-grid/row/row-height", sourceFiles="rowHeight.cs" %}

{% endaspTab %}

### Customize row height for particular row

Grid row height for particular row can be customized using the [`RowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html)
event by setting the `RowHeight` in arguments for each row based on the requirement.

In the below example, the row height for the row with Task ID as '3' is set as '90px' using the `RowDataBound` event.

{% aspTab template="tree-grid/row/customize-row-height", sourceFiles="customizeRowHeight.cs" %}

{% endaspTab %}