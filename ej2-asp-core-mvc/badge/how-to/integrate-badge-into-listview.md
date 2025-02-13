---
layout: post
title: Integrate Badge Into ListView in ##Platform_Name## Badge control | Syncfusion
description: Learn here all about how to integrate Badge into ListView in Syncfusion ##Platform_Name## Badge control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integrate Badge Into ListView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate Badge into ListView

The Badges can be integrated with the `ListView` control to indicate new notification with color based on priority.

In the following sample, `default` Badges are used and there is no need to customize the Badge size. The control will automatically adjust the size based on the container element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/listview/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/listview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/listview/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Sample](../images/listview.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Badge/BadgeCustomSample).