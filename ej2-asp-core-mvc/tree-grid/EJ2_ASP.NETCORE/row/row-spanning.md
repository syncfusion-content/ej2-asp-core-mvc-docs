---
layout: post
title: Row Spanning in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Row Spanning in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Spanning in ##Platform_Name## Tree Grid Component

The TreeGrid provides an option to span row cells, allowing merging two or more cells in a row into a single cell. This feature can be useful in scenarios where information needs to be displayed that spans across multiple rows, but repeating the same information in each row should be avoided.

To achieve this, define the `rowSpan` attribute to span cells in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event. The rowSpan attribute is used to specify the number of rows that the current cell should span.

The `queryCellInfo` event is triggered for each cell in the TreeGrid, and allows customizing the cells in the TreeGrid. By handling this event, the `rowSpan` attribute can be set for a cell to achieve row spanning.

In the following demo, **Lunch Break** cell is spanned to two rows in the **1:00** column. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowspanning.cs" %}
{% include code-snippet/tree-grid/row/row-spanning/rowSpanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowspanning.cs" %}
{% include code-snippet/tree-grid/row/row-spanning/rowSpanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> * To disable the spanning for particular TreeGrid page, use **requestType** from `queryCellInfo` event argument.
N> * The `rowSpan` and `colSpan` attributes can be used together to merge cells both vertically and horizontally.

## Limitations

* The `updateCell` method does not support row spanning.
* Row spanning is not compatible with the following features:
    1. Virtual scrolling
    2. Infinite scrolling
    3. Row drag and drop
    4. Autofill
    5. Row or cell editing
    6. Batch editing
    7. CRUD

## Row spanning using enableRowSpan property    

The  TreeGrid componentintroduces a simplified approach to vertically merge cells using the `enableRowSpan` property. 

When the `enableRowSpan` property is enabled, the Tree Grid automatically merges cells with matching data across adjacent columns without requiring manual span configuration using the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event. These merged cells are visually combined into a single cell, improving readability.

Here is an example of how to use the `enableRowSpan` property to merge cells vertically:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning-property/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowSpan.cs" %}
{% include code-snippet/tree-grid/row/row-spanning-property/rowspan.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-spanning-property/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowspan.cs" %}
{% include code-snippet/tree-grid/row/row-spanning-property/rowspan.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can also control spanning at the column level. To prevent merging for specific columns, set `enableRowSpan` to **false** in the column definition.

### Limitation

* Virtualization
* Infinite Scrolling
* Row Drag and Drop
* Column Virtualization
* Detail Template
* Editing
* Export
