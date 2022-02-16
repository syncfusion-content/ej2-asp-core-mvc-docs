---
layout: post
title: Setting Dimension in ##Platform_Name## Tooltip Component
description: Learn here all about Setting Dimension in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Setting Dimension
publishingplatform: ##Platform_Name##
documentation: ug
---


# Setting Dimension

## Height and width

The Tooltip can either be assigned auto height and width values or specific pixel values. The `width` and `height` properties are used to
 set the outer dimension of the Tooltip element. The default value for both the properties is `auto`.
  It also accepts string and number values in pixels.

The following sample explains how to set dimensions for the Tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/height-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Height-width.cs" %}
{% include code-snippet/tooltip/height-width/height-width.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/height-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Height-width.cs" %}
{% include code-snippet/tooltip/height-width/height-width.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Dimension](./images/tooltip-dimension.png)

### Scroll mode

When `height` is specified with a certain pixel value and the Tooltip content overflows, the scrolling mode gets enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/scroll-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scroll-mode.cs" %}
{% include code-snippet/tooltip/scroll-mode/scroll-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/scroll-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scroll-mode.cs" %}
{% include code-snippet/tooltip/scroll-mode/scroll-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Scroll Mode](./images/tooltip-scroll.png)

> The scrolling mode can best be seen when the sticky mode of the Tooltip is enabled. To enable sticky mode, set the `isSticky` property to true.
