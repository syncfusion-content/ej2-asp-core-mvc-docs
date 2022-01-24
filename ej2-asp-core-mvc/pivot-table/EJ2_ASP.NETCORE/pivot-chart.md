---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Pivot Chart of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Pivot Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pivot Chart

In pivot table component, pivot chart would act as an additional visualization component with its basic and important characteristic like drill down and drill up, 15+ chart types, series customization, axis customization, legend customization, export, print and tooltip. Its main purpose is to show the pivot data in graphical format.

If user prefers, the pivot chart component can also be displayed individually with pivot values and can change the report dynamically with the help of field list and grouping bar. Using the [`e-displayOption`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html) property in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag, user can set the visibility of grid and chart in pivot table component. It holds below properties,

* [`view`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_View): Specifies the pivot table component to display grid alone or chart alone or both.
* [`primary`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_Primary): Specifies the pivot table to display either grid or chart as primary component during initial loading. It is applicable only when setting the property [`view`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDisplayOption.html#Syncfusion_EJ2_PivotView_PivotViewDisplayOption_View) to [**Both**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.View.html).

The below sample displays the pivot chart component based on the pivot report bound on it.

{% aspTab template="pivot-table/pivot-chart/display-view", sourceFiles="DisplayView.cs" %}

{% endaspTab %}

## Data Binding

End user can bind both local and remote data binding options available in the component to feed the data. The [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_DataSource) property can be assigned either with an instance of `DataManager` or list of object.
For more information [`refer`](./data-binding) here.

## Chart Types

Supports 19 different types of charts as follows,

* Line
* Column
* Area
* Bar
* StepArea
* StackingColumn
* StackingArea
* StackingBar
* StepLine
* Pareto
* Bubble
* Scatter
* Spline
* SplineArea
* StackingColumn100
* StackingBar100
* StackingArea100
* Polar
* Radar

[**Line**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ChartSeriesType.html) is the default pivot chart type. User can change the pivot chart type by using the property [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_Type) in [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) tag.

In the below code sample, the pivot chart type is set as [**Bar**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ChartSeriesType.html).

{% aspTab template="pivot-table/pivot-chart/chart-type", sourceFiles="ChartType.cs" %}

{% endaspTab %}

![output](images/charttype.png)

## Accumulation Charts

Supports 4 different types of accumulation charts as follows,

* Pie
* Doughnut
* Funnel
* Pyramid

As like other chart types it can be changed using the property [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_Type) in [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) tag.

In the below code sample, the **Pie** chart is rendered, and the other accumulation charts can be switched using the drop-down list.

{% aspTab template="pivot-table/pivot-chart/chart-accumulation", sourceFiles="Accumulation.cs" %}

{% endaspTab %}

![output](images/accumulation.png)

### Drill Down/Up

In the accumulation charts, drill down and drill up operations can be performed using the built-in context menu option. It will be shown while clicking on the chart series. The context menu has the following options:
**Expand** - It is to drill down the corresponding series until the last level.
**Collapse** - It is to drill up the corresponding series until the first level.
**Exit** - It is to close the context menu.

> The drill operation in accumulation charts can be performed only for row headers.

{% aspTab template="pivot-table/pivot-chart/chart-drill", sourceFiles="Drill.cs" %}

{% endaspTab %}

![output](images/accumulation-drill.png)

### Column Headers and Delimiters

Unlike other chart types, the accumulation charts consider the values of a single column from the pivot table to be drawn. Preferably the first column of the pivot table is considered by default. But it can be changed by defining the column headers using the `columnHeader` property in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag.

If the column has more than one header, then need to mention all the headers separated by the delimiter **-**, for example,**FY 2016-Q2**. Using the property `columnDelimiter` in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag, one can set the desired delimiter to separate the column headers.

Using the property `columnDelimiter` in `chartSettings`, one can set the desired delimiter to separate the column headers.

{% aspTab template="pivot-table/pivot-chart/chart-column", sourceFiles="Column.cs" %}

{% endaspTab %}

![output](images/accumulation-column.png)

### Label Customization

The data labels are visible by default showing header name. Its visibility can be modified using the `visible` boolean property in `dataLabel`. With regard to the label arrangement, the **Smart Labels** options help to arrange labels efficiently without overlapping. It can be disabled by setting the `enableSmartLabels` property in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag as **false**.
The `position` property in `dataLabel` allows to specify the position of the data label. The available options are,
* `Outside`: Positions the label outside the point. It is the default option.
* `Inside`: Positions the label inside the point.

In the following code sample, the data labels are placed inside.

{% aspTab template="pivot-table/pivot-chart/chart-datalabel", sourceFiles="DataLabel.cs" %}

{% endaspTab %}

![output](images/accumulation-label.png)

The **Connector Line** will be visible when the data label is placed outside the chart. It can be customized using the `connectorStyle` property in `dataLabel` for its color, length, width etc. In the following code sample, the connector line is customized.

{% aspTab template="pivot-table/pivot-chart/chart-connector", sourceFiles="Connector.cs" %}

{% endaspTab %}

![output](images/accumulation-connector.png)

### Pie and Doughnut Customization

User can draw pie and doughnut charts within the specified range using the `startAngle` and `endAngle` properties in [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) tag. The default value of the `startAngle` property is **0**, and the `endAngle` property is **360**. By customizing these properties, user can draw semi pie and semi doughnut charts.

{% aspTab template="pivot-table/pivot-chart/chart-angle", sourceFiles="Angle.cs" %}

{% endaspTab %}

![output](images/accumulation-angle.png)

Users can get doughnut chart from pie chart and vice-versa using the `innerRadius` property in [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) tag. If the property is greater than **0** percent, the doughnut chart will appear from the pie chart.
> It takes the value only in percentage.

{% aspTab template="pivot-table/pivot-chart/chart-radius", sourceFiles="Radius.cs" %}

{% endaspTab %}

![output](images/accumulation-radius.png)

### Exploding Series Points

Exploding can be enabled by setting the `explode` property in  [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) tag to **true**. The series points will be exploded either on mouse click or touch.

{% aspTab template="pivot-table/pivot-chart/chart-explode", sourceFiles="Explode.cs" %}

{% endaspTab %}

![output](images/accumulation-explode.png)

## Field List

User can enable the field list by setting the property [`showFieldList`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowFieldList) in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag as **true**.
By using this, user can customize the report dynamically and view the result in pivot chart. For more information regarding the field list, refer the [field list](./field-list) topic.

In the following sample, the `Popup` mode of field list is enabled in the pivot chart integration.

{% aspTab template="pivot-table/pivot-chart/chart-fieldlist", sourceFiles="ChartFieldList.cs" %}

{% endaspTab %}

![output](images/pivotchart-FL.png)

## Grouping Bar

User can enable the grouping bar by setting the property [`showGroupingBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowGroupingBar) in [`ejs-pivotview`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag as **true**. The grouping bar in pivot chart shows a dropdown list in value axis instead of buttons. The dropdown list holds list of value fields bounded in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) and it can be switched to draw the pivot chart with the selected value field. This has been defined as the default behavior in the pivot chart component. For more information regarding the grouping bar, refer the [grouping bar](./grouping-bar) topic.

> For multiple axis support, buttons will be placed in value axis instead of dropdown list.

{% aspTab template="pivot-table/pivot-chart/chart-groupingbar", sourceFiles="ChartGroupingBar.cs" %}

{% endaspTab %}

![output](images/pivotchart-gbar.png)

For accumulation charts alone, a drop-down list will be placed in the column axis instead of the buttons. The drop-down list shows the column headers available in the pivot table. Users can dynamically switch column headers with the help of the drop-down list, and the accumulation chart will be updated accordingly.

In the below code sample, the pivot chart type is set as **Pie**.

{% aspTab template="pivot-table/pivot-chart/chart-group", sourceFiles="Group.cs" %}

{% endaspTab %}

![output](images/accumulation-group.png)

## Single Axis

By default, the pivot chart will be drawn with the value field (measure) which is set first in the report under value axis. But, user can change to specific value field using the property [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_Value) in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag.

{% aspTab template="pivot-table/pivot-chart/chart-single", sourceFiles="ChartSingle.cs" %}

{% endaspTab %}

![output](images/chart_single_axis.png)

## Multiple Axis

User can draw the pivot chart with multiple value fields by setting the property [`enableMultipleAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableMultipleAxis) in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag as **true**. In the below code sample, the pivot chart will be drawn with both value fields "Sold" and "Amount" available in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html).

