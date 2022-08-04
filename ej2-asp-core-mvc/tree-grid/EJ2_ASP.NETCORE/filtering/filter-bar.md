---
layout: post
title: Filter Bar in ##Platform_Name## Tree Grid Component
description: Learn here all about Filter Bar in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filter Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filter Bar

By setting the [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowFiltering.html) to true, the filter bar row will render next to the header, which allows you to filter data. You can filter the records with different expressions depending upon the column type.

 **Filter bar expressions:**

 You can enter the following filter expressions (operators) manually in the filter bar.

Expression |Example |Description |Column Type
-----|-----|-----|-----
= |=value |equal |Number
!= |!=value |notequal |Number
> |>value |greaterthan |Number
< |<value |lessthan |Number
>= |>=value |greaterthanorequal |Number
<=|<=value|lessthanorequal |Number
* |*value |startswith |String
% |%value |endswith |String
N/A |N/A | `Equal` operator will always be used for date filter. |Date
N/A |N/A |`Equal` operator will always be used for Boolean filter. |Boolean

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/default-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultFiltering.cs" %}
{% include code-snippet/tree-grid/filtering/default-filtering/defaultFiltering.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/default-filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultFiltering.cs" %}
{% include code-snippet/tree-grid/filtering/default-filtering/defaultFiltering.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Filter bar template with custom component

The [`filterBarTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~FilterBarTemplate.html) is used to add custom components to a particular column, and does the following functions:
* **create**: Creates custom components.
* **write**: Wires events for custom components.

In the following sample, the dropdown is used as a custom component in the Duration column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/ui-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UiTemplate.cs" %}
{% include code-snippet/tree-grid/filtering/ui-template/uiTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/ui-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UiTemplate.cs" %}
{% include code-snippet/tree-grid/filtering/ui-template/uiTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change default Filter Bar Operator

You can change the default filter operator by extending [`filterModule.filterOperators`](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/filtering/#filter-operators) property in [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DataBound) event.

In the following sample, we have changed the default operator for string typed columns as `contains` from `startsWith`.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/default-filter-operator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default-filter-operator.cs" %}
{% include code-snippet/tree-grid/filtering/default-filter-operator/default-filter-operator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/default-filter-operator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default-filter-operator.cs" %}
{% include code-snippet/tree-grid/filtering/default-filter-operator/default-filter-operator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.