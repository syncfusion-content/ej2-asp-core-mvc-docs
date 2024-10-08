---
layout: post
title: Paging in ##Platform_Name## Grid Component
description: Learn here all about Paging in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---


# Paging

Paging provides an option to display Grid data in page segments. To enable paging, set the [`AllowPaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging) to true. When paging is enabled, pager component renders at the bottom of the grid. Paging options can be configured through the [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html).

In the below sample, **pageSize** is calculated based on the grid height by using the [`Load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/grid/paging/page/page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/grid/paging/page/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can achieve better performance by using grid paging to fetch only a pre-defined number of records from the data source.

## Template

You can use custom elements inside the pager instead of default elements. The custom elements can be defined by using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_Template) property of [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html). Inside this template, you can access the **CurrentPage**, **PageSize**, **TotalPage** and **TotalRecordCount** values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/page-temp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-temp.cs" %}
{% include code-snippet/grid/paging/page-temp/page-temp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/page-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page-temp.cs" %}
{% include code-snippet/grid/paging/page-temp/page-temp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pager with Page Size Dropdown

The pager Dropdown allows you to change the number of records in the Grid dynamically. It can be enabled by defining the [`PageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) property of [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pagerdropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pagerdropdown.cs" %}
{% include code-snippet/grid/paging/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pagerdropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pagerdropdown.cs" %}
{% include code-snippet/grid/paging/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to render Pager at the Top of the Grid

By default, Pager will be rendered at the bottom of the Grid. You can also render the Pager at the top of the Grid by using the [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pagerattop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pagerattop.cs" %}
{% include code-snippet/grid/paging/pagerattop/pagerattop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/paging/pagerattop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pagerattop.cs" %}
{% include code-snippet/grid/paging/pagerattop/pagerattop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> During the paging action, the pager component triggers the below three events.
<br/> The created event triggers when Pager is created.
<br/> The click event triggers when the numeric items in the pager is clicked.
<br/> The dropDownChanged event triggers when pageSize DropDownList value is selected.

## See Also

* [Group with Paging](./grouping##group-with-paging)
