---
layout: post
title: Sorting in ##Platform_Name## Mention Component
description: Learn here all about sorting the datasource in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Sort order type

The Mention provides an option to sort the data source in a specific order. It has possible types as `Ascending`, `Descending` and `None` in the [SortOrder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SortOrder) property.

In the following sample, the popup list data is rendered in `Descending` order.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/sorting/EmailData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC sorting](../images/asp-core-mvc-mention-sorting.png)