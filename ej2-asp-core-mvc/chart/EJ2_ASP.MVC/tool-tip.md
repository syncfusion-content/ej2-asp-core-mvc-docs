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

Chart will display details about the points through tooltip, when the mouse is moved over the point.

## Enable tooltip

The tooltip is useful when you cannot display information by using the data labels due to space constraints. You can enable the tooltip by setting [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Enable) property as true in [`Tooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html) object.

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

By default, tooltip track the mouse movement, but you can set a fixed position for the tooltip by using the [`Location`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Location) property.

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

By default, tooltip shows information of x and y value in points. In addition to that, you can show more information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

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



## Inline tooltip formatting

The tooltip content can be formatted directly within the [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Format) property by adding DateTime or number format specifiers to supported tooltip tokens. This allows you to control how point and series values are displayed without using additional events.

A format specifier can be applied to a tooltip token by adding a colon (`:`) followed by the required format.

For example:

```cshtml
    .Tooltip(tooltip => tooltip
        .Enable(true)
        .Format("${point.x:MMM yyyy} : <b>${point.y:p0}</b>")
    )
```

In the above example, `point.x` is displayed in month-year format, and `point.y` is displayed as a percentage without decimal places.

Inline formatting can be applied to the following tooltip tokens:

- `point.x` – Specifies the x-value of the data point, such as DateTime or category values.
- `point.y` – Specifies the numeric y-value of the data point.
- `point.size` – Specifies the size value of the data point, commonly used in bubble series.
- `point.high` and `point.low` – Specify the high and low values, commonly used in range and financial series.
- `point.open` and `point.close` – Specify the open and close values, commonly used in financial series.
- `point.volume` – Specifies the volume value, commonly used in financial series.
- `point.minimum` – Specifies the minimum value, commonly used in box and whisker series.
- `point.maximum` – Specifies the maximum value, commonly used in box and whisker series.
- `point.median` – Specifies the median value, commonly used in box and whisker series.
- `point.lowerQuartile` – Specifies the lower quartile value, commonly used in box and whisker series.
- `point.upperQuartile` – Specifies the upper quartile value, commonly used in box and whisker series.
- `point.outliers` – Specifies the outlier values, commonly used in box and whisker series.
- `series.name` – Specifies the name assigned to the series.
- `series.type` – Specifies the rendering type of the series, such as `Line`, `Spline`, or `Column`.
- `series.opacity` – Specifies the opacity value applied to the series. This value controls the visual transparency of the series and can be customized in the series configuration.

**Important:** The availability of point-specific tokens depends on the series type and the values configured in the data source. For example, `point.size` is applicable to bubble series, while `point.median`, `point.lowerQuartile`, and `point.upperQuartile` are applicable to box and whisker series. The `series.name` and `series.type` tokens return string values, so DateTime or number formatting is not applied to these tokens.

The following format types are supported:

- DateTime formats such as `MMM yyyy`, `MM:yy`, and `dd MMM`
- Number formats such as:
  - `n2` – number with two decimal places
  - `n0` – number without decimals
  - `c2` – currency format
  - `p1` – percentage format
  - `e1` – exponential notation

If the specified format does not match the resolved value type, the original value is displayed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/inline-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-format.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/inline-format/inline-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip/inline-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inline-format.cs" %}
{% include code-snippet/chart/user-interaction/tooltip/inline-format/inline-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD013 -->

## Tooltip template

Any HTML elements can be displayed in the tooltip by using the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Template) property of the tooltip. You can use the ${x} and ${y} as place holders in the HTML element to display the x and y values of the corresponding data point.

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

The [`Fill`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`TextStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text. The [`HighlightColor`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_HighlightColor) property is used to customize the point color while hovering for tooltip.

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

## Split tooltip

The split tooltip displays a separate tooltip for each series at the same data point, making it easier to compare values across multiple series.

Enable this feature by setting the `split` property to **true**:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/split-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Split-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/split-tooltip/split-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/split-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Split-tooltip.cs" %}
{% include code-snippet/chart/user-interaction/split-tooltip/split-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Follow pointer

The follow pointer feature enables the tooltip to follow the mouse cursor or touch pointer as users interact with the chart. This provides a more dynamic and intuitive experience by keeping the tooltip close to the user's point of interaction.

Enable this feature by setting the `followPointer` property to **true**:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/follow-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Follow-pointer.cs" %}
{% include code-snippet/chart/user-interaction/follow-pointer/follow-pointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/follow-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Follow-pointer.cs" %}
{% include code-snippet/chart/user-interaction/follow-pointer/follow-pointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Tooltip distance

The tooltip distance property controls the spacing between the tooltip and the mouse pointer or target data point. This prevents the tooltip from overlapping with the cursor or nearby chart elements, improving readability.

Set the `distance` property to specify the gap in pixels:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip-distance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-distance.cs" %}
{% include code-snippet/chart/user-interaction/tooltip-distance/tooltip-distance.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/tooltip-distance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-distance.cs" %}
{% include code-snippet/chart/user-interaction/tooltip-distance/tooltip-distance.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enable highlight

By setting the [`EnableHighlight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_EnableHighlight) property to **true**, you can highlight all points in the hovered series while dimming points in other series, enhancing focus and clarity.

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

The [`ShowNearestTooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_ShowNearestTooltip) property in the chart tooltip displays tooltips based on the data points closest to the cursor.

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


