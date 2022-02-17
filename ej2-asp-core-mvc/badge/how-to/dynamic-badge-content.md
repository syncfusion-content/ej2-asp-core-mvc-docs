---
layout: post
title: Dynamic Badge Content in ##Platform_Name## Badge Component
description: Learn here all about Dynamic Badge Content in Syncfusion ##Platform_Name## Badge component and more.
platform: ej2-asp-core-mvc
control: Dynamic Badge Content
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dynamic Badge Content

Badges in real-time needs to be updated dynamically based on the requirements. The following sample demonstrates how to
update the badges content dynamically. Click the increment button to change the badge value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/dynamic-badge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/dynamic-badge/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/dynamic-badge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/dynamic-badge/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Badge Sample](../images/badgecount.PNG)
