---
layout: post
title: Selection in ##Platform_Name## Spreadsheet Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection

Selection provides interactive support to highlight the cell, row, or column that you select. Selection can be done through Mouse, Touch, or Keyboard interaction. To enable selection, set `mode` as `Single` | `Multiple` in [`selectionSettings`](../api/spreadsheet/#selectionsettings). If you set `mode` to `None`, it disables the UI selection.

> * The default value for `mode` in  `selectionSettings` is `Multiple`.

You have the following options in Selection,

* Cell selection
* Row selection
* Column selection

## Cell selection

Cell selection is used to select a single or multiple cells. It can be performed using the [`selectRange`](../api/spreadsheet/#selectRange) method.

**User Interface**:

* Click on a cell to select it (or) use the `arrow` keys to navigate to it and select it.
* To select a range, select a cell, then use the left mouse button to select and drag over to other cells (or) use the `Shift + arrow` keys to select the range.
* To select non-adjacent cells and cell ranges, hold `Ctrl` and select the cells.

You can quickly locate and select specific cells or ranges by entering their names or cell references in the Name box, which is located to the left of the formula bar, and also select named or unnamed cells or ranges by using the Go To (`Ctrl+G`) command.

## Row selection

Row selection is used to select a single or multiple rows.

**User Interface**:

You can perform row selection in any of the following ways,

* By clicking the row header.
* To select multiple rows, select a row header with the left mouse button and drag over to other row headers (or) use the `Shift + arrow` keys to select multiple rows.
* To select non-adjacent rows, hold `Ctrl` and select the row header.
* You can also use the `selectRange` method for row selection.

The following sample shows the row selection in the spreadsheet, here selecting the 5th row using the `selectRange` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/row-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionController.cs" %}
{% include code-snippet/spreadsheet/row-selection/selectionController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/row-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionController.cs" %}
{% include code-snippet/spreadsheet/row-selection/selectionController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column selection

Column selection is used to select a single or multiple columns.

**User Interface**:

You can perform column selection in any of the following ways,

* By clicking the column header.
* To select multiple columns, select a column header with the left mouse button and drag over to other column headers (or) use the `Shift + arrow` keys to select the multiple columns.
* To select non-adjacent columns, hold `Ctrl` and select the column header.
* You can also use the `selectRange` method for row selection.

The following sample shows the column selection in the spreadsheet, here selecting the 3rd column using  the `selectRange` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/column-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionController.cs" %}
{% include code-snippet/spreadsheet/column-selection/selectionController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/column-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionController.cs" %}
{% include code-snippet/spreadsheet/column-selection/selectionController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to remove selection in the spreadsheet

The following sample shows, how to remove the selection in the spreadsheet. Here changing the `mode` as `None` in [`selectionSettings`](../api/spreadsheet/#selectionsettings) to disable's the UI selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/disable-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionController.cs" %}
{% include code-snippet/spreadsheet/disable-selection/selectionController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/disable-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionController.cs" %}
{% include code-snippet/spreadsheet/disable-selection/selectionController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

* We have a limitation while performing the Select All(`ctrl + A`). You can do this only by clicking the Select All button at the top left corner.