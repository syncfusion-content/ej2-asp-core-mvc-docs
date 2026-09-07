---
layout: post
title: ##Platform_Name## Grid Grouping | Syncfusion
description: Learn how to use Grouping in ##Platform_Name## Data Grid to organize data, display aggregates, customize grouping settings, and expand or collapse records.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grouping in ASP.NET MVC Data Grid

The grouping feature in the Data Grid organizes data into a hierarchical structure, allowing grouped records to be expanded and collapsed for improved readability and analysis.

To enable grouping, set the [AllowGrouping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property to `true`. When grouping is enabled, column headers can be dragged into the group drop area to organize data.

The [GroupSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GroupSettings) property provides configuration options for customizing grouping behavior, including:

- Showing or hiding the group drop area.
- Controlling the display of grouped columns.
- Defining custom [CaptionTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) for grouped rows.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group/group.cs %}
{% endhighlight %}
{% endtabs %}

![Grouping](../images/grouping/grouping.png)

> - Columns can be grouped and ungrouped dynamically using the `groupColumn` and `ungroupColumn` methods.
> - To disable grouping for a specific column, set the `allowGrouping` property to `false` in column configuration.

## Initial group

Initial grouping in the grid is configured by assigning an array of column field names to the [GroupSettings.Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_Columns)  property. This approach is effective for organizing large datasets based on predefined criteria.

The following example groups data by "Customer ID" and "Ship City", creating a two-level hierarchy with records grouped first by "Customer ID" and then by "Ship City" within each group.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/initial-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="initial-group.cs" %}
{% include code-snippet/grid/grouping/initial-group/initial-group.cs %}
{% endhighlight %}
{% endtabs %}

![Initial group](../images/grouping/grouping-initail.png)

> To group multiple columns, specify an array of column names in the `GroupSettings.Columns` property.

## Single and multiple column grouping

The Data Grid supports grouping by one or more columns to organize data into hierarchical sections. In single-column grouping, records are grouped based on the values of a single column. In multiple-column grouping, records are grouped by multiple columns in sequence, creating nested groups that provide a more structured view of the data.

The following example demonstrates switching between single-column and multiple-column grouping using a button click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/grouping-single-multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="initial-group.cs" %}
{% include code-snippet/grid/grouping/grouping-single-multiple/group-single-multiple.cs %}
{% endhighlight %}
{% endtabs %}

![Single and multiple grouped columns](../images/grouping/grouping-single-multiple.gif)

## Prevent grouping for particular column

Some columns, such as those containing unique identifiers, may not require grouping. In such cases, grouping can be disabled by setting the [AllowGrouping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping)property to `false` in the column configuration, preventing the column header from being placed in the group drop area.

The following example prevents grouping on the "Customer ID" column. While other columns can be grouped, "Customer ID" cannot be dragged to the group drop area.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-prevent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group-prevent.cs" %}
{% include code-snippet/grid/grouping/group-prevent/group-prevent.cs %}
{% endhighlight %}
{% endtabs %}

## Hide drop area

By default, the Data Grid shows a group drop area container where column headers can be dragged to configure grouping or ungrouping. In scenarios where grouping through the drag-and-drop interface is not required, this group drop area can be hidden.

To disable the group drop area container, set the [GroupSettings.ShowDropArea](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowDropArea) property to `false`. This hides the group drop area from the UI, while still allowing grouping to be managed programmatically using the Data Grid `groupColumn` and `ungroupColumn` methods if needed.

