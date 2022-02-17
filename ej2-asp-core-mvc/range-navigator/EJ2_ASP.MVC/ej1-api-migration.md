---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Range Navigator Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Range navigator component from Essential JS 1 to Essential JS 2.

## RangeNavigator

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Allow snapping</b></td>
<td>
<b>Property</b>:<i>AllowSnapping</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.AllowSnapping(true)
)
</code>
</td>
<td>
<b>Property</b>:<i>AllowSnapping</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.AllowSnapping(true)
)
</code></td>
</tr>

<tr>
<td><b>Animation duration</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>AnimationDuration</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.AnimationDuration("3000")
)
</code></td>
</tr>

<tr>
<td><b>Border for range navigator</b></td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Border(b => b.Color("red").Width("2"))
)
</code>
</td>
<td>
<b>Property</b>:<i>NavigatorBorder</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.NavigatorBorder(b => b.Color("red").Width("2"))
)
</code></td>
</tr>

<tr>
<td><b>dataSource for range navigator</b></td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.DataSource()
)
</code>
</td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.DataSource(ViewBag.dataSource)
)
</code></td>
</tr>

<tr>
<td><b>enabling deffered update for range navigator</b></td>
<td>
<b>Property</b>:<i>EnableDeferedUpdate</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.EnableDeferedUpdate(true)
)
</code>
</td>
<td>
<b>Property</b>:<i>EnableDeferredUpdate</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.EnableDeferedUpdate(true)
)
</code></td>
</tr>

<tr>
<td><b>multilevel level labels</b></td>
<td>
<b>Property</b>:<i>LabelSettings.HigherLevelLabels</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.LabelSettings(l => l.HigherLevelLabels())
)
</code>
</td>
<td>
<b>Property</b>:<i>EnableGrouping</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.EnableGrouping(false)
)
</code></td>
</tr>

<tr>
<td><b>enabling scroll bar</b></td>
<td>
<b>Property</b>:<i>EnableScrollBar</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.EnableScrollBar(true)
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>enabling auto resizing</b></td>
<td>
<b>Property</b>:<i>EnableAutoResize</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.EnableAutoResize(true)
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>responsive of range navigator</b></td>
<td>
<b>Property</b>:<i>IsResponsive</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.IsResponsive(true)
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>enabling RTL for range navigator</b></td>
<td>
<b>Property</b>:<i>EnableRtl</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.EnableRtl(true)
)
</code>
</td>
<td>
<b>Property</b>:<i>EnableRtl</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.EnableRtl(true)
)
</code></td>
</tr>

<tr>
<td><b>interval for range navigator</b></td>
<td>
<b>Property</b>:<i>ValueAxisSettings.Range.Interval</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ValueAxisSettings(v => v.Range(r => r.Interval("1")))
)
</code>
</td>
<td>
<b>Property</b>:<i>Interval</i>
</br>
</br>
<code>
<code>
@(Html.EJS().RangeNavigator("container")
.Interval("1")
)
</code></td>
</tr>

<tr>
<td><b>intervaltype for range navigator</b></td>
<td>
<b>Property</b>:<i>ValueAxisSettings.Range.IntervalType</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ValueAxisSettings(v => v.Range(r => r.IntervalType("Years")))
)
</code>
</td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.IntervalType(Syncfusion.EJ2.Charts.RangeIntervalType.Years)
)
</code></td>
</tr>

<tr>
<td><b>labelformat for range navigator</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.LabelFormat(yMd")
)
</code></td>
</tr>

<tr>
<td><b>label intersect action for range navigator</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.LabelIntersectAction(Syncfusion.EJ2.Charts.RangeLabelIntersectAction.Hide)
)
</code></td>
</tr>

<tr>
<td><b>labelStyle range navigator</b></td>
<td>
<b>Property</b>:<i>ValueAxisSettings.Font</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ValueAxisSettings(v => v.Font())
)
</code>
</td>
<td>
<b>Property</b>:<i>LabelStyle</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.LabelStyle()
)
</code></td>
</tr>

<tr>
<td><b>locale of range navigator</b></td>
<td>
<b>Property</b>:<i>Locale</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Locale("en-US")
)
</code>
</td>
<td>
<b>Property</b>:<i>Locale</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Locale("en-US")
)
</code></td>
</tr>

