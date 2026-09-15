---
layout: post
title: ##Platform_Name## Grid Lazy Load Grouping | Syncfusion
description: Learn how to use Lazy Load Grouping in ##Platform_Name## Data Grid to load grouped records on demand, improve performance, and efficiently handle large datasets.
platform: ej2-asp-core-mvc
control: Lazy Load Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Lazy Load Grouping in ASP.NET MVC Data Grid

The [Data Grid](https://www.syncfusion.com/angular-components/angular-data-grid) supports lazy load grouping, which optimizes the rendering of large datasets by loading only the required grouped data on demand. Initially, only the top-level group caption rows are rendered in a collapsed state. Child rows are fetched and displayed dynamically when a group is expanded.

To enable this feature, set the  [GroupSettings.EnableLazyLoading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) property to `true`.

The following example demonstrates configuring lazy load grouping using the `GroupSettings.EnableLazyLoading` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/lazy-load-grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="lazy-load.cs" %}
{% include code-snippet/grid/grouping/lazy-load-grouping/lazy-load.cs %}
{% endhighlight %}
{% endtabs %}

![Lazy load grouping](../images/grouping/grouping-lazyloading.png)

## Configure server-side lazy load grouping

`UrlAdaptor` of `DataManager` is used to handle server-side operations, including lazy load grouping. Along with the default server request, this feature will additionally send the following details to handle the lazy load grouping:

Property Name |Description
-----|-----
`IsLazyLoad` |Used to differentiate the default grouping and lazy load grouping
`OnDemandGroupInfo` |Contains the details of expanded caption row grouping `Level`, `Skip`, `Take` and `Filter` query of the child records

On the server side, these parameters can be accessed through the `DataManagerRequest` model to handle data retrieval based on the expanded group context. The following screenshots illustrate these request parameters.

![IsLazyLoad](../images/islazyload.jpg)

![OnDemandGroupInfo](../images/groupinfo.jpg)

The following code example demonstrates handling lazy load grouping on the server along with other grid actions.

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

Lazy load grouping with infinite scrolling is especially useful when presenting grouped data from large datasets. It allows data to be loaded on demand as groups are expanded or the scrollbar advances, ensuring efficient handling of records. This approach improves performance, maintains responsiveness, and efficiently handles extensive grouped data.

**Lazy-load grouping workflow:**

1. Initially, only top-level group caption rows are rendered in a collapsed state.

2. Child rows are fetched and displayed dynamically when a group caption is expanded.

3. Infinite scrolling loads additional data as the scrollbar reaches the end, maintaining seamless navigation.

To enable this feature, set both [GroupSettings.EnableLazyLoading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) and [EnableInfiniteScrolling](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableInfiniteScrolling) properties to `true`.

The following example demonstrates configuring lazy load grouping with infinite scrolling using these properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/lazy-load-grouping-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="lazy-load.cs" %}
{% include code-snippet/grid/grouping/lazy-load-grouping-scroll/lazy-load-grouping-scroll.cs %}
{% endhighlight %}
{% endtabs %}

![lazy load grouping with infinite scrolling ](../images/grouping/grouping-infinitescrolling.gif)

> * The `EnableInfiniteScrolling` property is optional and can be set to `true` or `false` based on the requirement.
> * When enabling the `enableInfiniteScrolling` feature, it is necessary to define the  [Height](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) property.

## Lazy load grouping with virtual scrolling

The Data Grid supports lazy load grouping with virtual scrolling to efficiently manage and display large grouped datasets. This feature improves performance, reduces initial load time, and ensures a responsive data presentation experience.

**Lazy-load grouping workflow**

1. Initially, only top-level group caption rows are rendered in a collapsed state.

2. Child rows are loaded and displayed dynamically when a group is expanded.

3. Virtual scrolling loads a buffered subset of records as needed, optimizing data rendering and memory usage.

To enable this feature, set both [GroupSettings.EnableLazyLoading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_EnableLazyLoading) and [EnableVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableVirtualization) properties to `true`.

The following example demonstrates configuring lazy load grouping with virtual scrolling using these properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/group-virtual/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtual-scroll.cs" %}
{% include code-snippet/grid/grouping/group-virtual/virtual-scroll.cs %}
{% endhighlight %}
{% endtabs %}

![lazy load grouping with virtual scrolling](../images/grouping/grouping-virtual-scrolling.gif)

> When using the `EnableVirtualization` feature, it is necessary to define the [Height](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) property.

## Lazy load grouping constraints

Lazy load grouping supports both `UrlAdaptor` and `JsonAdaptor` data sources, making it suitable for local and remote data scenarios. Selection and clipboard operations work with expanded groups.