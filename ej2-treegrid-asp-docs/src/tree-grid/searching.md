---
title: "Search"
component: "TreeGrid"
description: "Learn how to search TreeGrid content, change search operators, perform searches using external buttons, and search particular fields."
---

# Search

You can search records in a TreeGrid, by using the `search` method with search key as a parameter. This also provides an option to integrate search text box in treegrid's toolbar by adding `search` item to the [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html).

{% aspTab template="tree-grid/searching/default-searching", sourceFiles="defaultSearching.cs" %}

{% endaspTab %}

## Initial search

To apply search at initial rendering, set the fields, operator, key, and ignoreCase in the [`SearchSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~SearchSettings.html).

{% aspTab template="tree-grid/searching/initial-search", sourceFiles="initialsearch.cs" %}

{% endaspTab %}

> By default, treegrid searches all the bound column values. To customize this behavior define the [`SearchSettings.Fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Fields.html) property.

## Search operators

The search operator can be defined in the [`SearchSettings.Operator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Operators.html) property to configure specific searching.

The following operators are supported in searching:

Operator |Description
-----|-----
startsWith |Checks whether a value begins with the specified value.
endsWith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notEqual |Checks for values not equal to the specified value.

> By default, the [`SearchSettings.Operator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Operators.html) value is `contains`.

## Search by external button

To search treegrid records from an external button, invoke the `search` method.

{% aspTab template="tree-grid/searching/search-external", sourceFiles="searchExternal.cs" %}

{% endaspTab %}

## Search specific columns

By default, treegrid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`SearchSettings.Fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Fields.html) property.

{% aspTab template="tree-grid/searching/search-columns", sourceFiles="searchColumns.cs" %}

{% endaspTab %}