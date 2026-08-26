---
layout: post
title: Pivot Chart in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how to visualize Pivot Table data in ASP.NET MVC using Pivot Charts with multiple chart types, drill-down, and export.
platform: ej2-asp-core-mvc
control: Pivot Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# Pivot Chart in ASP.NET MVC Pivot Table

The Pivot Chart in the Syncfusion ASP.NET MVC Pivot Table component visualizes aggregated values in a graphical format. It provides essential options like drill down and drill up operations, 21 chart types, and various display settings for series, axes, legends, export, print, and tooltips. The main purpose of the Pivot Chart is to present Pivot Table data in a way that is easy to understand and interact with.

Users can display the pivot chart component individually with pivot values and modify the report dynamically using the field list and grouping bar. The [`PivotViewDisplayOption`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property in the Pivot Table allows users to control the visibility of both the grid and chart components. This property includes the following options:

* [`View`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_View): Determines whether the Pivot Table component displays only the grid, only the chart, or both components.
* [`Primary`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_Primary): Specifies which component (grid or chart) appears as the primary view during initial loading. This option applies only when the [`View`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_View) property is set to **Both**.

The following sample shows the pivot chart component based on the pivot report bound to it.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/display-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayView.cs" %}
{% include code-snippet/pivot-table/pivot-chart/display-view/DisplayView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/display-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisplayView.cs" %}
{% include code-snippet/pivot-table/pivot-chart/display-view/DisplayView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Data Binding

The Pivot Table component supports both local and remote data binding options to populate data in the pivot chart. Users can bind data to the component using the [`DataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_DataSource) property, which accepts either an instance of `DataManager` for remote data sources or a JavaScript object array collection for local data. For further details, [refer here](./data-binding).

## Chart Types

The Pivot Chart offers 21 different chart types. You can choose any of these chart types based on your needs:

- Line
- Column
- Area
- Bar
- StepArea
- StackingLine
- StackingColumn
- StackingArea
- StackingBar
- StepLine
- Pareto
- Bubble
- Scatter
- Spline
- SplineArea
- StackingLine100
- StackingColumn100
- StackingBar100
- StackingArea100
- Polar
- Radar

By default, the [**ChartSeriesType.Line**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.ChartSeriesType.html) chart type is displayed in the Pivot Chart. Users can change the chart type at any time using the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_Type) property under [`PivotChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html).

For example, to display a [**ChartSeriesType.Bar**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.ChartSeriesType.html) chart, set the chart type to 'Bar' within the Pivot Chart settings. Review the following code samples to see how to set this option:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartType.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-type/ChartType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-type/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartType.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-type/ChartType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart type example](images/charttype.png)

## Accumulation Charts

Pivot Chart supports four types of accumulation charts:

- Pie
- Doughnut
- Funnel
- Pyramid

You can use any of these chart types to visualize your aggregated data clearly. To select a specific accumulation chart, set the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_Type) property in the [`PivotChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) option:

In the code example below, the **Pie** chart is displayed by default. You can switch to other accumulation chart types, such as Doughnut, Funnel, or Pyramid, using the dropdown list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-accumulation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accumulation.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-accumulation/Accumulation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-accumulation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accumulation.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-accumulation/Accumulation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Accumulation chart example](images/accumulation.png)

### Drill down and up

In accumulation charts, you can use the drill down and drill up options to explore data at different levels. When you click on a chart series, a built-in context menu appears with the following options:

- **Expand**: Drill down to view more detailed data for the selected series, until the lowest level is reached.
- **Collapse**: Drill up to view higher-level, summarized information for that series, returning to the top level as needed.
- **Exit**: Close the context menu without making any changes.


> You can use the drill operation for row headers only in accumulation charts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-drill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drill.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-drill/Drill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-drill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drill.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-drill/Drill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Accumulation chart drilldown](images/accumulation-drill.png)

### Column Headers and Delimiters

In accumulation charts, only the values from a single column in the pivot chart are displayed. By default, the first column is used. If you want to show values from a different column, you can specify the column headers with the [`ColumnHeader`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_ColumnHeader) property in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

If the column has more than one header, enter all the headers separated by a delimiter, such as **Germany-Road Bikes**. You can set your preferred delimiter using the [`ColumnDelimiter`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_ColumnDelimiter) property in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-column/Column.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-column/Column.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Accumulation chart column header selection](images/accumulation-column.png)

### Label Customization

By default, the data labels in accumulation charts display the header name. Use the [`Visible`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartDataLabel.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartDataLabel_Visible) property in the [`PivotViewPivotChartDataLabel`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartDataLabel.html) settings to control their visibility.

To improve label arrangement and prevent overlapping, the **Smart Labels** option arranges labels efficiently. You can disable this option by setting the `enableSmartLabels` property to **false** in the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

The [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartDataLabel.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartDataLabel_Position) property in [`PivotViewPivotChartDataLabel`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartDataLabel.html) allows you to specify where the data label appears. The available options are:

* `Outside`: Places the label outside the chart point. This is the default option.
* `Inside`: Places the label inside the chart point.

In the following code sample, the data labels are placed inside the chart points.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-datalabel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DataLabel.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-datalabel/DataLabel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-datalabel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DataLabel.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-datalabel/DataLabel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Accumulation chart data labels](images/accumulation-label.png)

The **Connector Line** appears when data labels are positioned outside the chart. You can style this connector line using the [`ConnectorStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartDataLabel.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartDataLabel_ConnectorStyle) property in [`PivotViewPivotChartDataLabel`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartDataLabel.html). The most common sub-properties are:

| Property | Type | Description |
|----------|------|-------------|
| `Color` | `string` | The stroke color of the connector line. |
| `Width` | `double` | The stroke width in pixels. |
| `Length` | `string` | Specifies the length of the connector line from the data label to the associated data point (for example, "50px") |

In the example below, the connector line appearance is changed to show a different style.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-connector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-connector/Connector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-connector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Connector.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-connector/Connector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Accumulation chart connector line](images/accumulation-connector.png)

