---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Virtual Scrolling of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Virtual Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Virtual Scrolling

## Virtual Scrolling

The virtual scrolling option allows you to load the large amounts of data without performance degradation by rendering rows and columns only in the content viewport. The data will refresh dynamically on vertical or horizontal scroll. This feature can be enabled by setting the [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**.

{% aspTab template="pivot-table/virtual-scrolling", sourceFiles="VirtualScrolling.cs" %}

{% endaspTab %}

![output](images/virtualscrolling.png)

**Limitations for virtual scrolling**

* In virtual scrolling, the [`columnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property in [`e-gridSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) should be in pixel and percentage values are not accepted.
* Resizing columns, setting width to individual columns which affects the calculation used to pick the correct page on scrolling.
* Grouping, which takes additional time to splitting the raw items into the provided format.
* Date Formatting, which takes additional time to convert date format.
* Date Formatting with sorting, here additionally full date time format should be framed to perform sorting along with the provided date format which lags the performance.

## Data Compression

> This property is applicable only for relational data source.

When we bind one million raw data, the pivot table will process all raw data to generate aggregated data during initial rendering and report manipulation. But in data compression, the data will be compressed based on the uniqueness of the raw data, and unique records will be provided as input for the Pivot Table. The compressed data will be used for further operations at all times, reducing the looping complexity and improving the performance of the pivot table. For example, if the pivot table  is connected to one million raw data aggregated to 1,000 unique data means, it will be rendered within 3 seconds rather than 10 seconds. You can enable this option by using the [`allowDataCompression`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDataCompression) property along with [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property.

> This options will only function when the virtual scrolling is enabled.

{% aspTab template="pivot-table/virtual-scrolling-compression", sourceFiles="VirtualScrolling.cs" %}

{% endaspTab %}

**Limitations during data compression**

* The following aggregation types will not be supported.
    * Average
    * Populationstdev
    * Samplestdev
    * Populationvar
    * Samplevar
* If you use any of the aggregations above, it will result in an aggregation type **"Sum"**.
* Distinctcount will act as **"Count"** aggregation type.
* In the calculated field, an existing field can be inserted without altering its default aggregation type Even if we change it, it would use the default aggregation type back for calculation.

## Virtual scrolling for static field list

Virtual scrolling automatically works with "Popup" field list on setting the [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table to **true**. Incase of static field list, which act as a separate component, user need to enable [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table and also pass the report information to pivot table instance via the [`load`](https://ej2.syncfusion.com/documentation/common/api-l10n.html#load) event of the field list.

{% aspTab template="pivot-table/field-list/static-fieldlist-virtualization", sourceFiles="virtualization.cs" %}

{% endaspTab %}