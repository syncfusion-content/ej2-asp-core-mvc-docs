---
title: "Select grid rows based on certain condition"
component: "Grid"
description: "Learn how to select grid rows based on certain condition."
---

# Select grid rows based on certain condition

You can select the specific row in the grid based on a certain condition by using the `selectRows` method in the `dataBound` event of Grid.

In the below demo, we have selected the grid rows only when `EmployeeID` column value greater than `3`.

{% aspTab template="grid/how-to/databasedselection", sourceFiles="databasedselection.cs" %}

{% endaspTab %}
