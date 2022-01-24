---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Filtering of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

= |=value |equal |Number
!= |!=value |notequal |Number
> |>value |greaterthan |Number
< |<value |lessthan |Number
>= |>=value |greaterthanorequal |Number
<=|<=value|lessthanorequal |Number
* |*value |startswith |String
% |%value |endswith |String
N/A |N/A | `Equal` operator will always be used for date filter. |Date
N/A |N/A |`Equal` operator will always be used for Boolean filter. |Boolean

{% aspTab template="tree-grid/filtering/default-filtering", sourceFiles="defaultFiltering.cs" %}

{% endaspTab %}

### Filter bar template with custom component

The [`FilterBarTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~FilterBarTemplate.html) is used to add custom components to a particular column, and does the following functions:
* `create`: Creates custom components.
* `write`: Wires events for custom components.

In the following sample, the dropdown is used as a custom component in the Duration column.

{% aspTab template="tree-grid/filtering/ui-template", sourceFiles="uiTemplate.cs" %}

{% endaspTab %}

## Filter menu

You can enable filter menu by setting the [`FilterSettings.Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Type.html) as `Menu`. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% aspTab template="tree-grid/filtering/filter-menu", sourceFiles="filterMenu.cs" %}

{% endaspTab %}

> * [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) must be set as true to enable filter menu.
> * Setting [`Columns.AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html) as false will prevent filter menu rendering for a particular column.

### Custom component in filter menu

The [`Column.Filter.ui`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) is used to add custom filter components to a particular column. To implement custom filter ui, define the following functions:

* `create`:  Creates custom component.
* `write`: Wire events for custom component.
* `read`: Read the filter value from custom component.

In the following sample, dropdown is used  as custom component in the duration column.

{% aspTab template="tree-grid/filtering/filter-menu-ui", sourceFiles="filterMenuUI.cs" %}

{% endaspTab %}

### Enable different filter for a column

You can use both `Menu` and `Excel` filter in a same TreeGrid. To do so, set the
`Column.Filter.Type` as `Menu` or `Excel`.

In the following sample menu filter is enabled by default and excel filter is enabled for the Task Name column using the [`Column.Filter.Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html).

{% aspTab template="tree-grid/filtering/diffcolumnfilter", sourceFiles="diffcolumnfilter.cs" %}

{% endaspTab %}

## Excel like filter

You can enable Excel like filter by defining.
[`FilterSettings.Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Type.html) as `Excel`.The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% aspTab template="tree-grid/filtering/excelfilter", sourceFiles="excelfilter.cs" %}

{% endaspTab %}
