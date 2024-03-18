---
layout: post
title: Pie dough nut in ##Platform_Name## Circular Chart 3D Component | Syncfusion
description: Learn here all about Pie dough nut in Syncfusion ##Platform_Name## Circular Chart 3D component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pie dough nut
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pie dough nut in ##Platform_Name## Circular Chart 3D Component

## Pie chart

To render a pie series, use the series `Type` as `Pie`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/pie/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pie.cs" %}
{% include code-snippet/circular-chart/pie-donut/pie/pie.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/pie/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pie.cs" %}
{% include code-snippet/circular-chart/pie-donut/pie/pie.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Radius customization

By default, radius of the pie series will be 80% of the size (minimum of circular chart width and height). You can customize this using `Radius` property of the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/circular-chart/pie-donut/radius/radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/circular-chart/pie-donut/radius/radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Various radius pie chart

You can use radius mapping to render the slice with different `Radius` pie and also use `Border`, fill properties to customize the point. dataLabel is used to represent individual data and its value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/various-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Various-radius.cs" %}
{% include code-snippet/circular-chart/pie-donut/various-radius/various-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/various-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Various-radius.cs" %}
{% include code-snippet/circular-chart/pie-donut/various-radius/various-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Doughnut chart

To achieve a doughnut in pie series, customize the `InnerRadius` property of the series. By setting value greater than 0%, a doughnut will appear. The `InnerRadius` property takes value from 0% to 100% of the pie radius.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/donut/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Donut.cs" %}
{% include code-snippet/circular-chart/pie-donut/donut/donut.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/donut/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Donut.cs" %}
{% include code-snippet/circular-chart/pie-donut/donut/donut.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Color & text mapping

The fill color and the text in the data source can be mapped to the chart using `PointColorMapping` in series and `Name` in datalabel respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color.cs" %}
{% include code-snippet/circular-chart/pie-donut/color/color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color.cs" %}
{% include code-snippet/circular-chart/pie-donut/color/color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Individual points can be customized using the `PointRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/circular-chart/pie-donut/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/pie-donut/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/circular-chart/pie-donut/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


