# Linear Gauge Dimensions

<!-- markdownlint-disable MD036 -->

## Size for Linear Gauge

You can also set size for linear gauge directly through [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~Width.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~Height.html) properties.

**In Pixel**

You can set the size of lineargauge in pixel as demonstrated below.

{% aspTab template="lineargauge/dimensions/pixel", sourceFiles="pixel.cs" %}

{% endaspTab %}

**In Percentage**

By setting value in percentage, linear gauge gets its dimension with respect to its container. For example, when the height is ‘50%’, linear gauge renders to half of the container height.

{% aspTab template="lineargauge/dimensions/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}

>Note: When you do not specify the size, it takes `450px` as the height and window size as its width.