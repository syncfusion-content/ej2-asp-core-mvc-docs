---
layout: post
title: Tooltip in Syncfusion ##Platform_Name## Chart Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip in ##Platform_Name## Chart Component

<!-- markdownlint-disable MD036 -->

The chart displays detailed information about a data point through a tooltip when the mouse pointer moves over the point.

## Enable tooltip

By default, the tooltip is not visible. You can enable the tooltip by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Enable) property to **true** in [`Tooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Fixed tooltip

By default, the tooltip tracks the mouse movement. You can render the tooltip at a fixed position by using the [`Location`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Location) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/fixed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/fixed/fixed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/fixed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/fixed/fixed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format the tooltip

<!-- markdownlint-disable MD013 -->

By default, the tooltip displays the x- and y-values of a data point. Additional information can be shown by specifying a custom format. For example, the format `${series.name} ${point.x}` displays the series name along with the x-value of the data point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD013 -->

## Tooltip template

Custom HTML content can be rendered in the tooltip by using the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Template) property. The `${x}` and `${y}` placeholders can be used within the template to display the x- and y-values of the corresponding data point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the appearance of tooltip

The appearance of the tooltip can be customized by using the following properties:

- [`Fill`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Fill) to set the background color
- [`Border`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Border) to configure the tooltip border
- [`TextStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_TextStyle) to customize the tooltip text style

The [`HighlightColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_HighlightColor) property is used to change the color of a data point when it is highlighted during tooltip interaction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/custom-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/custom-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/custom-tooltip/custom-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip mapping name

By default, tooltip shows information of x and y value in points. You can show more information from data source in tooltip by using the [`TooltipMappingName`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_TooltipMappingName) property of the tooltip. You can use the `${point.tooltip}` as place holders to display the specified tooltip content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/tooltip-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-mapping.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/tooltip-mapping/tooltip-mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/tooltip-mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-mapping.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/tooltip-mapping/tooltip-mapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enable highlight

By setting the [`EnableHighlight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_EnableHighlight) property to **true**, all points in the hovered series are highlighted while the remaining points are dimmed. This behavior improves focus and readability during data analysis.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/tooltip-enable/tagHelper %}
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



## Closest tooltip

The [`ShowNearestTooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_ShowNearestTooltip) property displays the tooltip for the data point nearest to the pointer, even when the pointer is not directly positioned over the point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/nearest-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nearest-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/nearest-tooltip/nearest-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/nearest-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nearest-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/nearest-tooltip/nearest-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


