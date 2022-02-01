---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Searching of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---

startswith |Checks whether a value begins with the specified value.
endswith |Checks whether a value ends with the specified value.
contains |Checks whether a value contains the specified value.
equal |Checks whether a value is equal to the specified value.
notequal |Checks for values not equal to the specified value.

> By default, the [`operator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Operator) value is **contains**.

## Search by external button

To search grid records from an external button, invoke the **search** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="external-btn" %}
{% include code-snippet/grid/search/external-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="external-btn" %}
{% include code-snippet/grid/search/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="external-btn" %}
{% include code-snippet/grid/search/external-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="external-btn" %}
{% include code-snippet/grid/search/external-btn/external-btn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) property of **e-grid-searchSettings** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="search-a-column" %}
{% include code-snippet/grid/search/search-a-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="search-a-column" %}
{% include code-snippet/grid/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="search-a-column" %}
{% include code-snippet/grid/search/search-a-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="search-a-column" %}
{% include code-snippet/grid/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Clear search by external button

To clear the searched grid records from the external button, set [`key`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Key) property of **e-grid-searchSettings** as **empty** string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="clear-search" %}
{% include code-snippet/grid/search/clear-search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="clear-search" %}
{% include code-snippet/grid/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="clear-search" %}
{% include code-snippet/grid/search/clear-search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="clear-search" %}
{% include code-snippet/grid/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Search on each key stroke

You can search the Grid data on each key stroke by binding the `keyup` event for the search input element inside the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. Inside the `keyup` handler you can search the Grid by invoking the [`search`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#search) method of the Grid component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="search-each-key" %}
{% include code-snippet/grid/search/search-each-key/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="search-each-key" %}
{% include code-snippet/grid/search/search-each-key/search-each-key.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="search-each-key" %}
{% include code-snippet/grid/search/search-each-key/razor %}
{% endhighlight %}
{% highlight c# tabtitle="search-each-key" %}
{% include code-snippet/grid/search/search-each-key/search-each-key.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

