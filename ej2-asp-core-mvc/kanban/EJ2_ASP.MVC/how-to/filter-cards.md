---
layout: post
title: Filter Cards in ##Platform_Name## Kanban Component
description: Learn here all about Filter Cards in Syncfusion ##Platform_Name## Kanban component and more.
platform: ej2-asp-core-mvc
control: Filter Cards
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering Cards

You can filter the collection of cards from the dataSource and display it on the Kanban board by using the [`query`](../../api/kanban/#query) property.

In the below sample, you can filter the cards based on the ‘where’ query and display the filtered data to the Kanban board.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/cards/filter-cards/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/cards/filter-cards/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/cards/filter-cards/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/cards/filter-cards/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](../../images/filter-cards.PNG)