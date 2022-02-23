---
title: "Combo box Template"
component: "ComboBox"
description: "This section for Syncfusion ASP.NET combo box control shows on how to customize the appearance of each item in the pop-up list using template option."
---

# Templates

The ComboBox has been provided with several options to customize each list item, group title,
selected value, header, and footer elements. It uses the Essential JS 2
Template engine to compile and render the elements properly.

## Item template

The content of each list item within the ComboBox can be customized with the
help of [itemTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~ItemTemplate.html)
property.

In the following sample, each list item is split into two columns to display relevant data's.

{% aspTab template="combobox/templates/itemtemplate", sourceFiles="itemtemplate.cs" %}

{% endaspTab %}

## Group template

The group header title under which appropriate sub-items are categorized can also be
customize with the help of
[groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~GroupTemplate.html) property.
This template is common for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

{% aspTab template="combobox/templates/grouptemplate", sourceFiles="grouptemplate.cs" %}

{% endaspTab %}

## Header template

The header element is shown statically at the top of the popup list items within the
ComboBox, and any custom element can be placed as a header element using the
[headerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~HeaderTemplate.html) property.

In the following sample, the list items and its headers are designed and displayed as two columns
similar to multiple columns of the grid.

{% aspTab template="combobox/templates/headertemplate", sourceFiles="headertemplate.cs" %}

{% endaspTab %}

## Footer template

The ComboBox has options to show a footer element at the bottom of the list items in the popup list.
Here, you can place any custom element as a footer element using the [footerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~FooterTemplate.html) property.

In the following sample, footer element displays the total number of list items present in the ComboBox.

{% aspTab template="combobox/templates/footertemplate", sourceFiles="footertemplate.cs" %}

{% endaspTab %}

## No records template

The ComboBox is provided with support to custom design the popup list content when no data is found
and no matches found on search with the help of
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~NoRecordsTemplate.html) property.

In the following sample, popup list content displays the notification of no data available.

{% aspTab template="combobox/templates/norecordstemplate", sourceFiles="norecordstemplate.cs" %}

{% endaspTab %}

## Action failure template

There is also an option to custom design the popup list content when the data fetch request
fails at the remote server. This can be achieved using the
[actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~ActionFailureTemplate.html) property.

In the following sample, when the data fetch request fails, the ComboBox displays the notification.

{% aspTab template="combobox/templates/actionfailuretemplate", sourceFiles="actionfailuretemplate.cs" %}

{% endaspTab %}

## See Also

* [How to acheive filtering](./filtering/)
* [How to group the data using header](./grouping/)
* [How to show the list items with icon](./how-to/icons-support/)