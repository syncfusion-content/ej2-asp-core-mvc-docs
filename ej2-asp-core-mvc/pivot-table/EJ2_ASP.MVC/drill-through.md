---
layout: post
title: Drill Through in ##Platform_Name## Pivot Table Component
description: Learn here all about Drill Through in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Drill Through
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD012 -->

# Drill Through

Allows to view the underlying raw data of a summarized cell in the pivot table. It can be enabled by setting the [`AllowDrillThrough`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDrillThrough) property to **true**. By double-clicking on any value cell, user can view the detailed raw data in a data grid inside a new window. In the new window, row header, column header and measure name of the clicked cell will be shown at the top. Also, user can include or exclude fields available in the data grid using column chooser option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThrough.cs" %}
{% include code-snippet/pivot-table/drill-through/DrillThrough.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThrough.cs" %}
{% include code-snippet/pivot-table/drill-through/DrillThrough.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/drillthrough-before.png)
<br/>
<br/>
![output](images/drillthrough-after.png)

Users can also view the underlying raw data though the pivot chart. By clicking on any data point, user can view the detailed raw data in a data grid inside a new window.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through-chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThroughChart.cs" %}
{% include code-snippet/pivot-table/drill-through-chart/DrillThroughChart.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through-chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThroughChart.cs" %}
{% include code-snippet/pivot-table/drill-through-chart/DrillThroughChart.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/drillthrough-chart-before.png)
<br/>
<br/>
![output](images/drillthrough-chart-after.png)

## Maximum rows to retrieve

> This property is applicable only for OLAP data sources.

The [`MaxRowsInDrillThrough`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MaxRowsInDrillThrough) property allows to specify the maximum number of raw data to be returned during the drill through process. By default, this property is set to **"10000"** meaning that if you do not specify this property, you will get 10,000 or less raw data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-drill-through/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drill-through.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-drill-through/drill-through.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-drill-through/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drill-through.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/olap-drill-through/drill-through.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/maxrows.png)

## Events

### DrillThrough

The event `DrillThrough` triggers every time before a value cell is double clicked. This event allows user to customize the data grid columns in drill through popup. Exclusively the event helps to view and process the raw data information behind a aggregated value inside value cell. It has the following parameters:

* `columnHeaders` - It holds column header of the current cell.
* `currentCell` - It holds the current cell's information.
* `currentTarget` - It holds current cell's html element.
* `gridColumns` - It holds data grid columns to be rendered in drill through popup.
* `rawData` - It holds current cell's raw data.
* `rowHeaders` - It holds row header of current cell.
* `value` - It holds value of current cell.
* `cancel` - It is a boolean property and by setting this to true, dialog won’t be created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThroughEvent.cs" %}
{% include code-snippet/pivot-table/drill-through-event/DrillThroughEvent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/drill-through-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DrillThroughEvent.cs" %}
{% include code-snippet/pivot-table/drill-through-event/DrillThroughEvent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### BeginDrillThrough

The event `BeginDrillThrough` occurs for each and every value cell with a double click, and the event argument provides the data grid information before the drill-through popup is shown. User can access the data grid (which holds the raw data underneath the aggregated value cell) options such as sort, group, filter and customize those in the data grid. It has the following parameters:

* `gridObj` - It holds the data grid instance to be rendered inside the drill-through popup.
* `cellInfo` - It holds current cell information like raw data, row header, column header and value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomEditing.cs" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/CustomEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomEditing.cs" %}
{% include code-snippet/pivot-table/custom-editing/custom-editing/CustomEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

