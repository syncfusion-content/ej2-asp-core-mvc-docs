---
title: "Migration from Essential JS 1"
component: "LinearGauge"
description: "Explains the common steps for migrating from Essential JS 1 application to Essential JS 2 components especially, linear gauge component."
---

# Migration from Essential JS 1

This article describes the API migration process of Accordion component from Essential JS 1 to Essential JS 2.

## Linear gauge dimensions

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Height| **Property:** *height*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Height("150px")`|**Property:** *height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Height("150px").Render()`|
|Width| **Property:** *width*<br/><br/>`@Html.EJ().LinearGauge("container")` <br/> `.Width("200px")`|**Property:** *width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Width("200px").Render()`|
|Height(In Percentage)| Not Applicable |**Property:** *height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Height("70%").Render()`|
|Width(In Percentage)| Not Applicable |**Property:** *width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Height("100%").Render()`|

## Line customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Height| **Property:** *scales.length*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Length(300).Add()})`|**Property:** *axes.line.height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Line(line => line.Height(100)).Add())` <br/> `.Render()`|
|Width| **Property:** *scales.width*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Width(300).Add()})`|**Property:** *axes.line.width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Line(line => line.Width(50)).Add())` <br/> `.Render()`|
|Color| **Property:** *scales.backgroundColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.BackgroundColor("blue").Add()})`|**Property:** *axes.line.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Line(line => line.Color("Blue")).Add())` <br/> `.Render()`|
|Offset| Not Applicable |**Property:** *axes.line.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Line(line => line.Offset(2)).Add())` <br/> `.Render()`|
|Opacity| **Property:** *scales.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Opacity(0.2).Add()})`| Not Applicable |
|DashArray| Not Applicable |**Property:** *axes.line.dashArray*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Line(line => line.DashArray(1)).Add())` <br/> `.Render()`|

## Ticks

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Type of Ticks| **Property:** *scales.ticks.type*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval)}).Add()` <br/> `.Add()})`| **Property:** *axes.majorTicks.height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MajorTicks().Add())` <br/> `.Render()`|
|Height of Major Ticks| **Property:** *scales.ticks.height*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval).Height(8).Add()` <br/> `}).Add()})`|**Property:** *axes.majorTicks.height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(ma => ma.Height(8)).Add())` <br/> `.Render()`|
|Width of Major Ticks| **Property:** *scales.ticks.width*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval).Width(5).Add()` <br/> `}).Add()})`|**Property:** *axes.majorTicks.width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(ma => ma.Width(5)).Add())` <br/> `.Render()`|
|Color of Major Ticks| **Property:** *scales.ticks.color*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval).Color("Blue").Add()` <br/> `}).Add()})`|**Property:** *axes.majorTicks.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(ma => ma.Color("Blue")).Add())` <br/> `.Render()`|
|Offset for Major Ticks| **Property:** *scales.ticks.distanceFromScale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval)` <br/> `.distanceFromScale(5).Add();` <br/> `}).Add()})`|**Property:** *axes.majorTicks.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(ma => ma.Offset(2)).Add())` <br/> `.Render()`|
|Interval of Major Ticks| **Property:** *scales.majorIntervalValue*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.majorIntervalValue(15).Add()})`|**Property:** *axes.majorTicks.interval*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(ma => ma.Interval(15)).Add())` <br/> `.Render()`|
|Angle of Major Ticks| **Property:** *scales.ticks.angle*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval).Angle(30).Add();` <br/> `}).Add()})`| Not Applicable|
|Opacity of Major Ticks| **Property:** *scales.ticks.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MajorInterval).Opacity(0.2).Add();` <br/> `}).Add()})`| Not Applicable|
|Height of Minor Ticks| **Property:** *scales.ticks.height*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MinorInterval).Height(8).Add()` <br/> `}).Add()})`|**Property:** *axes.minorTicks.height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Height(8)).Add())` <br/> `.Render()`|
|Width of Minor Ticks| **Property:** *scales.ticks.width*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MinorInterval).Width(5).Add()` <br/> `}).Add()})`|**Property:** *axes.minorTicks.width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Width(5)).Add())` <br/> `.Render()`|
|Color of Minor Ticks| **Property:** *scales.ticks.color*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MinorInterval).Color("Blue").Add()` <br/> `}).Add()})`|**Property:** *axes.minorTicks.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Color("Blue")).Add())` <br/> `.Render()`|
|Offset for Minor Ticks| **Property:** *scales.ticks.distanceFromScale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MinorInterval)` <br/> `.distanceFromScale(5).Add();` <br/> `}).Add()})`|**Property:** *axes.minorTicks.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Offset(2)).Add())` <br/> `.Render()`|
|Interval of Minor Ticks| **Property:** *scales.minorIntervalValue*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.minorIntervalValue(15).Add()})`|**Property:** *axes.minorTicks.interval*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Interval(15)).Add())` <br/> `.Render()`|
|Angle of Minor Ticks| **Property:** *scales.ticks.angle*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MinorInterval).Angle(30).Add();` <br/> `}).Add()})`| Not Applicable|
|Opacity of Minor Ticks| **Property:** *scales.ticks.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ticks(tic => {tic.Type(TickType.MinorInterval).Opacity(0.2).Add();` <br/> `}).Add()})`| Not Applicable|

