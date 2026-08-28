---
layout: post
title: Summary View in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to enable and use Summary View in ##Platform_Name## Query Builder to display the generated query in a summarized format.
platform: ej2-asp-core-mvc
control: Summary View
publishingplatform: ##Platform_Name##
documentation: ug
---

# Summary View in ##Platform_Name## Query Builder

Summary View allows you to show or hide the filtered query. By default, the value is `false`. You can enable it by setting the [`SummaryView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_SummaryView) property to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/query-builder/how-to/enable-summary-view/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Query builder Sample](../images/summary-view.png)