### Pie and Doughnut Customization

You can draw pie and doughnut charts within a specific range by using the [`StartAngle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_StartAngle) and [`EndAngle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_EndAngle) properties in the [`PivotChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) configuration. The default value for the [`StartAngle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_StartAngle) property is **0**, and the [`EndAngle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_EndAngle) property is **360**. By modifying these properties, you can create semi-pie and semi-doughnut charts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-angle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Angle.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-angle/Angle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-angle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Angle.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-angle/Angle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pie/doughnut chart angle customization](images/accumulation-angle.png)

You can convert a pie chart to a doughnut chart and vice-versa using the [`InnerRadius`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_InnerRadius) property in the [`PivotChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) configuration. When this property is set to a value greater than **0** percent, the chart appears as a doughnut instead of a pie chart.

> This property accepts values only in percentage format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-radius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-radius/Radius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-radius/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Radius.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-radius/Radius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pie to doughnut radius exampl](images/accumulation-radius.png)

### Exploding Series Points

You can highlight an individual point in a pivot chart by enabling the exploding option. To do this, set the [`Explode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_Explode) property in the [`PivotChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) to **true**. When this option is turned on, a chart point separates from the rest of the series when a user clicks it with a mouse or taps it on a touch device. This makes it easier to highlight specific data points in accumulation charts like Pie, Doughnut, Funnel, or Pyramid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-explode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Explode.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-explode/Explode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-explode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Explode.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-explode/Explode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Exploding series point](images/accumulation-explode.png)

## Field List

The field list allows you to add, remove, or rearrange fields in the pivot chart, so you can display exactly the data you need. To show the field list in the Pivot Chart, set the [`ShowFieldList`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) property of the Pivot Table to **true**. When you make changes with the field list, the pivot chart updates right away to show the new results. To learn more about the field list and how it works, see the [field list](./field-list) topic in the documentation.

The sample below demonstrates the field list shown in `Popup` mode within the pivot chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-fieldlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartFieldList.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-fieldlist/ChartFieldList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-fieldlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartFieldList.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-fieldlist/ChartFieldList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart with field list](images/pivotchart-FL.png)

## Grouping Bar

