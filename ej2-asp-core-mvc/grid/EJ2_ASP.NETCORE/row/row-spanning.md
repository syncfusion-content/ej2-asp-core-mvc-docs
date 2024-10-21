---
layout: post
title: Row Spanning in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Row Spanning in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row spanning in ASP.NET Core Grid component

The grid provides an option to span row cells, allowing you to merge two or more cells in a row into a single cell. This feature can be useful in scenarios where you want to display information that spans across multiple rows, but want to avoid repeating the same information in each row.

To achieve this, You need to define the `rowSpan` attribute to span cells in the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event. The `rowSpan` attribute is used to specify the number of rows that the current cell should span.

The `queryCellInfo` event is triggered for each cell in the grid, and allows you to customize the cells in the grid. By handling this event, you can set the `rowSpan` attribute for a cell to achieve row spanning.

In the following code example, **Davolio** cell is spanned to two rows in the **EmployeeName** column. Also Grid supports the spanning of rows and columns for same cells. **Lunch Break** cell is spanned to two rows and three columns in the **1:00** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-span/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Span.cs" %}
{% include code-snippet/grid/row/row-span/row-span.cs %}
{% endhighlight %}
{% endtabs %}

![Row span](../images/row/row-span.png)

> * To disable the spanning for particular grid page, you need to use **requestType** from [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event argument.
> * The `rowSpan` and `colSpan` attributes can be used together to merge cells both vertically and horizontally.

## Limitations

* The `updateCell` method does not support row spanning.
* Row spanning is not compatible with the following features:
    1. Virtual scrolling
    2. Infinite scrolling
    3. Grouping
    4. Row drag and drop
    5. Autofill
    6. Inline editing
    7. Batch editing
    8. CRUD