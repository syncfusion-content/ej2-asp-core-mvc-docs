---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grouping of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping

The ComboBox supports wrapping nested elements into a group based on different categories. The category
of each list item can be mapped through the [groupBy](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBoxFieldSettings~GroupBy.html) field in
the data table. The group header is displayed both as inline and fixed headers. The fixed group header content
is updated dynamically on scrolling the popup list with its category value.

In the following sample, vegetables are grouped according on its category using `groupBy` field.

{% aspTab template="combobox/grouping", sourceFiles="grouping.cs,Vegetables.cs" %}

{% endaspTab %}

## Customization

The grouping header is also provided with customization option. This allows custom designing using the `groupTemplate` property for both inline and fixed headers as referred here:
[Group Template support to ComboBox](./templates).