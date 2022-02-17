---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Sparkline Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Sparkline component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Accordion component from Essential JS 1 to Essential JS 2.

## Sparkline Types

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Type| **Property:** *type*<br/><br/> `@(Html.EJ().Sparkline("container").Type(SparklineType.Column))`| **Property:** *type*<br/><br/> `@Html.EJS().Sparkline("container").Type(Syncfusion.EJ2.Charts.SparklineType.Area).Render()` |

## Databinding

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Datasource| **Property:** *dataSource*<br/><br/> `@(Html.EJ().Sparkline("container").DataSource(ViewBag.SparklineData))` |**Property:** *dataSource*<br/><br/> `@Html.EJS().Sparkline("container").DataSource(ViewBag.datasource).Render()`|
|Binding X values with datasource| **Property:** *xName*<br/><br/> `@(Html.EJ().Sparkline("container").XName("Month"))` |**Property:** *xName*<br/><br/> `@Html.EJS().Sparkline("container").XName("Month").Render()`|
|Binding Y values with datasource| **Property:** *yName*<br/><br/> `@(Html.EJ().Sparkline("container").YName("Sales"))` |**Property:** *yName*<br/><br/> `@Html.EJS().Sparkline("container").YName("Sales").Render()`|

## Markers

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable markers| **Property:** *markerSettings.visible*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Visible(true)))`| **Property:** *markerSettings.visible*<br/><br/> `@Html.EJS().Sparkline("container").MarkerSettings(ms =>ms.Visible(new string[] {"All"})).Render()`|
|Color| **Property:** *markerSettings.fill*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Fill("red")))` |**Property:** *markerSettings.fill*<br/><br/> `@Html.EJS().Sparkline("container").MarkerSettings(ms =>ms.Fill("red")).Render()`|
|Size| **Property:** *markerSettings.width*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Width(10)))`  |**Property:** *markerSettings.size*<br/><br/> `@Html.EJS().Sparkline("container").MarkerSettings(ms =>ms.Size(10)).Render()`|
|Opacity| **Property:** *markerSettings.opacity*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Opacity(0.5)))` |**Property:** *markerSettings.opacity*<br/><br/> `@Html.EJS().Sparkline("container").MarkerSettings(ms =>ms.Opacity(0.5)).Render()`|
|Border color| **Property:** *markerSettings.border.color*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Border(br=> br.Color("black")))`| **Property:** *markerSettings.border.color*<br/><br/> `@Html.EJS().Sparkline("container").MarkerSettings(ms =>ms.Border(br=> br.Color("Black"))).Render()`|
|Border width| **Property:** *markerSettings.border.width*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Border(br=> br.Width(1)))` |**Property:** *markerSettings.border.width*<br/><br/> `@Html.EJS().Sparkline("container").MarkerSettings(ms =>ms.Border(br=> br.Width(1))).Render()`|
|Border opacity| **Property:** *markerSettings.border.opacity*<br/><br/> `@(Html.EJ().Sparkline("container").MarkerSettings(mr => mr.Border(br=> br.Opacity(0.5)))` |Not applicable|