{% aspTab template="pivot-table/pivot-chart/chart-multivalue", sourceFiles="ChartMultiValue.cs" %}

{% endaspTab %}

![output](images/multi-axis.png)

> The multiple axis support is not applicable for the accumulation chart types like pie, doughnut, pyramid, and funnel.

If the user binds more value fields, the result will be multiple pivot charts, and each chart will shrink within the parent container height. To avoid this, set the [`enableScrollOnMultiAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableScrollOnMultiAxis) property in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) to **true**. By doing so, each pivot chart will only shrink to a minimal "160px" – "180px" height showing a vertical scrollbar for a clear view.

{% aspTab template="pivot-table/pivot-chart/chart-multiaxisscrollbar", sourceFiles="ChartScrollBar.cs" %}

{% endaspTab %}

![output](images/chart-scrollbar.png)

Meanwhile, there is another way to display multiple values in a chart. In this approach, the series drawn from multiple values are grouped and displayed in a single chart. And, based on the values, multiple Y axis scales will be framed with different ranges. This can be achieved by setting the properties [`enableMultipleAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_EnableMultipleAxis) as **true** and [`multipleAxisMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_MultipleAxisMode) as `Single` in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html).

In the following code sample, the pivot chart can be seen as a single chart with multiple value fields such as **Sold** and **Amount** that are drawn as multiple Y axis.

{% aspTab template="pivot-table/pivot-chart/chart-multipleaxismode", sourceFiles="ChartMultipleAxisMode.cs" %}

{% endaspTab %}

## Series Customization

User can customize series of the pivot chart using [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag. The changes handled in the property will be reflected commonly in all chart series.

In the following sample, the pivot chart type and border has been changed for all the series.

{% aspTab template="pivot-table/pivot-chart/chartseries", sourceFiles="ChartSeries.cs" %}

{% endaspTab %}

![output](images/chart-series.png)

User can also customize the pivot chart series individually using the `chartSeriesCreated` event, which occurs after the pivot chart series has been created. You can customize each series individually by iterating them.

In the following sample, the even series are hidden in the pivot chart.

{% aspTab template="pivot-table/pivot-chart/chartseries-event", sourceFiles="ChartSeriesEvent.cs" %}

{% endaspTab %}

![output](images/chart-series-event.png)

## Axis Customization

User can customize axis of the pivot chart using [`primaryXAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_PrimaryXAxis) and [`primaryYAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_PrimaryYAxis) properties in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag.

> Axis customization is not applicable for the accumulation chart types like pie, doughnut, pyramid, and funnel.

In the following sample, title of y-axis and x-axis are customized.

{% aspTab template="pivot-table/pivot-chart/chart-axis", sourceFiles="ChartAxis.cs" %}

{% endaspTab %}

![output](images/axis-customization.png)

One can also customize multi-level labels of primary x-axis by using the `multiLevelLabelRender` event in the [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html), which fires on rendering each multi-level label in the pivot chart. It has the following parameters:

{% aspTab template="pivot-table/pivot-chart/chart-multiLevelLabelRender", sourceFiles="chart-multiLevelLabelRender.cs" %}

{% endaspTab %}

![output](images/multilevellabelrender.png)

## Legend Customization

User can customize legend using [`legendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html) in [`ChartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag. By default, legend will be visible and it can be hidden by setting the property [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartSettingsLegendSettings_Visible) in [`legendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html) tag as **false**.