You can display the grouping bar in the Pivot Chart by setting the [`ShowGroupingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) property to **true**. When enabled, the grouping bar in the pivot chart shows a drop-down list on the value axis. This drop-down lets users select from the value fields defined in [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html). Users can switch between these fields to update the chart based on the selected value field. This method of selection is the default behavior in the Pivot Chart component. For more details about how the grouping bar works, refer to the [grouping bar](./grouping-bar) documentation.

> When there are multiple axes, buttons appear on the value axis instead of the drop-down list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-groupingbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartGroupingBar.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-groupingbar/ChartGroupingBar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-groupingbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartGroupingBar.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-groupingbar/ChartGroupingBar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart grouping bar](images/pivotchart-gbar.png)

When using accumulation charts, the drop-down list appears on the column axis. This list contains the column headers available in the Pivot Chart. Users can switch column headers using this drop-down, and the accumulation chart will update with the selected header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-group/Group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-group/Group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Accumulation chart grouping](images/accumulation-group.png)

## Single Axis

By default, the pivot chart uses the first value field (measure) from your report as the value axis. To display data using a different value field, use the [`Value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_Value) property inside [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html). This option lets you show a specific value field in the pivot chart, allowing you to focus on the data you need.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-single/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartSingle.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-single/ChartSingle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-single/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartSingle.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-single/ChartSingle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart single axis](images/chart_single_axis.png)

## Multiple Axis

The pivot chart can be drawn with multiple value fields by setting the [`EnableMultipleAxis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableMultipleAxis) property to **true** in the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ChartSettings). In the following code sample, the pivot chart displays both value fields "Sold" and "Amount" from the [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

> Multiple axis support is not applicable for accumulation chart types like pie, doughnut, pyramid, and funnel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multivalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartMultiValue.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multivalue/ChartMultiValue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multivalue/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartMultiValue.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multivalue/ChartMultiValue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart multiple axes](images/multi-axis.png)

When binding more value fields, the result displays multiple pivot charts, with each chart shrinking within the parent container height. To prevent this behavior, set the [`EnableScrollOnMultiAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableScrollOnMultiAxis) property to **true** in the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ChartSettings). This ensures each pivot chart maintains a minimum height of "160px" to "180px" (approximate) and displays a vertical scroll bar for better visibility.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiaxisscrollbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartScrollBar.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiaxisscrollbar/ChartScrollBar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiaxisscrollbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartScrollBar.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiaxisscrollbar/ChartScrollBar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart with scroll bar](images/chart-scrollbar.png)

Alternatively, you can display multiple values in a single chart. In this approach, the series from multiple values are grouped and displayed together. Based on the values, multiple Y-axis scales are created with different ranges. This can be achieved by setting [`EnableMultipleAxis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableMultipleAxis) to **true** and [`MultipleAxisMode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_MultipleAxisMode) to `Single` in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

