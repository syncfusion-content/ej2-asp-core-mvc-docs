---
layout: post
title: Customization in ##Platform_Name## Tooltip Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

The Tooltip can be customized by using the `cssClass` property, which accepts custom CSS class names that define specific user-defined
 styles and themes to be applied on the Tooltip element.

## Tip pointer customization

Styling the tip pointer's size, background, and border color's can be done using the `cssClass` property, as given below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-pointer.cs" %}
{% include code-snippet/tooltip/tooltip-pointer/tooltip-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-pointer.cs" %}
{% include code-snippet/tooltip/tooltip-pointer/tooltip-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Tip Pointer Customization](./images/tip-pointer-customization.png)

## Tooltip customization

The complete look and feel of the Tooltip can be customized by changing it's background color, opacity, content font, etc.
 The following code example shows the way to achieve it.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-view.cs" %}
{% include code-snippet/tooltip/tooltip-view/tooltip-view.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-view.cs" %}
{% include code-snippet/tooltip/tooltip-view/tooltip-view.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Customization](./images/tooltip-customization.png)
