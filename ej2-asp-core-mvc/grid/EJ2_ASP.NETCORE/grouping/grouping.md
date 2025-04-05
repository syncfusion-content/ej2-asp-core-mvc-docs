---
layout: post
title: Grouping in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grouping in ASP.NET Core Grid component

The grouping feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid allows you to organize data into a hierarchical structure, making it easier to expand and collapse records. You can group the columns by simply dragging and dropping the column header to the group drop area. To enable grouping in the grid, you need to set the [allowGrouping](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property to **true**. Additionally, you can customize the grouping options using the [groupSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_GroupSettings) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group/group.cs %}
{% endhighlight %}
{% endtabs %}

![Grouping](../images/grouping/grouping.png)

> * You can group and ungroup columns in the Grid by using the `groupColumn` and `ungroupColumn` methods respectively.
> * To disable grouping for a specific column, set the `columns.allowGrouping` to **false**.

## Initial group

To enable initial grouping in the Grid, you can use the [groupSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_GroupSettings) property and set the [groupSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_Columns) property to an array of column names(`field` of the column) that you want to group by. This feature is particularly useful when working with large datasets, as it allows you to quickly organize and analyze the data based on specific criteria.

The following example demonstrates how to set an initial grouping for the **CustomerID** and **ShipCity** columns during the initial rendering grid, by using the `groupSettings.columns` property. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/initial-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="initial-group.cs" %}
{% include code-snippet/grid/grouping/initial-group/initial-group.cs %}
{% endhighlight %}
{% endtabs %}

![Initial group](../images/grouping/grouping-initail.png)

> You can group by multiple columns by specifying an array of column names in the columns property of the `groupSettings`. 

## Prevent grouping for particular column

The Grid component provides the ability to prevent grouping for a particular column. This can be useful when you have certain columns that you do not want to be included in the grouping process. It can be achieved by setting the [allowGrouping](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping) property of the particular `column` to **false**. The following example demonstrates, how to disable grouping for **CustomerID** column. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-prevent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group-prevent.cs" %}
{% include code-snippet/grid/grouping/group-prevent/group-prevent.cs %}
{% endhighlight %}
{% endtabs %}

## Hide drop area

By default, the Grid provides a drop area for grouping columns. This drop area allows you to drag and drop columns to group and ungroup them. However, in some cases, you may want to prevent ungrouping or further grouping a column after initial grouping.

To hide the drop area in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid, you can set the [groupSettings.showDropArea](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowDropArea) property to **false**. 

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added to hide or show the drop area. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered and the `groupSettings.showDropArea` property of the grid is updated accordingly. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/hide-drop-area/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="hide-drop-area.cs" %}
{% include code-snippet/grid/grouping/hide-drop-area/hide-drop-area.cs %}
{% endhighlight %}
{% endtabs %}

![Hide drop area](../images/grouping/grouping-drag-hide.png)

> By default, the group drop area will be shown only if there is at least one column available to group.

## Show the grouped column

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid has a default behavior where the grouped column is hidden, to provide a cleaner and more focused view of your data. However, if you prefer to show the grouped column in the grid, you can achieve this by setting the [groupSettings.showGroupedColumn](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_ShowGroupedColumn) property to **true**.

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added to hide or show the grouped columns. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered and the `groupSettings.showGroupedColumn` property of the grid is updated accordingly. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-show/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-show/group.cs %}
{% endhighlight %}
{% endtabs %}

![Show the grouped column](../images/grouping/grouping-show-hide-column.png)

## Reordering on grouped columns 

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid allows you to easily reorder the grouped columns by dragging and dropping the grouped header cells in the group drag area. By changing the order of the grouped columns, the corresponding changes are automatically reflected in the grouping hierarchy of the grid. The grid dynamically adjusts the grouping based on the reordered columns in the group drag area. Additionally, you can also drop new columns into specific positions within the group drag area.

