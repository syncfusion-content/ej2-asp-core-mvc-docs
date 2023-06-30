---
layout: post
title: Selection in Syncfusion ##Platform_Name## HeatMap Chart Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## HeatMap Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection in ##Platform_Name## HeatMap Chart Component

{% if page.publishingplatform == "aspnet-core" %}

In the HeatMap, the cell selection is used to select single or multiple HeatMap cells at runtime and get the selected cell details using the [cellSelected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellSelected) event. You can enable the cell selection using the [allowSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_AllowSelection) property.

The HeatMap cells can be selected using the following interactions, as shown in the table below.

|   Modes of Interactions |   Description                                                                                                      |
|------------------------ | -------------------------------------------------------------------------------------------------------------------|
|   Mouse                 |  HeatMap cells can be selected by clicking or dragging and dropping over them.                                     |
|   Touch                 |  HeatMap cells can be selected by tapping or dragging and dropping over them.                                      |
|   Keyboard              |  The **Ctrl** key on the keyboard can be used to enable multiple cell selection with mouse and touch interaction. The **Ctrl** key can only be used if the `enableMultiSelect` property is set to **true** in order to enable multiple cell selection.                                                                                                                                     |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/cellSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/heatmap/selection/cellSelection/cellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the HeatMap, the cell selection is used to select single or multiple HeatMap cells at runtime and get the selected cell details using the [CellSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_CellSelected) event. You can enable the cell selection using the [AllowSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_AllowSelection) property.

The HeatMap cells can be selected using the following interactions, as shown in the table below.

|   Modes of Interactions |   Description                                                                                                      |
|------------------------ | -------------------------------------------------------------------------------------------------------------------|
|   Mouse                 |  HeatMap cells can be selected by clicking or dragging and dropping over them.                                     |
|   Touch                 |  HeatMap cells can be selected by tapping or dragging and dropping over them.                                      |
|   Keyboard              |  The **Ctrl** key on the keyboard can be used to enable multiple cell selection with mouse and touch interaction. The **Ctrl** key can only be used if the `EnableMultiSelect` property is set to **true** in order to enable multiple cell selection.                                                                                                                                     |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/cellSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/heatmap/selection/cellSelection/cellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatMap chart with selection](./images/selection/heatmap-chart-selection.gif)

The illustration below shows how to select multiple cells in the HeatMap by clicking and dragging the mouse across the cells.

![ASP.NET Core HeatMap chart with multiple selection](./images/selection/heatmap-chart-multiple-selection.gif)

## Enable single cell selection

{% if page.publishingplatform == "aspnet-core" %}

In the HeatMap, the [enableMultiSelect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property is used to allow single cell selection. When you set the `enableMultiSelect` property to **false**, only one cell is selected. By default, `enableMultiSelect` property is set to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/singleCellSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SingleCellSelection.cs" %}
{% include code-snippet/heatmap/selection/singleCellSelection/singleCellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

In the HeatMap, the [EnableMultiSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.HeatMap.HeatMap.html#Syncfusion_EJ2_HeatMap_HeatMap_EnableMultiSelect) property is used to allow single cell selection. When you set the `EnableMultiSelect` property to **false**, only one cell is selected. By default, `EnableMultiSelect` property is set to **true**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/singleCellSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SingleCellSelection.cs" %}
{% include code-snippet/heatmap/selection/singleCellSelection/singleCellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatMap chart with single cell selection](./images/selection/heatmap-chart-single-cell-selection.gif)

### Clearing cell selection

The `clearSelection` method can be used to clear all the selected cells. The below example illustrates the same.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/clear-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ClearSelection.cs" %}
{% include code-snippet/heatmap/selection/clear-selection/clear-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/selection/clear-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClearSelection.cs" %}
{% include code-snippet/heatmap/selection/clear-selection/clear-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core HeatMap chart with clearSelection method](./images/selection/heatmap-chart-clear-selection.gif)
