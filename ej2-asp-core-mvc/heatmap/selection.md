---
layout: post
title: Selection in Syncfusion ##Platform_Name## Heatmap Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Heatmap component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection in ##Platform_Name## HeatMap Component

In the HeatMap, the cell selection is used to select the single or multiple heat map cells at runtime and get the selected cell details using the [`cellSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~CellSelected.html) client-side event. You can enable this cell selection using the [`allowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMap~AllowSelection.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/cellSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/heatmap/selection/cellSelection/cellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/cellSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/heatmap/selection/cellSelection/cellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Enable single cell selection

{% if page.publishingplatform == "aspnet-core" %}

In the HeatMap, the [`enableMultiSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property is used to allow single cell selection. When you set the [`enableMultiSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property to false, only one cell is selected. By default, [`enableMultiSelect`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property is set to true.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/singleCellSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SingleCellSelection.cs" %}
{% include code-snippet/heatmap/selection/singleCellSelection/singleCellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the HeatMap, the [`enableMultiSelect`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property is used to allow single cell selection. When you set the [`enableMultiSelect`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property to false, only one cell is selected. By default, [`enableMultiSelect`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property is set to true.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/singleCellSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SingleCellSelection.cs" %}
{% include code-snippet/heatmap/selection/singleCellSelection/singleCellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

