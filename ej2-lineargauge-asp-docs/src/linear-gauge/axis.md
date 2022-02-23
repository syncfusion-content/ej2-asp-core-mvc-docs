# Axes

Axes is a collection of linear axis which can be used to indicate the numeric values. Line, ticks, labels, ranges and pointers are the sub elements of an axis.

## Line Customization

The [`line`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine.html) property of an axis provides options to customize the [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~Height.html), [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~Width.html), [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~Color.html) and [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLine~offset.html) of the axis line.

{% aspTab template="lineargauge/axes/line-customization", sourceFiles="line-customization.cs" %}

{% endaspTab %}

## Ticks Customization

You can customize the [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick~Height.html), [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick~Color.html) and [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick~Width.html) of major and minor ticks, by using [`majorTicks`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick.html) and [`minorTicks`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTick.html)) property. By default, interval for major ticks will be calculated automatically and also you can customize the interval for major and minor ticks using interval property.

<!-- markdownlint-disable MD036 -->

{% aspTab template="lineargauge/axes/ticks-customization", sourceFiles="ticks-customization.cs" %}

{% endaspTab %}

## Labels Customization

The [`labelStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~LabelStyle.html) property of an axis provides options to
customize the [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Offset.html), [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Format.html), [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Color.html) and [`font`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Font.html) of the axis labels.

<!-- markdownlint-disable MD036 -->

{% aspTab template="lineargauge/axes/labels-customization", sourceFiles="labels-customization.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**Label Format**

Axis labels can be formatted by using the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel~Format.html) property in [`labelStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeLabel.html) and it supports all the globalize formats.

{% aspTab template="lineargauge/axes/label-format", sourceFiles="label-format.cs" %}

{% endaspTab %}

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

{% aspTab template="lineargauge/axes/custom-label", sourceFiles="custom-label.cs" %}

{% endaspTab %}

## Inverted Axes

[`isInversed`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAxis~IsInversed.html) property is used to choose the rendering of axis either bottom to top or top to bottom direction.

{% aspTab template="lineargauge/axes/inverted-axes", sourceFiles="inverted-axes.cs" %}

{% endaspTab %}

## Opposed Axes

To place an axis opposite from its original position, set [`opposedPosition`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAxis~OpposedPosition.html) property as true in the axis.

{% aspTab template="lineargauge/axes/opposed-axes", sourceFiles="opposed-axes.cs" %}

{% endaspTab %}

## Multiple Axes

You can render any number of axis for a linear gauge by using array of axis objects.
Each axis will have its own ranges, pointers, annotations and customization options.

{% aspTab template="lineargauge/axes/multiple-axes", sourceFiles="multiple-axes.cs" %}

{% endaspTab %}
