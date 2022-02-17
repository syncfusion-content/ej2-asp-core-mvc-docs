---
layout: post
title: Sort Columns in ##Platform_Name## Query Builder Component
description: Learn here all about Sort Columns in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: Sort Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sort the columns

SortDirection allows you to sort the columns bounded to the Query Builder to view the columns by ascending or descending order. You should set the `SortDirection` property to sort the fields.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/how-to/sorting/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/how-to/sorting/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


