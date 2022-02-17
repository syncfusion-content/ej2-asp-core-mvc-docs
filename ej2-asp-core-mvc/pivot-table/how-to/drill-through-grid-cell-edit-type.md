---
layout: post
title: Drill Through Grid Cell Edit Type in ##Platform_Name## Pivot Table Component
description: Learn here all about Drill Through Grid Cell Edit Type in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Drill Through Grid Cell Edit Type
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drill-through grid's cell edit type

Using the `drillThrough` event in the pivot table, you can define the edit type of a particular column in the grid present inside the drill-through dialog. To do so, check the column name in the `drillThrough` event and then specify the edit type of that column using the `gridColumns.editType` event argument.

> The `gridColumns.editType` property must be set based on the column's data type. For example, the string data type will not be applicable for the numeric text box edit type.

* `NumericTextBox` control for integer, double, and decimal data types.
* `TextBox` control for string data type.
* `DropDownList` control to show all unique values related to that field.
* `CheckBox` control for boolean data type.
* `DatePicker` control for date data type.
* `DateTimePicker` control for date time data type.

In the below example, the data type of the `Country` column is set to `DropDownList`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditType.cs" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/EditType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditType.cs" %}
{% include code-snippet/pivot-table/summary-customization/edit-type/EditType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/edit-type.png)