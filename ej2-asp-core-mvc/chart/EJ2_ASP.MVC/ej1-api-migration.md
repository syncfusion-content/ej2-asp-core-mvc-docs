---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Chart Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of  Chart component from Essential JS 1 to Essential JS 2.

## Annotations

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>rotation of annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Angle</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        .Angle(270).Add();
        })
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>annotations</b></td>
<td>
<b>Property</b>:<i>Annotations.Content</i>
</br>
<code>
<div id= "watermark" style="font-size:100px; display:none">2014</div>
<div>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.Content("watermark").Add();
    })
</div>
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.Content</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.Content(ViewBag.content).Add();
    })
</code>
</td>
</tr>

<tr>
<td><b>coordinate unit for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.CoordinateUnit</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
    .Annotations(an => {
        an.CoordinateUnit(CoordinateUnit.Pixels).Add();
    })
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.CoordinateUnits</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.CoordinateUnits(Syncfusion.EJ2.Charts.Units.Point).Add();
    })
</code>
</td>
</tr>

<tr>
<td><b>horizontalAlignment for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.HorizontalAlignment</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.HorizontalAlignment(HorizontalAlignment.Left).Add();
    })
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.HorizontalAlignment</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.HorizontalAlignment(Syncfusion.EJ2.Charts.Position.Near).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>margin for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Margin</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.Margin(mr=>mr.Right(40)).Add();
})
)
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Opacity for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Opacity</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.Opacity(0.2).Add();
})
)
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Region for annotation with respect to chart or series</b></td>
<td>
<b>Property</b>:<i>Annotations.Region</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.Region(Region.Series).Add();
})
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.Region</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.Region(Region.Series).Add();
    })
</code>
</td>
</tr>

<tr>
<td><b>verticalAlignment for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.VerticalAlignment</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.VerticalAlignment(VerticalAlignment.Middle).Add();
})
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.VerticalAlignment</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.VerticalAlignment(Syncfusion.EJ2.Charts.Position.Top).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Visibility of annotations</b></td>
<td>
<b>Property</b>:<i>Annotations.Visible</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.Visible(true).Add();
})
)
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>X offset for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.X</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.X(170).Add();
})
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.X</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.X("170").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>X axis name in which annotation to be rendered</b></td>
<td>
<b>Property</b>:<i>Annotations.XAxisName</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.XAxisName("xAxis").Add();
})
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.XAxisName</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.XAxisName("xAxis").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Y offset for annotation</b></td>
<td>
<b>Property</b>:<i>Annotations.Y</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.Y("50").Add();
})
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.Y</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.Y("50").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Y axis name in which annotation to be rendered</b></td>
<td>
<b>Property</b>:<i>Annotations.YAxisName</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Annotations(an => {
        an.YAxisName("yAxis").Add();
})
)
</code>
</td>
<td>
<b>Property</b>:<i>Annotations.YAxisName</i>
</br>
<code>
@Html.EJS().Chart("container")
.Annotations(an => {
           an.YAxisName("yAxis").Add();
})
</code>
</td>
</tr>
</table>

## Columns

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Columns in chart</b></td>
<td>
<b>Property</b>:<i>ColumnDefinitions</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ColumnDefinitions()
</code>
</td>
<td>
<b>Property</b>:<i>Columns</i>
</br>
<code>
@Html.EJS().Chart("container")
.Columns()
</code>
</td>
</tr>

<tr>
<td><b>unit</b></td>
<td>
<b>Property</b>:<i>ColumnDefinitions.Unit</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ColumnDefinitions(cdn =>
      {
          cdn.Unit("percentage").Add();
      })
</div>
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>width of columns in chart</b></td>
<td>
<b>Property</b>:<i>ColumnDefinitions.ColumnWidth</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
    .ColumnDefinitions(cdn =>
      {
          cdn.ColumnWidth(50).Add();
      })
</code>
</td>
<td>
<b>Property</b>:<i>Columns.Width</i>
</br>
<code>
@Html.EJS().Chart("container")
.Columns(columns =>
   {
       columns.width("50%").Add();
   })
</code>
</td>
</tr>

<tr>
<td><b>Line customization</b></td>
<td>
<b>Property</b>:<i>LineColor, LineWidth</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
    .ColumnDefinitions(cdn =>
      {
          cdn.ColumnWidth(50).LineColor('red').LineWidth(2).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Columns.Border</i>
</br>
<code>
@Html.EJS().Chart("container")
.Columns(columns =>
   {
       columns.Width("50%").Border(br => br.Width("2").Color("red")).Add();
   })
</code>
</td>
</tr>
</table>

## CommonSeriesOptions

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>commonSeriesOptions</b></td>
<td>
<b>Property</b>:<i>CommonSeriesOptions</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.CommonSeriesOptions()
</code>
</td>
<td>
<b>Not applicable</b>
</tr>
</table>

## Crosshair

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>crosshair</b></td>
<td>
<b>Property</b>:<i>Crosshair.Visible</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Crosshair(crosshair=>crosshair.Visible(true))
</code>
</td>
<td>
<b>Property</b>:<i>Crosshair.Enable</i>
</br>
<code>
@Html.EJS().Chart("container")
.Crosshair(cr=>cr.Enable(true))
</code>
</td>
</tr>

<tr>
<td><b>trackballTooltipSettings</b></td>
<td>
<b>Property</b>:<i>TrackballTooltipSettings</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Crosshair(crosshair => crosshair.TrackballTooltipSettings(tr => tr.Border(br => br.Width(2)))
</div>
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>marker</b></td>
<td>
<b>Property</b>:<i>Marker</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Crosshair(crosshair => crosshair.Marker(mr => mr.Border(br => br.Width(2)))
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>crosshair line style</b></td>
<td>
<b>Property</b>:<i>Line</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Crosshair(crosshair => crosshair.Line(line=>line.Color("grey").Width(2)))
</code>
</td>
<td>
<b>Property</b>:<i>Line</i>
</br>
<code>
@Html.EJS().Chart("container")
.Crosshair(crosshair => crosshair.Line(line => line.Border(br => br.Width(2).Color("grey")))
</code>
</td>
</tr>

<tr>
<td><b>type</b></td>
<td>
<b>Property</b>:<i>Type</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Crosshair(crosshair => crosshair.Type("trackball"))
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>
</table>

## 3D chart

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>3d chart</b></td>
<td>
<b>Property</b>:<i>Enable3D</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Enable3D(true)
)
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Rotation of 3d chart</b></td>
<td>
<b>Property</b>:<i>EnableRotation</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.EnableRotation(true)
)
</div>
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>depth</b></td>
<td>
<b>Property</b>:<i>Depth</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Depth(120)
)
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>
</table>

## Canvas rendering

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>canvas rendering</b></td>
<td>
<b>Property</b>:<i>EnableCanvasRendering</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.EnableCanvasRendering(true)
)
</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>
</table>

## Indicators

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Type of Indicator</b></td>
<td>
<b>Property</b>:<i>Type</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .Type(ChartIndicatorType.AccumulationDistribution).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Type</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Type(Syncfusion.EJ2.Charts.TechnicalIndicators.AccumulationDistribution).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Period for indicator</b></td>
<td>
<b>Property</b>:<i>Period</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .Period(3).Add();
      })
)
</div>
</code>
</td>
<td>
<b>Property</b>:<i>Period</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Period(3).Add();})
</code>
</td>
</tr>

<tr>
<td><b>%K value in stochastic indicator</b></td>
<td>
<b>Property</b>:<i>KPeriod</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .KPeriod(14).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>KPeriod</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.KPeriod("14").Add();})
</code>
</td>
</tr>

<tr>
<td><b>%D value in stochastic indicator</b></td>
<td>
<b>Property</b>:<i>DPeriod</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .DPeriod("3").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>DPeriod</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.DPeriod("3").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Shows overSold/overBought values</b></td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property</b>:<i>ShowZones</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.ShowZones(true).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Overbought value for RSI and stochastic indicator</b></td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property</b>:<i>OverBought</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.OverBought("80").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Oversold value for RSI and stochastic indicator</b></td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property</b>:<i>OverSold</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.OverSold("20").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Standard deviation for Bollingerbands</b></td>
<td>
<b>Property</b>:<i>StandardDeviations</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .StandardDeviations("2").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>StandardDeviation</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.StandardDeviation("2").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Field for indicator</b></td>
<td>
<b>Property</b>:<i>Field</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .Field("Close").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Field</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Field(Syncfusion.EJ2.Charts.FinancialDataFields.Close).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Slow period for MACD indicator</b></td>
<td>
<b>Property</b>:<i>ShortPeriod</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .ShortPeriod("12").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>slowPeriod</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.slowPeriod("12").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Fast period for MACD indicator</b></td>
<td>
<b>Property</b>:<i>LongPeriod</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .LongPeriod("26").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>FastPeriod</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.FastPeriod("26").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Line style for MACD indicator</b></td>
<td>
<b>Property</b>:<i>MacdLine</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind
          .MacdLine(ma => ma.Width("2").Fill("red")).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>MacdLine</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.MacdLine(ma => ma.Width("2").Fill("red")).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Type of MACD indicator</b></td>
<td>
<b>Property</b>:<i>Type</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.Type(ChartIndicatorType.MACD).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>MacdType</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.MacdType(Syncfusion.EJ2.Charts.MacdType.Both).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Color of the positive bars in Macd indicators</b></td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property</b>:<i>MacdPositiveColor</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.MacdPositiveColor("red").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Color of the negative bars in Macd indicators</b></td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property</b>:<i>MacdNegativeColor</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.MacdNegativeColor("red").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Color for Bollinger bands</b></td>
<td>
<b>Not Applicable</b>
</td>
<td>
<b>Property</b>:<i>BandColor</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.BandColor("red").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Appearance of upper line in indicator</b></td>
<td>
<b>Property</b>:<i>UpperLine</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.UpperLine(up => up.Fill("red").Width("2")).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>UpperLine</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.UpperLine(up => up.Fill("red").Width("2")).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Appearance of lower line in indicator</b></td>
<td>
<b>Property</b>:<i>LowerLine</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.LowerLine(lo => lo.Fill("red").Width("2")).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>LowerLine</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.LowerLine(lo => lo.Fill("red").Width("2")).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Appearance of period line in indicator</b></td>
<td>
<b>Property</b>:<i>PeriodLine</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.PeriodLine(pl => pl.Fill("red").Width("2")).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>PeriodLine</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.PeriodLine(pl => pl.Fill("red").Width("2")).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Name of the series for which indicator has to be drawn</b></td>
<td>
<b>Property</b>:<i>SeriesName</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.SeriesName("series1").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>SeriesName</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.SeriesName("series1")).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Options to customize the histogram in MACD indicator</b></td>
<td>
<b>Property</b>:<i>Histogram</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind. Histogram().Add();
      })
)
</code>
</td>
<td>
<b>Not Applicable</b>
</td>
</tr>

<tr>
<td><b>Enabling animation</b></td>
<td>
<b>Property</b>:<i>EnableAnimation</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind. enableAnimation(true).Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Animation.Enable</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Animation(an => an.Enable(true)).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Animation duration</b></td>
<td>
<b>Property</b>:<i>AnimationDuration</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind. animationDuration("3000").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Animation.Duration</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Animation(an => an.Duration("3000")).Add();})
</code>
</td>
</tr>

