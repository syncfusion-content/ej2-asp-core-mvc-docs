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

Data labels display the values of data points directly on the chart, reducing the need to reference axes for exact values. Enable data labels by setting the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) option to `true` in the `DataLabel` configuration. Labels automatically adjust to avoid overlapping and maintain readability.

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

Use the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartSeries.html#Syncfusion_EJ2_Charts_ChartSeries_Marker) property to place data labels at `Top`, `Middle`, `Bottom`, or `Outer` (applicable to column and bar series). Appropriate label positioning enhances clarity and preserves chart readability.

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



N> The position `Outer` is applicable for column and bar type series.

## Data Label Template

Customize label content using templates. Use placeholders such as `${point.x}` and `${point.y}` to display data point values. The [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html#Syncfusion_EJ2_Charts_ChartDataLabelSettings_Template) property enables fully customizable and visually rich labels.

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

Display custom text using the `Name` property, which maps label text from a specific field in the data source. This feature is useful for descriptive or category‑based labels.

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

Apply number or date formatting using the [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Charts.ChartDataLabelSettings.html#Syncfusion_EJ2_Charts_ChartDataLabelSettings_Format) property. Global formatting symbols include:

- `n` – number format  
- `p` – percentage format  
- `c` – currency format 

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
    <td>Rounded to 1 decimal place.</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>n2</td>
    <td>1000.00</td>
    <td>Rounded to 2 decimal places.</td>
  </tr>
   <tr>
    <td>1000</td>
    <td>n3</td>
    <td>1000.000</td>
    <td>Rounded to 3 decimal places.</td>
  </tr>
  <tr>
    <td>0.01</td>
    <td>p1</td>
    <td>1.0%</td>
    <td>Converted to percentage with 1 decimal place.</td>
  </tr>
  <tr>
    <td>0.01</td>
    <td>p2</td>
    <td>1.00%</td>
    <td>Converted to percentage with 2 decimal places.</td>
  </tr>
   <tr>
    <td>0.01</td>
    <td>p3</td>
    <td>1.000%</td>
    <td>Converted to percentage with 3 decimal places.</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>c1</td>
    <td>$1000.0</td>
    <td>Currency with 1 decimal place.</td>
  </tr>
   <tr>
    <td>1000</td>
    <td>c2</td>
    <td>$1000.00</td>
    <td>Currency with 2 decimal places.</td>
  </tr>
</table>

## Margin

Adjust spacing around labels using the `Margin` property, which includes `Left`, `Right`, `Bottom`, and `Top` values. Margins help prevent labels from overlapping chart elements.

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

Enhance label appearance using properties such as `Fill` (background), `Border`, and corner radius (`Rx`, `Ry`). Refine text appearance using the `Font` settings, which support `Color`, `FontFamily`, `FontWeight`, and `Size`.

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



N> The `Rx` and `Ry` properties require non‑null `Border` values.

## Customizing Specific Point

Customize individual markers or labels using the [`PointRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_PointRender) and [`TextRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.Chart.html#Syncfusion_EJ2_Charts_Chart_TextRender) events. 

- `PointRender` modifies shape, color, or border of a point.  
- `TextRender` customizes the label text for specific points.

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

Calculate and display percentage values based on each series’ total using the `SeriesRender` and `TextRender` events.  

- In `SeriesRender`, compute the total of `y` values.  
- In `TextRender`, calculate the percentage for each point and update the label text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/datalabels/series-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Series-percentage.cs" %}
{% include code-snippet/chart/datalabels/series-percentage/series-percentage.cs %}
{% endhighlight %}
{% endtabs %}
