---
layout: post
title: Customization in ##Platform_Name## Bullet Chart Component | Syncfusion
description: Learn here all about Customization in Syncfusion ##Platform_Name## Bullet Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization in Bullet Chart Control

## Orientation

The Bullet Chart can be rendered in different orientations such as **Horizontal** or **Vertical** via the [`Orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Orientation) property. By default, the Bullet Chart is rendered in the **Horizontal** orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class OrientationData
{           
    public double value;
    public double target;
}
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

The Bullet Chart supports the right-to-left rendering that can be enabled by setting the [`EnableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_EnableRtl) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/right-to-left/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class RightToLeftData
{           
    public double value;
    public double target;
}
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

The actual and the target bar supports the linear animation via the [`Animation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Animation) setting. The speed and the delay are controlled using the [`Duration`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartAnimation.html#Syncfusion_EJ2_Charts_BulletChartAnimation_Duration) and [`Delay`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartAnimation.html#Syncfusion_EJ2_Charts_BulletChartAnimation_Delay) properties respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class AnimationData
{           
    public double value;
    public double target;
}
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

The Bullet Chart supports different type of themes via the [`Theme`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Theme) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/customization/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class Themes
{           
    public double value;
    public double target;
}
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