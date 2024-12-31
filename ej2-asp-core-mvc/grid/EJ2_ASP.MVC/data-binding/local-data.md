---
layout: post
title: Local Data in ##Platform_Name## Grid Component
description: Learn here all about Local Data in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Local Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Local data in ASP.NET MVC Grid component

The Syncfusion Grid offers a straightforward way to bind local data, such as arrays or JSON objects, to the grid component. This feature allows you to display and manipulate data within the grid without the need for external server calls, making it particularly useful for scenarios where you're working with static or locally stored data.

To achieve this, you can assign a JavaScript object array to the [DataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property. Additionally, you have an option to provide the local data source using an instance of the **DataManager**.

The following example demonstrates how to utilize the local data binding feature in the ASP.NET MVC Grid component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

![Local data](../../images/data-binding/local-data.png)

## Data binding with SignalR 

The syncfusion Grid provides support for real-time data binding using SignalR, allowing you to update the grid automatically as data changes on the server-side. This feature is particularly useful for applications requiring live updates and synchronization across multiple clients.

To achieve real-time data binding with SignalR in your Syncfusion Vue Grid, follow the steps below:

## Binding data from excel file

The Syncfusion Grid component allows you to import data from Excel files into your web application for display and manipulation within the grid. This feature streamlines the process of transferring Excel data to a web-based environment. This can be achieved by using [Uploader](https://ej2.syncfusion.com/vue/documentation/uploader/getting-started) component [change](https://ej2.syncfusion.com/vue/documentation/api/uploader#change) event.

To import excel data in to grid, you can follow these steps:

1. Import excel file using Uploader component. 
2. Parse the excel file data using **XLSX** library.
3. Bind the JSON to the grid component. 

The following example demonstrates how to import Excel data into the grid by utilizing the [Uploader](https://ej2.syncfusion.com/vue/documentation/uploader/getting-started) component's `change` event along with the **XLSX** library:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

![Local data](../../images/data-binding/local-data.png)


## Managing spinner visibility during data loading

Showing a spinner during data loading in the Syncfusion vue Grid enhances the experience by providing a visual indication of the loading progress. This feature helps to understand that data is being fetched or processed.

To show or hide a spinner during data loading in the grid, you can utilize the [showSpinner](https://ej2.syncfusion.com/vue/documentation/api/grid/#showspinner) and [hideSpinner](https://ej2.syncfusion.com/vue/documentation/api/grid/#hidespinner) methods provided by the Grid component

The following example demonstrates how to show and hide the spinner during data loading using external buttons in a grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

![Local data](../../images/data-binding/local-data.png)

## Immutable mode  

Immutable mode in the Syncfusion Grid is designed to optimize re-rendering performance by utilizing the object reference and [deep compare](https://dmitripavlutin.com/how-to-compare-objects-in-javascript/#4-deep-equality) concept. This mode ensures that when performing Grid actions, only the modified or newly added rows are re-rendered, preventing unnecessary re-rendering of unchanged rows. 

To enable this feature, you need to set the [enableImmutableMode](https://ej2.syncfusion.com/vue/documentation/api/grid/#enableImmutableMode) property as **true**.

If immutable mode is enabled, when the datasource changes, only newly added rows are regenerated or reused. Consequently, the grid's [queryCellInfo](https://ej2.syncfusion.com/vue/documentation/api/grid/#querycellinfo) and [rowDataBound](https://ej2.syncfusion.com/vue/documentation/api/grid/#rowdatabound) events trigger only for newly generated rows, not for existing rows. 

If immutable mode is not enabled, both newly added rows and existing rows are regenerated or reused when the datasource changes. As a result, the `rowDataBound` and `queryCellInfo` events trigger for both newly added and existing rows. 

> This feature uses the primary key value for data comparison. So, you need to provide the [isPrimaryKey](https://ej2.syncfusion.com/vue/documentation/api/grid/column/#isprimarykey) column.

The following example demonstrates how to enable immutable mode in an vue component. When add, delete, or update actions are performed, existing rows are not regenerated or reused, ensuring efficient rendering of only the modified or newly added rows:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/localdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Local.cs" %}
{% include code-snippet/grid/data-binding/localdata/local.cs %}
{% endhighlight %}
{% endtabs %}

![Local data](../../images/data-binding/local-data.png)


### Limitations

The following features are not supported in the immutable mode:

* Frozen rows and columns
* Grouping
* Row Template 
* Detail Template
* Hierarchy Grid
* Scrolling 
* Virtual scroll
* Infinite scroll
* Column reorder
* Rows,column spanning
* PDF export ,Excel export,Print
* Column Resize
* Drag and drop
* Column template
* Column chooser
* Clipboard
* AutoFit
* Filtering

