---
title: " Chart Strip-lines | ASP.NET MVC "

component: "Chart"

description: "Strip Lines are vertical or horizontal lines used to highlight/mark a certain region on the plot area."
---

<!-- markdownlint-disable MD036 -->

# Strip lines

<!-- markdownlint-disable MD036 -->

EJ2 chart supports horizontal and vertical strip lines and customization of stripline in both orientation.

## Horizontal Strip lines

You can create Horizontal stripline by adding the `Stripline` in the vertical axis and set `Visible` option to true.
Striplines are rendered in the specified start to end range and you can add more than one stripline for an axis.

{% aspTab template="chart/axis/strip-line/horizontal", sourceFiles="horizontal.cs" %}

{% endaspTab %}

## Vertical Striplines

You can create vertical stripline by adding the `Stripline` in the horizontal axis and set `Visible` option to true.
Striplines are rendered in the specified start to end range and you can add more than one stripline for an axis.

{% aspTab template="chart/axis/strip-line/vertical", sourceFiles="vertical.cs" %}

{% endaspTab %}

## Customize the strip line

Starting value in specific strip line can be customized by `Start` property in strip line. Similarly, ending value
is customized by `End`. It can be also set for starting from the corresponding origin of the axis by `StartFromOrigin`.
Size of the strip line is customized by `Size`. Border for the stripline is customized by `Border`.
Order of the strip line such that whether it should be rendered in behind or over the series elements
is customized by `ZIndex`.

{% aspTab template="chart/axis/strip-line/custom-stripline", sourceFiles="custom-stripline.cs" %}

{% endaspTab %}

## Customize the stripline text

You can customize the text rendered in stripline by `TextStyle` property. Rotation of the strip line text can be changed by `Rotation` property.
Horizontal and Vertical alignment of stripline text can be changed by `HorizontalAlignment` and `VerticalAlignment` property.

{% aspTab template="chart/axis/strip-line/custom-striptext", sourceFiles="custom-striptext.cs" %}

{% endaspTab %}

## Dash Array

You can create dash array stripline by using `DashArray` property. The Striplines are rendered with specified dash array values.

{% aspTab template="chart/axis/strip-line/dasarray", sourceFiles="dash.cs" %}

{% endaspTab %}

## Recurrence Stripline

 The strip lines to be drawn repeatedly at the regular intervals – this will be useful when you want to mark an event that occurs recursively along the timeline of the chart. Following properties are used to configure this feature.

* `IsRepeat`       - It is used for enable / disable the recurrence strip line.
* `RepeatEvery`    - It is used for mention the stripline interval.
* `RepeatUntil`    - It specifies the end value at which point strip line has to stop repeating.

{% aspTab template="chart/axis/strip-line/recurrence", sourceFiles="recurrence.cs" %}

{% endaspTab %}

## Size Type

The `SizeType` property refers the size of the stripline. They are,

* `Auto`
* `Pixel`
* `Years`
* `Months`
* `Days`
* `Hours`
* `Minutes`
* `Seconds`

{% aspTab template="chart/axis/strip-line/size-type", sourceFiles="size-type.cs" %}

{% endaspTab %}

## Segment Stripline

You can create stripline in a particular region with respect to segment. You can enable the segment stripline using `IsSegmented` property. The start and end value of this type of stripline can be defined using `SegmentStart` and `SegmentEnd` properties.

* `IsSegmented`     - It is used for enable the segment stripline.
* `SegmentStart`    - Used to change the segment start value. Value correspond to associated axis.
* `SegmentEnd`      - Used to change the segment end value. Value correspond to associated axis.
* `SegmentAxisName` - Used to specify the name of the associated axis.

{% aspTab template="chart/axis/strip-line/segment", sourceFiles="segment.cs" %}

{% endaspTab %}