---
layout: post
title: Perform Cell Selection And Get Selected Cells Information in ##Platform_Name## Pivot Table Component
description: Learn here all about Perform Cell Selection And Get Selected Cells Information in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Perform Cell Selection And Get Selected Cells Information
publishingplatform: ##Platform_Name##
documentation: ug
---

# Perform cell selection and get selected cells information

You can select any cell/row by setting the property `gridSettings.allowSelection` as `true` where the selected cells can be highlighted. It can be done through mouse down or arrow keys.

## Selection mode

It supports four types of selection mode that can be set by the property `gridSettings.selectionSettings.mode`. They are,

* **`Row`**: The `Row` value is set by default, and allows you to select only rows.
* **`Column`**: Allows you to select only columns.
* **`Cell`**: Allows you to select only cells.
* **`Both`**: Allows you to select rows and columns at the same time.

## Selection type

It supports two types of selection that can be set by the property `gridSettings.selectionSettings.type`. They are,

* **`Single`**: The `Single` value is set by default, and it only allows selection of a single row or a column or a cell.
* **`Multiple`**: Allows you to select multiple rows or cells.
To perform the multi-selection, press and hold CTRL key and click the desired rows or columns or cells. To select range of rows or cells, press and hold the SHIFT key and click the rows or columns or cells.

## Event

The event `cellSelected` fires on every cell/row/column on selected/deselected operations and it provides the selected cells information with its corresponding column and row headers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PivotSelection.cs" %}
{% include code-snippet/pivot-table/pivot-selection/PivotSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PivotSelection.cs" %}
{% include code-snippet/pivot-table/pivot-selection/PivotSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


