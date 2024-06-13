---
layout: post
title: Columns in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Columns in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Columns in ##Platform_Name## MultiColumn Combobox control

The [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Columns) property allow you to define what data fields is to be displayed in the MultiColumn ComboBox.

You can customize the column by using `e-multicolumncombobox-column` tag helper, which provides options such as `field`, `header`, `width`, `format`, `template` and more.

In the following examples, column is customized with `field`, `header` and `width`.

* `field` property - Specifies the data fields to be displayed in each column, mapping the fields from the data source to the multicolumn combobox.

* `header` property - which is used to display the column header.

* `width` property - which is used to define the column width.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnField.cs" %}
{% include code-snippet/multicolumn-combobox/items/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![ColumnField](images/text.png)

## Setting text align

You can use the `textAlign` property to define the text alignment of the column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/columns/text-align/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextAlign.cs" %}
{% include code-snippet/multicolumn-combobox/columns/text-align/text-align.cs %}
{% endhighlight %}
{% endtabs %}

![TextAlign](images/textalign.png)

## Setting template

You can use the `template` property to customize the each cell of the column. It accepts either a template string or an HTML element.

## Setting display as checkBox

You can use `displayAsCheckBox` property to display the column value as checkbox instead of a boolean value. By default, the value is `false`.

## Setting custom attributes

You can use the `customAttributes` property to customize the CSS styles and attributes of each column's content cells.