---
title: " Chart Axis Labels | ASP.NET MVC "

component: "Chart"

description: "Chart contains smart axis labels, label positioning, multilevelabels, text customization and sorting properties "
---

# Axis Labels

## Smart Axis Labels

When the axis labels overlap with each other, you can use [`labelIntersectAction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelIntersectAction)
property in the axis, to place them smartly.

When setting `labelIntersectAction` as `Hide`

{% aspTab template="chart/axis/multiple/hide", sourceFiles="hide.cs" %}

{% endaspTab %}

When setting `labelIntersectAction` as `Rotate45`

{% aspTab template="chart/axis/multiple/rotate45", sourceFiles="rotate45.cs" %}

{% endaspTab %}

When setting `labelIntersectAction` as `Rotate90`

{% aspTab template="chart/axis/multiple/rotate90", sourceFiles="rotate90.cs" %}

{% endaspTab %}

## Axis Labels Positioning

By default, the axis labels can be placed at `outside` the axis line and this also can be placed at `inside`
the axis line using the `labelPosition` property.

{% aspTab template="chart/axis/multiple/position", sourceFiles="position.cs" %}

{% endaspTab %}

## Multilevel Labels

Any number of levels of labels can be added to an axis using the `multiLevelLabels` property. This property can be
configured using the following properties:

• Categories
• Overflow
• Alignment
• Text style
• Border

### Categories

Using the categories property, you can configure the `start`, `end`, `text`, and `maximumTextWidth` of multilevel labels.

{% aspTab template="chart/axis/multiple/multi-category", sourceFiles="category.cs" %}

{% endaspTab %}

### Overflow

Using the `overflow` property, you can `trim` or `wrap` the multilevel labels.

{% aspTab template="chart/axis/multiple/multi-overflow", sourceFiles="overflow.cs" %}

{% endaspTab %}

### Alignment

The `alignment` property provides option to position the multilevel labels at `far`, `center`, or `near`.

{% aspTab template="chart/axis/multiple/multi-alignment", sourceFiles="alignement.cs" %}

{% endaspTab %}

### Text customization

The `textStyle` property of multilevel labels provides options to customize the `size`, `color`, `fontFamily`,
`fontWeight`, `fontStyle`, `opacity`, `textAlignment` and `textOverflow`.

{% aspTab template="chart/axis/multiple/multi-textcustom", sourceFiles="text-custom.cs" %}

{% endaspTab %}

### Border customization

Using the `border` property, you can customize the `width`, `color`, and `type`. The `type` of border
are `Rectangle`, `Brace`, `WithoutBorder`, `WithoutTopBorder`, `WithoutTopandBottomBorder` and `CurlyBrace`.

{% aspTab template="chart/axis/multiple/multi-bordercustom", sourceFiles="border-custom.cs" %}

{% endaspTab %}

## Edge Label Placement

Labels with long text at the edges of an axis may appear partially in the chart. To avoid this,
use [`edgeLabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EdgeLabelPlacement) property in axis, which moves
the label inside the chart area for better appearance or hides it.

{% aspTab template="chart/axis/multiple/edge", sourceFiles="edge.cs" %}

{% endaspTab %}

## Labels Customization

The [`labelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelStyle) property of an axis provides options to customize the
`color`, `font-family`, `font-size` and `font-weight` of the axis labels.

{% aspTab template="chart/axis/multiple/labels-custom", sourceFiles="labels-custom.cs" %}

{% endaspTab %}

## Customizing Specific Point

You can customize the specific text in the axis labels using `axisLabelRender` event.

{% aspTab template="chart/axis/multiple/custom-point", sourceFiles="custom-point.cs" %}

{% endaspTab %}

## Trim using maximum label width

You can trim the label using [`enableTrim`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EnableTrim) property and width of the labels can also be customized using [`maximumLabelWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MaximumLabelWidth) property in the axis, the value maximum label width is `34` by default.

{% aspTab template="chart/axis/multiple/labels-trim", sourceFiles="labels-trim.cs" %}

{% endaspTab %}

## Line break support

Line break feature used to customize the long axis label text into multiple lines by using
`<br>` tag. Refer the below example in that dataSource x value contains long text, it breaks into two lines by using  `<br>` tag.

{% aspTab template="chart/axis/multiple/line-break", sourceFiles="line-break.cs" %}

{% endaspTab %}

## Maximum Labels

`MaximumLabels` property is set, then the labels will be rendered based on the count in the property per 100 pixel. If you have set range (minimum, maximum, interval) and maximumLabels, then the priority goes to range only. If you haven’t set the range, then we have considered priority to maximumLabels property.

{% aspTab template="chart/axis/multiple/max-label", sourceFiles="max-label.cs" %}

{% endaspTab %}