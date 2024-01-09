---
layout: post
title: Data labels in ##Platform_Name## Syncfusion 3D Chart Component
description: Learn here all about data labels in Syncfusion ##Platform_Name## 3D Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data labels in ##Platform_Name## 3D Chart Component

Data labels are fields that includes information about the sample point connected to an output.

Data label can be added to a chart series by enabling the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Visible) option in the dataLabel. By default, the labels will arrange smartly without overlapping.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/datalabel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datalabel.cs" %}
{% include code-snippet/3d-chart/series/datalabel/datalabel/datalabel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/datalabel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datalabel.cs" %}
{% include code-snippet/3d-chart/series/datalabel/datalabel/datalabel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Position

The [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Position) property is used to place the label either on `Top`, `Middle`, or `Bottom`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/3d-chart/series/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/3d-chart/series/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template

Label content can be formatted by using the template option. Inside the template, the placeholder text `${point.x}` and `${point.y}` can be added to display corresponding data points x & y value. Using [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Template) property, the data label template can be set.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/3d-chart/series/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/3d-chart/series/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Text mapping

Text from the data source can be mapped using [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Name) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/mapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mapping.cs" %}
{% include code-snippet/3d-chart/series/datalabel/mapping/mapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/mapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mapping.cs" %}
{% include code-snippet/3d-chart/series/datalabel/mapping/mapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Format

Data label for the chart can be formatted using [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Format) property. The global formatting options can be used as 'n', 'p', and 'c'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/3d-chart/series/datalabel/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/3d-chart/series/datalabel/format/format.cs %}
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

[`Margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Margin) for data label can be applied by using [`Left`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DMargin.html#Syncfusion_EJ2_Charts_Chart3DMargin_Left), [`Right`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DMargin.html#Syncfusion_EJ2_Charts_Chart3DMargin_Right), [`Bottom`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DMargin.html#Syncfusion_EJ2_Charts_Chart3DMargin_Bottom) and [`Top`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DMargin.html#Syncfusion_EJ2_Charts_Chart3DMargin_Top) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/margin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/3d-chart/series/datalabel/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/margin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Margin.cs" %}
{% include code-snippet/3d-chart/series/datalabel/margin/margin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The `Stroke` and `Border` of data label can be customized using [`Fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3DDataLabelSettings.html#Syncfusion_EJ2_Charts_Chart3DDataLabelSettings_Border) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/3d-chart/series/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing specific point

Specific label can be customized by using [`TextRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart3D.html#Syncfusion_EJ2_Charts_Chart3D_TextRender) event.  The `TextRender` event allows you to change the text for the point.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/series-percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Series-percentage.cs" %}
{% include code-snippet/3d-chart/series/datalabel/series-percentage/series-percentage.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/3d-chart/series/datalabel/series-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-percentage.cs" %}
{% include code-snippet/3d-chart/series/datalabel/series-percentage/series-percentage.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


