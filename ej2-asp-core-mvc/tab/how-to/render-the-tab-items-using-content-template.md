---
layout: post
title: Render Tab Items Using Template in ##Platform_Name## Tabs | Syncfusion
description: Render Syncfusion ##Platform_Name## Tabs items from any data using the content template property with the `e-tab-header` and `e-content` classes.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to render Tab items using template in ##Platform_Name##

You can bind any data in Tab items, by simply using the content template property in ASP.NET Tab.

In the below demo, the Tab items are given as [chart](../../chart), [grid](../../grid), [calender](../../calendar) using the content template. In the content template you can give the header using `e-tab-header` and content using `e-content` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/contenttemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contenttemplate.cs" %}
{% include code-snippet/tab/contenttemplate/contenttemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/contenttemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contenttemplate.cs" %}
{% include code-snippet/tab/contenttemplate/contenttemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![content template](../images/contenttemplate.PNG)
