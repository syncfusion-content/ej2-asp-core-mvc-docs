---
layout: post
title: Grouping Bar in ##Platform_Name## Pivot Table Component
description: Learn here all about Grouping Bar in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping bar in ASP.NET Core Pivot Table component

The Grouping Bar option in the Pivot Table automatically displays fields from the bound data source. It allows users to drag and drop fields between different axes such as columns, rows, values, and filters to create a pivot table at runtime. You can enable it by setting the [`showGroupingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**.

The grouping bar provides intuitive interactions similar to the Field List, making report creation accessible to all users. These interactions include:

* Re-arranging fields through drag-and-drop operations between row, column, value, and filter axes.
* Removing fields from the existing report using the remove icon.
* Adding fields to the report using the fields panel option.
* Filtering members of specific fields using the filter icon.
* Sorting members of specific fields using the sort icon.

To use the grouping bar, you need to inject the `GroupingBar` module in the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Groupingbar.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/groupingbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Groupingbar.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/groupingbar/groupingbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/gs_groupingbar.png)

The grouping bar offers additional options to modify its appearance and behavior using the [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) property.

## Show or hide fields panel

The fields panel appears above the grouping bar and shows all the fields that are available in the data source but not currently used in the Pivot Table report. Users can drag and drop these fields into the appropriate axes (rows, columns, values, or filters) to build their desired Pivot Table layout. When a field is removed from any axis, it automatically returns to the fields panel for reuse.

To display the fields panel, set the [`showFieldsPanel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFieldsPanel) property to **true** within the [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) configuration.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/showFieldsPanel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowFieldsPanel.cs" %}
{% include code-snippet/pivot-table/grouping-bar/showFieldsPanel/showFieldsPanel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/showFieldsPanel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowFieldsPanel.cs" %}
{% include code-snippet/pivot-table/grouping-bar/showFieldsPanel/showFieldsPanel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/showfieldspanel.png)

## Show or hide all filter icon

The Grouping Bar provides an option to filter members of specific fields during runtime in the Pivot Table. To filter members in a field, click the filter icon next to the field name and select or deselect the members you want to display. 

By default, the filter icon appears next to each field in the grouping bar. If you want to hide the filter icon, set the [`showFilterIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFilterIcon) property to **false** within the [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) configuration.

> By default, the filter icon is enabled in the grouping bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowFilter.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter/ShowFilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowFilter.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter/ShowFilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-filter.png)

## Show or hide specific filter icon

By default, the filter icon appears for all fields in the grouping bar. To hide the filter icon for specific fields, set the [`showFilterIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowFilterIcon) to **false** to the corresponding field in [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html). This lets you control which fields can be filtered, providing a cleaner and more focused user interface.

In the sample below, the filter icons for the "Quarter" and "Products" fields are hidden.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowFilter.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter-specific/ShowFilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowFilter.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-filter-specific/ShowFilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-filter-specific.png)

## Show or hide all sort icon

The Grouping Bar provides an option to sort members of a particular field in either ascending or descending order at runtime. To sort a field, click the sort icon next to the field name. To reverse the sort direction, click the same sort icon again. By default, the sort icon is displayed next to each field in the grouping bar, and members are arranged in ascending order. 

To disable the sort option, set the [`showSortIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFilterIcon) property to **false** within the [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) configuration.

> By default, the sort icon is enabled in the grouping bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSort.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort/ShowSort.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSort.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort/ShowSort.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-sort.png)

## Show or hide specific sort icon

You can choose to show or hide the sort icon for individual fields in the Pivot Table's grouping bar. To hide the sort icon for a particular field, set the [`showSortIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSortIcon) property to **false** for that field in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) property.

In the example below, the sort icons for the "Quarter" and "Country" fields are hidden in the grouping bar. This allows users to prevent sorting for these fields while keeping other fields sortable.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSort.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort-specific/ShowSort.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowSort.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-sort-specific/ShowSort.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-sort-specific.png)

## Show or hide all remove icon

The grouping bar in the Pivot Table lets users remove any field at runtime by clicking the remove icon next to the field. By default, the remove icon is visible beside each field in the grouping bar. 

If you want to hide the remove icon, set the [`showRemoveIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowFilterIcon) property to **false** within the [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) configuration. This will prevent users from removing fields directly from the grouping bar.

> Note: The remove icon is enabled in the grouping bar by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowRemove.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove/ShowRemove.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowRemove.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove/ShowRemove.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-remove.png)

## Show or hide a specific remove icon

You can hide the remove icon for an individual field button in the Pivot Table grouping bar. To do this, set the [`showRemoveIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowRemoveIcon) property to **false** for the desired field within the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) options.

