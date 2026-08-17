---
layout: post
title: Sorting in ASP.NET MVC Mention | Syncfusion
description: Sort Syncfusion ASP.NET MVC Mention suggestion list items alphabetically by setting the sortOrder property to Ascending, Descending, or None.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: aspnet-mvc
documentation: ug
---

# Sorting in ASP.NET MVC Mention

You can display the suggestion list items in a specific order. It has possible types as `Ascending`, `Descending`, and `None` in the [SortOrder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SortOrder) property.

* `None` - The data source is not sorted.
* `Ascending` - The data source is sorted in ascending order.
* `Descending` - The data source is sorted in descending order.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/sorting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/sorting/SportsData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention sorting](./images/mention-sorting.png)