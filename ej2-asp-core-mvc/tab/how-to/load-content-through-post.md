---
layout: post
title: Load Content Through Post in ##Platform_Name## Tab Component
description: Learn here all about Load Content Through Post in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Load Content Through Post
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load content through Ajax

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


