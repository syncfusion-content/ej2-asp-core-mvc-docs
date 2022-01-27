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
{% highlight %}
{% include_relative code-snippet/search/external-btn/external-btn.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/external-btn/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/search/external-btn/external-btn.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/external-btn/razor %}
{% endhighlight %}
{% endtabs %}



## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the [`fields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Fields) property of **e-grid-searchSettings** tag helper.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/search-a-column/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/search-a-column/razor %}
{% endhighlight %}
{% endtabs %}



## Clear search by external button

To clear the searched grid records from the external button, set [`key`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSearchSettings.html#Syncfusion_EJ2_Grids_GridSearchSettings_Key) property of **e-grid-searchSettings** as **empty** string.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/clear-search/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/clear-search/razor %}
{% endhighlight %}
{% endtabs %}



## Search on each key stroke

You can search the Grid data on each key stroke by binding the `keyup` event for the search input element inside the [`created`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. Inside the `keyup` handler you can search the Grid by invoking the [`search`](https://ej2.syncfusion.com/javascript/documentation/api/grid/#search) method of the Grid component.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/search/search-each-key/search-each-key.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/search-each-key/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/search/search-each-key/search-each-key.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/search/search-each-key/razor %}
{% endhighlight %}
{% endtabs %}

