---
layout: post
title: Axis in ##Platform_Name## Linear Gauge Component
description: Learn here all about Axis in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Axis
publishingplatform: ##Platform_Name##
documentation: ug
---

# Axes

Axes is a collection of linear axis which can be used to indicate the numeric values. Line, ticks, labels, ranges and pointers are the sub elements of an axis.

## Line Customization

The [`line`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine.html) property of an axis provides options to customize the [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~Height.html), [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~Width.html), [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~Color.html) and [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~offset.html) of the axis line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/line-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Line-customization.cs" %}
{% include code-snippet/lineargauge/axes/line-customization/line-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/line-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Line-customization.cs" %}
{% include code-snippet/lineargauge/axes/line-customization/line-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Ticks Customization

You can customize the [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick~Height.html), [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick~Color.html) and [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick~Width.html) of major and minor ticks, by using [`majorTicks`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick.html) and [`minorTicks`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick.html)) property. By default, interval for major ticks will be calculated automatically and also you can customize the interval for major and minor ticks using interval property.

<!-- markdownlint-disable MD036 -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/ticks-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks-customization.cs" %}
{% include code-snippet/lineargauge/axes/ticks-customization/ticks-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/ticks-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks-customization.cs" %}
{% include code-snippet/lineargauge/axes/ticks-customization/ticks-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Labels Customization

The [`labelStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~LabelStyle.html) property of an axis provides options to
customize the [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Offset.html), [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Format.html), [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Color.html) and [`font`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Font.html) of the axis labels.

<!-- markdownlint-disable MD036 -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/labels-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Labels-customization.cs" %}
{% include code-snippet/lineargauge/axes/labels-customization/labels-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/labels-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Labels-customization.cs" %}
{% include code-snippet/lineargauge/axes/labels-customization/labels-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

**Label Format**

Axis labels can be formatted by using the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Format.html) property in [`labelStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel.html) and it supports all the globalize formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/lineargauge/axes/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/lineargauge/axes/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following table describes the result of applying some commonly used label formats on numeric values.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Label Value</b></td>
<td><b>Label Format property value</b></td>
<td><b>Result </b></td>
<td><b>Description </b></td>
</tr>
<tr>
<td>1000</td>
<td>n1</td>
<td>1000.0</td>
<td>The Number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>n2</td>
<td>1000.00</td>
<td>The Number is rounded to 2 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>n3</td>
<td>1000.000</td>
<td>The Number is rounded to 3 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p1</td>
<td>1.0%</td>
<td>The Number is converted to percentage with 1 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p2</td>
<td>1.00%</td>
<td>The Number is converted to percentage with 2 decimal place</td>
</tr>
<tr>
<td>0.01</td>
<td>p3</td>
<td>1.000%</td>
<td>The Number is converted to percentage with 3 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c1</td>
<td>$1,000.0</td>
<td>The Currency symbol is appended to number and number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c2</td>
<td>$1,000.00</td>
<td>The Currency symbol is appended to number and number is rounded to 2 decimal place</td>
</tr>
</table>

<!-- markdownlint-disable MD036 -->

**Custom Label Format**

Axis also supports custom label format using placeholder like {value}°C, in which the value represents the axis label e.g. 20°C.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/custom-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-label.cs" %}
{% include code-snippet/lineargauge/axes/custom-label/custom-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/custom-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-label.cs" %}
{% include code-snippet/lineargauge/axes/custom-label/custom-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Inverted Axes

[`isInversed`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAxis~IsInversed.html) property is used to choose the rendering of axis either bottom to top or top to bottom direction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/inverted-axes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inverted-axes.cs" %}
{% include code-snippet/lineargauge/axes/inverted-axes/inverted-axes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/inverted-axes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inverted-axes.cs" %}
{% include code-snippet/lineargauge/axes/inverted-axes/inverted-axes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Opposed Axes

To place an axis opposite from its original position, set [`opposedPosition`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAxis~OpposedPosition.html) property as true in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/opposed-axes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed-axes.cs" %}
{% include code-snippet/lineargauge/axes/opposed-axes/opposed-axes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/opposed-axes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed-axes.cs" %}
{% include code-snippet/lineargauge/axes/opposed-axes/opposed-axes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Axes

You can render any number of axis for a linear gauge by using array of axis objects.
Each axis will have its own ranges, pointers, annotations and customization options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/multiple-axes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-axes.cs" %}
{% include code-snippet/lineargauge/axes/multiple-axes/multiple-axes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/axes/multiple-axes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-axes.cs" %}
{% include code-snippet/lineargauge/axes/multiple-axes/multiple-axes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


