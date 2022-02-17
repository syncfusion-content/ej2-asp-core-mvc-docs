---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Circular Gauge Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Accordion component from Essential JS 1 to Essential JS 2.

## Circular gauge dimensions

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Height| **Property:** *height*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Height("400px")`|**Property:** *height*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Height("400px").Render()`|
|Width| **Property:** *width*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Width("100px")`|**Property:** *width*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Height("150px").Render()`|
|Height(In Percentage)| Not Applicable|**Property:** *height*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Height("50%").Render()`|
|Width(In Percentage)| Not Applicable|**Property:** *width*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Height("80%").Render()`|

## Axis Line

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Axisline Width| **Property:** *scales.size*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.ShowScaleBar(true)` <br/> `.size(1).Add())`|**Property:** *axes.lineStyle.width*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LineStyle(new CircularGaugeLine` <br/> `{ Width = 0 }).Add()).Render()`|
|Axisline Color| **Property:** *scales.color*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.ShowScaleBar(true)` <br/> `.color('red').Add())`|**Property:** *axes.lineStyle.color*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LineStyle(new CircularGaugeLine` <br/> `{ color = 'red' }).Add()).Render()`|
|Axisline BackgroundColor| Not Applicable|**Property:** *axes.background*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Background("red")` <br/> `.Add()).Render()`|
|Axisline Direction| **Property:** *scales.direction*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.Direction('CounterClockwise')` <br/> `.color('red').Add())`|**Property:** *axes.direction*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Direction(GaugeDirection.AntiClockWise)` <br/> `.Add()).Render()`|
|Axisline Radius| **Property:** *scales.radius*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.Radius('150').color('red').Add())`|**Property:** *axes.radius*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Radius(150)` <br/> `.Add()).Render()`|
|Axisline Startangle| **Property:** *scales.startAngle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.startAngle('150')` <br/> `.color('red').Add())`|**Property:** *axes.startAngle*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.StartAngle(150)` <br/> `.Add()).Render()`|
|Axisline Endangle| **Property:** *scales.sweepAngle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.sweepAngle('150').color('red')` <br/> `.Add())>`|**Property:** *axes.endAngle*<br/><br/> `@Html.EJS().CircularGauge("container").Axes(axes => axes.EndAngle(70).Add()).Render()`|
|Minimum Axisvalue| **Property:** *scales.minimum*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.Minimum(20)` <br/> `.Add())`|**Property:** *axes.minimum*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Minimum(20)` <br/> `.Add()).Render()`|
|Maximum Axisvalue| **Property:** *scales.maximum*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.maximum(200).Add())`|**Property:** *axes.maximum*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Maximum(200)` <br/> `.Add()).Render()`|

