---
layout: post
title: Pyramid in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Pyramid in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Pyramid
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pyramid Chart

To render a pyramid series, use the series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Type)
as `Pyramid`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Mode

The Pyramid chart supports linear and surface modes of rendering. The default type of the
`pyramidMode` is `linear`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mode.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/mode/mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mode.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/mode/mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size

The size of the pyramid chart can be customized by using the  `width` and `height` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gap Between the Segments

Pyramid chart provides options to customize the space between the segments by using the `gapRatio` property of the
series. It ranges from 0 to 1.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/gap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gap.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/gap/gap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/gap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gap.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/gap/gap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Explode

Points can be exploded on mouse click by setting the `explode` property to true. You can also explode the point
on load using `explodeIndex`. Explode distance can be set by using `explodeOffset` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/explode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Explode.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/explode/explode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/explode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Explode.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/explode/explode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Individual points can be customized using the `pointRender` event.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pyramid/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/pyramid/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data label](./data-label/)
* [Grouping](./grouping/)