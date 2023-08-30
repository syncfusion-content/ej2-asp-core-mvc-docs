---
layout: post
title: Sorting in ASP.NET MVC Mention control | Syncfusion
description: Learn here all about sorting the datasource in Syncfusion ASP.NET MVC Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sorting
publishingplatform: ejmvc
documentation: ug
---

# Sorting datasource in Mention 

## Sort order type

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