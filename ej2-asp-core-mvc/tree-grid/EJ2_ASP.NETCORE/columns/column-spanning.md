---
layout: post
title: Column Spanning in ##Platform_Name## TreeGrid Component | Syncfusion
description: Learn here all about Column Spanning in Syncfusion ##Platform_Name## TreeGrid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Spanning in ##Platform_Name## TreeGrid Component

The column spanning feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.Core TreeGrid allows merging adjacent cells horizontally, creating a visually appealing and informative layout. By defining the `colSpan` attribute in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event, cells can be easily spanned and the appearance of the TreeGrid can be customized.

In the following example, Employee **Davolio** is scheduled for analysis from "9.00 AM" to "10.00 AM", so those cells have been spanned.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-spanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnSpanning.cs" %}
{% include code-snippet/tree-grid/columns-core/column-spanning/spanning.cs %}
{% endhighlight %}
{% endtabs %}

## Limitations

Column spanning in the ASP.Core TreeGrid has the following limitations:

* The [updateCell](https://ej2.syncfusion.com/documentation/api/treegrid/index-default#updatecell) method does not support column spanning.
* Column spanning is not compatible with the following features:
    1. Virtual scrolling
    2. Infinite scrolling

> When using column spanning, ensure that the spanned cells do not interfere with TreeGrid operations such as sorting, filtering, or editing, as this may lead to unexpected behavior.

## Column spanning implementation through API

The Syncfusion TreeGrid provides an API-based approach to horizontally merge cells with identical values in the same row across adjacent columns.

The column spanning feature in the Syncfusion TreeGrid can be enabled using `EnableColumnSpan` property to **true** in the TreeGrid configuration, which significantly enhances readability and delivers a cleaner layout by eliminating repetitive data in columns such as "Status", "Permit Status", "Inspection Status" and "Punch List Status".

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-spanning-using-property/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spanningapi.cs" %}
{% include code-snippet/tree-grid/columns-core/column-spanning-using-property/spanningapi.cs %}
{% endhighlight %}
{% endtabs %}

> In the sample, column spanning is disabled at the column level for the price based columns such as "Planned Budget" and "Actual Spend" by setting each column's `EnableColumnSpan` property to **false**.

### Limitations

Column spanning feature is not compatible with all the features which are available in TreeGrid and it has limited features support. Here we have listed out the features which are not compatible with column spanning feature.

* Virtualization
* Infinite Scrolling
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export
