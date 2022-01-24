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

<!-- ## Filter bar template with custom component

The `FilterBarTemplate` is used to add custom components to a particular column, and does the following functions:
* `create`: Creates custom components.
* `write`: Wires events for custom components.

In the following sample, the dropdown is used as a custom component in the EmployeeID column.

{% aspTab template="grid/filter/filterbartemplate", sourceFiles="filterbartemplate.cs" %}

{% endaspTab %} -->

### Filter bar template with custom component

The [`filterBarTemplate`] is used to add a custom component for a particular column and this contains the following functions.
* `create` – It is used for creating custom components.
* `read` – It is used to read the Filter value selected.
* `write` - It is used to wire events for custom components.

In the following sample dropdown is used  as custom component in EmployeeID column.

{% aspTab template="grid/filtering/filterbartemplate", sourceFiles="filterbartemplate.cs" %}

{% endaspTab %}

### Change default filterbar operator

You can change the default filter operator by extending `filterModule.filterOperators` property in [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_DataBound_System_String_) event. In the following sample,
we have changed the default operator for string typed columns as `contains` from `startsWith`.

{% aspTab template="grid/filtering/filteroptr", sourceFiles="filter.cs" %}

{% endaspTab %}

## Filter menu

You can enable filter menu by setting the [`FilterSettings.Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FilterSettings?lang=typescript#type-string) as `Menu`. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% aspTab template="grid/filtering/filtermenu", sourceFiles="filtermenu.cs" %}

{% endaspTab %}

> * [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as true to enable filter menu.
> * Setting [`Columns.AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) as false will prevent
 filter menu rendering for a particular column.

<!-- ### Custom component in filter menu

The `Column.Filter.ui` is used to add custom filter components to a particular column.
To implement custom filter ui, define the following functions:

* `create`:  Creates custom component.
* `write`: Wire events for custom component.
* `read`: Read the filter value from custom component.

{% aspTab template="grid/filter/customfiltermenu", sourceFiles="customfiltermenu.cs" %}

{% endaspTab %} -->

### Enable different filter for a column

You can use both `Menu` and `CheckBox` filter in a same Grid. To do so, set the
`Column.Filter.Type` as `Menu` or `CheckBox`.

In the following sample menu filter is enabled by default and checkbox filter is enabled for the CustomerID column using the
`Column.Filter.Type`.

{% aspTab template="grid/filtering/diffcolumnfilter", sourceFiles="diffcolumnfilter.cs" %}

{% endaspTab %}

## Excel like filter

You can enable Excel like filter by defining.
[`FilterSettings.Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_FilterSettings?lang=typescript#type-string) as `Excel`.The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% aspTab template="grid/filtering/excelfilter", sourceFiles="excelfilter.cs" %}

{% endaspTab %}

> * By default, while opening the excel/checkbox filter in the Grid, the filter dialog will get and display the distinct data from the first 1000 records bound to the Grid to optimize performance. The remaining records will be returned as a result of the search option of the filter dialog.
> * However, we can increase the excel/checkbox filter count by modifying the `filterChoiceCount` argument value(as per our need) in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event when the `requestType` is `filterchoicerequest` or `filtersearchbegin`. This is demonstrated in the below code snippet,

```typescript
function actionBegin(args: FilterEventArgs) {
    if (args.requestType === "filterchoicerequest" || args.requestType === "filtersearchbegin") {
        args.filterChoiceCount = 3000;
    }
}
```

## See also

* [Customizing filter menu operators list](./how-to/customizing-filter-menu-operators-list)
* [Customizing Filter Dialog by using an additional parameter](./how-to/add-params-for-filtering)
