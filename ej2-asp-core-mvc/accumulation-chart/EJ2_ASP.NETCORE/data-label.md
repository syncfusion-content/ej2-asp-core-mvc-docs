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

Data label can be added to a chart series by enabling the [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Visible) option in the dataLabel property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

## Positioning

Accumulation chart provides support for placing the data label either `inside` or `outside` the chart.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

## Smart labels

Data labels will be arranged smartly without overlapping with each other. You can enable or disable this feature using the [`enableSmartLabels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_EnableSmartLabels) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

## Data Label Template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text `${point.x}` and `${point.y}` to display corresponding data points x & y value. Using [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Template) property, you can set data label template in chart.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

## Connector Line

Connector line will be visible when the data label is placed `outside` the chart. The connector line can be customized using the `type`, `color`, `width`, `length` and `dashArray` properties.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}


## Text Mapping

Text from the data source can be mapped to data label using `name` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}


## Format

Data label for the accumulation chart can be formatted using [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Format) property. You can use the global formatting options, such as 'n', 'p', and 'c'.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
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

Individual text can be customized using the `textRender` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

## Text wrap

When the data label text exceeds the container, the text can be wrapped by using [`textWrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_TextWrap) property. End user can also wrap the data label text based on [`maxWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_MaxWidth) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/textwrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string x;
    public double y;
    public string text;
    public string tooltipMappingName;
}
{% endhighlight %}
{% endtabs %}

## Show percentages in data labels of pie chart

You can show the percentages in data labels of pie chart using `textRender` event and `template` option.

### Using textRender event

You can customize the data label of pie chart using [TextRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_TextRender) event as follows to show percentage.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

### Using template

You can display the percentage values in data label of pie chart using `template` option.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template-percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}
{% endhighlight %}
{% endtabs %}

![Show percentage in ASP.NET Core Accumulationchart control](images/show-percentage-in-pie-chart.png)
