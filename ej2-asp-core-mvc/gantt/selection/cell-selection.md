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

## Toggle selection

The toggle selection allows you to select and deselect a specific row or cell. To enable toggle selection, set the `enableToggle` property of the selectionSettings to `true`. If you click the selected row or cell, then it will be deselected and vice versa. By default, the `enableToggle` property is set to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/toggleselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/gantt/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/toggleselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/gantt/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Clear selection

You can clear the selected cells and selected rows by using a method called `clearSelection`. The following code example demonstrates how to clear the selected rows in Gantt Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/clearselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clearselection.cs" %}
{% include code-snippet/gantt/selection/clearselection/clearselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/clearselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clearselection.cs" %}
{% include code-snippet/gantt/selection/clearselection/clearselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Get selected row indexes and records

You can get the selected row indexes by using the [`getSelectedRowIndexes`](../api/gantt/#getselectedrowindexes) method. And by using [`getSelectedRecords`](../api/gantt/#getSelectedRecords) method, you can get the selected record details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GetSelectedRowIndex.cs" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/getSelectedRowIndex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GetSelectedRowIndex.cs" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/getSelectedRowIndex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Selection based on condition

You can select multiple rows based on condition by using the [`selectRows`](../api/grid/#selectrows) method.

In the following code, the rows which contains `TaskId` value as 3 and 4 are selected at initial rendering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/conditionalSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ConditionalSelection.cs" %}
{% include code-snippet/gantt/selection/conditionalSelection/conditionalSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/conditionalSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ConditionalSelection.cs" %}
{% include code-snippet/gantt/selection/conditionalSelection/conditionalSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/conditionalSelection.png)

## See Also

* [Touch interaction](./touch-interaction/#selection)