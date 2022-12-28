---
layout: post
title: Rows And Columns in ##Platform_Name## Syncfusion Spreadsheet Component
description: Learn here all about Rows And Columns in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Rows And Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rows and columns in Spreadsheet control

Spreadsheet is a tabular format consisting of rows and columns. The intersection point of rows and columns are called as cells. The list of operations that you can perform in rows and columns are,

* Insert
* Delete
* Show and Hide

## Insert

You can insert rows or columns anywhere in a spreadsheet. Use the [`allowInsert`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowInsert) property to enable or disable the insert option in Spreadsheet.

### Row

The rows can be inserted in the following ways,

* Using [`insertRow`](../api/spreadsheet/#insertrow) method, you can insert the rows once the component is loaded.
* Using context menu, insert the empty rows in the desired position.

The following code example shows the options for inserting rows in the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/insert-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InsertRowController.cs" %}
{% include code-snippet/spreadsheet/insert-row/insertRowController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/insert-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InsertRowController.cs" %}
{% include code-snippet/spreadsheet/insert-row/insertRowController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Column

The columns can be inserted in the following ways,

* Using [`insertColumn`](../api/spreadsheet/#insertcolumn) method, you can insert the columns once the component is loaded.
* Using context menu, insert the empty columns in the desired position.

The following code example shows the options for inserting columns in the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/insert-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InsertColumnController.cs" %}
{% include code-snippet/spreadsheet/insert-column/insertColumnController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/insert-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InsertColumnController.cs" %}
{% include code-snippet/spreadsheet/insert-column/insertColumnController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Delete

Delete support provides an option for deleting the rows and columns in the spreadsheet. Use [`allowDelete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowDelete) property to enable or disable the delete option in Spreadsheet.

The rows and columns can be deleted dynamically in the following ways,

* Using [`delete`](../api/spreadsheet/#delete) method, you can delete the loaded rows and columns.
* Using context menu, you can delete the selected rows and columns.

The following code example shows the delete operation of rows and columns in the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/delete-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteRowController.cs" %}
{% include code-snippet/spreadsheet/delete-row/deleteRowController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/delete-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteRowController.cs" %}
{% include code-snippet/spreadsheet/delete-row/deleteRowController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Limitations of insert and delete

The following features have some limitations in Insert/Delete:

* Insert row/column between the formatting applied cells.
* Insert row/column between the data validation.
* Insert row/column between the conditional formatting applied cells.
* Insert/delete row/column between the filter applied cells.

## Hide and show

You can show or hide the rows and columns in the spreadsheet through property binding, method, and context menu.

### Row

The rows can be hidden or shown through the following ways,

* Using `hidden` property in row, you can hide/show the rows at initial load.
* Using `hideRow` method, you can hide the rows by specifying the start and end row index, set the last argument `hide` as `false` to unhide the hidden rows.
* Right-click on the row header and select the desired option from context menu

### Column

The columns can be hidden or shown through following ways,

* Using `hidden` property in columns, you can hide/show the columns at initial load.
* Using `hideColumn` method, you can hide the columns by specifying the start and end column index, set the last argument `hide` as `false` to unhide the hidden columns.
* Right-click on the column header and select the desired option from context menu

The following code example shows the hide/show rows and columns operation in the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHideController.cs" %}
{% include code-snippet/spreadsheet/show-hide/showHideController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHideController.cs" %}
{% include code-snippet/spreadsheet/show-hide/showHideController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size

You can change the size of rows and columns in the spreadsheet by using [setRowsHeight](../api/spreadsheet/#setrowsheight) and [setColumnsWidth](../api/spreadsheet/#setcolumnswidth) methods.

### Row

You can change the height of single or multiple rows by using the [setRowsHeight](../api/spreadsheet/#setrowsheight) method.

You can provide the following type of ranges to the method:

* Single row range: `['2:2']`
* Multiple rows range: `['1:100']`
* Multiple rows with discontinuous range: `['1:10', '15:25', '30:40']`
* Multiple rows with different sheets: `[Sheet1!1:50, 'Sheet2!1:50', 'Sheet3!1:50']`

The following code example shows how to change the height for single/multiple rows in the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeightController.cs" %}
{% include code-snippet/spreadsheet/row-height/rowHeightController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeightController.cs" %}
{% include code-snippet/spreadsheet/row-height/rowHeightController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Column

You can change the width of single or multiple columns by using the [setColumnsWidth](../api/spreadsheet/#setcolumnswidth) method.

You can provide the following type of ranges to the method:

* Single column range: `['F:F']`
* Multiple columns range: `['A:F']`
* Multiple columns with discontinuous range: `['A:C', 'G:I', 'K:M']`
* Multiple columns with different sheets: `[Sheet1!A:H, 'Sheet2!A:H', 'Sheet3!A:H']`

The following code example shows how to change the width for single/multiple columns in the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/column-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnWidthController.cs" %}
{% include code-snippet/spreadsheet/column-width/columnWidthController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/column-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnWidthController.cs" %}
{% include code-snippet/spreadsheet/column-width/columnWidthController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Hyperlink](./link)
* [Sorting](./sort)
* [Filtering](./filter)
