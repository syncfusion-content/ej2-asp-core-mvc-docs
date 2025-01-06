---
layout: post
title: Virtual in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about Virtual in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtual
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tree Grid Virtualization

TreeGrid allows you to load large amount of data without performance degradation.

## Row Virtualization

Row virtualization allows you to load and render rows only in the content viewport. It is an alternative way of paging in which the rows will be appended while scrolling vertically. To setup the row virtualization, you need to define [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableVirtualization) as true and content height by [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Height) property.

The number of records displayed in the TreeGrid is determined implicitly by height of the content area and a buffer records will be maintained in the TreeGrid content in addition to the original set of rows.

Expand and Collapse state of any child record will be persisted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/virtual/rowvirtual/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowvirtual.cs" %}
{% include code-snippet/tree-grid/virtual/rowvirtual/rowvirtual.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/virtual/rowvirtual/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowvirtual.cs" %}
{% include code-snippet/tree-grid/virtual/rowvirtual/rowvirtual.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Limitations 

* Row virtual scrolling is not compatible with the following feature
	1. Batch editing
	2. Detail template
	3. Row template
	4. Rowspan
	5. Autofill
	
* It is necessary to set a static height for the component or its parent container when using row virtualization. The 100% height will work only if the component height is set to 100%, and its parent container has a static height.

* When row virtual scrolling is activated, compatibility for copy-paste and drag-and-drop operations is limited to the data items visible in the current viewport of the tree grid.
* The cell-based selection is not supported for row virtual scrolling. 
* Using different row heights with a template column, when the template height differs for each row, is not supported.
* Due to the element height limitation in browsers, the maximum number of records loaded by the tree grid is limited by the browser capability.
* The height of the tree grid content is calculated using the row height and total number of records in the data source and hence features which changes row height such as text wrapping are not supported.
* If you want to increase the row height to accommodate the content then you can specify the row height as below to ensure all the table rows are in same height.

    ```css
    .e-treegrid .e-row {
        height: 2em;
    }
    ```

## Column Virtualization

Column virtualization allows you to virtualize columns. It will render column only in the current view port and all other columns are rendered on demand during horizontal scrolling.

To setup the column virtualization, set the [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableVirtualization) and [`EnableColumnVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableColumnVirtualization) properties as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/virtual/columnvirtual/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnvirtual.cs" %}
{% include code-snippet/tree-grid/virtual/columnvirtual/columnvirtual.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/virtual/columnvirtual/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnvirtual.cs" %}
{% include code-snippet/tree-grid/virtual/columnvirtual/columnvirtual.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> Column's `Width` is required for column virtualization. If column's width is not defined then tree grid will consider its value as `200px`.



### Limitations 

* While using column virtual scrolling, column width should be in pixel. Percentage values are not accepted.
* Selected column details are only retained within the viewport. When the next set of columns is loaded, the selection for previously visible columns is lost.
* The cell selection is not supported for column virtual scrolling.
* The **Ctrl + Home** and **Ctrl + End** keys are not supported when using column virtual scrolling.
* The following features are compatible with column virtualization and works only within the viewport:
   1. Column resizing
   2. Column reordering
   3. Auto-fit
   4. Print
   5. Clipboard
   6. Column menu - Column chooser, AutofitAll

* Column virtual scrolling is not compatible with the following feature
    1. Colspan
    2. Batch editing
    3. Column with infinite scrolling
    4. Stacked header
    5. Row template
    6. Detail template
    7. Autofill
    8. Column chooser

N> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.
