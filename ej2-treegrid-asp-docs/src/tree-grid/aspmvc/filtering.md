---
title: "Filtering"
component: "TreeGrid"
description: "Learn how to filter rows in the TreeGrid using the filter bar, and menu filtering. Also learn how to use custom filter components in the TreeGrid control."
---

# Filtering

Filtering allows you to view specific or related records based on filter criteria. To enable filtering in the TreeGrid, set the [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) to true. Filtering options can be configured through [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~FilterSettings.html).

{% aspTab template="tree-grid/filtering/default-filtering", sourceFiles="defaultFiltering.cs" %}

{% endaspTab %}

> You can apply and clear filtering by using [`filterByColumn`](https://ej2.syncfusion.com/documentation/api/treegrid/#filterbycolumn) and [`clearFiltering`](https://ej2.syncfusion.com/documentation/api/treegrid/#clearfiltering) methods.
> To disable filtering for a particular column, set
[`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) to false.

## Filter Hierarchy Modes

TreeGrid provides support for a set of filtering modes with [`HierarchyMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~HierarchyMode.html) of [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~FilterSettings.html) property.
The below are the type of filter mode available in TreeGrid.

* **Parent** : This is the default filter hierarchy mode in TreeGrid. The filtered records are displayed with its parent records, if the filtered records not have any parent record then the filtered records only displayed.

* **Child** : The filtered records are displayed with its child record, if the filtered records not have any child record then the filtered records only displayed.

* **Both** : The filtered records are displayed with its both parent and child record, if the filtered records not have any parent and child record then the filtered records only displayed.

* **None** : The filtered records are only displayed.

{% aspTab template="tree-grid/filtering/filter-modes", sourceFiles="filterModes.cs" %}

{% endaspTab %}

## Initial filter

To apply the filter at initial rendering, set the filter **Predicate** object in
[`Columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Columns.html) property of [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html).

{% aspTab template="tree-grid/filtering/initial-filter", sourceFiles="initialFilter.cs" %}

{% endaspTab %}

## Filter operators

The filter operator for a column can be defined in the **Operator** property of [`Columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Columns.html) in [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html).

The available operators and its supported data types are:

Operator |Description |Supported Types
-----|-----|-----
startswith |Checks whether the value begins with the specified value. |String
endswith |Checks whether the value ends with the specified value. |String
contains |Checks whether the value contains the specified value. |String
equal |Checks whether the value is equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date
notequal |Checks for values not equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date
greaterthan |Checks whether the value is greater than the specified value. |Number &#124; Date
greaterthanorequal|Checks whether a value is greater than or equal to the specified value. |Number &#124; Date
lessthan |Checks whether the value is less than the specified value. |Number &#124; Date
lessthanorequal |Checks whether the value is less than or equal to the specified value. |Number &#124; Date

> By default, the **Operator** [`Columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Columns.html) value is **equal**.

## Filter bar

By setting the [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) to true, the filter bar row will render next to the header, which allows you to filter data. You can filter the records with different expressions depending upon the column type.

 **Filter bar expressions:**

 You can enter the following filter expressions (operators) manually in the filter bar.

Expression |Example |Description |Column Type
-----|-----|-----|-----
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

* **create**: Creates custom components.
* **write**: Wires events for custom components.

In the following sample, the dropdown is used as a custom component in the Duration column.

{% aspTab template="tree-grid/filtering/ui-template", sourceFiles="uiTemplate.cs" %}

{% endaspTab %}

### Change default Filter Bar Operator

You can change the default filter operator by extending [`filterModule.filterOperators`](https://ej2.syncfusion.com/aspnetmvc/documentation/tree-grid/filtering/#filter-operators) property in [`dataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataBound) event.

In the following sample, we have changed the default operator for string typed columns as `contains` from `startsWith`.
{% aspTab template="tree-grid/filtering/default-filter-operator", sourceFiles="default-filter-operator.cs" %}

{% endaspTab %}

## Filter menu

You can enable filter menu by setting the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Type.html) of [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html) as **Menu**. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% aspTab template="tree-grid/filtering/filter-menu", sourceFiles="filterMenu.cs" %}

{% endaspTab %}

> [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) must be set as true to enable filter menu.
> Setting [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) as false will prevent filter menu rendering for a particular column.

### Custom component in filter menu

The [`Filter.ui`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) is used to add custom filter components to a particular column. To implement custom filter ui, define the following functions:

* **create**:  Creates custom component.
* **write**: Wire events for custom component.
* **read**: Read the filter value from custom component.

In the following sample, dropdown is used as custom component in the duration column.

{% aspTab template="tree-grid/filtering/filter-menu-ui", sourceFiles="filterMenuUI.cs" %}

{% endaspTab %}

### Enable different filter for a column

You can use both **Menu** and **Excel** filter in a same TreeGrid. To do so, set the
type as **Menu** or **Excel** using [`Filter`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

In the following sample menu filter is enabled by default and excel filter is enabled for the Task Name column using the [`Filter`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

{% aspTab template="tree-grid/filtering/diffcolumnfilter", sourceFiles="diffcolumnfilter.cs" %}

{% endaspTab %}

## Excel like filter

You can enable Excel like filter by defining.
[`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Type.html) of [`FilterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html) as **Excel**.The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% aspTab template="tree-grid/filtering/excelfilter", sourceFiles="excelfilter.cs" %}

{% endaspTab %}

### Change default Excel filter Operator

You can change the default excel-filter operator by changing the column operator as `contains` from `startsWith` in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ActionBegin) event.

{% aspTab template="tree-grid/filtering/excelfilter-default-operator", sourceFiles="excelfilter-default-operator.cs" %}

{% endaspTab %}

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.
