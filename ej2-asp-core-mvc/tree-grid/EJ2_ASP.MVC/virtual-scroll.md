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

Row virtualization allows you to load and render rows only in the content viewport. It is an alternative way of paging in which the rows will be appended while scrolling vertically. To setup the row virtualization, you need to define [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableVirtualization) as true and content height by [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_Height) property.

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



> Column's `Width` is required for column virtualization. If column's width is not defined then tree grid will consider its value as `200px`.



## Limitations for Virtualization

* Due to the element height limitation in browsers, the maximum number of records loaded by the treegrid is limited by the browser capability.
* Cell selection will not be persisted in row.
* Virtual scrolling is not compatible with detail template, clipboard functionality and row drag and drop features.
* The page size provided must be two times larger than the number of visible rows in the TreeGrid. If the page size is failed to meet this condition then the size will be determined by TreeGrid.
* The virtual height of the treegrid content is calculated using the row height and total number of records in the data source and hence features which changes row height such as text wrapping are not supported. If you want to increase the row height to accommodate the content then you can specify the row height as below to ensure all the table rows are in same height.

```css
.e-treegrid .e-row {
    height: 2em;
}
```

* Programmatic selection using the **SelectRows** method is not supported in virtual scrolling.

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.
