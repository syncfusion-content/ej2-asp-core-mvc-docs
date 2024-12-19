---
layout: post
title: Tooltip in ##Platform_Name## Syncfusion Accumulation Chart Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip in ##Platform_Name## Accumulation chart component

Tooltip for the accumulation chart can be enabled by using the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Enable) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header

We can specify header for the tooltip using [`Header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Header) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/header/header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format

By default, tooltip shows information of x and y value in points. In addition to that, you can show more information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip format

Any HTML element can be displayed in the tooltip by using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Template) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-format.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-format/tooltip-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Fixed tooltip

By default, tooltip track the mouse movement, but you can set a fixed position for the tooltip by using the [`Location`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Location) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-fixed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-fixed.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-fixed/tooltip-fixed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-fixed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-fixed.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-fixed/tooltip-fixed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`TextStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text. The [`HighlightColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_HighlightColor) property can be used to change the color of the data point when hovering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## To customize individual tooltip

Using [`TooltipRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_TooltipRender) event, you can customize a tooltip for particular point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/individual/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/individual/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Individual.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/individual/individual.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip mapping name

By default, tooltip shows information of x and y value in points. You can show more information from datasource in tooltip by using the [`TooltipMappingName`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_TooltipMappingName) property of the tooltip. You can use the `${point.tooltip}` as place holders to display the specified tooltip content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class GroupingChartData
{
    public string xValue;
    public double yValue;
    public string text;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mapping.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/mapping/mapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enable highlight

By setting the [`EnableHighlight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_EnableHighlight) property to **true**, the hovered pie slice is highlighted, while the remaining slices are dimmed, enhancing focus and clarity.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-enable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class GroupingChartData
{
    public string xValue;
    public double yValue;
    public string text;
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-enable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-enable.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-enable/tooltip-enable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