To enable this feature, you have to set the [groupSettings.allowReordering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_AllowReordering) property as **true**. This is demonstrated in the sample below.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-reorder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="reorder.cs" %}
{% include code-snippet/grid/grouping/group-reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}

![Reordering on grouped columns](../images/grouping/grouping-reorder.gif)

## Sort grouped columns in descending order during initial grouping

By default, grouped columns are sorted in ascending order. However, you can sort them in descending order during initial grouping by setting the `field` and `direction` in the [sortSettings.columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSortSettings.html#Syncfusion_EJ2_Grids_GridSortSettings_Columns) property.

The following example demonstrates how to sort the **CustomerID** column by setting the `sortSettings.columns` property to **Descending** during the initial grouping of the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-sort-descending/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-sort-descending/group.cs %}
{% endhighlight %}
{% endtabs %}

![Sort grouped columns in descending order](../images/grouping/grouping-descending-order.png)

## Group with paging

The Grid component supports grouping columns with paging feature. When grouping is applied, the grid displays aggregated information and total items based on the current page. However, by default, the group footer and group caption footer does not consider the aggregated information and total items from other pages. To get additional details from other pages, set the [groupSettings.disablePageWiseAggregates](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_DisablePageWiseAggregates) property to **false**.

> If remote data is bound to grid dataSource, two requests will be sent when performing grouping action one for getting the grouped data and another for getting aggregate details and total items count.

## Group by format

By default, columns are grouped by the data or value present for the particular row. However, you can also group numeric or datetime columns based on the specified format. To enable this feature, you need to set the `enableGroupByFormat` property of the corresponding grid column. This feature allows you to group numeric or datetime columns based on a specific format.

The following example demonstrates how to perform a group action using the `enableGroupByFormat` property for the  **OrderDate** and **Freight** columns of the grid. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group-format.cs" %}
{% include code-snippet/grid/grouping/group-format/group-format.cs %}
{% endhighlight %}
{% endtabs %}

![Group by format](../images/grouping/grouping-format.png)

> Numeric columns can be grouped based on formats such as currency or percentage, while datetime columns can be grouped based on specific date or time formats.

## Collapse all grouped rows at initial rendering

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid offers a convenient feature to expand or collapse grouped rows, allowing you to control the visibility of grouped data. The option is useful when dealing with a large dataset that contains many groups, and there is a need to provide a summarized view by initially hiding the details.

To collapse all grouped rows at the initial rendering of the Grid using the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event along with the `collapseAll` method.

The following example demonstrates how to collapse all grouped rows at the initial rendering.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-collapse-initial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-collapse-initial/group.cs %}
{% endhighlight %}
{% endtabs %}

![Collapse all grouped rows at initial rendering](../images/grouping/group-collapse-initial.png)

> You can also collapse all the grouped rows at the initial rendering using the `groupCollapseAll` method inside the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. This is demonstrated in the below code snippet,

```typescript
    dataBound() {
        if (this.initial === true) {
           var grid = document.getElementById("grid").ej2_instances[0];
           grid.groupCollapseAll();
           initial = false;
        }
    }
```
> The collapse all approach is suggested for a limited number of records since collapsing every grouped record takes some time. If you have a large dataset, it is recommended to use [lazy-load grouping](https://ej2.syncfusion.com/aspnetcore/documentation/grid/grouping/lazy-load-grouping). This approach is also applicable for the `groupExpandAll` method.

## Group or ungroup column externally

By default, the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid supports interaction-oriented column grouping, where users manually group columns by dragging and dropping them into the grouping area of the grid. Grid provides an ability to group and ungroup a column using `groupColumn` and `ungroupColumn` methods. These methods provide a programmatic approach to perform column grouping and ungrouping.

The following example demonstrates how to group and ungroup the columns in a grid. It utilizes the [DropDownList](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) component to select the column. When an external button is clicked, the `groupColumn` and `ungroupColumn` methods are called to group or ungroup the selected column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-ungroup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-ungroup/group.cs %}
{% endhighlight %}
{% endtabs %}