<tr>
<td><b>Tooltip</b></td>
<td>
<b>Property</b>:<i>Tooltip.Visible</i>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.Tooltip(tp => tp.Visible(true)).Add();
      })
)
</code>
</td>
<td>
<b>Not Applicable</b>
</td>
</tr>

<tr>
<td><b>Trigger value of MACD indicator</b></td>
<td>
<b>Property</b>:<i>Trigger</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.Trigger("14").Add();
      })
)
</code>
</td>
<td>
<b>Not Applicable</b>
</td>
</tr>

<tr>
<td><b>Fill color for indicator</b></td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.Fill("red").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Fill("red").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Width for indicator</b></td>
<td>
<b>Property</b>:<i>Width</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.Width("2").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.Width("2").Add();})
</code>
</td>
</tr>

<tr>
<td><b>xAxis Name of  indicator</b></td>
<td>
<b>Property</b>:<i>XAxisName</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.XAxisName("").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>XAxisName</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.XAxisName("").Add();})
</code>
</td>
</tr>

<tr>
<td><b>yAxis Name of  indicator</b></td>
<td>
<b>Property</b>:<i>YAxisName</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.YAxisName("").Add();
      })
)
</code>
</td>
<td>
<b>Property</b>:<i>YAxisName</i>
</br>
<code>
@Html.EJS().Chart("container").Indicators(id =>{id.YAxisName("").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Visibility of indicator</b></td>
<td>
<b>Property</b>:<i>Visibility</i>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Indicators(ind => { ind.Visibility(true).Add();
      })
)
</code>
</td>
<td>
<b>Not Applicable</b>
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
<b>Property</b>:<i>Legend.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.Visible(true))
)
</code>
</td>
<td>
<b>Property</b>:<i>LegendSettings.Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container").LegendSettings(legend => legend.Visible(true))
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
.Legend(lg=>lg.Size(sz => sz.Height("50"))))
</code>
</td>
<td>
<b>Property</b>:<i>Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container").LegendSettings(legend => legend.Height("50"))
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
.Legend(lg=>lg.Size(sz => sz.Width("50"))))
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container").LegendSettings(legend => legend.Width("50"))
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
.Legend(lg=>lg.Location(loc => loc.X("3").Y("45"))))
</code>
</td>
<td>
<b>Property</b>:<i>Location</i>
</br>
</br>
<code>
@Html.EJS().Chart("container").LegendSettings(le => le.Location(loc => loc.X("3").Y("45")))
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
.Legend(lg=>lg.Position(LegendPosition.Top)))
</code>
</td>
<td>
<b>Property</b>:<i>Position</i>
</br>
</br>
<code>
@Html.EJS().Chart("container").LegendSettings(le => le.Position(Syncfusion.EJ2.Charts.LegendPosition.Top))
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
@Html.EJS().Chart("container").LegendSettings(le => le.Padding("8"))
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
.Legend(lg=>lg.Alignment(Syncfusion.JavaScript.DataVisualization.TextAlignment.Far)))
</code>
</td>
<td>
<b>Property</b>:<i>Alignment</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.Alignment(Syncfusion.EJ2.Charts.Alignment.Far))
</code>
</td>
</tr>

<tr>
<td><b>Text style for legend</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.Font(font=>font.FontFamily("Segoe UI").FontStyle(ChartFontStyle.Italic)
                .FontWeight(ChartFontWeight.Bold).Size("12px"))))
</code>
</td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.Font(ViewBag.font))
</code>
</td>
</tr>

<tr>
<td><b>Shape height of legend</b></td>
<td>
<b>Property</b>:<i>ItemStyle.Height</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.ItemStyle(item=>item.Height(13))))
</code>
</td>
<td>
<b>Property</b>:<i>ShapeHeight</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.ShapeHeight(20))
</code>
</td>
</tr>

<tr>
<td><b>Shape width of legend</b></td>
<td>
<b>Property</b>:<i>ItemStyle.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.ItemStyle(item=>item.Width("20"))))
</code>
</td>
<td>
<b>Property</b>:<i>ShapeWidth</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.ShapeWidth("20"))
</code>
</td>
</tr>

<tr>
<td><b>Shape border of legend</b></td>
<td>
<b>Property</b>:<i>ItemStyle.Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.ItemStyle(item=>item.Border(br=>br.Width(1).Color("#FF0000")))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Shape padding of legend</b></td>
<td>
<b>Property</b>:<i>ItemPadding</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.ItemPadding(15)))
</code>
</td>
<td>
<b>Property</b>:<i>ShapePadding</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.ShapePadding("20"))
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
.Legend(lg=>lg.Background("transparent")))
</code>
</td>
<td>
<b>Property</b>:<i>Backgorund</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.Backgorund("transparent"))
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
.Legend(lg=>lg.Opacity("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.Opacity("0.3"))
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
.Legend(lg=>lg.ToggleSeriesVisibility(true)))
</code>
</td>
<td>
<b>Property</b>:<i>ToggleVisibility</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.ToggleVisibility(true))
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
.Legend(lg=>lg.Title()))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Text Overflow for legend</b></td>
<td>
<b>Property</b>:<i>TextOverflow</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Legend(lg=>lg.TextOverflow(TextOverflow.Trim)))
</code>
</td>
<td>
<b>Property</b>:<i>TextStyle.TextOverFlow</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(le => le.TextStyle(tx => tx.TextOverFlow("Trim")))
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
.Legend(lg=>lg.TextWidth("3")))
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
.Legend(lg=>lg.EnableScrollBar(true)))
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
.Legend(lg=>lg.RowCount("2")))
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
.Legend(lg=>lg.ColumnCount("2")))
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
.Legend(lg=>lg.Fill("red")))
</code>
</td>
<td>
Not applicable
</td>
</tr>
</table>

## primaryXAxis

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Alternate grid band</b></td>
<td>
<b>Property</b>:<i>AlternateGridBand</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.AlternateGridBand(alt => alt.even(e => e.Fill("red")))))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Axis line cross value</b></td>
<td>
<b>Property</b>:<i>CrossesAt</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.CrossesAt(0)))
</code>
</td>
<td>
<b>Property</b>:<i>CrossesAt</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.CrossesAt(0)))
</code>
</td>
</tr>

<tr>
<td><b>Axis name with which the axis line has to be crossed</b></td>
<td>
<b>Property</b>:<i>CrossesInAxis</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.CrossesInAxis("")))
</code>
</td>
<td>
<b>Property</b>:<i>CrossesInAxis</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.CrossesInAxis(""))
</code>
</td>
</tr>

<tr>
<td><b>Axis elements placed with axis line</b></td>
<td>
<b>Property</b>:<i>ShowNextToAxisLine</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ShowNextToAxisLine(true)))
</code>
</td>
<td>
<b>Property</b>:<i>PlaceNextToAxisLine</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.PlaceNextToAxisLine(true))
</code>
</td>
</tr>

<tr>
<td><b>Axis line style</b></td>
<td>
<b>Property</b>:<i>AxisLine.Color</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.AxisLine(al => al.Color("red"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LineStyle(ls => ls.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Axis line dashArray</b></td>
<td>
<b>Property</b>:<i>AxisLine.DashArray</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.AxisLine(al => al.DashArray("10,5"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LineStyle(ls => ls.DashArray("10,5")))
</code>
</td>
</tr>

<tr>
<td><b>Offset for axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Offset</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.AxisLine(al => al.Offset("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LineStyle(ls => ls.PlotOffset("10")))
</code>
</td>
</tr>

<tr>
<td><b>Visible of an axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.AxisLine(al => al.Visible(false))))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LineStyle(ls => ls.Visible(false)))
</code>
</td>
</tr>

<tr>
<td><b>Width of an axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.AxisLine(al => al.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LineStyle(ls => ls.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Column index of an axis</b></td>
<td>
<b>Property</b>:<i>ColumnIndex</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ColumnIndex("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>ColumnIndex</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.ColumnIndex("2")))
</code>
</td>
</tr>

<tr>
<td><b>Span of an axis to place horizontally or vertically</b></td>
<td>
<b>Property</b>:<i>ColumnSpan</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ColumnSpan("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Span</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Span("2")))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label of an axis</b></td>
<td>
<b>Property</b>:<i>CrossHairLabel.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.CrossHairLabel(cr => cr.Visible(true))))
</code>
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.Enable</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.CrossHairLabel(cr => cr.Enable(true)))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label color of an axis</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.CrossHairLabel(cr => cr.Fill("red")))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label text style</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.TextStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.CrossHairLabel(cr => cr.TextStyle()))
</code>
</td>
</tr>

<tr>
<td><b>Desired interval count for primaryXAxis</b></td>
<td>
<b>Property</b>:<i>DesiredIntervals</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.DesiredIntervals("4")))
</code>
</td>
<td>
<b>Property</b>:<i>DesiredIntervals</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.DesiredIntervals("4"))
</code>
</td>
</tr>

<tr>
<td><b>Edges primaryXAxis</b></td>
<td>
<b>Property</b>:<i>EdgeLabelPlacement</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.EdgeLabelPlacement("none")))
</code>
</td>
<td>
<b>Property</b>:<i>EdgeLabelPlacement</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.EdgeLabelPlacement("none"))
</code>
</td>
</tr>

<tr>
<td><b>Enables trim for axis labels</b></td>
<td>
<b>Property</b>:<i>EnableTrim</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.EnableTrim(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableTrim</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.EnableTrim(true))
</code>
</td>
</tr>

<tr>
<td><b>Specifies the interval of the axis according to the zoomed data of the chart</b></td>
<td>
<b>Property</b>:<i>EnableAutoIntervalOnZooming</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.EnableAutoIntervalOnZooming(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableAutoIntervalOnZooming</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.EnableAutoIntervalOnZooming(true))
</code>
</td>
</tr>

<tr>
<td><b>Title style for primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Font()))
</code>
</td>
<td>
<b>Property</b>:<i>TitleStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.TitleStyle())
</code>
</td>
</tr>

<tr>
<td><b>Indexed for category axis</b></td>
<td>
<b>Property</b>:<i>IsIndexed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.IsIndexed(true)))
</code>
</td>
<td>
<b>Property</b>:<i>IsIndexed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.IsIndexed(true))
</code>
</td>
</tr>

<tr>
<td><b>Interval type for date time axis</b></td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.IntervalType("Auto")))
</code>
</td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.IntervalType("Auto"))
</code>
</td>
</tr>

<tr>
<td><b>Inversed axis</b></td>
<td>
<b>Property</b>:<i>IsInversed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.IsInversed(true)))
</code>
</td>
<td>
<b>Property</b>:<i>IsInversed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.IsInversed(true))
</code>
</td>
</tr>

<tr>
<td><b>Custom label format</b></td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LabelFormat('{value}K')))
</code>
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LabelFormat('{value}K'))
</code>
</td>
</tr>

<tr>
<td><b>labelIntersectAction</b></td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LabelIntersectAction("trim")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LabelIntersectAction("Trim"))
</code>
</td>
</tr>

