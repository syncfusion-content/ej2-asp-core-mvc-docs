# Annotations

Annotations are used to mark a specific area of interest in the gauge with texts, shapes or images.

## Content

You can place any custom element on the axis area by assigning the id of the element to
[`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAnnotation_Content) property of [`annotation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html) object.

{% aspTab template="circulargauge/gauge-annotations/annotations", sourceFiles="annotations.cs" %}

{% endaspTab %}

## Position

Annotation can be placed around the axis by using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAnnotation_Radius)
and [`angle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeAnnotation.html#Syncfusion_EJ2_CircularGauge_CircularGaugeAnnotation_Angle) property.
For example, if the angle is 90 degree and the radius is 110%, then the annotation, will be placed at the right side of the axis.

Radius of the annotation takes value either in pixel or percentage. By setting value in percentage, annotation gets its position with respect to its axis radius.

{% aspTab template="circulargauge/gauge-annotations/position", sourceFiles="position.cs" %}

{% endaspTab %}

## Sub Gauge

As the annotation allows you to place any custom element, we can initialize a gauge to the element and can
be used to place that in another gauge.

{% aspTab template="circulargauge/gauge-annotations/subgauge", sourceFiles="subgauge.cs" %}

{% endaspTab %}

## See also

* [Tooltip for Annotations](gauge-user-interaction/#tooltip-for-annotations)