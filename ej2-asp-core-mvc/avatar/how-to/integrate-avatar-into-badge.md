---
layout: post
title: Integrate Avatar Into Badge in ##Platform_Name## Avatar Component
description: Learn here all about Integrate Avatar Into Badge in Syncfusion ##Platform_Name## Avatar component and more.
platform: ej2-asp-core-mvc
control: Integrate Avatar Into Badge
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate avatar into Badge

The badge is dependent and supportive component, and it can be used with avatar to create a notification avatar.
The default avatar (.`e-avatar`) and circle avatar (.`e-avatar-circle`) have been used with notification badges (.`e-badge-notification`) in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/badge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/badge/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/badge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/badge/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Avatar Sample](../images/badge.png)