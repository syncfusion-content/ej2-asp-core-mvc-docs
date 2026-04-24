---
layout: post
title: Drill Through in ##Platform_Name## Syncfusion Pivot Table
description: Learn here all about Drill Through in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Drill Through
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD012 -->

# Drill through in ##Platform_Name## Pivot Table component

The drill-through feature in the Pivot Table component allows users to view the raw, unaggregated data behind any aggregated cell in the Pivot Table. To enable this feature, set the [`AllowDrillThrough`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowDrillThrough) property to **true**. By double-clicking an aggregated cell, users can view its detailed raw data in a data grid displayed in a new window. The new window shows the row header, column header, and measure name of the selected cell at the top. Additionally, users can include or exclude fields available in the data grid using the column chooser option.

To use the drill-through feature, inject the `DrillThrough` module in the Pivot Table.

Below is an example of enabling drill-through in a Pivot Table:

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



![Pivot Table drill-through before interaction](images/drillthrough-before.png)
<br/>
<br/>
![Pivot Table drill-through after interaction](images/drillthrough-after.png)

Users can also access drill-through data through the pivot chart. By clicking on any data point in the pivot chart, they can view the raw data in a data grid displayed in a new window.

Below is an example of enabling drill-through with a pivot chart:

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



![Pivot chart drill-through before interaction](images/drillthrough-chart-before.png)
<br/>
<br/>
![Pivot chart drill-through after interaction](images/drillthrough-chart-after.png)

## Maximum rows to retrieve

> This property is applicable only for the OLAP data source.

The [`MaxRowsInDrillThrough`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_MaxRowsInDrillThrough) property specifies the maximum number of rows to be returned during a drill-through operation. By default, this property is set to **"10000"**, meaning that if it is not explicitly defined, up to 10,000 rows will be returned.

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



![Maximum rows drill-through](images/maxrows.png)

## Events

### DrillThrough

The [`DrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DrillThrough) event is triggered immediately after a user double-clicks a value cell in the Pivot Table. This event allows users to customize the columns displayed in the drill-through popup's data grid. It is specifically designed to help users view and process the raw data behind an aggregated value in a value cell. The event includes the following parameters:

- `columnHeaders`: Contains the column header of the clicked cell.
- `currentCell`: Contains details about the clicked cell.
- `currentTarget`: Contains the HTML element of the clicked cell.
- `gridColumns`: Specifies the data grid columns to be displayed in the drill-through popup.
- `rawData`: Contains the raw, unaggregated data for the clicked cell.
- `rowHeaders`: Contains the row header of the clicked cell.
- `value`: Contains the value of the clicked cell.
- `cancel`: It is a boolean property and by setting this to **true**, dialog won’t be created.

Below is an example of using the [`DrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DrillThrough) event in a Pivot Table:

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

The event [`BeginDrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeginDrillThrough) triggers after a double-click on a value cell in the Pivot Table and fires right after the data grid is initialized in the drill-through popup. This event allows users to interact with the data grid, which displays the raw data behind the aggregated value cell. Users can perform operations such as `sorting`, `grouping`, and `filtering` within the data grid according to their specific needs. The event includes the following parameters:

* `gridObj` - It holds the data grid instance to be rendered inside the drill-through popup.
* `cellInfo` - Gives details about the clicked cell, including rawData (unaggregated data), rowHeaders, columnHeaders, and value.

The following example demonstrates how to enable `sorting`, `filtering`, and `grouping` in the data grid displayed within the drill-through popup. This is achieved by configuring the `gridObj` in the [`BeginDrillThrough`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_BeginDrillThrough) event.

> `Grid` features are segregated into individual feature-wise modules. For example, to use `sorting` feature, you should inject `Sort` using the `Grid.Inject(Sort)` section.

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

