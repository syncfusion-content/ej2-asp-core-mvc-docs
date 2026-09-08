---
layout: post
title: ##Platform_Name## Grid Programmatic Filtering | Syncfusion
description: Learn ##Platform_Name## Grid programmatic filtering using filter APIs, retrieve filtered records, inspect filter details, and clear filters programmatically.
platform: ej2-asp-core-mvc
control: Programmatic Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

# Programmatic Filtering in ASP.NET MVC Grid

Programmatic filtering allows filters to be applied to specific columns through code, without relying on user interface interactions. This capability is useful for applying predefined filter criteria when the grid loads or for triggering filters from external application logic. Programmatic filtering is performed using the `filterByColumn` method.

The following example demonstrates programmatic filtering using single and multiple values for the "Order ID" and "Customer ID" columns. The `filterByColumn` method is called within an external button click function.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-programmatically/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/filter-programmatically/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-programmatically.gif)

## Get filtered records

Use Data Grid methods and properties to retrieve records that satisfy the active filter criteria.

### Using the getFilteredRecords() method

The `getFilteredRecords` method returns an array of records that match the filters currently applied on the grid. When the Data Grid is bound to remote data, this method returns a Promise that resolves to the filtered records.

The following example demonstrates getting filtered data using the `getFilteredRecords` method:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/get-filtered-records/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/get-filtered-records/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/filter-selected-record.png)

### Using the properties in the FilterEventArgs object

Alternatively, use properties available in the `FilterEventArgs` object to obtain filter record details:

* `Columns`: Returns the collection of filtered columns.

* `CurrentFilterObject`: Returns the filter object for the current filtering operation.

* `CurrentFilteringColumn`Returns the name of the column currently being filtered.

Access these properties in the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event handler:

```typescript
actionComplete(args) {
	const filteredColumns = args.columns;
    const filterObject = args.currentFilterObject;
    const filteringColumn = args.currentFilteringColumn;
}
```

## Clear filters programmatically

The Data Grid provides the `clearFiltering` method to remove filter conditions and reset the grid to its original state. To clear filters on specific columns, pass the column field names as an array to the optional `fields` argument of the method.

The following example demonstrates clearing filters using the `clearFiltering` method:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/clear-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter.cs" %}
{% include code-snippet/grid/filtering/clear-filtering/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](../images/filtering/clear-fliter.gif)