---
layout: post
title: Integrate Badge Into Listview in ##Platform_Name## Badge Component
description: Learn here all about Integrate Badge Into Listview in Syncfusion ##Platform_Name## Badge component and more.
platform: ej2-asp-core-mvc
control: Integrate Badge Into Listview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate Badge into ListView

The badges can be integrated with the `listview` component to indicate new notification with colour based on priority.

In the following sample, `default` badges are used and there is no need to customize the badge size. The component
will automatically adjust the size based on the container element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/listview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/listview/HomeController.cs %}
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



Output be like the below.

![Badge Sample](../images/listview.PNG)