---
layout: post
title: Multiple Sidebars in ##Platform_Name## Sidebar | Syncfusion
description: Learn how to render and manage multiple Sidebars in Syncfusion ##Platform_Name## Sidebar using a shared main content area.
platform: ej2-asp-core-mvc
control: Multiple Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Multiple Sidebars in ##Platform_Name## Sidebar

Two Sidebars can be initialized in a web page with same main content. Sidebars can be initialized on right side or left side of the main content using [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Position) property.

N>The HTML element with class name `e-main-content` will be considered as the main content and both the Sidebars will behave as side content to this main content area of a web page.

In the following sample, more than one sidebar is rendered based on [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Sidebar.html#Syncfusion_EJ2_Navigations_Sidebar_Position) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/sidebar/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/sidebar/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/multiple.png)