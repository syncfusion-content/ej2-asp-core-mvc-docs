---
title: "Search"
component: "Grid"
description: "Learn how to search DataGrid content, change search operators, perform searches using external buttons, and search particular fields."
---

# Search

You can search records in a Grid, by using the `Search` method with search key as a parameter. This also provides an option to integrate search text box in grid's toolbar by adding `Search` item to the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_Toolbar_System_Object_).

{% aspTab template="grid/search/search", sourceFiles="search.cs" %}

{% endaspTab %}

## Initial search

To apply search at initial rendering, set the fields, operator, key, and ignoreCase in the [`SearchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_SearchSettings_Syncfusion_EJ2_Grids_GridSearchSettings_).

{% aspTab template="grid/search/initial-search", sourceFiles="initial-search.cs" %}

{% endaspTab %}

> By default, grid searches all the bound column values. To customize this behavior define the `SearchSettings.Fields` property.

## Search operators

The search operator can be defined in the `SearchSettings.Operator` property to configure specific searching.

The following operators are supported in searching:

Operator |Description
-----|-----
startswith |Checks whether a value begins with the specified value.
endswith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notequal |Checks for values not equal to the specified value.

> By default, the `SearchSettings.Operator` value is `contains`.

## Search by external button

To search grid records from an external button, invoke the `search` method.

{% aspTab template="grid/search/external-btn", sourceFiles="initial-search.cs" %}

{% endaspTab %}

## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the `SearchSettings.Fields` property.

{% aspTab template="grid/search/search-a-column", sourceFiles="search-a-column.cs" %}

{% endaspTab %}

## Clear search by external button

To clear the searched grid records from the external button, set [`searchSettings.key`](./api-searchSettings.html#key-string) property as `empty` string.

{% aspTab template="grid/search/clear-search", sourceFiles="clear-search.cs" %}

{% endaspTab %}
