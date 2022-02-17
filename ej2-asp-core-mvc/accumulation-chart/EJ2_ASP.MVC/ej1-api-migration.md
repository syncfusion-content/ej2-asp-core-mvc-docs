---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Accumulation Chart Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Accumulation Chart component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Accumulation chart component from Essential JS 1 to Essential JS 2.

## Accumulation Chart

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>annotations</b></td>
<td>
<b>Property</b>:<i>Annotations</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations())
</code>
</td>
<td>
<b>Property</b>:<i>annotations</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations())
</code></td>
</tr>

<tr>
<td><b>background</b></td>
<td>
<b>Property</b>:<i>Background</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Background())
</code>
</td>
<td>
<b>Property</b>:<i>Background</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Background())
</code></td>
</tr>

<tr>
<td><b>border</b></td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Border(b => b.Color("red").Width("2")))
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Background()).Border(b => b.Color("red").Width("2")))</code></td>
</tr>

<tr>
<td><b>DataSource</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.DataSource())</code></td>
</code></td>
</tr>

<tr>
<td><b>Animation after legend click</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>EnableAnimation</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.EnableAnimation(true))
</code></td>
</tr>

<tr>
<td><b>Persisting component's state between page reloads.</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>EnablePersistance</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.EnablePersistance(true))
</code></td>
</tr>

<tr>
<td><b>Enabling smart labels</b></td>
<td>
<b>Property</b>:<i>Series.EnableSmartLabels</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.EnableSmartLabels(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableSmartLabels</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.EnableSmartLabels(true)))
</code></td>
</tr>

<tr>
<td><b>Height of Chart</b></td>
<td>
<b>Property</b>:<i>Size.Height</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Size(s => s.Height("400")))
</code>
</td>
<td>
<b>Property</b>:<i>Height</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Height("400"))
</code></td>
</tr>

<tr>
<td><b>Multi selection</b></td>
<td>
<b>Property</b>:<i>SelectionSettings.Type</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SelectionSettings(s => s.Type("multiple")))
</code>
</td>
<td>
<b>Property</b>:<i>IsMultiSelect</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.IsMultiSelect(true))
</code></td>
</tr>

<tr>
<td><b>legend Settings</b></td>
<td>
<b>Property</b>:<i>Legend</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend())
</code>
</td>
<td>
<b>Property</b>:<i>LegendSettings</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(true))
</code></td>
</tr>

<tr>
<td><b>Margin for the chart</b></td>
<td>
<b>Property</b>:<i>Margin</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Margin(m => m.Top("10").Bottom("10")))
</code>
</td>
<td>
<b>Property</b>:<i>Margin</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Margin(m => m.Top("10").Bottom("10")))
</code></td>
</tr>

<tr>
<td><b>SelectedDataIndexes</b></td>
<td>
<b>Property</b>:<i>SelectedDataPointIndexes </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SelectedDataPointIndexes())
</code>
</td>
<td>
<b>Property</b>:<i>SelectedDataIndexes </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.SelectedDataIndexes(s => s.Series("0").Point("1"))
</code></td>
</tr>

<tr>
<td><b>Selection Mode</b></td>
<td>
<b>Property</b>:<i>SelectionSettings.Mode</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SelectionSettings(s => s.Mode("point")))
</code>
</td>
<td>
<b>Property</b>:<i>selectionMode </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.SelectionSettings(s => s.Mode("Point"))
</code></td>
</tr>

<tr>
<td><b>Series</b></td>
<td>
<b>Property</b>:<i>Series</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series())
</code>
</td>
<td>
<b>Property</b>:<i>Series</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series())
</code></td>
</tr>

<tr>
<td><b>Title text</b></td>
<td>
<b>Property</b>:<i>Title.Text</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Title(t => t.Text("pie chart"))

</code>
</td>
<td>
<b>Property</b>:<i>Title</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Title(t => t.Text("pie chart"))
</code></td>
</tr>

<tr>
<td><b>Title Styles</b></td>
<td>
<b>Property</b>:<i>TitleStyle</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.TitleStyle(t => t.FontFamily("SegoeUI"))

