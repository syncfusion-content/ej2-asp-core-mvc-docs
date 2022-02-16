---
layout: post
title: Sidebar With Variation Animation in ##Platform_Name## Sidebar Component
description: Learn here all about Sidebar With Variation Animation in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Sidebar With Variation Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom animation effects with sidebar

In the following example, the sidebar is rendered with custom animation effects. Click the buttons available in the main content area to check how the custom animations works with sidebar.

Sidebar will automatically adjust expanding animation to match any custom size specified in CSS styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/sidebar/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/sidebar/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below without animation.

![Sidebar Sample](../images/before_animation.png)

Output be like the below, after applying animation to the Sidebar element.

![Sidebar Sample](../images/after_animation.png)