In the example below, the remove icon for the "Year", "Sold", and "Products" fields has been hidden. This helps prevent users from accidentally removing those fields while interacting with the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowRemove.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove-specific/ShowRemove.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowRemove.cs" %}
{% include code-snippet/pivot-table/grouping-bar/show-remove-specific/ShowRemove.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-remove-specific.png)

## Disable all fields from dragging

In the Pivot Table, the grouping bar lets users move fields between the row, column, value, and filter axes to change the report as needed. By default, all fields can be moved using drag-and-drop in the grouping bar. To prevent users from dragging any fields, set the [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_AllowDragAndDrop) option in [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html) to **false**. This will lock the layout of the current report, so users cannot rearrange fields in the grouping bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/drag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drag.cs" %}
{% include code-snippet/pivot-table/grouping-bar/drag/drag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/drag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drag.cs" %}
{% include code-snippet/pivot-table/grouping-bar/drag/drag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/gbar_drag.png)

## Disable specific field from dragging

You can prevent users from dragging certain fields in the grouping bar of the Pivot Table. To do this, set the [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_AllowDragAndDrop) property to **false** for the specific field within the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the example below, users cannot drag the "Year" and "Products" fields. This setting helps you control which fields can be arranged in the column, row, value, or filter axes at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/drag-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drag.cs" %}
{% include code-snippet/pivot-table/grouping-bar/drag-specific/drag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/drag-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drag.cs" %}
{% include code-snippet/pivot-table/grouping-bar/drag-specific/drag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Remove specific field(s) from displaying

When you bind a report to the Pivot Table, all fields from the data source are automatically displayed in the Grouping Bar. However, you can hide specific fields from appearing in the Grouping Bar to simplify the user interface.

To exclude specific fields, add the field names to the [`excludeFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ExcludeFields) property within the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) configuration. This prevents the selected fields from being displayed in the Grouping Bar while keeping them available in the underlying data source.

> **Note:** When you exclude fields using the `excludeFields` property, these fields will also be hidden in the field list UI. For more information about field list behavior, refer to this [link](https://ej2.syncfusion.com/angular/documentation/pivotview/field-list/#remove-specific-fields-from-displaying).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/removespecific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Removespecific.cs" %}
{% include code-snippet/pivot-table/grouping-bar/removespecific/removespecific.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/removespecific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Removespecific.cs" %}
{% include code-snippet/pivot-table/grouping-bar/removespecific/removespecific.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/excludefieldgroupingbar.png)

## Changing aggregation type of value fields at runtime

Users can easily perform calculations on groups of values in the Pivot Table by using the aggregation option. Each value field in the Pivot Table appears in the grouping bar with a dropdown icon next to it. This icon lets users select a different aggregation type, such as Sum, Average, or Count, at runtime. When an aggregation type is selected, the Pivot Table values update immediately to reflect the new calculation.

By default, the icon for setting the aggregation type is visible in the grouping bar. To hide this icon, set the [`showValueTypeIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html#Syncfusion_EJ2_PivotView_PivotViewGroupingBarSettings_ShowValueTypeIcon) property to **false** inside [`e-groupingBarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGroupingBarSettings.html). For more details about aggregation options, see the [aggregation](./aggregation) section.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation.cs" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation/aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation.cs" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation/aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD012 -->
![output](images/aggregation_gb_icon.png "Icon to change aggregation type")
<br/>
<br/>
<br/>
![output](images/aggregation_gb_menu.png "List of pre-defined aggregation types")

## Show or hide specific dropdown icon

You can hide the dropdown icon for a particular field button in the Pivot Table’s grouping bar. To do this, set the [`showValueTypeIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowValueTypeIcon) property to **false** for the desired field within the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

In the following example, the dropdown icon for the "Sold" field is hidden:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation-specific.cs" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-specific/aggregation-specific.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation-specific.cs" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-specific/aggregation-specific.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbar-dropdown-specific.png)

> The following properties—[`showFilterIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowFilterIcon), [`showSortIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSortIcon), [`showValueTypeIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowValueTypeIcon), and [`allowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_AllowDragAndDrop)—in the fields of [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) apply to both the grouping bar and field list.

## Show values button

The **Values** button appears in the grouping bar when the [`showValuesButton`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowValuesButton) property is set to **true**. This button can be moved to a different position among the fields in either the column or row axis while working with the Pivot Table. To enable this option, set [`showValuesButton`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowValuesButton) to **true** in the `Pivot Table` settings.

> This option is available only when using relational data sources.

> The Values button is displayed only when multiple fields are added to the Values axis. It is not shown when a single field is present.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/groupingbar-valuesbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Groupingbar-valuesbutton.cs" %}
{% include code-snippet/pivot-table/grouping-bar/groupingbar-valuesbutton/groupingbar-valuesbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/groupingbar-valuesbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Groupingbar-valuesbutton.cs" %}
{% include code-snippet/pivot-table/grouping-bar/groupingbar-valuesbutton/groupingbar-valuesbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/groupingbarvaluebutton.png)

## Event

### OnFieldDropped

The [`onFieldDropped`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnFieldDropped) event in the Pivot Table triggers whenever a user moves and drops a field into a new axis, such as columns, rows, values, or filters. This event provides the following parameters:

- `dataSourceSettings`: Defines the current report in the Pivot Table.
- `droppedAxis`: Defines the axis where the field has been dropped.
- `droppedField`: Defines the dropped field item.
- `droppedPosition`: Defines the position where the field has been dropped.

For example, you can use this event to change the caption of the `droppedField` instantly at runtime when a user moves a field to a different axis.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-dropped/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Field-dropped.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-dropped/field-dropped.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-dropped/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Field-dropped.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-dropped/field-dropped.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### FieldDragStart

The [`fieldDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDragStart) event is triggered when a field begins to be dragged from its axis in the Pivot Table. Users can use this event to limit or prevent the drag action based on certain conditions. The event provides the following parameters:

- `fieldName`: This parameter contains the name of the field being dragged.
- `fieldItem`: This parameter holds the complete details of the field as described in the `dataSourceSettings`.
- `axis`: This specifies the axis (such as columns, rows, values, or filters) from which the field is being dragged.
- `cancel`: This boolean property can be set to **true** by the user to prevent the selected field from being dragged.
- `dataSourceSettings`: This property returns the current `dataSourceSettings` used in the Pivot Table.

In the following example, the drag action is prevented only for fields placed in the rows axis. Users will not be able to drag fields from the rows axis, but can still drag fields from other axes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-drag-start/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Field-drag-start.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-drag-start/field-drag-start.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-drag-start/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Field-drag-start.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-drag-start/field-drag-start.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### FieldDrop

The [`fieldDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDrop) event is triggered whenever a user drags and drops a field into a different axis in the Pivot Table. This event helps users control whether a field should be allowed to move to a new axis by using the event’s parameters. The event provides the following information:

* `fieldName`: The name of the field being moved.
* `draggedAxis`: The axis where the user started dragging the field.
* `dropAxis`: The axis where the field is dropped.
* `dropPosition`: The position where the field is dropped among the fields in the target axis.
* `dropField`: The complete definition of the field as defined in the `dataSourceSettings`.
* `dataSourceSettings`: The entire configuration of the Pivot Table’s data source.
* `cancel`: A boolean value. If set to **true**, this stops the field from being dropped into the axis.

In the example below, dropping any field into the "Values" axis is prevented. This is managed by setting the `cancel` parameter to **true** when a field is dropped onto the "Values" axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Field-drop.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-drop/field-drop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Field-drop.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-drop/field-drop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### FieldRemove

The [`fieldRemove`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldRemove) event occurs when a user tries to remove a field from an axis in the Pivot Table. This event can be used to control whether a field should be removed, based on specific conditions.

The event provides the following parameters:

- `fieldName`: The name of the field that the user wants to remove.
- `fieldItem`: The full definition of the field as specified in the `dataSourceSettings`.
- `axis`: The name of the axis (row, column, value, or filter) from which the field will be removed.
- `dataSourceSettings`: The complete configuration of the Pivot Table data source.
- `cancel`: A boolean property; set this to **true** to prevent the field from being removed.

In the following example, the field "Country" cannot be removed from the report by any UI action. This is achieved by handling the [`fieldRemove`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldRemove) event and setting the `cancel` property to **true** if the field name matches "Country".

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Field-remove.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-remove/field-remove.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/field-remove/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Field-remove.cs" %}
{% include code-snippet/pivot-table/grouping-bar/field-remove/field-remove.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### AggregateMenuOpen

The [`aggregateMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateMenuOpen) event is triggered when a user clicks the dropdown icon in a value field button in the Pivot Table’s grouping bar. This event allows users to control which aggregation types appear in the dropdown menu.

The event provides the following parameters:

- `fieldName`: The name of the field for which the aggregation menu is opened.
- [`aggregateTypes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateTypes): The list of aggregation types available for the selected field.
- `displayMenuCount`: The number of options shown in the dropdown initially. By default, this value is 7.
- `cancel`: A boolean that, when set to true, prevents the dropdown menu from opening.

In the following sample, the dropdown menu for the "Amount" field is customized to show specific aggregation types.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-menu-open/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation-menu-open.cs" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-menu-open/aggregation-menu-open.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-menu-open/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Aggregation-menu-open.cs" %}
{% include code-snippet/pivot-table/grouping-bar/aggregation-menu-open/aggregation-menu-open.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/aggregatemenuopen.png)

> The [`aggregateMenuOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AggregateMenuOpen), [`fieldRemove`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldRemove), [`fieldDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDrop), [`fieldDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_FieldDragStart), and [`onFieldDropped`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_OnFieldDropped) events are available for both the grouping bar and field list.

### ActionBegin

The [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event occurs whenever an action begins in the grouping bar of the Pivot Table. These actions include sorting, filtering, changing aggregation, removing fields, or editing a calculated field using the grouping bar UI. This event helps the user identify and manage what is happening in real time. The event provides several helpful parameters:

- `dataSourceSettings`: This provides the current `report settings`, which include the input data, row fields, column fields, values, filters, formatting settings, and more.
- `actionName`: This contains the name of the action that has started. The most common actions and their respective names are:

  | Action                                 | Action Name         |
  |-----------------------------------------|---------------------|
  | Clicking the sort icon                  | Sort field          |
  | Using the filter icon                   | Filter field        |
  | Selecting aggregation in the drop-down  | Aggregate field     |
  | Clicking the remove icon                | Remove field        |
  | Clicking the edit icon                  | Edit calculated field|

- `fieldInfo`: This provides information about the selected field on which the action is performed.

> Note: This option applies only to actions performed through the field-based UI, such as filtering, sorting, removing a field from the grouping bar, editing, and changing the aggregation type.

- `cancel`: Set this property to **true** within the event to prevent the current action from being completed.

For example, in the sample below, users can restrict actions like sorting or filtering from the grouping bar by setting `args.cancel` to **true** within the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-groupingBar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-groupingBar/actionBegin-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-groupingBar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-groupingBar/actionBegin-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionComplete

The [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) event in the Pivot Table is triggered whenever a user completes a UI action in the grouping bar, such as sorting, filtering, changing the aggregation type, editing a calculated field, or removing a field. This event helps users track the specific interaction that has just been finished, supporting a smooth workflow within the Pivot Table.

The event provides the following parameters:

- `dataSourceSettings`: Contains the current `report settings`, including information about the input data, rows, columns, values, filters, and format settings used in the Pivot Table.

- `actionName`: Specifies the name of the action just completed. The table below lists possible UI actions and their corresponding action names:

  | Action                                          | Action Name               |
  |-------------------------------------------------|--------------------------|
  | Sort icon clicked                               | Field sorted             |
  | Filter icon clicked                             | Field filtered           |
  | Aggregation changed (using value type dropdown) | Field aggregated         |
  | Remove icon clicked                             | Field removed            |
  | Edit icon (calculated field) clicked            | Calculated field edited  |

- `fieldInfo`: Provides information about the field selected during the action.

  > Note: The `fieldInfo` parameter is provided only for actions related to sorting, filtering, aggregation changes, removing a field, or editing a calculated field using the grouping bar.

- `actionInfo`: Supplies detailed information about the UI action. For example, when sorting is finished, this parameter includes the sort order and the name of the field involved.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-groupingBar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-groupingBar/actionComplete-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-groupingBar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-groupingBar/actionComplete-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ActionFailure

The [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) event occurs when a user action in the Pivot Table does not complete as expected. This event helps users understand what went wrong during interactions with the grouping bar.

**Event Parameters**

- `actionName`: Identifies which user action did not succeed. The table below lists the actions and their corresponding names:

  | Action                                                | Action Name         |
  |-------------------------------------------------------|---------------------|
  | Clicking the sort icon                                | Sort field          |
  | Applying a filter using the filter icon               | Filter field        |
  | Choosing a value type from the aggregation dropdown   | Aggregate field     |
  | Removing a field by clicking the remove icon          | Remove field        |
  | Editing a calculated field using the edit icon        | Edit calculated field|

- `errorInfo`: Provides details about the error that occurred for the specific user action.

When this event is triggered, users can refer to the information in these parameters to identify the action that failed and the reason for the failure. This helps users correct issues with actions such as sorting, filtering, aggregating, removing, or editing fields in the Pivot Table's grouping bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-groupingBar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-groupingBar/actionFailure-aggregation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-groupingBar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-aggregation.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-groupingBar/actionFailure-aggregation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Change load limited data in member editor](./filtering#loading-members-on-demand)
* [Customize the icons for pivot table](./how-to/customize-the-icons-for-pivot-table)