## Labels

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Angle| **Property:** *scales.labels.angle*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.Angle(15).Add();` <br/> `}).Add()})`| Not Applicable|
|Offset| **Property:** *scales.labels.distanceFromScale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.distanceFromScale(` <br/> `dis => {dis.x(15).Add();}).Add();` <br/> `}).Add()})`|**Property:** *axes.labelStyle.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Offset(2)).Add())` <br/> `.Render()`|
|Format| **Property:** *scales.labels.unitText*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.UnitText("F").Add();` <br/> `}).Add()})`|**Property:** *axes.labelStyle.format*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Format("C")).Add())` <br/> `.Render()`|
|Unit Text Placement| **Property:** *scales.labels.unitTextPlacement*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.UnitTextPlacement("Front").Add();` <br/> `}).Add()})`| Not Applicable|
|Label Range Color| Not Applicable|**Property:** *axes.labelStyle.useRangeColor*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.UseRangeColor(true))` <br/> `.Add()).Render()`|
|Opacity| **Property:** *scales.labels.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.Opacity(0.5)` <br/> `.Add();}).Add()})`|**Property:** *axes.labelStyle.font.opacity*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Font("fontstyle"))` <br/> `.Add()).Render()` <br/> `var fontstyle = new { opacity = 0.5 };`|
|Label Text Color| **Property:** *scales.labels.textColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.TextColor("red")` <br/> `.Add();}).Add()})`|**Property:** *axes.labelStyle.font.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Font("fontstyle"))` <br/> `.Add()).Render()` <br/> `var fontstyle = new { color= 'red' };`|
|Label Font Family| **Property:** *scales.labels.font.fontFamily*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.Font(fon => {fon.FontFamily("SegoeUI").Add();}).Add();` <br/> `}).Add()})`|**Property:** *axes.labelStyle.font.fontFamily*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Font("fontstyle"))` <br/> `.Add()).Render()` <br/> `var fontstyle = new { fontFamily: 'Arial' };`|
|Label Font Style| **Property:** *scales.labels.font.fontStyle*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.Font(fon => {fon.FontStyle("Normal").Add();}).Add();` <br/> `}).Add()})`|**Property:** *axes.labelStyle.font.fontStyle*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Font("fontstyle"))` <br/> `.Add()).Render()` <br/> `var fontstyle = new { fontStyle= 'Bold' };`|
|Label Size| **Property:** *scales.labels.font.size*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Labels(lab => {lab.Font(fon => {fon.Size("20px").Add();}).Add();` <br/> `}).Add()})`|**Property:** *axes.labelStyle.font.size*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Font("fontstyle"))` <br/> `.Add()).Render()` <br/> `var fontstyle = new { size= "15px" };`|
|Label Font Weight| Not Applicable|**Property:** *axes.labelStyle.font.fontWeight* <br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(lab => lab.Font("fontstyle"))` <br/> `.Add()).Render()` <br/> `var fontstyle = new { fontWeight= '4' };`|

