---
layout: post
title: Cell Selection in ##Platform_Name## Gantt Component
description: Learn here all about Cell Selection in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Cell selection

You can select a cell in the Gantt control by setting the [`selectionSettings.mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttSelectionSettings) property to cell. You can get the selected cell information using the `getSelectedRowCellIndexes` method. This method returns the result as an object collection, which has `cellIndexes` and `rowIndex` information of the selected cells.

Find the code example below to enable the cell selection in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/cellSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/gantt/selection/cellSelection/cellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/cellSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/gantt/selection/cellSelection/cellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Selecting multiple cells

You can select multiple cells by setting the [`SelectionSettings.Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_SelectionSettings) property to `Multiple`. You can select more than one cell by holding down the CTRL key while selecting multiple cells. The following code example explains how to enable multiple selection in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/multipleCellSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleCellSelection.cs" %}
{% include code-snippet/gantt/selection/multipleCellSelection/multipleCellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/multipleCellSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleCellSelection.cs" %}
{% include code-snippet/gantt/selection/multipleCellSelection/multipleCellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Selecting a cell dynamically

You can select a cell dynamically using the `selectCell` method. Refer to the following code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/selectCell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectCell.cs" %}
{% include code-snippet/gantt/selection/selectCell/selectCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/selectCell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectCell.cs" %}
{% include code-snippet/gantt/selection/selectCell/selectCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customize cell selection action

While selecting a cell in Gantt, the [`cellSelecting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_CellSelecting) and [`cellSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_CellSelected) event will be triggered. The [`cellSelecting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_CellSelecting) event will be triggered on initialization of cell selection action, and you can get the current selecting cell information to prevent the selection of a particular cell in a particular row. The [`cellSelected`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_CellSelected) event will be triggered on completion of cell selection action, and you can get the current selected cell’s information. The following code example demonstrates how to prevent the selection of the cell using the [`cellSelecting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_CellSelecting) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/cellSelectingEvent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelectingEvent.cs" %}
{% include code-snippet/gantt/selection/cellSelectingEvent/cellSelectingEvent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/cellSelectingEvent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelectingEvent.cs" %}
{% include code-snippet/gantt/selection/cellSelectingEvent/cellSelectingEvent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}