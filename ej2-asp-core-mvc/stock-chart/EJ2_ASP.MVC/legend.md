---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Legend of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Legend
publishingplatform: ##Platform_Name##
documentation: ug
---


# Legend

Legend provides information about the series rendered in the Stock Chart. Legend can be added to a Stock Chart by enabling the [`Visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Visible) option in the [`LegendSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings).

## Position and Alignment

By using the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Position) property, legend can be placed at `Left`, `Right`, `Top`, `Bottom` or `Custom` of the Stock Chart. The legend is positioned at the bottom of the Stock Chart, by default.

{% aspTab template="stock-chart/stockchart-legend/position", sourceFiles="position.cs" %}

{% endaspTab %}

[`Custom`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Position) position is used to position the legend anywhere in the Stock Chart using x, y coordinates.

{% aspTab template="stock-chart/stockchart-legend/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

## Legend Alignment

The legend can be align as `Center`, `Far` or `Near` to the Stock Chart using [`Alignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Alignment) property.

{% aspTab template="stock-chart/stockchart-legend/alignment", sourceFiles="alignment.cs" %}

{% endaspTab %}

## Customization

To change the legend icon shape, [`LegendShape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries_LegendShape) property in the [`Series`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartSeries.html#Syncfusion_EJ2_Charts_StockChartStockChartSeries) can be used. By default legend icon shape is `SeriesType`.

{% aspTab template="stock-chart/stockchart-legend/customization", sourceFiles="customization.cs" %}

{% endaspTab %}

## Legend Size

By default, legend takes 20% - 25% of the Stock Chart's height horizontally, when it is placed on top or bottom position and 20% - 25% of the width vertically, while placing on left or right position of the Stock Chart. The default legend size can be changed by using the [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Width) and [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Height) property of the `LegendSettings`.

{% aspTab template="stock-chart/stockchart-legend/size", sourceFiles="size.cs" %}

{% endaspTab %}

## Legend Item Size

The size of the legend items can customized by using the [`ShapeHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_ShapeHeight) and [`ShapeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_ShapeWidth) property.

{% aspTab template="stock-chart/stockchart-legend/item-size", sourceFiles="item-size.cs" %}

{% endaspTab %}

## Collapsing Legend Item

By default, series name will be displayed as legend. To skip the legend for a particular series, empty string to the series name can be given.

{% aspTab template="stock-chart/stockchart-legend/collapsing", sourceFiles="collapsing.cs" %}

{% endaspTab %}

## Legend Title

The title for legend can be set using [`Title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_Title) property in `LegendSettings`. Customize the [`FontStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_FontStyle), [`Size`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_Size), [`FontWeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_FontWeight), [`Color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_Color), [`TextAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_TextAlignment), [`FontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_FontFamily), [`Opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_Opacity) and [`TextOverflow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartFont.html#Syncfusion_EJ2_Charts_StockChartFont_TextOverflow) of legend title. [`TitlePosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_TitlePosition) is used to set the legend position in `Top`, `Left` and `Right` position. [`MaximumTitleWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChartStockChartLegendSettings.html#Syncfusion_EJ2_Charts_StockChartStockChartLegendSettings_MaximumTitleWidth) is used to set the width of the legend title. By default, it will be `100px`.

{% aspTab template="stock-chart/stockchart-legend/title", sourceFiles="title.cs" %}

{% endaspTab %}