In this example, the [Switch](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) component is used to dynamically show or hide the group drop area. When the switch is toggled, the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event updates the Data Grid's `GroupSettings.ShowDropArea` property to either display or hide the group drop area.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/hide-drop-area/razor %}
{% endhighlight %}
{% highlight c# tabtitle="hide-drop-area.cs" %}
{% include code-snippet/grid/grouping/hide-drop-area/hide-drop-area.cs %}
{% endhighlight %}
{% endtabs %}

![Hide drop area](../images/grouping/grouping-drag-hide.png)

> The group drop area is displayed only if at least one column is available for grouping.

## Show the grouped column

By default, when a column is grouped in the Data Grid, that column is hidden from the display. This keeps the layout clean and makes grouped rows easier to read. To keep grouped columns visible, set the  [GroupSettings.ShowGroupedColumn](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowGroupedColumn) property to `true`.

In the example below, a [Switch](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) component is used to control this setting. When the switch is toggled, the [change](https://ej2.syncfusion.com/angular/documentation/api/switch#change) event updates the Data Grid's `GroupSettings.ShowGroupedColumn` property, showing or hiding the grouped columns as needed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-show/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-show/group.cs %}
{% endhighlight %}
{% endtabs %}

![Show the grouped column](../images/grouping/grouping-show-hide-column.png)

## Reordering on grouped columns 

By default, grouped columns follow the order in which they are added to the group drop area. Because grouping order determines the hierarchy of data organization, modifying this order can present different structural views. For example, grouping by "Region" before "Sales Person" produces a different arrangement than the reverse.

To allow reordering, set[GroupSettings.AllowReordering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_AllowReordering) to `true`. This enables drag-and-drop rearrangement of grouped column badges, and the grid dynamically updates the data hierarchy to reflect the new order.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-reorder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="reorder.cs" %}
{% include code-snippet/grid/grouping/group-reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}

![Reordering on grouped columns](../images/grouping/grouping-reorder.gif)

## Sort groups in descending order

Grouped columns are sorted in ascending order by default (A-Z, 0-9, oldest to newest). To display grouped values in descending order (Z-A, 9-0, newest to oldest), configure the [SortSettings.Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) property by specifying the corresponding `field` and setting its `direction` to `Descending`.

Since the grouped column order is driven by the sort pipeline, ensure the `AllowSorting` property is enabled and the `SortService` is injected for this configuration to take effect.

The following example demonstrates sorting the "Customer ID" column in descending order during the grid's initial load.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-sort-descending/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-sort-descending/group.cs %}
{% endhighlight %}
{% endtabs %}

![Sort grouped columns in descending order](../images/grouping/grouping-descending-order.png)

## Group by format

By default, grouping is based on the raw data values of each row. For numeric or datetime columns, grouping can also be performed using formatted values. For example, dates can be grouped by month and numbers can be grouped by a specified range. To enable this behavior, set the `EnableGroupByFormat` property on the corresponding column.

The following example demonstrates grouping the "Order Date" and "Freight" columns using formatted values.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group-format.cs" %}
{% include code-snippet/grid/grouping/group-format/group-format.cs %}
{% endhighlight %}
{% endtabs %}

![Group by format](../images/grouping/grouping-format.png)

> Numeric columns can be grouped based on formats such as currency or percentage, while datetime columns can be grouped based on specific date or time formats.

## Group or ungroup column externally

The Data Grid supports both interactive and programmatic approaches to column grouping. Columns can be grouped manually via drag-and-drop or programmatically using the `groupColumn` and `ungroupColumn`methods.

The following example demonstrates programmatic grouping and ungrouping of columns. A [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) component is used for column selection, and the selected column is grouped or ungrouped using the Group Column and Ungroup Column buttons, which invoke the appropriate Data Grid API method

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-ungroup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-ungroup/group.cs %}
{% endhighlight %}
{% endtabs %}

![Group or ungroup column externally](../images/grouping/grouping-ungroup.gif)

## Collapse all groups on initial load

The Data Grid provides the ability to expand or collapse grouped rows, enabling better control over data visibility. This is especially useful for large datasets where an initial summarized view is preferred.

To collapse all grouped rows on initial render, use the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event in combination with the `collapseAll` method. This is shown in the example below.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-collapse-initial/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-collapse-initial/group.cs %}
{% endhighlight %}
{% endtabs %}

![Collapse all grouped rows at initial rendering](../images/grouping/group-collapse-initial.png)

