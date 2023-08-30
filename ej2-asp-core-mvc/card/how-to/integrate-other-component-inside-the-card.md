---
layout: post
title: Integrate Other Control in ##Platform_Name## Card Control | Syncfusion
description: Learn here all about how to integrate other component inside the card in Syncfusion ##Platform_Name## Card control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integrate Other Component Inside The Card
publishingplatform: ##Platform_Name##
documentation: ug
---


# Integrate other component inside the card

You can integrate any component inside the card element. Here, ListView component is placed inside the card for showcasing the To-Do list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/card/card-with-list/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/card/card-with-list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/card/card-with-list/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Alt text](./../images/card-other.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Card/CardUGSample).