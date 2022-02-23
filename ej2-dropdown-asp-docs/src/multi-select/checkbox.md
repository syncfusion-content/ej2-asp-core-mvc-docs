---
title: "Multiselect Checkbox"
component: "MultiSelect"
description: "This sample for Syncfusion ASP.NET multiselect control demonstrates the built-in support to select the multiple values through checkbox."
---

# CheckBox

The MultiSelect has built-in support to select multiple values through checkbox,
when [mode](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Mode.html) property set as `CheckBox`.

To use checkbox, inject the `CheckBoxSelection` module in the MultiSelect.

{% aspTab template="multiselect/checkbox/default", sourceFiles="arrayofobjects.cs,GameList.cs" %}

{% endaspTab %}

## Select All

The MultiSelect control has in-built support to select the all list items using `Select All` options in the header.

When the [showSelectAll](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~ShowSelectAll.html) property is set to true, by default Select All text will show.
You can customize the name attribute of the Select All option by using
[selectAllText](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~SelectAllText.html).

For the unSelect All option, by default unSelect All text will show.
You can customize the name attribute of the unSelect All option by using
`unSelectAllText`.

{% aspTab template="multiselect/checkbox/selectall", sourceFiles="arrayofobjects.cs,GameList.cs" %}

{% endaspTab %}

## Selection Limit

Defines the limit of the selected items using [maximumSelectionLength](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~MaximumSelectionLength.html).

{% aspTab template="multiselect/checkbox/limits", sourceFiles="arrayofobjects.cs,GameList.cs" %}

{% endaspTab %}

## Selection Reordering

Using [enableSelectionOrder](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~EnableSelectionOrder.html) to Reorder the selected items in popup visibility state.

{% aspTab template="multiselect/checkbox/reorder", sourceFiles="arrayofobjects.cs,gamelist.cs" %}

{% endaspTab %}

## See Also

* [How to bind the data](./data-binding/)
* [How to filter the bound data](./filtering/)
* [How to add custom value to the MultiSelect](./custom-value/)
* [How to render checkbox in grouping to the MultiSelect](./grouping/#grouping-with-checkbox).
