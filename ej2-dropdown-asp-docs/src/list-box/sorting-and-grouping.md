---
title: "ListBox sorting and grouping"
component: "ListBox"
description: "Angular ListBox supports sorting of items in the alphabetical order and group items based on its category."
---

# sorting and grouping

## Sorting

The ListBox supports sorting of available items in the alphabetical order that can be either ascending or descending. This can achieved using
[`sortOrder`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~SortOrder.html) property. Sort order can be `None`, `Ascending` or `Descending`.

In the following example, the `SortOrder` is set as `Descending`.

{% aspTab template="listbox/sorting-grouping/sorting", sourceFiles="sorting.cs" %}

{% endaspTab %}

## Grouping

The ListBox supports to wrap the nested element into a group based on its category. The category of each list item can be mapped with
[`groupBy`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~GroupBy.html) field in the data table.

In the following example, vegetables are grouped based on its category.

{% aspTab template="listbox/sorting-grouping/grouping", sourceFiles="grouping.cs" %}

{% endaspTab %}