In the following code sample, the pivot chart appears as a single chart with multiple value fields such as **Sold** and **Amount**, each represented with its own Y-axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multipleaxismode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartMultipleAxisMode.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multipleaxismode/ChartMultipleAxisMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multipleaxismode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartMultipleAxisMode.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multipleaxismode/ChartMultipleAxisMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Additionally, to display chart series for multiple values within a single y-axis, set the properties [`EnableMultipleAxis`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableMultipleAxis) to **true** and the [`MultipleAxisMode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_MultipleAxisMode) to **Combined**, in the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

> The y-axis range values will be formatted using the first value field on the value axis. For example, if the first value field is in currency format and the remaining value fields are in different number formats or no format, the y-axis range values will be displayed in the currency format of the first value field.

The pivot chart in the following code sample can be seen as a single chart with multiple value fields such as **Sold** and **Amount** drawn as a single y-axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/single-combined-y-axis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="combinedYAxis.cs" %}
{% include code-snippet/pivot-table/pivot-chart/single-combined-y-axis/combinedYAxis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/single-combined-y-axis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="combinedYAxis.cs" %}
{% include code-snippet/pivot-table/pivot-chart/single-combined-y-axis/combinedYAxis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot Chart for multiple values in a single y-axis](images/single-combined-y-axis.png)

### Show point color based on members

When you enable multiple axes in the pivot chart, you can use the [`ShowPointColorByMembers`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_ShowPointColorByMembers) property in the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) to display the same color for each member on the column axis across all measures. Setting this property to **true** makes it easier to spot and compare each member throughout the entire chart.

In addition, users can show or hide specific members from all measures in the chart by clicking the corresponding legend item. This interaction allows users to focus on the members they want to analyze without distraction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/show-member-series/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowMemberSeries.cs" %}
{% include code-snippet/pivot-table/pivot-chart/show-member-series/ShowMemberSeries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/show-member-series/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowMemberSeries.cs" %}
{% include code-snippet/pivot-table/pivot-chart/show-member-series/ShowMemberSeries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Show point color based on members in Pivot Chart](images/showMemberSeries.png)

## Series customization

You can customize the series in the pivot chart by using the [`ChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) class. Any changes you make to the [`ChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) property will apply to all series in the chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartSeries.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries/ChartSeries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartSeries.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries/ChartSeries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart series customization](images/chart-series.png)

If you want to change each series separately, use the `chartSeriesCreated` event. This event happens after the pivot chart series are created, making it possible to work with each series one at a time. The event handler receives the `ChartSeries` collection as a parameter, so you can update properties per series.

The sample below shows how you can hide every even-numbered series in the pivot chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartSeriesEvent.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries-event/ChartSeriesEvent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartSeriesEvent.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chartseries-event/ChartSeriesEvent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart series event example](images/chart-series-event.png)

## Axis Customization

Users can customize the x-axis and y-axis of the pivot chart using the [`PrimaryXAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_PrimaryXAxis) and [`PrimaryYAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_PrimaryYAxis) options in the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) class of the Pivot Table.

> Please note that axis customization is not supported for accumulation chart types, such as pie, doughnut, pyramid, and funnel.

For example, in the sample below, the titles for the y-axis and x-axis are set to custom values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-axis/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartAxis.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-axis/ChartAxis.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-axis/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartAxis.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-axis/ChartAxis.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart axis customization](images/axis-customization.png)

Users can also modify multi-level labels on the primary x-axis by using the [`MultiLevelLabelRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_MultiLevelLabelRender) event in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html). This event is triggered whenever a multi-level label is rendered on the chart. The event provides the following options:

- `axis`: Information about the current axis.
- `text`: Option to change the content of the multi-level label.
- `textStyle`: Option to adjust the font of the label.
- `alignment`: Option to set how the label text is aligned.

The example below shows how to update the text and style for multi-level labels on the pivot chart’s x-axis:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiLevelLabelRender/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Chart-multiLevelLabelRender.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiLevelLabelRender/chart-multiLevelLabelRender.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiLevelLabelRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Chart-multiLevelLabelRender.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-multiLevelLabelRender/chart-multiLevelLabelRender.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Multi-level label customization](images/multilevellabelrender.png)

## Legend customization

Users can change the legend in the pivot chart by using the [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html) option inside the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) property. By default, the legend is shown. If you want to hide it, set the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartSettingsLegendSettings_Visible) property in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html) to **false**.

The pivot chart allows users to select from various legend shapes, including:

- Circle
- Rectangle
- VerticalLine
- Pentagon
- InvertedTriangle
- SeriesType (default)
- Triangle
- Diamond
- Cross
- HorizontalLine

The default shape for the legend is **SeriesType**, but you can change it by setting the [`LegendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_LegendShape) property in [`ChartSeries`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html).

Users can also choose where the legend appears in the pivot chart by setting the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartSettingsLegendSettings_Position) property in [`LegendSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html). The available positions include:

- **Auto**: Places the legend based on the chart area (default).
- **Top**: Shows the legend above the pivot chart.
- **Left**: Displays the legend to the left of the chart.
- **Bottom**: Places the legend below the chart.
- **Right**: Shows the legend on the right side.
- **Custom**: Positions the legend using the `x` and `y` sub-properties you provide.

> Note: Legends are not shown by default for accumulation charts such as pie, doughnut, pyramid, and funnel.

In the following code example, you can see how to set a different legend shape and position.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/pivot-table/pivot-chart/legend/Legend.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend.cs" %}
{% include code-snippet/pivot-table/pivot-chart/legend/Legend.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Legend settings customization](images/legend-settings.png)

## User interaction

### Marker and crossHair

You can show and customize markers and crosshair's on the pivot chart. To do this, use the [`MarkerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSeriesMarkerSettings.html) and [`CrosshairSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsCrosshairSettings.html) options within the [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) property.

