---
layout: post
title: Filter Menu in ##Platform_Name## Tree Grid Component
description: Learn here all about Filter Menu in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filter Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filter Menu

You can enable filter menu by setting the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Type.html) as **menu**. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/filter-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FilterMenu.cs" %}
{% include code-snippet/tree-grid/filtering/filter-menu/filterMenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/filter-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FilterMenu.cs" %}
{% include code-snippet/tree-grid/filtering/filter-menu/filterMenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) must be set as true to enable filter menu.
> * Setting [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper as false will prevent filter menu rendering for a particular column.

## Custom component in filter menu

The [`filter`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper is used to add custom filter components to a particular column. To implement custom filter ui, define the following functions:

* **create**:  Creates custom component.
* **write**: Wire events for custom component.
* **read**: Read the filter value from custom component.

In the following sample, dropdown is used  as custom component in the duration column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/filter-menu-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FilterMenuUI.cs" %}
{% include code-snippet/tree-grid/filtering/filter-menu-ui/filterMenuUI.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/filter-menu-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FilterMenuUI.cs" %}
{% include code-snippet/tree-grid/filtering/filter-menu-ui/filterMenuUI.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable different filter for a column

You can use both **Menu** and **Excel** filter in a same TreeGrid. To do so, set the type as **Menu** or **Excel** using [`filter`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

In the following sample menu filter is enabled by default and excel filter is enabled for the Task Name column using the [`filter`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Filter.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/diffcolumnfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Diffcolumnfilter.cs" %}
{% include code-snippet/tree-grid/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/diffcolumnfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diffcolumnfilter.cs" %}
{% include code-snippet/tree-grid/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.