## Data labels

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable data labels| Not applicable |**Property:** *dataLabelSettings.visible*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Visible(new string[] { "All" })).Render()`|
|Color| Not applicable |**Property:** *dataLabelSettings.fill*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Fill("red")).Render()`|
|Opacity| Not applicable |**Property:** *dataLabelSettings.opacity*<br/><br/>`@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Opacity(0.5)).Render()` |
|Border color| Not applicable |**Property:** *dataLabelSettings.border.color*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Border(ViewBag.border)).Render()`<br/><br/>`ViewBag.border = new {color="red"}`|
|Border width| Not applicable |**Property:** *dataLabelSettings.border.width*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Border(ViewBag.border)).Render()`<br/><br/>`ViewBag.border = new {width=2}`|
|Format| Not applicable |**Property:** *dataLabelSettings.format*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Format("${xval}: ${yval}")).Render()`|
|Horizontal Offset| Not applicable |**Property:** *dataLabelSettings.offset.x*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Offset(ViewBag.offset)).Render()`<br/><br/>`ViewBag.offset = new {x=100}`|
|Vertical Offset| Not applicable |**Property:** *dataLabelSettings.offset.y*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.Offset(ViewBag.offset)).Render()`<br/><br/>`ViewBag.offset = new {y=100}`|
|Font color| Not applicable |**Property:** *dataLabelSettings.textStyle.color*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.TextStyle(ViewBag.textStyle)).Render()`<br/><br/>`ViewBag.textStyle = new {color="green"}`|
|Font family| Not applicable |**Property:** *dataLabelSettings.textStyle.fontFamily*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.TextStyle(ViewBag.textStyle)).Render()`<br/><br/>`ViewBag.textStyle = new {fontFamily="Arial"}`|
|Font style| Not applicable |**Property:** *dataLabelSettings.textStyle.fontStyle*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.TextStyle(ViewBag.textStyle)).Render()`<br/><br/>`ViewBag.textStyle = new {fontStyle="normal"}`|
|Font weight| Not applicable |**Property:** *dataLabelSettings.textStyle.fontWeight*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.TextStyle(ViewBag.textStyle)).Render()`<br/><br/>`ViewBag.textStyle = new {fontWeight="bold"}`|
|Font opacity| Not applicable |**Property:** *dataLabelSettings.textStyle.opacity*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.TextStyle(ViewBag.textStyle)).Render()`<br/><br/>`ViewBag.textStyle = new {opacity=0.5}`|
|Font size| Not applicable |**Property:** *dataLabelSettings.textStyle.fontSize*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelSettings(dl => dl.TextStyle(ViewBag.textStyle)).Render()`<br/><br/>`ViewBag.textStyle = new {fontSize="12px"}`|

## Range band

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Color| **Property:** *rangeBandSettings.color*<br/><br/>`@Html.EJ().Sparkline("container").RangeBandSettings(range => range.Color("red"))` |**Property:** *rangeBandSettings.color*<br/><br/> `@Html.EJS().Sparkline("container").RangeBandSettings(rbs => rbs.Color("red")).Render()`|
|Opacity| **Property:** *rangeBandSettings.opacity*<br/><br/> `<@Html.EJ().Sparkline("container").RangeBandSettings(range => range.Opacity(0.4))` |**Property:** *rangeBandSettings.opacity*<br/><br/> `@Html.EJS().Sparkline("container").RangeBandSettings(rbs => rbs.Opacity(0.5)).Render()`|
|Start range| **Property:** *rangeBandSettings.startRange*<br/><br/> `@Html.EJ().Sparkline("container").RangeBandSettings(range => range.StartRange(4))` |**Property:** *rangeBandSettings.startRange*<br/><br/> `@Html.EJS().Sparkline("container").RangeBandSettings(rbs => rbs.StartRange(5)).Render()`|
|End range| **Property:** *rangeBandSettings.endRange*<br/><br/> `@Html.EJ().Sparkline("container").RangeBandSettings(range => range.EndRange(30))` |**Property:** *rangeBandSettings.endRange*<br/><br/> `@Html.EJS().Sparkline("container").RangeBandSettings(rbs => rbs.EndRange(15)).Render()`|

## Special points customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|High point color| **Property:** *highPointColor*<br/><br/> `@(Html.EJ().Sparkline("container")HighPointColor("Blue"))` |**Property:** *highPointColor*<br/><br/> `@Html.EJS().Sparkline("container").HighPointColor("red").Render()`|
|Low point color| **Property:** *lowPointColor*<br/><br/> `@(Html.EJ().Sparkline("container").LowPointColor("Orange"))` |**Property:** *lowPointColor*<br/><br/> `@Html.EJS().Sparkline("container").LowPointColor("blue").Render()`|
|Negative point color| **Property:** *negativePointColor*<br/><br/> `@(Html.EJ().Sparkline("container").NegativePointColor("Red"))` |**Property:** *negativePointColor*<br/><br/> `@Html.EJS().Sparkline("container").NegativePointColor("green").Render()`|
|Start point color| **Property:** *startPointColor*<br/><br/> `@(Html.EJ().Sparkline("container").StartPointColor("Green"))` |**Property:** *startPointColor*<br/><br/> `<@Html.EJS().Sparkline("container").StartPointColor("black").Render()`|
|End point color| **Property:** *endPointColor*<br/><br/> `@(Html.EJ().Sparkline("container").EndPointColor("Green"))` |**Property:** *endPointColor*<br/><br/> `@Html.EJS().Sparkline("container").EndPointColor("orange").Render()`|
|Tie point color| **Property:** *tiePointColor*<br/><br/>Not Applicable |**Property:** *tiePointColor*<br/><br/> `@Html.EJS().Sparkline("container").TiePointColor("grey").Render()`|

## Axis customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show axis line| **Property:** *axisSettings.visible*<br/><br/> `@(Html.EJ().Sparkline("container").AxisLineSettings(as => as.Visible(true)))` |**Property:** *axisSettings.lineSettings.visible*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.LineSettings(ls => ls.Visible(true))).Render()`|
|Line color| **Property:** *axisSettings.color*<br/><br/> `@(Html.EJ().Sparkline("container").AxisLineSettings(as => as.Color("#ff14ae")))` |**Property:** *axisSettings.lineSettings.color*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.LineSettings(ls => ls.Color("red"))).Render()`|
|Line width| **Property:** *axisSettings.width*<br/><br/> `@(Html.EJ().Sparkline("container").AxisLineSettings(as => as.Width(2)))` |**Property:** *axisSettings.lineSettings.width*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.LineSettings(ls => ls.Width(2))).Render()`|
|Dash array| **Property:** *axisSettings.dashArray*<br/><br/> `@(Html.EJ().Sparkline("container").AxisLineSettings(as => as.DashArray("5,3")))` |**Property:** *axisSettings.lineSettings.dashArray*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.LineSettings(ls => ls.DashArray("5,3"))).Render()`|
|X axis minimum value| Not applicable |**Property:** *axisSettings.minX*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.MinX(0)).Render()`|
|X axis maximum value| Not applicable |**Property:** *axisSettings.maxX*<br/><br/>`@Html.EJS().Sparkline("container").AxisSettings(axis => axis.MaxX(100)).Render()`|
|Y axis minimum value| Not applicable |**Property:** *axisSettings.minY*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.MinY(0)).Render()`|
|Y axis maximum value| Not applicable |**Property:** *axisSettings.maxY*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.MaxY(100)).Render()`|
|Horizontal axis line position| Not applicable |**Property:** *axisSettings.value*<br/><br/> `@Html.EJS().Sparkline("container").AxisSettings(axis => axis.Value(10))).Render()`|

