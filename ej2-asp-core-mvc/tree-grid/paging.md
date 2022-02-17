---
layout: post
title: Paging in ##Platform_Name## Tree Grid Component
description: Learn here all about Paging in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---


# Paging

Paging provides an option to display TreeGrid data in page segments. To enable paging, set the [`AllowPaging`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowPaging.html) to true. When paging is enabled, pager component renders at the bottom of the treegrid.
Paging options can be configured through the [`PageSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~PageSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/default-paging/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultPaging.cs" %}
{% include code-snippet/tree-grid/paging/default-paging/defaultPaging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/default-paging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultPaging.cs" %}
{% include code-snippet/tree-grid/paging/default-paging/defaultPaging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can achieve better performance by using treegrid paging to fetch only a pre-defined number of records from the data source.

## Page Size Mode

Two behaviour are available in TreeGrid paging to display certain number of records in a current page. Following are the two types of [`PageSizeMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizeMode.html).

* **All** : This is the default mode. The number of records in a page is based on [`PageSize`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSize.html) property.
* **Root** : The number of root nodes or the 0th level records to be displayed per page is based on [`PageSize`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSize.html) property.

With [`PageSizeMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizeMode.html) property as `Root`, only the root level or the 0th level records are considered in records count.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/page-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PageMode.cs" %}
{% include code-snippet/tree-grid/paging/page-mode/pageMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/page-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PageMode.cs" %}
{% include code-snippet/tree-grid/paging/page-mode/pageMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template

You can use custom elements inside the pager instead of default elements.
The custom elements can be defined by using the [`Template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~Template.html) property.
Inside this template, you can access the [`CurrentPage`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~CurrentPage.html), [`PageSize`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSize.html), [`PageCount`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageCount.html), `TotalPage` and `TotalRecordCount` values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/pager-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PagerTemplate.cs" %}
{% include code-snippet/tree-grid/paging/pager-template/pagerTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/pager-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PagerTemplate.cs" %}
{% include code-snippet/tree-grid/paging/pager-template/pagerTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pager with Page Size Dropdown

The pager Dropdown allows you to change the number of records in the TreeGrid dynamically. It can be enabled by defining the [`PageSettings.PageSizes`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridPageSettings~PageSizes.html) property as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/page-sizes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PageSizes.cs" %}
{% include code-snippet/tree-grid/paging/page-sizes/pageSizes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/page-sizes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PageSizes.cs" %}
{% include code-snippet/tree-grid/paging/page-sizes/pageSizes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Page size dropdown](images/pagesizes.png)

## How to render Pager at the Top of the TreeGrid

By default, Pager will be rendered at the bottom of the TreeGrid. You can also render the Pager at the top of the TreeGrid by using the `DataBound` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/tree-grid/paging/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/paging/customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/tree-grid/paging/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> During the paging action, the pager component triggers the below three events.
> * The `created` event triggers when Pager is created.
> * The `click` event triggers when the numeric items in the pager is clicked.
> * The `dropDownChanged` event triggers when pageSize DropDownList value is selected.