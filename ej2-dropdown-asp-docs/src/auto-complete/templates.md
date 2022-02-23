---
title: "Autocomplete Template"
component: "AutoComplete"
description: "This section for Syncfusion ASP.NET autocomplete control shows how to customize the appearance of each item in the pop-up list using template option."
---

# Templates

The AutoComplete has been provided with several options to customize each list items, group title, header
and footer elements. It uses the Essential JS 2 `Template engine` to compile
and render the elements properly.

## Item template

The content of each list item within the AutoComplete can be customized with the help of
[itemTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~ItemTemplate.html) property.

In the following sample, each list item is split into two columns to display relevant data's.

{% aspTab template="autocomplete/templates/itemtemplate", sourceFiles="itemtemplate.cs" %}

{% endaspTab %}

## Group template

The group header title under which appropriate sub-items are categorized can also be customize
with the help of [groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~GroupTemplate.html) property. This template is common
for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

{% aspTab template="autocomplete/templates/grouptemplate", sourceFiles="grouptemplate.cs" %}

{% endaspTab %}

## Header template

The header element is shown statically at the top of the suggestion list items
within the AutoComplete, and any custom element can be placed as a header element using
[headerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~HeaderTemplate.html) property.

In the following sample, the list items and its headers are designed and displayed as two columns similar to multiple columns of the grid.

{% aspTab template="autocomplete/templates/headertemplate", sourceFiles="headertemplate.cs" %}

{% endaspTab %}

## Footer template

The AutoComplete has options to show a footer element at the bottom of the list items in the
suggestion list. Here, you can place any custom element as a footer element using
[footerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~FooterTemplate.html) property.

In the following sample, footer element displays the total number of list items present in the AutoComplete.

{% aspTab template="autocomplete/templates/footertemplate", sourceFiles="footertemplate.cs" %}

{% endaspTab %}

## No records template

The AutoComplete is provided with support to custom design the suggestion list content when no data is
found and no matches found on search with the help of
[`noRecordsTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~NoRecordsTemplate.html) property.

In the following sample, suggestion list content displays the notification of no data available.

{% aspTab template="autocomplete/templates/norecordstemplate", sourceFiles="norecordstemplate.cs" %}

{% endaspTab %}

## Action failure template

There is also an option to custom design the suggestion list content when the data fetch request
fails at the remote server. This can be achieved using the
[actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~ActionFailureTemplate.html) property.

In the following sample, when the data fetch request fails, the AutoComplete displays the notification.

{% aspTab template="autocomplete/templates/actionfailuretemplate", sourceFiles="actionfailuretemplate.cs" %}

{% endaspTab %}

## See Also

* [How to acheive filtering](./filtering/)
* [How to group the data using header](./grouping#grouping)
* [How to show the list items with icon](./how-to/icon-support/)