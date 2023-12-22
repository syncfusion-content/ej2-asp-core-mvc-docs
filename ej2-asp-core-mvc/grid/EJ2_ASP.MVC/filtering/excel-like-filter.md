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

You can enable Excel like filter by defining [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Excel**. The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

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

## Render checkbox list data in on-demand for Excel/Checkbox filtering of ##Platform_Name## Grid control

The Excel/Checkbox filter in the Grid provides options for loading large datasets on-demand by enabling the [`EnableInfiniteScrolling`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_EnableInfiniteScrolling) property to `true`. This feature is especially useful for handling extensive datasets and improves data loading performance. The Excel/Checkbox filter retrieves distinct data in ascending order, based on its [`ItemsCount`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ItemsCount) property, which defaults to `50`. When the scroller reaches its end, the next data set is fetched. Importantly, this feature sends a request to retrieve new data only, without making a request for the existing loaded dataset.

### Customization of default on-demand filtersettings:

#### Filter choice count:

You can customize the count of on-demand data rendering for Excel/Checkbox filter by adjusting the [`ItemsCount`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ItemsCount) property. The default value is `50`

```html
@Html.EJS().Grid("OnDemandExcelFilter").DataSource(ViewBag.DataSource).FilterSettings(Filter => Filter.EnableInfiniteScrolling(true).ItemsCount(40))
```

> It is recommended to keep the itemsCount below **300**. Higher values will result in unwanted whitespace because of dom maintenance performance degradation.

#### Loading animation effect:

The loading effect during on-demand data retrieval for Excel/Checkbox filter can be customized using the [`LoadingIndicator`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_LoadingIndicator) property. The default value is `Shimmer`.

```html
@Html.EJS().Grid("OnDemandExcelFilter").DataSource(ViewBag.DataSource).FilterSettings(Filter => Filter.EnableInfiniteScrolling(true).LoadingIndicator(Syncfusion.EJ2.Grids.IndicatorType.Spinner))
```

#### In the following sample, we used the below configuration for On-Demand Excel/Checkbox filter:

```html
@Html.EJS().Grid("OnDemandExcelFilter").DataSource(ViewBag.DataSource).FilterSettings(Filter => Filter.Type(Syncfusion.EJ2.Grids.FilterType.Excel).EnableInfiniteScrolling(true).ItemsCount(40).LoadingIndicator(Syncfusion.EJ2.Grids.IndicatorType.Spinner))
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/checkbox-excel-filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/how-to/checkbox-excel-filter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/checkbox-excel-filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/how-to/checkbox-excel-filter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [How to perform filter by using Wildcard and LIKE operator filter](./filtering/#wildcard-and-like-operator-filter)