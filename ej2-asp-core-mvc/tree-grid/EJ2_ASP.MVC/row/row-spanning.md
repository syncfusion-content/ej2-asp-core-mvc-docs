---
layout: post
title: Row Spanning in ##Platform_Name## TreeGrid Component | Syncfusion
description: Learn here all about Row Spanning in Syncfusion ##Platform_Name## TreeGrid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Spanning in ##Platform_Name## TreeGrid Component

Row spanning in the TreeGrid allows merging cells in the same column vertically, creating a visually appealing and informative layout. By defining the `rowSpan` attribute in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.treegrid.treegrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event, cells can be easily spanned and the appearance of the TreeGrid can be customized.

In the following demo, the "Lunch Break" cell spans multiple rows in the "1:00 PM" column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-span/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Span.cs" %}
{% include code-snippet/tree-grid/row/row-span/row-spanning.cs %}
{% endhighlight %}
{% endtabs %}

## Row spanning via API

Row spanning in the TreeGrid allows automatically merging cells with identical values in the same column across consecutive rows. This significantly enhances readability and delivers a cleaner layout by eliminating repetitive data.To enable row spanning, set the `EnableRowSpan` property to "true" in the TreeGrid configuration.
 
In the following example, row spanning is applied to the "Status", "Permit Status", "Inspection Status", and "Punch List Status" columns, while it is disabled for the "Planned Budget" and "Actual Spend" columns by setting the `EnableRowSpan` property to "false" in the column level.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Span.cs" %}
{% include code-snippet/tree-grid/row/row-spanning/row-spanning.cs %}
{% endhighlight %}
{% endtabs %}

### Limitations
 
The following list outlines the features that are not compatible with row spanning:
 
* Virtualization
* Infinite Scrolling
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export

## See Also
* [Column Spanning in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.MVC TreeGrid](https://ej2.syncfusion.com/aspnetmvc/documentation/tree-grid/columns/column-spanning)