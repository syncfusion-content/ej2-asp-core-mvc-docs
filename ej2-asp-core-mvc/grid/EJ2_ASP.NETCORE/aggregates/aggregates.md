---
layout: post
title: Aggregates in ##Platform_Name## Grid Component
description: Learn here all about Aggregates in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Aggregates
publishingplatform: aspnet-core
documentation: ug
---


# Aggregates

Aggregate values are displayed in the footer, group footer, or group caption of the Grid. It can be configured through [`e-grid-aggregates`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Aggregates) tag helper.
 [`field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Field) and
  [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type)
 are the minimum properties required to represent an aggregate column.

By default, the aggregate value can be displayed in the footer, group, and caption cells. To show the aggregate value in one of the cells, use the [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_FooterTemplate),
[`groupFooterTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupFooterTemplate),
 or [`groupCaptionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_GroupCaptionTemplate) property.

## Built-in aggregate types

The aggregate type should be specified in the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property to configure an aggregate column.

The built-in aggregates are,
* Sum
* Average
* Min
* Max
* Count
* TrueCount
* FalseCount

> * Multiple aggregates can be used for an aggregate column by setting the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridAggregateColumn.html#Syncfusion_EJ2_Grids_GridAggregateColumn_Type) property
with an array of aggregate types.
> * Multiple types for a column is supported only when one of the aggregate templates is used.