## Appearance customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Background color| **Property:** *background*<br/><br/> `@(Html.EJ().Sparkline("container").Background("gray"))` |**Property:** *containerArea.background*<br/><br/> `@Html.EJS().Sparkline("container").ContainerArea(ca => ca.Background("red")).Render()`|
|Border color | Not applicable |**Property:** *containerArea.border.color*<br/><br/> `@Html.EJS().Sparkline("container").ContainerArea(ca => ca.Border(ViewBag.border)).Render()`<br/><br/>`ViewBag.border = new {color="green"}`|
|Border width | Not applicable |**Property:** *containerArea.border.width*<br/><br/> `@Html.EJS().Sparkline("container").ContainerArea(ca => ca.Border(ViewBag.border)).Render()`<br/><br/>`ViewBag.border = new {color="green"}`|
|Series color| **Property:** *fill*<br/><br/> `@(Html.EJ().Sparkline("container").Fill("gray"))` |**Property:** *fill*<br/><br/> `@Html.EJS().Sparkline("container").Fill("green").Render()`|
|Series opacity| **Property:** *opacity*<br/><br/> `@(Html.EJ().Sparkline("container").Opacity(0.5))` |**Property:** *opacity*<br/><br/> `@Html.EJS().Sparkline("container").Opacity(0.5).Render()`|
|Line series width| **Property:** *width*<br/><br/> `@(Html.EJ().Sparkline("container").Width(2))` |**Property:** *lineWidth*<br/><br/> `@Html.EJS().Sparkline("container").LineWidth(2).Render()`|
|Series border color| **Property:** *border.color*<br/><br/> `@(Html.EJ().Sparkline("container") .Border(border=>border.Color("green")))` |**Property:** *border.color*<br/><br/>`@Html.EJS().Sparkline("container").Border(br=>br.Color("red")).Render()`|
|Series border width| **Property:** *border.width*<br/><br/> `@(Html.EJ().Sparkline("container") .Border(border=>border.Width(2)))` |**Property:** *border.width*<br/><br/> `@Html.EJS().Sparkline("container").Border(br=>br.Width(2)).Render()`|
|Series palette| **Property:** *palette*<br/><br/> `@(Html.EJ().Sparkline("container").Palette(ViewBag.palettes))`<br/><br/>`ViewBag.palettes = new string[] { "red", "green", "orange", "blue" };` |**Property:** *palette*<br/><br/> `@Html.EJS().Sparkline("container").Palette(ViewBag.palettes).Render()`<br/><br/>`ViewBag.palettes = new string[] { "red", "green", "orange", "blue" };`|
|Theme| **Property:** *theme*<br/><br/> `@(Html.EJ().Sparkline("container").Theme(SparkTheme.FlatDark))` |**Property:** *theme*<br/><br/> `@Html.EJS().Sparkline("container").Theme("Material").Render()`|
|Width| **Property:** *size.width*<br/><br/> `@(Html.EJ().Sparkline("container").Width("300px"))` |**Property:** *width*<br/><br/> `@Html.EJS().Sparkline("container").Width("300px").Render()`|
|Height| **Property:** *size.height*<br/><br/> `<@(Html.EJ().Sparkline("container").Height("300px"))` |**Property:** *height*<br/><br/> `@Html.EJS().Sparkline("container").Height("300px").Render()`|

