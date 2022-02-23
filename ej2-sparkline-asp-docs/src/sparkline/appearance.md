---
title: "Appearance"
component: "Sparkline"
description: "Explains how to customize the appearance of sparkline"
---

# Appearance

The appearance of the sparkline can be customized using margin, container Area border, and container Area background.

## Sparkline border

The [`containerArea border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineContainerArea~Border.html) of the sparkline is used to render border to cover sparkline area.

The following code example shows the sparkline with overall border.

{% aspTab template="sparkline/appearance/border", sourceFiles="border.cs" %}

{% endaspTab %}

## Sparkline padding

Padding is used to specify padding value between container and sparkline. By default, padding value of the sparkline is 5. Sparkline [`padding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklinePadding.html) values are specified by the left, right, top, and bottom.

The following code example shows the sparkline with overall padding is set to 20.

{% aspTab template="sparkline/appearance/padding", sourceFiles="padding.cs" %}

{% endaspTab %}

## Sparkline area customization

The background color of the sparkline area can be customized using the [`containerArea background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineContainerArea~BackGround.html) color. By default, the sparkline background color is `transparent`.

{% aspTab template="sparkline/appearance/area_custom", sourceFiles="area_custom.cs" %}

{% endaspTab %}

## Sparkline theme

Datalabel and track line colors of the sparkline will be changed based on theme. For example, for dark theme, the color of datalabel and track line should be white; for light theme, their value should be black. The possible values for sparkline theme are [`Material`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html), [`Fabric`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html), [`Bootstrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html), and [`Highcontrast`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~Theme.html).

The following code example shows the color for datalabel and track line is set to white for dark theme.

{% aspTab template="sparkline/appearance/theme", sourceFiles="theme.cs" %}

{% endaspTab %}