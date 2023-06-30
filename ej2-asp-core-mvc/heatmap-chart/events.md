---
layout: post
title: Events in Syncfusion ##Platform_Name## HeatMap Chart Component
description: Learn here all about Events in Syncfusion ##Platform_Name## HeatMap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---


# Events in ##Platform_Name## HeatMap Chart Component

This section describes the HeatMap chart control event, which occurs when the required actions are performed.

## CellClick

{% if page.publishingplatform == "aspnet-core" %}

When you click on a HeatMap cell, the [cellClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellClick) event is triggered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellClick.cs" %}
{% include code-snippet/heatmap/events/cell-click/cell-click.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When you click on a HeatMap cell, the [CellClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellClick) event is triggered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellClick.cs" %}
{% include code-snippet/heatmap/events/cell-click/cell-click.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## CellDoubleClick

{% if page.publishingplatform == "aspnet-core" %}

When you double click on a HeatMap cell, the [cellDoubleClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellDoubleClick) event is triggered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-double-click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellDoubleClick.cs" %}
{% include code-snippet/heatmap/events/cell-double-click/cell-double-click.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When you double click on a HeatMap cell, the [CellDoubleClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellDoubleClick) event is triggered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-double-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellDoubleClick.cs" %}
{% include code-snippet/heatmap/events/cell-double-click/cell-double-click.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## CellRender

{% if page.publishingplatform == "aspnet-core" %}

The [cellRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellRender) event will be triggered before each HeatMap cell is rendered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellRender.cs" %}
{% include code-snippet/heatmap/events/cell-render/cell-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [CellRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellRender) event will be triggered before each HeatMap cell is rendered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellRender.cs" %}
{% include code-snippet/heatmap/events/cell-render/cell-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## CellSelected

{% if page.publishingplatform == "aspnet-core" %}

When single or multiple cells in the HeatMap are selected, the [cellSelected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellSelected) event is triggered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-selected/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelected.cs" %}
{% include code-snippet/heatmap/events/cell-selected/cell-selected.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When single or multiple cells in the HeatMap are selected, the [CellSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellSelected) event is triggered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/cell-selected/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelected.cs" %}
{% include code-snippet/heatmap/events/cell-selected/cell-selected.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Created

{% if page.publishingplatform == "aspnet-core" %}

Once HeatMap has been completely rendered, the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Created) event is triggered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/created/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/heatmap/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Once HeatMap has been completely rendered, the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Created) event is triggered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/heatmap/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## LegendRender

{% if page.publishingplatform == "aspnet-core" %}

The [legendRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_LegendRender) event is triggered before the legend is rendered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/legend-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LegendRender.cs" %}
{% include code-snippet/heatmap/events/legend-render/legend-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [LegendRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_LegendRender) event is triggered before the legend is rendered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/legend-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LegendRender.cs" %}
{% include code-snippet/heatmap/events/legend-render/legend-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Load

{% if page.publishingplatform == "aspnet-core" %}

The [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Load) event is triggered before the HeatMap is rendered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/load/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Load.cs" %}
{% include code-snippet/heatmap/events/load/load.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Load) event is triggered before the HeatMap is rendered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/load/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Load.cs" %}
{% include code-snippet/heatmap/events/load/load.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Loaded

{% if page.publishingplatform == "aspnet-core" %}

Once HeatMap is loaded, the [loaded](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Loaded) event is triggered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/loaded/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Loaded.cs" %}
{% include code-snippet/heatmap/events/loaded/loaded.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Once HeatMap is loaded, the [Loaded](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Loaded) event is triggered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/loaded/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Loaded.cs" %}
{% include code-snippet/heatmap/events/loaded/loaded.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Resized

{% if page.publishingplatform == "aspnet-core" %}

When the window is resized, the [resized](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Resized) event is triggered to notify the resize of the HeatMap.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/resized/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Resized.cs" %}
{% include code-snippet/heatmap/events/resized/resized.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When the window is resized, the [Resized](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_Resized) event is triggered to notify the resize of the HeatMap.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/resized/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resized.cs" %}
{% include code-snippet/heatmap/events/resized/resized.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## TooltipRender

{% if page.publishingplatform == "aspnet-core" %}

The [tooltipRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_TooltipRender) event is triggered before the tooltip is rendered on the HeatMap cell.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/tooltip-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TooltipRender.cs" %}
{% include code-snippet/heatmap/events/tooltip-render/tooltip-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The [TooltipRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_TooltipRender) event is triggered before the tooltip is rendered on the HeatMap cell.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/events/tooltip-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TooltipRender.cs" %}
{% include code-snippet/heatmap/events/tooltip-render/tooltip-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
