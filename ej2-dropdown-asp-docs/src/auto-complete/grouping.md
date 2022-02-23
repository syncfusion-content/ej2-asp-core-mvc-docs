---
title: "Autocomplete Grouping"
component: "AutoComplete"
description: "This section for Syncfusion ASP.NET autocomplete control demonstrates the grouping with individual header and it's header customization."
---

# Grouping

The AutoComplete supports wrapping nested elements into a group based on different categories. The
category of each list item can be mapped through the
[groupBy](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings~GroupBy.html) field in the data table. The group
header is displayed as both inline and fixed headers. The fixed group header content
is updated dynamically on scrolling the suggestion list with its category value.

In the following sample, vegetables are grouped according on its category using `groupBy` field.

{% aspTab template="autocomplete/grouping", sourceFiles="Vegetables.cs,grouping.cs" %}

{% endaspTab %}

## Customization

The grouping header is also provided with customization option. This allows custom designing
using the
[groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~GroupTemplate.html) property for both inline and
fixed headers as referred here:

[Group Template support to AutoComplete](./templates).