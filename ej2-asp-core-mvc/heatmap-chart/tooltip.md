---
layout: post
title: Tooltip in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip in ##Platform_Name## HeatMap Chart Component

Tooltip is used to provide the details of the heatmap cell, and this can be displayed, while hovering the cursor over the cell or performing tap action in touch devices.

## Default tooltip

{% if page.publishingplatform == "aspnet-core" %}

You can enable the tooltip by setting the [showTooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~ShowTooltip.html) property to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/tooltip/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/heatmap/tooltip/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can enable the tooltip by setting the [ShowTooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_ShowTooltip) property to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/tooltip/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/heatmap/tooltip/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip template

{% if page.publishingplatform == "aspnet-core" %}

The HTML element can be rendered in the tooltip of the Maps using the template property of the [tooltipSettings](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings). In the following example, ${xLabel}, ${yLabel} and ${value} are the place holders in the HTML element to display the x-axis labels, y-axis labels and cell values of the corresponding cells in the Heatmap.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/tooltip/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/heatmap/tooltip/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The HTML element can be rendered in the tooltip of the Maps using the template property of the [TooltipSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings.html#Syncfusion_EJ2_HeatMap_HeatMapTooltipSettings). In the following example, ${xLabel}, ${yLabel} and ${value} are the place holders in the HTML element to display the x-axis labels, y-axis labels and cell values of the corresponding cells in the Heatmap.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/tooltip/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/heatmap/tooltip/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize the appearance of tooltip

{% if page.publishingplatform == "aspnet-core" %}

The [fill](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings~Fill.html) and [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings~Border.html) properties are used to customize the background color and border of the tooltip respectively. The [textStyle](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings~TextStyle.html) property in the tooltip is used to customize the font of the tooltip text.

In heatmap, you can customize the tooltip using the [tooltipRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~TooltipRender.html) client side event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/tooltip/tooltipSettings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/heatmap/tooltip/tooltipSettings/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings.html#Syncfusion_EJ2_HeatMap_HeatMapTooltipSettings_Fill) and [border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings.html#Syncfusion_EJ2_HeatMap_HeatMapTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapTooltipSettings.html#Syncfusion_EJ2_HeatMap_HeatMapTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text.

In heatmap, you can customize the tooltip using the [TooltipRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~TooltipRender.html) client side event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/tooltip/tooltipSettings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/heatmap/tooltip/tooltipSettings/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