## Axis

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Minimum Value| **Property:** *scales.minimum*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Minimum(20).Add()})`| **Property:** *axes.minimum*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Minimum(20).Add()).Render()`|
|Maximum Value| **Property:** *scales.maximum*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Maximum(20).Add()})`| **Property:** *axes.maximum*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Maximum(20).Add()).Render()`|
|Inverted Position| Not Applicable| **Property:** *axes.isInversed*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.IsInversed(true).Add()).Render()`|
|Opposed Position| Not Applicable| **Property:** *axes.opposedPosition*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.OpposedPosition(true).Add()).Render()`|

## Ranges

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Start Value| **Property:** *scales.ranges.startValue*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.StartValue(20)` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.start*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Start(20))` <br/> `.Add()).Render()`|
|End Value| **Property:** *scales.ranges.endValue*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.EndValue(20)` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.end*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.End(20))` <br/> `.Add()).Render()`|
|Start Width| **Property:** *scales.ranges.startWidth*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.StartWidth(20)` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.startWidth*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.StartWidth(20))` <br/> `.Add()).Render()`|
|End Width| **Property:** *scales.ranges.endWidth* <br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.EndWidth(20)` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.endWidth*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.EndWidth(20))` <br/> `.Add()).Render()`|
|Color| **Property:** *scales.ranges.backgroundColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.BackgroundColor("Red")` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Color("red"))` <br/> `.Add()).Render()`|
|Offset| **Property:** *scales.ranges.distanceFromScale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.DistanceFromScale(10)` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Offset(5))` <br/> `.Add()).Render()`|
|Range Position| **Property:** *scales.ranges.placement*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.Placement("Near")` <br/> `.Add();}).Add()})`| **Property:** *axes.ranges.position*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Position("Inside"))` <br/> `.Add()).Render()`|
|Opacity| **Property:** *scales.ranges.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.Opacity(0.5)` <br/> `.Add();}).Add()})`| Not Applicable|
|Border Customization| **Property:** *scales.ranges.border*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(ran => {ran.Border(bor => {bor.Color("green")` <br/> `.Width(2).Add();}).Add();}).Add()})`| **Property:** *axes.ranges.border*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Border(border))` <br/> `.Add()).Render()` <br/> `var border = new { color='green', width="2"};`|

## Bar Pointer

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Bar Pointer| **Property:** *scales.ranges.barPointers.value*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {br.Value(20).Add();}).Add()})`| **Property:** *axes.pointers.value*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar")).Add()).Render()`|
|Color of Bar Pointer| **Property:** *scales.ranges.barPointers.backgroundColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {br.Value(20)` <br/> `.backgroundColor("red").Add();}).Add()})`| **Property:** *axes.pointers.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").Color("Red")).Add()).Render()`|
|Offset of Bar Pointer| **Property:** *scales.ranges.barPointers.distanceFromScale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {br.distanceFromScale(20)` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").Offset(20)).Add()).Render()`|
|Opacity of Bar Pointer| **Property:** *scales.ranges.barPointers.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {br.Opacity(0.5)` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.opacity*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").Opacity(0.5)).Add()).Render()`|
|Width of Bar Pointer| **Property:** *scales.ranges.barPointers.width*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {br.Width(2)` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").Width(2)).Add()).Render()`|
|Gradients of Bar Pointer| **Property:** *scales.ranges.barPointers.gradients*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {` <br/> `br.gradients(gra => {gra.ColorStop(0).Color("#FFFFFF").Add();})` <br/> `.Add();}).Add()})`| Not Applicable|
|Border of Bar Pointer| **Property:** *scales.ranges.barPointers.border*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(BarPointers => {br.Border(bor => {bor.Color("red").Width(2).Add();})` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.border*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").Border(border)).Add()).Render()` <br/> `var border = new { color="red" width="2" };`|
|Animation of Bar Pointer| **Property:** *enableAnimation*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.EnableAnimation(true)`| **Property:** *axes.pointers.animationDuration*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").animationDuration(1000)).Add()).Render()`|
|Rounded Corner of Bar Pointer| Not Applicable| **Property:** *axes.pointers.roundedCornerRadius*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("RangeBar").RoundedCornerRadius(10)).Add()).Render()`|

## Marker Pointer

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Marker Pointer| **Property:** *scales.ranges.markerPointers.value*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Value(20).Add();}).Add()})`| **Property:** *axes.pointers.value*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker")).Add()).Render()`|
|Color of Marker Pointer| **Property:** *scales.ranges.markerPointers.backgroundColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Value(20).Color("Red").Add();}).Add()})`| **Property:** *axes.pointers.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").Color("Red")).Add()).Render()`|
|Offset of Marker Pointer| **Property:** *scales.ranges.markerPointers<br/>.distanceFromScale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Value(20).distanceFromScale(10).Add();})` <br/> `.Add()})`| **Property:** *axes.pointers.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").Offset(20)).Add()).Render()`|
|Opacity of Marker Pointer| **Property:** *scales.ranges.markerPointers.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Opacity(0.5)` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.opacity*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").Opacity(0.5)).Add()).Render()`|
|Width of Marker Pointer| **Property:** *scales.ranges.markerPointers.width*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Width(2)` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.width*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").Width(2)).Add()).Render()`|
|Gradients of Marker Pointer| **Property:** *scales.ranges.markerPointers<br/>.gradients*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {` <br/> `mr.gradients(gra => {gra.ColorStop(0).Color("#FFFFFF").Add();})` <br/> `.Add();}).Add()})`| Not Applicable|
|Border of Marker Pointer| **Property:** *scales.ranges.markerPointers.border*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Border(bor => {bor.Color("red").Width(2).Add();})` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.border*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").Border(border)).Add()).Render()` <br/> `var border = new { color="red" width="2" };`|
|Animation of Marker Pointer| **Property:** *enableMarkerPointerAnimation*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.EnableMarkerPointerAnimation(true)`| **Property:** *axes.pointers.animationDuration*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").animationDuration(1000)).Add()).Render()`|
|Type of Marker Pointer| **Property:** *scales.ranges.markerPointers.type*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Type("Diamond")` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.markerType*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").MarkerType("Diamond")).Add()).Render()`|
|Placement of Marker Pointer| **Property:** *scales.ranges.markerPointers<br/>.placement*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Ranges(MarkerPointers => {mr.Placement("Near")` <br/> `.Add();}).Add()})`| **Property:** *axes.pointers.placement*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").Placement("Near")).Add()).Render()`|
|Drag of Marker Pointer|  **Property:** *readOnly*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.ReadOnly(true)`| **Property:** *axes.pointers.enableDrag*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").EnableDrag(true)).Add()).Render()`|
|Image Marker Pointer| Not Applicable| **Property:** *axes.pointers.imageUrl*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Axes(axes => axes.pointers(po => po.Value(20)` <br/> `.Type("Marker").ImageUrl("")).Add()).Render()`|

## Annotation

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Content| **Property:** *scales.customLabels.value*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.Value("Linear Gauge")` <br/> `.Add();}).Add()})`| **Property:** *annotations.content*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.Content("Linear Gauge").Add()).Render()`|
|Horizontal Alignment| Not Applicable| **Property:** *annotations.horizontalAlignment*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.HorizontalAlignment("Center").Add()).Render()`|
|Vertical Alignment| Not Applicable| **Property:** *annotations.verticalAlignment*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.VerticalAlignment("Center").Add()).Render()`|
|Position of X| **Property:** *scales.customLabels.position.x*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.Position(po => {po.X(20).Add();})` <br/> `.Add();}).Add()})`| **Property:** *annotations.x*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.X(35).Add()).Render()`|
|Position of Y| **Property:** *scales.customLabels.position.y*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.Position(po => {po.Y(20).Add();})` <br/> `.Add();}).Add()})`| **Property:** *annotations.y*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.Y(35).Add()).Render()`|
|Z Index| Not Applicable| **Property:** *annotations.zIndex*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.ZIndex("1").Add()).Render()`|
|Axis Index| Not Applicable| **Property:** *annotations.axisIndex*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.AxisIndex("0").Add()).Render()`|
|Axis Value| Not Applicable| **Property:** *annotations.axisValue*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.AxisValue("35").Add()).Render()`|
|Font customization| **Property:** *scales.customLabels.font*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.Font(fo => {fo.Size("20px").Add();})` <br/> `.Add();}).Add()})`| **Property:** *annotations.font*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.Font(font).Add()).Render()` <br/> `var font =new {size='12px'}`|
|Annotation Color| **Property:** *scales.customLabels.color*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.Color("Red")` <br/> `.Add();}).Add()})`| **Property:** *annotations.font.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.Font(font).Add()).Render()` <br/> `var font =new {color ="red"}`|
|Opacity of Annotation| **Property:** *scales.customLabels.opacity*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.Opacity(0.4)` <br/> `.Add();}).Add()})`| **Property:** *annotations.font.opacity*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Annotations(ann => ann.Font(font).Add()).Render()` <br/> `var font =new {opacity ="0.4"}`|
|Position Type| **Property:** *scales.customLabels.positionType*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.PositionType("Outer")` <br/> `.Add();}).Add()})`| Not applicable|
|TextAngle of Annotation| **Property:** *scales.customLabels.textAngle*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.customLabels(cus => {cus.TextAngle(25)` <br/> `.Add();}).Add()})`| Not applicable|

