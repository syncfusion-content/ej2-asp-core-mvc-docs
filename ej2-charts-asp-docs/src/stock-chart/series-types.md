---
title: "Series Types  | ASP.NET MVC "

component: "Stock Chart"

description: "Essential JS 2   StockChart supports 32 types of series and also supports different tpes customizations for each type of StockChart."
---

# Stock Chart Series Types

Essential JS 2 StockChart  Stock Chart supports 6 major types of series namely `Line`, `Spline`, `Hilo`, `HiloOpenClose`, `Hollow Candle` and `Candle` . By using the series dropdown button you can navigate between the above listed series types.

<!-- markdownlint-disable MD036 -->

**Line**

To render a line series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) as `Line`.

**Candle**

To render a candle series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) as `Candle` .

**HollowCandle**

To render a hollowcandle series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) as `Candle` and set `enableSolidCandle` as false.

**Spline**

To render a spline series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) as `Spline`.

**Hilo**

To render a hilo series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) as `Hilo` .

**HiloOpenClose**

To render a hiloOpenClose series, use series [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_Type) as `HiloOpenClose`.

{% aspTab template="stock-chart/stockchart-feature/candle", sourceFiles="candle.cs" %}

{% endaspTab %}
