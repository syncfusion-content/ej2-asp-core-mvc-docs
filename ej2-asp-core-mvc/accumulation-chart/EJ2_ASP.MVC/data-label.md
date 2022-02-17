---
layout: post
title: Data Label in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Data Label in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Data Label
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Label

Data label can be added to a chart series by enabling the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Visible)
option in the dataLabel property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Positioning

Accumulation chart provides support for placing the data label either `Inside` or `Outside` the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Smart Labels

Datalabels will be arranged smartly without overlapping with each other. You can enable or disable this feature using
the [`EnableSmartLabels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_EnableSmartLabels)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Smartlabels.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/smartlabels.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Smartlabels.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/smartlabels/smartlabels.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data Label Template

Label content can be formatted by using the template option. Inside the template, you can add the placeholder text
`${point.x}` and `${point.y}` to display corresponding data points x & y value. Using
[`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationDataLabelSettings.html#Syncfusion_EJ2_Charts_AccumulationDataLabelSettings_Template)
property, you can set data label template in chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Connector Line

Connector line will be visible when the data label is placed `Outside` the chart.
The connector line can be customized using the `Type`, `Color`, `Width`, `Length` and `DashArray` properties

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/connector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/connector/connector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Text Mapping

Text from the data source can be mapped to data label using `Name` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Map.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/map.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Map.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/map/map.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

Individual text can be customized using the `TextRender` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/chart/accumulation-charts/datalabel/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