<tr>
<td><b>labelPosition</b></td>
<td>
<b>Property</b>:<i>LabelPosition</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LabelPosition("inside")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LabelPosition("Inside"))
</code>
</td>
</tr>

<tr>
<td><b>labelPlacement for category axis</b></td>
<td>
<b>Property</b>:<i>LabelPlacement</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LabelPlacemen("onTicks")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelPlacement</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LabelPlacemen("onTicks"))
</code>
</td>
</tr>

<tr>
<td><b>Axis label alignment</b></td>
<td>
<b>Property</b>:<i>Alignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Alignment("center")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Rotation of axis labels</b></td>
<td>
<b>Property</b>:<i>LabelRotation</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LabelRotation("45")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelRotation</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LabelRotation("45"))
</code>
</td>
</tr>

<tr>
<td><b>Log base value for logarithmic axis</b></td>
<td>
<b>Property</b>:<i>LogBase</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LogBase("10")))
</code>
</td>
<td>
<b>Property</b>:<i>LogBase</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LogBase("10"))
</code>
</td>
</tr>

<tr>
<td><b>Major grid line visible</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>DashArray of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.DashArray</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.DashArray("10,2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.DashArray("10,2")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of major grid line</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Major Tick line</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorTickLines(mtl => mtl.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorTickLines(mtl => mtl.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Height of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Size</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorTickLines(mtl => mtl.Size("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Height("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorTickLines(mtl => mtl.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MajorGridLines(mgl => mgl.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of major Tick line</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MajorTickLines(mtl => mtl.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>maximum labels of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>MaximumLabels</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MaximumLabels("5")))
</code>
</td>
<td>
<b>Property</b>:<i>MaximumLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MaximumLabels("5"))
</code>
</td>
</tr>

<tr>
<td><b>maximum labels width of primaryXAxis to trim</b></td>
<td>
<b>Property</b>:<i>MaximumLabelWidth</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MaximumLabelWidth("40")))
</code>
</td>
<td>
<b>Property</b>:<i>MaximumLabelWidth</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MaximumLabelWidth("40"))
</code>
</td>
</tr>

<tr>
<td><b>minor grid line</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>DashArray of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.DashArray</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.DashArray("10,5"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.DashArray("10,5")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of minor grid line</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorGridLines(mi => mi.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>minor Tick line</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorTickLines(mit => mit.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorTickLines(mit => mit.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorTickLines(mi => mi.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Height of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Size</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorTickLines(mit => mit.Size("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorTickLines(mi => mi.Height("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Color</i>
</br>
</br>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorTickLines(mit => mit.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorTickLines(mi => mi.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of minor Tick line</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorTickLines(mit => mit.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Minor ticks per interval of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>MinorTicksPerInterval</i>
</br>
</br>
<code>
Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MinorTicksPerInterval("4"))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTicksPerInterval</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MinorTicksPerInterval("4"))
</code>
</td>
</tr>

<tr>
<td><b>name of the primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Name("primaryXAxis")))
</code>
</td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Name("primaryXAxis"))
</code>
</td>
</tr>

<tr>
<td><b>Orientation of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Orientation</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Orientation("Horizontal")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Plot offset for primaryXAxis</b></td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.PlotOffset("0")))
</code>
</td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.PlotOffset("0"))
</code>
</td>
</tr>

<tr>
<td><b>minimum for  primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Range.Minimum</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Range(r => r.Minimum("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>Minimum</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Minimum("10"))
</code>
</td>
</tr>

<tr>
<td><b>maximum for primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Range.Maximum</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Range(r => r.Maximum("23"))))
</code>
</td>
<td>
<b>Property</b>:<i>Maximum</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Maximum("23"))
</code>
</td>
</tr>

<tr>
<td><b>interval for  primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Range.Interval</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Range(r => r.Interval("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Interval</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Interval("2"))
</code>
</td>
</tr>

<tr>
<td><b>RangePadding for  primaryXAxis</b></td>
<td>
<b>Property</b>:<i>RangePadding</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.RangePadding("none")))
</code>
</td>
<td>
<b>Property</b>:<i>RangePadding</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.RangePadding("none"))
</code>
</td>
</tr>

<tr>
<td><b>Rounding Places in primaryXAxis</b></td>
<td>
<b>Property</b>:<i>RoundingPlaces </i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.RoundingPlaces("3")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.LabelFormat("n3"))
</code>
</td>
</tr>

<tr>
<td><b>ScrollBar settings of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>ScrollbarSettings </i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ScrollbarSettings()))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>TickPosition in primaryXAxis</b></td>
<td>
<b>Property</b>:<i>TickLinesPosition</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.TickLinesPosition("Inside")))
</code>
</td>
<td>
<b>Property</b>:<i>TickPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.TickPosition("Inside")))
</code>
</td>
</tr>

<tr>
<td><b>valueType of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ValueType("DateTime")))
</code>
</td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.ValueType("DateTime"))
</code>
</td>
</tr>

<tr>
<td><b>visible of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Visible(true)))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Visible(true))
</code>
</td>
</tr>

<tr>
<td><b>zoomFactor of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>ZoomFactor</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ZoomFactor("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomFactor</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.ZoomFactor("0.3"))
</code>
</td>
</tr>

<tr>
<td><b>zoomPosition of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>ZoomPosition</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.ZoomPosition("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.ZoomPosition("0.3"))
</code>
</td>
</tr>

<tr>
<td><b>labelBorder of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>LabelBorder</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.LabelBorder(lb => lb.Color("red").Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Border(b => b.Color("red").Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>title of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>Title.Text</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.Title(t => t.Text("Chart Title"))))
</code>
</td>
<td>
<b>Property</b>:<i>Title</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.Title("Chart Title")
</code>
</td>
</tr>

<tr>
<td><b>StripLine of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>StripLine</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.StripLine()))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.StripLines())
</code>
</td>
</tr>

<tr>
<td><b>Multilevel labels of primaryXAxis</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px=>px.MultiLevelLabels)))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryXAxis(px=>px.MultiLevelLabels())
</code>
</td>
</tr>

<tr>
<td><b>skeleton for an axes</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Skeleton</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(ax=>ax.Skeleton('yMd'))
</code>
</td>
</tr>
<tr>
<td><b>skeleton type for an axes</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>SkeletonType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(ax=>ax.SkeletonType("DateTime"))
</code>
</td>
</tr>
<table>

## primaryYAxis

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Alternate grid band</b></td>
<td>
<b>Property</b>:<i>AlternateGridBand</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryYAxis(px=>px.AlternateGridBand(alt => alt.even(e => e.Fill("red")))))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Axis line cross value</b></td>
<td>
<b>Property</b>:<i>CrossesAt</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryYAxis(px=>px.CrossesAt(0)))
</code>
</td>
<td>
<b>Property</b>:<i>CrossesAt</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryYAxis(px=>px.CrossesAt(0)))
</code>
</td>
</tr>

<tr>
<td><b>Axis name with which the axis line has to be crossed</b></td>
<td>
<b>Property</b>:<i>CrossesInAxis</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryYAxis(px=>px.CrossesInAxis("")))
</code>
</td>
<td>
<b>Property</b>:<i>CrossesInAxis</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryYAxis(px=>px.CrossesInAxis(""))
</code>
</td>
</tr>

<tr>
<td><b>Axis elements placed with axis line</b></td>
<td>
<b>Property</b>:<i>ShowNextToAxisLine</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryYAxis(px=>px.ShowNextToAxisLine(true)))
</code>
</td>
<td>
<b>Property</b>:<i>PlaceNextToAxisLine</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.PlaceNextToAxisLine(true))
</code>
</td>
</tr>

<tr>
<td><b>Axis line style</b></td>
<td>
<b>Property</b>:<i>AxisLine.Color</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.AxisLine(al => al.Color("red"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LineStyle(ls => ls.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Axis line dashArray</b></td>
<td>
<b>Property</b>:<i>AxisLine.DashArray</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.AxisLine(al => al.DashArray("10,5"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LineStyle(ls => ls.DashArray("10,5")))
</code>
</td>
</tr>

<tr>
<td><b>Offset for axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Offset</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.AxisLine(al => al.Offset("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LineStyle(ls => ls.PlotOffset("10")))
</code>
</td>
</tr>

<tr>
<td><b>Visible of an axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.AxisLine(al => al.Visible(false))))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LineStyle(ls => ls.Visible(false)))
</code>
</td>
</tr>

<tr>
<td><b>Width of an axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.AxisLine(al => al.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LineStyle(ls => ls.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Column index of an axis</b></td>
<td>
<b>Property</b>:<i>ColumnIndex</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.ColumnIndex("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>ColumnIndex</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.ColumnIndex("2")))
</code>
</td>
</tr>

<tr>
<td><b>Span of an axis to place horizontally or vertically</b></td>
<td>
<b>Property</b>:<i>ColumnSpan</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.ColumnSpan("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Span</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Span("2")))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label of an axis</b></td>
<td>
<b>Property</b>:<i>CrossHairLabel.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.CrossHairLabel(cr => cr.Visible(true))))
</code>
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.Enable</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.CrossHairLabel(cr => cr.Enable(true)))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label color of an axis</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.CrossHairLabel(cr => cr.Fill("red")))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label text style</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.TextStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.CrossHairLabel(cr => cr.TextStyle()))
</code>
</td>
</tr>

<tr>
<td><b>Desired interval count for primaryYAxis</b></td>
<td>
<b>Property</b>:<i>DesiredIntervals</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.DesiredIntervals("4")))
</code>
</td>
<td>
<b>Property</b>:<i>DesiredIntervals</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.DesiredIntervals("4"))
</code>
</td>
</tr>

<tr>
<td><b>Edges primaryYAxis</b></td>
<td>
<b>Property</b>:<i>EdgeLabelPlacement</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.EdgeLabelPlacement("none")))
</code>
</td>
<td>
<b>Property</b>:<i>EdgeLabelPlacement</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.EdgeLabelPlacement("none"))
</code>
</td>
</tr>

<tr>
<td><b>Enables trim for axis labels</b></td>
<td>
<b>Property</b>:<i>EnableTrim</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.EnableTrim(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableTrim</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.EnableTrim(true))
</code>
</td>
</tr>

<tr>
<td><b>Specifies the interval of the axis according to the zoomed data of the chart</b></td>
<td>
<b>Property</b>:<i>EnableAutoIntervalOnZooming</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.EnableAutoIntervalOnZooming(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableAutoIntervalOnZooming</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.EnableAutoIntervalOnZooming(true))
</code>
</td>
</tr>

<tr>
<td><b>Title style for primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Font()))
</code>
</td>
<td>
<b>Property</b>:<i>TitleStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.TitleStyle())
</code>
</td>
</tr>

<tr>
<td><b>Indexed for category axis</b></td>
<td>
<b>Property</b>:<i>IsIndexed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.IsIndexed(true)))
</code>
</td>
<td>
<b>Property</b>:<i>IsIndexed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.IsIndexed(true))
</code>
</td>
</tr>

