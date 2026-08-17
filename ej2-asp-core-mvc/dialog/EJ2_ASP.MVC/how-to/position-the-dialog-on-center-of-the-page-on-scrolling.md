---
layout: post
title: How to position Dialog on page scroll in ASP.NET MVC Dialog | Syncfusion
description: Keep the Syncfusion ASP.NET MVC Dialog centered on the page while scrolling by adding the e-fixed class to the Dialog element to prevent page scroll.
platform: ej2-asp-core-mvc
control: Position The Dialog On Center Of The Page On Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to position Dialog on page scroll in ASP.NET MVC Dialog

By default, when scroll the page/container Dialog also scrolled along with the page/container. When a user expects to display the Dialog in the same position without scrolling achieving this in sample level as like below. Here added 'e-fixed' class to Dialog element and prevent the scrolling.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/scrolling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/scrolling/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/scrolling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/scrolling/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

