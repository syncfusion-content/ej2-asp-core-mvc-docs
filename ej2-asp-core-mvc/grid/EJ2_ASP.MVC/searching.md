---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Searching of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---

startswith |Checks whether a value begins with the specified value.
endswith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notequal |Checks for values not equal to the specified value.

> By default, the [`Operator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Operator) value is **contains**.

## Search by external button

To search grid records from an external button, invoke the [`search`](https://ej2.syncfusion.com/documentation/api/grid/#search) method.

{% aspTab template="grid/search/external-btn", sourceFiles="initial-search.cs" %}

{% endaspTab %}

## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`Fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) property of [`SearchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html).

{% aspTab template="grid/search/search-a-column", sourceFiles="search-a-column.cs" %}

{% endaspTab %}

## Clear search by external button

To clear the searched grid records from the external button, set [`Key`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Key) property as **empty** string.

{% aspTab template="grid/search/clear-search", sourceFiles="clear-search.cs" %}

{% endaspTab %}

## Search on each key stroke

You can search the Grid data on each key stroke by binding the `keyup` event for the search input element inside the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. Inside the `keyup` handler you can search the Grid by invoking the [`search`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#search) method of the Grid component.

{% aspTab template="grid/search/search-each-key", sourceFiles="search-each-key.cs" %}

{% endaspTab %}

## See Also

* [Add clear icon in search in ASP.NET MVC  Grid](https://www.syncfusion.com/forums/139361/add-clear-icon-in-search-in-asp-net-mvc-grid)