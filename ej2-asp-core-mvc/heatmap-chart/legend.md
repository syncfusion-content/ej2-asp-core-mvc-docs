---
layout: post
title: Legend in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend in ##Platform_Name## HeatMap Chart Component

{% if page.publishingplatform == "aspnet-core" %}

The legend is used to provide the information about the heat map cell. You can enable the legend by setting the [visible](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Visible) property to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/legend/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend is used to provide the information about the heat map cell. You can enable the legend by setting the [Visible](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Visible) property to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/legend/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Legend](images/Legend/heatmap-with-legend.png)

## Legend types

{% if page.publishingplatform == "aspnet-core" %}

Heat map supports two legend types: **Gradient** and **Fixed** type.

* **Gradient** - This is a continuous color legend with smooth color transition between palette color values.
* **Fixed** - The fixed color legend is a list. Each palette color information is shown separately in the list item.

You can change the legend type by using the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property in the [paletteSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html) property.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/types/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Types.cs" %}
{% include code-snippet/heatmap/legend/types/types.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Heat map supports two legend types: Gradient and Fixed type.

* **Gradient** - This is a continuous color legend with smooth color transition between palette color values.
* **Fixed** - The fixed color legend is a list. Each palette color information is shown separately in the list item.

You can change the legend type by using the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html#Syncfusion_EJ2_HeatMap_HeatMapPaletteSettings_Type) property in the [paletteSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html)property.


{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/types/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Types.cs" %}
{% include code-snippet/heatmap/legend/types/types.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Fixed Legend](images/Legend/heatmap-with-fixed-legend.png)

## Placement

{% if page.publishingplatform == "aspnet-core" %}

You can place the legend at **Left**, **Right**, **Top**, or **Bottom** to the heat map layout by using the [position](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Position.html) property. The legend is positioned at the **Right** to the heat map by default.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/placement/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/heatmap/legend/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can place the legend at left, right, top, or bottom to the heat map layout by using the [Position](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Position) property. The legend is positioned at the right to the heat map by default.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/placement/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placement.cs" %}
{% include code-snippet/heatmap/legend/placement/placement.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Changing Legend Position](images/Legend/heatmap-with-legend-position.png)

## Alignment

{% if page.publishingplatform == "aspnet-core" %}

You can align the legend as **Center**, **Far**, or **Near** to the heat map using the [alignment](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Alignment.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/heatmap/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can align the legend as center, far, or near to the heat map using the [Alignment](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Alignment) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/heatmap/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Changing Legend Alignment](images/Legend/heatmap-with-legend-alignment.png)

## Legend dimensions

{% if page.publishingplatform == "aspnet-core" %}

You can change the legend dimensions with values in pixels or percentage by using the[width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Width.html) and [height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~Height.html) properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/dimensions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dimensions.cs" %}
{% include code-snippet/heatmap/legend/dimensions/dimensions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can change the legend dimensions with values in pixels or percentage by using the[Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Width) and [Height](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Height) properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/dimensions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dimensions.cs" %}
{% include code-snippet/heatmap/legend/dimensions/dimensions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Changing Legend Dimensions](images/Legend/heatmap-with-legend-dimension.png)

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

![ASP.NET Core HeatmapChart with Legend Paging](images/Legend/heatmap-with-legend-paging.png)

## Smart legend

{% if page.publishingplatform == "aspnet-core" %}

Smart legend is another way of showing list type legend with responsiveness and readability, when the palette has more number of items. You can enable this smart legend by using the [enableSmartLegend](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~EnableSmartLegend.html) property when the palette type is set to **Fixed**.

In smart legend, you can change the display type of legend labels by using the [labelDisplayType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~LabelDisplayType.html) property.

The following are the legend label display types:
* **All**: Displays all labels in the legend.
* **Edge**: Displays the legend labels only at extreme ends.
* **None**: None of the labels are displayed. The tooltip will appear for this type of label display when hovering over the legend item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/smart-legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Smart-legend.cs" %}
{% include code-snippet/heatmap/legend/smart-legend/smart-legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Smart legend is another way of showing list type legend with responsiveness and readability, when the palette has more number of items. You can enable this smart legend by using the [EnableSmartLegend](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_EnableSmartLegend) property when the palette type is set to **Fixed**.

In smart legend, you can change the display type of legend labels by using the [LabelDisplayType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_LabelDisplayType) property.

The following are the legend label display types:
* **All**: Displays all labels in the legend.
* **Edge**: Displays the legend labels only at extreme ends.
* **None**: None of the labels are displayed. The tooltip will appear for this type of label display when hovering over the legend item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/smart-legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Smart-legend.cs" %}
{% include code-snippet/heatmap/legend/smart-legend/smart-legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Smart Legend](images/Legend/heatmap-with-smart-legend.png)

## Legend selection

{% if page.publishingplatform == "aspnet-core" %}

In the HeatMap, the legend selection is used to toggle the visibility of cell for viewing the specific range value. You can enable the legend selection using the [toggleVisibility](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~ToggleVisibility.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/legend-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-selection.cs" %}
{% include code-snippet/heatmap/legend/legend-selection/legend-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the HeatMap, the legend selection is used to toggle the visibility of cell for viewing the specific range value. You can enable the legend selection using the [ToggleVisibility](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_ToggleVisibility) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/legend-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-selection.cs" %}
{% include code-snippet/heatmap/legend/legend-selection/legend-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Legend Selection](images/Legend/heatmap-with-legend-selection.png)

## Legend title

{% if page.publishingplatform == "aspnet-core" %}

The legend title displays a specific information about the legend. You can enable the legend title by setting the [title](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~title.html) property by providing the text and customizing the legend title text style using the [textStyle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapLegendSettings~titleModel~textStyle.html) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/legend-title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-title.cs" %}
{% include code-snippet/heatmap/legend/legend-title/legend-title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The legend title displays a specific information about the legend. You can enable the legend title by setting the [Title](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_Title) property by providing the text and customizing the legend title text style using the [TextStyle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapLegendSettings.html#Syncfusion_EJ2_HeatMap_HeatMapLegendSettings_TextStyle) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/legend/legend-title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-title.cs" %}
{% include code-snippet/heatmap/legend/legend-title/legend-title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatmapChart with Legend Title](images/Legend/heatmap-with-legend-title.png)