## Ticks

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Type of Ticks| **Property:** *scales.ticks.type*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Major)` <br/> `.Add()}).Add()})`| **Property:** *axes.majorTicks*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MajorTicks.Add())` <br/> `.Render()`|
|Height of Major Ticks| **Property:** *scales.ticks.height*<br/><br/>  `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Major)` <br/> `.Height(12).Add()}).Add()})`| **Property:** *axes.majorTicks.height*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(mi => mi.Height(12))` <br/> `.Add()).Render()`|
|Width of Major Ticks| **Property:** *scales.ticks.width*<br/><br/>  `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Major)` <br/> `.Width(3).Add()}).Add()})`| **Property:** *axes.majorTicks.width*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(mi => mi.Width(2))` <br/> `.Add()).Render()`|
|Color of Major Ticks| **Property:** *scales.ticks.color*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Major)` <br/> `.color('red').Add()}).Add()})`| **Property:** *axes.majorTicks.color*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(mi => mi.Color("red"))` <br/> `.Add()).Render()`|
|Offset of Major Ticks| **Property:** *scales.ticks.distanceFromScale*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Major)` <br/> `.DistanceFromScale(10).Add()}).Add()})`| **Property:** *axes.majorTicks.offset*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(mi => mi.Offset(5))` <br/> `.Add()).Render()`|
|Angle of Major Ticks| **Property:** *scales.ticks.angle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Major)` <br/> `.Angle(10).Add()}).Add()})`| Not Applicable|
|Interval of Major Ticks| **Property:** *scales.majorIntervalValue*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {MajorIntervalValue(10)` <br/> `.Add()})`| **Property:** *axes.majorTicks.interval*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MajorTicks(mi => mi.Interval(2))` <br/> `.Add()).Render()`|
|Height of Minor Ticks| **Property:** *scales.ticks.height*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Minor)` <br/> `.Height(12).Add()}).Add()})`| **Property:** *axes.minorTicks.height*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Height(12))` <br/> `.Add()).Render()`|
|Width of Minor Ticks| **Property:** *scales.ticks.width*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Minor)` <br/> `.Width(3).Add()}).Add()})`| **Property:** *axes.minorTicks.width*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Width(2))` <br/> `.Add()).Render()`|
|Color of Minor Ticks| **Property:** *scales.ticks.color*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Minor)` <br/> `.color('red').Add()}).Add()})`| **Property:** *axes.minorTicks.color*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Color("red"))` <br/> `.Add()).Render()`|
|Offset of Minor Ticks| **Property:** *scales.ticks.distanceFromScale*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Minor)` <br/> `.DistanceFromScale(10).Add()}).Add()})`| **Property:** *axes.minorTicks.offset*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Offset(5))` <br/> `.Add()).Render()`|
|Angle of Major Ticks| **Property:** *scales.ticks.angle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ticks(tic => {tic.Type(CircularTickTypes.Minor)` <br/> `.Angle(10).Add()}).Add()})`| Not Applicable|
|Interval of Minor Ticks| **Property:** *scales.MinorIntervalValue*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {MinorIntervalValue(10)` <br/> `.Add()})`| **Property:** *axes.minorTicks.interval*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.MinorTicks(mi => mi.Interval(2))` <br/> `.Add()).Render()`|

## Labels

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Autoangle| **Property:** *scales.labels.autoAngle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.showLabels(true)` <br/> `.Add()}).Add()})`| **Property:** *axes.labelStyle.autoAngle*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.AutoAngle(true))` <br/> `.Add()).Render()`|
|Angle| **Property:** *scales.labels.angle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => sc.showLabels(true).Labels(lbl => {lbl.Angle(20)` <br/> `.Add()}).Add()})`| Not Applicable|
|Offset| **Property:** *scales.labels.distanceFromScales*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.DistanceFromScale(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.labelStyle.offset*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Offset(5))` <br/> `.Add()).Render()`|
|Format| **Property:** *scales.labels.unitText*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.UnitText("Front")` <br/> `.Add()}).Add()})`| **Property:** *axes.labelStyle.format*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Format("KMPH"))` <br/> `.Add()).Render()`|
|UnitText Position| **Property:** *scales.labels.placement*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.Placement("Near")` <br/> `.Add()}).Add()})`| **Property:** *axes.labelStyle.position*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Position(Position.Inside))` <br/> `.Add()).Render()`|
|Label Range Color| Not Applicable| **Property:** *axes.labelStyle.useRangeColor*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.UseRangeColor(true))` <br/> `.Add()).Render()`|
|LabelText Color| **Property:** *scales.labels.color*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.Color("red")` <br/> `.Add()}).Add()})`| **Property:** *axes.labelStyle.font.color*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Font(fo => fo.Color("red"))` <br/> `.Add()).Render()`|
|Opacity| **Property:** *scales.labels.opacity*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.Opacity(0.2)` <br/> `.Add()}).Add()})`| **Property:** *axes.labelStyle.font.opacity*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Font(fo => fo.Opacity(0.5)))` <br/> `.Add()).Render()`|
|Label Font Family| **Property:** *scales.labels.font.fontFamily*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.font('font').Add()})` <br/> `.Add()})` <br/> `var font = new {fontFamily="aerial"}`| **Property:** *axes.labelStyle.font.fontFamily*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Font(fo => fo.FontFamily("Robato")))` <br/> `.Add()).Render()`|
|Label Font Style| **Property:** *scales.labels.font.fontStyle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.font('font')` <br/> `.Add()}).Add()})`<br/>`var font = new {font-style="bold"}`| **Property:** *axes.labelStyle.font.fontStyle*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Font(fo => fo.FontStyle("Bold")))` <br/> `.Add()).Render()`|
|Label Font Size| **Property:** *scales.labels.font.size*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Labels(lbl => {lbl.font('font').Add()})` <br/> `.Add()})`<br/>`var font = new {size="12"}`| **Property:** *axes.labelStyle.font.size*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Font(fo => fo.Size("12")))` <br/> `.Add()).Render()`|
|Label Font Weight| Not Applicable| **Property:** *axes.labelStyle.font.fontWeight*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.LabelStyle(ls => ls.Font(fo => fo` <br/> `.FontWeight("Regular"))).Add()).Render()`|

