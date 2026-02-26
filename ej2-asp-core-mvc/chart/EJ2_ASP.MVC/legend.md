---
layout: post
title: Legend and Customization in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend and in ##Platform_Name## Chart Component

The legend provides information about the series rendered in the chart and helps users identify each series by its color, shape, or style.

## Enable Legend

You can use legend for the chart by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Visible) property to true in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/chart/getting-started/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/getting-started/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/chart/getting-started/legend/legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Position and Alignment

By using the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Position) property, the legend can be positioned at the left, right, top, or bottom of the chart. By default, the legend is positioned at the bottom of the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/axis/legend/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/axis/legend/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Custom positioning allows the legend to be placed anywhere in the chart using `X` and `Y` coordinates.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/axis/legend/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/axis/legend/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Reverse

Use the [`Reverse`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Reverse) property to reverse the order of legend items. By default, the legend item for the first series is placed first.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/reverse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reverse.cs" %}
{% include code-snippet/chart/axis/legend/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/reverse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reverse.cs" %}
{% include code-snippet/chart/axis/legend/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

**Legend Alignment**

<!-- markdownlint-disable MD036 -->

Align the legend to `Center`, `Far`, or `Near` using the [`Alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Alignment) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/chart/axis/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/chart/axis/legend/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

To change the legend icon shape, use the [`LegendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_LegendShape) property in the [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html). By default, the legend icon shape is the `SeriesType`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/axis/legend/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/axis/legend/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend Size

By default, the legend occupies approximately 20%–25% of the chart height when positioned at the top or bottom, and 20%–25% of the chart width when positioned at the left or right. Change the default size using the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Height) properties of `LegendSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/axis/legend/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/chart/axis/legend/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Legend Item Size

Customize the size of legend items using the [`ShapeHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ShapeHeight) and [`ShapeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ShapeWidth) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/item-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/chart/axis/legend/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/item-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-size.cs" %}
{% include code-snippet/chart/axis/legend/item-size/item-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Paging for Legend

Paging is enabled automatically when legend items exceed the legend bounds. Navigate between pages using the provided navigation buttons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/paging/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/chart/axis/legend/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/paging/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/chart/axis/legend/paging/paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Legend Text Wrap

When legend text exceeds the container, enable wrapping using the [`TextWrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_TextWrap) property. Wrapping can also be controlled using the [`MaximumLabelWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_MaximumLabelWidth) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/text-wrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textwrap.cs" %}
{% include code-snippet/chart/axis/legend/text-wrap/textwrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/text-wrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textwrap.cs" %}
{% include code-snippet/chart/axis/legend/text-wrap/textwrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Set the label color based on series color

Set the legend label color based on the series color by using the chart’s [Loaded](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_Loaded) event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/legend-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="legend-label.cs" %}
{% include code-snippet/chart/axis/legend/legend-label/legend-label.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Chart Label Color](../images/legend-label.png)

## Series Selection on Legend

By default, clicking a legend item toggles the visibility of its series. To select a series through a legend click, disable [`ToggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ToggleVisibility).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/chart/axis/legend/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/chart/axis/legend/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable Animation

You can customize the animation while clicking legend by setting enableAnimation as true or false using `EnableAnimation` property in chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/chart/axis/legend/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/chart/axis/legend/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Collapsing Legend Item

By default, the series name is displayed as a legend item. To omit a legend item for a particular series, set the series name to an empty string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/collapse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapse.cs" %}
{% include code-snippet/chart/axis/legend/collapse/collapse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/collapse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapse.cs" %}
{% include code-snippet/chart/axis/legend/collapse/collapse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Legend Title

Set a title for the legend using the `Title` property in `LegendSettings`. The title can be customized using `FontStyle`, `Size`, `FontWeight`, `Color`, `TextAlignment`, `FontFamily`, `Opacity`, and `TextOverflow`. Use `TitlePosition` to place the title at `Top`, `Left`, or `Right`. The `MaximumTitleWidth` property sets the width of the legend title and defaults to `100px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/axis/legend/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/chart/axis/legend/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Arrow Page Navigation

When legend paging is enabled, page numbers are shown by default. To display only left and right arrows for navigation, set `EnablePages` to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/arrow-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrow-page.cs" %}
{% include code-snippet/chart/axis/legend/arrow-page/arrow-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/arrow-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrow-page.cs" %}
{% include code-snippet/chart/axis/legend/arrow-page/arrow-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Legend Item Padding

Use the [`ItemPadding`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ItemPadding) property to adjust the spacing between legend items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/itempadding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ItemPadding.cs" %}
{% include code-snippet/chart/axis/legend/itempadding/itempadding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/itempadding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemPadding.cs" %}
{% include code-snippet/chart/axis/legend/itempadding/itempadding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Legend layout

The [`Layout`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Layout) property in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_LegendSettings) displays the legend horizontally or vertically. By default, [`Layout`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Layout) is set to **Auto**. The [`MaximumColumns`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_MaximumColumns) property defines the maximum number of columns that can be displayed within the available space when using auto layout. Enabling the [`FixedWidth`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_FixedWidth) property ensures that all legend items have equal widths, determined by the maximum item width.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Layout.cs" %}
{% include code-snippet/chart/axis/legend/layout/layout.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/axis/legend/layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Layout.cs" %}
{% include code-snippet/chart/axis/legend/layout/layout.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}