## Tooltip

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Tooltip for Pointer| Not Applicable| **Property:** *tooltip.enable*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.Enable(true).Add()).Render()`|
|Tooltip for Label|  **Property:** *tooltip.showLabelTooltip*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.tooltip(tool => {tool.ShowLabelTooltip(true)` <br/> `.Add();}).Add()})`| Not Applicable|
|Tooltip Format| Not Applicable| **Property:** *tooltip.format*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.Format(${pointers.value}).Add()).Render()`|
|Tooltip Color| Not Applicable| **Property:** *tooltip.fill*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.Fill("Gray").Add()).Render()`|
|Tooltip Template| **Property:** *tooltip.templateID*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.tooltip(tool => {tool.TemplateId(true)` <br/> `.Add();}).Add()})`| **Property:** *tooltip.template*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.Template("Temaplate").Add()).Render()`|
|Tooltip Animation| Not Applicable| **Property:** *tooltip.enableAnimation*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.EnableAnimation(true).Add()).Render()`|
|Tooltip Border| Not Applicable| **Property:** *tooltip.border*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.Border(border).Add()).Render()` <br/> `var border = new {width: 2, color: 'red'}`|
|Tooltip TextStyle| Not Applicable| **Property:** *tooltip.textStyle*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Tooltip(tool => tool.TextStyle("Bold").Add()).Render()`|

## Appearance of Linear Gauge

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Background Color| **Property:** *backgroundColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.BackgroundColor("red")`| **Property:** *background*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Background("Red").Render()`|
|Border Color| **Property:** *borderColor*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.BorderColor("blue")`| **Property:** *border.color*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Border(border).Render()` <br/> `var border= new {color="red"}`|
|Margin| Not Applicable| **Property:** *margin*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Margin(margin).Render()` <br/> `var margin= new {left: 40, right: 40, top: 40, bottom: 40}`|
|Orientation| **Property:** *orientation*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Orientation("Vertical")`| **Property:** *orientation*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Orientation("Vertical").Render()`|
|Locale| **Property:** *locale*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Locale("en-US")`| **Property:** *locale*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Locale("en-US").Render()`|
|Theme| **Property:** *theme*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Theme("saffron")`| **Property:** *theme*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Theme("Material").Render()`|
|Gauge Title| Not Applicable| **Property:** *title*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Title("LinearGauge").Render()`|

## Gauge Container type

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Container Type| **Property:** *scales.type*<br/><br/> `@Html.EJ().LinearGauge("container")` <br/> `.Scales(sc => {sc.Type("Thermometer").Add()})`| **Property:** *container.type*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Container(con => con.Type("Thermometer").Add())` <br/> `.Render()`|
|Container Height| Not Applicable| **Property:** *container.height*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Container(con => con.Type("Thermometer").Height(20).Add())` <br/> `.Render()`|
|Container Width| Not Applicable| **Property:** *container.width*<br/><br/>  `@Html.EJS().LinearGauge("container")` <br/> `.Container(con => con.Type("Thermometer").Width(10).Add())` <br/> `.Render()`|
|Container Offset| Not Applicable| **Property:** *container.offset*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Container(con => con.Type("Thermometer").Offset(5).Add())` <br/> `.Render()`|

