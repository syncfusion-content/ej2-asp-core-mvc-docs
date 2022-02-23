---
title: "Stock Chart Appearance | ASP.NET MVC "

component: "Stock Chart"

description: "We can customize stock chart appearance by using title and tooltip customizations."
---

# Appearance

## Stock Chart Title

Stock Chart can be given a title using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Title) property, to show the information
about the data plotted.

{% aspTab template="stock-chart/appearance/title", sourceFiles="title.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Title Customizations

The `textStyle` property of chart title provides options to customize the `size`, `color`, `fontFamily`, `fontWeight`, `fontStyle`, `opacity`, `textAlignment` and `textOverflow`.

{% aspTab template="stock-chart/appearance/titlewrap", sourceFiles="titlewrap.cs" %}

{% endaspTab %}

## Stock Chart Theme

Changing theme will affect background color,gridlines,tooltip colors and appearance.

[`theme`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.StockChart.html#Syncfusion_EJ2_Charts_StockChart_Theme) property of Stock chart is shipped with several built-in themes such as `Material`, `Fabric`, `Bootstrap` , `HighContrastLight`, `MaterialDark`, `FabricDark`, `FabricDark`, `HighContrast` and `BootstrapDark`.

{% aspTab template="stock-chart/appearance/theme", sourceFiles="theme.cs" %}

{% endaspTab %}

## See Also

* [Axis Customization](./axis-customization/)
