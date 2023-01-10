---
layout: post
title: Input And Anchor Elements in ##Platform_Name## Button | Syncfusion
description: Learn here all about how to customize Input And Anchor Elements in Syncfusion ##Platform_Name## Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Input And Anchor Elements
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize input and anchor elements

You can customize the appearance of the input and anchor elements using predefined styles through the class property. In the following code snippet, the input element is customized as a link Button by setting the `e-btn e-link` class, and the anchor element is customized as a primary Button by setting the `e-btn e-primary` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/custom-element/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-element.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/custom-element/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-element.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Button/ButtonHowToSample).