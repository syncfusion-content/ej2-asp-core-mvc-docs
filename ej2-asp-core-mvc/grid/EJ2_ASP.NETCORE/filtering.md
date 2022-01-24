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
N/A |N/A | `equal` operator will always be used for date filter. |Date
N/A |N/A |`equal` operator will always be used for Boolean filter. |Boolean

{% aspTab template="grid/filtering/filter-bar", sourceFiles="filter-bar.cs" %}

{% endaspTab %}

## Filter bar template with custom component

The [`filterBarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) of **e-grid-column** is used to add a custom component for a particular column and this contains the following functions.
* **create** – It is used for creating custom components.
* **read** – It is used to read the Filter value selected.
* **write** - It is used to wire events for custom components.

In the following sample dropdown is used  as custom component in EmployeeID column.

{% aspTab template="grid/filtering/filterbartemplate", sourceFiles="filterbartemplate.cs" %}

{% endaspTab %}

### Change default filterbar operator

You can change the default filter operator by extending **filterOperators** property in [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. In the following sample,
we have changed the default operator for string typed columns as **contains** from **startsWith**.

{% aspTab template="grid/filtering/filteroptr", sourceFiles="filter.cs" %}

{% endaspTab %}

## Filter menu

You can enable filter menu by setting the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) of **e-grid-filterSettings** as **Menu**. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% aspTab template="grid/filtering/filtermenu", sourceFiles="filtermenu.cs" %}

{% endaspTab %}

> * [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as true to enable filter menu.
> * Setting [`allowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) property of **e-grid-column** as false will prevent
 filter menu rendering for a particular column.

### Enable different filter for a column

You can use both **Menu** and **CheckBox** filter in a same Grid. To do so, set the
[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Menu** in **e-grid-filterSettings** and **CheckBox** in [`filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of **e-grid-column** tag helper.

In the following sample menu filter is enabled by default and checkbox filter is enabled for the CustomerID column using the [`filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of **e-grid-column** tag helper.

{% aspTab template="grid/filtering/diffcolumnfilter", sourceFiles="diffcolumnfilter.cs" %}

{% endaspTab %}

## Excel like filter

You can enable Excel like filter by defining.
[`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Excel**.The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% aspTab template="grid/filtering/excelfilter", sourceFiles="excelfilter.cs" %}

{% endaspTab %}

## See also

* [Customizing filter menu operators list](./how-to/customizing-filter-menu-operators-list)
* [Customizing Filter Dialog by using an additional parameter](./how-to/add-params-for-filtering)
* [Hide sorting options on Excel filter Dialog](./how-to/hide-sorting-in-excel-filter)