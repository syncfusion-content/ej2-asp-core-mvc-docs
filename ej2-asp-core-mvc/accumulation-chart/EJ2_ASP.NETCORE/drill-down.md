---
layout: post
title: Drill down in Syncfusion ##Platform_Name## Accumulation Chart
description: Learn here all about Drill down in Syncfusion ##Platform_Name## Accumulation Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drill down
publishingplatform: ##Platform_Name##
documentation: ug
---

# Multilevel pie chart drill-down and display corresponding data in Grid

You can achieve multilevel drill-down in pie chart and display corresponsding data in Grid by using chart's [pointClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_PointClick) and [chartMouseClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationChart.html#Syncfusion_EJ2_Charts_AccumulationChart_ChartMouseClick) events.

Pie chart drill-down can be achieved by processing corresponding nested data using `pointClick` event and You can drill up by using `chartMouseClick` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/accumulation-charts/drill-down/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drill-down.cs" %}
{% include code-snippet/chart/accumulation-charts/drill-down/drill-down.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC AccumulationChart Drill-Down and Display Data in Grid](../images/pie-drill-down-and-display-data-in-grid.gif)