---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Button Size of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Button Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Button Size

Button size can be customized by setting `height` and `width` for the button element.

In the following sample, the height and width of the large button is customized as `50px` and `120px` and
the height and width of the small button is customized as `30px` and `25px`.

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

