---
layout: post
title: Lazy Load Grouping in Syncfusion ASP.NET Core Grid Component
description: Learn here all about Lazy Load Grouping in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Lazy Load Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Lazy load grouping in ASP.NET Core Grid component

In ASP.NET Core, lazy loading refers to the technique of loading data dynamically when they are needed, instead of loading everything upfront. Lazy loading can significantly improve the performance of your application by reducing the initial load time.

Lazy load grouping in Syncfusion<sup style="font-size:70%">&reg;</sup> Grid allows you to load and display grouped data efficiently by fetching only the required data on demand. This feature is useful when dealing with large datasets where loading all the data at once might affect performance. The Grid will render only the initial level caption rows in the collapsed state at grouping. The child rows of each caption will be fetched in on demand and render in the Grid when you expand the caption row.

To enable this feature, need to set the [groupSettings.enableLazyLoading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) property to **true**.

The following example demonstrates how to enable the lazy load grouping feature by setting `groupSettings.enableLazyLoading` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/lazy-load-grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="lazy-load.cs" %}
{% include code-snippet/grid/grouping/lazy-load-grouping/lazy-load.cs %}
{% endhighlight %}
{% endtabs %}

![Lazy load grouping](../images/grouping/grouping-lazyloading.png)

## Handling the lazy load grouping at server-side

When using the lazy load grouping feature of the Grid, you can use the `UrlAdaptor` of `DataManager` when binding remote data to handle the lazy load grouping at the server-side. Along with the default server request, this feature will additionally send the following details to handle the lazy load grouping:

Property Name |Description
-----|-----
`isLazyLoad` |Used to differentiate the default grouping and lazy load grouping
`onDemandGroupInfo` |Contains the details of expanded caption row grouping `level`, `skip`, `take` and `filter` query of the child records

In the server-side, you can bind these details with the `isLazyLoad` and `onDemandGroupInfo` parameters in the `DataManagerRequest` model. Please refer to the below screenshots.

![IsLazyLoad](../images/islazyload.jpg)

![OnDemandGroupInfo](../images/groupinfo.jpg)

The following code example describes lazy load grouping being handled on the server-side along with other grid actions.

```typescript
public IActionResult UrlDataSource([FromBody] DataManagerRequest dataRequest)
{
    IEnumerable groupedData = null;
    IEnumerable<Customers> dataSource = customers;
    DataOperations operation = new DataOperations();

    if (dataRequest.Search != null && dataRequest.Search.Count > 0)
    {
        dataSource = operation.PerformSearching(dataSource, dataRequest.Search);  //Search
    }
    if (dataRequest.Where != null && dataRequest.Where.Count > 0) //Filtering
    {
        dataSource = operation.PerformFiltering(dataSource, dataRequest.Where, dataRequest.Where[0].Operator);
    }
    int count = dataSource.Cast<Customers>().Count();
    if (dataRequest.IsLazyLoad == false && dataRequest.Sorted != null && dataRequest.Sorted.Count > 0) //Sorting for grouping
    {
        dataSource = operation.PerformSorting(dataSource, dataRequest.Sorted);
    }   
    if (dataRequest.IsLazyLoad == false && dataRequest.Skip != 0)
    {
        dataSource = operation.PerformSkip(dataSource, dataRequest.Skip); // Paging
    }
    if (dataRequest.IsLazyLoad == false && dataRequest.Take != 0)
    {
        dataSource = operation.PerformTake(dataSource, dataRequest.Take);
    }
    if (dataRequest.IsLazyLoad)
    {
        groupedData = operation.PerformGrouping<Customers>(dataSource, dataRequest); // Lazy load grouping
        groupedData = operation.PerformSorting(groupedData, dataRequest); // Sorting with Lazy load grouping
        if (dataRequest.OnDemandGroupInfo != null && dataRequest.Group.Count() == dataRequest.OnDemandGroupInfo.Level)
        {
            count = groupedData.Cast<Customers>().Count();
        }
        else
        {
            count = groupedData.Cast<Group>().Count();
        }
        groupedData = operation.PerformSkip(groupedData, dataRequest.OnDemandGroupInfo == null ? dataRequest.Skip : dataRequest.OnDemandGroupInfo.Skip);
        groupedData = operation.PerformTake(groupedData, dataRequest.OnDemandGroupInfo == null ? dataRequest.Take : dataRequest.OnDemandGroupInfo.Take);
    }
return dataRequest.RequiresCounts ? Json(new { result = groupedData == null ? dataSource : groupedData, count = count }) : Json(dataSource);
}

```

