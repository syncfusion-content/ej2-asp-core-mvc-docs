---
layout: post
title: Tool Tip in ##Platform_Name## Stock Chart Component
description: Learn here all about Tool Tip in Syncfusion ##Platform_Name## Stock Chart component and more.
platform: ej2-asp-core-mvc
control: Tool Tip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

<!-- markdownlint-disable MD036 -->

Stock Chart will display details about the points through tooltip, when the mouse is moved over the point.

## Default Tooltip

By default, tooltip is not visible. Enable the tooltip by setting
[`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Enable)property to true .

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD013 -->

## Format the Tooltip

<!-- markdownlint-disable MD013 -->

By default, tooltip shows information of x and y value in points. In addition to that, you can show more information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the Appearance of Tooltip

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Fill) and [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/customtooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customtooltip.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/customtooltip/customtooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/stock-chart/stockchart-feature/customtooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customtooltip.cs" %}
{% include code-snippet/stock-chart/stockchart-feature/customtooltip/customtooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


