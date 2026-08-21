---
layout: post
title: How to load content through post in ##Platform_Name## Tabs | Syncfusion
description: Load external content into Syncfusion ##Platform_Name## Tabs through the AJAX library by importing the Ajax module and initializing with a URL path.
platform: ej2-asp-core-mvc
control: Load Content Through Post
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to load content through post in ##Platform_Name## Tabs

The Tab supports to load external contents through AJAX library. Refer to the following steps.

* Import the Ajax module from ej2-base and initialize with URL path.

* Get the data from Ajax Success event, then initialize the Tab with retrieved external path data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/ajax/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/tab/ajax/ajax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/ajax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/tab/ajax/ajax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


