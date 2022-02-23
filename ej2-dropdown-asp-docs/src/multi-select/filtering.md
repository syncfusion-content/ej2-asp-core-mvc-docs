---
title: "Multiselect Filtering"
component: "MultiSelect"
description: "This section shows the built-in filtering support with a rich set of filtering configurations in Syncfusion ASP.NET multiselect control."
---

# Filtering

The MultiSelect has built-in support to filter data items when [allowFiltering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~AllowFiltering.html) is enabled. The filter
operation starts as soon as you start typing characters in the MultiSelect input.

To display filtered items in the popup, filter the required data and return it to the MultiSelect
via `updateData` method by using the [filtering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Filtering.html) event.

The following sample illustrates how to query the data source and pass the data to the MultiSelect
through the `updateData` method in [filtering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Filtering.html) event.

{% aspTab template="multiselect/filtering/filter", sourceFiles="filter.cs,Countries.cs" %}

{% endaspTab %}

## Limit the minimum filter character

When filtering the list items, you can set the limit for character count to raise remote request and fetch
filtered data on the MultiSelect. This can be done by manual validation within the filter event handler.

In the following example, the remote request does not fetch the search data until the search key contains three characters.

{% aspTab template="multiselect/filtering/filterlimit", sourceFiles="filterlimit.cs" %}

{% endaspTab %}

## Change the filter type

While filtering, you can change the filter type to `contains`,
`startsWith`, or `endsWith` for string type within the filter event handler.

In the following examples, data filtering is done with `endsWith` type.

{% aspTab template="multiselect/filtering/filtertype", sourceFiles="filtertype.cs" %}

{% endaspTab %}

## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager. This can be done
by passing the fourth optional parameter of the `where` clause.

The following example shows how to perform case-sensitive filter.

{% aspTab template="multiselect/filtering/casesensitive", sourceFiles="casesensitive.cs" %}

{% endaspTab %}

## Diacritics Filtering

MultiSelect supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and
makes it easier to filter the results in international characters lists
when the [ignoreAccent](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~IgnoreAccent.html) is enabled.

In the following sample,data with diacritics are bound as dataSource for MultiSelect.

{% aspTab template="multiselect/filtering/diacritics", sourceFiles="diacritics.cs" %}

{% endaspTab %}

## See Also

* [How to bind the data](./data-binding/)
* [How to group the data using header](./grouping/)
* [How to add custom value to the MultiSelect](./custom-value/)