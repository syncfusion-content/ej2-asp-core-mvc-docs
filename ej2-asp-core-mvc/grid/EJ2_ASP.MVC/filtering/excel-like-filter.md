---
layout: post
title: Excel Like Filter in ##Platform_Name## Grid Component
description: Learn here all about Excel Like Filter in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Like Filter
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Like Filter

You can enable Excel like filter by defining [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Excel**. The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Bind custom remote datasource for excel/checkbox filtering

The Syncfusion Grid allows you to dynamically change the filter data source for the Excel or Checkbox filter [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) using custom remote data as well. This can be achieved by either assigning a custom remote `DataManager` as the filter model dataSource or by initially fetching the data, storing it in a global variable, and then assigning this global variable directly to the filter model dataSource in the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event for the `filterBeforeOpen` [requestType](https://ej2.syncfusion.com/documentation/api/grid/filterEventArgs/#requesttype), as detailed in our [knowledge base](https://support.syncfusion.com/kb/article/10065/how-to-change-the-data-source-for-checkbox-filter-popup-in-grid).

The following example demonstrates how to dynamically change the remote custom dataSource for all columns in the Excel or Checkbox filter dialog using a `DataManager` with `UrlAdaptor`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfiltercustomremotedata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfiltercustomremotedata/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfiltercustomremotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfiltercustomremotedata/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Render checkbox list data in on-demand for excel/checkbox filtering

The Excel/Checkbox filter type of Grid has a restriction where only the first 1000 unique sorted items are accessible to view in the filter dialog checkbox list content by scrolling. This limitation is in place to avoid any rendering delays when opening the filter dialog. However, the searching and filtering processes consider all unique items in that particular column.

The Excel/Checkbox filter in the Grid provides an option to load large data sets on-demand during scrolling to improve scrolling limitation functionality. This is achieved by setting the [EnableInfiniteScrolling](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_EnableInfiniteScrolling) property to **true**. This feature proves especially beneficial for managing extensive datasets, enhancing data loading performance in the checkbox list, and allowing interactive checkbox selection with persistence for the selection based on filtering criteria.

The Excel/Checkbox filter retrieves distinct data in ascending order, governed by its [ItemsCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ItemsCount)  property, with a default value of **50**. As the checkbox list data scroller reaches its end, the next dataset is fetched and displayed, with the notable advantage that this process only requests new checkbox list data without redundantly fetching the existing loaded dataset.

### Customize the items count for initial rendering

Based on the items count value, the Excel/Checkbox filter gets unique data and displayed in Excel/Checkbox filter content dialog. You can customize the count of on-demand data rendering for Excel/Checkbox filter by adjusting the [ItemsCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ItemsCount) property. The default value is `50`.

```html
@Html.EJS().Grid("OnDemandExcelFilter").DataSource(ViewBag.DataSource).FilterSettings(Filter => Filter.EnableInfiniteScrolling(true).ItemsCount(40))
```

> It is recommended to keep the itemsCount below **300**. Higher values will result in unwanted whitespace because of DOM maintenance performance degradation.

### Customize the loading animation effect

A loading effect is presented to signify that loading is in progress when the checkbox list data scroller reaches the end, and there is a delay in receiving the data response from the server. The loading effect during on-demand data retrieval for Excel/Checkbox filter can be customized using the [LoadingIndicator](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_LoadingIndicator) property. The default value is `Shimmer`.

```html
@Html.EJS().Grid("OnDemandExcelFilter").DataSource(ViewBag.DataSource).FilterSettings(Filter => Filter.EnableInfiniteScrolling(true).LoadingIndicator(Syncfusion.EJ2.Grids.IndicatorType.Spinner))
```

In the provided example, On-Demand Excel filter has been enabled for the ##Platform_Name## Grid

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/checkbox-excel-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OnDemandExcelFilter.cs" %}
{% include code-snippet/grid/checkbox-excel-filter/ondemandexcelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/checkbox-excel-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OnDemandExcelFilter.cs" %}
{% include code-snippet/grid/checkbox-excel-filter/ondemandexcelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [How to perform filter by using Wildcard and LIKE operator filter](./filtering/#wildcard-and-like-operator-filter)