## Ranges

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Start Value| **Property:** *scales.ranges.startValue*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.StartValue(20)` <br/> `.Add()}).Add()})`| **Property:** *axes.ranges.start*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Start(20))` <br/> `.Add()).Render()`|
|End Value| **Property:** *scales.ranges.endValue*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.EndValue(30)` <br/> `.Add()}).Add()})`| **Property:** *axes.ranges.end*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.End(30))` <br/> `.Add()).Render()`|
|Start Width| **Property:** *scales.ranges.startWidth*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.StartWidth(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.ranges.startWidth*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.StartWidth(10))` <br/> `.Add()).Render()`|
|End Width| **Property:** *scales.ranges.endWidth*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.EndWidth(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.ranges.endWidth*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.EndWidth(10))` <br/> `.Add()).Render()`|
|Color| **Property:** *scales.ranges.backgroundColor*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.BackgroundColor('red')` <br/> `.Add()}).Add()})`| **Property:** *axes.ranges.color*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Color("red"))` <br/> `.Add()).Render()`|
|Offset| **Property:** *scales.ranges.distanceFromScale*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.DistanceFromScale(10))` <br/> `.Add()}).Add()})`| Not Applicable|
|Placement| **Property:** *scales.ranges.placement*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.Placement('Far'))` <br/> `.Add()}).Add()})`| Not Applicable|
|Opacity| **Property:** *scales.ranges.opacity*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.Opacity(0.5)` <br/> `.Add()}).Add()})`|Not Applicable|
|Radius| Not Applicable| **Property:** *axes.ranges.radius*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.Radius("30"))` <br/> `.Add()).Render()`|
|Rounded Corner Radius| Not Applicable| **Property:** *axes.ranges.roundedCornerRadius*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Ranges(ran => ran.RoundedCornerRadius(10)).Add())` <br/> `.Render()`|
|Border| **Property:** *scales.ranges.border*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Ranges(ran => {ran.Border.Color('blue')` <br/> `.Add()}).Add()})`| Not Applicable|

## Needle Pointer

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Needle Pointer| **Property:** *scales.pointers.type*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Type(PointerType.Needle)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.type*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Needle)` <br/> `.Value(20)).Add()).Render()`|
|Needle Pointer Color| **Property:** *scales.pointers.backgroundColor*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.BackgroundColor('red')` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.color*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Color("red"))` <br/> `.Add()).Render()`|
|Animation| **Property:** *enableAnimation*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.EnableAnimation(true)`| **Property:** *axes.pointers.animation*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Animation(true))` <br/> `.Add()).Render()` |
|Pointer Width| **Property:** *scales.pointers.width*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Width(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.pointerWidth*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.PointerWidth(10))` <br/> `.Add()).Render()`|
|Pointer Radius|**Property:** *scales.pointers.distanceFromScale*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.DistanceFromScale(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.radius*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Radius("10"))` <br/> `.Add()).Render()`|
|Opacity| **Property:** *scales.pointers.opacity*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Opacity(0.5)` <br/> `.Add()}).Add()})`| Not Applicable|
|Needle Type| **Property:** *scales.pointers.needleType*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.NeedleType("Triangle")` <br/> `.Add()}).Add()})`| Not Applicable|
|Back Needle Length| **Property:** *scales.pointers.backNeedleLength*<br/><br/>  `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.BackNeedleLength(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.needleTail.length*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.NeedleTail(nd => nd.Length("10")))` <br/> `.Add()).Render()`|

## Marker Pointer

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Marker Pointer| **Property:** *scales.pointers.type*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Type(PointerType.Marker)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.type*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Marker)` <br/> `.Value(20)).Add()).Render()`|
|Marker Type| **Property:** *scales.pointers.markerType*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.MarkerType(MarkerType.Diamond)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.markerShape*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Marker)` <br/> `.MarkerShape(GaugeShape.Diamond)).Add()).Render()`|
|Marker Width| **Property:** *scales.pointers.width*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Width(10)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.markerWidth*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Marker)` <br/> `.MarkerWidth(10)).Add()).Render()`|
|Marker Height| **Property:** *scales.pointers.length*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Length(20)` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.markerHeight*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Marker)` <br/> `.MarkerHeight(20)).Add()).Render()`|
|Marker Image| **Property:** *scales.pointers.imageUrl*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.ImageUrl('a.png')` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.imageUrl*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Marker)` <br/> `.ImageUrl("a.png")).Add()).Render()`|
|Border Customization| **Property:** *scales.pointers.border*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {Pointers(po => {po.Border.Color('red')` <br/> `.Add()}).Add()})`| **Property:** *axes.pointers.border*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.Marker).Border(bo => bo.Color("red")` <br/> `.Width(2))).Add()).Render()`|