All grouped rows can also be collapsed at the initial rendering using the [`groupCollapseAll`](https://ej2.syncfusion.com/angular/documentation/api/grid#groupcollapseall) method within the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. The following code snippet demonstrates this approach:

```typescript
    dataBound() {
        if (this.initial === true) {
           var grid = document.getElementById("Grid").ej2_instances[0];
           grid.groupCollapseAll();
           initial = false;
        }
    }
```
> The collapse all approach is recommended for a limited number of records since collapsing every grouped record requires time. For large datasets, [lazy-load grouping](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/grouping/lazy-load-grouping) is recommended to optimize performance. This approach is also applicable to the `groupExpandAll` method.

### Expand or collapse all groups

The Data Grid supports external control of grouped row visibility through programmatic expand and collapse. This functionality can be integrated using the grid's methods to manage grouped data display dynamically.

### Expand or collapse all grouped rows

The Data Grid enables programmatic expand and collapse of all grouped rows using the `groupExpandAll` and `groupCollapseAll`methods.

In the example below, the [Switch](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) component is used to control the visibility of grouped rows. When toggled, the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change)event triggers the appropriate method to expand or collapse all groups accordingly.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-expand-collapse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-expand-collapse/group.cs %}
{% endhighlight %}
{% endtabs %}

![Expand or collapse all grouped rows](../images/grouping/grouping-all-grouped-rows.gif)

### Expand or collapse a specific group

The Data Grid allows programmatic expand or collapse of specific grouped rows through the `expandCollapseRows` method, which toggles the state of a targeted group caption row based on its current visibility.

To implement this functionality, follow these steps:

- Capture the grouped row index via an input field.
- Use a button to trigger a method.
- Retrieve grouped rows using `querySelectorAll` method.
- Identify the target group caption element by index.
- Call `expandCollapseRows` to toggle its state.

The example below demonstrates collapsing a selected grouped row using an external button. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-selected/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-selected/group.cs %}
{% endhighlight %}
{% endtabs %}

![Expand or collapse selected grouped row](../images/grouping/grouping-selected-grouped-row.png)

## Use grouping with paging

The Data Grid component supports column grouping in combination with paging. When grouping is enabled, aggregated values and item counts are calculated based on the current page by default. As a result, group footers and caption summaries reflect only the visible page data. To include aggregate values and total item counts across all pages, set the [GroupSettings.DisablePageWiseAggregates](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_DisablePageWiseAggregates) property to `true`.

This option is useful when grouped aggregates must represent the complete dataset rather than only the records visible on the current page.

> When using remote data binding, enabling this option sends two separate requests during grouping: one to retrieve the grouped data and another to fetch aggregate values and the total item count.

## Clear grouping 

The Data Grid provides a `clearGrouping` method to remove all grouped columns programmatically. This is useful for resetting the grid to an ungrouped state.

The following example demonstrates executing `clearGrouping` through an external button click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-clearing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-clearing/group.cs %}
{% endhighlight %}
{% endtabs %}

![Clear grouping](../images/grouping/sorting-clear.gif)

## Grouping Events

The Grid component provides two events that are triggered during the group action such as [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete). The `ActionBegin` event is triggered before the group action starts, and the `ActionComplete` event is triggered after the group action is completed. You can use these events to perform any custom action based on the grouping.

The Data Grid provides two key events for handling grouping operations. These events enable the integration of custom logic before and after a grouping action:

1. [ActionBegin][ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin): Triggered before a grouping action starts. It provides details such as the group field name and `requestType`, allowing conditional logic or cancellation.

2. [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete): Triggered after a grouping action completes. It exposes the updated grid state for post-processing tasks like UI updates or data handling.

The following example demonstrates canceling grouping for the "Order ID" column using `ActionBegin` and displaying a status message via `ActionComplete`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/grouping-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="grouping-events.cs" %}
{% include code-snippet/grid/grouping/grouping-events/grouping-events.cs %}
{% endhighlight %}
{% endtabs %}

![Grouping Events](../images/grouping/sorting-events.gif)

> The `args.requestType` property represents the name of the current action being performed. For instance, during grouping, the `args.requestType` value will be **grouping**.

## Grouping constraints

`AutoFill` applies fill operations to records within the same group.

## See Also

* [Exporting grouped records](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/excel-export/excel-export-options#exporting-grouped-records)
* [Lazy load grouping](./lazy-load-grouping)
* [Group and caption aggregates](../aggregates/group-and-caption-aggregate)
* [Caption template](./caption-template)
* [Aggregates overview](../aggregates/aggregates)