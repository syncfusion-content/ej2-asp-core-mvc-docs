---
layout: post
title: Palette in Syncfusion ##Platform_Name## Heatmap Chart Component
description: Learn here all about Palette in Syncfusion ##Platform_Name## Heatmap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Palette
publishingplatform: ##Platform_Name##
documentation: ug
---


# Palette in ##Platform_Name## HeatMap Chart Component

{% if page.publishingplatform == "aspnet-core" %}

In heat map, each data point is displayed as a cell with applied color based on the data value. The palette in the heat map is used to define the color range for cells and gradient type for colors. You can define the colors either in RGB or hex codes using the [color](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Color) property in the `palette`. The defined colors are applied to the cell background based on the palette type and cell value.

{% elsif page.publishingplatform == "aspnet-mvc" %}

In heat map, each data point is displayed as a cell with applied color based on the data value. The palette in the heat map is used to define the color range for cells and gradient type for colors. You can define the colors either in RGB or hex codes using the [color](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Color) property in the `palette`. The defined colors are applied to the cell background based on the palette type and cell value.

{% endif %}

## Palette types

You can display the heat map cells either in gradient colors or fixed colors.

### Gradient

{% if page.publishingplatform == "aspnet-core" %}

The smooth transition between the given palette colors can be applied for the heat map cells based on value. The heat map calculates all the gradient colors between the start and end colors for all distinct data values. Default start color and end color will be considered for gradient calculation, if the colors are not defined. The palette type must be defined as **Gradient** for the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property in the [paletteSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html#Syncfusion_EJ2_HeatMap_HeatMapPaletteSettings_Type) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/gradient/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gradient.cs" %}
{% include code-snippet/heatmap/palette/gradient/gradient.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The smooth transition between the given palette colors can be applied for the heat map cells based on value. The heat map calculates all the gradient colors between the start and end colors for all distinct data values. Default start color and end color will be considered for gradient calculation, if the colors are not defined. The palette type must be defined as **Gradient** for the [type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html#Syncfusion_EJ2_HeatMap_HeatMapPaletteSettings_Type) property in the [PaletteSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/gradient/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gradient.cs" %}
{% include code-snippet/heatmap/palette/gradient/gradient.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Fixed

{% if page.publishingplatform == "aspnet-core" %}

In fixed palette type, solid colors are applied to the heat map cells. The data values can be grouped based on the number of colors defined for the heat map. The palette type should be defined as Fixed **Fixed** for the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property in the [paletteSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html#Syncfusion_EJ2_HeatMap_HeatMapPaletteSettings_Type) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/fixed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed.cs" %}
{% include code-snippet/heatmap/palette/fixed/fixed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In fixed palette type, solid colors are applied to the heat map cells. The data values can be grouped based on the number of colors defined for the heat map. The palette type should be defined as Fixed **Fixed** for the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings~Type.html) property in the [PaletteSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPaletteSettings.html) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/fixed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fixed.cs" %}
{% include code-snippet/heatmap/palette/fixed/fixed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Defining color stops


{% if page.publishingplatform == "aspnet-core" %}

You can define the colors ranges or color stops for data values in both gradient and fixed palette types. You need to define the data value in the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPalette~Value.html)property for `palette` property to calculate the color stops. The heat map automatically calculates the color stops if the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPalette~Value.html) property is not defined. The [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapPalette~Label.html) property is used to provide the additional information about the color that is to be displayed in the legend. If the label is not provided, the value is displayed in the legend. The labels can be automatically calculated based on data values, if both the values and labels are not defined.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Color.cs" %}
{% include code-snippet/heatmap/palette/color/color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can define the colors ranges or color stops for data values in both gradient and fixed palette types. You need to define the data value in the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Value)property for `palette` property to calculate the color stops. The heat map automatically calculates the color stops if the [value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Value) property is not defined. The [label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Label) property is used to provide the additional information about the color that is to be displayed in the legend. If the label is not provided, the value is displayed in the legend. The labels can be automatically calculated based on data values, if both the values and labels are not defined.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Color.cs" %}
{% include code-snippet/heatmap/palette/color/color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Color range

{% if page.publishingplatform == "aspnet-core" %}

The color range support is used to provide a specific color for specific range in heat map. The [startValue](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_StartValue) and [endValue](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_EndValue) properties are used to define the range start and end value. The [minColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_MinColor) and [maxColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_MaxColor) properties represent the colors of given range. It’s possible to set the cell color for the value not in the given range using the [color](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Color) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/colorrange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColorRange.cs" %}
{% include code-snippet/heatmap/palette/colorrange/color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The color range support is used to provide a specific color for specific range in heat map. The [StartValue](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_StartValue) and [EndValue](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_EndValue) properties are used to define the range start and end value. The [MinColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_MinColor) and [MaxColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_MaxColor) properties represent the colors of given range. It’s possible to set the cell color for the value not in the given range using the [Color](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMapPalette.html#Syncfusion_EJ2_HeatMap_HeatMapPalette_Color) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/palette/colorrange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColorRange.cs" %}
{% include code-snippet/heatmap/palette/colorrange/color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [How to enable smart legend](./legend/#smart-legend)
