---
layout: post
title: Data Compression in ##Platform_Name## Pivot Table component | Syncfusion
description: Learn here all about data compression in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Compression
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Data Compression in ##Platform_Name## Pivot Table component

> This property is applicable only for the relational data source.

When binding large volumes of raw data, the pivot table processes all raw data to generate aggregated data during initial rendering and report manipulation. However, with data compression enabled, the input raw data is compressed based on the uniqueness of the raw data, and the final compressed raw data is utilized by the pivot table. The compressed raw data is then used for all subsequent operations, reducing the looping complexity and improving the performance of the pivot table. For example, if the pivot table connects to one million raw data records that compress to 1,000 unique raw data records, it will render significantly faster—potentially within 3 seconds rather than 10 seconds, depending on the data complexity and system specifications. Enable this option by using the [AllowDataCompression](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDataCompression) property along with the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property.

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

**Limitations during data compression:**

- The following aggregation types are not supported:
  - Average
  - PopulationStDev
  - SampleStDev
  - PopulationVar
  - SampleVar
- If any of the above aggregation types are used, they will be automatically converted to **"Sum"** aggregation.
- **"DistinctCount"** will function as **"Count"** aggregation type.
- In a calculated field, existing fields can be inserted without changing their default aggregation type. Even if the aggregation type is changed, it will revert to the default aggregation type for calculation purposes.
