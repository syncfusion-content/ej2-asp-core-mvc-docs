---
layout: post
title: Avatar Customization in ##Platform_Name## Avatar Component | Syncfusion
description: Learn here all about Avatar Customization in Syncfusion ##Platform_Name## Avatar component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Avatar Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Avatar Customization

## Color customization

The Avatar comes with default background color (Grey). This can be easily customized to the desired color by adding custom class or directly selecting the Avatar class from the CSS.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/color/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/color/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Avatar Color](../images/color.PNG)

## Customize Avatar sizes

Even though the Avatar comes with five predefined sizes, sometimes it's not enough. The Avatar is designed so that the width and height are relative to the font-size. By changing the `font-size` of the Avatar element, you can change the width and height automatically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/custom-size/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/custom-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/custom-size/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Avatar Size](../images/customization.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Avatar/AvatarUGSample).

## Use various media in Avatar

Avatars can be used with a wide variety of types of media formats like SVG, font-icons, images, letters, words, etc.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/media-formats/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/media-formats/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/media-formats/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Media Format](../images/media.PNG)
