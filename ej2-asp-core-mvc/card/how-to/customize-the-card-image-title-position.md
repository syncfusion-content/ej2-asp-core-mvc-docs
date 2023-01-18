---
layout: post
title: Customize The Card Image Title Position in ##Platform_Name## Card Control | Syncfusion
description: Learn here all about how to customize the Card Image title position in Syncfusion ##Platform_Name## Card control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize The Card Image Title Position
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the card image title position

Card Image titles are placed as always at Bottom-Left Corner only, you can manually customize to place titles anywhere over the image by adding styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card-img-title-pos/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card-img-title-pos/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-img-title-pos/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Card/CardUGSample).