<tr>
<td><b>Interval type for date time axis</b></td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.IntervalType("Auto")))
</code>
</td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.IntervalType("Auto"))
</code>
</td>
</tr>

<tr>
<td><b>Inversed axis</b></td>
<td>
<b>Property</b>:<i>IsInversed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.IsInversed(true)))
</code>
</td>
<td>
<b>Property</b>:<i>IsInversed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.IsInversed(true))
</code>
</td>
</tr>

<tr>
<td><b>Custom label format</b></td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LabelFormat('{value}K')))
</code>
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LabelFormat('{value}K'))
</code>
</td>
</tr>

<tr>
<td><b>labelIntersectAction</b></td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LabelIntersectAction("trim")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LabelIntersectAction("Trim"))
</code>
</td>
</tr>

<tr>
<td><b>labelPosition</b></td>
<td>
<b>Property</b>:<i>LabelPosition</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LabelPosition("inside")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LabelPosition("Inside"))
</code>
</td>
</tr>

<tr>
<td><b>labelPlacement for category axis</b></td>
<td>
<b>Property</b>:<i>LabelPlacement</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LabelPlacemen("onTicks")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelPlacement</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LabelPlacemen("onTicks"))
</code>
</td>
</tr>

<tr>
<td><b>Axis label alignment</b></td>
<td>
<b>Property</b>:<i>Alignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Alignment("center")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Rotation of axis labels</b></td>
<td>
<b>Property</b>:<i>LabelRotation</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LabelRotation("45")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelRotation</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LabelRotation("45"))
</code>
</td>
</tr>

<tr>
<td><b>Log base value for logarithmic axis</b></td>
<td>
<b>Property</b>:<i>LogBase</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LogBase("10")))
</code>
</td>
<td>
<b>Property</b>:<i>LogBase</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LogBase("10"))
</code>
</td>
</tr>

<tr>
<td><b>Major grid line visible</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>DashArray of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.DashArray</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.DashArray("10,2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.DashArray("10,2")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of major grid line</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Major Tick line</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorTickLines(mtl => mtl.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorTickLines(mtl => mtl.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Height of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Size</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorTickLines(mtl => mtl.Size("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Height("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorTickLines(mtl => mtl.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MajorGridLines(mgl => mgl.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of major Tick line</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MajorTickLines(mtl => mtl.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>maximum labels of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>MaximumLabels</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MaximumLabels("5")))
</code>
</td>
<td>
<b>Property</b>:<i>MaximumLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MaximumLabels("5"))
</code>
</td>
</tr>

<tr>
<td><b>maximum labels width of primaryYAxis to trim</b></td>
<td>
<b>Property</b>:<i>MaximumLabelWidth</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MaximumLabelWidth("40")))
</code>
</td>
<td>
<b>Property</b>:<i>MaximumLabelWidth</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MaximumLabelWidth("40"))
</code>
</td>
</tr>

<tr>
<td><b>minor grid line</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>DashArray of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.DashArray</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.DashArray("10,5"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.DashArray("10,5")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of minor grid line</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorGridLines(mi => mi.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>minor Tick line</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorTickLines(mit => mit.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorTickLines(mit => mit.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorTickLines(mi => mi.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Height of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Size</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorTickLines(mit => mit.Size("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorTickLines(mi => mi.Height("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Color</i>
</br>
</br>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorTickLines(mit => mit.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorTickLines(mi => mi.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of minor Tick line</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorTickLines(mit => mit.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Minor ticks per interval of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>MinorTicksPerInterval</i>
</br>
</br>
<code>
Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.MinorTicksPerInterval("4"))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTicksPerInterval</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.MinorTicksPerInterval("4"))
</code>
</td>
</tr>

<tr>
<td><b>name of the primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Name("primaryYAxis")))
</code>
</td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Name("primaryYAxis"))
</code>
</td>
</tr>

<tr>
<td><b>Orientation of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Orientation</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Orientation("Horizontal")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Plot offset for primaryYAxis</b></td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.PlotOffset("0")))
</code>
</td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.PlotOffset("0"))
</code>
</td>
</tr>

<tr>
<td><b>minimum for  primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Range.Minimum</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Range(r => r.Minimum("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>Minimum</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Minimum("10"))
</code>
</td>
</tr>

<tr>
<td><b>maximum for primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Range.Maximum</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Range(r => r.Maximum("23"))))
</code>
</td>
<td>
<b>Property</b>:<i>Maximum</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Maximum("23"))
</code>
</td>
</tr>

<tr>
<td><b>interval for  primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Range.Interval</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Range(r => r.Interval("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Interval</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Interval("2"))
</code>
</td>
</tr>

<tr>
<td><b>RangePadding for  primaryYAxis</b></td>
<td>
<b>Property</b>:<i>RangePadding</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.RangePadding("none")))
</code>
</td>
<td>
<b>Property</b>:<i>RangePadding</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.RangePadding("none"))
</code>
</td>
</tr>

<tr>
<td><b>Rounding Places in primaryYAxis</b></td>
<td>
<b>Property</b>:<i>RoundingPlaces </i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.RoundingPlaces("3")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.LabelFormat("n3"))
</code>
</td>
</tr>

<tr>
<td><b>ScrollBar settings of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>ScrollbarSettings </i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.ScrollbarSettings()))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>TickPosition in primaryYAxis</b></td>
<td>
<b>Property</b>:<i>TickLinesPosition</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.TickLinesPosition("Inside")))
</code>
</td>
<td>
<b>Property</b>:<i>TickPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.TickPosition("Inside")))
</code>
</td>
</tr>

<tr>
<td><b>valueType of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.ValueType("DateTime")))
</code>
</td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.ValueType("DateTime"))
</code>
</td>
</tr>

<tr>
<td><b>visible of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Visible(true)))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Visible(true))
</code>
</td>
</tr>

<tr>
<td><b>zoomFactor of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>ZoomFactor</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.ZoomFactor("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomFactor</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.ZoomFactor("0.3"))
</code>
</td>
</tr>

<tr>
<td><b>zoomPosition of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>ZoomPosition</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.ZoomPosition("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.ZoomPosition("0.3"))
</code>
</td>
</tr>

<tr>
<td><b>labelBorder of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>LabelBorder</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.LabelBorder(lb => lb.Color("red").Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Border(b => b.Color("red").Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>title of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>Title.Text</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.Title(t => t.Text("Chart Title"))))
</code>
</td>
<td>
<b>Property</b>:<i>Title</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.Title("Chart Title")
</code>
</td>
</tr>

<tr>
<td><b>StripLine of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>StripLine</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.primaryYAxis(px=>px.StripLine()))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.primaryYAxis(px=>px.StripLines())
</code>
</td>
</tr>

<tr>
<td><b>Multilevel labels of primaryYAxis</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.PrimaryYAxis(px=>px.MultiLevelLabels)))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.PrimaryYAxis(px=>px.MultiLevelLabels())
</code>
</td>
</tr>

<tr>
<td><b>skeleton for an axes</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Skeleton</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(ax=>ax.Skeleton('yMd'))
</code>
</td>
</tr>
<tr>
<td><b>skeleton type for an axes</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>SkeletonType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(ax=>ax.SkeletonType("DateTime"))
</code>
</td>
</tr>
<table>

## Axes

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Alternate grid band</b></td>
<td>
<b>Property</b>:<i>AlternateGridBand</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.AlternateGridBand(alt => alt.even(e => e.Fill("red")))))
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Axis line cross value</b></td>
<td>
<b>Property</b>:<i>CrossesAt</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.CrossesAt(0)))
</code>
</td>
<td>
<b>Property</b>:<i>CrossesAt</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.CrossesAt(0)))
</code>
</td>
</tr>

<tr>
<td><b>Axis name with which the axis line has to be crossed</b></td>
<td>
<b>Property</b>:<i>CrossesInAxis</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.CrossesInAxis("")))
</code>
</td>
<td>
<b>Property</b>:<i>CrossesInAxis</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.CrossesInAxis(""))
</code>
</td>
</tr>

<tr>
<td><b>Axis elements placed with axis line</b></td>
<td>
<b>Property</b>:<i>ShowNextToAxisLine</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ShowNextToAxisLine(true)))
</code>
</td>
<td>
<b>Property</b>:<i>PlaceNextToAxisLine</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.PlaceNextToAxisLine(true))
</code>
</td>
</tr>

<tr>
<td><b>Axis line style</b></td>
<td>
<b>Property</b>:<i>AxisLine.Color</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.AxisLine(al => al.Color("red"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LineStyle(ls => ls.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Axis line dashArray</b></td>
<td>
<b>Property</b>:<i>AxisLine.DashArray</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.AxisLine(al => al.DashArray("10,5"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LineStyle(ls => ls.DashArray("10,5")))
</code>
</td>
</tr>

<tr>
<td><b>Offset for axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Offset</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.AxisLine(al => al.Offset("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LineStyle(ls => ls.PlotOffset("10")))
</code>
</td>
</tr>

<tr>
<td><b>Visible of an axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.AxisLine(al => al.Visible(false))))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LineStyle(ls => ls.Visible(false)))
</code>
</td>
</tr>

<tr>
<td><b>Width of an axis</b></td>
<td>
<b>Property</b>:<i>AxisLine.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.AxisLine(al => al.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>LineStyle.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LineStyle(ls => ls.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Column index of an axis</b></td>
<td>
<b>Property</b>:<i>ColumnIndex</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ColumnIndex("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>ColumnIndex</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.ColumnIndex("2")))
</code>
</td>
</tr>

<tr>
<td><b>Span of an axis to place horizontally or vertically</b></td>
<td>
<b>Property</b>:<i>ColumnSpan</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ColumnSpan("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Span</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Span("2")))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label of an axis</b></td>
<td>
<b>Property</b>:<i>CrossHairLabel.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.CrossHairLabel(cr => cr.Visible(true))))
</code>
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.Enable</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.CrossHairLabel(cr => cr.Enable(true)))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label color of an axis</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.CrossHairLabel(cr => cr.Fill("red")))
</code>
</td>
</tr>

<tr>
<td><b>Crosshair label text style</b></td>
<td>
Not applicable
</td>
<td>
<b>Property</b>:<i>CrossHairTooltip.TextStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.CrossHairLabel(cr => cr.TextStyle()))
</code>
</td>
</tr>

<tr>
<td><b>Desired interval count for Axes</b></td>
<td>
<b>Property</b>:<i>DesiredIntervals</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.DesiredIntervals("4")))
</code>
</td>
<td>
<b>Property</b>:<i>DesiredIntervals</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.DesiredIntervals("4"))
</code>
</td>
</tr>

<tr>
<td><b>Edges Axes</b></td>
<td>
<b>Property</b>:<i>EdgeLabelPlacement</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.EdgeLabelPlacement("none")))
</code>
</td>
<td>
<b>Property</b>:<i>EdgeLabelPlacement</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.EdgeLabelPlacement("none"))
</code>
</td>
</tr>

<tr>
<td><b>Enables trim for axis labels</b></td>
<td>
<b>Property</b>:<i>EnableTrim</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.EnableTrim(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableTrim</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.EnableTrim(true))
</code>
</td>
</tr>

