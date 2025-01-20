---
layout: post
title: Integrate Avatar Into Badge in ##Platform_Name## Avatar control
description: Learn here all about how to integrate Avatar into Badge in Syncfusion ##Platform_Name## Avatar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integrate Avatar Into Badge
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate Avatar into Badge

The Badge is a dependent and supportive control that can be used with Avatar to create a notification Avatar. The default Avatar `(.e-avatar)` and circle Avatar `(.e-avatar-circle)` have been used with notification badges `(.e-badge-notification)` in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/badge/tagHelper %}
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

![Avatar Sample](../images/badge.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Avatar/AvatarUGSample).