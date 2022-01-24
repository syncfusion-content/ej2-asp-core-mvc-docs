---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grouped Row Page Size of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grouped Row Page Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show grouped rows based on the pageSize

By default, we have displayed the no of records based on the [`PageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize). If you want to show grouped column rows based on the [`PageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize) then we suggest you to use the below way.

In the below sample, we have overridden the default **generateQuery** to display the grouped rows instead of grid rows based on the [`PageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSize).

{% aspTab template="grid/how-to/group-page-size", sourceFiles="group-page-size.cs" %}

{% endaspTab %}