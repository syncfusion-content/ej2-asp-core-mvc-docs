---
layout: post
title: TreeGrid View Rows in ##Platform_Name## Gantt Component | Syncfusion
description: Learn here all about customization of treegrid view rows in Syncfusion ##Platform_Name## Gantt component and much more.
platform: ej2-asp-core-mvc
control: Rows
publishingplatform: ##Platform_Name##
documentation: ug
---


# Rows in ##Platform_Name## Gantt Component

Row represents a task information from the data source, and it is possible to perform the following actions in Gantt rows.

## Row height

It is possible to change the height of the row in Gantt by setting row height in pixels to the [`RowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowHeight.html) property. The following code example explains how to change the row height in Gantt at load time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/rowHeight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/gantt/rows/rowHeight/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/rowHeight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/gantt/rows/rowHeight/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/rowHeight.png)

## Expand/Collapse row

In Gantt parent tasks are expanded/collapsed by using expand/collapse icons, expand all/collapse all toolbar items and by using public methods. By default all tasks in Gantt was rendered in expanded state but we can change this status in Gantt.

### Collapse all tasks at gantt chart load

All tasks available in Gantt was rendered in collapsed state by setting [`CollapseAllParentTasks`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~CollapseAllParentTasks.html) property as `true`. The following code example shows how to use this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/enableCollapseAll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableCollapseAll.cs" %}
{% include code-snippet/gantt/rows/enableCollapseAll/enableCollapseAll.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/enableCollapseAll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableCollapseAll.cs" %}
{% include code-snippet/gantt/rows/enableCollapseAll/enableCollapseAll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/enableCollapseAll.png)

### Define expand/collapse status of tasks

In Gantt, we can render some tasks in collapsed state and some tasks in expanded state, this can done by defining expand status of the task in data source. This value was mapped to Gantt control by using [`ExpandState`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttTaskFields~ExpandState.html) property. The following code example shows how to use this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/expandState/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandState.cs" %}
{% include code-snippet/gantt/rows/expandState/expandState.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/expandState/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandState.cs" %}
{% include code-snippet/gantt/rows/expandState/expandState.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/expandState.png)

### Customize expand/collapse action

On expand action [`Expanding`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~Expanding.html) and [`Expanded`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~Expanded.html) event will be triggered with current expanding row’s information. Similarly on collapse action [`Collapsing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~Collapsing.html) and [`Collapsed`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~Collapsed.html) event will be triggered. Using this events and it’s arguments we can customize the expand/collapse action. The following code example shows how to prevent the particular row from expand/collapse action using [`Expanding`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~Expanding.html) and [`Collapsing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~Collapsing.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/expandCollapseEvent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandCollapseEvent.cs" %}
{% include code-snippet/gantt/rows/expandCollapseEvent/expandCollapseEvent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/expandCollapseEvent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandCollapseEvent.cs" %}
{% include code-snippet/gantt/rows/expandCollapseEvent/expandCollapseEvent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Customize rows

You can customize the appearance of a row in grid side, by using the [`rowDataBound`](../api/gantt/#rowdatabound) event and in chart side by using [`queryTaskbarInfo`](../api/gantt/#querytaskbarinfo) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/customizeRows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRows.cs" %}
{% include code-snippet/gantt/rows/customizeRows/customizeRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/customizeRows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRows.cs" %}
{% include code-snippet/gantt/rows/customizeRows/customizeRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/customizeRows.png)

## Styling alternate rows

You can change the background colour of alternative rows in Gantt chart, by overriding the class as shown below.

```css
.e-altrow, tr.e-chart-row:nth-child(even)  {
    background-color: #f2f2f2;
}
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/styleAlternateRows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="StyleAlternateRows.cs" %}
{% include code-snippet/gantt/rows/styleAlternateRows/styleAlternateRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/styleAlternateRows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="StyleAlternateRows.cs" %}
{% include code-snippet/gantt/rows/styleAlternateRows/styleAlternateRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/alternateRows.png)

## Row spanning

Gantt chart has an option to span row cells. You can achieve this using [`rowSpan`](../api/gantt/queryCellInfoEventArgs/#rowspan) attribute to span cells in the [`QueryCellInfo`](../api/gantt/queryCellInfoEventArgs) event.

In the following demo, **Soil test approval** cell is spanned to two rows in the **TaskName** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/rowSpanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowSpanning.cs" %}
{% include code-snippet/gantt/rows/rowSpanning/rowSpanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/rows/rowSpanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowSpanning.cs" %}
{% include code-snippet/gantt/rows/rowSpanning/rowSpanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/rowSpanning.png)

## Customize rows and cells

While rendering the TreeGrid part in Gantt, the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_RowDataBound) and [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryCellInfo) events trigger for every row and cell. Using these events, you can customize the rows and cells. The following code example shows how to customize the cell and row elements using these events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/customizeRow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRow.cs" %}
{% include code-snippet/gantt/appearance-and-styling/customizeRow/customizeRow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/appearance-and-styling/customizeRow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRow.cs" %}
{% include code-snippet/gantt/appearance-and-styling/customizeRow/customizeRow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/customizeRow.png)

## Clip mode

The clip mode provides options to display its overflow cell content and it can be defined by the [`Columns.ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ClipMode) property.

The following are three types of `ClipMode`:

* `Clip`: Truncates the cell content when it overflows its area.
* `Ellipsis`: Displays ellipsis when content of the cell overflows its area.
* `EllipsisWithTooltip`: Displays ellipsis when content of the cell overflows its area; it displays the tooltip content when hover over ellipsis.

N> By default, all the column's [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ClipMode) property is defined as `EllipsisWithTooltip`.

### Cell tooltip

You can enable or disable the Grid cell tooltip using the [`Columns.ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ClipMode) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GridcellTooltip.cs" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/gridcellTooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GridcellTooltip.cs" %}
{% include code-snippet/gantt/tooltip/gridcellTooltip/gridcellTooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
