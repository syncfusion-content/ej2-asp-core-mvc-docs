---
title: "Axis"
component: "Heatmap"
description: "This section describes the axis types available in heatmap and other axis customizations available in heatmap like inversed axis, opposed axis and axis label formatting"
---

# Axis

Heat map consists of two axes namely, X-axis and Y-axis that displays the row headers and column headers to plot the data points respectively. You can define the type, format, and other customizing options for both axes in the heat map.

## Types

There are three different axis types available in the heat map, which defines the data type of the axis labels. You can define the axis type by using the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ValueType.html) property in the heat map.

### Category axis

Category axis type is used to represent the string values in axis labels.

{% aspTab template="heatmap/axis/category", sourceFiles="category.cs" %}

{% endaspTab %}

### Numeric axis

Numeric axis type is used to represent the numeric values in axis labels.

{% aspTab template="heatmap/axis/numeric", sourceFiles="numeric.cs" %}

{% endaspTab %}

### Date-time axis

Date-time axis type is used to represent the date-time values in axis labels with a specific format. In date-time axis, you can define the start and end date/time using the [`minimum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Minimum.html) and [`maximum`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Maximum.html) properties.

{% aspTab template="heatmap/axis/dateTime", sourceFiles="dateTime.cs" %}

{% endaspTab %}

## Inversed axis

Heat map supports inversing the axis origin for both axes, where the axis labels are placed in an inversed manner. You can enable axis inversing by enabling the [`isInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~IsInversed.html) property.

{% aspTab template="heatmap/axis/inversed", sourceFiles="inversed.cs" %}

{% endaspTab %}

## Opposed axis

In heat map, you can place the axis label in an opposite position of its default axis label position by using the [`opposedPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~OpposedPosition.html) property.

{% aspTab template="heatmap/axis/opposed", sourceFiles="opposed.cs" %}

{% endaspTab %}

## Label formatting

Heat map supports formatting the axis labels by using the [`labelFormat`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~LabelFormat.html) property. Using this property, you can customize the axis label by global string format ('P', 'C', etc) or customized format like '{value}°C'.

{% aspTab template="heatmap/axis/label-format", sourceFiles="label-format.cs" %}

{% endaspTab %}

## Axis intervals

In heat map, you can define an interval between the axis labels using the [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Interval.html) property. In date-time axis, you can change the interval mode by using the [`intervalType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~IntervalType.html) property. The date-time axis supports the following interval types:

* Years
* Months
* Days
* Hours
* Minutes

{% aspTab template="heatmap/axis/interval", sourceFiles="interval.cs" %}

{% endaspTab %}

## Axis label increment

Axis label increment in the heat map is used to display the axis labels with regular interval values in numeric and date-time axes. The labels will be displayed with tick gaps when you set the label interval. But, to achieve the same behavior without tick gaps, use the label increment. You can set the axis label increment using the [`increment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~Increment.html) property and the default value of this property is 1.

{% aspTab template="heatmap/axis/increment", sourceFiles="increment.cs" %}

{% endaspTab %}

## Limiting labels in date-time axis

You can display the axis labels at specific time intervals along with the date-time axis using the [`showLabelOn`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~ShowLabelOn.html) property. This property supports the following types:

* None: Displays the axis labels based on the `intervalType` and `interval` property of the axis. This type is default value of the `showLabelOn` property.
* Years: Displays the axis labels on every year between given date-time range.
* Months: Displays the axis labels on every month between given date-time range.
* Days: Displays the axis labels on every day between given date-time range.
* Minutes: Displays the axis labels on every minute between given date-time range.

{% aspTab template="heatmap/axis/show-label", sourceFiles="show-label.cs" %}

{% endaspTab %}

## Multi Level Labels

You can add many levels of labels using the [`multiLevelLabels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapAxis~MultiLevelLabels.html) property. This property can be configured using the following properties:

* Categories
* Overflow
* Alignment
* Text style
* Border

### Categories

Using this property, you can configure the  `start`, `end`, `text`, `maximumTextWidth` of the multilevel labels.

{% aspTab template="heatmap/axis/multi-level-category", sourceFiles="multi-level-category.cs" %}

{% endaspTab %}

### Overflow

Using this property, you can trim and wrap the multilevel labels.

>Note: This support works in x-axis only.

{% aspTab template="heatmap/axis/multi-level-overflow", sourceFiles="multi-level-overflow.cs" %}

{% endaspTab %}

### Alignment

This property provides an option to position the multilevel labels at far, center, and near.

{% aspTab template="heatmap/axis/multi-level-alignment", sourceFiles="multi-level-alignment.cs" %}

{% endaspTab %}

### Text Customization

The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel~TextStyle.html) property of multilevel labels provides options to customize the size, color, fontFamily, fontWeight, fontStyle, opacity, textAlignment and textOverflow.

{% aspTab template="heatmap/axis/multi-level-textstyle", sourceFiles="multi-level-textstyle.cs" %}

{% endaspTab %}

### Border Customization

Using the [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.HeatMap.HeatMapMultiLevelLabel~Border.html) property, you can customize the width, color, and type. The types of border are `Rectangle`, `WithoutTopBorder`, `WithoutBottomBorder`, `WithoutTopAndBottomBorder`, `Brace`, `WithoutBorder`.

{% aspTab template="heatmap/axis/multi-level-border", sourceFiles="multi-level-border.cs" %}

{% endaspTab %}