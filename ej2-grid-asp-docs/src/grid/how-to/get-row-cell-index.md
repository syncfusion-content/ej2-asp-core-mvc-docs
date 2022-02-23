---
title: "Get specific row and cell index in Grid"
component: "Grid"
description: "Learn how to get specific row and cell index in Grid."
---

# Get specific row and cell index in Grid

You can get the specific row and cell index of the grid by using `rowSelected` event of the grid. Here, we can get the row and cell index by using `aria-rowindex`(get row Index from `tr` element) and `aria-colindex`(column index from `td` element) attribute.

{% aspTab template="grid/how-to/row-cell-index", sourceFiles="rowcellidx.cs" %}

{% endaspTab %}