> For optimal performance, especially when dealing with lazy loading grouping, it is recommended to perform sorting after the grouping action.

## Lazy load grouping with infinite scrolling

Lazy loading grouping with infinite scrolling is a valuable feature in scenarios where there is a need to present grouped data, efficiently handle large datasets, and ensure a seamless experience. This feature enables loading data on demand as the interface is interacted with, ensuring optimal performance and responsiveness while effectively managing and presenting large grouped datasets

**How lazy load grouping with infinite scrolling works**

1. When you enable lazy load grouping with infinite scrolling, the Grid initially renders only the top-level caption rows in a collapsed state.

2. The child rows associated with each group caption are loaded and rendered in the Grid only when you expand the corresponding caption row.

3. Infinite scrolling enables the Grid to load additional data as the user scrolls to the end of the scrollbar.

To enable this feature, you need to set the [groupSettings.enableLazyLoading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) and [enableInfiniteScrolling](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableInfiniteScrolling) properties to **true**.

The following example demonstrates how to enable the lazy load grouping with infinite scrolling feature using the `groupSettings.enableLazyLoading` and `enableInfiniteScrolling` properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/lazy-load-grouping-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="lazy-load-grouping-scroll.cs" %}
{% include code-snippet/grid/grouping/lazy-load-grouping-scroll/lazy-load-grouping-scroll.cs %}
{% endhighlight %}
{% endtabs %}

![lazy load grouping with infinite scrolling ](../images/grouping/grouping-infinitescrolling.gif)

> * The [enableInfiniteScrolling](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableInfiniteScrolling) property is optional and can be set to **true** or **false** based on the requirement.
> * When enabling the `enableInfiniteScrolling` feature, it is necessary to define the [height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) property.

## Lazy load grouping with virtual scrolling

The lazy load grouping with virtual scrolling feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid allows you to efficiently present and analyze large grouped datasets. This feature optimizes performance, reduces initial load time, and provides smooth scrolling through the dataset. 

**How lazy load grouping with virtual scrolling works**

1. When you enable lazy load grouping with virtual scrolling, the Grid renders only the initial level caption rows in a collapsed state.

2. The child rows associated with each group caption are loaded and rendered in the Grid only when you expand the respective caption row.

3. Virtual scrolling allows the Grid to load and display a buffered set of records while scrolling vertically.

To enable this feature, you need to set the [groupSettings.enableLazyLoading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) and [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableVirtualization) properties to **true**.

The following example demonstrates how to enable the lazy load grouping with virtual scrolling feature using the `groupSettings.enableLazyLoading` and `enableVirtualization` properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-virtual/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtual-scroll.cs" %}
{% include code-snippet/grid/grouping/group-virtual/virtual-scroll.cs %}
{% endhighlight %}
{% endtabs %}

![lazy load grouping with virtual scrolling](../images/grouping/grouping-virtual-scrolling.gif)

> When using the `enableVirtualization` feature, it is necessary to define the [height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) property.

## Checkbox selection with lazy load grouping

Checkbox selection with lazy load grouping in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Grid enables row selection using checkboxes while grouped data is loaded on demand, enabling efficient bulk operations over large grouped datasets.

The [selectionSettings.persistSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_PersistSelection) property must be set to `true` to enable this feature. Additionally, one of the columns must be defined as a primary key using the [columns.isPrimaryKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property so that selection is persisted correctly across lazy-loaded groups.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/lazy-load-group-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="lazy-load-group-selection.cs" %}
{% include code-snippet/grid/grouping/lazy-load-group-selection/lazy-load-group-selection.cs %}
{% endhighlight %}
{% endtabs %}

### Checkbox selection with lazy load grouping using URL adaptor

The `UrlAdaptor` integrated with lazy load grouping and checkbox selection requires the server-side to return the `lazyLoadRecordsCount` property in the response. This value represents the total records count of the lazy-loaded group, which the Grid uses internally to correctly manage and persist checkbox selections across all records in each group, including records that have not yet been loaded.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}

