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
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/search/external-btn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="initial-search" %}
{% include code-snippet/grid/search/external-btn/initial-search.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/search/external-btn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="initial-search" %}
{% include code-snippet/grid/search/external-btn/initial-search.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Search specific columns

By default, grid searches all visible columns. You can search specific columns by defining the specific column's field names in the `SearchSettings.Fields` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/search/search-a-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="search-a-column" %}
{% include code-snippet/grid/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/search/search-a-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="search-a-column" %}
{% include code-snippet/grid/search/search-a-column/search-a-column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Clear search by external button

To clear the searched grid records from the external button, set [`searchSettings.key`](./api-searchSettings.html#key-string) property as `empty` string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/search/clear-search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="clear-search" %}
{% include code-snippet/grid/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/search/clear-search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="clear-search" %}
{% include code-snippet/grid/search/clear-search/clear-search.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