## Tooltip

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show tooltip| **Property:** *tooltip.visible*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Visible(true)))` |**Property:** *tooltipSettings.visible*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.Visible(true)).Render()`|
|Background| **Property:** *tooltip.fill*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Fill("red")))` |**Property:** *tooltipSettings.fill*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.Fill("red")).Render()`|
|Format| Not applicable |**Property:** *tooltipSettings.format*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.Format("${xval}: ${yval}")).Render()`|
|Template| **Property:** *tooltip.template*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Template("tooltip")))`<br/><br/>`<div id="tooltip">`</br>&nbsp;        `<div>#point.x#</div>`</br>&nbsp;&nbsp;`<div>#point.y#</div>`</br>`</div>`|**Property:** *tooltipSettings.template*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.Template("tooltip")).Render()`<br/><br/>`<div id="tooltip">${x} : ${y}<div>`|
|Font color| **Property:** *tooltip.font.color*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Font(font=>font.Color("red"))))` |**Property:** *tooltipSettings.textStyle.color*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TextStyle(ViewBag.font)).Render()`<br/><br/>`ViewBag.font = new { color="gray"};`|
|Font opacity| **Property:** *tooltip.font.opacity*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Font(font=>font.Opacity(0.5))))` |**Property:** *tooltipSettings.textStyle.opacity*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TextStyle(ViewBag.font)).Render()`<br/><br/>`ViewBag.font = new { opacity=0.5};`|
|Font size| **Property:** *tooltip.font.size*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Font(font=>font.Size('12px'))))` |**Property:** *tooltipSettings.textStyle.size*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TextStyle(ViewBag.font)).Render()`<br/><br/>`ViewBag.font = new { size="14px"};`|
|Font family| **Property:** *tooltip.font.fontFamily*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Font(font=>font.FontFamily('Algerian'))))` |**Property:** *tooltipSettings.textStyle.fontFamily*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TextStyle(ViewBag.font)).Render()`<br/><br/>`ViewBag.font = new { fontFamily="Arial"};`|
|Font style| **Property:** *tooltip.font.fontStyle*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Font(font=>font.FontStyle('Italic'))))` |**Property:** *tooltipSettings.textStyle.fontStyle*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TextStyle(ViewBag.font)).Render()`<br/><br/>`ViewBag.font = new { fontStyle="normal"};`|
|Font weight| **Property:** *tooltip.font.fontWeight*<br/><br/> `@(Html.EJ().Sparkline("container").Tooltip(tooltip => tooltip.Font(font=>font.FontWeight('Lighter'))))` |**Property:** *tooltipSettings.textStyle.fontWeight*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TextStyle(ViewBag.font)).Render()`<br/><br/>`ViewBag.font = new { fontWeight="bold"};`|
|Enable track line| Not applicable |**Property:** *tooltipSettings.trackLineSettings.visible*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TrackLineSettings(ts=>ts.Visible(true))).Render()`|
|Track line color| Not applicable |**Property:** *tooltipSettings.trackLineSettings.color*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TrackLineSettings(ts=>ts.Color("red"))).Render()`|
|Track line width| Not applicable |**Property:** *tooltipSettings.trackLineSettings.width*<br/><br/> `@Html.EJS().Sparkline("container").TooltipSettings(tooltip => tooltip.TrackLineSettings(ts=>ts.Width(2)).Render()`|

