---
layout: post
title: Performance tips for ASP.NET MVC DataGrid | Syncfusion
description: Checkout and learn here all about how to improve the loading performance of ASP.NET MVC DataGrid even binding large data set.
platform: ej2-asp-core-mvc
control: DataGrid
documentation: ug
---

# Performance tips for ASP.NET MVC DataGrid

This article is a comprehensive guide on improving the loading performance of the ASP.NET MVC DataGrid, especially when dealing with large datasets along with large number of columns. It provides valuable insights into the steps that need to be followed to bind a large data source without experiencing any performance degradations. By offering detailed explanations and actionable tips, this resource aims to empower readers with the knowledge and best practices necessary to optimize the performance of the ASP.NET MVC DataGrid during data binding, ensuring a smooth and efficient user experience.

## How to improve loading performance by binding large dataset

As you all know, a Grid is made up of rows and columns. For instance, when you bind 10 rows and 10 columns, it means 100 elements will be rendered in the DOM (Document Object Model). So, it is recommended to render only a limited number of rows and columns to guarantee the best loading performance for the component.

### Optimizing performance with paging 

To boost the performance efficiency of your application, especially when dealing with large datasets, it is advised to implement paging. [Paging](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/paging) allows you to display Grid data in segmented pages, facilitating easier navigation through substantial datasets. This feature proves particularly beneficial in enhancing the overall performance of your application. For more information on implementing paging, you can refer to the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/paging) section dedicated to this feature.

### Optimizing performance with row virtualization or infinite scrolling 

To enhance your application's efficiency, especially when dealing with substantial datasets, it is recommended to either using [virtualization](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/virtual-scrolling) or [infinite scrolling](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/infinite-scrolling). Implementing these techniques can significantly reduce the load on your application and elevate its overall performance.

1.  **Virtualization**: The Virtual scrolling feature in the ASP.NET MVC Data Grid enables the efficient handling and display of large volumes of data without compromising performance. This approach optimizes the rendering process by loading only the visible rows within the Grid viewport, rather than rendering the entire dataset simultaneously. For more information on implementing row virtualization , you can refer to the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/virtual-scrolling) section dedicated to this feature.

2.  **Infinite scrolling**: The Infinite Scrolling feature in the ASP.NET MVC Data Grid is a powerful tool for seamlessly handling extensive data sets without compromising Grid performance. It operates on a "load-on-demand" concept, ensuring that data is fetched only when needed. In the default infinite scrolling mode, a new block of data is loaded each time the scrollbar reaches the end of the vertical scroller. For more information on implementing infinite scrolling , you can refer to the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/infinite-scrolling) section dedicated to this feature.

### Optimizing performance with column virtualization in large no of columns

[Column virtualization](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/virtual-scrolling#column-virtualization) feature in the ASP.NET MVC Data Grid that allows you to optimize the rendering of columns by displaying only the columns that are currently within the viewport. It allows horizontal scrolling to view additional columns. This feature is particularly useful when dealing with grids that have a large number of columns, as it helps to improve the performance and reduce the initial loading time.

It is possible to enable both row and column virtualization. This feature allows for efficient handling of large datasets by dynamically loading only the visible rows and columns, optimizing performance and enhancing the overall responsiveness of the Grid. For more information on implementing column virtualization , you can refer to the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/virtual-scrolling#column-virtualization) section dedicated to this feature.

### How to overcome browser height limitation in virtual scrolling

[Documentation link](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/scrolling/virtual-scrolling#browser-height-limitation-in-virtual-scrolling-and-solution)

## How to improve loading performance by binding large data by showing custom text or element

When integrating image or template elements into a column, it's recommended to utilize the [Column Template](https://ej2.syncfusion.com/aspnetmvc/documentation/grid/columns/column-template) feature rather than customizing the data through [rowDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) or [queryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) events. These events are triggered for each row and cell rendering, introducing delays in the component's rendering process. Moreover, rendering custom elements using these events may result in the persistence of rendered elements, potentially causing longer rendering times over time. By opting for the column template feature, you can efficiently meet this requirement without experiencing rendering delays and ensure a more streamlined rendering process.

## How to improve loading performance by referring individual script and CSS

To improve the performance of Syncfusion Grid during the initial render as well as certain actions, suggested you to download the specific component scripts using CRG (Custom Resource Generator) to speed up the project. By default, the ej2.min.js script file contains all the Syncfusion component scripts. So, it will take some time to load the scripts to the project. Using [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator), you can select the components which you want to use, and the modules for those components, then you can download the scripts and CSS for the selected components and use them as per your need.

[CRG website link](https://crg.syncfusion.com/) 

So to improve the performance of Grid during the initial rendering, suggested you to refer individual script and CSS.

## How to update cell values without frequent server calls 

Efficiently update cell values without the need for frequent server calls, especially beneficial for live update scenarios. Even when the data is initially bound from the server, performing edit operations can be done without triggering a database refresh. Utilize the `setCellValue` method to update the DataGrid without affecting the database and only refresh the UI.

## How to optimize server-side data operations with adaptors

The ASP.NET MVC DataGrid provides support for various adaptors (OData, ODataV4, WebAPI, URL, etc.) to facilitate server-side data operations and CRUD functionalities. By leveraging these adaptors along with the `DataManager` component, you can seamlessly bind remote data sources to the Grid and execute actions. During data operations like filtering, sorting, and paging, the corresponding action queries are generated as per the adaptor's requirements. It is crucial to handle these actions on the application end and return the processed data back to the Grid. Refer to the documentation for comprehensive details. It's worth noting that for efficient data processing, the suggested order for returning processed data to the Grid is as follows

* Filtering
* Sorting
* Aggregates
* Paging
* Grouping

## How to avoid MaxJsonLength error while passing large amount of records

The ASP.NET MVC Grid is client-server based. So, we send the data as JSON object between client and server. The reported issue occurs due to the serialization of the large-sized JSON object. We need to increase the maximum length for serializing the large-sized JSON object. You have to alter the [MaxJsonLength](https://social.msdn.microsoft.com/Forums/en-US/ab1a5864-46e2-4c57-9511-dc3f60cc314a/how-to-increase-maxjsonlength-for-json-post-in-mvc3?forum=aspmv) property on your web.config file or in the place of deserialization.

**Solution: 1**

```csharp
<configuration> 
   <system.web.extensions>
       <scripting>
           <webServices>
               <jsonSerialization maxJsonLength="25000000"/>
           </webServices>
       </scripting>
   </system.web.extensions>
</configuration> 
```

**Solution : 2**
```csharp
var serializer = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
```

## Microsoft excel limitation while exporting millions of records to excel file format

By default, Microsoft Excel supports only 1,048,576 records in an excel sheet. Hence it is not possible to export millions of records to excel. You can refer the [documentation](https://support.microsoft.com/en-gb/office/excel-specifications-and-limits-1672b34d-7043-467e-8e27-269d656771c3) link for more details on Microsoft excel specifications and limits. So suggest to export the data in CSV (Comma-Separated Values) or other formats that can handle large datasets more efficiently than Excel.