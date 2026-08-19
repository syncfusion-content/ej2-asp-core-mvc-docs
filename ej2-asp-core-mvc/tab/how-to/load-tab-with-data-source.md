---
layout: post
title: How to load tab with data source in ##Platform_Name## Tabs | Syncfusion
description: Bind Syncfusion ##Platform_Name## Tabs items from a remote data source by mapping the `header` and `content` fields using `DataManager` and OData service.
platform: ej2-asp-core-mvc
control: Load Tab With Data Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to load tab with data source in ##Platform_Name## Tabs

{% if page.publishingplatform == "aspnet-core" %}

You can bind any data object to Tab items, by mapping it to a [header](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabHeader.html) and [content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_Content)&nbsp; property.

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can bind any data object to Tab items, by mapping it to a [header](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabHeader.html) and [content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_Content)&nbsp; property.

{% endif %}

In the below demo, Data is fetched from an `OData` service using `DataManager`. The result data is formatted as a JSON object with `header` and `content` fields, which is set to items property of Tab.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/tab/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/tab/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


