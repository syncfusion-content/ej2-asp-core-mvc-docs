---
layout: post
title: Virtual Scroll in Syncfusion ASP.NET Core Grid Component
description: Learn here all about Virtual Scroll in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtual Scroll
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtualization in ASP.NET Core Grid Component

Grid allows you to load large amount of data without performance degradation.

## Row virtualization

Row virtualization allows you to load and render rows only in the content viewport. It is an alternative way of paging in which the data will be loaded while scrolling vertically. To setup the row virtualization, you need to define [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableVirtualization) as true and content height by [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Height) property.

The number of records displayed in the Grid is determined implicitly by height of the content area. Also, you have an option to define a visible number of records by
the [`pageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize) property of [`e-grid-pagesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PageSettings) tag helper. The loaded data will be cached and reused when it is needed for next time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/virtual-grid/row-virtualization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-virtualization.cs" %}
{% include code-snippet/grid/virtual-grid/row-virtualization/row-virtualization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/virtual-grid/row-virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-virtualization.cs" %}
{% include code-snippet/grid/virtual-grid/row-virtualization/row-virtualization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column virtualization

Column virtualization allows you to virtualize columns. It will render columns which are in the viewport. You can scroll horizontally to view more columns.

To setup the column virtualization, set the [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableVirtualization) and [`enableColumnVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableColumnVirtualization) properties as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/virtual-grid/column-virtualization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-virtualization.cs" %}
{% include code-snippet/grid/virtual-grid/column-virtualization/Column-virtualization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/virtual-grid/column-virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-virtualization.cs" %}
{% include code-snippet/grid/virtual-grid/column-virtualization/Column-virtualization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Column's [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Width) is required for column virtualization. If column's width is not defined then Grid will consider its value as **200px**.

## Virtualization with grouping

Both the row and column virtualization can be used along with grouping. At initial rendering, the virtual height of scrollbar will be set based on the total number of records and after grouping, it will be refreshed based on the grouped state(expand/collapse). While collapse the group caption row in current viewport then the next view page grouped records are shown.

> The collapsed/expanded state will persist only for local dataSource while scrolling.

## Limitations for virtual scrolling

* While using column virtual scrolling, column width should be in the pixel. Percentage values are not accepted.
* Due to the element height limitation in browsers, the maximum number of records loaded by the grid is limited by the browser capability.
* The cell selection is not supported for both row and column virtual scrolling.
* Virtual scrolling is not compatible with batch editing, detail template, rowspan, colspan and hierarchy features.
* Group expand and collapse state will not be persisted.
* Since data is virtualized in grid, the aggregated information and total group items are displayed based on the current view items. To get these information regardless of the view items, refer to the [`Group with Page`](./grouping/#group-with-paging) topic.
* The page size provided must be two times larger than the number of visible rows in the grid. If the page size is failed to meet this condition then the size will be determined by grid.
* The height of the grid content is calculated using the row height and total number of records in the data source and hence features which changes row height such as text wrapping are not supported. If you want to increase the row height to accommodate the content then you can specify the row height as below to ensure all the table rows are in same height.

```css
.e-grid .e-row {
    height: 2em;
}
```

* Programmatic selection using the **selectRows** method is not supported in virtual scrolling.

## Browser height limitation in virtual scrolling and solution

You can load millions of records in the Grid by using virtual scrolling where grid loads and renders rows in on-demand while scrolling vertically. As a result, Grid lighten the browser’s load by minimizing the DOM elements and rendering elements that are visible in viewport. The height of the grid is calculated using the Total Records Count * [Row Height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property.

The browser has some maximum pixel height limitation for scroll bar element. The content placed above the maximum height can't be scrolled, if the element height is greater than the browser's maximum height limit. The browser height limit affects the virtual scrolling of grid. When a large number of records are bound to the Grid, it can only display the records until the maximum height limit of the browser. Once the browser's height limit is reached while scrolling, user won't able to scroll further to view the remaining records.

For example, if the row height is set as 30px and the total record count will be 1000000(1 million), then the height of the grid element will be 30,000,000 pixels. In this case, the browser's maximum height limit for a div is about 22,369,600 (The maximum pixel height limitation differs for different browsers). The records above the maximum height limit of the browser can't be scrolled. 

This height limitation is not related to Grid component. Its fully depend on the default behaviour of the browser. The same issue reproduced in the normal html table too.

>> gif image

Grid component aslo faced the same issue as mentioned in the below image.

>> gif image

The Grid has an option to overcome this limitation of the browser in the following ways.

### Solution 1: Using external buttons

You can prevent the height limitation problem in browser when scrolling through the millions of records by loading the segment of data through different strategy.

In the following sample, Grid is rendered with a large number of records(nearly 2 million). Here, you can scroll 5L records at a time in Grid. Once you reach the last page of 0.5 million records, the **Load Next Set** button will be shown at the bottom of the Grid. By clicking that button, you can view the next set of 0.5 million records in Grid.This button will be shown only if the next set of records is available. Also, **Load Previous Set** button will be shown at the top of the Grid to load the previous set of 0.5 million records. This button will be shown only if the previous set of records is available.

Lets see the step by step procedure for how we can overcome the limitation in Syncfusion Grid component.

1.	Create custom adaptor by extending UrlAdaptor and bind to the grid dataSource property. In the processQuery method of custom adaptor, we handled the Skip query based on the current page set to perform the data operation with whole records on the server.

```csharp
export class CustomUrlAdaptor extends UrlAdaptor {
    processQuery(args) {
        if (arguments[1].queries) {
            for (var i = 0; i < arguments[1].queries.length; i++) {
                if (arguments[1].queries[i].fn === 'onPage') {
                    // pageSet - defines the number of segments that we are going to split the 2million records. In this example we have considered 5L records for each set so the pageSet is 1, 2, 3 and 4.
                    // maxRecordsPerPageSet – In this example we define the value as 5L.

                    // gridPageSize – the pageSize that we have defined in the Grid pageSettings->pageSize property

                    // customize the pageIndex based on the current pageSet (It send the skip query including the previous pageSet ) so that the other operations performed for total 2millions records instead of 5L alone.
                    arguments[1].queries[i].e.pageIndex = (((pageSet - 1) * maxRecordsPerPageSet) / gridPageSize) + arguments[1].queries[i].e.pageIndex;
                }
            }
        }
        var original = super.processQuery.apply(this, arguments);
        return original;
    }
}

this.dataManager = new DataManager({
    adaptor: new CustomUrlAdaptor(),
    url: "Home/UrlDatasource"
});
```

2.	Render the grid by define the following features.

```csharp
<GridComponent id='grid' ref={g => this.grid = g} dataSource={this.dataManager} enableVirtualization={true} pageSettings={this.pageSettings} height={360} beforeDataBound={this.beforeDataBound}>
        <ColumnsDirective>
            …………..
            …………..
        </ColumnsDirective>
</GridComponent>
```                

3.	In the beforeDataBound event, we set the args.count as 5L to perform scrolling with 5L records and all the data operations are performed with whole records which is handled using the custom adaptor. And also particular segment records count is less than 5L means it will directly assigned the original segmented count instead of 5L.

```csharp
    beforeDataBound(args) {
        // storing the total records count which means 2 million records count
        totalRecords = args.count; 

        // change the count with respect to maxRecordsPerPageSet (maxRecordsPerPageSet = 500000)
        args.count = args.count - ((pageSet - 1) * maxRecordsPerPageSet) > maxRecordsPerPageSet ? maxRecordsPerPageSet : args.count - ((pageSet - 1) * maxRecordsPerPageSet);   
    }
```

4.	Render “Load Next Set” button and “Load Previous Set” button at bottom and top of the grid component.

```csharp
<div className="pagearea1">
    <ButtonComponent cssClass='e-info prevbtn' onClick={this.prevBtnClick} style={{ width: '100%' }}>Load Previous Set...</ButtonComponent>
</div>

<GridComponent id='grid' ref={g => this.grid = g} dataSource={this.dataManager} enableVirtualization={true} pageSettings={this.pageSettings} height={360} beforeDataBound={this.beforeDataBound} >
    <ColumnsDirective>
        …………..
        …………..
    </ColumnsDirective>
</GridComponent>
<div className="pagearea2">
    <ButtonComponent cssClass='e-info nxtbtn' onClick={this.nxtBtnClick} style={{ width: '100%' }}>Load Next Set...</ButtonComponent>
</div>
```

5.	While click on the `Load Next Set` / `Load Previous Set` button corresponding page data set is loaded to view remaining records of total 2millions records after doing some simple calculation.

```typescript
    // Triggered when clicking the Previous/ Next button.
    prevNxtBtnClick(args) {
        if (this.grid.element.querySelector('.e-content') && this.grid.element.querySelector('.e-content').getAttribute('aria-busy') === 'false') {
            // Increase/decrease the pageSet based on the target element.
            pageSet = args.target.classList.contains('prevbtn') ? --pageSet : ++pageSet;
            this.rerenderGrid(); // Re-render the Grid component.
        }
    }
 ```   

> [View GitHub Sample]

> If you perform grid actions such as filtering, sorting, etc., after scrolling through the 5L data, the Grid performs those data actions with the whole records, not just the current loaded 5L data.

### Solution 2: Using RowHeight property

You can reduce the [row height](https://ej2.syncfusion.com/aspnetcore/documentation/grid/row/row-height) using the [RowHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property of the Grid. It will reduce overall height to accomodate more rows. But this approach optimizes the limitation, but if height limit reached after reducing row height also, you have to opt previos solution or use paging. 

Before setting rowHeight property to the grid.

![Grid Without Row Height](../images/ReactGrid.gif)

After setting rowHeight property as "30px" to the grid.

![Grid With Row Height](../images/RowHeight.gif)

### Solution 3: Using paging instead of virtual scrolling

Similar to virtual scrolling, the [paging](https://ej2.syncfusion.com/aspnetcore/documentation/grid/paging) feature also loads the data in on-demand concept. Pagination is also compatible with all the other features(Grouping, Editing, etc.,) in Grid. So use the paging feature instead of virtual scrolling to view the large number of records in the Grid without any kind of performance degradation and browser height limitation.
