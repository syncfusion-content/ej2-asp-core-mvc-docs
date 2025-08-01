---
layout: post
title: Virtual Scroll in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Virtual Scroll in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtual Scroll
publishingplatform: ##Platform_Name##
documentation: ug
---

# Virtual scrolling in ASP.NET MVC Grid component

The virtual scrolling feature in the Grid allows you to efficiently handle and display a large amount of data without experiencing any performance degradation. It optimizes the rendering process by loading only the visible rows in the Grid viewport, rather than rendering the entire dataset at once. This is particularly useful when dealing with datasets that contain thousands of records.

## Row virtualization

Row virtualization is a feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid that allows you to load and render rows only in the content viewport. It provides an alternative way of paging where data is loaded dynamically while scrolling vertically, rather than loading all the data at once. This is particularly useful when dealing with large datasets, as it improves the performance and reduces the initial load time.

To set up row virtualization, you need to define the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableVirtualization) property as **true** and specify the content height using the [Height](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) property in the Grid configuration.

The number of records displayed in the Grid is implicitly determined by the height of the content area. Additionally, you have an option to explicitly define the visible number of records using the [PageSettings.PageSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize) property. The loaded data will be cached and reused when needed in the future.

The following example enable row virtualization using `EnableVirtualization` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/row-virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-virtualization.cs" %}
{% include code-snippet/grid/scrolling/row-virtualization/row-virtualization.cs%}
{% endhighlight %}
{% endtabs %}

![Row virtualization](../images/scrolling/scrolling-row-virtual-scroll.gif)

### Limitations 

* Row virtual scrolling is not compatible with the following feature
	1. Batch editing
	2. Detail template
	3. Row template
	4. Rowspan
	5. Autofill
	6. Hierarchy grid
    7. Page
* AutoFill support for Batch mode editing, so this feature is not compatible with Row Virtualization feature. 
* When row virtual scrolling is activated, compatibility for copy-paste and drag-and-drop operations is limited to the data items visible in the current viewport of the grid.
* The cell-based selection is not supported for row virtual scrolling. 
* Using different row heights with a template column, when the template height differs for each row, is not supported.
* Group expand and collapse state will not be persisted for remote data.
* Due to the element height limitation in browsers, the maximum number of records loaded by the Grid is limited by the browser capability.
* The height of the grid content is calculated using the row height and total number of records in the data source and hence features which changes row height such as text wrapping are not supported.
* If you want to increase the row height to accommodate the content then you can specify the row height as below to ensure all the table rows are in same height.

    ```css
    .e-grid .e-row {
        height: 2em;
    }
    ```