</code>
</td>
<td>
<b>Property</b>:<i>TitleStyle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("Container")
.TitleStyle(t => t.FontFamily("SegoeUI"))
</code></td>
</tr>

<tr>
<td><b>Sub Title text</b></td>
<td>
<b>Property</b>:<i>subTitle.text</i>
</br>
</br>
<code>
@(Html.EJ().Chart("Container")
.subTitle(t => t.Text("chart"))
</code>
</td>
<td>
<b>Property</b>:<i>subTitle</i>
</br>
</br>
<code>
@(Html.EJ().AccumulationChart("Container")
.subTitle(t => t.Text("chart"))
</code></td>
</tr>

<tr>
<td><b>Sub title Styles</b></td>
<td>
<b>Property</b>:<i>Title</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SubTitleStyle(s => s.Font()))
</code>
</td>
<td>
<b>Property</b>:<i>SubTitleStyle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.SubTitleStyle(s => s.Font()))
</code></td>
</tr>

<tr>
<td><b>tooltip</b></td>
<td>
<b>Property</b>:<i>Series.ToolTip</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Tooltip()))
</code>
</td>
<td>
<b>Property</b>:<i>Tooltip</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Tooltip()))
</code></td>
</tr>

<tr>
<td><b>Width of Chart</b></td>
<td>
<b>Property</b>:<i>Size.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Size(s => s.Width("400")))
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Size(s => s.Width("400")))
</code></td>
</tr>
</table>

## Annotation

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Content</b></td>
<td>
<b>Property</b>:<i>Annotations.Content</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.Content("divID")))
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.Content</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations(a => a.Content("divID")))
</code></td>
</tr>

<tr>
<td><b>coordinateUnits</b></td>
<td>
<b>Property</b>:<i>Annotations.CoordinateUnit</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.CoordinateUnit("pixel")))
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.CoordinateUnit</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations(a => a.CoordinateUnit("pixel")))
</code></td>
</tr>

<tr>
<td><b>description</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Description</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations(a => a.Description("")))
</code></td>
</tr>

<tr>
<td><b>horizontalAlignment for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.HorizontalAlignment </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.HorizontalAlignment("middle")))
</code>
</td>
<td>
<b>Property</b>:<i>annotations.horizontalAlignment</i>
</br>
</br>
<code>
 @(Html.EJS().AccumulationChart("container")
.Annotations(a => a.HorizontalAlignment("center")))
</code></td>
</tr>

<tr>
<td><b>margin for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Margin </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.Margin(m => m.Top("10").Bottom("10"))))
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Opacity for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Opacity </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.Opacity("0.5")))
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Region for annotation with respect to chart or series</b></td>
<td>
<b>Property</b>:<i>Annotations.Region </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.Region("chart") ))
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.Region</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations(a => a.Region("chart") ))
</code></td>
</tr>

<tr>
<td><b>verticalAlignment for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.VerticalAlignment </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.VerticalAlignment("middle")))
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.VerticalAlignment</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations(a => a.VerticalAlignment("center")))
</code></td>
</tr>

<tr>
<td><b>Visibility of annotations</b></td>
<td>
<b>Property</b>:<i>Annotations.Visible </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.Visible(true)))
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>X offset for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.X </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.X("50")))
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.X</i>
</br>
</br>
<code>
 @(Html.EJS().AccumulationChart("container")
.Annotations(a => a.X("50")))
</code></td>
</tr>

<tr>
<td><b>Y offset for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Y</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(a => a.Y("150")))
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.Y</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Annotations(a => a.Y("150")))
</code></td>
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
<td><b>series</b></td>
<td>
<b>Property</b>:<i>Series</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series())
</code>
</td>
<td>
<b>Property</b>:<i>Series</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series())
</code></td>
</tr>

<tr>
<td><b>animation for series</b></td>
<td>
<b>Property</b>:<i>EnableAnimation</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.EnableAnimation(true)))
</code>
</td>
<td>
<b>Property</b>:<i>Animation.Enable</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Animation(a => a.Enable(true))))
</code></td>
</tr>

<tr>
<td><b>animation duration for series</b></td>
<td>
<b>Property</b>:<i>AnimationDuration</i>
</br>
</br>
<code>

