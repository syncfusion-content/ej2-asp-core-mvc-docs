---
layout: post
title: Virtual Scrolling in ##Platform_Name## Pivot Table Component
description: Learn here all about Virtual Scrolling in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Virtual Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Virtual Scrolling

## Virtual Scrolling

The virtual scrolling option allows you to load the large amounts of data without performance degradation by rendering rows and columns only in the content viewport. The data will refresh dynamically on vertical or horizontal scroll. This feature can be enabled by setting the [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**.

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

**Limitations for virtual scrolling**

* In virtual scrolling, the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property in [`GridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) should be in pixel and percentage values are not accepted.
* Resizing columns, setting width to individual columns which affects the calculation used to pick the correct page on scrolling.
* Grouping, which takes additional time to splitting the raw items into the provided format.
* Date Formatting, which takes additional time to convert date format.
* Date Formatting with sorting, here additionally full date time format should be framed to perform sorting along with the provided date format which lags the performance.

## Data Compression

> This property is applicable only for relational data source.

When we bind one million raw data, the pivot table will process all raw data to generate aggregated data during initial rendering and report manipulation. But in data compression, the data will be compressed based on the uniqueness of the raw data, and unique records will be provided as input for the Pivot Table. The compressed data will be used for further operations at all times, reducing the looping complexity and improving the performance of the pivot table. For example, if the pivot table  is connected to one million raw data aggregated to 1,000 unique data means, it will be rendered within 3 seconds rather than 10 seconds. You can enable this option by using the [`AllowDataCompression`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDataCompression) property along with [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property.

> This options will only function when the virtual scrolling is enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/virtual-scrolling-compression/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="VirtualScrolling.cs" %}
{% include code-snippet/pivot-table/virtual-scrolling-compression/VirtualScrolling.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/virtual-scrolling-compression/razor %}
{% endhighlight %}
{% highlight c# tabtitle="VirtualScrolling.cs" %}
{% include code-snippet/pivot-table/virtual-scrolling-compression/VirtualScrolling.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

Virtual scrolling automatically works with "Popup" field list on setting the [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table to **true**. Incase of static field list, which act as a separate component, user need to enable [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table and also pass the report information to pivot table instance via the [`load`](https://ej2.syncfusion.com/documentation/common/api-l10n.html#load) event of the field list.

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

