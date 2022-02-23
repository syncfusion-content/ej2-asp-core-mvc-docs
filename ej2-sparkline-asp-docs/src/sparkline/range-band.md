---
title: "Range band"
component: "Sparkline"
description: "Range band support in sparkline component"
---

# Range Band

This section explains how to customize the sparkline with multiple range bands.

## Range band customization

The range band feature is used to highlight a particular range along with the y-axis using the [`startRange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~StartRange.html) and [`endRange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~EndRange.html) properties. You can also customize the [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~Color.html) and [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~Opacity.html) of the range band.

{% aspTab template="sparkline/rangeband/range", sourceFiles="range.cs" %}

{% endaspTab %}

## Multiple range band customization

You can define multiple range bands to a sparkline as shown in the following code sample.

{% aspTab template="sparkline/rangeband/multi_range", sourceFiles="multi_range.cs" %}

{% endaspTab %}