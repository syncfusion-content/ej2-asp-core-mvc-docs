---
layout: post
title: Load Content Through Post in ##Platform_Name## Accordion Component
description: Learn here all about Load Content Through Post in Syncfusion ##Platform_Name## Accordion component and more.
platform: ej2-asp-core-mvc
control: Load Content Through Post
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load content through Ajax

Accordion supports to load external contents through `AJAX` library. Refer the below steps.

* Import the `Ajax` module from `ej2-base` and initialize with URL path.

* Get data from the Ajax Success event to initialize Accordion with retrieved external path data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/ajax/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/accordion/how-to/ajax/ajax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/how-to/ajax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ajax.cs" %}
{% include code-snippet/accordion/how-to/ajax/ajax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

