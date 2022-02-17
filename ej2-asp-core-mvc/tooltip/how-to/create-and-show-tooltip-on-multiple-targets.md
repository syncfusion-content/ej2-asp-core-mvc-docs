---
layout: post
title: Create And Show Tooltip On Multiple Targets in ##Platform_Name## Tooltip Component
description: Learn here all about Create And Show Tooltip On Multiple Targets in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Create And Show Tooltip On Multiple Targets
publishingplatform: ##Platform_Name##
documentation: ug
---

# Create and show Tooltip on multiple targets

Tooltip can be created and shown on multiple targets within a container by defining the specific target elements to the target property. So, the tooltip is initialized only on matched targets within a container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/multi-target/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-target.cs" %}
{% include code-snippet/tooltip/multi-target/multi-target.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/multi-target/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi-target.cs" %}
{% include code-snippet/tooltip/multi-target/multi-target.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

