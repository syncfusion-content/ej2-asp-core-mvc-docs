---
layout: post
title: Sort Columns in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to sort columns in ##Platform_Name## Query Builder using the SortDirection property to display fields in ascending or descending order.
platform: ej2-asp-core-mvc
control: Sort Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sort Columns in ##Platform_Name## Query Builder

The [`SortDirection`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_SortDirection) property allows you to sort the columns bound to the Query Builder to view the columns in ascending or descending order. You should set the `SortDirection` property to sort the fields.

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


