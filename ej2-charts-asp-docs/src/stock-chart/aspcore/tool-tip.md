---
title: "Stock Chart Tooltip   | ASP.NET MVC "

component: "Stock Chart"

description: "Tooltip is used to show the data value when mouse hover on the stockchart.We can able to customize format,template and appearance."
---

# Tooltip

<!-- markdownlint-disable MD036 -->

Stock Chart will display details about the points through tooltip, when the mouse is moved over the point.

## Default Tooltip

By default, tooltip is not visible. Enable the tooltip by setting
[`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Enable)property to true .

{% aspTab template="stock-chart/stockchart-feature/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD013 -->

## Format the Tooltip

<!-- markdownlint-disable MD013 -->

By default, tooltip shows information of x and y value in points. In addition to that, you can show more information in tooltip. For example the format `${series.name} ${point.x}` shows series name and point x value.

{% aspTab template="stock-chart/stockchart-feature/format", sourceFiles="format.cs" %}

{% endaspTab %}

## Customize the Appearance of Tooltip

The [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Fill) and [`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`textStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartTooltipSettings.html#Syncfusion_EJ2_Charts_ChartTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text.

{% aspTab template="stock-chart/stockchart-feature/customtooltip", sourceFiles="customtooltip.cs" %}

{% endaspTab %}
