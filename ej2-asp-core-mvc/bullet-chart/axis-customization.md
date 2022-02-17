---
layout: post
title: Axis Customization in ##Platform_Name## Bullet Chart Component
description: Learn here all about Axis Customization in Syncfusion ##Platform_Name## Bullet Chart component and more.
platform: ej2-asp-core-mvc
control: Axis Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis Customization

## MajorTickLines and MinorTickLines Customization

You can customize the `width`, `color`, and `size` of minor and major tick lines using the
[`majorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartMajorTickLines.html) and [`minorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartMinorTickLines.html) properties of the bullet-chart.

The following properties can be used to customize `majorTicklines` and `minorTicklines`.

* **width** - Specifies the width of ticklines.
* **height** - Specifies the height of ticklines.
* **color** - Specifies the color of ticklines.
* **useRangeColor** - Specifies the color of ticklines and represents the color from corresponding range colors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/ticks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks.cs" %}
{% include code-snippet/bullet-chart/axis-customization/ticks/ticks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/ticks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Ticks.cs" %}
{% include code-snippet/bullet-chart/axis-customization/ticks/ticks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Customizing Major and Minor TickLines in Bullet Chart](images/blazor-bullet-chart-tick-line-customization.png)

## Tick Placement

The major and the minor ticks can be placed **inside** or **outside** the ranges using the `tickPosition` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/tick-placement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tick-placement.cs" %}
{% include code-snippet/bullet-chart/axis-customization/tick-placement/tick-placement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/tick-placement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tick-placement.cs" %}
{% include code-snippet/bullet-chart/axis-customization/tick-placement/tick-placement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Label Format

Axis numeric labels can be formatted by using the `labelFormat` property. Axis labels support all globalize formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/label-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/bullet-chart/axis-customization/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/label-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-format.cs" %}
{% include code-snippet/bullet-chart/axis-customization/label-format/label-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Changing Label Format in Bullet Chart](images/blazor-bullet-chart-label-format.png)

The following table describes the result of applying some commonly used formats to numeric axis labels.

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
<td>$1000.0</td>
<td>The Currency symbol is appended to number and number is rounded to 1 decimal place</td>
</tr>
<tr>
<td>1000</td>
<td>c2</td>
<td>$1000.00</td>
<td>The Currency symbol is appended to number and number is rounded to 2 decimal place</td>
</tr>
</table>

## GroupingSeparator

To separate groups of thousands, use the [`enableGroupSeparator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBuilder.html) property of bullet-chart.
To separate the groups of thousands, set the `enableGroupSeparator` property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/bullet-chart/axis-customization/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/bullet-chart/axis-customization/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Custom Label Format

Using the `labelFormat` property, axis labels can be specified with a custom defined format in addition to the axis value. The label format uses a placeholder such as **${value}K**, which represents the axis label.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/custom-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-label.cs" %}
{% include code-snippet/bullet-chart/axis-customization/custom-label/custom-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/custom-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-label.cs" %}
{% include code-snippet/bullet-chart/axis-customization/custom-label/custom-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Custom Label Format](images/blazor-bullet-chart-custom-label-format.png)

## Label Placement

You can customize the axis labels `inside` or `outside` the bullet-chart using the [`labelPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.LabelPosition.html) property.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/label-placement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-placement.cs" %}
{% include code-snippet/bullet-chart/axis-customization/label-placement/label-placement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/label-placement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-placement.cs" %}
{% include code-snippet/bullet-chart/axis-customization/label-placement/label-placement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Opposed Position

To place an axis opposite to its original position, set the `opposedPosition` property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/bullet-chart/axis-customization/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/bullet-chart/axis-customization/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Category Label

The Bullet Chart supports X-axis label by specifying the property from the data source to the `categoryField`. It helps to understand the input data in a more efficient way.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/category/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/bullet-chart/axis-customization/category/category.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/category/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Category.cs" %}
{% include code-snippet/bullet-chart/axis-customization/category/category.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart with Category Label](images/blazor-bullet-chart-category-label.png)

## Category Label Customization

The label color, opacity, font size, font family, font weight, and font style can be customized by using the `categoryLabelStyle` setting for category and the `labelStyle` setting for axis label. The `useRangeColor` property specifies the color of the axis label and represents the color from the corresponding range colors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/category-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Category-label.cs" %}
{% include code-snippet/bullet-chart/axis-customization/category-label/category-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/axis-customization/category-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Category-label.cs" %}
{% include code-snippet/bullet-chart/axis-customization/category-label/category-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Customizing Axis and Category Label in Bullet Chart](images/blazor-bullet-chart-label-customization.png)