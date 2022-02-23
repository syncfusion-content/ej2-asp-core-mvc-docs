---
title: "Search"
component: "Grid"
description: "Learn how to search DataGrid content, change search operators, perform searches using external buttons, and search particular fields."
---

# Search

You can search records in a Grid, by using the **Search** method with search key as a parameter. This also provides an option to integrate search text box in grid's toolbar by adding **Search** item to the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar).

{% aspTab template="grid/search/search", sourceFiles="search.cs" %}

{% endaspTab %}

## Initial search

To apply search at initial rendering, set the fields, operator, key, and ignoreCase in [`e-grid-searchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_SearchSettings_Syncfusion_EJ2_Grids_GridSearchSettings_) tag helper.

{% aspTab template="grid/search/initial-search", sourceFiles="initial-search.cs" %}

{% endaspTab %}

> By default, grid searches all the bound column values. To customize this behavior define the [`fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) property of **e-grid-searchSettings** tag helper.

## Search operators

The search operator can be defined in the [`operator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Operator) property of **e-grid-searchSettings** to configure specific searching.

The following operators are supported in searching:

Operator |Description
-----|-----
startswith |Checks whether a value begins with the specified value.
endswith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notequal |Checks for values not equal to the specified value.

> By default, the [`operator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Operator) value is **contains**.

## Search by external button

To search grid records from an external button, invoke the **search** method.

{% aspTab template="grid/search/external-btn", sourceFiles="external-btn.cs" %}

{% endaspTab %}

## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) property of **e-grid-searchSettings** tag helper.

{% aspTab template="grid/search/search-a-column", sourceFiles="search-a-column.cs" %}

{% endaspTab %}

## Clear search by external button

To clear the searched grid records from the external button, set [`key`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Key) property of **e-grid-searchSettings** as **empty** string.

{% aspTab template="grid/search/clear-search", sourceFiles="clear-search.cs" %}

{% endaspTab %}

## Search on each key stroke

You can search the Grid data on each key stroke by binding the `keyup` event for the search input element inside the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. Inside the `keyup` handler you can search the Grid by invoking the [`search`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#search) method of the Grid component.

{% aspTab template="grid/search/search-each-key", sourceFiles="search-each-key.cs" %}

{% endaspTab %}