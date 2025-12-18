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

Column spanning in the TreeGrid allows merging adjacent cells horizontally, creating a visually appealing and informative layout. By defining the `colSpan` attribute in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event, cells can be easily spanned and the appearance of the TreeGrid can be customized.

In the following example, Employee "Davolio" is scheduled for analysis from "9.00 AM" to "10.00 AM", so those cells have been spanned.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-spanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnSpanning.cs" %}
{% include code-snippet/tree-grid/columns-core/column-spanning/spanning.cs %}
{% endhighlight %}
{% endtabs %}

## Column spanning via API
 
Column spanning in the TreeGrid allows automatically merging cells with identical values in the same row across consecutive columns. This significantly enhances readability and delivers a cleaner layout by eliminating repetitive data. To enable column spanning, set the `EnableColumnSpan` property to "true" in the TreeGrid configuration.
 
In the following example, column spanning is applied to the "Status", "Permit Status", "Inspection Status", and "Punch List Status" columns, while it is disabled for the "Planned Budget" and "Actual Spend" columns by setting the `EnableColumnSpan` property to "false" in the column level.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-spanning-using-property/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spanningapi.cs" %}
{% include code-snippet/tree-grid/columns-core/column-spanning-using-property/spanningapi.cs %}
{% endhighlight %}
{% endtabs %}

### Limitations
 
The following list outlines the features that are not compatible with column spanning:
 
* Virtualization
* Infinite Scrolling
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export

## See Also
* [Row Spanning in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.Core TreeGrid](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/row/row-spanning)