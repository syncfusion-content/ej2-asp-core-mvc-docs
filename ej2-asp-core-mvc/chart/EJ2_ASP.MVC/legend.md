---
layout: post
title: Legend in ##Platform_Name## Chart Component
description: Learn here all about Legend in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend

Legend provides information about the series rendered in the chart.

## Enable Legend

You can use legend for the chart by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Visible)
property to true in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html) object.

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

By using the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Position) property, you can position the legend
at left, right, top or bottom of the chart. The legend is positioned at the bottom of the chart, by default.

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



Custom position helps you to position the legend anywhere in the chart using x, y coordinates.

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

You can reverse the order of the legend items by using the [`Reverse`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Reverse) property. By default, legend for the first series in the collection will be placed first.

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

You can align the legend as `Center`, `Far` or `Near` to the chart using
[`Alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Alignment) property.

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

To change the legend icon shape, you can use [`LegendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_LegendShape) property
in the [`Series`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartSeries.html). By default legend icon shape is `SeriesType`.

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



**Legend Size**

By default, legend takes 20% - 25% of the chart's height horizontally, when it is placed on top or bottom position and 20% - 25% of the
chart's width vertically, when placed on left or right position of the chart. You can change this default legend size by using the
[`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_Height) property of the `LegendSettings`.

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



**Legend Item Size**

You can customize the size of the legend items by using the [`ShapeHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ShapeHeight)
and [`ShapeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ShapeWidth) property.

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



**Paging for Legend**

Paging will be enabled by default, when the legend items exceeds the legend bounds. You can view each legend
items by navigating between the pages using navigation buttons.

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



## Series Selection on Legend

By default, legend click enables you to collapse the series visibility.  On other hand, if you need to select
a series through legend click, disable the
[`ToggleVisibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartLegendSettings.html#Syncfusion_EJ2_Charts_ChartLegendSettings_ToggleVisibility).

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

By default, series name will be displayed as legend. To skip the legend for a particular series, you can give empty string to the series name.

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

You can set title for legend using `Title` property in `LegendSettings`. You can also customize the `FontStyle`, `Size`, `FontWeight`,
`Color`, `TextAlignment`, `FontFamily`, `Opacity` and `TextOverflow` of legend title. `TitlePosition` is used to set the legend position in `Top`, `Left` and `Right` position. `MaximumTitleWidth` is used to set the width of the legend title. By default, it will be `100px`.

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

By default, the page number will be enabled while legend paging. Now, you can disable that page number and also you can get left and right arrows for page navigation. You have to set `false` value to `EnablePages` to get this support.

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

