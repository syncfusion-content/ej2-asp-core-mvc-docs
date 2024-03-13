---
layout: post
title: Reverse in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Reverse in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Reverse
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reverse in ##Platform_Name## Timeline control

This section explains how to display Timeline items in reverse order, starting with the most recent events. This is achieved using the reverse property of the Timeline control.

By default, Timeline items are often ordered with the oldest events at the top (or left in horizontal orientation). Reversing the timeline allows users to view the most recent activity without needing to scroll through long lists.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}