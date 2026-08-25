---
layout: post
title: Virtual Scrolling in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how the ASP.NET MVC Pivot Table renders only the rows and columns visible in the viewport using EnableVirtualization, for efficient large-dataset rendering.
platform: ej2-asp-core-mvc
control: Virtual Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Virtual scrolling in ASP.NET MVC Pivot Table

## Virtual scrolling

Virtual scrolling enables efficient handling of large datasets by rendering only the rows and columns visible in the current viewport. Content refreshes dynamically as the user scrolls vertically or horizontally. This feature is enabled by setting the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property to **true** (default `false`).

N> Virtualization and [Paging](./paging) cannot be enabled at the same time. Use one or the other; they are designed to handle data rendering differently and may conflict when combined.


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

![Virtual scrolling example](images/virtualscrolling.gif)

> The `height` and `width` properties should be set for virtual scrolling. If they are not defined, the Pivot Table defaults to `300px` height and `800px` width.

## Virtual Scrolling with Single Page Mode

When virtual scrolling is enabled, the Pivot Table renders not only the current view page but also the adjacent previous and next pages by default. While this approach supports smooth navigation, it can increase computational load and reduce performance when working with extensive datasets, as additional rows and columns from surrounding pages are processed.

To optimize performance, set the [AllowSinglePage](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewVirtualScrollSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewVirtualScrollSettingsBuilder_AllowSinglePage_System_Boolean_) property to **true** within the [PivotViewVirtualScrollSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewVirtualScrollSettings.html). Enabling this property ensures that only the rows and columns for the current view page are rendered during virtual scrolling. This significantly enhances the performance of the Pivot Table, especially during initial rendering and user actions such as drilling up, drilling down, sorting, and filtering.

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

### Static field list

Virtual scrolling works automatically with **Popup** field lists when you set the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property in the Pivot Table to **true**. However, when using a static field list (displayed as a separate component), you need to connect both components manually.

To make virtual scrolling work with a static field list:

1. Enable virtual scrolling in the Pivot Table component by setting the [EnableVirtualization](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableVirtualization) property to **true**.
2. Connect the PivotFieldList component to the Pivot Table component using the [load](https://ej2.syncfusion.com/documentation/common/api-l10n.html#load) event.
3. Synchronize the Pivot Table and field list by updating the Pivot Table's report configuration with the field list's report configuration inside the [load](https://ej2.syncfusion.com/documentation/common/api-l10n.html#load) event.

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


## Limitations

* In virtual scrolling, the [ColumnWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property in [GridSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) must be in pixels; percentage values are not accepted.
* Features such as auto fit, column resizing, text wrapping, and setting column widths through events can dynamically affect the row height and column width at runtime. These changes are not considered in the scroller calculations, particularly with large datasets, which can cause performance issues. It is not recommended to use these features alongside virtualization.
* Grouping, which takes additional time to split raw items into the provided format.
* Date formatting, which takes additional time to convert date format.
* Date formatting with sorting requires the full date-time format to perform sorting along with the provided date format, which lags performance.
* When using OLAP data, subtotals and grand totals are only displayed when measures are bound at the last position in the [Row](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [Column](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) axis. Otherwise, the Pivot Table will show data without summary totals.
* Even with virtual scrolling, the current viewport data plus the immediate previous and next pages are all retrieved. As a result, when the user scrolls slightly ahead or behind, the next or previous page data is shown immediately. **Note:** Large `width` and `height` values increase the loading count across the current, previous, and next viewport, which can affect performance.

## See also

* [Paging](./paging)
* [Data Compression](./data-compression)
* [Performance best practices](./performance-best-practices)