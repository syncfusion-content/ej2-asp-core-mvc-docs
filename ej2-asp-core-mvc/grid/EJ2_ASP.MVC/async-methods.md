---
layout: post
title: ##Platform_Name## Grid - Async Methods | Syncfusion
description: ##Platform_Name## Grid provides promise‑based async methods for awaitable filtering, sorting, paging, CRUD operations, grouping, and more.
platform: ej2-asp-core-mvc
control: Async methods 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Async Methods in ASP.NET MVC Grid Component

The Syncfusion EJ2 ASP.NET MVC Grid introduces async methods that return a `Promise<void>`, enabling `await` based control over grid actions such as filtering, sorting, paging, grouping, searching, and CRUD operations. This powerful approach ensures that subsequent code runs only after the grid action has fully completed, eliminating race conditions and streamlining complex asynchronous workflows.

> All async methods return a `Promise<void>`. Use `await` inside an `async` function or chain `.then()` to execute logic after the action completes.

## setCellValueAsync

The `setCellValueAsync` method updates the value of a specific cell identified by its primary key and field name, and resolves after an optional delay.

> The primary key column must be defined using the [Columns.IsPrimaryKey](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property.

The following example demonstrates updating the "Ship Name" cell of a specific row using the `setCellValueAsync` method with a 50 ms delay:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/setcellvalue-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/edit/setcellvalue-method/async.cs  %}
{% endhighlight %}
{% endtabs %}

## setRowDataAsync

The `setRowDataAsync` method updates the entire data object of a row identified by its primary key, and resolves after an optional delay. Unlike cell-level updates, this method replaces all field values of the target row with the provided data object.

> The primary key column must be configured using [Columns.IsPrimaryKey](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey). The `rowData` object should include all field values, any omitted fields will be set to "undefined".

The following example demonstrates updating the full record of a specific row with a 50 ms delay using the `setRowDataAsync` method:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/setrowdata-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/edit/setrowdata-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## goToPageAsync

The `goToPageAsync` method navigates the grid to a specified page number and resolves the promise once the paging action is fully complete.

> The [AllowPaging](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging) property must be set to `true` for this method to work.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/gotopage-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/paging/gotopage-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## sortColumnAsync and clearSortingAsync

The `sortColumnAsync` method sorts the grid by a specified column and direction, and resolves when the sorting action is complete. It also supports multi-column sorting by passing `true` for the `isMultiSort` parameter, which preserves existing sort states while adding the new sort.

The `clearSortingAsync` method removes all applied sort orders from the grid and resolves when the operation is complete.

> The [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting) property must be set to `true`. For multi-column sorting, also set [AllowMultiSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowMultiSorting) to `true`.

The following example demonstrates using the `sortColumnAsync` method to sort by "Order Date" in descending order and `clearSortingAsync` method to clear all applied sorts:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/sorting/sortcolumn-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/sorting/sortcolumn-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## filterByColumnAsync and clearFilteringAsync

The `filterByColumnAsync` method applies a filter condition on a specified column and resolves when the filtering action is complete. It supports all standard filter operators and optional parameters for case sensitivity, accent handling, predicate logic (`and`/`or`), and cell values.

The `clearFilteringAsync` method removes filter conditions from the grid and resolves when the action is complete. An array of field names can optionally be passed to clear filters only for those specific columns. If no fields are provided, all applied filters are cleared.

> The [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) property must be set to `true`.

The following example demonstrates how to use the `filterByColumnAsync` method to filter the "Customer ID" column and the `clearFilteringAsync` method to clear filters for all columns:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filterbycolumn-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/filtering/filterbycolumn-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## searchAsync

The `searchAsync` method performs a grid-wide search using the provided string and resolves when the search operation completes. It searches across all searchable columns simultaneously.

> Search is applied to all columns unless restricted by setting [Columns.AllowSearching](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowSearching) to `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/search/search-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## addRecordAsync

The `addRecordAsync` method programmatically adds a new record to the grid and resolves after the save action is complete. When `data` is provided, the record is immediately saved to the data source. When no `data` is passed, the grid switches to add mode (opens the edit form) and resolves immediately without waiting for user interaction.

> The [EditSettings.AllowAdding](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowAdding) must be set to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/addrecord-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/edit/addrecord-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## endEditAsync

The `endEditAsync` method programmatically saves the currently active edit (whether it is an add or update operation) and resolves once the save action completes. If the edit is cancelled (e.g., via validation), the promise still resolves, allowing subsequent code to proceed safely.

> Either [AllowEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing) or [AllowAdding](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowAdding) must be enabled. The grid must be in edit mode for this method to trigger a save.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/endedit-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/edit/endedit-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## updateRowAsync

The `updateRowAsync` method updates a row at a specified zero-based index with new data, without entering edit mode. It directly replaces the row's data in the grid and resolves when the save action completes.

> The [EditSettings.AllowEditing](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowEditing) must be `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/updaterow-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/edit/endedit-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## deleteRecordAsync and deleteRowAsync

The `deleteRecordAsync` method deletes a record identified by a field name and data object, and resolves when the delete action completes. If no arguments are provided, the currently selected row(s) are deleted. If there are no selected rows and no arguments are passed, the promise resolves immediately.

The `deleteRowAsync` method deletes a row by passing its `HTMLTableRowElement` reference directly, and resolves when the delete action completes. This is the preferred approach when a direct reference to a row element is available from a template, event handler, or DOM traversal.

> The [EditSettings.AllowDeleting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_AllowDeleting) must be `true`. The primary key field is typically passed as `fieldname` for precise record targeting and use `getRowByIndex` to obtain the `HTMLTableRowElement` by its zero-based row index.

The following example demonstrates how to use the `deleteRecordAsync` method to delete a specific record and `deleteRowAsync` method to delete a row using its element reference:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/deleterecord-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/edit/deleterecord-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## groupColumnAsync, ungroupColumnAsync, and clearGroupingAsync

The `groupColumnAsync` method groups the grid by a specified column and resolves when the grouping action is complete. Multiple calls can be chained to group by several columns sequentially.

The `ungroupColumnAsync` method removes the grouping applied to a specified column and resolves when the ungrouping action completes.

The `clearGroupingAsync` method removes all grouped columns from the grid at once and resolves when the ungrouping action is complete. This resets the grid to its default ungrouped state.

> The [AllowGrouping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) must be `true`. If the specified column is not currently grouped, the method resolves immediately without error.

The following example demonstrates grouping the "Ship Country" column using the `groupColumnAsync` method, removing grouping from a specific column with the `ungroupColumnAsync` method, and clearing all groupings using the `clearGroupingAsync` method.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/groupcolumn-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AsyncMethod.cs" %}
{% include code-snippet/grid/grouping/groupcolumn-method/async.cs %}
{% endhighlight %}
{% endtabs %}

## See also

- [Sorting in EJ2 ASP.NET MVC Grid](./sorting)
- [Filtering in EJ2 ASP.NET MVC Grid](./filtering/filtering)
- [Paging in EJ2 ASP.NET MVC Grid](./paging)
- [Grouping in EJ2 ASP.NET MVC Grid](./grouping/grouping)
- [Editing in EJ2 ASP.NET MVC Grid](./editing/edit)
- [Searching in EJ2 ASP.NET MVC Grid](./searching)