![Group or ungroup column externally](../images/grouping/grouping-ungroup.gif)

## Expand or collapse externally

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid offers a convenient feature to expand or collapse grouped rows, allowing you to control the visibility of grouped data. This section will provide guidance on enabling this functionality and integrating it into your application using the Grid properties and methods.

### Expand or collapse all grouped rows

Grid provides an ability to expand or collapse grouped rows using `groupExpandAll` and `groupCollapseAll` methods respectively.

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added to expand or collapse grouped rows. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered and the `groupExpandAll` and `groupCollapseAll` methods are called to expand or collapse grouped rows. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-expand-collapse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-expand-collapse/group.cs %}
{% endhighlight %}
{% endtabs %}

![Expand or collapse all grouped rows](../images/grouping/grouping-all-grouped-rows.gif)

### Expand or collapse selected grouped row

Expanding or collapsing selected grouped rows in a Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid involves implementing the functionality to expand or collapse grouped records programatically.

To enable the expand and collapse functionality for grouped rows in a grid, you can utilize the `expandCollapseRows` method. This method is designed to handle two scenarios such as expanding collapsed grouped records and collapsing expanded grouped records.

To implement this functionality, follow these steps:

1. Include an `input` element to capture the grouped row index.
2. Add a `button` element with a **click** event binding to trigger the **onExpandCollapseButtonClick** method. This method retrieve the grouped rows from the grid's content table using the `querySelectorAll` method.
3. Check if there are any grouped rows available.
4. If grouped rows exist, locate the group caption element based on the entered row index.
5. Call the `expandCollapseRows` method of the grid's group module, passing the group caption element to toggle its expand/collapse state.

The following example demonstrates the function that collapses the selected row using an external button click. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-selected/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-selected/group.cs %}
{% endhighlight %}
{% endtabs %}

![Expand or collapse selected grouped row](../images/grouping/grouping-selected-grouped-row.png)

## Clear grouping

The clear grouping feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid allows you to removing all the grouped columns from the grid. This feature provides a convenient way to clear the grouping of columns in your application.

To clear all the grouped columns in the Grid, you can utilize the `clearGrouping` method of the grid.

The following example demonstrates how to clear the grouping using `clearGrouping` method in the external button click.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-clearing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="group.cs" %}
{% include code-snippet/grid/grouping/group-clearing/group.cs %}
{% endhighlight %}
{% endtabs %}

![Clear grouping](../images/grouping/sorting-clear.gif)

## Grouping Events

The Grid component provides two events that are triggered during the group action such as [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) and [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete). The `actionBegin` event is triggered before the group action starts, and the `actionComplete` event is triggered after the group action is completed. You can use these events to perform any custom action based on the grouping.

1. **actionBegin event**: `actionBegin` event is triggered before the group action begins. It provides a way to perform any necessary operations before the group action takes place. This event provides a parameter that contains the current grid state, including the current group field name, requestType information and etc.

2. **actionComplete event**: `actionComplete` event is triggered after the group action is completed. It provides a way to perform any necessary operations after the group action has taken place. This event provides a parameter that contains the current grid state, including the grouped data and column information and etc.

The following example demonstrates how the `actionBegin` and `actionComplete` events work when grouping is performed. The `actionBegin` event event is used to cancel the grouping of the **OrderID** column. The `actionComplete` event is used to display a message.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/grouping-events/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="grouping-events.cs" %}
{% include code-snippet/grid/grouping/grouping-events/grouping-events.cs %}
{% endhighlight %}
{% endtabs %}

![Grouping Events](../images/grouping/sorting-events.gif)

> The `args.requestType` property represents the name of the current action being performed. For instance, during grouping, the `args.requestType` value will be **grouping**.

## Limitations

* Grouping is not compatible with the following features:
    1. Autofill

## See Also

* [Exporting grouped records](https://ej2.syncfusion.com/aspnetcore/documentation/grid/excel-export/excel-export-options#exporting-grouped-records)