<tr>
<td><b>Specifies the interval of the axis according to the zoomed data of the chart</b></td>
<td>
<b>Property</b>:<i>EnableAutoIntervalOnZooming</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.EnableAutoIntervalOnZooming(true)))
</code>
</td>
<td>
<b>Property</b>:<i>EnableAutoIntervalOnZooming</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.EnableAutoIntervalOnZooming(true))
</code>
</td>
</tr>

<tr>
<td><b>Title style for Axes</b></td>
<td>
<b>Property</b>:<i>Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Font()))
</code>
</td>
<td>
<b>Property</b>:<i>TitleStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.TitleStyle())
</code>
</td>
</tr>

<tr>
<td><b>Indexed for category axis</b></td>
<td>
<b>Property</b>:<i>IsIndexed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.IsIndexed(true)))
</code>
</td>
<td>
<b>Property</b>:<i>IsIndexed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.IsIndexed(true))
</code>
</td>
</tr>

<tr>
<td><b>Interval type for date time axis</b></td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.IntervalType("Auto")))
</code>
</td>
<td>
<b>Property</b>:<i>IntervalType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.IntervalType("Auto"))
</code>
</td>
</tr>

<tr>
<td><b>Inversed axis</b></td>
<td>
<b>Property</b>:<i>IsInversed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.IsInversed(true)))
</code>
</td>
<td>
<b>Property</b>:<i>IsInversed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.IsInversed(true))
</code>
</td>
</tr>

<tr>
<td><b>Custom label format</b></td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LabelFormat('{value}K')))
</code>
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LabelFormat('{value}K'))
</code>
</td>
</tr>

<tr>
<td><b>labelIntersectAction</b></td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LabelIntersectAction("trim")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelIntersectAction</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LabelIntersectAction("Trim"))
</code>
</td>
</tr>

<tr>
<td><b>labelPosition</b></td>
<td>
<b>Property</b>:<i>LabelPosition</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LabelPosition("inside")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LabelPosition("Inside"))
</code>
</td>
</tr>

<tr>
<td><b>labelPlacement for category axis</b></td>
<td>
<b>Property</b>:<i>LabelPlacement</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LabelPlacemen("onTicks")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelPlacement</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LabelPlacemen("onTicks"))
</code>
</td>
</tr>

<tr>
<td><b>Axis label alignment</b></td>
<td>
<b>Property</b>:<i>Alignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Alignment("center")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Rotation of axis labels</b></td>
<td>
<b>Property</b>:<i>LabelRotation</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LabelRotation("45")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelRotation</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LabelRotation("45"))
</code>
</td>
</tr>

<tr>
<td><b>Log base value for logarithmic axis</b></td>
<td>
<b>Property</b>:<i>LogBase</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LogBase("10")))
</code>
</td>
<td>
<b>Property</b>:<i>LogBase</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LogBase("10"))
</code>
</td>
</tr>

<tr>
<td><b>Major grid line visible</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorGridLines(mgl => mgl.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorGridLines(mgl => mgl.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MajorGridLines(mgl => mgl.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorGridLines(mgl => mgl.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MajorGridLines(mgl => mgl.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>DashArray of MajorGridLines</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.DashArray</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorGridLines(mgl => mgl.DashArray("10,2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorGridLines.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MajorGridLines(mgl => mgl.DashArray("10,2")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of major grid line</b></td>
<td>
<b>Property</b>:<i>MajorGridLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorGridLines(mgl => mgl.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Major Tick line</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorTickLines(mtl => mtl.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorTickLines(mtl => mtl.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MajorGridLines(mgl => mgl.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Height of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Size</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorTickLines(mtl => mtl.Size("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MajorGridLines(mgl => mgl.Height("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of MajorTickLines</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorTickLines(mtl => mtl.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MajorTickLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MajorGridLines(mgl => mgl.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of major Tick line</b></td>
<td>
<b>Property</b>:<i>MajorTickLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MajorTickLines(mtl => mtl.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>maximum labels of Axes</b></td>
<td>
<b>Property</b>:<i>MaximumLabels</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MaximumLabels("5")))
</code>
</td>
<td>
<b>Property</b>:<i>MaximumLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MaximumLabels("5"))
</code>
</td>
</tr>

<tr>
<td><b>maximum labels width of Axes to trim</b></td>
<td>
<b>Property</b>:<i>MaximumLabelWidth</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MaximumLabelWidth("40")))
</code>
</td>
<td>
<b>Property</b>:<i>MaximumLabelWidth</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MaximumLabelWidth("40"))
</code>
</td>
</tr>

<tr>
<td><b>minor grid line</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorGridLines(mi => mi.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorGridLines(mi => mi.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorGridLines(mi => mi.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Color</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorGridLines(mi => mi.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorGridLines(mi => mi.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>DashArray of minorGridLines</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.DashArray</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorGridLines(mi => mi.DashArray("10,5"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorGridLines.DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorGridLines(mi => mi.DashArray("10,5")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of minor grid line</b></td>
<td>
<b>Property</b>:<i>MinorGridLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorGridLines(mi => mi.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>minor Tick line</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorTickLines(mit => mit.Visible(true))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Width of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Width</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorTickLines(mit => mit.Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorTickLines(mi => mi.Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>Height of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Size</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorTickLines(mit => mit.Size("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorTickLines(mi => mi.Height("2")))
</code>
</td>
</tr>

<tr>
<td><b>Color of minorTickLines</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Color</i>
</br>
</br>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorTickLines(mit => mit.Color("black"))))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTickLines.Color</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorTickLines(mi => mi.Color("black")))
</code>
</td>
</tr>

<tr>
<td><b>Opacity of minor Tick line</b></td>
<td>
<b>Property</b>:<i>MinorTickLines.Opacity</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorTickLines(mit => mit.Opacity("0.5"))))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Minor ticks per interval of Axes</b></td>
<td>
<b>Property</b>:<i>MinorTicksPerInterval</i>
</br>
</br>
<code>
Html.EJ().Chart("chartContainer")
.Axes(px=>px.MinorTicksPerInterval("4"))
</code>
</td>
<td>
<b>Property</b>:<i>MinorTicksPerInterval</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MinorTicksPerInterval("4"))
</code>
</td>
</tr>

<tr>
<td><b>name of the Axes</b></td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Name("Axes")))
</code>
</td>
<td>
<b>Property</b>:<i>Name</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Name("Axes"))
</code>
</td>
</tr>

<tr>
<td><b>Orientation of Axes</b></td>
<td>
<b>Property</b>:<i>Orientation</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Orientation("Horizontal")))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Plot offset for Axes</b></td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.PlotOffset("0")))
</code>
</td>
<td>
<b>Property</b>:<i>PlotOffset</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.PlotOffset("0"))
</code>
</td>
</tr>

<tr>
<td><b>minimum for  Axes</b></td>
<td>
<b>Property</b>:<i>Range.Minimum</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Range(r => r.Minimum("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>Minimum</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Minimum("10"))
</code>
</td>
</tr>

<tr>
<td><b>maximum for Axes</b></td>
<td>
<b>Property</b>:<i>Range.Maximum</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Range(r => r.Maximum("23"))))
</code>
</td>
<td>
<b>Property</b>:<i>Maximum</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Maximum("23"))
</code>
</td>
</tr>

<tr>
<td><b>interval for  Axes</b></td>
<td>
<b>Property</b>:<i>Range.Interval</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Range(r => r.Interval("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Interval</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Interval("2"))
</code>
</td>
</tr>

<tr>
<td><b>RangePadding for  Axes</b></td>
<td>
<b>Property</b>:<i>RangePadding</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.RangePadding("none")))
</code>
</td>
<td>
<b>Property</b>:<i>RangePadding</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.RangePadding("none"))
</code>
</td>
</tr>

<tr>
<td><b>Rounding Places in Axes</b></td>
<td>
<b>Property</b>:<i>RoundingPlaces </i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.RoundingPlaces("3")))
</code>
</td>
<td>
<b>Property</b>:<i>LabelFormat</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.LabelFormat("n3"))
</code>
</td>
</tr>

<tr>
<td><b>ScrollBar settings of Axes</b></td>
<td>
<b>Property</b>:<i>ScrollbarSettings </i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ScrollbarSettings()))
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>TickPosition in Axes</b></td>
<td>
<b>Property</b>:<i>TickLinesPosition</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.TickLinesPosition("Inside")))
</code>
</td>
<td>
<b>Property</b>:<i>TickPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.TickPosition("Inside")))
</code>
</td>
</tr>

<tr>
<td><b>valueType of Axes</b></td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ValueType("DateTime")))
</code>
</td>
<td>
<b>Property</b>:<i>ValueType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.ValueType("DateTime"))
</code>
</td>
</tr>

<tr>
<td><b>visible of Axes</b></td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Visible(true)))
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Visible(true))
</code>
</td>
</tr>

<tr>
<td><b>zoomFactor of Axes</b></td>
<td>
<b>Property</b>:<i>ZoomFactor</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ZoomFactor("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomFactor</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.ZoomFactor("0.3"))
</code>
</td>
</tr>

<tr>
<td><b>zoomPosition of Axes</b></td>
<td>
<b>Property</b>:<i>ZoomPosition</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.ZoomPosition("0.3")))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomPosition</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.ZoomPosition("0.3"))
</code>
</td>
</tr>

<tr>
<td><b>labelBorder of Axes</b></td>
<td>
<b>Property</b>:<i>LabelBorder</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Axes(px=>px.LabelBorder(lb => lb.Color("red").Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Border(b => b.Color("red").Width("2")))
</code>
</td>
</tr>

<tr>
<td><b>title of Axes</b></td>
<td>
<b>Property</b>:<i>Title.Text</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.Title(t => t.Text("Chart Title"))))
</code>
</td>
<td>
<b>Property</b>:<i>Title</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.Title("Chart Title")
</code>
</td>
</tr>

<tr>
<td><b>StripLine of Axes</b></td>
<td>
<b>Property</b>:<i>StripLine</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.StripLine()))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.StripLines())
</code>
</td>
</tr>

<tr>
<td><b>Multilevel labels of Axes</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels</i>
</br>
</br>
<code>
(Html.EJ().Chart("chartContainer")
.Axes(px=>px.MultiLevelLabels)))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(px=>px.MultiLevelLabels())
</code>
</td>
</tr>

<tr>
<td><b>skeleton for an axes</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Skeleton</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(ax=>ax.Skeleton('yMd'))
</code>
</td>
</tr>
<tr>
<td><b>skeleton type for an axes</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>SkeletonType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Axes(ax=>ax.SkeletonType("DateTime"))
</code>
</td>
</tr>
<table>

## Rows

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>rows in chart</b></td>
<td>
<b>Property</b>:<i>RowDefinitions</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.RowDefinitions().Add();)
</code>
</td>
<td>
<b>Property</b>:<i>Rows</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Rows().Add();
</code></td>
</tr>

<tr>
<td><b>unit</b></td>
<td>
<b>Property</b>:<i>Unit </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.RowDefinitions(r => r.Unit("percentage")).Add();)
</code>
</td>
<td>
<b>Not Applicable</b>
</td>
</tr>

