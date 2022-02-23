---
title: "Special points customization"
component: "Sparkline"
description: "Explains how to customize the special points in sparkline"
---

# Special points customization

You can customize the points by initializing the point colors. The customization options allows to differentiate the [`start`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~StartPointColor.html), [`end`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~EndPointColor.html), [`positive`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~HighPointColor.html), [`negative`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~NegativePointColor.html), and [`low`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.Sparkline~LowPointColor.html) points. This customization is only applicable for line, column, and area type sparklines.

<!-- markdownlint-disable MD036 -->

{% aspTab template="sparkline/specialpoints/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

**Tie point color**

Tie point color is used to configure the win-loss series type sparkline's y-value point color. The following code sample shows the tie point color of sparkline series.

{% aspTab template="sparkline/specialpoints/tie_point", sourceFiles="tie_point.cs" %}

{% endaspTab %}