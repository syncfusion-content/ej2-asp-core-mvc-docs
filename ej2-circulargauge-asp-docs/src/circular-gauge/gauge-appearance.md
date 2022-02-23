# Appearance

## Gauge Title

Circular gauge can be given a title by using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Title) property, to show the information about the gauge.
Title can be customized by using [`titleStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_TitleStyle) property in gauge.

{% aspTab template="circulargauge/gauge-appearance/title", sourceFiles="title.cs" %}

{% endaspTab %}

## Gauge Position

<!-- markdownlint-disable MD036 -->

Gauge can be positioned anywhere in the container with the help of
[`centerX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterX) and
[`centerY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterY)
property and it accepts values either in percentage or in pixels.
The default value of the [`centerX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterX) and
[`centerY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterY) property is 50%, which means gauge will get rendered to the centre of the container.

**In Pixel**

You can set the mid point of the gauge in pixel as demonstrated below,

{% aspTab template="circulargauge/gauge-appearance/position", sourceFiles="position.cs" %}

{% endaspTab %}

**In Percentage**

By setting the value in percentage, gauge gets its mid point with respect to its plot area.
For example, when the [`centerX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterX)
value as '0%' and [`centerY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_CenterY) value is ‘50%’, gauge will get positioned at the top left corner of the plot area.

{% aspTab template="circulargauge/gauge-appearance/position-percentage", sourceFiles="position-percentage.cs" %}

{% endaspTab %}

## Area Customization

**Customize the gauge background**

Using [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Background) and
[`border`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Border) properties, you can change the background color and border of the circular gauge.

{% aspTab template="circulargauge/gauge-appearance/area-customization", sourceFiles="area-customization.cs" %}

{% endaspTab %}

**Gauge Margin**

You can set margin for gauge from its container through
[`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_Margin) property.

{% aspTab template="circulargauge/gauge-appearance/margin", sourceFiles="margin.cs" %}

{% endaspTab %}

## Radius calculation based on angles

Render semi or quarter circular gauges by modifying the start and end angles. By enabling the radius based on angle option, the radius of circular gauge will be calculated based on the start and end angles to avoid excess white space.

{% aspTab template="circulargauge/gauge-appearance/radiusbasedgauge", sourceFiles="radiusbasedgauge.cs" %}

{% endaspTab %}