---
layout: post
title: Tool Tip in ##Platform_Name## Chart Component
description: Learn here all about Tool Tip in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

<!-- markdownlint-disable MD036 -->

Chart will display details about the points through tooltip, when the mouse is moved over the point.

## Enable Tooltip

The tooltip is useful when you cannot display information by using the data labels due to space constraints.
You can enable tooltip by setting the [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Enable) property as true
in [`tooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html) object.

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



## Format the Tooltip

<!-- markdownlint-disable MD013 -->

By default, tooltip shows information of x and y value in points. In addition to that, you can show more
information in tooltip. For example the format '${series.name} ${point.x}' shows series name and point x
value.

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

## Tooltip Template

Any HTML elements can be displayed in the tooltip by using the ‘template’ property of the tooltip. You can use the ${x} and ${y} as place holders in the HTML element to display the x and y values of the corresponding data point.

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



## Customize the Appearance of Tooltip

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Fill)
and [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Border)
properties are used to customize the background color and border of the tooltip respectively.
The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_TextStyle)
property in the tooltip is used to customize the font of the tooltip text.
The [`highlightColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_HighlightColor) property is used to customize the point color while hovering for tooltip.

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



## Tooltip Mapping Name

By default, tooltip shows information of x and y value in points. You can show more information from data source in tooltip by using the `tooltipMappingName` property of the tooltip. You can use the `${point.tooltip}` as place holders to display the specified tooltip content.

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