<tr>
<td><b>major grid lines of range navigator</b></td>
<td>
<b>Property</b>:<i>ValueAxisSettings.MajorGridLines</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ValueAxisSettings(v => v.MajorGridLines(m => m.Width("2").Color("red")))
)
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.MajorGridLines(mg => mg.Color("blue").Width(2).DashArray("5,5"))
)
</code></td>
</tr>

<tr>
<td><b>margin of range navigator</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Margin</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Margin()
)
</code></td>
</tr>

<tr>
<td><b>maximum value of range navigator</b></td>
<td>
<b>Property</b>:<i>ValueAxisSettings.Range.Max</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ValueAxisSettings(v => v.Range(r => r.Max("34")))
)
</code>
</td>
<td>
<b>Property</b>:<i>Maximum</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Maximum("34")
)
</code></td>
</tr>

<tr>
<td><b>minimum value of range navigator</b></td>
<td>
<b>Property</b>:<i>ValueAxisSettings.Range.Min</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ValueAxisSettings(v => v.Range(r => r.Min("10")))
)
</code>
</td>
<td>
<b>Property</b>:<i>Minimum</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Minimum("10")
)
</code></td>
</tr>

<tr>
<td><b>query for data source of range navigator</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Query</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Query()
)
</code></td>
</tr>

<tr>
<td><b>Secondary label alignment of range navigator</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>SecondaryLabelAlignment</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.SecondaryLabelAlignmen("Far")
)
</code></td>
</tr>

<tr>
<td><b>Skeleton of range navigator axis</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Skeleton</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Skeleton()
)
</code></td>
</tr>

<tr>
<td><b>skeletontype of range navigator axis</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>SkeletonType</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.SkeletonType()
)
</code></td>
</tr>

<tr>
<td><b>Theme of range navigator</b></td>
<td>
<b>Property</b>:<i>Theme</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Theme()
)
</code>
</td>
<td>
<b>Property</b>:<i>Theme</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Theme()
)
</code></td>
</tr>

<tr>
<td><b>Default selector value range navigator</b></td>
<td>
<b>Property</b>:<i>SelectedRangeSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.SelectedRangeSettings(s => s.Start("2").End("20"))
)
</code>
</td>
<td>
<b>Property</b>:<i>Value</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Value("2,10")
)
</code></td>
</tr>

<tr>
<td><b>Value type of range navigator</b></td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
$@(Html.EJS().RangeNavigator("container")
.ValueType("DateTime")
)
</code>
</td>
<td>
<b>Property</b>:<i>valueType</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.ValueType(Syncfusion.EJ2.Charts.RangeValueType.DateTime)
</code></td>
</tr>

<tr>
<td><b>Width of range navigator</b></td>
<td>
<b>Property</b>:<i>Size.Width</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Size(s => s.Width("400"))
)
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Width("400")
)
</code></td>
</tr>

<tr>
<td><b>Height of range navigator</b></td>
<td>
<b>Property</b>:<i>Size.Height</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Size(s => s.Height("400"))
)
</code>
</td>
<td>
<b>Property</b>:<i>Height</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Height("400")
)
</code></td>
</tr>

<tr>
<td><b>Series settings for range navigator</b></td>
<td>
<b>Property</b>:<i>SeriesSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.SeriesSettings()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Range settings for range navigator</b></td>
<td>
<b>Property</b>:<i>RangeSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.RangeSettings(r => r.Start("20").End("30"))
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Scroll range settings for range navigator</b></td>
<td>
<b>Property</b>:<i>ScrollRangeSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ScrollRangeSettings(r => r.Start("20").End("30"))
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>
</table>

## Series

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>animation</b></td>
<td>
<b>Property</b>:<i>EnableAnimation</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.EnableAnimation(true)
</code>
</td>
<td>
<b>Property</b>:<i>Animation</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Animation(a => a.Enable(true).Duration("3000"))
)
</code></td>
</tr>

<tr>
<td><b>Border for range navigator series</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Border(b => b.Color("red").Width("2"))
)
</code></td>
</tr>

<tr>
<td><b>dataSource for range navigator</b></td>
<td>
<b>Property</b>:<i>Series.DataSource</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Series(s => s.DataSource())
)
</code>
</td>
<td>
<b>Property</b>:<i>Series.DataSource</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.DataSource())
)
</code></td>
</tr>

