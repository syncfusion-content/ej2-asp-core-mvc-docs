# Circular Gauge Dimensions

## Size for Circular Gauge

<!-- markdownlint-disable MD036 -->

You can also set size for the gauge directly through [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Height) properties.

**In Pixel**

You can set the size of the gauge in pixel as demonstrated below.

{% aspTab template="circulargauge/gauge-dimension/gauge-dimension", sourceFiles="gauge-dimension.cs" %}

{% endaspTab %}

**In Percentage**

By setting value in percentage, gauge gets its dimension with respect to its container. For example, when
the height is ‘50%’, gauge renders to half of the container height.

{% aspTab template="circulargauge/gauge-dimension/percentage", sourceFiles="percentage.cs" %}

{% endaspTab %}

>Note: When you do not specify the size, it takes `450px` as the height and window size as its width.