---
layout: post
title: Ranges in ##Platform_Name## Bullet Chart Component | Syncfusion
description: Learn here all about Ranges in Syncfusion ##Platform_Name## Bullet Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ranges
publishingplatform: ##Platform_Name##
documentation: ug
---


# Ranges in Bullet Chart Control

Ranges represent the quality of a specific range such as **Good**, **Bad** and **Satisfactory** in the Bullet Chart scale. The ending point of a qualitative range is specified in the [`End`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Range.html#Syncfusion_EJ2_Charts_Range_End) property in [`Ranges`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Ranges). The [`Minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Minimum) value of a quantitative scale is considered the starting point of the first range or the previous range end point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class Range
{           
    public double value;
    public double target;
    public string category;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges.cs" %}
{% include code-snippet/bullet-chart/ranges/ranges/ranges.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Ranges in Bullet Chart](images/blazor-bullet-chart-range.png)

## Color customization

Enhance the readability of ranges with color and opacity. It can be applied using the [`Color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Range.html#Syncfusion_EJ2_Charts_Range_Color) and [`Opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Range.html#Syncfusion_EJ2_Charts_Range_Opacity) properties in [`Ranges`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Ranges).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class Custom
{           
    public double value;
    public double target;
    public string category;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ranges-custom.cs" %}
{% include code-snippet/bullet-chart/ranges/ranges-custom/ranges-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customizing Ranges with Color in Bullet Chart](images/blazor-bullet-chart-range-customization.png)