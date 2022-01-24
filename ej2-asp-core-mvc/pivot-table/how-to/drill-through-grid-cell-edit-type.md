---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Drill Through Grid Cell Edit Type of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
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

{% aspTab template="pivot-table/summary-customization/edit-type", sourceFiles="EditType.cs" %}

{% endaspTab %}

![output](images/edit-type.png)