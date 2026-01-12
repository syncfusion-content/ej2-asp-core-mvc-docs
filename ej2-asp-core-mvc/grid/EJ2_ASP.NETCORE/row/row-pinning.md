---
layout: post
title: Row Pinning in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Row Pinning in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Pinning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Pinning in EJ2 ASP.NET Core Grid Control

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid control provides option to pin specific rows at the top, ensuring important information remains visible while scrolling vertically. This feature is useful when you want to keep specific rows always visible for quick reference or priority viewing, regardless of user interactions.

To enable the row pinning feature, configure the [isRowPinned](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_IsRowPinned) callback function, which returns **true** or **false** based on the required condition. The function receives each row's data as input, allowing the pinning logic to be determined. It executes only during initial rendering, ensuring that any condition defined within it is evaluated during that initial stage.

This functionality does not change the grid's overall content height, keeping the content area fully visible and scrollable even when multiple rows are pinned. This behavior prevents pinned rows from overlapping or obscuring the scrollable content, maintaining a consistent layout and smooth scrolling experience. Pinned rows are displayed in a fixed region above the content area, while the grid preserves its original height and continues to provide unobstructed interaction with all other rows.
 
The following example pins rows with "Critical" priority and "Open" status at the top using the `isRowPinned` callback function.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-pinning-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="row-pinning.cs" %}
{% include code-snippet/grid/row/row-pinning-cs1/row-pinning.cs %}
{% endhighlight %}
{% endtabs %}

> Pinning rows requires a primary key column for mapping the pinned rows to their original records. To define the primary key, set [columns->isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) to **true** in particular column.

## Paging with row pinning

Row pinning in the Grid control keeps important rows visible at the top while navigating through pages. Pinned rows are not counted as part of the page size and remain fixed at the top of the grid. For example, if  [pageSettings->pageSize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize) is set to "10" and "2" rows are pinned, those "2" rows stay at the top, and the grid displays "10" additional rows beneath them. When moving to another page, the pinned rows remain fixed at the top, and the next set of  "10" records is rendered below.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-pinning-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="row-pinning.cs" %}
{% include code-snippet/grid/row/row-pinning-cs2/row-pinning.cs %}
{% endhighlight %}
{% endtabs %}

## Pinned rows selection

Pinned rows can be selected in the same way as regular rows. Their selection state is always synchronized with the corresponding data rows through the primary key value. This ensures consistent behavior during all grid operations, including paging, sorting, and filtering. Whether selection is performed using the mouse, keyboard, or checkbox selection, pinned rows always display the same selection state as their associated data rows.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-pinning-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="row-pinning.cs" %}
{% include code-snippet/grid/row/row-pinning-cs3/row-pinning.cs %}
{% endhighlight %}
{% endtabs %}

> The [selectionSettings->persistSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_PersistSelection) will be automatically enabled when pinning the rows using the `isRowPinned` callback function.

## Filtering and sorting with pinned rows

Row pinning remains fully compatible with filtering and sorting operations in the Grid. When a filter is applied, both the pinned section and the scrollable content display only the rows that meet the filter criteria, ensuring consistent and predictable results. This unified filtering behavior keeps the interface clear and prevents mismatches between pinned and unpinned data.
 
When sorting is applied to any column, pinned rows are reordered using the same sorting rules while remaining fixed at the top of the grid. This ensures that pinned rows stay visible and correctly positioned, even as the rest of the data is reorganized. The combined behavior provides a smooth and intuitive experience, allowing data to be refined and analyzed without losing visibility of important pinned records.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-pinning-cs4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="row-pinning.cs" %}
{% include code-snippet/grid/row/row-pinning-cs4/row-pinning.cs %}
{% endhighlight %}
{% endtabs %}

## CRUD operations with row pinning

Row pinning fully supports CRUD operations by keeping pinned rows and their corresponding original rows synchronized. Any edit, update, or deletion applied to a pinned row is immediately reflected in the original row, and any change made to the original row is likewise mirrored in the pinned row. This ensures consistent and accurate data across both views.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-pinning-cs5/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="row-pinning.cs" %}
{% include code-snippet/grid/row/row-pinning-cs5/row-pinning.cs %}
{% endhighlight %}
{% endtabs %}

## Dynamic row pinning

Row pinning provides dynamic control through the built-in context menu, allowing quick actions to pin or remove pinned rows. Using options such as `PinRow` and `UnpinRow`, any row can be right-clicked to pin it to the top or quickly remove it from the pinned section.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-pinning-cs6/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="row-pinning.cs" %}
{% include code-snippet/grid/row/row-pinning-cs6/row-pinning.cs %}
{% endhighlight %}
{% endtabs %}

## Limitation

Row pinning is not compatible with the following features:

* Column and row spanning
* Row template
* Detail template
* Row drag and drop
* Grouping
* Aggregate
* Cell selection
* Frozen rows
* Excel and PDF export
* Adaptive UI