<tr>
<td><b>query for data source of range navigator</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Query</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.Query())
)
</code></td>
</tr>

<tr>
<td><b>series type for range navigator</b></td>
<td>
<b>Property</b>:<i>Series.Type</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Series(s => s.Type(SeriesType.Line))
)
</code>
</td>
<td>
<b>Property</b>:<i>Series.Type</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Type(Syncfusion.EJ2.Charts.RangeNavigatorType.Line)
)
</code></td>
</tr>

<tr>
<td><b>series xName for range navigator</b></td>
<td>
<b>Property</b>:<i>Series.XName</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Series(s => s.XName())
)
</code>
</td>
<td>
<b>Property</b>:<i>Series.XName</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.XName())
)
</code></td>
</tr>

<tr>
<td><b>series yName for range navigator</b></td>
<td>
<b>Property</b>:<i>Series.YName</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Series(s => s.YName())
)
</code>
</td>
<td>
<b>Property</b>:<i>Series.YName</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.YName())
)
</code></td>
</tr>

<tr>
<td><b>series fill color for range navigator</b></td>
<td>
<b>Property</b>:<i>Series.Fill</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Series(s => s.Fill("red"))
)
</code>
</td>
<td>
<b>Property</b>:<i>Series.Fill</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.Fill("red"))
)
</code></td>
</tr>

<tr>
<td><b>series width for range navigator</b></td>
<td>
<b>Property</b>:<i>Series.Width</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Series(s => s.Width(""))
)
</code>
</td>
<td>
<b>Property</b>:<i>Series.Width</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.Width(""))
)
</code></td>
</tr>

<tr>
<td><b>series dashArray for range navigator</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Series.DashArray</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Series(s => s.DashArray("10,5"))
)
</code></td>
</tr>
</table>

## StyleSettings

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Style settings of range navigator</b></td>
<td>
<b>Property</b>:<i>NavigatorStyleSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings()
)
</code>
</td>
<td>
<b>Property</b>:<i>StyleSettings</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.StyleSettings()
)
</code></td>
</tr>

<tr>
<td><b>Selected region color of range navigator</b></td>
<td>
<b>Property</b>:<i>SelectedRegionColor</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.SelectedRegionColor("red"))
)
</code>
</td>
<td>
<b>Property</b>:<i>SelectedRegionColor</i>
</br>
</br>
@(Html.EJS().RangeNavigator("container")
.StyleSettings(s => s.SelectedRegionColor("red"))
)
</code></td>
</tr>

<tr>
<td><b>UnSeleted region color of range navigator</b></td>
<td>
<b>Property</b>:<i>UnselectedRegionColor</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.UnSelectedRegionColor("red"))
)
</code>
</td>
<td>
<b>Property</b>:<i>UnselectedRegionColor</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.StyleSettings(s => s.UnSelectedRegionColor("red"))
)
</code></td>
</tr>

<tr>
<td><b>Thumb color of range navigator</b></td>
<td>
<b>Property</b>:<i>ThumColor</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.ThumColor("red"))
)
</code>
</td>
<td>
<b>Property</b>:<i>ThumbSettings</i>
</br>
</br>
@(Html.EJS().RangeNavigator("container")
.StyleSettings(s => s.ThumbSettings("red"))
)
</code></td>
</tr>

<tr>
<td><b>Selected region opacity of range navigator</b></td>
<td>
<b>Property</b>:<i>SelectedRegionOpacity</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.SelectedRegionOpacity("0.4"))
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Unselected region opacity of range navigator</b></td>
<td>
<b>Property</b>:<i>UnselectedRegionOpacity</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.UnSelectedRegionOpacity("0.4"))
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Background for thumb</b></td>
<td>
<b>Property</b>:<i>Background</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.Background("red"))
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>border for thumb</b></td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.Border(b => b.Color("red").Width("2")))
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Highlightsettings for range navigator</b></td>
<td>
<b>Property</b>:<i>HighlightSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.HighlightSettings())
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Selected style settings for range navigator</b></td>
<td>
<b>Property</b>:<i>SelectionSettings</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.SelectionSettings())
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Left thumb template for range navigator</b></td>
<td>
<b>Property</b>:<i>LeftThumbTemplate</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.LeftThumbTemplate())
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Right thumb template for range navigator</b></td>
<td>
<b>Property</b>:<i>RightThumbTemplate</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.NavigatorStyleSettings(n => n.RightThumbTemplate())
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>
</table>

