---
layout: post
title: Data Labels in ##Platform_Name## Chart Component
description: Learn here all about Data Labels in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Data Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Labels

Data label can be added to a chart series by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker)
option in the dataLabel. By default, the labels will arrange smartly without overlapping.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/datalabel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datalabel.cs" %}
{% include code-snippet/chart/datalabels/datalabel/datalabel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/datalabel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datalabel.cs" %}
{% include code-snippet/chart/datalabels/datalabel/datalabel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Position

Using [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) property, you can place the label either on
`Top`, `Middle`,`Bottom` or `Outer` (outer is applicable for column and bar type series).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/datalabels/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/datalabels/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The position `Outer` is applicable for column and bar type series.

## Datalabel template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text
`${point.x}` and `${point.y}` to display corresponding data points x & y value.
Using [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html#Syncfusion_EJ2_Charts_ChartDataLabelSettings_Template) property, you can set data label template
in chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/datalabels/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/datalabels/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Text Mapping

Text from the data source can be mapped using `name` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mapping.cs" %}
{% include code-snippet/chart/datalabels/mapping/mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mapping.cs" %}
{% include code-snippet/chart/datalabels/mapping/mapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Margin

`margin` for data label can be applied to using `left`, `right`, `bottom` and `top` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/chart/datalabels/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/chart/datalabels/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

`stroke` and `border` of data label can be customized using `fill` and `border` properties. Rounded corners
can be customized using `rx` and `ry` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/datalabels/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/datalabels/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> `rx` and `ry` properties requires `border` values not to be null.

## Customizing Specific Point

You can also customize the specific marker and label using
[`pointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and
[`textRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) event.
 `pointRender` event allows you to change the shape, color and border for a point, whereas the `textRender` event
allows you to change the text for the point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/custom-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-point.cs" %}
{% include code-snippet/chart/datalabels/custom-point/custom-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/custom-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-point.cs" %}
{% include code-snippet/chart/datalabels/custom-point/custom-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

