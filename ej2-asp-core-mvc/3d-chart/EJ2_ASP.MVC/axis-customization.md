---
layout: post
title: Axis Customization in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about Axis Customization in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Axis Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Axis customization in ##Platform_Name## 3D Chart Component

The following topics shows how to customize the axis.

## Title

The title for the axis can be added by using the [`Title`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_Title) property. It helps to provide quick information to the user about the data plotted in the axis. Title style can be customized using [`TitleStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_TitleStyle) property of the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/3d-chart/series/axis/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/3d-chart/series/axis/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Title rotation

The title can be rotated from 0 to 360 degree by using the [`TitleRotation`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_TitleRotation) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/titlerotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TitleRotation.cs" %}
{% include code-snippet/3d-chart/series/axis/titlerotation/titlerotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/titlerotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TitleRotation.cs" %}
{% include code-snippet/3d-chart/series/axis/titlerotation/titlerotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Tick lines customization

The [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DMajorTickLines.html#Syncfusion_EJ2_Charts_Chart3DMajorTickLines_Width), [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DMajorTickLines.html#Syncfusion_EJ2_Charts_Chart3DMajorTickLines_Color) and [`Height`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DMajorTickLines.html#Syncfusion_EJ2_Charts_Chart3DMajorTickLines_Height) of the minor and major tick lines can be customized by using the [`MajorTickLines`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_MajorTickLines) and [`MinorTickLines`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_MinorTickLines) properties in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/tick/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/3d-chart/series/axis/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/tick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/3d-chart/series/axis/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grid lines customization

The [`Width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DMajorGridLines.html#Syncfusion_EJ2_Charts_Chart3DMajorGridLines_Width), and [`Color`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DMajorGridLines.html#Syncfusion_EJ2_Charts_Chart3DMajorGridLines_Color) of the minor and major grid lines can be customized by using the [`MajorGridLines`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_MajorGridLines) and [`MinorGridLines`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_MinorGridLines) properties in the axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/3d-chart/series/axis/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/3d-chart/series/axis/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple axis

In addition to primary X and Y axis, n number of axis can be added to the chart. Series can be associated with this axis, by mapping with axis's unique name.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/3d-chart/series/axis/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple.cs" %}
{% include code-snippet/3d-chart/series/axis/multiple/multiple.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Inversed axis

When an axis is inversed, highest value of the axis comes closer to origin and vice versa. To place an axis in inversed manner set the [`IsInversed`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_IsInversed) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/inversed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/3d-chart/series/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/inversed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inversed.cs" %}
{% include code-snippet/3d-chart/series/axis/inversed/inversed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Opposed position

To place an axis opposite from its original position, set [`OpposedPosition`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.Chart3DAxis.html#Syncfusion_EJ2_Charts_Chart3DAxis_OpposedPosition) property to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/opposed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/3d-chart/series/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/axis/opposed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opposed.cs" %}
{% include code-snippet/3d-chart/series/axis/opposed/opposed.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




