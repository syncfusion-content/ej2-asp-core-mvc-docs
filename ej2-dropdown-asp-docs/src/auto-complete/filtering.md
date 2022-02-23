---
title: "Autocomplete Filtering"
component: "AutoComplete"
description: "This section for Syncfusion ASP.NET autocomplete control shows the built-in filtering support with a rich set of filtering configurations."
---

# Filtering

The AutoComplete has built-in support to filter data items. The filter operation
starts as soon as you start typing characters in the control.

## Change the filter type

Determines on which filter type, the control needs to be considered on search action.
The available [filterType](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~FilterType.html) and its supported data types are

| **Filter Type** | **Description** | **Supported Types** |
| --- | --- |
| StartsWith | Checks whether a value begins with the specified value. | String |
| EndsWith | Checks whether a value ends with specified value. | String |
| Contains | Checks whether a value contains with specified value. | String |

The following examples shows the data filtering is done with `StartsWith` type.

{% aspTab template="autocomplete/filtering/filtertype", sourceFiles="filtertype.cs" %}

{% endaspTab %}

## Filter item count

You can specify the filter suggestion item count through
[suggestionCount](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~SuggestionCount.html) property of AutoComplete.

The following example, to restrict the suggestion list item counts as 5.

{% aspTab template="autocomplete/filtering/filtercount", sourceFiles="filtercount.cs" %}

{% endaspTab %}

## Limit the minimum filter character

You can set the limit for the character count to filter the data on the AutoComplete. This can be done by
set the [minLength](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~MinLength.html) property to AutoComplete.

In the following example, the remote request doesn't fetch the search data, until the search key contains three characters.

{% aspTab template="autocomplete/filtering/filterlimit", sourceFiles="filterlimit.cs" %}

{% endaspTab %}

## Case sensitive filtering

Data items can be filtered either with or without case sensitivity using the DataManager.
This can be done by setting the [ignoreCase](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~IgnoreCase.html) property of AutoComplete.

The following sample depicts how to filter the data with case-sensitive.

{% aspTab template="autocomplete/filtering/casesensitive", sourceFiles="casesensitive.cs" %}

{% endaspTab %}

## Diacritics filtering

An AutoComplete supports diacritics filtering which will ignore the [diacritics](https://en.wikipedia.org/wiki/Diacritic) and
makes it easier to filter the results in international characters lists
when the [ignoreAccent](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~IgnoreAccent.html) is enabled.

In the following sample,data with diacritics are bound as dataSource for AutoComplete.

{% aspTab template="autocomplete/filtering/diacritics", sourceFiles="diacritics.cs" %}

{% endaspTab %}

## See Also

* [How to acheive autofill while filtering](./how-to/autofill/)
* [How to group the data using header](./grouping/)
* [How to highlight the search data](./how-to/custom-search/)