If you want to display a tooltip when hovering over an axis crosshair, use the [`crosshairTooltip`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartAxisCrosshairTooltip.html#properties) option. Common sub-properties include `Enable` and `Fill`.

> Please note, marker and crosshair options do not work with accumulation chart types, such as pie, doughnut, pyramid, or funnel.

In the following code sample, both marker and crosshair options are enabled and set up using the above properties:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker.cs" %}
{% include code-snippet/pivot-table/pivot-chart/marker/Marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker.cs" %}
{% include code-snippet/pivot-table/pivot-chart/marker/Marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Marker and crosshair example](images/marker-crosshair.png)

### Zooming and panning

Users can customize the zooming and panning options in the pivot chart by using the [`ChartZoomSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html) property within [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html). The pivot chart supports four zooming options:

- [`EnablePinchZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnablePinchZooming) – Zooms by pinching on touch devices.
- [`EnableSelectionZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnableSelectionZooming) – Zooms into a selected region on the chart.
- [`EnableDeferredZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnableDeferredZooming) – Applies zooming only after the selection is complete, which helps improve performance for large data.
- [`EnableMouseWheelZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnableMouseWheelZooming) – Zooms using the mouse wheel.

The direction of zooming can be controlled using the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_Mode) property in [`ZoomSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html). The available options are:

- `x`: zooms horizontally,
- `y`: zooms vertically,
- `x,y`: zooms both horizontally and vertically.

When the pivot chart is zoomed, a toolbar appears at the top of the chart with tools for Zoom, Zoom In, Zoom Out, Pan, and Reset actions. This toolbar can be customized using the [`ToolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_ToolbarItems) property in [`ZoomSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html).

> Zooming and panning are not available for accumulation chart types, such as pie, doughnut, pyramid, and funnel.

In the code sample below, all four zooming types are enabled, along with the toolbar options for the pivot chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/zooming/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Zooming.cs" %}
{% include code-snippet/pivot-table/pivot-chart/zooming/Zooming.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/zooming/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Zooming.cs" %}
{% include code-snippet/pivot-table/pivot-chart/zooming/Zooming.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Chart zooming and panning](images/zooming.png)

### Tooltip


The tooltip in the Pivot Chart is enabled by default, showing detailed information about each data point when users move the pointer over the chart. Users can change how the tooltip looks and functions by using the [`TooltipSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotTooltipSettings.html) in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) class. Common sub-properties include:

- `Enable`: Set to `false` to hide the tooltip.
- `Template`: A custom HTML template id for the tooltip content.
- `Fill`: The background color of the tooltip.
- `TextStyle`: Font styling for the tooltip text.

If users do not want to show the tooltip, they can disable it by setting the [`Enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotTooltipSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotTooltipSettings_Enable) property in [`TooltipSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotTooltipSettings.html) to **false**.

The code below shows how to change the default tooltip appearance and settings in the Pivot Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChartTooltip.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-tooltip/ChartTooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/chart-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChartTooltip.cs" %}
{% include code-snippet/pivot-table/pivot-chart/chart-tooltip/ChartTooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart tooltip](images/tooltip.png)

## Export

You can export the pivot chart to various file formats by using the `chartExport` method. This method requires the `type` parameter, which specifies the file format. The supported export formats are:

- `'PNG'`
- `'JPEG'`
- `'SVG'`
- `'PDF'`

Other optional parameters for the `chartExport` method include:

- `pdfExportProperties`: Lets you set specific export options for the PDF format.
- `isMultipleExport`: Use this to export several charts or reports into one PDF document.
- `pdfDoc`: Allows you to include another external PDF document as part of the export.
- `isBlob`: If enabled, saves the PDF as blob data.

The example below shows how to export the pivot chart using an external button labeled "Export":

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pivot-chart/export/Export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export.cs" %}
{% include code-snippet/pivot-table/pivot-chart/export/Export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart export example](images/chart-export.png)

## Print

You can print the current view of the pivot chart directly from the browser by using the `printChart` method. This allows you to create a physical or digital copy of your pivot chart as displayed on the screen.

In the example below, clicking an external button labeled "Print Chart" calls the `printChart` method and prints the rendered pivot chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/print/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/pivot-table/pivot-chart/print/Print.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/pivot-chart/print/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Print.cs" %}
{% include code-snippet/pivot-table/pivot-chart/print/Print.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot chart print example](images/print-chart.png)