## Rangebar Pointer

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Rangebar| Not Applicable| **Property:** *axes.pointers.type*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.RangeBar)` <br/> `.Value(20)).Add()).Render()`|
|Rounded Corner Radius| Not Applicable| **Property:** *axes.pointers.roundedCornerRadius*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Pointers(pt => pt.Type(PointerType.RangeBar)` <br/> `.RoundedCornerRadius(10).Add()).Render()`|

## Annotations

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Content| **Property:** *scales.customLabels.value*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {CustomLabels(c1 =>` <br/> `{c1.Value("Circular Gauge")` <br/> `.Add()}).Add()})`| **Property:** *axes.annotations.content*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.Content("Circular Gauge"))` <br/> `.Add()).Render()`|
|Angle| **Property:** *scales.customLabels.textAngle*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {CustomLabels(c1 =>` <br/> `{c1.TextAngle(90)` <br/> `.Add()}).Add()})`| **Property:** *axes.annotations.angle*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.Angle(90))` <br/> `.Add()).Render()`|
|Font Family| **Property:** *scales.customLabels.font.fontFamily*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {CustomLabels(c1 =>` <br/> `{c1.Font(fon => fon.` <br/> `FontFamily("Arial").Add()).Add()}).Add()})`| **Property:** *axes.annotations.textStyle.fontFamily*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.TextStyle(text => text.FontFamily("Roboto")))` <br/> `.Add()).Render()`|
|Font Color| **Property:** *scales.customLabels.color*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {CustomLabels(c1 => {c1.Color('red')` <br/> `.Add()}).Add()})`| **Property:** *axes.annotations.textStyle.color*<br/><br/> `@html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.TextStyle(text => text.Color("Red"))` <br/> `.Add()).Render()`|
|Auto Angle| Not Applicable| **Property:** *axes.annotations.autoAngle*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.AutoAngle(true))` <br/> `.Add()).Render()`|
|Radius| Not Applicable| **Property:** *axes.annotations.radius*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.Radius("10"))` <br/> `.Add()).Render()`|
|Annotation Position| **Property:** *scales.customLabels.position*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {CustomLabels(c1 =>` <br/> `{c1.Position(pos => pos.X(5)` <br/> `.Y(-10).Add()).Add()}).Add()})`| Not Applicable|
|Annotation Position Type| **Property:** *scales.customLabels.positionType*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Scales(sc => {CustomLabels(c1 =>` <br/> `{c1.CustomLabelPositionType` <br/> `(CustomLabelPositionType.Outer)` <br/> `.Add()}).Add()})`| Not Applicable|
|ZIndex| Not Applicable| **Property:** *axes.annotations.zIndex*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Axes(axes => axes.Annotations(an => an.ZIndex("1"))` <br/> `.Add()).Render()`|

