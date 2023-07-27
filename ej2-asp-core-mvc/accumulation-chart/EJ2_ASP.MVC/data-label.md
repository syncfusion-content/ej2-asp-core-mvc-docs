---
layout: post
title: Data Label in Syncfusion ##Platform_Name## Accumulation Chart
description: Learn here all about Data Label in Syncfusion ##Platform_Name## Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Label in ##Platform_Name## Accumulation Chart Component

Data label can be added to a chart series by enabling the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Visible) option in the dataLabel property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/default.cs %}
{% endhighlight %}
{% endtabs %}

## Positioning

Accumulation chart provides support for placing the data label either `Inside` or `Outside` the chart.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}

## Smart labels

Data labels will be arranged smartly without overlapping with each other. You can enable or disable this feature using the [`EnableSmartLabels`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_EnableSmartLabels) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Smartlabels.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/smartlabels.cs %}
{% endhighlight %}
{% endtabs %}

## Data Label Template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text `${point.x}` and `${point.y}` to display corresponding data points x & y value. Using [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Template) property, you can set data label template in chart.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}

## Connector Line

Connector line will be visible when the data label is placed `Outside` the chart. The connector line can be customized using the `Type`, `Color`, `Width`, `Length` and `DashArray` properties.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/connector.cs %}
{% endhighlight %}
{% endtabs %}

## Text Mapping

Text from the data source can be mapped to data label using `Name` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Map.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/map.cs %}
{% endhighlight %}
{% endtabs %}

## Format

Data label for the accumulation chart can be formatted using [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Format) property. You can use the global formatting options, such as 'n', 'p', and 'c'.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}

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
## Customization

Individual text can be customized using the `TextRender` event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

## Text wrap

When the data label text exceeds the container, the text can be wrapped by using ['textWrap'](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_TextWrap) property. End user can also wrap the data label text based on ['maxWidth'](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_MaxWidth) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/textwrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textwrap.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/textwrap/textwrap.cs %}
{% endhighlight %}
{% endtabs %}


## Show percentages in data labels of pie chart

You can show the percentages in data labels of pie chart using `textRender` event and `template` option.

### Using textRender event

You can customize the data label of pie chart using [TextRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_TextRender) event as follows to show percentage.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

### Using template

You can display the percentage values in data label of pie chart using `template` option.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template-percentage.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template-percentage/template-percentage.cs %}
{% endhighlight %}
{% endtabs %}

![Show percentage in ASP.NET Core Accumulationchart control](images/show-percentage-in-pie-chart.png)

