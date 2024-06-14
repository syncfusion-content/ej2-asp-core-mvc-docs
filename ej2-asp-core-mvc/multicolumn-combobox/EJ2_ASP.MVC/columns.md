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

The [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Columns) property allow you to define the data fields to be displayed in the MultiColumn ComboBox.

You can customize the column by using [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Columns) property, which provides options such as `Field`, `Header`, `Width`, `Format`, `Template` and more.

In the following examples, column is customized with `field`, `header` and `width`.

* `field` - Specifies the fields to be displayed in each column, mapped from the data source to the multicolumn combobox.

* `header` - Specifes the data to be displayed in the column header.

* `width` - Specifes the column width.

In the following example, the column is customized with `field`, `header` and `width` properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnField.cs" %}
{% include code-snippet/multicolumn-combobox/items/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![ColumnField](images/text.png)

## Setting text align

You can use the `TextAlign` property to define the text alignment of the column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/columns/text-align/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextAlign.cs" %}
{% include code-snippet/multicolumn-combobox/columns/text-align/text-align.cs %}
{% endhighlight %}
{% endtabs %}

![TextAlign](images/textalign.png)

## Setting template

You can use the `Template` property to customize the each cell of the column. It accepts either a template string or an HTML element.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/columns/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/multicolumn-combobox/columns/template/template.cs %}
{% endhighlight %}
{% endtabs %}

![Template](images/template.png)

## Setting display as checkBox

You can use `DisplayAsCheckBox` property to display the column value as checkbox instead of a boolean value. By default, the value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/columns/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayAsCheckBox.cs" %}
{% include code-snippet/multicolumn-combobox/columns/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

![DisplayAsCheckBox](images/checkbox.png)

## Setting custom attributes

You can use the `CustomAttributes` property to customize the CSS styles and attributes of each column's content cells.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/columns/customattribute/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomAttribute.cs" %}
{% include code-snippet/multicolumn-combobox/columns/customattribute/customattribute.cs %}
{% endhighlight %}
{% endtabs %}
