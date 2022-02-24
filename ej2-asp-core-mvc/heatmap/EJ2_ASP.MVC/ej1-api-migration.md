---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Heatmap Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Heatmap component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of heat map component from Essential JS 1 to Essential JS 2.

## Members

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Specifies the width of the heat map</b></td>
<td>
<b>Property</b>:<i>width</i>
<br/>
<br/>

@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.Width = "830";

</td>
<td>
<b>Property</b>:<i>width</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").Width("300px").Render()
</td>
</tr>

<tr>
<td><b>Specifies the height of the heat map</b></td>
<td>
<b>Property</b>:<i>height</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.Height = "830";
</td>
<td>
<b>Property</b>:<i>height</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").Height("300px").Render()
</td>
</tr>

<tr>
<td><b>Enables or disables tooltip of heat map</b></td>
<td>
<b>Property</b>:<i>showtooltip</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.ShowTooltip = true;
</td>
<td>
<b>Property</b>:<i>showTooltip</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").ShowTooltip(true).Render()
</td>
</tr>

<tr>
<td><b>Defines the tooltip that should be shown when the mouse hovers over cells.</b></td>
<td>
<b>Property</b>:<i>toolTipSettings.templateId</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.ToolTipSettings = new ToolTipSettings() { templateId = "mouseovertoolTipId" };
</td>
<td>
<b>Property</b>:<i>tooltipRender</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").TooltipRender("tooltipRender").Render()
<br><br>
var tooltipRender = function (args) {};
</td>
</tr>

<tr>
<td><b>Specifies the source data of the heat map.</b></td>
<td>
<b>Property</b>:<i>itemsSource</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.ItemsSource = [];
</td>
<td>
<b>Property</b>:<i>dataSource</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").DataSource(ViewBag.dataSource).Render()
</td>
</tr>

<tr>
<td><b>Specifies whether the cell content can be visible or not.</b></td>
<td>
<b>Property</b>:<i>heatmapCell.showContent</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.HeatMapCell = new HeatMapCell() { showContent = "Hidden" }
</td>
<td>
<b>Property</b>:<i>cellSettings.showLabel</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").CellSettings(cs => cs.ShowLabel(false)).Render()
</td>
</tr>

<tr>
<td><b>Specifies the color of the heat map column data.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.color</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Color = "#8ec8f8" });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>paletteSettings.palette.color</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").PaletteSettings(ps => ps.Palette(palette => {
        palette.Value(0).Color("rgb(238,238,238)").Add();
})).Render()
</td>
</tr>

<tr>
<td><b>Specifies the color values of the heat map column data.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.value</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Value = 0 });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>paletteSettings.palette.value</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").PaletteSettings(ps => ps.Palette(palette => {
        palette.Value(20).Add();
})).Render()
</td>
</tr>

<tr>
<td><b>Specifies the label text of the heat map color.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.label.text</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Label = new HeatMapLabel() { Text = "Moderate" } });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>paletteSettings.palette.label</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").PaletteSettings(ps => ps.Palette(palette => {
        palette.Label("no contributions").Add();
})).Render()
</td>
</tr>

<tr>
<td><b>Specifies the style of the heat map color label.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.label.bold</i>
<b>Property</b>:<i>colorMappingCollection.label.italic</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Label = new HeatMapLabel() { Bold = true } });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>legendSettings.textStyle.fontStyle</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").LegendSettings(ls => ls.TextStyle(ViewBag.textStyle)).Render()
<br><br>
ViewBag.textStyle new { fontStyle:'bold' };
</td>
</tr>

<tr>
<td><b>Specifies the font size of the heat map label.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.label.fontSize</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Label = new HeatMapLabel() { FontSize = 18 } });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>legendSettings.textStyle.size</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").LegendSettings(ls => ls.TextStyle(ViewBag.textStyle)).Render()
<br><br>
ViewBag.textStyle = new { size: 18 };
</td>
</tr>

<tr>
<td><b>Specifies the font family of the heat map label.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.label.fontFamily</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Label = new HeatMapLabel() { FontFamily = "Arial" } });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>legendSettings.textStyle.fontFamily</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").LegendSettings(ls => ls.TextStyle(ViewBag.textStyle)).Render()
<br><br>
ViewBag.textStyle = new { fontFamily: 'Arial' }
</td>
</tr>

<tr>
<td><b>Specifies the font color of the heat map label.</b></td>
<td>
<b>Property</b>:<i>colorMappingCollection.label.fontColor</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
colorCollection.Add(new HeatMapColorMapping() { Label = new HeatMapLabel() { FontColor = "red" } });
Heatmap.ColorMappingCollection = colorCollection;
</td>
<td>
<b>Property</b>:<i>legendSettings.textStyle.fontFamily</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").LegendSettings(ls => ls.TextStyle(ViewBag.textStyle)).Render()
<br><br>
ViewBag.textStyle = new { color: 'red' }
</td>
</tr>

<tr>
<td><b>Specifies the mapping name of the column.</b></td>
<td>
<b>Property</b>:<i>itemsMapping.column.propertyName</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
TableMapping TableMapping = new TableMapping();
TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "Y2010" });
Heatmap.ItemsMapping = TableMapping;
</td>
<td>
<b>Property</b>:<i>dataSource.yDataMapping</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").DataSource(ViewBag.dataSource).Render()
<br><br>
ViewBag.dataSource = new {
            data: heatmapData,
            yDataMapping: 'columnid'
        };
</td>
</tr>

<tr>
<td><b>Specifies the mapping name of the row.</b></td>
<td>
<b>Property</b>:<i>itemsMapping.row.propertyName</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
TableMapping TableMapping = new TableMapping();
TableMapping.RowMapping.Add(new HeaderMapping() { PropertyName = "Y2010" });
Heatmap.ItemsMapping = TableMapping;
</td>
<td>
<b>Property</b>:<i>dataSource.xDataMapping</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").DataSource(ViewBag.dataSource).Render()
<br><br>
ViewBag.dataSource = new {
            data: heatmapData,
            xDataMapping: 'rowid'
        };
</td>
</tr>

<tr>
<td><b>Specifies the mapping name of the row.</b></td>
<td>
<b>Property</b>:<i>itemsMapping.value.propertyName</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
TableMapping TableMapping = new TableMapping();
TableMapping.ValueMapping.Add(new HeaderMapping() { PropertyName = "Y2010" });
Heatmap.ItemsMapping = TableMapping;
</td>
<td>
<b>Property</b>:<i>dataSource.valueMapping</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").DataSource(ViewBag.dataSource).Render()
<br><br>
ViewBag.dataSource = new {
            data: heatmapData,
            valueMapping: 'value'
        };
</td>
</tr>
</table>

## Events

<table>
<tr>
<td><b>Behaviour</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Triggered when the cell get clicked.</b></td>
<td>
<b>Property</b>:<i>cellSelected</i>
<br/>
<br/>
@Html.EJ().HeatMap("heatmap", ViewData["HeatMapModel"] as Syncfusion.JavaScript.DataVisualization.Models.HeatMapProperties)
<br><br>
HeatMapProperties Heatmap = new HeatMapProperties();
Heatmap.CellSelected = function(args) {};
</td>
<td>
<b>Property</b>:<i>cellClick</i>
<br/>
<br/>
@Html.EJS().HeatMap("container").CellClick("cellClick").Render()
<br><br>
var cellClick = function (args) {};
</td>
</tr>
</table>
