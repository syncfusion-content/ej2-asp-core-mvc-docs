---
layout: post
title: Data Compression in ##Platform_Name## Pivot Table Component
description: Learn here all about Data Compression in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Compression
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Data Compression in ##Platform_Name## Pivot Table Control

N> This property is applicable only for relational data source.

When we bind one million raw data, the pivot table will process all raw data to generate aggregated data during initial rendering and report manipulation. But in data compression, the data will be compressed based on the uniqueness of the raw data, and unique records will be provided as input for the Pivot Table. The compressed data will be used for further operations at all times, reducing the looping complexity and improving the performance of the pivot table. For example, if the pivot table  is connected to one million raw data aggregated to 1,000 unique data means, it will be rendered within 3 seconds rather than 10 seconds. You can enable this option by using the [`allowDataCompression`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDataCompression) property along with [`enableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property.

N> This options will only function when the virtual scrolling is enabled.

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