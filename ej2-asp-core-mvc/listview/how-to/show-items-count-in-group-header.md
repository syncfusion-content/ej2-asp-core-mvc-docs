---
layout: post
title: Show items count in group header | Syncfusion
description: Show the Syncfusion ##Platform_Name## ListView grouped item count in each group header via groupTemplate counting visible items per category.
platform: ej2-asp-core-mvc
control: Show Items Count In Group Header
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to show items count in group header of ##Platform_Name## ListView

The ListView control supports wrapping list items into a group based on the category. The category of each list item can be mapped with groupBy field of the data source. You can display grouped list items count in the list-header using the group header template. Refer to the following code sample to display grouped list item count.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/count/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/count/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ListView - Item count in Group Header](../images/item-count.png)