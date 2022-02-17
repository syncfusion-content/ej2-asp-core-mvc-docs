---
layout: post
title: Funnel in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Funnel in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Funnel
publishingplatform: ##Platform_Name##
documentation: ug
---


# Funnel Chart

To render a funnel series, use the series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Type)
as `Funnel`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size

The size of the funnel chart can be customized by using the  `Width` and `Height` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Neck Size

The funnel's neck size can be customized by using the `NeckWidth` and `NeckHeight` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/neck-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Neck-size.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/neck-size/neck-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/neck-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Neck-size.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/neck-size/neck-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gap Between the Segments

Funnel chart provides options to customize the space between the segments by using the `GapRatio` property of the
series. It ranges from 0 to 1.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/gap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gap.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/gap/gap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/gap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gap.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/gap/gap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Explode

Points can be exploded on mouse click by setting the `Explode` property to true. You can also explode the point
on load using `ExplodeIndex`. Explode distance can be set by using `ExplodeOffset` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/explode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Explode.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/explode/explode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/explode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Explode.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/explode/explode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Smart Data Label

It provides the data label smart arrangement of the funnel and pyramid series. The overlap data label will be placed on left side of the funnel/pyramid series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/data-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/data-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data-label.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/data-label/data-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Individual points can be customized using the `PointRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/funnel/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/funnel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data label](./data-label/)
* [Grouping](./grouping/)
