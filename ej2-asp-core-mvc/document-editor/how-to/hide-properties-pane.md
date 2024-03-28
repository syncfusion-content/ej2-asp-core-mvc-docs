---
layout: post
title: Hide properties pane in ##Platform_Name## Document Editor Component
description: Learn how to hide the properties pane from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Hide Properties Pane
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to hide properties pane in Document Editor component

The following example code illustrates how to hide the properties pane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-properties-pane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="hide-properties-pane.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-properties-pane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="hide-properties-pane.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> Positioning and customizing the properties pane in Document editor container is not possible. Instead, you can hide the exiting properties pane and create your own pane using public API's.