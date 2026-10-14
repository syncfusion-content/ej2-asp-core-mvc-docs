---
layout: post
title: How to filter ListBox using TextBox in ##Platform_Name## | Syncfusion
description: Filter Syncfusion ##Platform_Name## ListBox items by binding a partner TextBox keyup to filter the list's dataSource or query string to refine visible items.
platform: ej2-asp-core-mvc
control: Filter List Box
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to filter ListBox using TextBox in ##Platform_Name##

This example demonstrates how to filter data in the Syncfusion<sup style="font-size:70%">&reg;</sup> ListBox using a TextBox component. It shows the implementation of a TextBox filter for data filtering in ListBox items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/filter-listbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scroller.cs" %}
{% include code-snippet/listbox/filter-listbox/filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/filter-listbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scroller.cs" %}
{% include code-snippet/listbox/filter-listbox/filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

