---
layout: post
title: Render The Tab Using Content Template in ##Platform_Name## Tab Component
description: Learn here all about Render The Tab Using Content Template in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Render The Tab Using Content Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render the Tab items using content template

You can bind any data in Tab items, by simply using the content template property in ASP.NET Tab.

In the below demo, the tab items are given as [chart](../../chart), [grid](../../grid), [calender](../../calendar) using the content template. In the content template you can give the header using `e-tab-header` and content using `e-content` class.

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
