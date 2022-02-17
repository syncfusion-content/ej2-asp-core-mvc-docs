---
layout: post
title: Auto Close in ##Platform_Name## Sidebar Component
description: Learn here all about Auto Close in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Auto Close
publishingplatform: ##Platform_Name##
documentation: ug
---


# Auto-close

Sidebar often behaves differently on a mobile versus a desktop display. It has an effective feature that offers to set it in opened or closed state corresponding to the specified resolution. This is achieved through [`mediaQuery`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~mediaQuery.html) property that allows you to set the Sidebar in an expanded state or collapsed state only in user-defined resolution.

In the following sample, mediaQuery has been used for specific resolution to close and open sidebar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/autoclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autoclose.cs" %}
{% include code-snippet/sidebar/autoclose/autoclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/autoclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autoclose.cs" %}
{% include code-snippet/sidebar/autoclose/autoclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](./images/autoclose.png)

* In this sample,the Sidebar will be in an expanded state only in resolution below `400px` using [`mediaQuery`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~mediaQuery.html) for max-width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/autoclose/max-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autoclose.cs" %}
{% include code-snippet/sidebar/autoclose/max-width/autoclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/autoclose/max-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autoclose.cs" %}
{% include code-snippet/sidebar/autoclose/max-width/autoclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](./images/auto_close.png)