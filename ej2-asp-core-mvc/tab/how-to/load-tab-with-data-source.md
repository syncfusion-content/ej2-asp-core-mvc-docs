---
layout: post
title: Load Tab With Data Source in ##Platform_Name## Tab Component
description: Learn here all about Load Tab With Data Source in Syncfusion ##Platform_Name## Tab component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load Tab With Data Source
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load tab with DataSource

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


