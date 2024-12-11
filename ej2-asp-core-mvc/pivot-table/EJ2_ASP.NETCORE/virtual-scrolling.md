---
layout: post
title: Virtual Scrolling in ##Platform_Name## Pivot Table component | Syncfusion
description: Learn here all about Virtual Scrolling in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtual Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Virtual Scrolling in ##Platform_Name## Pivot Table component

## Virtual Scrolling

The virtual scrolling option allows you to load the large amounts of data without performance degradation by rendering rows and columns only in the content viewport. The data will refresh dynamically on vertical or horizontal scroll. This feature can be enabled by setting the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in [ejs-pivotview](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/virtual-scrolling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="VirtualScrolling.cs" %}
{% include code-snippet/pivot-table/virtual-scrolling/VirtualScrolling.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/virtual-scrolling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="VirtualScrolling.cs" %}
{% include code-snippet/pivot-table/virtual-scrolling/VirtualScrolling.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/virtualscrolling.png)

## Virtual scrolling with single page mode

When virtual scrolling is enabled, the pivot table renders not only the current view page, but also the previous and next pages by default. This default behavior, however, can cause performance delays when dealing with a large number of rows and columns. This is because the same number of rows and columns from adjacent pages are also processed, resulting in additional computational load. This performance constraint can be avoided by setting the [allowSinglePage](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewVirtualScrollSettings.html#Syncfusion_EJ2_PivotView_PivotViewVirtualScrollSettings_AllowSinglePage) property to **true** within the [virtualScrollSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewVirtualScrollSettings.html).

Enabling this property causes the pivot table to render only the rows and columns that are relevant to the current view page during virtual scrolling. This optimization significantly improves the performance of the pivot table during initial rendering and when performing UI actions such as drill up/down, sorting, filtering, and more.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/single-page-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SinglePageMode.cs" %}
{% include code-snippet/pivot-table/single-page-mode/SinglePageMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/single-page-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SinglePageMode.cs" %}
{% include code-snippet/pivot-table/single-page-mode/SinglePageMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Limitations for virtual scrolling**

* In virtual scrolling, the [columnWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property in [e-gridSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) should be in pixel and percentage values are not accepted.
* Resizing columns, setting width to individual columns which affects the calculation used to pick the correct page on scrolling.
* Grouping, which takes additional time to splitting the raw items into the provided format.
* Date Formatting, which takes additional time to convert date format.
* Date Formatting with sorting, here additionally full date time format should be framed to perform sorting along with the provided date format which lags the performance.
* When using OLAP data, subtotals and grandtotals are only displayed when measures are bound at the last position in the [Row](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [Column](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) axis. Otherwise, the data from the pivot table will be shown without summary totals.
* Even if virtual scrolling is enabled, not only is the current view port data retrieved, but also the data for the immediate previous page and the immediate next page. As a result, when the end user scrolls slightly ahead or behind, the next or previous page data is displayed immediately without requiring a refresh. **Note:** If the pivot table's width and height are large, the loading data count in the current, previous, and next view ports (pages) will also increase, affecting performance.

## Virtual scrolling for static field list

Virtual scrolling automatically works with "Popup" field list on setting the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table to **true**. Incase of static field list, which act as a separate component, user need to enable [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table and also pass the report information to pivot table instance via the [load](https://ej2.syncfusion.com/documentation/common/api-l10n.html#load) event of the field list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/static-fieldlist-virtualization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Virtualization.cs" %}
{% include code-snippet/pivot-table/field-list/static-fieldlist-virtualization/virtualization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/static-fieldlist-virtualization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Virtualization.cs" %}
{% include code-snippet/pivot-table/field-list/static-fieldlist-virtualization/virtualization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [Paging in Syncfusion<sup style="font-size:70%">&reg;</sup> EJ2 Typescript components](./paging)
* [Data Compression in Syncfusion<sup style="font-size:70%">&reg;</sup> EJ2 Typescript components](./data-compression)