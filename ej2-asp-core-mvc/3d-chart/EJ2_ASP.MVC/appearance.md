---
layout: post
title: Appearance in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about appearance in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Appearance in ##Platform_Name## 3D Chart Component

## Custom color palette

The default color of series or points can be customized by providing a custom color palette of your choice by using the [`Palettes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Palettes) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/appearance/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/appearance/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Data point customization

The color of an individual data point can be customized using the below options.

### Point color mapping

The color for the points can be bound from the [`DataSource`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_DataSource) for the series by utilizing the [`PointColorMapping`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_PointColorMapping) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/point-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-color.cs" %}
{% include code-snippet/3d-chart/series/appearance/point-color/point-color.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/point-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-color.cs" %}
{% include code-snippet/3d-chart/series/appearance/point-color/point-color.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Point level customization

The data label and fill color of each data point can be customized using the [`PointRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_PointRender) and [`TextRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_TextRender) events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/point-custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Point-custom.cs" %}
{% include code-snippet/3d-chart/series/appearance/point-custom/point-custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/point-custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Point-custom.cs" %}
{% include code-snippet/3d-chart/series/appearance/point-custom/point-custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

## Chart area customization

<!-- markdownlint-disable MD036 -->

**Customize the chart background**

The background color and border of the 3D chart can be customized using the [`Background`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Background) and [`Border`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Border) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/background/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Background.cs" %}
{% include code-snippet/3d-chart/series/appearance/background/background.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/background/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Background.cs" %}
{% include code-snippet/3d-chart/series/appearance/background/background.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Chart margin**

The 3D chart's margin can be set from its container using the [`Margin`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Margin) property.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/3d-chart/series/appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/3d-chart/series/appearance/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Animation

To customize the animation for a particular series, the [`Animation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DSeries.html#Syncfusion_EJ2_Charts_Chart3DSeries_Animation) property can be used. It can be enabled or disabled by using the `Enable` property. The `Duration` property specifies the duration of an animation and the `Delay` property allows us to start the animation at desire time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/3d-chart/series/appearance/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/3d-chart/series/appearance/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Chart rotation

The 3D Chart can be roatated by using the [`EnableRotation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_EnableRotation) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/rotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotation.cs" %}
{% include code-snippet/3d-chart/series/appearance/rotation/rotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/rotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotation.cs" %}
{% include code-snippet/3d-chart/series/appearance/rotation/rotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Title

The 3D chart can be given a title by using [`Title`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Title) property, to show the information about the data plotted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/3d-chart/series/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/3d-chart/series/appearance/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Title position

By using the [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_Position) property in [`TitleStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_TitleStyle), the [`Title`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_Title) can be positioned at left, right, top or bottom of the 3D chart. The title is positioned at the top of the 3D chart, by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/titleposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titleposition.cs" %}
{% include code-snippet/3d-chart/series/appearance/titleposition/titleposition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/titleposition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titleposition.cs" %}
{% include code-snippet/3d-chart/series/appearance/titleposition/titleposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The custom option is used to position the title anywhere in the 3D chart using [`X`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_X) and [`Y`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_Y) coordinates.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/titleoption/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titleoption.cs" %}
{% include code-snippet/3d-chart/series/appearance/titleoption/titleoption.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/titleoption/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titleoption.cs" %}
{% include code-snippet/3d-chart/series/appearance/titleoption/titleoption.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Title alignment

The title can be aligned to the near, far, or center of the 3D chart by using the [`TextAlignment`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_TextAlignment) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/titlealignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titlealignment.cs" %}
{% include code-snippet/3d-chart/series/appearance/titlealignment/titlealignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/titlealignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titlealignment.cs" %}
{% include code-snippet/3d-chart/series/appearance/titlealignment/titlealignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Title customization

The [`TitleStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_TitleStyle) property of the 3D chart provides options to customize the title by using the following properties.

* [`Size`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_Size) - Specifies the size of the title.
* [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_Color) - Specifies the color for the title. 
* [`FontFamily`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_FontFamily) - Specifies the font family for the title.
* [`FontWeight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_FontWeight) - Specifies the font weight of the title.
* [`FontStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_FontStyle) - Specifies the font style for the title.
* [`Opacity`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_Opacity) - Specifies the opacity for the color of the title.
* [`TextAlignment`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_TextAlignment) - Specifies the alignment of the title.
* [`TextOverflow`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DTitleSettings.html#Syncfusion_EJ2_Charts_Chart3DTitleSettings_TextOverflow) - Specifies the overflow of the title.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/3d-chart/series/appearance/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/appearance/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/3d-chart/series/appearance/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


