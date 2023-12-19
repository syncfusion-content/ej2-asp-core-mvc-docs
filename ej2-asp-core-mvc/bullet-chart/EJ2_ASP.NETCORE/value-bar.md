---
layout: post
title: Value Bar in ##Platform_Name## Bullet Chart Component
description: Learn here all about Value Bar in Syncfusion ##Platform_Name## Bullet Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Value Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Actual bar

To display the primary data or the current value of the data being measured known as the **Feature Measure** that should be encoded as a bar. This is called as the **Actual Bar** or the **Feature Bar** in the Bullet Chart, and to display the actual bar the [`ValueField`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_ValueField) should be mapped to the appropriate field from the data source.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/value-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value-bar.cs" %}
{% include code-snippet/bullet-chart/value-bar/value-bar/value-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/value-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value-bar.cs" %}
{% include code-snippet/bullet-chart/value-bar/value-bar/value-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Actual Bar in Bullet Chart](images/blazor-bullet-chart-actual-bar.png)

## Types of actual bar

The shape of the actual bar can be customized using the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_Type) property of the Bullet Chart. The actual bar contains `Rect` and `Dot` shapes. By default, the actual bar shape is Rect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/types/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Types.cs" %}
{% include code-snippet/bullet-chart/value-bar/types/types.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/types/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Types.cs" %}
{% include code-snippet/bullet-chart/value-bar/types/types.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Dot Actual Bar](images/blazor-bullet-chart-dot-actual-bar.png)

## Actual bar customization

### Border customization

Using the [`ValueBorder`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_ValueBorder) property of the bullet chart, you can customize the border [`Color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBorder.html#Syncfusion_EJ2_Charts_BulletChartBorder_Color) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBorder.html#Syncfusion_EJ2_Charts_BulletChartBorder_Width) of the actual bar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/value-border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value-border.cs" %}
{% include code-snippet/bullet-chart/value-bar/value-border/value-border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/value-border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value-border.cs" %}
{% include code-snippet/bullet-chart/value-bar/value-border/value-border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Fill color and height customization

Customize the fill color and height of the actual bar using the [`ValueFill`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_ValueFill) and [`ValueHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_ValueHeight) properties of the bullet chart. Also, you can bind the color for the actual bar from [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_DataSource) for the bullet chart using [`ValueFill`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.charts.bulletchart.html#Syncfusion_EJ2_Charts_BulletChart_ValueFill) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/value-fill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value-fill.cs" %}
{% include code-snippet/bullet-chart/value-bar/value-fill/value-fill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/value-bar/value-fill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value-fill.cs" %}
{% include code-snippet/bullet-chart/value-bar/value-fill/value-fill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customizing Actual Bar in Bullet Chart](images/blazor-bullet-chart-actual-bar-customization.png)