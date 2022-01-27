---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Paging of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---


# Paging

Paging provides an option to display Grid data in page segments. To enable paging, set the [`AllowPaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_AllowPaging_System_Boolean_) to true. When paging is enabled, pager component renders at the bottom of the grid.
Paging options can be configured through the [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridBuilder-1.html#Syncfusion_EJ2_Grids_GridBuilder_1_PageSettings_Syncfusion_EJ2_Grids_GridPageSettings_).

In the below sample, `pageSize` is calculated based on the grid height by using the `load` event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/paging/page/page.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/page/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/paging/page/page.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/page/razor %}
{% endhighlight %}
{% endtabs %}



> You can achieve better performance by using grid paging to fetch only a pre-defined number of records from the data source.

## Template

You can use custom elements inside the pager instead of default elements.
The custom elements can be defined by using the `Template` property.
Inside this template, you can access the `CurrentPage`, `PageSize`, `TotalPage` and `TotalRecordCount` values.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/paging/page-temp/page-temp.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/page-temp/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/paging/page-temp/page-temp.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/page-temp/razor %}
{% endhighlight %}
{% endtabs %}



## Pager with Page Size Dropdown

The pager Dropdown allows you to change the number of records in the Grid dynamically. It can be enabled by defining the `pageSettings.pageSizes` property as true.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/paging/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/pagerdropdown/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/paging/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/pagerdropdown/razor %}
{% endhighlight %}
{% endtabs %}



## How to render Pager at the Top of the Grid

By default, Pager will be rendered at the bottom of the Grid. You can also render the Pager at the top of the Grid by using the `dataBound` event.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/paging/pagerattop/pagerattop.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/pagerattop/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/paging/pagerattop/pagerattop.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/paging/pagerattop/razor %}
{% endhighlight %}
{% endtabs %}



> During the paging action, the pager component triggers the below three events.
> * The `created` event triggers when Pager is created.
> * The `click` event triggers when the numeric items in the pager is clicked.
> * The `dropDownChanged` event triggers when pageSize DropDownList value is selected.

## See Also

* [Group with Paging](./grouping##group-with-paging)
