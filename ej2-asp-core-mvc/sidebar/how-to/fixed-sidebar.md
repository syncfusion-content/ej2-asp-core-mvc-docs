---
layout: post
title: Fixed Sidebar in ##Platform_Name## Sidebar Component
description: Learn here all about Fixed Sidebar in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Fixed Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sidebar with fixed position

The Sidebar does not require any specific style to make it as a fixed one. By default, the Sidebar position will be in fixed state. The following example demonstrates that the Sidebar is rendered with a fixed position. The position of the Sidebar will not change when scrolling the main content area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/fixed-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed_position.cs" %}
{% include code-snippet/sidebar/fixed-position/fixed_position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/fixed-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed_position.cs" %}
{% include code-snippet/sidebar/fixed-position/fixed_position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/fixed_position.png)
