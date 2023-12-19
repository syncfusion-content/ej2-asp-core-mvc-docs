---
layout: post
title: Tooltip in ##Platform_Name## Bullet Chart Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Bullet Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

When the mouse is hovered over a bar in the Bullet Chart, the tooltip displays important summary about the actual and the target bar values.

## Default tooltip

By setting [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBulletTooltipSettings.html#Syncfusion_EJ2_Charts_BulletChartBulletTooltipSettings_Enable)property to true. By default tooltip is visible in bullet-chart. The tooltip is not visible by default. To make it visible, set the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBulletTooltipSettings.html#Syncfusion_EJ2_Charts_BulletChartBulletTooltipSettings_Enable) property in the [`Tooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Tooltip) to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/tool-tip/tool-tip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tool-tip.cs" %}
{% include code-snippet/bullet-chart/tool-tip/tool-tip/tool-tip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/bullet-chart/tool-tip/tool-tip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tool-tip.cs" %}
{% include code-snippet/bullet-chart/tool-tip/tool-tip/tool-tip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bullet Chart displays ToolTip](images/blazor-bulletchart-tooltip.png)

## Tooltip template

Any HTML elements can be displayed in the tooltip by using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBulletTooltipSettings.html#Syncfusion_EJ2_Charts_BulletChartBulletTooltipSettings_Template) property of the [`Tooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChart.html#Syncfusion_EJ2_Charts_BulletChart_Tooltip). You can use the **${target}** and **${value}** as place holders in the HTML element to display the value and target values from the data source of corresponding data point.

## Tooltip customization

The following properties can be used to customize the Bullet Chart tooltip.

The [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBulletTooltipSettings.html#Syncfusion_EJ2_Charts_BulletChartBulletTooltipSettings_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBulletTooltipSettings.html#Syncfusion_EJ2_Charts_BulletChartBulletTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`TextStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.BulletChartBulletTooltipSettings.html#Syncfusion_EJ2_Charts_BulletChartBulletTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text.
* `Fill` - Specifies the color of tooltip.
* `Border` - Specifies the tooltip border color and width.
* `TextStyle` - Specifies the tooltip font family, font style, font weight, color and size.