The pivot chart support different types of legend shapes as follows,

* Circle
* Rectangle
* VerticalLine
* Pentagon
* InvertedTriangle
* SeriesType
* Triangle
* Diamond
* Cross
* HorizontalLine

Here **SeriesType** would act as the default shape and it can changed using the property [`legendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html#Syncfusion_EJ2_PivotView_PivotViewPivotSeries_LegendShape) in [`e-chartSeries`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSeries.html) tag.

Also user can set the position of the legend in pivot chart using the property [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotChartSettingsLegendSettings_Position) in [`legendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsLegendSettings.html) tag. The available options to set the legend position are as follows,

* Auto: Places the legend based on area type. This is the default.
* Top: Displays the legend at the top of the pivot chart.
* Left: Displays the legend at the left of the pivot chart.
* Bottom: Displays the legend at the bottom of the pivot chart.
* Right: Displays the legend at the right of the pivot chart.
* Custom: Displays the legend based on the given x and y values.

> By default, the legend is not visible for the accumulation chart types like pie, doughnut, pyramid, and funnel.

In the following sample, the legend shape and its position can be customized.

{% aspTab template="pivot-table/pivot-chart/legend", sourceFiles="Legend.cs" %}

{% endaspTab %}

![output](images/legend-settings.png)

## User Interaction

