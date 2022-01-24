---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customizing Filter Menu Operators List of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customizing Filter Menu Operators List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing filter menu operators list

You can customize the default filter operator list by defining the [`Operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property of [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html).

The available options are:
**stringOperator**- defines customized string operator list.
**numberOperator** - defines customized number operator list.
**dateOperator** - defines customized date operator list.
**booleanOperator** - defines customized boolean operator list.

In the following sample, we have customized string filter operators.

{% aspTab template="grid/how-to/customize-filter-menu", sourceFiles="customize-filter-menu.cs" %}

{% endaspTab %}
