---
layout: post
title: Customize Button Size in ASP.NET Core Button Component
description: Learn here all about how to customize Button Size in Syncfusion ASP.NET Core Button Component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Button Size
publishingplatform: ASP.NET Core
documentation: ug
---


# Customize Button Size

Button size can be customized by setting `height` and `width` for the button element.

In the following sample, the height and width of the large button is customized as `50px` and `120px` and the height and width of the small button is customized as `30px` and `25px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/custom-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customsize.cs" %}
{% include code-snippet/button/howto/custom-size/customsize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/custom-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customsize.cs" %}
{% include code-snippet/button/howto/custom-size/customsize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

