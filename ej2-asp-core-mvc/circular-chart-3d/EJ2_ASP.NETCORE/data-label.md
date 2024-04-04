---
layout: post
title: Data Label in Syncfusion ##Platform_Name## 3D Circular Chart Component
description: Learn here all about data label in Syncfusion ##Platform_Name## 3D Circular Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Label in ##Platform_Name## 3D Circular Chart Component

A data label refers to a label associated with specific data points. It can be added to a 3D Circular Chart series by enabling the `Visible` option in the `DataLabel` property. By default, the labels will arrange themselves smartly to avoid overlapping.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/datalabel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datalabel.cs" %}
{% include code-snippet/circular-chart/datalabel/datalabel/datalabel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/datalabel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datalabel.cs" %}
{% include code-snippet/circular-chart/datalabel/datalabel/datalabel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Positioning

Using the `Position` property, we can place the data label either `Inside` or `Outside` the 3D Circular Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circular-chart/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/circular-chart/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Data label template

The label content can be formatted using the template option. Inside the template, placeholder text `${point.x}` and `${point.y` can be added to display the corresponding data point's x & y value. The data label template can be set using the `Template` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/circular-chart/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/circular-chart/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Connector line

The connector line will be visible when the data label is placed `Outside` the chart. It can be customized using properties such as `Color`, `Width`, `Length`, and `DashArray` within the `ConnectorStyle` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/connector-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connector-line.cs" %}
{% include code-snippet/circular-chart/datalabel/connector-line/connector-line.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/connector-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Connector-line.cs" %}
{% include code-snippet/circular-chart/datalabel/connector-line/connector-line.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Text mapping

Text from the data source can be mapped using the `Name` property within the data label.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/text-mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-mapping.cs" %}
{% include code-snippet/circular-chart/datalabel/text-mapping/text-mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/text-mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-mapping.cs" %}
{% include code-snippet/circular-chart/datalabel/text-mapping/text-mapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Format

The data label for the 3D Circular Chart can be formatted using the `Format` property. You can utilize global formatting options such as 'n', 'p', and 'c'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/circular-chart/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/circular-chart/datalabel/format/format.cs %}
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

## Customization

Individual text for the data points in the 3D Circular Chart can be customized using the `TextRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/circular-chart/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/circular-chart/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Using textRender event

You can customize the data label of a pie chart using the `TextRender` event as follows to show the percentage.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/text-render/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-render.cs" %}
{% include code-snippet/circular-chart/datalabel/text-render/text-render.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/text-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-render.cs" %}
{% include code-snippet/circular-chart/datalabel/text-render/text-render.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Using template

You can display the percentage values in the data label of a pie chart using the `Template` option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/circular-chart/datalabel/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circular-chart/datalabel/percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Percentage.cs" %}
{% include code-snippet/circular-chart/datalabel/percentage/percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


