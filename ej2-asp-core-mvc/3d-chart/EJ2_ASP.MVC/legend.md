---
layout: post
title: Legend in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about legend in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend in ##Platform_Name## 3D Chart Component

Legend provides information about the series rendered in the 3D chart.

## Position and alignment

By using the [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_Position) property, the legend can be positioned at left, right, top or bottom of the 3D chart. The legend is positioned at the bottom of the 3D chart, by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/3d-chart/series/legend/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/3d-chart/series/legend/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The custom position helps you to position the legend anywhere in the 3D chart using X and Y coordinates.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/custom-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-position.cs" %}
{% include code-snippet/3d-chart/series/legend/custom-position/custom-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/custom-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-position.cs" %}
{% include code-snippet/3d-chart/series/legend/custom-position/custom-position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend reverse

The order of the legend items can be reversed by using the [`Reverse`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_Reverse) property. By default, legend for the first series in the collection will be placed first.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/reverse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reverse.cs" %}
{% include code-snippet/3d-chart/series/legend/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/reverse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reverse.cs" %}
{% include code-snippet/3d-chart/series/legend/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend alignment

The legend can be aligned at near, far or center to the 3D chart using the [`Alignment`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_Alignment) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/3d-chart/series/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/3d-chart/series/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend customization

To change the legend icon shape, [`LegendShape`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_LegendShape) property in the [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html) can be used. By default, the legend icon shape is `SeriesType`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/legend/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/legend/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend size

By default, legend takes 20% - 25% of the 3D chart's height horizontally, when it is placed on top or bottom position and 20% - 25% of the 3D chart's width vertically, when it is placed on left or right position. You can change this default legend size by using the [`Height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_Height) and [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_Width) properties of the `LegendSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/3d-chart/series/legend/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/3d-chart/series/legend/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend item size

The size of the legend items can be customised by using the [`ShapeHeight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_ShapeHeight) and [`ShapeWidth`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_ShapeWidth) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/item-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/3d-chart/series/legend/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/item-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/3d-chart/series/legend/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Paging for legend

Paging will be enabled by default, when the legend items exceeds the legend bounds. Each legend items can be viewed by navigating between the pages using navigation buttons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/paging/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/3d-chart/series/legend/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/paging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/3d-chart/series/legend/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend text wrap

When the legend text exceeds the container, the text can be wrapped by using the [`TextWrap`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_TextWrap) property. End user can also wrap the legend text based on the [`MaximumLabelWidth`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_MaximumLabelWidth) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/text-wrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-wrap.cs" %}
{% include code-snippet/3d-chart/series/legend/text-wrap/text--wrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/text-wrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-wrap.cs" %}
{% include code-snippet/3d-chart/series/legend/text-wrap/text-wrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Series selection through legend

By default, you can collapse the series visibility by clicking the legend. On the other hand, turn off the [`ToggleVisibility`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_ToggleVisibility) property if you must use a legend click to choose a series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/3d-chart/series/legend/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/3d-chart/series/legend/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Collapsing legend item

By default, series name will be displayed as legend. To skip the legend for a particular series, you can give empty string to the series name.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/collapse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapse.cs" %}
{% include code-snippet/3d-chart/series/legend/collapse/collapse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/collapse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapse.cs" %}
{% include code-snippet/3d-chart/series/legend/collapse/collapse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend title

You can set title for legend using [`Title`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_Title) property in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_LegendSettings). The [`Size`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_Size), [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_Color), [`Opacity`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_Opacity), [`FontStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_FontStyle), [`FontWeight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_FontWeight), [`FontFamily`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_FontFamily), [`TextAlignment`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_TextAlignment), and [`TextOverflow`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DFont.html#Syncfusion_EJ2_Charts_Chart3DFont_TextOverflow) of legend title can be customized by using the [`TitleStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_TitleStyle) property in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_LegendSettings). The [`TitlePosition`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_TitlePosition) is used to set the legend position in `Top`, `Left` and `Right` position. The [`MaximumTitleWidth`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_MaximumTitleWidth) is used to set the width of the legend title. By default, it will be `100px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/3d-chart/series/legend/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/3d-chart/series/legend/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Arrow page navigation

The page number will always be visible while using legend paging. It is now possible to disable the page number and enable page navigation with the left and right arrows. The [`EnablePages`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_EnablePages) property needs to be set to **false** in order to render the arrow page navigation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/arrow-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrow-page.cs" %}
{% include code-snippet/3d-chart/series/legend/arrow-page/arrow-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/arrow-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrow-page.cs" %}
{% include code-snippet/3d-chart/series/legend/arrow-page/arrow-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend item padding

The [`ItemPadding`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DLegendSettings.html#Syncfusion_EJ2_Charts_Chart3DLegendSettings_ItemPadding) property can be used to adjust the space between the legend items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/item-padding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Item-padding.cs" %}
{% include code-snippet/3d-chart/series/legend/item-padding/item-padding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/legend/item-padding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-padding.cs" %}
{% include code-snippet/3d-chart/series/legend/item-padding/item-padding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