* Since data is virtualized in grid, the aggregated information and total group items are displayed based on the current view items. To get these information regardless of the view items, refer to the [Group with paging](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/grouping/grouping#group-with-paging) topic. 
* It is necessary to set a static height for the component or its parent container when using row virtualization. The 100% height will work only if the component height is set to 100%, and its parent container has a static height.

## Column virtualization

Column virtualization feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> Grid that allows you to optimize the rendering of columns by displaying only the columns that are currently within the viewport. It allows horizontal scrolling to view additional columns. This feature is particularly useful when dealing with grids that have a large number of columns, as it helps to improve the performance and reduce the initial loading time.

To enable column virtualization, you need to set the [EnableColumnVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableColumnVirtualization) property of the Grid to **true**. This configuration instructs the Grid to only render the columns that are currently visible in the viewport. 

The following example enable column virtualization using `EnableColumnVirtualization`  property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/scrolling/column-virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-virtualization.cs" %}
{% include code-snippet/grid/scrolling/column-virtualization/column-virtualization.cs%}
{% endhighlight %}
{% endtabs %}

![Column virtualization](../images/scrolling/scrolling-column-virtual-scroll.gif)

> Column's [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) is required for column virtualization. If column's width is not defined then Grid will consider its value as **200px**.

### Limitations 

* While using column virtual scrolling, column width should be in pixel. Percentage values are not accepted.
* Selected column details are only retained within the viewport. When the next set of columns is loaded, the selection for previously visible columns is lost.
* The cell selection is not supported for column virtual scrolling.
* The **Ctrl + Home** and **Ctrl + End** keys are not supported when using column virtual scrolling.
* The following features are compatible with column virtualization and work within the viewport:
   1. Column resizing
   2. Column reordering
   3. Auto-fit
   4. Print
   5. Clipboard
   6. Column menu - AutofitAll

* Column virtual scrolling is not compatible with the following feature
    1. Grouping
    2. Colspan
    3. Batch editing
    4. Stacked header
    5. Row template
    6. Detail template
    7. Hierarchy grid
    8. Autofill
    9. Page

## Browser height limitation in virtual scrolling and solution

You can load millions of records in the Grid by using virtual scrolling, where the Grid loads and renders rows on-demand while scrolling vertically. As a result, Grid lightens the browser’s load by minimizing the DOM elements and rendering elements visible in the viewport. The height of the Grid is calculated using the Total Records Count * [RowHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property.

The browser has some maximum pixel height limitations for the scroll bar element. The content placed above the maximum height can't be scrolled if the element height is greater than the browser's maximum height limit. The browser height limit affects the virtual scrolling of the Grid. When a large number of records are bound to the Grid, it can only display the records until the maximum height limit of the browser. Once the browser's height limit is reached while scrolling, the user won't able to scroll further to view the remaining records.

For example, if the row height is set as 30px and the total record count is 1000000(1 million), then the height of the Grid element will be 30,000,000 pixels. In this case, the browser's maximum height limit for a div is about 22,369,600 (The maximum pixel height limitation differs for different browsers). The records above the maximum height limit of the browser can't be scrolled.

This height limitation is not related to the Grid. It fully depends on the default behavior of the browser. The same issue is reproduced in the normal HTML table too.

The following image illustrates the height limitation issue of a normal HTML table in different browsers (Chrome and Firefox).

![Browser height limitation in HTML table](../images/scrolling/html-table.gif)

Grid also faced the same issue as mentioned in the below image.

![Grid with browser height limitation](../images/scrolling/grid.gif)

The Grid has an option to overcome this limitation of the browser in the following ways.

### Solution 1: Using external buttons

You can prevent the height limitation problem in the browser when scrolling through millions of records by loading the segment of data through different strategy.

In the following sample, Grid is rendered with a large number of records(nearly 2 million). Here, you can scroll 0.5 million records at a time in Grid. Once you reach the last page of 0.5 million records, the **Load Next Set** button will be shown at the bottom of the Grid. By clicking that button, you can view the next set of 0.5 million records in Grid. Also, the **Load Previous Set** button will be shown at the top of the Grid to load the previous set of 0.5 million records.

Let's see the step by step procedure for how we can overcome the limitation in the Syncfusion Grid.

1. Create a custom adaptor by extending `UrlAdaptor` and binding it to the Grid [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. In the **processQuery** method of the custom adaptor, we handled the `Skip` query based on the current page set to perform the data operation with whole records on the server.

```typescript
class CustomAdaptor extends ej.data.UrlAdaptor {
    processQuery(dataManager, query) {
        if (query.queries) {
            query.queries.forEach(queryItem => {
                if (queryItem.fn === 'onPage') {
                    // pageSet - Defines the number of segments going to split the 2 million records. In this example 0.5 million records are considered for each set so the pageSet is 1, 2, 3 and 4.
                    // maxRecordsPerPageSet – In this example the value is define as 0.5 million.
                    // gridPageSize – The pageSize defined in the Grid as pageSettings->pageSize property.
                    // Customize the pageIndex based on the current pageSet (It send the skip query including the previous pageSet ) so that the other operations performed for total 2 millions records instead of 0.5 million alone.
                    let pageIndex = queryItem.e.pageIndex;
                    pageIndex = (((pageSet - 1) * maxRecordsPerPageSet) / gridPageSize) + pageIndex;
                }
            });
        }
        return super.processQuery(dataManager, query);
    }
}

document.addEventListener("DOMContentLoaded", function () {
    let grid = document.getElementById("Grid").ej2_instances[0];
    if (grid) {
        let dataManager = new ej.data.DataManager({
            url: "/api/Grid",
            adaptor: new CustomAdaptor()
        });
        grid.dataSource = dataManager;
    }
```

2. Render the Grid by define the following features.

```cshtml
@Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.dataSource).EnableVirtualization().Height("360").BeforeDataBound("beforeDataBound").Columns(col =>
{
    col.Field("OrderID").HeaderText("OrderID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
    ......
    ......
}).PageSettings(page => { page.PageSize(50); }).Render();
```

3. In the [beforeDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_BeforeDataBound) event, we set the args.count as 0.5 million to perform scrolling with 0.5 million records and all the data operations are performed with whole records which is handled using the custom adaptor. And also particular segment records count is less than 0.5 million means it will directly assigned the original segmented count instead of 0.5 million.

```typescript
function beforeDataBound(args) {
    // Storing the total records count which means 2 million records count.
    totalRecords = args.count;

    // Change the count with respect to maxRecordsPerPageSet (maxRecordsPerPageSet = 500000).
    args.count = args.count - ((pageSet - 1) * maxRecordsPerPageSet) > maxRecordsPerPageSet ?maxRecordsPerPageSet : args.count - ((pageSet - 1) * maxRecordsPerPageSet);
}
```

4. Render “Load Next Set” button and “Load Previous Set” button at bottom and top of the Grid.

```cshtml
@Html.EJS().Button("prevButton").Class("e-info prevbtn").CssClass("e-info prevbtn e-primary").Content("Load Previous Set...").Render()
@Html.EJS().Grid("Grid").DataSource((IEnumerable<object>)ViewBag.dataSource).EnableVirtualization().Height("360").BeforeDataBound("beforeDataBound").Columns(col =>
{
    col.Field("OrderID").HeaderText("OrderID").Width("100").TextAlign(Syncfusion.EJ2.Grids.TextAlign.Right).Add();
    ......
    ......
}).PageSettings(page => { page.PageSize(50); }).Render();
@Html.EJS().Button("nextButton").Class("e-info nxtbtn").CssClass("e-info nxtbtn e-primary").Content("Load Next Set...").Render()
```

5. While click on the `Load Next Set` / `Load Previous Set` button corresponding page data set is loaded to view remaining records of total 2 millions records after doing some simple calculation.

```typescript
document.getElementById("prevButton").addEventListener("click", function () {
    loadPageSet(-1);  // Move to the previous page set.
});

document.getElementById("nextButton").addEventListener("click", function () {
    loadPageSet(1);  // Move to the next page set.
});

function loadPageSet(direction) {
    let grid = document.getElementById("Grid").ej2_instances[0];
    if (grid && grid.element) {
        let contentElement = grid.element.querySelector('.e-content');
        if (contentElement && contentElement.getAttribute('aria-busy') === 'false') {
            pageSet += direction; // Update page set based on direction (-1 for previous, +1 for next).
            grid.refresh(); // Reload data with the new page set.
        } else {
            console.warn("Grid is still loading. Please wait..."); // Prevent multiple clicks while loading.
        }
    }
}
```

![Prevent browser height limitation](../images/scrolling/external-button.png)

> If you perform Grid actions such as filtering, sorting, etc., after scrolling through the 0.5 million data, the Grid performs those data actions with the whole records, not just the current loaded 0.5 million data.

### Solution 2: Using RowHeight property

You can reduce the [RowHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) using the `RowHeight` property of the Grid. It will reduce the overall height to accommodate more rows. But this approach optimizes the limitation, but if the height limit is reached after reducing row height also, you have to opt for the previous solution or use paging.

In the following image, you can see how many records will be scrollable when setting `RowHeight` to "36px" and "30px".

![Row Height](../images/scrolling/row-height.gif)

### Solution 3: Using paging instead of virtual scrolling

Similar to virtual scrolling, the [Paging](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/paging) feature also loads the data in an on-demand concept. Pagination is also compatible with all the other features(Grouping, Editing, etc.) in Grid. So, use the `paging` feature instead of virtual scrolling to view a large number of records in the Grid without any kind of performance degradation or browser height limitation.