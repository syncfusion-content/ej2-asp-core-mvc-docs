---
layout: post
title: Pie Dough Nut in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Pie Dough Nut in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Pie Dough Nut
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pie & Doughnut

## Pie Chart

To render a pie series, use the series [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Type)
as `Pie`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/pie/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pie.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/pie/pie.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/pie/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pie.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/pie/pie.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Radius Customization

By default, radius of the pie series will be 80% of the size (minimum of chart width and height).
You can customize this using [`Radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Radius)
property of the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/radius/radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/radius/radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pie Center

The center position of the pie can be changed by Center X and Center Y. By default, center value of the pie series x and y is 50%. You can customize this using [`Center`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_Center) property of the series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/piecenter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Piecenter.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/piecenter/piecenter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/piecenter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Piecenter.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/piecenter/piecenter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Various Radius Pie Chart

You can use radius mapping to render the slice with different [`Radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Radius) pie and also use [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_Border) , fill properties to customize the point. dataLabel is used to represent individual data and its value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/various-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Various-radius.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/various-radius/various-radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/various-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Various-radius.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/various-radius/various-radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Doughnut Chart

To achieve a doughnut in pie series, customize the [`InnerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_InnerRadius)
property of the series. By setting value greater than 0%, a doughnut will appear.
The `InnerRadius` property takes value from 0% to 100% of the pie radius.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/doughnut/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Doughnut.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/doughnut/doughnut.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/doughnut/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Doughnut.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/doughnut/doughnut.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Start and End angles

You can customize the start and end angle of the pie series using the
[`StartAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_StartAngle) and
[`EndAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_EndAngle)
properties. The default value of  `StartAngle` is 0 degree, and `EndAngle` is 360 degrees. By customizing this,
you can achieve a semi pie series.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/start-angle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Start-angle.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/start-angle/start-angle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/start-angle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Start-angle.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/start-angle/start-angle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Color & Text Mapping

The fill color and the text in the data source can be mapped to the chart using `PointColorMapping` in series and
`Name` in datalabel respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/map/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Map.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/map/map.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/map/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Map.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/map/map.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Individual points can be customized using the `PointRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hide pie or doughnut border

By default, the border will appear in the pie/doughnut chart while mouse hover on the chart. You can disable the the border by
setting `EnableBorderOnMouseMove` property is `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Color Palette

You can customize the color the of the point using the `Palettes` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/palette/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/palette/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Palette.cs" %}
{% include code-snippet/chart/accumulation-charts/pie-doughnut/palette/palette.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Data label](./data-label/)
* [Grouping](./grouping/)