## Tooltip

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>tooltip</b></td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Tooltip(t => t.Visible(true))
)
</code>
</td>
<td>
<b>Property</b>:<i>Enable</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.Enable(true))
)
</code></td>
</tr>

<tr>
<td><b>background color of tooltip</b></td>
<td>
<b>Property</b>:<i>BackgroundColor</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Tooltip(t => t.BackgroundColor("red"))
)
</code>
</td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Tooltip(t => t.Fill("red"))
)
</code></td>
</tr>

<tr>
<td><b>Font style of tooltip</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Tooltip(t => t.Font())
)
</code>
</td>
<td>
<b>Property</b>:<i>TextStyle</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.TextStyle())
)
</code></td>
</tr>

<tr>
<td><b>Label format of tooltip</b></td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Tooltip(t => t.LabelFormat("yMd"))
)
</code>
</td>
<td>
<b>Property</b>:<i>Format</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.Format("yMd"))
)
</code></td>
</tr>

<tr>
<td><b>Display mode of tooltip</b></td>
<td>
<b>Property</b>:<i>TooltipDisplayMode</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Tooltip(t => t.TooltipDisplayMode("always"))
)
</code>
</td>
<td>
<b>Property</b>:<i>displayMode</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.DisplayMode("always"))
)
</code></td>
</tr>

<tr>
<td><b>Template of tooltip</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Template</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.Template(""))
)
</code></td>
</tr>

<tr>
<td><b>Border of tooltip</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.Border(b => b.Color("red").Width("2")))
)
</code></td>
</tr>

<tr>
<td><b>Opacity of tooltip</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Tooltip(t => t.Opacity("0.5")))
)
</code></td>
</tr>
</table>

## Period Selector

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>period selector</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>PeriodSelector</i>
</br>
</br>
<code>
(Html.EJS().RangeNavigator("container")
.PeriodSelector(p => p.Periods(pr => pr.Interval("1").IntervalType("Months").Text("1M"))))
</code></td>
</tr>
</table>

## Methods

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Print</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Print()</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
RangeNavigator.Print())
</code>
</td>
</tr>

<tr>
<td><b>Export</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>export()</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
RangeNavigator.Export())
</code>
</td>
</tr>
</table>

## Events

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Fires before loading the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>Load</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Load()
)
</code>
</td>
<td>
<b>Property</b>:<i>Load</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Load()
)
</code>
</td>
</tr>

<tr>
<td><b>Fires before loading the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>Loaded</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Loaded()
)
</code>
</td>
<td>
<b>Property</b>:<i>Loaded</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Loaded()
)
</code>
</td>
</tr>

<tr>
<td><b>Fires when  the value changes in range navigator.</b></td>
<td>
<b>Property</b>:<i>RangeChanged</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.RangeChanged()
)
</code>
</td>
<td>
<b>Property</b>:<i>Changed</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Changed()
)
</code>
</td>
</tr>

<tr>
<td><b>Fires before after resize the RangeNavigator.</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Resized</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.Resized()
)
</code>
</td>
</tr>

<tr>
<td><b>Fires before tooltip the RangeNavigator.</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>TooltipRender</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.TooltipRender()
)
</code>
</td>
</tr>

<tr>
<td><b>Fires before period render in the RangeNavigator.</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>SelectorRender</i>
</br>
</br>
<code>
@(Html.EJS().RangeNavigator("container")
.SelectorRender()
)
</code>
</td>
</tr>

<tr>
<td><b>Fires when scrollStart the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>ScrollStart</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ScrollStart()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when scrollEnd the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>ScrollEnd</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ScrollEnd()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when selected range Start the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>SelectedRangeStart</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.SelectedRangeStart()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when selected range ends the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>SelectedRangeEnd</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.SelectedRangeEnd()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when scroll range changed in the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>ScrollChanged</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.ScrollChanged()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when  click in the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>Click</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.Click()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when  right click in the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>RightClick</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.RightClick()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Fires when double click in the RangeNavigator.</b></td>
<td>
<b>Property</b>:<i>DoubleClick</i>
</br>
</br>
<code>
@(Html.EJ().RangeNavigator("container")
.DoubleClick()
)
</code>
</td>
<td>
Not Applicable
</td>
</tr>
</table>