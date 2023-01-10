---
layout: post
title: Searching in ##Platform_Name## Tree Grid Component
description: Learn here all about Searching in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---


# Search

You can search records in a TreeGrid, by using the [`search`](https://ej2.syncfusion.com/documentation/api/treegrid/#search) method with search key as a parameter. This also provides an option to integrate search text box in treegrid's toolbar by adding **search** item to the [`Toolbar`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Toolbar.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/default-searching/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultSearching.cs" %}
{% include code-snippet/tree-grid/searching/default-searching/defaultSearching.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/default-searching/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultSearching.cs" %}
{% include code-snippet/tree-grid/searching/default-searching/defaultSearching.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Initial search

To apply search at initial rendering, set the fields, operator, key, and ignoreCase in the [`SearchSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~SearchSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/initial-search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initialsearch.cs" %}
{% include code-snippet/tree-grid/searching/initial-search/initialsearch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/initial-search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialsearch.cs" %}
{% include code-snippet/tree-grid/searching/initial-search/initialsearch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, treegrid searches all the bound column values. To customize this behavior define the [`SearchSettings.Fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Fields.html) property.

## Search operators

The search operator can be defined in the [`Operators`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Operators.html) property of [`SearchSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings.html) to configure specific searching.

The following operators are supported in searching:

Operator |Description
-----|-----
startsWith |Checks whether a value begins with the specified value.
endsWith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notEqual |Checks for values not equal to the specified value.

> By default, the [`Operators`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Operators.html) value is **contains**.

## Search by external button

To search treegrid records from an external button, invoke the [`search`](https://ej2.syncfusion.com/documentation/api/treegrid/#search) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/search-external/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SearchExternal.cs" %}
{% include code-snippet/tree-grid/searching/search-external/searchExternal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/search-external/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SearchExternal.cs" %}
{% include code-snippet/tree-grid/searching/search-external/searchExternal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Search specific columns

By default, treegrid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`Fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings~Fields.html) property of [`SearchSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSearchSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/search-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SearchColumns.cs" %}
{% include code-snippet/tree-grid/searching/search-columns/searchColumns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/searching/search-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SearchColumns.cs" %}
{% include code-snippet/tree-grid/searching/search-columns/searchColumns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.