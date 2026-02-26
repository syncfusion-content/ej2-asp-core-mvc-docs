---
layout: post
title: Axis Customization in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Axis Customization in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis Customization in ##Platform_Name## Chart Component

## Axis Crossing

An axis can be positioned dynamically within the chart area using the `CrossesAt` and `CrossesInAxis` properties. The `CrossesAt` property specifies the value (date-time, numeric, or logarithmic) at which the axis line intersects another axis, while the `CrossesInAxis` property defines the name of the axis with which the current axis should intersect. This customization is useful for emphasizing specific reference points or thresholds in the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/axis-cross/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-cross.cs" %}
{% include code-snippet/chart/axis/category/axis-cross/axis-cross.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/axis-cross/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Axis-cross.cs" %}
{% include code-snippet/chart/axis/category/axis-cross/axis-cross.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Title

A title can be added to an axis using the [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_Title) property. Axis titles provide context and help users quickly understand the data represented along the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/axis/category/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/axis/category/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Title Rotation

The orientation of the axis title can be adjusted using the [`TitleRotation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_TitleRotation) property. This property supports rotation values from 0 to 360 degrees, allowing better alignment based on the chart layout and available space.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/titlerotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TitleRotation.cs" %}
{% include code-snippet/chart/axis/category/titlerotation/titlerotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/titlerotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TitleRotation.cs" %}
{% include code-snippet/chart/axis/category/titlerotation/titlerotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Tick Lines Customization

The appearance of both major and minor tick lines can be customized using the [`MajorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorTickLines) and [`MinorTickLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorTickLines) properties. These properties allow customization of the `Width`, `Color`, and `Size` of tick lines to enhance chart readability.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/tick/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/chart/axis/category/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/tick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/chart/axis/category/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grid Lines Customization

Grid lines can be styled using the [`MajorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MajorGridLines) and [`MinorGridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MinorGridLines) properties. These options support customization of `Width`, `Color`, and `DashArray`, helping users distinguish data points and scales more effectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/chart/axis/category/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/chart/axis/category/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Axis

In addition to the primary X and Y axes, multiple additional axes can be added to a chart. Each series can be associated with a specific axis by mapping it to the axis using a unique axis name. This is useful for visualizing datasets with different units or scales within the same chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/chart/axis/category/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/chart/axis/category/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Inversed Axis

<!-- markdownlint-disable MD033 -->

When an axis is inversed, the highest value is displayed closer to the origin, and the lowest value appears farther away. This behavior can be enabled by setting the [`IsInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_IsInversed) property to `true`. Inversed axes are commonly used in scenarios such as ranking or inverted value representations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/inversed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/chart/axis/category/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/inversed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/chart/axis/category/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Opposed Position

<!-- markdownlint-disable MD012 -->
An axis can be placed on the opposite side of its default position by setting the [`OpposedPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_OpposedPosition) property to `true`. This option is useful when displaying multiple axes or when optimizing space usage in complex chart layouts.
<!-- markdownlint-disable MD012 -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/chart/axis/category/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/category/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/chart/axis/category/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




