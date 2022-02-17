---
layout: post
title: Customization in ##Platform_Name## Bullet Chart Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Bullet Chart component and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

## Orientation

The Bullet Chart can be rendered in different orientations such as **Horizontal** or **Vertical** via the `orientation` property. By default, the Bullet Chart is rendered in the **Horizontal** orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/bullet-chart/customization/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/orientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/bullet-chart/customization/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Orientation](images/blazor-bullet-chart-orientation.png)

## Right-to-left (RTL)

The Bullet Chart supports the right-to-left rendering that can be enabled by setting the `enableRtl` property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/right-to-left/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Right-to-left.cs" %}
{% include code-snippet/bullet-chart/customization/right-to-left/right-to-left.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/right-to-left/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Right-to-left.cs" %}
{% include code-snippet/bullet-chart/customization/right-to-left/right-to-left.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Right to Left Flow Direction in Bullet Chart](images/blazor-bullet-chart-right-to-left-direction.png)

## Animation

The actual and the target bar supports the linear animation via the `animation` setting. The speed and the delay are controlled using the `duration` and `delay` properties respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/bullet-chart/customization/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/bullet-chart/customization/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Theme

The Bullet Chart supports different type of themes via the `theme` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/bullet-chart/customization/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/bullet-chart/customization/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Applying Theme to Bullet Chart](images/blazor-bullet-chart-theme.png)