@(Html.EJ().Chart("chartContainer")
.Series(s => s.AnimationDuration("1000")))
</code>
</td>
<td>
<b>Property</b>:<i>Animation.Duration</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Animation(a => a.Duration("1000"))))
</code></td>
</tr>

<tr>
<td><b>animation delay for series</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Animation.Delay</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Animation(a => a.Delay("1000"))))
</code></td>
</tr>

<tr>
<td><b>Border for series</b></td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Border(b => b.Color("red").Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Border(b => b.Color("red").Width("2"))))
</code></td>
</tr>

<tr>
<td><b>DataLabel for series</b></td>
<td>
<b>Property</b>:<i>DataLabel</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.DataLabel()))
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel()))
</code></td>
</tr>

<tr>
<td><b>DataSource for series</b></td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.DataSource()))
</code>
</td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataSource()))
</code></td>
</tr>

<tr>
<td><b>enableTooltip for series</b></td>
<td>
<b>Property</b>:<i>Tooltip.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.ToolTip(t =>t.Visible(true))))
</code>
</td>
<td>
<b>Property</b>:<i>EnableTooltip</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.EnableTooltip(true)))
</code></td>
</tr>

<tr>
<td><b>start angle</b></td>
<td>
<b>Property</b>:<i>StartAngle</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.StartAngle("90")))
</code>
</td>
<td>
<b>Property</b>:<i>StartAngle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.StartAngle("90")))
</code></td>
</tr>

<tr>
<td><b>end angle</b></td>
<td>
<b>Property</b>:<i>EndAngle</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.EndAngle("190")))
</code>
</td>
<td>
<b>Property</b>:<i>EndAngle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.EndAngle("190")))
</code></td>
</tr>

<tr>
<td><b>explode</b></td>
<td>
<b>Property</b>:<i>Explode</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Explode(true)))
</code>
</td>
<td>
<b>Property</b>:<i>Explode</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Explode(true)))
</code></td>
</tr>

<tr>
<td><b>explodeAll</b></td>
<td>
<b>Property</b>:<i>ExplodeAll</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.ExplodeAll(true)))
</code>
</td>
<td>
<b>Property</b>:<i>ExplodeAll</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.ExplodeAll(true)))
</code></td>
</tr>

<tr>
<td><b>explodeIndex</b></td>
<td>
<b>Property</b>:<i>ExplodeIndex</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.ExplodeIndex("0")))
</code>
</td>
<td>
<b>Property</b>:<i>ExplodeIndex</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.EExplodeIndex("1")))
</code></td>
</tr>

<tr>
<td><b>explodeOffset</b></td>
<td>
<b>Property</b>:<i>ExplodeOffset</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.ExplodeOffset("30%")))
</code>
</td>
<td>
<b>Property</b>:<i>ExplodeOffset</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.ExplodeOffset("30%")))
</code></td>
</tr>

<tr>
<td><b>gapRatio</b></td>
<td>
<b>Property</b>:<i>GapRatio</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.GapRatio("0.6")))
</code>
</td>
<td>
<b>Property</b>:<i>GapRatio</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.GapRatio("0.6")))
</code></td>
</tr>

<tr>
<td><b>gapWidth</b></td>
<td>
<b>Property</b>:<i>GapWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.GapWidth("5")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>inner radius of the accumulation chart</b></td>
<td>
<b>Property</b>:<i>InnerRadius </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.InnerRadius("30%")))
</code>
</td>
<td>
<b>Property</b>:<i>innerRadius </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.InnerRadius("30%")))
</code></td>
</tr>

<tr>
<td><b>Legend shape of the series</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>LegendShape</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.LegendShape("Rectangle")))
</code></td>
</tr>

<tr>
<td><b>name of the series</b></td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Name("")))
</code>
</td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Name("")))
</code></td>
</tr>

<tr>
<td><b>neck height for funnel series</b></td>
<td>
<b>Property</b>:<i>NeckHeight</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.NeckHeight("50")))
</code>
</td>
<td>
<b>Property</b>:<i>NeckHeight</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.NeckHeight("50")))
</code></td>
</tr>

