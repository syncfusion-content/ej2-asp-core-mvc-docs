---
title: " Chart Axis Labels | ASP.NET MVC "

component: "Chart"

description: "Chart contains smart axis labels, label positioning, multilevelabels, text customization and sorting properties "
---

# Axis Labels

## Smart Axis Labels

When the axis labels overlap with each other, you can use [`LabelIntersectAction`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelIntersectAction)
property in the axis, to place them smartly.

When setting `LabelIntersectAction` as `Hide`

{% aspTab template="chart/axis/multiple/hide", sourceFiles="hide.cs" %}

{% endaspTab %}

When setting `LabelIntersectAction` as `Rotate45`

{% aspTab template="chart/axis/multiple/rotate45", sourceFiles="rotate45.cs" %}

{% endaspTab %}

When setting `LabelIntersectAction` as `Rotate90`

{% aspTab template="chart/axis/multiple/rotate90", sourceFiles="rotate90.cs" %}

{% endaspTab %}

## Axis Labels Positioning

By default, the axis labels can be placed at `Outside` the axis line and this also can be placed at `Inside`
the axis line using the `LabelPosition` property.

{% aspTab template="chart/axis/multiple/position", sourceFiles="position.cs" %}

{% endaspTab %}

## Multilevel Labels

Any number of levels of labels can be added to an axis using the `MultiLevelLabels` property. This property can be
configured using the following properties:

• Categories
• Overflow
• Alignment
• Text style
• Border

### Categories

Using the categories property, you can configure the `Start`, `End`, `Text`, and `MaximumTextWidth` of multilevel labels.

{% aspTab template="chart/axis/multiple/multi-category", sourceFiles="category.cs" %}

{% endaspTab %}

### Overflow

Using the `Overflow` property, you can `Trim` or `Wrap` the multilevel labels.

{% aspTab template="chart/axis/multiple/multi-overflow", sourceFiles="overflow.cs" %}

{% endaspTab %}

### Alignment

The `Alignment` property provides option to position the multilevel labels at `Far`, `Center`, or `Near`.

{% aspTab template="chart/axis/multiple/multi-alignment", sourceFiles="alignement.cs" %}

{% endaspTab %}

### Text customization

The `TextStyle` property of multilevel labels provides options to customize the `Size`, `Color`, `FontFamily`,
`FontWeight`, `FontStyle`, `Opacity`, `TextAlignment` and `TextOverflow`.

{% aspTab template="chart/axis/multiple/multi-textcustom", sourceFiles="text-custom.cs" %}

{% endaspTab %}

### Border customization

Using the `Border` property, you can customize the `Width`, `Color`, and `Type`. The `Type` of border
are `Rectangle`, `Brace`, `WithoutBorder`, `WithoutTopBorder`, `WithoutTopandBottomBorder` and `CurlyBrace`.

{% aspTab template="chart/axis/multiple/multi-bordercustom", sourceFiles="border-custom.cs" %}

{% endaspTab %}

## Edge Label Placement

Labels with long text at the edges of an axis may appear partially in the chart. To avoid this,
use [`EdgeLabelPlacement`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EdgeLabelPlacement) property in axis, which moves
the label inside the chart area for better appearance or hides it.

{% aspTab template="chart/axis/multiple/edge", sourceFiles="edge.cs" %}

{% endaspTab %}

## Labels Customization

The [`LabelStyle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_LabelStyle) property of an axis provides options to customize the
`Color`, `Font-family`, `Font-size` and `Font-weight` of the axis labels.

{% aspTab template="chart/axis/multiple/labels-custom", sourceFiles="labels-custom.cs" %}

{% endaspTab %}

## Customizing Specific Point

You can customize the specific text in the axis labels using `AxisLabelRender` event.

{% aspTab template="chart/axis/multiple/custom-point", sourceFiles="custom-point.cs" %}

{% endaspTab %}

## Trim using maximum label width

You can trim the label using [`EnableTrim`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_EnableTrim) property and width of the labels can also be customized using [`MaximumLabelWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Charts.ChartAxis.html#Syncfusion_EJ2_Charts_ChartAxis_MaximumLabelWidth) property in the axis, the value maximum label width is `34` by default.

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