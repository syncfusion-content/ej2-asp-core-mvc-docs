---
layout: post
title: Custom Context in ##Platform_Name## Sidebar Component
description: Learn here all about Custom Context in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Custom Context
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context

By default, Sidebar initializes context to the body element. Using the [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~Target.html) property, set context element to initialize Sidebar inside any HTML element apart from the body element.

> If required , `zIndex` can be set when sidebar act as overlay type.

In the following sample, click the toggle button to expand or collapse the sidebar and add button in sidebar element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/custom-context/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Context.cs" %}
{% include code-snippet/sidebar/custom-context/context.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/custom-context/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Context.cs" %}
{% include code-snippet/sidebar/custom-context/context.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](./images/target.png)

## See Also

* [How to add layout sidebar](./how-to/layout-page-sidebar)
* [How to add partial view sidebar](./how-to/sidebar-with-partial-view)
* [Hide sidebar](./how-to/hide-sidebar)
