---
layout: post
title: Paging in ##Platform_Name## Grid Control | Syncfusion
description: Learn here all about Paging in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---


# Paging in Grid Control

Paging provides an option to display Grid data in page segments. To enable paging, set the [`allowPaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowPaging) to true. When paging is enabled, pager component renders at the bottom of the grid. Paging options can be configured through the [`e-page-settings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PageSettings) tag helper.

In the below sample, `pageSize` is calculated based on the grid height by using the [`load`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event.

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



> You can achieve better performance by using grid paging to fetch only a pre-defined number of records from the data source.

## Template

You can use custom elements inside the pager instead of default elements. The custom elements can be defined by using the [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_Template) property of **e-page-settings** tag helper. Inside this template, you can access the **CurrentPage**, **PageSize**, **TotalPage** and **TotalRecordCount** values.

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

The pager Dropdown allows you to change the number of records in the Grid dynamically. It can be enabled by defining the [`pageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) property of **e-page-settings** as true.

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

By default, Pager will be rendered at the bottom of the Grid. You can also render the Pager at the top of the Grid by using the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

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



> During the paging action, the pager component triggers the below three events.
> * The **created** event triggers when Pager is created.
> * The **click** event triggers when the numeric items in the pager is clicked.
> * The **dropDownChanged** event triggers when pageSize DropDownList value is selected.

## See Also

* [Group with Paging](./grouping##group-with-paging)
