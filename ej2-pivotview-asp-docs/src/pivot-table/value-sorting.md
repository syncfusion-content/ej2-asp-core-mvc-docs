---
title: "Value Sorting"
component: "Pivot Table"
description: "Value sorting allows user to sort individual column based on the measure values."
---

# Value sorting

Value sorting allows you to sort individual column based on it's values either in ascending or descending order. It can been enabled by setting the `enableValueSorting` property to **true**. You can sort the column values by clicking the column header.

Value sorting can be configured using the `valueSortSettings` option through code behind. The settings required to sort value fields at initial rendering are:
* `headerText`: It allows to set the column header names with delimiters, that is used for value sorting.
* `headerDelimiter`: It allows to set the delimiters string to separate the given header text.
* `sortOrder`: It allows to set the sort direction of the value field.

{% aspTab template="pivot-table/value-sorting", sourceFiles="ValueSorting.cs" %}

{% endaspTab %}

## See Also

* [Sorting](./sorting)