# Ranges

You can categories certain interval on gauge axis using [`ranges`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html) property.

## Start and End

Start and end value of a range in an axis can be customized by using [`start`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_Start) and [`end`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_End) properties.

{% aspTab template="circulargauge/gauge-ranges/ranges", sourceFiles="ranges.cs" %}

{% endaspTab %}

## Customization

Color and thickness of the range can be customized by using [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_Color),[`startWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_StartWidth) and [`endWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_EndWidth) property.

{% aspTab template="circulargauge/gauge-ranges/customization", sourceFiles="customization.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

## Radius

You can place the range inside or outside of the axis by using [`radius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeRange.html#Syncfusion_EJ2_CircularGauge_CircularGaugeRange_Radius)
property. The radius of the range can takes value either in percentage or in pixels. By default, ranges
take 100% of the axis radius.

**In Pixel**

You can set the radius of the range in pixel as demonstrated below,

{% aspTab template="circulargauge/gauge-ranges/radius", sourceFiles="radius.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**In Percentage**

By setting value in percentage, range gets its dimension with respect to its axis radius.
For example, when the radius is ‘50%’, range renders to half of the axis radius.

{% aspTab template="circulargauge/gauge-ranges/radius-percentage", sourceFiles="radius-percentage.cs" %}

{% endaspTab %}

## Dragging Ranges

The ranges can be dragged over the axis line by clicking and dragging the same. To enable or disable the range drag, use the [`EnableRangeDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_EnableRangeDrag) property.

{% aspTab template="circulargauge/gauge-ranges/dragging-range", sourceFiles="dragging-range.cs" %}

{% endaspTab %}

## Multiple Ranges

You can add multiple ranges to an axis with the above customization as demonstrated below.

>Note: You can set the range color to axis ticks and labels by enabling `useRangeColor` property in [`majorTicks`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html),
[`minorTicks`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTick.html) and [`labelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeLabel.html) object.

{% aspTab template="circulargauge/gauge-ranges/multiple-ranges", sourceFiles="multiple-ranges.cs" %}

{% endaspTab %}

## Rounded corner radius

You can customize the corner radius using the `roundedCornerRadius` property in `ranges`.

{% aspTab template="circulargauge/gauge-ranges/roundedcorner", sourceFiles="ranges.cs" %}

{% endaspTab %}

## Gradient Color

Gradient support allows to add multiple colors in the ranges and pointers of the circular gauge. The following gradient types are supported in the circular gauge.

* Linear Gradient
* Radial Gradient

### Linear Gradient

Using linear gradient, colors will be applied in a linear progression. The start value of the linear gradient will be set using the [`startValue`](../api/circular-gauge/linearGradient/#startvalue) property. The end value of the linear gradient will be set using the [`endValue`](../api/circular-gauge/linearGradient/#endvalue) property. The color stop values such as color, opacity and offset are set using [`colorStop`](../api/circular-gauge/linearGradient/#colorstop) property.
To apply linear gradient to the range, follow the below code sample.

{% aspTab template="circulargauge/gauge-ranges/lineargradient", sourceFiles="lineargradient.cs" %}

{% endaspTab %}

### Radial Gradient

Using radial gradient, colors will be applied in circular progression. The inner circle position of the radial gradient will be set using the [`innerPosition`](../api/circular-gauge/radialGradient/#innerposition) property. The outer circle position of the radial gradient can be set using the [`outerPosition`](../api/circular-gauge/radialGradient/#outerposition) property. The color stop values such as color, opacity and offset are set using [`colorStop`](../api/circular-gauge/radialGradient/#colorstop) property.

To apply radial gradient to the range, follow the below code sample.

{% aspTab template="circulargauge/gauge-ranges/radialgradient", sourceFiles="radialgradient.cs" %}

{% endaspTab %}

## See also

* [Tooltip for Ranges](gauge-user-interaction/#tooltip-for-ranges)
