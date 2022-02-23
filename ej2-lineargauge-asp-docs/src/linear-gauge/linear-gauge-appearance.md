# Appearance

## Gauge Area Customization

<!-- markdownlint-disable MD036 -->

**Customize the Linear Gauge background**

Using [`background`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.html) and
[`border`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.html) properties, you can change the background color and border of the linear gauge.

{% aspTab template="lineargauge/lineargauge-appearance/gauge-background", sourceFiles="gauge-background.cs" %}

{% endaspTab %}

**Gauge Margin**

You can set margin for the lineargauge through [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeMargin.html) property.

{% aspTab template="lineargauge/lineargauge-appearance/gauge-margin", sourceFiles="gauge-margin.cs" %}

{% endaspTab %}

## Gauge Title

You can give the title using [`title`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~Title.html) property to show the information about the linear gauge. Its appearance can be customized by using the [`titleStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGauge~TitleStyle.html) property.

{% aspTab template="lineargauge/lineargauge-appearance/gauge-title", sourceFiles="gauge-title.cs" %}

{% endaspTab %}

## Gauge Container

The area used to render the ranges and pointers at the center position of the gauge is called [`container`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer.html). It can be customized by using [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Type.html), [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Offset.html), [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Width.html), [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~Height.html) and [`backgroundColor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer~BackGroundColor.html) properties in [`container`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeContainer.html). It is of three types namely,

* Normal
* Rounded Rectangle
* Thermometer

**Normal**

The normal type will render the container as rectangle and this is the default container type.

{% aspTab template="lineargauge/lineargauge-appearance/gauge-container", sourceFiles="gauge-container.cs" %}

{% endaspTab %}

**Rounded Rectangle**

The rounded rectangle type will render the container as rectangle with rounded corners.

{% aspTab template="lineargauge/lineargauge-appearance/rounded-rectangle", sourceFiles="rounded-rectangle.cs" %}

{% endaspTab %}

**Thermometer**

This type is used to render the container similar to the thermometer appearance.

{% aspTab template="lineargauge/lineargauge-appearance/thermo-meter", sourceFiles="thermo-meter.cs" %}

{% endaspTab %}