## Appearance

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Title| Not Applicable| **Property:** *title*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Title("Circular Gauge").Render()`|
|Background Color| **Property:** *backgroundColor*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.BackgroundColor('red')`| **Property:** *background*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Background("Red").Render()`|
|Localization| **Property:** *locale*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Locale('en-US')`| **Property:** *locale*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Locale("en-US").Render()`|
|Border| Not Applicable| **Property:** *border*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Border(bo => bo.Color("red").Width(2)).Render()`|
|Center of X| Not Applicable| **Property:** *centerX*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.CenterX("120px").Render()`|
|Center of Y| Not Applicable| **Property:** *centerY*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.CenterY("150px").Render()`|
|Theme| **Property:** *theme*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Theme('Material')`| **Property:** *theme*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Theme(GaugeTheme.Material).Render()`|
|Margin| Not Applicable| **Property:** *margin*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Margin(mar => mar.Left(10).Right(10)).Render()`|

## Events

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Annotation Event| **Event:** *drawCustomLabel*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawCustomLabel("customLabel")`<br/> `function customLabel(args) {}`| **Event:** *annotationRender*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.AnnotationRender("annotationRender").Render()` <br/> `<script>function annotationRender(args) {}</script>`|
|Label Event| **Event:** *drawLabels*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawLabels("drawLabels")` <br/> `function drawLabels(args) {}`| **Event:** *axisLabelRender*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.AxisLabelRender("axisLabelRender").Render()` <br/> `<script>function axisLabelRender(args) {}</script>`|
|Load Event| **Event:** *load*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Load("load")` <br/> `function load(args) {}`| **Event:** *load*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Load("load").Render()` <br/> `<script>function load(args) {}</script>`|
|Loaded Event| **Event:** *loaded*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.Loaded("loaded")` <br/> `function loaded(args) {}`| **Event:** *loaded*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Loaded("loaded").Render()` <br/> `<script>function loaded(args) {}</script>`|
|Tooltip Rendered Event| Not Applicable| **Event:** *tooltipRender*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.TooltipRender("tooltipRender").Render()` <br/> `<script>function tooltipRender(args) {}</script>`|
|Resized Rendered Event| Not Applicable| **Event:** *resized*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.Resized("resized").Render()` <br/> `function resized(args) {}`|
|Animation Event| Not Applicable| **Event:** *animationComplete*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.AnimationComplete("animationComplete").Render()` <br/> `<script>function animationComplete(args) {}</script>`|
|Mousedown Event| **Event:** *mouseClick*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.MouseClick("mouseClick")`<br/> `function mouseClick(args) {}`| **Event:** *gaugeMouseDown*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.GaugeMouseDown("gaugeMouseDown").Render()` <br/> `<script>function gaugeMouseDown(args) {}</script>`|
|Mousemove Event| **Event:** *mouseClickMove*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.MouseClickMove("mouseClickMove")`<br/> `function mouseClickMove(args) {}`| **Event:** *gaugeMouseLeave*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.GaugeMouseLeave("gaugeMouseLeave").Render()` <br/> `<script>function gaugeMouseLeave(args) {}</script>`|
|Mouseup Event| **Event:** *mouseClickUp*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.MouseClickUp("mouseClickUp")`<br/> `function mouseClickUp(args) {}`| **Event:** *gaugeMouseUp*<br/><br/>  `@Html.EJS().CircularGauge("container")` <br/> `.GaugeMouseUp("gaugeMouseUp").Render()` <br/> `<script>function gaugeMouseUp(args) {}</script>`|
|Pointerdrag Move Event| **Event:** *drawPointers*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawPointers("drawPointers")`<br/> `function drawPointers(args) {}`| **Event:** *dragMove*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.DragMove("dragMove").Render()` <br/> `<script>function dragMove(args) {}</script>`|
|Draw Range Event| **Event:** *drawRange*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawRange("drawRange")`<br/> `function drawRange(args) {}`| Not Applicable|
|Draw Ticks Event| **Event:** *drawTicks*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DrawTicks("drawTicks")`<br/> `function drawTicks(args) {}`| Not Applicable|
|Legend Render Event| **Event:** *legendItemRender*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.LegendItemRender("legendItemRender")`<br/> `function legendItemRender(args) {}`| Not Applicable|
|Animation Complete Event| Not Applicable| **Event:** *animationComplete*<br/><br/> `@Html.EJS().CircularGauge("container")` <br/> `.AnimationComplete("animationComplete").Render()` <br/> `<script>function animationComplete(args) {}</script>`|
|Right Click Event| **Event:** *rightClick*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.RightClick("rightClick")`<br/> `function rightClick(args) {}`| Not Applicable|
|Double Click Event| **Event:** *doubleClick*<br/><br/> `@Html.EJ().CircularGauge("container")` <br/> `.DoubleClick("doubleClick")`<br/> `function doubleClick(args) {}`| Not Applicable|