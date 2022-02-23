---
title: "  Stock Chart Axis Types  | ASP.NET MVC "

component: "Stock Chart"

description: "Date time axis uses date time scale and displays the date time values as axis labels in the specified format"
---

# DateTime,Numeric and Logarithmic Axis

## DateTime Axis

Date time axis uses date time scale and displays the date time values as axis labels in the specified format and set the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to DateTime.

{% aspTab template="stock-chart/stockchart-feature/datetime", sourceFiles="datetime.cs" %}

{% endaspTab %}

## Logarithmic Axis

<!-- markdownlint-disable MD033 -->

Logarithmic axis uses logarithmic scale and it is very useful in visualizing data, when it has numerical values in
both lower order of magnitude (eg: 10<sup>-6</sup>) and higher order of magnitude (eg: 10<sup>6</sup>) and set the [`valueType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartAxis.html#Syncfusion_EJ2_Charts_StockChartStockChartAxis_ValueType) of axis to `Lograthmic`.

{% aspTab template="stock-chart/stockchart-feature/log", sourceFiles="log.cs" %}

{% endaspTab %}

## See Also

* [Axis Customization](./axis-customization/)