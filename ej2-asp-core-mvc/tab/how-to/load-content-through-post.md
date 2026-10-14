---
layout: post
title: How to load content through post in ##Platform_Name## Tabs | Syncfusion
description: Load external content into Syncfusion ##Platform_Name## Tabs through the AJAX library by importing the Ajax module and initializing with a URL path.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to load content through post in ##Platform_Name## Tabs

The Tabs control supports loading external content using the Ajax library. Refer to the following steps.

* Import the Ajax module from ej2-base and initialize with URL path.

* Retrieve the response from the Ajax `success` event and use it to initialize the Tab.

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