## Rendering

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable canvas rendering| **Property:** *enableCanvasRendering*<br/><br/> `@Html.EJ().Sparkline("container").EnableCanvasRandering(true))` | Not applicable |

## Localization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Localization| **Property:** *locale*<br/><br/> `@Html.EJ().Sparkline("container").Locale("en-US"))` | **Property:** *type*<br/><br/> `@Html.EJS().Sparkline("container").Locale("en-US").Render()` |

## Methods

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Dynamically updating sparkline| **Method:** *redraw*<br/><br/> `var sparkline = $("#container").ejSparkline("instance");`</br>`sparkline.redraw();` | **Method:** *refresh*<br/><br/> `var sparkline = document.getElementById("container").ej2_instances[0];`</br>`sparkline.refresh();` |

## Events

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Load| **Event:** *load*<br/><br/> `@(Html.EJ().Sparkline("container").Load("load"))`<br/><br/>`function load(args) { }` | **Event:** *load*<br/><br/> `@Html.EJS().Sparkline("container").Load("load").Render()
`<br/><br/>`function load(args) { }` |
|Load completed| **Event:** *loaded*<br/><br/> `@(Html.EJ().Sparkline("container").Loaded("loaded"))`<br/><br/>`function loaded(args) { }` | **Event:** *loaded*<br/><br/> `@Html.EJS().Sparkline("container").Loaded("loaded").Render()`<br/><br/>`function loaded(args) { }` |
|Initialize tooltip| **Event:** *tooltipInitialize*<br/><br/> `@(Html.EJ().Sparkline("container").TooltipInitialize("tooltipInitialize"))`<br/><br/>`function tooltipInitialize(args) { }` | **Event:** *tooltipInitialize*<br/><br/> `@Html.EJS().Sparkline("container").TooltipInitialize("tooltipInitialize").Render()`<br/><br/>`function tooltipInitialize(args) { }` |
|Series rendering| **Event:** *seriesRendering*<br/><br/> `@(Html.EJ().Sparkline("container").SeriesRendering("seriesRendering"))`<br/><br/>`function seriesRendering(args) { }` | **Event:** *seriesRendering*<br/><br/> `@Html.EJS().Sparkline("container").SeriesRendering("seriesRendering").Render()`<br/><br/>`function seriesRendering(args) { }` |
|Region mouse move| **Event:** *pointRegionMouseMove*<br/><br/> `@(Html.EJ().Sparkline("container").PointRegionMouseMove("pointRegionMouseMove"))`<br/><br/>`function pointRegionMove(args) { }` | **Event:** *pointRegionMouseMove*<br/><br/> `@Html.EJS().Sparkline("container").PointRegionMouseMove("pointRegionMouseMove").Render()`<br/><br/>`function pointRegionMouseMove(args) { }` |
|Region click| **Event:** *pointRegionMouseClick*<br/><br/> `@(Html.EJ().Sparkline("container").PointRegionMouseClick("pointRegionMouseClick"))`<br/><br/>`function pointRegionClick(args) { }` | **Event:** *pointRegionMouseClick*<br/><br/> `@Html.EJS().Sparkline("container").PointRegionMouseClick("pointRegionMouseClick").Render()`<br/><br/>`function pointRegionMouseClick(args) { }` |
|Mouse move| **Event:** *sparklineMouseMove*<br/><br/> `@(Html.EJ().Sparkline("container").SparklineMouseMove("sparklineMouseMove"))`<br/><br/>`function mouseMove(args) { }` | **Event:** *sparklineMouseMove*<br/><br/> `@Html.EJS().Sparkline("container").SparklineMouseMove("sparklineMouseMove").Render()`<br/><br/>`function sparklineMouseMove(args) { }` |
|Mouse leave| **Event:** *sparklineMouseLeave*<br/><br/> `@(Html.EJ().Sparkline("container").SparklineMouseLeave("sparklineMouseLeave"))`<br/><br/>`function mouseLeave(args) { }` | Not applicable |
|Click| **Event:** *click*<br/><br/> `@(Html.EJ().Sparkline("container").Click("click"))`<br/><br/>`function sparklineMouseClick(args) { }` | **Event:** *sparklineMouseClick*<br/><br/> `@Html.EJS().Sparkline("container").SparklineMouseClick("sparklineMouseClick").Render()`<br/><br/>`function sparklineMouseClick(args) { }` |
|doubleClick| **Event:** *doubleClick*<br/><br/>`@(Html.EJ().Sparkline("container").DoubleClick("doubleClick"))`<br/><br/>`function doubleClick(args) { }` | Not applicable |
|rightClick| **Event:** *rightClick*<br/><br/> `@(Html.EJ().Sparkline("container").RightClick("rightClick"))`<br/><br/>`function rightClick(args) { }` | Not applicable |
|axisRendering| Not applicable | **Event:** *axisRendering*<br/><br/> `@Html.EJS().Sparkline("container").AxisRendering("axisRendering").Render()`<br/><br/>`function axisRendering(args) { }` |
|dataLabelRendering| Not applicable | **Event:** *dataLabelRendering*<br/><br/> `@Html.EJS().Sparkline("container").DataLabelRendering("dataLabelRendering").Render()`<br/><br/>`function dataLabelRendering(args) { }` |
|markerRendering| Not applicable | **Event:** *markerRendering*<br/><br/> `@Html.EJS().Sparkline("container").MarkerRendering("markerRendering").Render()`<br/><br/>`function markerRendering(args) { }` |
|pointRendering| Not applicable | **Event:** *pointRendering*<br/><br/> `@Html.EJS().Sparkline("container").PointRendering("pointRendering").Render()`<br/><br/>`function pointRendering(args) { }` |
|resize| Not applicable | **Event:** *resize*<br/><br/> `@Html.EJS().Sparkline("container").Resize("resize").Render()`<br/><br/>`function resize(args) { }` |