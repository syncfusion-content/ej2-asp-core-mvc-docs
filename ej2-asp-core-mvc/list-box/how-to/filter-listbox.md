---
layout: post
title: Filter ListBox Data Using TextBox in ##Platform_Name## List Box Control | Syncfusion
description: Learn here all about Filter ListBox Data Using TextBox Component in Syncfusion ##Platform_Name## List Box component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filter List Box
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to Filter List box Data Using TextBox Component

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

