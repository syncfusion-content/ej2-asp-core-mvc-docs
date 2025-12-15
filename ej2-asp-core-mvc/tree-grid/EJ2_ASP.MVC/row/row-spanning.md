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

The row spanning feature in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.MVC TreeGrid allows merging cells in the same column vertically, creating a visually appealing and informative layout. By defining the `rowSpan` attribute in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.treegrid.treegrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event, cells can be easily spanned and the appearance of the TreeGrid can be customized.

In the following demo, the **Lunch Break** cell spans multiple rows in the "1:00 PM" column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-span/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Span.cs" %}
{% include code-snippet/tree-grid/row/row-span/row-span.cs %}
{% endhighlight %}
{% endtabs %}

<!-- {% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="RowSpanning.cs" %}
{% include code-snippet/tree-grid/row/row-spanning/spanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowSpanning.cs" %}
{% include code-snippet/tree-grid/row/row-spanning/spanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %} -->

## Limitations

Row spanning in the ASP.MVC TreeGrid has the following limitations:

* The [updateCell](https://ej2.syncfusion.com/documentation/api/treegrid/index-default#updatecell) method does not support row spanning.
* Row spanning is not compatible with the following features:
    1. Virtual scrolling
    2. Infinite scrolling

> When using row spanning, ensure that the spanned cells do not interfere with TreeGrid operations such as sorting, filtering, or editing, as this may lead to unexpected behavior.

## Row spanning using EnableRowSpan property

The Syncfusion ASP.MVC TreeGrid introduces a simplified approach to vertically merge cells with identical values in the same column across consecutive rows.

The row spanning feature in the Syncfusion ASP.MVC TreeGrid can be enabled using `EnableRowSpan` property which significantly enhances readability and delivers a clean, professional look by eliminating repetitive data in columns such as "Status", "Permit Status", "Inspection Status" and "Punch List Status".

To enable column spanning, set the `EnableRowSpan` property to **true** in the TreeGrid configuration.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Span.cs" %}
{% include code-snippet/tree-grid/row/row-spanning/row-span.cs %}
{% endhighlight %}
{% endtabs %}

<!-- {% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Spanningapi.cs" %}
{% include code-snippet/tree-grid/row/spanning/rowspanningapi.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spanningapi.cs" %}
{% include code-snippet/tree-grid/row/spanning/rowspanningapi.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %} -->

> In the sample, row spanning is disabled at the column level for the price based columns such as "Planned Budget" and "Actual Spend" by setting each column's `enableRowSpan` property to **false**.

### Limitations

Row spanning feature is not compatible with all the features which are available in TreeGrid and it has limited features support. Here we have listed out the features which are not compatible with row spanning feature.

* Virtualization
* Infinite Scrolling
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export

## See Also

* [Column spanning in Syncfusion<sup style="font-size:70%">&reg;</sup> TreeGrid](https://ej2.syncfusion.com/asp.mvc/documentation/treegrid/columns/column-spanning)