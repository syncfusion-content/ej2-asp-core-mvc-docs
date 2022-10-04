---
layout: post
title: Data Labels in ##Platform_Name## Syncfusion Chart Component
description: Learn here all about Data Labels in Syncfusion ##Platform_Name## Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Labels in ##Platform_Name## Chart

Data label can be added to a chart series by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) option in the dataLabel. By default, the labels will arrange smartly without overlapping.

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

Using [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) property, you can place the label either on `Top`, `Middle`, `Bottom` or `Outer` (outer is applicable for column and bar type series).

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

## Data Label Template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text `${point.x}` and `${point.y}` to display corresponding data points x & y value. Using [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html#Syncfusion_EJ2_Charts_ChartDataLabelSettings_Template) property, you can set data label template in chart.

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

## Format

Data label for the chart can be formatted using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html#Syncfusion_EJ2_Charts_ChartDataLabelSettings_Format) property. You can use the global formatting options, such as 'n', 'p', and 'c'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/datalabels/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/datalabels/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

<table>
  <tr>
    <th>Value</th>
    <th>Format</th>
    <th>Resultant Value</th>
    <th>Description</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>n1</td>
    <td>1000.0</td>
    <td>The number is rounded to 1 decimal place.</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>n2</td>
    <td>1000.00</td>
    <td>The number is rounded to 2 decimal places.</td>
  </tr>
   <tr>
    <td>1000</td>
    <td>n3</td>
    <td>1000.000</td>
    <td>The number is rounded to 3 decimal place.</td>
  </tr>
  <tr>
    <td>0.01</td>
    <td>p1</td>
    <td>1.0%</td>
    <td>The number is converted to percentage with 1 decimal place.</td>
  </tr>
  <tr>
    <td>0.01</td>
    <td>p2</td>
    <td>1.00%</td>
    <td>The number is converted to percentage with 2 decimal place.</td>
  </tr>
   <tr>
    <td>0.01</td>
    <td>p3</td>
    <td>1.000%</td>
    <td>The number is converted to percentage with 3 decimal place.</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>c1</td>
    <td>$1000.0</td>
    <td>The currency symbol is appended to number and number is rounded to 1 decimal place.</td>
  </tr>
   <tr>
    <td>1000</td>
    <td>c2</td>
    <td>$1000.00</td>
    <td>The currency symbol is appended to number and number is rounded to 2 decimal place.</td>
  </tr>
</table>

## Margin

The `margin` for data label can be applied to use `left`, `right`, `bottom` and `top` properties.

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

The `stroke` and `border` of data label can be customized using `fill` and `border` properties. Rounded corners can be customized using `rx` and `ry` properties.

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

You can also customize the specific marker and label using [`pointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and [`textRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) event. The `pointRender` event allows to change the shape, color and border for a point, whereas the `textRender` event allows to change the text for the point.

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

## Show percentage based on each series points

You can calculate the percentage value based on the sum for each series using the `seriesRender` and `textRender` events in the chart. In `seriesRender` calculate the sum of each series y values and In `textRender` calculate percentage value based on the sum value and modify the text.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/series-percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-percentage.cs" %}
{% include code-snippet/chart/datalabels/series-percentage/series-percentage.cs %}
{% endhighlight %}
{% endtabs %}