<tr>
<td><b>neck width for funnel series</b></td>
<td>
<b>Property</b>:<i>NeckWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.NeckWidth("50")))
</code>
</td>
<td>
<b>Property</b>:<i>NeckWidth</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.NeckWidth("50")))
</code></td>
</tr>

<tr>
<td><b>opacity for series</b></td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Opacity("0.5")))
</code>
</td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Opacity("0.5")))
</code></td>
</tr>

<tr>
<td><b>palettes for series</b></td>
<td>
<b>Property</b>:<i>Palette</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Palette()))
</code>
</td>
<td>
<b>Property</b>:<i>Palettes</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Palette()))
</code></td>
</tr>

<tr>
<td><b>point color mapping name for series</b></td>
<td>
<b>Property</b>:<i>PointColorMappingName</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Series(s => s.PointColorMappingName("color")))
</code>
</td>
<td>
<b>Property</b>:<i>PointColorMapping</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.PointColorMapping("color")))
</code></td>
</tr>

<tr>
<td><b>Mode of pyramid series</b></td>
<td>
<b>Property</b>:<i>PyramidMode</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.PyramidMode("Surface")))
</code>
</td>
<td>
<b>Property</b>:<i>PyramidMode</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.PyramidMode("Linear")))
</code></td>
</tr>

<tr>
<td><b>query for datasource for series</b></td>
<td>
<b>Property</b>:<i>Query</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Query()))
</code>
</td>
<td>
<b>Property</b>:<i>Query</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Query()))
</code></td>
</tr>

<tr>
<td><b>Radius of Pie series</b></td>
<td>
<b>Property</b>:<i>PieCoefficient</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.PieCoefficient("0.5")))
</code>
</td>
<td>
<b>Property</b>:<i>Radius</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Radius("0.5")))
</code></td>
</tr>

<tr>
<td><b>Selection Style of Accumulation chart</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>SelectionStyle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.SelectionStyle()))
</code></td>
</tr>

<tr>
<td><b>tooltip Mapping name</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>TooltipMappingName</i>
</br>
</br>
<code>
(Html.EJS().AccumulationChart("container")
.Series(s => s.TooltipMappingName()))
</code></td>
</tr>

<tr>
<td><b>Type of series </b></td>
<td>
<b>Property</b>:<i>Type</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Type("")))
</code>
</td>
<td>
<b>Property</b>:<i>Type</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Type("")))
</code></td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains x value for the series.</b></td>
<td>
<b>Property</b>:<i>XName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.XName("x")))
</code>
</td>
<td>
<b>Property</b>:<i>XName</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.XName("x")))
</code>
</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains x value for the series.</b></td>
<td>
<b>Property</b>:<i>YName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.YName("y")))
</code>
</td>
<td>
<b>Property</b>:<i>YName</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.YName("y")))
</code>
</td>
</tr>

<tr>
<td><b>Width of funnel series</b></td>
<td>
<b>Property</b>:<i>FunnelWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.FunnelWidth("100")))
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.Width("100")))
</code>
</td>
</tr>

<tr>
<td><b>Grouping</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>GroupTo</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.GroupTo("1")))
</code>
</td>
</tr>

<tr>
<td><b>GroupMode</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>GroupMode</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.GroupMode("Point")))
</code>
</td>
</tr>
</table>

## DataLabel

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>dataLabel</b></td>
<td>
<b>Property</b>:<i>Series.Marker.DataLabel</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.Visible(true)))))
</code>
</td>
<td>
<b>Property</b>:<i>Series.DataLabel</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Visible(true))))
</code></td>
</tr>

<tr>
<td><b>border of dataLabel</b></td>
<td>
<b>Property</b>:<i>Series.Marker.DataLabel.Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.Boder(
    b => b.Color("red").Width("2")
)))))
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Boder(
    b => b.Color("red").Width("2")))))
</code></td>
</tr>

<tr>
<td><b>connector style for dataLabel connector line</b></td>
<td>
<b>Property</b>:<i>ConnectorLine</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.ConnectorLine(
    c => c.Type("Curve').Width("2")
)))))
</code>
</td>
<td>
<b>Property</b>:<i>connectorStyle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.ConnectorLine(
    c => c.Type("Curve').Width("2")
))))
</code></td>
</tr>