<tr>
<td><b>height of rows in chart</b></td>
<td>
<b>Property</b>:<i>RowHeight</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.RowDefinitions(r => r.owHeight("50")).Add();)
</code>
</td>
<td>
<b>Property</b>:<i>Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Rows(r => r.Height("300")).Add();
</code></td>
</tr>

<tr>
<td><b>Line customization</b></td>
<td>
<b>Property</b>:<i>lineColor, lineWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.RowDefinitions(r => r.owHeight("50").LineColor("brown").LineWidth("2")).Add();)
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Rows({r => r.Border(b => b.Width("2").Color("brown")).Height("300")).Add();});
chart.appendTo('#chart');
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
<td><b>BearFillColor</b></td>
<td>
<b>Property</b>:<i>BearFillColor</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.BearFillColor("red").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>BearFillColor</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.BearFillColor("red").Add();
})
</code></td>
</tr>

<tr>
<td><b>Border</b></td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Border(br => br.Color("red").Width("2").DashArray("10,5")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Border(br => br.Color("red").Width("2").DashArray("10,5")).Add();
})
</code></td>
</tr>

<tr>
<td><b>BoxPlotMode</b></td>
<td>
<b>Property</b>:<i>BoxPlotMode</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.BoxPlotMode("inclusive").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>BoxPlotMode</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.BoxPlotMode("inclusive").Add();
})
</code></td>
</tr>

<tr>
<td><b>Minimum radius of Bubble series</b></td>
<td>
<b>Property</b>:<i>BubbleOptions.MinRadius</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.BubbleOptions(b => b.MinRadius("2")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>MinRadius</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.BubbleOptions(b => b.MinRadius("2")).Add();
})
</code></td>
</tr>

<tr>
<td><b>Maximum radius of Bubble series</b></td>
<td>
<b>Property</b>:<i>BubbleOptions.MaxRadius</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.BubbleOptions(b => b.MaxRadius("10")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>MaxRadius</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.BubbleOptions(b => b.MaxRadius("10")).Add();
})
</code></td>
</tr>

<tr>
<td><b>bullFillColor</b></td>
<td>
<b>Property</b>:<i>BullFillColor</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.BullFillColor("red").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>BullFillColor</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.BullFillColor("red").Add();
})
</code></td>
</tr>

<tr>
<td><b>Cardinal spline tension for spline series</b></td>
<td>
<b>Property</b>:<i>CardinalSplineTension</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.CardinalSplineTension("0.5").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>CardinalSplineTension</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.CardinalSplineTension("0.5").Add();
})
</code></td>
</tr>

<tr>
<td><b>Column Width for rectangle series</b></td>
<td>
<b>Property</b>:<i>ColumnWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.ColumnWidth("0.5").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>ColumnWidth</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.ColumnWidth("0.5").Add();
})
</code></td>
</tr>

<tr>
<td><b>Column spacing for rectangle series</b></td>
<td>
<b>Property</b>:<i>ColumnSpacing</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.ColumnSpacing("0.5").Add();
})

</code>
</td>
<td>
<b>Property</b>:<i>ColumnSpacing</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.ColumnSpacing("0.5").Add();
})
</code></td>
</tr>

<tr>
<td><b>Topleft radius for rectangle series</b></td>
<td>
<b>Property</b>:<i>CornerRadius.TopLeft</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.CornerRadius(c => c.TopLeft(0)).Add();
})

</code>
</td>
<td>
<b>Property</b>:<i>CornerRadius.TopLeft</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.CornerRadius(c => c.TopLeft(0)).Add();
})
</code></td>
</tr>

<tr>
<td><b>topRight radius for rectangle series</b></td>
<td>
<b>Property</b>:<i>CornerRadius.TopRight</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.CornerRadius(c => c.TopRight(0)).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>CornerRadius.TopRight</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.CornerRadius(c => c.TopRight(0)).Add();
})
</code></td>
</tr>

<tr>
<td><b>bottomRight radius for rectangle series</b></td>
<td>
<b>Property</b>:<i>CornerRadius.BottomRight</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.CornerRadius(c => c.BottomRight(0)).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>CornerRadius.BottomRight</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.CornerRadius(c => c.BottomRight(0)).Add();
})
</code></td>
</tr>

<tr>
<td><b>bottomLeft radius for rectangle series</b></td>
<td>
<b>Property</b>:<i>CornerRadius.BottomLeft</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.CornerRadius(c => c.BottomLeft(0)).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>CornerRadius.BottomLeft</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.CornerRadius(c => c.BottomLeft(0)).Add();
})
</code></td>
</tr>

<tr>
<td><b>DashArray property</b></td>
<td>
<b>Property</b>:<i>DashArray</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.DashArray("10,5").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>DashArray</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.DashArray("10,5").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>DataSource for series</b></td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.DataSource().Add();
})

</code>
</td>
<td>
<b>Property</b>:<i>DataSource</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.DataSource().Add();
})
</code></td>
</tr>

<tr>
<td><b>Draw type for Polar series</b></td>
<td>
<b>Property</b>:<i>DrawType</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.DrawType("Line").Add();
})

</code>
</td>
<td>
<b>Property</b>:<i>DrawType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.DrawType("Line").Add();
})
</code></td>
</tr>

<tr>
<td><b>EmptyPointSettings for series</b></td>
<td>
<b>Property</b>:<i>EmptyPointSettings.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.EmptyPointSettings(e => e.Visible(false)).Add();
})

</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Empty Point Display mode</b></td>
<td>
<b>Property</b>:<i>EmptyPointSettings.DisplayMode</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.EmptyPointSettings(e => e.DisplayMode("Average")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>EmptyPointSettings.DisplayMode</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.EmptyPointSettings(e => e.DisplayMode("Average")).Add();
})
</code></td>
</tr>

<tr>
<td><b>Empty Point color</b></td>
<td>
<b>Property</b>:<i>EmptyPointSettings.Color</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Color("red").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>EmptyPointSettings.Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Fill("red").Add();
})
</code></td>
</tr>

<tr>
<td><b>Empty Point Border</b></td>
<td>
<b>Property</b>:<i>EmptyPointSettings.Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.EmptyPointSettings(e => e.Border(b => b.Color("red").Width("2"))).Add();
})

</code>
</td>
<td>
<b>Property</b>:<i>EmptyPointSettings.Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.EmptyPointSettings(e => e.Border(b => b.Color("red").Width("2"))).Add();
})
</code></td>
</tr>

<tr>
<td><b>Enable animation for series</b></td>
<td>
<b>Property</b>:<i>EnableAnimation</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.EnableAnimation(true).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Animation.Enable</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Animation(a => a.Enable(false)).Add();
})

</code></td>
</tr>

<tr>
<td><b>Animation duration for series</b></td>
<td>
<b>Property</b>:<i>AnimationDuration</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.AnimationDuration("1000").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Animation.Duration</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Animation(a => a.Duration("1000")).Add();
})
</code></td>
</tr>

<tr>
<td><b>Animation delay for series</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>Animation.Delay</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Animation(a => a.Delay("100")).Add();
})
</code></td>
</tr>

<tr>
<td><b>Drag settings for series</b></td>
<td>
<b>Property</b>:<i>DragSettings</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.DragSettings(d => d.Mode("X")).Add();
})

</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Errorbar settings for series</b></td>
<td>
<b>Property</b>:<i>ErrorBarSettings</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.ErrorBarSettings().Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>ErrorBarSettings</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.ErrorBarSettings().Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Closed series</b></td>
<td>
<b>Property</b>:<i>IsClosed</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.IsClosed(true).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>IsClosed</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.IsClosed(true).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Stacking Property for series</b></td>
<td>
<b>Property</b>:<i>IsStacking</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.IsStacking(true).Add();
})
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Line cap for series</b></td>
<td>
<b>Property</b>:<i>LineCap</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.LineCap("butt").Add();
})

</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Line join for series</b></td>
<td>
<b>Property</b>:<i>LineJoin</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.LineJoin("round").Add();
})
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Opacity for series</b></td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Opacity("0.7").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Opacity("0.7").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Outlier settings of series</b></td>
<td>
<b>Property</b>:<i>OutLierSettings</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.OutLierSettings(out => out.Shape("rectangle").Size(s => s.Height("30").Width("20"))).Add();
})

</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Palette</b></td>
<td>
<b>Property</b>:<i>Palette</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Palette("ColorFieldName").Add();
})

</code>
</td>
<td>
<b>Property</b>:<i>PointColorMapping</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.PointColorMapping("color").Add();
})

</code>

</td>
</tr>

<tr>
<td><b>Positive fill for waterfall series</b></td>
<td>
<b>Property</b>:<i>PositiveFill</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.PositiveFill("red").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>PositiveFill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.PositiveFill("red").Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Show average value in box and whisker series</b></td>
<td>
<b>Property</b>:<i>ShowMedian</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.ShowMedian(true).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>ShowMedian</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.ShowMedian(true).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>To group the series of stacking collection.</b></td>
<td>
<b>Property</b>:<i>StackingGroup</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.StackingGroup("group").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>StackingGroup</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.StackingGroup("group").Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Specifies the type of the series to render in chart.</b></td>
<td>
<b>Property</b>:<i>Type</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Type(SeriesType.Line).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Type</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Type(Syncfusion.EJ2.Charts.ChartSeriesType.Line).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Defines the visibility of the series.</b></td>
<td>
<b>Property</b>:<i>Visibility</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Visibility(true).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Visible(true).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Enables or disables the visibility of legend item.</b></td>
<td>
<b>Property</b>:<i>VisibleOnLegend </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.VisibleOnLegend(true).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>ToggleVisibility</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.LegendSettings(l => l.ToggleVisibility(true))
})
</code>

</td>
</tr>

<tr>
<td><b>Specifies the different types of spline curve.</b></td>
<td>
<b>Property</b>:<i>SplineType</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.SplineType('Natural').Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>SplineType</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.SplineType('Natural').Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Specifies the name of the x-axis that has to be associated with this series. Add an axis instance with this name to axes collection.</b></td>
<td>
<b>Property</b>:<i>XAxisName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.XAxisName('secondaryXAxis').Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>XAxisName</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.XAxisName('secondaryXAxis').Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains x value for the series.</b></td>
<td>
<b>Property</b>:<i>XName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.XName("x").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>XName</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.XName("x").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Specifies the name of the y-axis that has to be associated with this series. Add an axis instance with this name to axes collection.</b></td>
<td>
<b>Property</b>:<i>YAxisName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.YAxisName("secondaryYAxis").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>YAxisName</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.YAxisName("secondaryYAxis").Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains y value for the series.</b></td>
<td>
<b>Property</b>:<i>YName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.YName("Y").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>YName</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.YName("Y").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains high value for the series.</b></td>
<td>
<b>Property</b>:<i>High</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.High("y").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>High</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.High("y").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains low value for the series.</b></td>
<td>
<b>Property</b>:<i>Low</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Low("y").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Low</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Low("y").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains close value for the series.</b></td>
<td>
<b>Property</b>:<i>Close</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Close("y").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Close</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Close("y").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Name of the property in the datasource that contains open value for the series.</b></td>
<td>
<b>Property</b>:<i>Open</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Open("y").Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Open</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Open("y").Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Option to add trendlines to chart.</b></td>
<td>
<b>Property</b>:<i>TrendLines</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines().Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines().Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Options for customizing the appearance of the series or data point while highlighting.</b></td>
<td>
<b>Property</b>:<i>HighlightSettings</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.HighlightSettings().Add();
})
</code>
</td>
<td>
Not applicable.
</td>
</tr>

