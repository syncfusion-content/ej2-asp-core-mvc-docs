---
layout: post
title: Custom Context in ##Platform_Name## Sidebar Control | Syncfusion
description: Learn here all about Custom Context in Syncfusion ##Platform_Name## Sidebar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Context
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context

By default, Sidebar initializes context to the body element. Using the [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~Target.html) property, set context element to initialize Sidebar inside any HTML element apart from the body element.

N> If required , `zIndex` can be set when Sidebar act as overlay type.

In the following sample, click the toggle button to expand or collapse the Sidebar and add button in Sidebar element.

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

* [How to add layout Sidebar](./how-to/layout-page-sidebar)
* [How to add partial view Sidebar](./how-to/sidebar-with-partial-view)
* [Hide Sidebar](./how-to/hide-sidebar)