## Events

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Animation Complete Event| Not Applicable| **Event:** *animationComplete*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.AnimationComplete("animationComplete").Render()` <br/> `function animationComplete(args) {}`|
|Annotation Render Event| **Event:** *drawCustomLabel*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawCustomLabel("customLabel")`<br/> `function customLabel(args) {}`| **Event:** *annotationRender*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.AnnotationRender("annotationRender").Render()` <br/> `function annotationRender(args) {}`|
|AxisLabel Render Event| **Event:** *drawLabels*<br/><br/>  `@Html.EJ().CircularGauge("container")` <br/> `.DrawLabels("drawLabels")`<br/> `function drawLabels(args) {}`| **Event:** *axisLabelRender*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.AxisLabelRender("axisLabelRender").Render()` <br/> `function axisLabelRender(args) {}`|
|Load Event| **Event:** *load*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Load("load")`<br/> `function load(args) {}`| **Event:** *load*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Load("load").Render()` <br/> `function load(args) {}`|
|Loaded Event| Not Applicable| **Event:** *loaded*<br/><br/>  `@Html.EJS().LinearGauge("container")` <br/> `.Loaded("loaded").Render()` <br/> `function loaded(args) {}`|
|Resize Event| Not Applicable| **Event:** *resized*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.Resized("resized").Render()` <br/> `function resized(args) {}`|
|Tooltip Render Event| Not Applicable| **Event:** *tooltipRender*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.TooltipRender("tooltipRender").Render()` <br/> `function tooltipRender(args) {}`|
|Value Change Event| Not Applicable| **Event:** *valueChange*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.ValueChange("valueChange").Render()` <br/> `function valueChange(args) {}`|
|Mouse Move Event| **Event:** *mouseClickMove*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.MouseClickMove("mouseClickMove")`<br/> `function mouseClickMove(args) {}`| **Event:** *gaugeMouseMove*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.GaugeMouseMove("gaugeMouseMove").Render()` <br/> `function gaugeMouseMove(args) {}`|
|Mouse Up Event| **Event:** *mouseClickUp*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.MouseClickUp("mouseClickUp")`<br/> `function mouseClickUp(args) {}`| **Event:** *gaugeMouseUp*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.GaugeMouseUp("gaugeMouseUp").Render()` <br/> `function gaugeMouseUp(args) {}`|
|Mouse Down Event| Not Applicable| **Event:** *gaugeMouseDown*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.GaugeMouseDown("gaugeMouseDown").Render()` <br/> `function gaugeMouseDown(args) {}`|
|Mouse Leave Event| Not Applicable| **Event:** *gaugeMouseLeave*<br/><br/> `@Html.EJS().LinearGauge("container")` <br/> `.GaugeMouseLeave("gaugeMouseLeave").Render()` <br/> `function gaugeMouseLeave(args) {}`|
|Mouse Click Event| **Event:** *mouseClick*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.MouseClick("mouseClick")`<br/> `function mouseClick(args) {}`| Not Applicable|
|Render Complete Event| **Event:** *renderComplete*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.RenderComplete("renderComplete")`<br/> `function renderComplete(args) {}`| Not Applicable|
|Double Click Event| **Event:** *doubleClick*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DoubleClick("doubleClick")`<br/> `function doubleClick(args) {}`| Not Applicable|
|Right Click Event| **Event:** *rightClick*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.RightClick("rightClick")`<br/> `function rightClick(args) {}`| Not Applicable|
|BarPointers Event| **Event:** *drawBarPointers*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawBarPointers("drawBarPointers")`<br/> `function drawBarPointers(args) {}`| Not Applicable|
|Indicators Event| **Event:** *drawIndicators*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawIndicators("drawIndicators")`<br/> `function drawIndicators(args) {}`| Not Applicable|
|MarkerPointer Event| **Event:** *drawMarkerPointers*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawMarkerPointers("drawMarkerPointers")`<br/> `function drawMarkerPointers(args) {}`| Not Applicable|
|Ranges Event| **Event:** *drawRange*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawRange("drawRange")`<br/> `function drawRange(args) {}`| Not Applicable|
|Gauge Initialized Event| **Event:** *init*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Init("init")`<br/> `function init(args) {}`| Not Applicable|