<tr>
<td><b>Fill for dataLabel</b></td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.Fill("red")
))))
</code>
</td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Fill("red")
)))
</code></td>
</tr>

<tr>
<td><b>font for dataLabel</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.Font()
))))
</code>
</td>
<td>
<b>Property</b>:<i>font</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Font()
)))
</code></td>
</tr>

<tr>
<td><b>position</b></td>
<td>
<b>Property</b>:<i>Position</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.Position("Inside")
))))
</code>
</td>
<td>
<b>Property</b>:<i>Position</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Position("Outside")
)))
</code></td>
</tr>

<tr>
<td><b>Rounded corner radius X</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>DataLabel.Rx</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Rx("10"))))
</code>
</td>
</tr>

<tr>
<td><b>Rounded corner radius Y</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>DataLabel.Ry</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Ry("10"))))
</code>
</td>
</tr>

<tr>
<td><b>HTML template in dataLabel</b></td>
<td>
<b>Property</b>:<i>DataLabel.Template</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(s => s.Marker(m => m.DataLabel(d => d.Template("chart")
))))
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Template</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Series(s => s.DataLabel(d => d.Template("chart")
)))
</code>
</td>
</tr>

</table>

## Legend

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Default legend</b></td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Visible(true)))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Visible(true)))
</code>
</td>
</tr>

<tr>
<td><b>Legend height</b></td>
<td>
<b>Property</b>:<i>Size.Height</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Size(s => s.Height("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>Height</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Height("10")))
</code>
</td>
</tr>

<tr>
<td><b>Legend width</b></td>
<td>
<b>Property</b>:<i>Size.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Size(s => s.Width"10"))))
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Width("10")))
</code>
</td>
</tr>

<tr>
<td><b>Legend location in chart</b></td>
<td>
<b>Property</b>:<i>Location</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Location(loc => loc.X("10").Y("20"))))
</code>
</td>
<td>
<b>Property</b>:<i>Location</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Location(loc => loc.X("10").Y("20"))))
</code>
</td>
</tr>

<tr>
<td><b>Legend position in chart</b></td>
<td>
<b>Property</b>:<i>Position</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Position("Top")))
</code>
</td>
<td>
<b>Property</b>:<i>Position</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Position("Top")))
</code>
</td>
</tr>

<tr>
<td><b>Legend padding</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>Padding</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Padding("8")))
</code>
</td>
</tr>

<tr>
<td><b>Legend alignment</b></td>
<td>
<b>Property</b>:<i>Alignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Alignment("center")))
</code>
</td>
<td>
<b>Property</b>:<i>Alignment</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Alignment("center")))
</code>
</td>
</tr>

<tr>
<td><b>text style for legend</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Font()))
</code>
</td>
<td>
<b>Property</b>:<i>TextStyle</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Font()))
</code>
</td>
</tr>

<tr>
<td><b>shape height of legend</b></td>
<td>
<b>Property</b>:<i>ItemStyle.Height</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.ItemStyle(i => i.Height("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>ShapeHeight</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.ShapeHeight("10")))
</code>
</td>
</tr>

<tr>
<td><b>shape width of legend</b></td>
<td>
<b>Property</b>:<i>ItemStyle.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.ItemStyle(i => i.Width("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>ShapeWidth</i>
</br>
</br>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.ShapeWidth("10")))
</code>
</td>
</tr>

<tr>
<td><b>shape border of legend</b></td>
<td>
<b>Property</b>:<i>ItemStyle.Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.ItemStyle(i => i.Border())))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>shape padding of legend</b></td>
<td>
<b>Property</b>:<i>ItemPadding</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.ItemPadding("10")))
</code>
</td>
<td>
<b>Property</b>:<i>ShapePadding</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.ShapePadding("10")))
</code>
</td>
</tr>

<tr>
<td><b>Background of legend</b></td>
<td>
<b>Property</b>:<i>Background</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Background("transparent")))
</code>
</td>
<td>
<b>Property</b>:<i>Backgorund</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Background("transparent")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of legend</b></td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Opacity("0.5")))
</code>
</td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Opacity("0.5")))
</code>
</td>
</tr>

