---
title: "Drop-down list Template"
component: "DropDownList"
description: "This section shows on how to customize the appearance of each item in the pop-up list of Syncfusion ASP.NET drop-down list control using template option."
---

# Templates

The DropDownList has been provided with several options to customize each list item, group title,
selected value, header, and footer elements. It uses the Essential JS 2
`Template engine` to compile and render the elements properly.

## Item template

The content of each list item within the DropDownList can be customized with the
help of [itemTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ItemTemplate.html) property.

In the following sample, each list item is split into two columns to display relevant data's.

{% aspTab template="dropdownlist/templates/itemtemplate", sourceFiles="itemtemplate.cs" %}

{% endaspTab %}

## Value template

The currently selected value that is displayed by default on the DropDownList input element can be customized using the [valueTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ValueTemplate.html) property.

In the following sample, the selected value is displayed as a combined text of both `FirstName` and `City`
in the DropDownList input, which is separated by a hyphen.

{% aspTab template="dropdownlist/templates/valuetemplate", sourceFiles="valuetemplate.cs" %}

{% endaspTab %}

## Group template

The group header title under which appropriate sub-items are categorized can also be
customize with the help of
[groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~GroupTemplate.html) property.
This template is common for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

{% aspTab template="dropdownlist/templates/grouptemplate", sourceFiles="grouptemplate.cs" %}

{% endaspTab %}

## Header template

The header element is shown statically at the top of the popup list items within the
DropDownList, and any custom element can be placed as a header element using the
[headerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~HeaderTemplate.html) property.

In the following sample, the list items and its headers are designed and displayed as two columns
similar to multiple columns of the grid.

{% aspTab template="dropdownlist/templates/headertemplate", sourceFiles="headertemplate.cs" %}

{% endaspTab %}

## Footer template

The DropDownList has options to show a footer element at the bottom of the list items in the popup list.
Here, you can place any custom element as a footer element using the [footerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~FooterTemplate.html) property.

In the following sample, footer element displays the total number of list items present in the DropDownList.

{% aspTab template="dropdownlist/templates/footertemplate", sourceFiles="footertemplate.cs" %}

{% endaspTab %}

## No records template

The DropDownList is provided with support to custom design the popup list content when no data is found
and no matches found on search with the help of
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~NoRecordsTemplate.html) property.

In the following sample, popup list content displays the notification of no data available.

{% aspTab template="dropdownlist/templates/norecordstemplate", sourceFiles="norecordstemplate.cs" %}

{% endaspTab %}

## Action failure template

There is also an option to custom design the popup list content when the data fetch request
fails at the remote server. This can be achieved using the
[actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ActionFailureTemplate.html) property.

In the following sample, when the data fetch request fails, the DropDownList displays the notification.

{% aspTab template="dropdownlist/templates/actionfailuretemplate", sourceFiles="actionfailuretemplate.cs" %}

{% endaspTab %}

## See Also

* [How to acheive filtering](./filtering/)
* [How to group the data using header](./grouping/)
* [How to show the list items with icon](./how-to/icons-support/)
* [How to render tooltip for the options](./how-to/tooltip/)