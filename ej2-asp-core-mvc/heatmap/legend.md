---
layout: post
title: Legend in ##Platform_Name## Heatmap Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Heatmap component and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend

The legend is used to provide the information about the heat map cell. You can enable the legend by setting the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Visible.html) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/legend/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/legend/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend types

Heat map supports two legend types: Gradient and list type.

* Gradient - This is a continuous color legend with smooth color transition between palette color values.
* List - List is a fixed color legend. Each palette color information is shown separately in the list item.

You can change the legend type by using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property in the `paletteSettings` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/types/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Types.cs" %}
{% include code-snippet/heatmap/legend/types/types.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/types/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Types.cs" %}
{% include code-snippet/heatmap/legend/types/types.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Placement

You can place the legend at left, right, top, or bottom to the heat map layout by using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Position.html) property. The legend is positioned at the right to the heat map by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/placement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/heatmap/legend/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/placement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/heatmap/legend/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Alignment

You can align the legend as center, far, or near to the heat map using the [`alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Alignment.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/heatmap/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/heatmap/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend dimensions

You can change the legend dimensions with values in pixels or percentage by using the[`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Height.html) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/dimensions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dimensions.cs" %}
{% include code-snippet/heatmap/legend/dimensions/dimensions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/dimensions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dimensions.cs" %}
{% include code-snippet/heatmap/legend/dimensions/dimensions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Paging for legend

Paging is available only for the list type legend in the heat map, and it can be enabled by default,when the legend items exceed the legend bounds. You can view each legend items by navigating between the pages using navigation buttons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/paging/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/heatmap/legend/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/paging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/heatmap/legend/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Smart Legend

Smart legend is another way of showing list type legend with responsiveness and readability, when the palette has more number of items. You can enable this smart legend by using the [`enableSmartLegend`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~EnableSmartLegend.html) property when the palette type is set to `Fixed`.

In smart legend, you can change the display type of legend labels by using the [`labelDisplayType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~LabelDisplayType.html) property.

The following are the legend label display types:
* All: Displays all labels in the legend.
* Edge: Displays the legend labels only at extreme ends.
* None: None of the labels are displayed. The tooltip will appear for this type of label display when hovering over the legend item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/smart-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Smart-legend.cs" %}
{% include code-snippet/heatmap/legend/smart-legend/smart-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/smart-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Smart-legend.cs" %}
{% include code-snippet/heatmap/legend/smart-legend/smart-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Selection

In the HeatMap, the legend selection is used to toggle the visibility of cell for viewing the specific range value. You can enable the legend selection using the [`toggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~ToggleVisibility.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/legend-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-selection.cs" %}
{% include code-snippet/heatmap/legend/legend-selection/legend-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/legend-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-selection.cs" %}
{% include code-snippet/heatmap/legend/legend-selection/legend-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


