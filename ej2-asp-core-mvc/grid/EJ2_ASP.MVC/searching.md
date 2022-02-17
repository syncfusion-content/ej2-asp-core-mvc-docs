---
layout: post
title: Searching in ##Platform_Name## Grid Component
description: Learn here all about Searching in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---


# Search

You can search records in a Grid, by using the [`search`](https://ej2.syncfusion.com/documentation/api/grid/#search) method with search key as a parameter. This also provides an option to integrate search text box in grid's toolbar by adding **Search** item to the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Search.cs" %}
{% include code-snippet/grid/search/search/search.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Search.cs" %}
{% include code-snippet/grid/search/search/search.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Initial search

To apply search at initial rendering, set the fields, operator, key, and ignoreCase in the [`SearchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/search/initial-search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-search.cs" %}
{% include code-snippet/grid/search/initial-search/initial-search.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/initial-search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-search.cs" %}
{% include code-snippet/grid/search/initial-search/initial-search.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, grid searches all the bound column values. To customize this behavior define the [`Fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) of [`SearchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html) property.

## Search operators

The search operator can be defined in the [`Operator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Operator) property of [`SearchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html) to configure specific searching.

The following operators are supported in searching:

Operator |Description
-----|-----
startswith |Checks whether a value begins with the specified value.
endswith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notequal |Checks for values not equal to the specified value.

> By default, the [`Operator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Operator) value is **contains**.

## Search by external button

To search grid records from an external button, invoke the [`search`](https://ej2.syncfusion.com/documentation/api/grid/#search) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/search/external-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="External-btn.cs" %}
{% include code-snippet/grid/search/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/external-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="External-btn.cs" %}
{% include code-snippet/grid/search/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`Fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) property of [`SearchSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search-a-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Search-a-column.cs" %}
{% include code-snippet/grid/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search-a-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Search-a-column.cs" %}
{% include code-snippet/grid/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Clear search by external button

To clear the searched grid records from the external button, set [`Key`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Key) property as **empty** string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/search/clear-search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clear-search.cs" %}
{% include code-snippet/grid/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/clear-search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clear-search.cs" %}
{% include code-snippet/grid/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Search on each key stroke

You can search the Grid data on each key stroke by binding the `keyup` event for the search input element inside the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. Inside the `keyup` handler you can search the Grid by invoking the [`search`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#search) method of the Grid component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search-each-key/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Search-each-key.cs" %}
{% include code-snippet/grid/search/search-each-key/search-each-key.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/search/search-each-key/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Search-each-key.cs" %}
{% include code-snippet/grid/search/search-each-key/search-each-key.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Add clear icon in search in ASP.NET MVC  Grid](https://www.syncfusion.com/forums/139361/add-clear-icon-in-search-in-asp-net-mvc-grid)