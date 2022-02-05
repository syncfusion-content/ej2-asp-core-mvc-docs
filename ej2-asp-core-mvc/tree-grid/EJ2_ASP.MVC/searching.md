---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Searching of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---

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