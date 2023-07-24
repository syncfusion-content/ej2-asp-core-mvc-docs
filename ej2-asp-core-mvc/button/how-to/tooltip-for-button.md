---
layout: post
title: Tooltip For Button in ##Platform_Name## Button Control | Syncfusion
description: Learn here all about Tooltip for Button in Syncfusion ##Platform_Name## Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip For Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip for Button Control

Tooltip can be shown on Button hover and it can be achieved by setting `title` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/button/howto/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Button with Tooltip](../images/button-tooltip.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Button/ButtonHowToSample).