<tr>
<td><b>Options for customizing the appearance of the series/data point on selection.</b></td>
<td>
<b>Property</b>:<i>SelectionSettings</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.SelectionSettings().Add();
})
</code>
</td>
<td>
Not applicable.
</td>
</tr>
</table>

## marker

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>visibility of marker</b></td>
<td>
<b>Property</b>:<i>Marker.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Visible(true)).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.Visible(true)).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Fill for marker</b></td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Fill("red")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.Fill("red")).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Opacity for marker</b></td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Opacity("0.5")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Opacity</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.Opacity("0.5")).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Shape of marker</b></td>
<td>
<b>Property</b>:<i>Shape</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Shape("Cirlce")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Shape</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.Shape("Cirlce")).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>ImageUrl of marker</b></td>
<td>
<b>Property</b>:<i>ImageUrl</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.ImageUrl("")).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>ImageUrl</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.ImageUrl("")).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Border of marker</b></td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Border(b => b.Color("red").Width("2"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.IBorder(b => b.Color("red").Width("2"))).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Height of marker</b></td>
<td>
<b>Property</b>:<i>Size.Height</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Size(s => s.Height("30"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Height</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.Height("30")).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Width of marker</b></td>
<td>
<b>Property</b>:<i>Size.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Size(s => s.Width("30"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.Width("30")).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>DataLabelSettings of marker</b></td>
<td>
<b>Property</b>:<i>Marker.DataLabel</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.Size(s => s.DataLabel())).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>Marker.DataLabel</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel()).Add();
})
</code>

</td>
</tr>

<tr>
<td><b>Visibility of dataLabel</b></td>
<td>
<b>Property</b>:<i>DataLabel.Visible</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Visible(true))).Add();
}))
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Visible</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Visible(true)))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Text mapping name of dataLabel</b></td>
<td>
<b>Property</b>:<i>DataLabel.TextMappingName</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.TextMappingName())).Add();
}))
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Name</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Name()))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Fill color of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.Fill</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Fill("red"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Fill("red"))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Opacity of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.Opacity</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Opacity("0.5"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Opacity</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Opacity("0.5"))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Text position of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.TextPosition</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.TextPosition("middle"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Position</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.TextPosition("middle"))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Alignment of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.VerticalAlignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.VerticalAlignment("near"))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Alignment</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Alignment("near"))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Border of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Border(b => b.Color("blue").Width("2")))).Add();
})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Border(b => b.Color("blue").Width("2")))).Add();
})
</code>
</td>
</tr>

<tr>
<td><b>Offset for data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.Offset</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Offset(off => off.X("5").Y("6")))).Add();
})
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Margin of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.Margin</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Margin(m => m.Top("10").Bottom("10").Left("10").Right("10"))
.Add();})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Margin</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Margin(m => m.Top("10").Bottom("10").Left("10").Right("10"))
.Add();})
</code>
</td>
</tr>

<tr>
<td><b>Font of data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.Font</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Font(f => f.FontFamily('SegoeUI').FontStyle('italic').FOntWeight("600").Opacity("0.5")
.Add();})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Font</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Font(f => f.FontFamily('SegoeUI').FontStyle('italic').FOntWeight("600").Opacity("0.5")
.Add();})
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
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Template('<div>Chart</div>').Add();})
</code>
</td>
<td>
<b>Property</b>:<i>DataLabel.Template</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Template('<div>Chart</div>').Add();})
</code>
</td>
</tr>

<tr>
<td><b>Rounded corner radius X</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>dataLabel.Rx</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Rx("5").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Rounded corner radius Y</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>dataLabel.Ry</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.Ry("10").Add();})
</code>
</td>
</tr>

<tr>
<td><b>Maximum Label width for data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.MaximumLabelWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.MaximumLabelWidth("20").Add();})
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>Enable wrapping of text for data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.EnableWrap</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.EnableWrap(true)).Add();})
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>To show contrast color for data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.ShowContrastColor</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.ShowContrastColor(true)).Add();})
</code>
</td>
<td>
Not Applicable
</td>
</tr>

<tr>
<td><b>To show edge label for data label</b></td>
<td>
<b>Property</b>:<i>DataLabel.ShowEdgeLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.Marker(mar => mar.DataLabel(d => d.ShowEdgeLabels(true)).Add();})
</code>
</td>
<td>
Not Applicable
</td>
</tr>
</table>

## TrendLines

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Trendlines settings</b></td>
<td>
<b>Property</b>:<i>Series.TrendLines</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines().Add();})
</code>
</td>
<td>
<b>Property</b>:<i>Series.TrendLines</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines().Add();})
</code></td>
</tr>

<tr>
<td><b>Visibility of trendline</b></td>
<td>
<b>Property</b>:<i>TrendLines.Visibility</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Visibility('visible')).Add();})
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Type of trendLine</b></td>
<td>
<b>Property</b>:<i>TrendLines.Type</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Type(TrendlineType.Linear)).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Type</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Type(Syncfusion.EJ2.Charts.TrendlineTypes.Linear)).Add();})
</code></td>
</tr>

<tr>
<td><b>Name of trendLine</b></td>
<td>
<b>Property</b>:<i>TrendLines.Name</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Name("TrendLines")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Name</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Name("TrendLines")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Period of trendLine</b></td>
<td>
<b>Property</b>:<i>TrendLines.Period</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Period("45")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Period</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Period("45")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Polynomial order for Polynomial type trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.PolynomialOrder</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.PolynomialOrder("3")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.PolynomialOrder</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.PolynomialOrder("3")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Backward forecost for  trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.Backwardforecast</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Backwardforecast("3")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Backwardforecast</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Backwardforecast("3")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Forward forecost for  trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.ForwardForecast</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.ForwardForecast("3")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.ForwardForecast</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.ForwardForecast("3")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Fill for trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.Fill</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Fill("red")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Fill</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Fill("red")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Width for trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Width("2")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Width</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Width("2")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Intercept value for trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.Intercept</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Intercept("2")).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.Intercept</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Intercept("2")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Legend shape for trendLines</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>TrendLines.LegendShape</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.LegendShape("Rectangle")).Add();}))
</code></td>
</tr>

<tr>
<td><b>Animation settings for trendLines</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>TrendLines.Animation</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Animation(a => a.Enable(true))).Add();}))
</code></td>
</tr>

<tr>
<td><b>Marker settings for trendLines</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>TrendLines.Marker</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.Marker(m => m.Visible(true))).Add();}))
</code></td>
</tr>

<tr>
<td><b>Tooltip for trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.Tooltip</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.Tooltip()).Add();}))
</code>
</td>
<td>
<b>Property</b>:<i>TrendLines.EnableTooltip</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
.Series(sr => {
sr.TrendLines(tr => tr.EnableTooltip(true)).Add();}))
</code></td>
</tr>

<tr>
<td><b>DashArray for trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.DashArray</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.DashArray("10,5")).Add();}))
</code>
</td>
<td>
Not Applicable.
</td>
</tr>

<tr>
<td><b>Visible on legend for trendLines</b></td>
<td>
<b>Property</b>:<i>TrendLines.VisibleOnLegend</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Series(sr => {
sr.TrendLines(tr => tr.VisibleOnLegend(true)).Add();}))
</code>
</td>
<td>
Not Applicable.
</td>
</tr>
</table>

## StripLines

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Default behaviour for striplines</b></td>
<td>
<b>Property</b>:<i>PrimaryXAxis.StripLines</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.Visible(true))))
</td>
<td>
<b>Property</b>:<i>PrimaryXAxis.StripLines</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.Visible(true))))
</code></td>
</tr>

<tr>
<td><b>border for stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.BorderColor</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.BorderColor("pink"))))
</code>
</td>
<td>
<b>Property</b>:<i>stripLines.Border</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.Border(b => b.Color("pink").WIdth("2"))))
</code></td>
</tr>

<tr>
<td><b>Background color for stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.Color</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.Color("pink"))))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.Corder</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.Color("pink")))
</code></td>
</tr>

<tr>
<td><b>Start value for stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.Start</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.Start("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.Start</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.Start("10"))))
</code></td>
</tr>

<tr>
<td><b>End value for stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.End</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.End("20"))))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.End</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.End("10"))))
</code></td>
</tr>

<tr>
<td><b>StartfromAxis for stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.StartFromAxis</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.StartFromAxis(true))))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.StartFromAxis</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.StartFromAxis(true))))
</code></td>
</tr>

<tr>
<td><b>Text in stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.Text</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.Text("text"))))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.Text</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.Text("text"))))
</code></td>
</tr>

<tr>
<td><b>Text alignment in stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.TextAlignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.TextAlignment("far"))))
</code>
</td>
<td>
<b>Property</b>:<i>stripLines.HorizontalAlignment</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.HorizontalAlignment("middle"))))
</code></td>
</tr>

<tr>
<td><b>Vertical Text alignment in stripline</b></td>
<td>
Not Applicable
</td>
<td>
<b>Property</b>:<i>StripLines.VerticalAlignment</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.VerticalAlignment("far"))))
</code></td>
</tr>

<tr>
<td><b>Size of stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.Width</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.Width("10"))))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.Size</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.Size("10"))))
</code></td>
</tr>

<tr>
<td><b>ZIndex of stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.ZIndex</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.ZIndex("Behind"))))
</code>
</td>
<td>
<b>Property</b>:<i>stripLines.size</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.ZIndex("Behind"))))
</code></td>
</tr>

<tr>
<td><b>Font style  of stripline</b></td>
<td>
<b>Property</b>:<i>StripLines.FontStyle</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.StripLines(st => st.FontStyle())))
</code>
</td>
<td>
<b>Property</b>:<i>StripLines.TextStyle</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.StripLines(st => st.FontStyle())))
</code></td>
</tr>
</table>

## Multilevel Labels

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Default behaviour for multilevelLabels</b></td>
<td>
<b>Property</b>:<i>PrimaryXAxis.MultilevelLabels</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels()))
</code>
</td>
<td>
<b>Property</b>:<i>PrimaryXAxis.MultilevelLabels</i>
</br>
</br>
<code>
@Html.EJS().Chart("container")
PrimaryXAxis(px => px.MultilevelLabels()))
</code></td>
</tr>

<tr>
<td><b>Text alignment for multilevelLabels</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels.TextAlignment</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.TextAlignment("Near"))))
</code>
</td>
<td>
<b>Property</b>:<i>MultilevelLabels.Alignment</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Alignment("Near"))))
</code>
</td>
</tr>

<tr>
<td><b>Text overflow for multilevelLabels</b></td>
<td>
<b>Property</b>:<i>multiLevelLabels.TextOverFlow</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.TextOverFlow("Trim"))))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels.OverFlow</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.OverFlow("Trim"))))
</code>
</td>
</tr>

