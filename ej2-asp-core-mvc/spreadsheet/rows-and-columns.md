---
layout: post
title: Rows And Columns in ##Platform_Name## Spreadsheet Component
description: Learn here all about Rows And Columns in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Rows And Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rows and columns

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



## Hide and show

You can show or hide the rows and columns in the spreadsheet through property binding, method, and context menu.

## Row

The rows can be hidden or shown through the following ways,

* Using `hidden` property in row, you can hide/show the rows at initial load.
* Using `hideRow` method, you can hide the rows by specifying the start and end row index, set the last argument `hide` as `false` to unhide the hidden rows.
* Right-click on the row header and select the desired option from context menu

## Column

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



## Limitations

The following features have some limitations in Insert/Delete:

* Insert row/column between the formatting applied cells.
* Insert row/column between the data validation.
* Insert row/column between the conditional formatting applied cells.
* Insert/delete row/column between the filter applied cells.

## See Also

* [Hyperlink](./link)
* [Sorting](./sort)
* [Filtering](./filter)
