---
layout: post
title: Sorting in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Sorting in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Sorting in ##Platform_Name## MultiColumn Combobox control

The MultiColumn ComboBox control provides built-in support for sorting data-bound columns in ascending or descending order by using the [AllowSorting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_AllowSorting) property. By default, the value is `true`.

To sort a particular column in the MultiColumn ComboBox, click on the grid column header in the popup. Each click on the header toggles the sorting order of the column between `Ascending` and `Descending`.

## Setting the sort order

You can use the [SortOrder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_SortOrder) property to set the order of the column. It supports three types of sorting [None](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.SortOrder.html#Syncfusion_EJ2_MultiColumnComboBox_SortOrder_None), [Ascending](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.SortOrder.html#Syncfusion_EJ2_MultiColumnComboBox_SortOrder_Ascending) and [Descending](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.SortOrder.html#Syncfusion_EJ2_MultiColumnComboBox_SortOrder_Descending).

When you click on a column header for the first time, it sorts the column in ascending order. Clicking the same column header again will sort the column in descending order. A repetitive third click on the same column header will clear the sorting.

In the following examples, data sorting is done with `Descending` order.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/sorting/sort-order/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sorting.cs" %}
{% include code-snippet/multicolumn-combobox/sorting/sort-order/sort-order.cs %}
{% endhighlight %}
{% endtabs %}

![SortOrder](images/sortorder.png)

## Sort type

You can use the [SortType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_SortType) property to set the type of sorting applied to the columns. It supports tow types [OneColumn](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.SortType.html#Syncfusion_EJ2_MultiColumnComboBox_SortType_OneColumn) and [MultipleColumns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.SortType.html#Syncfusion_EJ2_MultiColumnComboBox_SortType_MultipleColumns). By default the `SortType` is oneColumn.

To sort multiple columns press and hold the CTRL key and click on the column headers. This feature is useful when you want to sort your data based on multiple criteria to analyze it in various ways.

In the following examples, data sorting type is set with `MultipleColumns`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/sorting/sort-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SortType.cs" %}
{% include code-snippet/multicolumn-combobox/sorting/sort-type/sort-type.cs %}
{% endhighlight %}
{% endtabs %}

![SortType](images/sorttype.png)
