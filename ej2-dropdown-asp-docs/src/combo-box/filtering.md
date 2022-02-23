---
title: "Combo box Filtering"
component: "ComboBox"
description: "This section for Syncfusion ASP.NET combo box control shows the built-in filtering support with a rich set of filtering configurations."
---

# Filtering

The ComboBox has built-in support to filter data items when [allowFiltering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~AllowFiltering.html) is enabled. The filter
operation starts as soon as you start typing characters in the control.

To display filtered items in the popup, filter the required data and return it to the ComboBox
via `updateData` method by using the [filtering](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~Filtering.html) event.

The following sample illustrates how to query the data source and pass the data to the ComboBox
through the `updateData` method in `filtering` event.

{% aspTab template="combobox/filtering/filter", sourceFiles="filter.cs,Countries.cs" %}

{% endaspTab %}

## Limit the minimum filter character

When filtering the list items, you can set the limit for character count to raise remote request and fetch
filtered data on the ComboBox. This can be done by manual validation within the filter event handler.

In the following example, the remote request does not fetch the search data until the search key contains three characters.

{% aspTab template="combobox/filtering/filterlimit", sourceFiles="filterlimit.cs" %}

{% endaspTab %}

## Change the filter type

While filtering, you can change the filter type to `contains`,
`startsWith`, or `endsWith` for string type within the filter event handler.

In the following examples, data filtering is done with `endsWith` type.

{% aspTab template="combobox/filtering/filtertype", sourceFiles="filtertype.cs" %}

{% endaspTab %}

## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager. This can be done
by passing the fourth optional parameter of the `where` clause.

The following example shows how to perform case-sensitive filter.

{% aspTab template="combobox/filtering/casesensitive", sourceFiles="casesensitive.cs" %}

{% endaspTab %}

## Diacritics filtering

ComboBox supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and
makes it easier to filter the results in international characters lists
when the [`ignoreAccent`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~IgnoreAccent.html) is enabled.

In the following sample,data with diacritics are bound as dataSource for ComboBox.

{% aspTab template="combobox/filtering/diacritics", sourceFiles="diacritics.cs" %}

{% endaspTab %}

## See Also

* [How to acheive autofill while filtering](./how-to/autofill)
* [How to group the data using header](./grouping/)
