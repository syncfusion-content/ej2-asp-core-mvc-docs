---
title: "Data Labels"
component: "Sparkline"
description: "Data labels support in sparkline"
---

# Data Labels

Data labels are used to display values of data points to improve the readability.

## Enable data label

To enable data label for sparkline series, provide [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings~Visible.html) of the [`dataLabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings.html) as following possible values:

* All - Enables data label of  all points.
* Start - Enables data label of the start point.
* End - Enables data label of the end point.
* High - Enables data label of the high point.
* Low - Enables data label of the low point.
* Negative - Enables data labels of the negative points.

The following example shows enabling sparkline data label for all points.

{% aspTab template="sparkline/datalabel/enable", sourceFiles="enable.cs" %}

{% endaspTab %}

## Customize data label

Data labels can be customized using the fill, border, opacity, and text Style. The following code example shows customizing data label border, text color, and fill color.

{% aspTab template="sparkline/datalabel/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Format data label text

The text of data labels can be formatted using the [`format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings~Format.html) API in the sparkline [`dataLabelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineSparklineDataLabelSettings.html). By default, data label shows the y-value of point. The following code example shows how to display x and y-values for points.

{% aspTab template="sparkline/datalabel/format", sourceFiles="format.cs" %}

{% endaspTab %}