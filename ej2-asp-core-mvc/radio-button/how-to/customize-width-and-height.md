---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Width And Height of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Width And Height
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize width and height

The following section explains about how to customize the height and width of the RadioButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/custom-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customheight.cs" %}
{% include code-snippet/radio-button/howto/custom-height/customheight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/custom-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customheight.cs" %}
{% include code-snippet/radio-button/howto/custom-height/customheight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