<ejs-grid id="Grid" allowPaging="true" allowSorting="true" allowFiltering="true" allowGrouping="true" toolbar="@(new List<string>() {"Search"})" height="315">
    <e-data-manager url="https://localhost:xxxx/api/Grid" adaptor="UrlAdaptor"></e-data-manager>
    <e-grid-groupsettings enableLazyLoading="true" columns="@(new string[] { "CustomerID" })"></e-grid-groupsettings>
    <e-grid-selectionsettings persistSelection="true"></e-grid-selectionsettings>
    <e-grid-columns>
        <e-grid-column type="checkbox" width="50"></e-grid-column>
        <e-grid-column field="OrderID" headerText="Order ID" width="120" textAlign="Right" isPrimaryKey="true" type="number"></e-grid-column>
        <e-grid-column field="CustomerID" headerText="Customer ID" width="140" type="string"></e-grid-column>
        <e-grid-column field="ShipCity" headerText="ShipCity" width="140"></e-grid-column>
        <e-grid-column field="ShipCountry" headerText="ShipCountry" width="140"></e-grid-column>
    </e-grid-columns>
</ejs-grid>

{% endhighlight %}

{% highlight cs tabtitle="GridController.cs" %}

public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
{
    IEnumerable groupedData = null;
    IEnumerable<Transaction> DataSource = transactions;
    DataOperations operation = new DataOperations();

    if (dm.Search != null && dm.Search.Count > 0)
    {
        DataSource = operation.PerformSearching(DataSource, dm.Search);
    }
    if (dm.Where != null && dm.Where.Count > 0)
    {
        DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
    }
    if (dm.IsLazyLoad == false && dm.Sorted != null && dm.Sorted.Count > 0)
    {
        DataSource = operation.PerformSorting(DataSource, dm.Sorted);
    }

    int totalCount = DataSource.Cast<Transaction>().Count();

    if (dm.IsLazyLoad == false && dm.Skip != 0)
    {
        DataSource = operation.PerformSkip(DataSource, dm.Skip);
    }
    if (dm.IsLazyLoad == false && dm.Take != 0)
    {
        DataSource = operation.PerformTake(DataSource, dm.Take);
    }

    if (dm.IsLazyLoad)
    {
        int count = 0;
        groupedData = operation.PerformGrouping<Transaction>(DataSource, dm);
        groupedData = operation.PerformSorting(groupedData, dm);

        if (dm.OnDemandGroupInfo != null && dm.Group.Count() == dm.OnDemandGroupInfo.Level)
        { 
            count = groupedData.Cast<Transaction>().Count();
        }
        else
        {
            count = groupedData.Cast<Group>().Count();
        }

        groupedData = operation.PerformSkip(groupedData, dm.OnDemandGroupInfo?.Skip ?? dm.Skip);
        groupedData = operation.PerformTake(groupedData, dm.OnDemandGroupInfo?.Take ?? dm.Take);

        return dm.RequiresCounts ? Json(new { result = groupedData ?? DataSource, count = count, lazyLoadRecordsCount = totalCount }) : Json(DataSource);
    }

    return dm.RequiresCounts ? Json(new { result = groupedData ?? DataSource, count = totalCount }) : Json(DataSource);
}

{% endhighlight %}
{% endtabs %}

## Limitations for lazy load grouping

* Due to the element height limitation in browsers, the maximum number of records loaded by the grid is limited due to the browser capability.
* Lazy load grouping is only supported by the `UrlAdaptor` and `JsonAdaptor` adaptors.
* Lazy load grouping is not compatible with the following features
    * Batch editing
    * Row template
    * Print
    * Row drag and drop in collapsed group
    * ExpandAll method   
    * Column virtualization
    * Hierarchical Grid
    * Detail Template
    * Row and Cell Spanning  
* Programmatic selection is not supported  in lazy load grouping.
* Drag selection, Cell selection (box and flow), Row Selection is not working in collapsed state.
* Clipboard is not support when the groups are in collapsed state.
* When using lazy load grouping, checkbox selection is restricted to rows visible within the viewport. Features like range selection via (Shift + Click) and header checkbox selection are not supported, as dynamically loaded data can cause row index mismatches.