<tr>
<td><b>Toggle visibility of series while legend click</b></td>
<td>
<b>Property</b>:<i>ToggleSeriesVisibility</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.ToggleSeriesVisibility("true")))
</code>
</td>
<td>
<b>Property</b>:<i>ToggleVisibility</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.ToggleVisibility<("true")))
</code>
</td>
</tr>

<tr>
<td><b>Title for legend</b></td>
<td>
<b>Property</b>:<i>Title</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Title(t => t.Text("chartText"))))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Text Overflow for legend</b></td>
<td>
<b>Property</b>:<i>TextOverFlow</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.TextOverFlow("Trim")))
</code>
</td>
<td>
<b>Property</b>:<i>TextStyle.TextOverFlow</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendSettings(l => l.Text(t => t.TextOverFlow("trim"))))
</code>
</td>
</tr>

<tr>
<td><b>Text width for legend while setting text overflow</b></td>
<td>
<b>Property</b>:<i>TextWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.TextWidth("20")))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Scroll bar for legend</b></td>
<td>
<b>Property</b>:<i>EnableScrollBar</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.EnableScrollBar(true)))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Row count for legend</b></td>
<td>
<b>Property</b>:<i>RowCount</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.RowCount("3")))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Column count for legend</b></td>
<td>
<b>Property</b>:<i>ColumnCount</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.ColumnCount("2")))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Color for legend items</b></td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(l => l.Fill("red")))
</code>
</td>
<td>
Not applicable
</td>
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
<td><b>animation for series</b></td>
<td>
<b>Property</b>:<i>Chart.Animate</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Animate()
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Redraw for chart</b></td>
<td>
<b>Property</b>:<i>Chart.Redraw</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Redraw()
</code>
</td>
<td>
<b>Property</b>:<i>Chart.Refresh()</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Refresh()
</code>
</td>
</tr>

<tr>
<td><b>Export</b></td>
<td>
<b>Property</b>:<i>Chart.Export()</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Export()
</code>
</td>
<td>
<b>Property</b>:<i>Chart.Export()</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Export()
</code>
</td>
</tr>

<tr>
<td><b>Print</b></td>
<td>
<b>Property</b>:<i>Chart.Print()</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Print()
</code>
</td>
<td>
<b>Property</b>:<i>Chart.Print()</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Print()
</code>
</td>
</tr>

<tr>
<td><b>AddSeries</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Chart.AddSeries()</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.AddSeries()
</code>
</td>
</tr>

<tr>
<td><b>RemoveSeries</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Chart.RemoveSeries()</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.RemoveSeries()
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
<td><b>Fires on annotation click</b></td>
<td>
<b>Property</b>:<i>AnnotationClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AnnotationClick())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires after animation</b></td>
<td>
<b>Property</b>:<i>AnimationComplete</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AnnotationComplete())
</code>
</td>
<td>
<b>Property</b>:<i>AnimationComplete()</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.AnnotationComplete())
</code>
</td>
</tr>

<tr>
<td><b>Fires on after chart resize</b></td>
<td>
<b>Property</b>:<i>AfterResize</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AfterResize())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires on before chart resize</b></td>
<td>
<b>Property</b>:<i>BeforeResize</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.BeforeResize())
</code>
</td>
<td>
<b>Property</b>:<i>Resized</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Resized())
</code>
</td>
</tr>

<tr>
<td><b>Fires on chart click</b></td>
<td>
<b>Property</b>:<i>ChartClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ChartClick())
</code>
</td>
<td>
<b>Property</b>:<i>ChartMouseClick</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.ChartMouseClick())
</code>
</td>
</tr>

<tr>
<td><b>Fires on chart mouse move</b></td>
<td>
<b>Property</b>:<i>ChartMouseMove</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ChartMouseMove())
</code>
</td>
<td>
<b>Property</b>:<i>ChartMouseMove</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.ChartMouseClick())
</code>
</td>
</tr>