### Marker and CrossHair

User can enable and customize the marker and crosshair using [`marker`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSeriesMarkerSettings.html) and [`crosshair`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotChartSettingsCrosshairSettings.html) properties in [`chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) respectively.

Also user can enable and customize the crosshair tooltip for axes using [`primaryXAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_PrimaryXAxis) and [`primaryYAxis`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html#Syncfusion_EJ2_PivotView_PivotViewChartSettings_PrimaryYAxis).

> Marker and crosshair is not applicable for the accumulation chart types like pie, doughnut, pyramid, and funnel.

{% aspTab template="pivot-table/pivot-chart/marker", sourceFiles="Marker.cs" %}

{% endaspTab %}

![output](images/marker-crosshair.png)

### Zooming and Panning

User can customize zooming and panning option using the property [`e-zoomSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html) in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag.

The pivot chart support four types of zooming which can be set as follows,

* [`enablePinchZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnablePinchZooming)
* [`enableSelectionZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnableSelectionZooming)
* [`enableDeferredZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnableDeferredZooming)
* [`enableMouseWheelZooming`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_EnableMouseWheelZooming)

and three modes of zooming direction that specifies whether to zoom vertically or horizontally or in both ways which are,

* x: Pivot chart can be zoomed horizontally.
* y: Pivot chart can be zoomed  vertically.
* x,y: Pivot chart can be zoomed both vertically and horizontally.

This can be set using the property [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_Mode) in [`e-zoomSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html) tag. By default, if the pivot chart is zoomed, a toolbar would display with the options - Zoom, ZoomIn, ZoomOut, Pan, Reset. User can also customize its option using the property [`toolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotZoomSettings_ToolbarItems) in [`e-zoomSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotZoomSettings.html) tag.

> Zooming and panning is not applicable for the accumulation chart types like pie, doughnut, pyramid, and funnel.

{% aspTab template="pivot-table/pivot-chart/zooming", sourceFiles="Zooming.cs" %}

{% endaspTab %}

![output](images/zooming.png)

### Tooltip

By default, tooltip for the pivot chart is enabled. User can customize it by using the property [`e-tooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotTooltipSettings.html) in [`e-chartSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewChartSettings.html) tag.

> The tooltip can be disabled by setting the property [`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotTooltipSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotTooltipSettings_Enable) in [`e-tooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotTooltipSettings.html) tag as **false**.

{% aspTab template="pivot-table/pivot-chart/chart-tooltip", sourceFiles="ChartTooltip.cs" %}

{% endaspTab %}

![output](images/tooltip.png)

## Export

The pivot chart can be exported using the `chartExport` method which holds parameters like export type, file name, PDF orientation, width, and height in the same order. The mandatory parameters for this method are export type and file name whereas other parameters are optional.

The following are the four export types:

* PNG
* JPEG
* SVG
* PDF

In the following code sample, exporting can be done using an external button named as "Chart Export".

{% aspTab template="pivot-table/pivot-chart/export", sourceFiles="Export.cs" %}

{% endaspTab %}

![output](images/chart-export.png)

## Print

The rendered pivot chart can be printed directly from the browser by calling `printChart` method.

In the following code sample, printing can be done using an external button named as "Print".

{% aspTab template="pivot-table/pivot-chart/print", sourceFiles="Print.cs" %}

{% endaspTab %}

![output](images/print-chart.png)