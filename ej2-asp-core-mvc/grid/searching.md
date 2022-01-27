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

> By default, the `SearchSettings.Operator` value is `contains`.

## Search by external button

To search grid records from an external button, invoke the `search` method.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="external-btn" %}
{% include_relative code-snippet/search/external-btn/initial-search.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="external-btn" %}
{% include_relative code-snippet/search/external-btn/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="external-btn" %}
{% include_relative code-snippet/search/external-btn/initial-search.cs %}
{% endhighlight %}
{% highlight razor tabtitle="external-btn" %}
{% include_relative code-snippet/search/external-btn/razor %}
{% endhighlight %}
{% endtabs %}



## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the `SearchSettings.Fields` property.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="search-a-column" %}
{% include_relative code-snippet/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="search-a-column" %}
{% include_relative code-snippet/search/search-a-column/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="search-a-column" %}
{% include_relative code-snippet/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% highlight razor tabtitle="search-a-column" %}
{% include_relative code-snippet/search/search-a-column/razor %}
{% endhighlight %}
{% endtabs %}



## Clear search by external button

To clear the searched grid records from the external button, set [`searchSettings.key`](./api-searchSettings.html#key-string) property as `empty` string.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="clear-search" %}
{% include_relative code-snippet/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="clear-search" %}
{% include_relative code-snippet/search/clear-search/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="clear-search" %}
{% include_relative code-snippet/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% highlight razor tabtitle="clear-search" %}
{% include_relative code-snippet/search/clear-search/razor %}
{% endhighlight %}
{% endtabs %}