<tr>
<td><b>Fires on chart mouse leave</b></td>
<td>
<b>Property</b>:<i>ChartMouseLeave</i>
</br>
</br>
<code>
$("#chart").ejChart({
@(Html.EJ().Chart("chartContainer")
.ChartMouseLeave())
</code>
</td>
<td>
<b>Property</b>:<i>chartMouseLeave</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.ChartMouseLeave())
</code>
</td>
</tr>

<tr>
<td><b>Fires on before chart double click</b></td>
<td>
<b>Property</b>:<i>ChartDoubleClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ChartDoubleClick())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires on chart mouse up</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>ChartmouseUp</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.ChartmouseUp())
</code>
</td>
</tr>

<tr>
<td><b>Fires on chart mouse down</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>ChartmouseDown</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.ChartmouseDown())
</code>
</td>
</tr>

<tr>
<td><b>Fires during the calculation of chart area bounds. You can use this event to customize the bounds of chart area</b></td>
<td>
<b>Property</b>:<i>ChartAreaBoundsCalculate</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ChartAreaBoundsCalculate())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires when chart is destroyed completely.</b></td>
<td>
<b>Property</b>:<i>Destroy</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Destroy())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires after chart is created.</b></td>
<td>
<b>Property</b>:<i>Create</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Create())
</code>
</td>
<td>
<b>Property</b>:<i>Loaded</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Loaded())
</code>
</td>
</tr>

<tr>
<td><b>Fires before rendering the data labels.</b></td>
<td>
<b>Property</b>:<i>DisplayTextRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.DisplayTextRendering())
</code>
</td>
<td>
<b>Property</b>:<i>TextRender</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.TextRender())
</code>
</td>
</tr>

<tr>
<td><b>Fires on clicking the legend item.</b></td>
<td>
<b>Property</b>:<i>LegendItemClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.LegendItemClick())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires when moving mouse over legend item</b></td>
<td>
<b>Property</b>:<i>LegendItemMouseMove</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.LegendItemMouseMove())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before rendering the legend item.</b></td>
<td>
<b>Property</b>:<i>LegendItemRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.LegendItemRendering())
</code>
</td>
<td>
<b>Property</b>:<i>LegendRender</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.LegendRender())
</code>
</td>
</tr>

<tr>
<td><b>Fires before loading the chart.</b></td>
<td>
<b>Property</b>:<i>Load</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Load())
</code>
</td>
<td>
<b>Property</b>:<i>Load</i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.Load())
</code>
</td>
</tr>

<tr>
<td><b>Fires on clicking a point in chart.</b></td>
<td>
<b>Property</b>:<i>PointRegionClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PointRegionClick())
</code>
</td>
<td>
<b>Property</b>:<i>PointClick </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.PointClick())
</code>
</td>
</tr>

<tr>
<td><b>Fires when mouse is moved over a point.</b></td>
<td>
<b>Property</b>:<i>PointRegionMouseMove</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PointRegionMouseMove())
</code>
</td>
<td>
<b>Property</b>:<i>PointMove </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.PointMove())
</code>
</td>
</tr>

<tr>
<td><b>Fires before rendering chart.</b></td>
<td>
<b>Property</b>:<i>PreRender</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PreRender())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires when point render.</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>PointRender </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.PointRender())
</code>
</td>
</tr>

<tr>
<td><b>Fires before rendering a series.</b></td>
<td>
<b>Property</b>:<i>SeriesRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SeriesRendering())
</code>
</td>
<td>
<b>Property</b>:<i>SeriesRender </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.SeriesRender())
</code>
</td>
</tr>

<tr>
<td><b>Fires before rendering the Chart title.</b></td>
<td>
<b>Property</b>:<i>TitleRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.TitleRendering())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before rendering the Chart sub title.</b></td>
<td>
<b>Property</b>:<i>SubTitleRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SubTitleRendering())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before rendering the tooltip. </b></td>
<td>
<b>Property</b>:<i>ToolTipInitialize</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ToolTipInitialize())
</code>
</td>
<td>
<b>Property</b>:<i>TooltipRender </i>
</br>
</br>
<code>
@(Html.EJS().AccumulationChart("container")
.TooltipRender())
</code>
</td>
</tr>
</table>