<tr>
<td><b>Border for multilevelLabels</b></td>
<td>
<b>Property</b>:<i>multiLevelLabels.Border</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Border(b => b.Width("2").Color("red")))))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Border</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Border(b => b.Width("2").Color("red")))))
</code>
</td>
</tr>

<tr>
<td><b>Start value for label</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Start</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Start("45"))))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Categories.Start</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Categories(c => c.Start("45"))))
</code>
</td>
</tr>

<tr>
<td><b>End value for label</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels.End</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.End("50"))))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Categories.End</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Categories(c => c.End("50"))))
</code>
</td>
</tr>

<tr>
<td><b>Text for label</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Text</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Text("start"))))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Categories.Text</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Categories(c => c.Text("start"))))
</code>
</td>
</tr>

<tr>
<td><b>maximum text width for label</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels.MaximumTextWidth</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.MaximumTextWidth("20"))))
</code>
</td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Categories.MaximumTextWidth</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Categories(c => c.MaximumTextWidth("20"))))
</code>
</td>
</tr>

<tr>
<td><b>level of labels</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabels.Level</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.PrimaryXAxis(px => px.MultilevelLabels(m => m.Level("2"))))
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
<b>Property</b>:<i>Animate</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Animate())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Redraw for chart</b></td>
<td>
<b>Property</b>:<i>Redraw</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Redraw())
</code>
</td>
<td>
<b>Property</b>:<i>Refresh</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.Refresh()
</code>
</td>
</tr>

<tr>
<td><b>Export</b></td>
<td>
<b>Property</b>:<i>Export()</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Export())
</code>
</td>
<td>
<b>Property</b>:<i>Export()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.Export()
</code>
</td>
</tr>

<tr>
<td><b>Print</b></td>
<td>
<b>Property</b>:<i>Print()</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Print())
</code>
</td>
<td>
<b>Property</b>:<i>Print()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
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
<b>Property</b>:<i>AddSeries()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
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
<b>Property</b>:<i>RemoveSeries()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
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
.AnimationComplete())
</code>
</td>
<td>
<b>Property</b>:<i>AnimationComplete()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.AnimationComplete()
</code>
</td>
</tr>

<tr>
<td><b>Fires on axis label click</b></td>
<td>
<b>Property</b>:<i>AxisLabelClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AxisLabelClick())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before axis label render</b></td>
<td>
<b>Property</b>:<i>AxisLabelRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AxisLabelRendering())
</code>
</td>
<td>
<b>Property</b>:<i>AxisLabelRender()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.AxisLabelRender()
</code>
</td>
</tr>

<tr>
<td><b>Fires on axis label mouseMove</b></td>
<td>
<b>Property</b>:<i>AxisLabelMouseMove</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AxisLabelMouseMove())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires on axis label initialize</b></td>
<td>
<b>Property</b>:<i>AxisLabelInitialize</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AxisLabelInitialize())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before axis range calculation</b></td>
<td>
<b>Property</b>:<i>AxesRangeCalculate</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AxesRangeCalculate());
</code>
</td>
<td>
<b>Property</b>:<i>AxisRangeCalculated()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.AxisRangeCalculated()
</code>
</td>
</tr>

<tr>
<td><b>Fires on axis title rendering</b></td>
<td>
<b>Property</b>:<i>AxisTitleRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.AxisTitleRendering())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires on after chart resize</b></td>
<td>
<b>Property</b>:<i>AfterResize</i>
</br>
</br>
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
@Html.EJ().Chart("container")
.Resized()
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
@Html.EJ().Chart("container")
.ChartMouseClick()
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
@Html.EJ().Chart("container")
.ChartMouseMove()
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
@(Html.EJ().Chart("chartContainer")
.ChartMouseLeave())
</code>
</td>
<td>
<b>Property</b>:<i>ChartMouseLeave</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.ChartMouseLeave()
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
@Html.EJ().Chart("container")
.ChartmouseUp()
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
@Html.EJ().Chart("container")
.ChartmouseDown()
</code>
</td>
</tr>

<tr>
<td><b>Fires during the calculation of chart area bounds.
You can use this event to customize the bounds of chart area</b></td>
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
<td><b>Fires when the dragging is started</b></td>
<td>
<b>Property</b>:<i>DragStart</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.DragStart())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires while dragging</b></td>
<td>
<b>Property</b>:<i>Dragging</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Dragging())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires when the dragging is completed</b></td>
<td>
<b>Property</b>:<i>DragEnd</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.DragEnd())
</code>
</td>
<td>
<b>Property</b>:<i>DragComplete</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.DragComplete()
</code>
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
@Html.EJ().Chart("container")
.Loaded()
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
@Html.EJ().Chart("container")
.TextRender()
</code>
</td>
</tr>

<tr>
<td><b>Fires, when error bar is rendering.</b></td>
<td>
<b>Property</b>:<i>ErrorBarRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ErrorBarRendering())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires during the calculation of legend bounds.</b></td>
<td>
<b>Property</b>:<i>LegendBoundsCalculate</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.LegendBoundsCalculate())
</code>
</td>
<td>
Not applicable
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
.LegendItemRendering()
</code>
</td>
<td>
<b>Property</b>:<i>LegendRender</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.LegendRender()
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
.Load()
</code>
</td>
<td>
<b>Property</b>:<i>Load</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.Load()
</code>
</td>
</tr>

<tr>
<td><b>Fires, when multi level labels are rendering.</b></td>
<td>
<b>Property</b>:<i>MultiLevelLabelRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.MultiLevelLabelRendering()
</code>
</td>
<td>
<b>Property</b>:<i>AxisMultiLabelRender</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.AxisMultiLabelRender()
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
.PointRegionClick()
</code>
</td>
<td>
<b>Property</b>:<i>PointClick </i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.PointClick()
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
@Html.EJ().Chart("container")
.PointMove()
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
@Html.EJ().Chart("container")
.PointRender()
</code>
</td>
</tr>

<tr>
<td><b>Fires after selected the data in chart.</b></td>
<td>
<b>Property</b>:<i>RangeSelected</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.RangeSelected())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires after selecting a series.</b></td>
<td>
<b>Property</b>:<i>SeriesRegionClick</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SeriesRegionClick())
</code>
</td>
<td>
Not applicable
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
@Html.EJ().Chart("container")
.SeriesRender()
</code>
</td>
</tr>

<tr>
<td><b>Fires before rendering the marker symbols.</b></td>
<td>
<b>Property</b>:<i>SymbolRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SymbolRendering())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before rendering the trendline</b></td>
<td>
<b>Property</b>:<i>TrendlineRendering</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.TrendlineRendering())
</code>
</td>
<td>
Not applicable
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
@Html.EJ().Chart("container")
.TooltipRender()
</code>
</td>
</tr>

<tr>
<td><b>Fires before rendering crosshair tooltip in axis</b></td>
<td>
<b>Property</b>:<i>TrackAxisToolTip</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.TrackAxisToolTip())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Fires before rendering trackball tooltip.</b></td>
<td>
<b>Property</b>:<i>TrackToolTip</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.TrackToolTip())
</code>
</td>
<td>
Not applicable
</td>
</tr>

<tr>
<td><b>Event triggered when scroll starts.</b></td>
<td>
<b>Property</b>:<i>ScrollStart</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ScrollStart())
</code>
</td>
<td>
<b>Property</b>:<i>ScrollStart </i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.ScrollStart()
</code>
</td>
</tr>

<tr>
<td><b>Event triggered when scroll ends.</b></td>
<td>
<b>Property</b>:<i>ScrollEnd</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ScrollEnd())
</code>
</td>
<td>
<b>Property</b>:<i>ScrollEnd</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.ScrollEnd()
</code>
</td>
</tr>

<tr>
<td><b>Event triggered when scroll changes.</b></td>
<td>
<b>Property</b>:<i>ScrollChange</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ScrollChange())
</code>
</td>
<td>
<b>Property</b>:<i>ScrollChange</i>
</br>
</br>
@Html.EJ().Chart("container")
.ScrollChange()
</code>
</td>
</tr>

<tr>
<td><b>Fires while performing rectangle zooming in chart.</b></td>
<td>
<b>Property</b>:<i>ZoomComplete</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ZoomComplete())
</code>
</td>
<td>
<b>Property</b>:<i>ZoomComplete</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.ZoomComplete()
</code>
</td>
</tr>
</table>

## Chart properties

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>selected data index</b></td>
<td>
<b>Property</b>:<i>SelectedDataPointIndexes:</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SelectedDataPointIndexes(s => s.SeriesIndex("0").PointIndex("1")))
</code>
</td>
<td>
<b>Property</b>:<i>SelectedDataIndexes</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.SelectedDataPointIndexes(s => s.SeriesIndex("0").PointIndex("1"))
</code></td>
</tr>

<tr>
<td><b>sideBySideSeriesPlacement for column based series</b></td>
<td>
<b>Property</b>:<i>SideBySideSeriesPlacement:</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.SideBySideSeriesPlacement(true)

</code>
</td>
<td>
<b>Property</b>:<i>SideBySidePlacement</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.SideBySidePlacement(true)
</code></td>
</tr>

<tr>
<td><b>ZoomSettings</b></td>
<td>
<b>Property</b>:<i>Zooming:</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Zooming(z => z.Enable(true).EnablePinch(true).EnableScrollBar(true)))
</code>
</td>
<td>
<b>Property</b>:<i>ZoomSettings</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.ZoomSettings(z => z.Enable(true).EnablePinch(true).EnableScrollBar(true)))
</code></td>
</tr>

<tr>
<td><b>Background color of the chart</b></td>
<td>
<b>Property</b>:<i>Background </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.Background('transparent')
</code>
</td>
<td>
<b>Property</b>:<i>Background</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.Background('transparent')
</code></td>
</tr>

<tr>
<td><b>URL of the image to be used as chart background.</b></td>
<td>
<b>Property</b>:<i>BackGroundImageUrl </i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.BackGroundImageUrl("")
</code>
</td>
<td>
<b>Not Applicable</b>
</td>
</tr>

<tr>
<td><b>Customizing border of the chart</b></td>
<td>
<b>Property</b>:<i>Border </i>
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
@Html.EJ().Chart("container")
.Border(b => b.Color("red").Width("2")))
</code></td>
</tr>

<tr>
<td>This provides options for customizing export settings</td>
<td>
<b>Property</b>:<i>ExportSettings</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ExportSettings(e => e.FileName("chart").Angle("45")))
</code>
</td>
<td>
<b>Property</b>:<i>Export()</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.Export(e => e.FileName("chart").Angle("45")))
</code></td>
</tr>

<tr>
<td>ChartArea customization</td>
<td>
<b>Property</b>:<i>ChartArea</i>
</br>
</br>
<code>
@(Html.EJ().Chart("chartContainer")
.ChartArea(c => c.Background("transparent").Border(b => b.Opacity("0.3").Color("red").Width("2"))))
</code>
</td>
<td>
<b>Property</b>:<i>ChartArea</i>
</br>
</br>
<code>
@Html.EJ().Chart("container")
.ChartArea(c => c.Background("transparent").Border(b => b.Opacity("0.3").Color("red").Width("2"))))
</code>
</td>
</tr>
</table>