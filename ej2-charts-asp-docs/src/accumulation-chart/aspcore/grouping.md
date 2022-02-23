---
title: "Accumulation Chart Grouping | ASP.NET MVC "

component: "Accumulation Chart"

description: "By using point and value in pie chart,you can group collection of points into the single slice"
---
<!-- markdownlint-disable MD036 -->

# Grouping

You can club/group few points of the series based on
[`groupTo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_GroupTo)
property. For example, if the club value is 11, then the points with value less than 11 is grouped together
and will be showed as a single point with label `others`. The property also takes value in percentage
(percentage of total data points value).

{% aspTab template="chart/accumulation-charts/grouping/group", sourceFiles="group.cs" %}

{% endaspTab %}

## Pie Grouping

**Broken Slice**

You can visualize all points available in club/group points by clicking on the grouped point. For example, if 5 points are grouped together it will be showed as a single slice with label `others`. If we click on `others` slice it will explode and broke into 5 seperate slices.

{% aspTab template="chart/accumulation-charts/grouping/slice", sourceFiles="slice.cs" %}

{% endaspTab %}

**Group Mode**

Slice can also be grouped based on number of points by specifying the [`groupMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.AccumulationSeries.html#Syncfusion_EJ2_Charts_AccumulationSeries_GroupMode)
to Point. For example, if the group to value is 11, accumulation chart will show 1st 11 points and will group remaining entries in the collection as a single point.

{% aspTab template="chart/accumulation-charts/grouping/groupmode", sourceFiles="groupmode.cs" %}

{% endaspTab %}

## Customization

You can customize the grouped point and its data label using `pointRender` and `textRender` event.

{% aspTab template="chart/accumulation-charts/grouping/custom", sourceFiles="custom.cs" %}

{% endaspTab %}