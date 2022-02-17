---
layout: post
title: Gauge Axes in ##Platform_Name## Circular Gauge Component
description: Learn here all about Gauge Axes in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Gauge Axes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Axes

By default, gauge will be displayed with an axis. Each axis contains its own ranges, pointers and annotation.

<!-- markdownlint-disable MD036 -->

## Axis Customization

You can customize the width and color of an axis line by using [`lineStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_LineStyle) property.
Background for an axis can be customized by using [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Background)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/axes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axes.cs" %}
{% include code-snippet/circulargauge/gauge-axes/axes/axes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/axes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axes.cs" %}
{% include code-snippet/circulargauge/gauge-axes/axes/axes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Angles and Direction

Circular gauge axis can sweep from 0 to 360 degrees. By default start angle of an axis is 200 degree and
end angle is 160 degree and you can customize this option by using
[`startAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_StartAngle) and [`endAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_EndAngle)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/angles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Angles.cs" %}
{% include code-snippet/circulargauge/gauge-axes/angles/angles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/angles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Angles.cs" %}
{% include code-snippet/circulargauge/gauge-axes/angles/angles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`direction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Direction) property enables you to render the gauge axis either in
`ClockWise` or in `AntiClockWise` direction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/direction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/circulargauge/gauge-axes/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/circulargauge/gauge-axes/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Axis Radius

By default, radius of an axis is calculated based on the available size. You can customize this, by using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Radius) property. It takes value either in `percentage` or in `pixel`.

**In Pixel**

You can set the radius of the gauge in pixel as demonstrated below,

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/radius-pixel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radius-pixel.cs" %}
{% include code-snippet/circulargauge/gauge-axes/radius-pixel/radius-pixel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/radius-pixel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius-pixel.cs" %}
{% include code-snippet/circulargauge/gauge-axes/radius-pixel/radius-pixel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**In Percentage**

By setting value in percentage, gauge gets its dimension with respect to its available size. For example, when the radius is ‘50%’, gauge renders to half of the available size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/radius-percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radius-percentage.cs" %}
{% include code-snippet/circulargauge/gauge-axes/radius-percentage/radius-percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/radius-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius-percentage.cs" %}
{% include code-snippet/circulargauge/gauge-axes/radius-percentage/radius-percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Ticks

You can customize the [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html),
[`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTick_Color) and
[`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTick_Width) of major and minor ticks by
using [`majorTicks`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_MajorTicks)
and [`minorTicks`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_MinorTicks) property.
By default, [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTick_Interval) for
`majorTicks` will be calculated automatically
and also you can customize the interval for major and minor ticks using
`interval` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/ticks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks.cs" %}
{% include code-snippet/circulargauge/gauge-axes/ticks/ticks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/ticks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks.cs" %}
{% include code-snippet/circulargauge/gauge-axes/ticks/ticks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Tick Position**

Both minor and major ticks can be moved by using [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html) and [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html) property. The [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTick_Offset) defines the distance between the axis and ticks.
By default, offset value is 0. The [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTick_Position) will place the ticks either inside or outside of the axis.
By default, ticks will be placed `inside` the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/tick-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tick-position.cs" %}
{% include code-snippet/circulargauge/gauge-axes/tick-position/tick-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/tick-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tick-position.cs" %}
{% include code-snippet/circulargauge/gauge-axes/tick-position/tick-position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Labels

Labels of an axis can be customized by using [`font`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeFont.html#Syncfusion_EJ2_CircularGauge_CircularGaugeFont_FontFamily) property in [`labelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_LabelStyle) options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Labels.cs" %}
{% include code-snippet/circulargauge/gauge-axes/labels/labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Labels.cs" %}
{% include code-snippet/circulargauge/gauge-axes/labels/labels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Label Position**

Labels can be moved by using [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Offset) or
[`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Position) property.
The [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Offset) defines the distance between the labels and ticks.
By default, offset value is 0.
The [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Position) will place the labels either inside or outside of the axis.
By default, labels will be placed `inside` the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/label-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-position.cs" %}
{% include code-snippet/circulargauge/gauge-axes/label-position/label-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/label-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-position.cs" %}
{% include code-snippet/circulargauge/gauge-axes/label-position/label-position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Auto Angle**

Labels can be swept along the axis angle by enabling [`autoAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_AutoAngle) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/auto-angles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-angles.cs" %}
{% include code-snippet/circulargauge/gauge-axes/auto-angles/auto-angles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/auto-angles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-angles.cs" %}
{% include code-snippet/circulargauge/gauge-axes/auto-angles/auto-angles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Smart Labels**

When an axis makes a complete circle, then the first and last label of the axis will get overlap with each other.
In this scenario, you can either hide 1st or last label using [`hiddenLabel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_HiddenLabel) property.
When `hiddenLabel` value is `First`,
then the 1st label will be hidden and when the
`hiddenLabel` value is 'Last',
then the last label will be hidden.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/smart-labels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Smart-labels.cs" %}
{% include code-snippet/circulargauge/gauge-axes/smart-labels/smart-labels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/smart-labels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Smart-labels.cs" %}
{% include code-snippet/circulargauge/gauge-axes/smart-labels/smart-labels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Label Format**

Axis labels can be formatted by using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Format) property in [`labelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html#Syncfusion_EJ2_CircularGauge_CircularGaugeLabel_Font) and its supports all globalize format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/circulargauge/gauge-axes/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/circulargauge/gauge-axes/label-format/label-format.cs %}
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

**Custom Label Format**

Axis labels support custom label format using placeholder like {value}°C, in which the value represent the axis label e.g 20°C.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/custom-label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-label-format.cs" %}
{% include code-snippet/circulargauge/gauge-axes/custom-label-format/custom-label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/custom-label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-label-format.cs" %}
{% include code-snippet/circulargauge/gauge-axes/custom-label-format/custom-label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Hide Intersecting Axis Labels**

When the axis labels overlap with each other, you can hide the intersected labels by setting the `hideIntersectingLabel` property to true in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/hide-intersecting-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-intersecting-label.cs" %}
{% include code-snippet/circulargauge/gauge-axes/hide-intersecting-label/hide-intersecting-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/hide-intersecting-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-intersecting-label.cs" %}
{% include code-snippet/circulargauge/gauge-axes/hide-intersecting-label/hide-intersecting-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Minimum and Maximum

The [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Minimum) and [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAxis.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAxis_Maximum) properties
enables you to customize the start and end values of an axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/minMax/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MinMax.cs" %}
{% include code-snippet/circulargauge/gauge-axes/minMax/minMax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/minMax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MinMax.cs" %}
{% include code-snippet/circulargauge/gauge-axes/minMax/minMax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Axes

In addition to the default axis, you can add n number of axis to a gauge.
Each axis will have its own ranges, pointers, annotations and customization options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/multiple-axes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-axes.cs" %}
{% include code-snippet/circulargauge/gauge-axes/multiple-axes/multiple-axes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-axes/multiple-axes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-axes.cs" %}
{% include code-snippet/circulargauge/gauge-axes/multiple-axes/multiple-axes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


