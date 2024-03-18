---
layout: post
title: Pie and Donut in ##Platform_Name## 3D Circular Chart Component | Syncfusion
description: Learn here all about Pie and Donut in Syncfusion ##Platform_Name## 3D Circular Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pie and Donut
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pie and Donut in ##Platform_Name## 3D Circular Chart Component

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

By default, the radius of the pie series will be 80% of the size, which is the minimum of the 3D Circular Chart's width and height. You can customize this by using the `Radius` property of the series.

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

You can assign different radii to each slice of the pie by fetching the radius from the data source and using it with the `Radius` property in the `Series`.

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



## Donut chart

To achieve a donut in the pie series, customize the `InnerRadius` property of the series. By setting a value greater than 0%, a donut will appear. The `InnerRadius` property takes value from 0% to 100% of the pie radius.

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



## Text and fill color mapping

The text and the fill color from the data source can be mapped to the 3D Circular Chart using `PointColorMapping` in the series and `Name` in the data label, respectively.

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

Individual points in pie chart can be customized using the `PointRender` event.

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


