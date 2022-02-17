---
layout: post
title: Tool Tip in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Tool Tip in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

Tooltip for the accumulation chart can be enabled by using the `enable` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/default/default.cs %}
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

We can specify header for the tooltip using `header` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/header/header.cs %}
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

By default, tooltip shows information of x and y value in points. In addition to that, you can show more
information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/format/format.cs %}
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



## Tooltip Format

Any HTML element can be displayed in the tooltip by using the `template` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-format.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/tooltip-format/tooltip-format.cs %}
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



## Customization

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Fill) and
[`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_Border)
properties are used to customize the background color and border of the tooltip respectively.
The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChartTooltipSettings.html#Syncfusion_EJ2_Charts_AccumulationChartTooltipSettings_TextStyle)
property in the tooltip is used to customize the font of the tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/custom/custom.cs %}
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

Using `tooltipRender` event, you can customize a tooltip for particular point. event, you can customize a
tooltip for particular point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/individual/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Individual.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/individual/individual.cs %}
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



## Tooltip Mapping Name

By default, tooltip shows information of x and y value in points. You can show more information from datasource in tooltip by using the `tooltipMappingName` property of the tooltip. You can use the `${point.tooltip}` as place holders to display the specified tooltip content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/tooltip/mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mapping.cs" %}
{% include code-snippet/chart/accumulation-charts/tooltip/mapping/mapping.cs %}
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


