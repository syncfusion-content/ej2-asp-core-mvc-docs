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
|Type| **Property:** *type*<br/><br/> `<ej-spark-line id="sparkline" type="@SparklineType.Line"></ej-spark-line>`| **Property:** *type*<br/><br/> `<ejs-sparkline id="sparkline" type="@SparklineType.Line"></ejs-sparkline>` |

## Databinding

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Datasource| **Property:** *dataSource*<br/><br/> `<ej-spark-line id="sparkline" datasource="data"></ej-spark-line>` |**Property:** *dataSource*<br/><br/> `<ejs-sparkline id="sparkline" dataSource="data"></ejs-sparkline>`|
|Binding X values with datasource| **Property:** *xName*<br/><br/> `<ej-spark-line id="sparkline" xName="xValue"></ej-spark-line>` |**Property:** *xName*<br/><br/> `<ejs-sparkline id="sparkline" xName="xValue"></ejs-sparkline>`|
|Binding Y values with datasource| **Property:** *yName*<br/><br/> `<ej-spark-line id="sparkline" yName="yValue"></ej-spark-line>` |**Property:** *yName*<br/><br/> `<ejs-sparkline id="sparkline" yName="yValue"></ejs-sparkline>`|

## Markers

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable markers| **Property:** *markerSettings.visible*<br/><br/> `<ej-spark-line id="sparkline">            <e-marker-settings visible="true"></e-marker-settings></ej-spark-line>`| **Property:** *markerSettings.visible*<br/><br/> `<ejs-sparkline id="sparkline">            <e-sparkline-markersettings visible="all"></e-sparkline-markersettings></ejs-sparkline>`<br/><br/>`var all = new string[] {"All"}`|
|Color| **Property:** *markerSettings.fill*<br/><br/> `<ej-spark-line id="sparkline">            <e-marker-settings fill="green"></e-marker-settings></ej-spark-line>` |**Property:** *markerSettings.fill*<br/><br/> `<ejs-sparkline id="sparkline">            <e-sparkline-markersettings fill="green"></e-sparkline-markersettings></ejs-sparkline>`|
|Size| **Property:** *markerSettings.width*<br/><br/> `<ej-spark-line id="sparkline">            <e-marker-settings width="10"></e-marker-settings></ej-spark-line>`  |**Property:** *markerSettings.size*<br/><br/> `<ejs-sparkline id="sparkline">            <e-sparkline-markersettings size=5></e-sparkline-markersettings></ejs-sparkline>`|
|Opacity| **Property:** *markerSettings.opacity*<br/><br/> `<ej-spark-line id="sparkline">            <e-marker-settings opacity=0.5></e-marker-settings></ej-spark-line>` |**Property:** *markerSettings.opacity*<br/><br/> `<ejs-sparkline id="sparkline">            <e-sparkline-markersettings opacity=0.5></e-sparkline-markersettings></ejs-sparkline>`|
|Border color| **Property:** *markerSettings.border.color*<br/><br/> `<ej-spark-line id="sparkline"><e-marker-settings><e-border color="green"></e-border></e-marker-settings></ej-spark-line>`| **Property:** *markerSettings.border.color*<br/><br/> `<ejs-sparkline id="sparkline">            <e-sparkline-markersettings border="border"></e-sparkline-markersettings></ejs-sparkline>`<br/><br/>`var border = new {color="red"}`|
|Border width| **Property:** *markerSettings.border.width*<br/><br/> `<ej-spark-line id="sparkline"><e-marker-settings><e-border width="2"></e-border></e-marker-settings></ej-spark-line>` |**Property:** *markerSettings.border.width*<br/><br/> `<ejs-sparkline id="sparkline">            <e-sparkline-markersettings border="border"></e-sparkline-markersettings></ejs-sparkline>`<br/><br/>`var border = new {width=2}`|
|Border opacity| **Property:** *markerSettings.border.opacity*<br/><br/> `<ej-spark-line id="sparkline"><e-marker-settings><e-border opacity=0.7></e-border></e-marker-settings></ej-spark-line>` |Not applicable|

## Data labels

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable data labels| Not applicable |**Property:** *dataLabelSettings.visible*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings visible="all"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var all = new string[] {"All"}`|
|Color| Not applicable |**Property:** *dataLabelSettings.fill*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings fill="red"></e-sparkline-datalabelsettings></ejs-sparkline>`|
|Opacity| Not applicable |**Property:** *dataLabelSettings.opacity*<br/><br/>`<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings opacity=0.5></e-sparkline-datalabelsettings></ejs-sparkline>` |
|Border color| Not applicable |**Property:** *dataLabelSettings.border.color*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings border="border"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var border = new {color="red"}`|
|Border width| Not applicable |**Property:** *dataLabelSettings.border.width*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings border="border"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var border = new {width=2}`|
|Format| Not applicable |**Property:** *dataLabelSettings.format*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings format="${xval}: ${yval}"></e-sparkline-datalabelsettings></ejs-sparkline>`|
|Horizontal Offset| Not applicable |**Property:** *dataLabelSettings.offset.x*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings offset="offset"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var offset = new {x=100}`|
|Vertical Offset| Not applicable |**Property:** *dataLabelSettings.offset.y*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings offset="offset"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var offset = new {y=100}`|
|Font color| Not applicable |**Property:** *dataLabelSettings.textStyle.color*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings textStyle="textStyle"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var textStyle = new {color="green"}`|
|Font family| Not applicable |**Property:** *dataLabelSettings.textStyle.fontFamily*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings textStyle="textStyle"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var textStyle = new {fontFamily="Arial"}`|
|Font style| Not applicable |**Property:** *dataLabelSettings.textStyle.fontStyle*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings textStyle="textStyle"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var textStyle = new {fontStyle="normal"}`|
|Font weight| Not applicable |**Property:** *dataLabelSettings.textStyle.fontWeight*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings textStyle="textStyle"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var textStyle = new {fontWeight="bold"}`|
|Font opacity| Not applicable |**Property:** *dataLabelSettings.textStyle.opacity*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings textStyle="textStyle"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var textStyle = new {opacity=0.5}`|
|Font size| Not applicable |**Property:** *dataLabelSettings.textStyle.fontSize*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-datalabelsettings textStyle="textStyle"></e-sparkline-datalabelsettings></ejs-sparkline>`<br/><br/>`var textStyle = new {fontSize="12px"}`|

## Range band

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Color| **Property:** *rangeBandSettings.color*<br/><br/>`<ej-spark-line id="sparkline">          <e-range-band-settings color="red"></e-range-band-settings></ej-spark-line>` |**Property:** *rangeBandSettings.color*<br/><br/> `<ejs-sparkline id="sparkline">        <e-sparkline-rangebandsettings><e-sparkline-rangebandsetting color="red" ></e-sparkline-rangebandsetting></e-sparkline-rangebandsettings></ejs-sparkline>`|
|Opacity| **Property:** *rangeBandSettings.opacity*<br/><br/> `<ej-spark-line id="sparkline">            <e-range-band-settings opacity="0.5"></e-range-band-settings></ej-spark-line>` |**Property:** *rangeBandSettings.opacity*<br/><br/> `<ejs-sparkline id="sparkline">        <e-sparkline-rangebandsettings><e-sparkline-rangebandsetting opacity="0.5"></e-sparkline-rangebandsetting></e-sparkline-rangebandsettings></ejs-sparkline>`|
|Start range| **Property:** *rangeBandSettings.startRange*<br/><br/> `<ej-spark-line id="sparkline"><e-range-band-settings start-range="5"></e-range-band-settings></ej-spark-line>` |**Property:** *rangeBandSettings.startRange*<br/><br/> `<ejs-sparkline id="sparkline">        <e-sparkline-rangebandsettings><e-sparkline-rangebandsetting startRange="5"></e-sparkline-rangebandsetting></e-sparkline-rangebandsettings></ejs-sparkline>`|
|End range| **Property:** *rangeBandSettings.endRange*<br/><br/> `<ej-spark-line id="sparkline">    <e-range-band-settings end-range="10"></e-range-band-settings></ej-spark-line>` |**Property:** *rangeBandSettings.endRange*<br/><br/> `<ejs-sparkline id="sparkline">        <e-sparkline-rangebandsettings><e-sparkline-rangebandsetting endRange="10"></e-sparkline-rangebandsetting></e-sparkline-rangebandsettings></ejs-sparkline>`|

## Special points customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|High point color| **Property:** *highPointColor*<br/><br/> `<ej-spark-line id="sparkline" high-point-color="green"></ej-spark-line>` |**Property:** *highPointColor*<br/><br/> `<ejs-sparkline id="sparkline" highPointColor="red"></ejs-sparkline>`|
|Low point color| **Property:** *lowPointColor*<br/><br/> `<ej-spark-line id="sparkline" low-point-color="green"></ej-spark-line>` |**Property:** *lowPointColor*<br/><br/> `<ejs-sparkline id="sparkline" lowPointColor="red"></ejs-sparkline>`|
|Negative point color| **Property:** *negativePointColor*<br/><br/> `<ej-spark-line id="sparkline" negative-point-color="green"></ej-spark-line>` |**Property:** *negativePointColor*<br/><br/> `<ejs-sparkline id="sparkline" negativePointColor="red"></ejs-sparkline>`|
|Start point color| **Property:** *startPointColor*<br/><br/> `<ej-spark-line id="sparkline" start-point-color="green"></ej-spark-line>` |**Property:** *startPointColor*<br/><br/> `<ejs-sparkline id="sparkline" startPointColor="red"></ejs-sparkline>`|
|End point color| **Property:** *endPointColor*<br/><br/> `<ej-spark-line id="sparkline" end-point-color="green"></ej-spark-line>` |**Property:** *endPointColor*<br/><br/> `<ejs-sparkline id="sparkline" endPointColor="red"></ejs-sparkline>`|
|Tie point color| **Property:** *tiePointColor*<br/><br/>Not Applicable |**Property:** *tiePointColor*<br/><br/> `<ejs-sparkline id="sparkline" tiePointColor="red"></ejs-sparkline>`|

## Axis customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show axis line| **Property:** *axisSettings.visible*<br/><br/> `<ej-spark-line id="sparkline"><e-axis-line-settings visible="true"></e-axis-line-settings></ej-spark-line>` |**Property:** *axisSettings.lineSettings.visible*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { Visible= true}`|
|Line color| **Property:** *axisSettings.color*<br/><br/> `<ej-spark-line id="sparkline"><e-axis-line-settings color="green"></e-axis-line-settings></ej-spark-line>` |**Property:** *axisSettings.lineSettings.color*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { Color= "red"}`|
|Line width| **Property:** *axisSettings.width*<br/><br/> `<ej-spark-line id="sparkline"><e-axis-line-settings width="3"></e-axis-line-settings></ej-spark-line>` |**Property:** *axisSettings.lineSettings.width*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { Width= 2}`|
|Dash array| **Property:** *axisSettings.dashArray*<br/><br/> `<ej-spark-line id="sparkline"><e-axis-line-settings dash-array="5,3"></e-axis-line-settings></ej-spark-line>` |**Property:** *axisSettings.lineSettings.dashArray*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { DashArray= "5,3"}`|
|X axis minimum value| Not applicable |**Property:** *axisSettings.minX*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { MinX= 0}`|
|X axis maximum value| Not applicable |**Property:** *axisSettings.maxX*<br/><br/>`<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { MaxY= 100}`|
|Y axis minimum value| Not applicable |**Property:** *axisSettings.minY*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { MinY= 0}`|
|Y axis maximum value| Not applicable |**Property:** *axisSettings.maxY*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { MaxY= 10}`|
|Horizontal axis line position| Not applicable |**Property:** *axisSettings.value*<br/><br/> `<ejs-sparkline id="sparkline" ><e-sparkline-axissettings lineSettings="lineSettings"></e-sparkline-axissettings></ejs-sparkline>`<br/><br/>`var lineSettings = new SparklineLineSettings { Value= 10}`|

## Appearance customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Background color| **Property:** *background*<br/><br/> `<ej-spark-line id="sparkline" background="grey"></ej-spark-line>` |**Property:** *containerArea.background*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-containerarea background="red"></e-sparkline-containerarea></ejs-sparkline>`|
|Border color | Not applicable |**Property:** *containerArea.border.color*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-containerarea border="border"></e-sparkline-containerarea></ejs-sparkline>`<br/><br/>`var border = new {color="green"}`|
|Border width | Not applicable |**Property:** *containerArea.border.width*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-containerarea border="border"></e-sparkline-containerarea></ejs-sparkline>`<br/><br/>`var border = new {color="green"}`|
|Series color| **Property:** *fill*<br/><br/> `<ej-spark-line id="sparkline" fill="grey"></ej-spark-line>` |**Property:** *fill*<br/><br/> `<ejs-sparkline id="sparkline" fill="lime"></ejs-sparkline>`|
|Series opacity| **Property:** *opacity*<br/><br/> `<ej-spark-line id="sparkline" opacity=0.5></ej-spark-line>` |**Property:** *opacity*<br/><br/> `<ejs-sparkline id="sparkline" opacity=0.5></ejs-sparkline>`|
|Line series width| **Property:** *width*<br/><br/> `<ej-spark-line id="sparkline" width=3></ej-spark-line>` |**Property:** *lineWidth*<br/><br/> `<ejs-sparkline id="sparkline" lineWidth=4></ejs-sparkline>`|
|Series border color| **Property:** *border.color*<br/><br/> `<ej-spark-line id="sparkline" ><e-border color="red"></e-border></ej-spark-line>` |**Property:** *border.color*<br/><br/>`<ejs-sparkline id="sparkline"><e-sparkline-border color="green" ></e-sparkline-border></ejs-sparkline>`|
|Series border width| **Property:** *border.width*<br/><br/> `<ej-spark-line id="sparkline" ><e-border width="1"></e-border></ej-spark-line>` |**Property:** *border.width*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-border width=10></e-sparkline-border></ejs-sparkline>`|
|Series palette| **Property:** *palette*<br/><br/> `<ej-spark-line id="sparkline" palette="palettes"></ej-spark-line>`<br/><br/>`var palettes = new string[] { "red", "green", "orange", "blue" };` |**Property:** *palette*<br/><br/> `<ejs-sparkline id="sparkline" palette="palettes"></ejs-sparkline>`<br/><br/>`var palettes = new string[] { "red", "green", "orange", "blue" };`|
|Theme| **Property:** *theme*<br/><br/> `<ej-spark-line id="sparkline" theme="flatdark"></ej-spark-line>` |**Property:** *theme*<br/><br/> `<ejs-sparkline id="sparkline" theme="Material"></ejs-sparkline>`|
|Width| **Property:** *size.width*<br/><br/> `<ej-spark-line id="sparkline"><e-size width="300px"></e-size></ej-spark-line>` |**Property:** *width*<br/><br/> `<ejs-sparkline id="sparkline" width="400px"></ejs-sparkline>`|
|Height| **Property:** *size.height*<br/><br/> `<ej-spark-line id="sparkline" ><e-size color="red" height="300px"></e-size></ej-spark-line>` |**Property:** *height*<br/><br/> `<ejs-sparkline id="sparkline" height="200px"></ejs-sparkline>`|

## Tooltip

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Show tooltip| **Property:** *tooltip.visible*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip visible="true"></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.visible*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings visible="true"></e-sparkline-tooltipsettings></ejs-sparkline>`|
|Background| **Property:** *tooltip.fill*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip fill="white"></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.fill*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings fill="white"></e-sparkline-tooltipsettings></ejs-sparkline>`|
|Format| Not applicable |**Property:** *tooltipSettings.format*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings format="${xval}: ${yval}"></e-sparkline-tooltipsettings></ejs-sparkline>`|
|Template| **Property:** *tooltip.template*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip template="tooltip"></e-tool-tip></e-size></ej-spark-line>`<br/><br/>`<div id="tooltip">`</br>&nbsp;        `<div>#point.x#</div>`</br>&nbsp;&nbsp;`<div>#point.y#</div>`</br>`</div>`|**Property:** *tooltipSettings.template*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings template="tooltip"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`<div id="tooltip">${x} : ${y}<div>`|
|Font color| **Property:** *tooltip.font.color*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip><e-font color="green"></e-font></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.textStyle.color*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings textstyle="textStyle"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`var textStyle = new { color="gray"};`|
|Font opacity| **Property:** *tooltip.font.opacity*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip><e-font opacity=0.7></e-font></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.textStyle.opacity*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings textstyle="textStyle"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`var textStyle = new { opacity=0.5};`|
|Font size| **Property:** *tooltip.font.size*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip><e-font size="14px"></e-font></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.textStyle.size*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings textstyle="textStyle"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`var textStyle = new { size="14px"};`|
|Font family| **Property:** *tooltip.font.fontFamily*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip><e-font font-family="Arial"></e-font></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.textStyle.fontFamily*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings textstyle="textStyle"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`var textStyle = new { fontFamily="Arial"};`|
|Font style| **Property:** *tooltip.font.fontStyle*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip><e-font font-style="normal"></e-font></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.textStyle.fontStyle*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings textstyle="textStyle"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`var textStyle = new { fontStyle="normal"};`|
|Font weight| **Property:** *tooltip.font.fontWeight*<br/><br/> `<ej-spark-line id="sparkline"><e-tool-tip><e-font font-weight="bold"></e-font></e-tool-tip></e-size></ej-spark-line>` |**Property:** *tooltipSettings.textStyle.fontWeight*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings textstyle="textStyle"></e-sparkline-tooltipsettings></ejs-sparkline>`<br/><br/>`var textStyle = new { fontWeight="bold"};`|
|Enable track line| Not applicable |**Property:** *tooltipSettings.trackLineSettings.visible*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings><e-sparklinetooltipsettings-tracklinesettings visible="true"></e-sparklinetooltipsettings-tracklinesettings></e-sparkline-tooltipsettings></ejs-sparkline>`|
|Track line color| Not applicable |**Property:** *tooltipSettings.trackLineSettings.color*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings><e-sparklinetooltipsettings-tracklinesettings color="red"></e-sparklinetooltipsettings-tracklinesettings></e-sparkline-tooltipsettings></ejs-sparkline>`|
|Track line width| Not applicable |**Property:** *tooltipSettings.trackLineSettings.width*<br/><br/> `<ejs-sparkline id="sparkline"><e-sparkline-tooltipsettings><e-sparklinetooltipsettings-tracklinesettings width=5></e-sparklinetooltipsettings-tracklinesettings></e-sparkline-tooltipsettings></ejs-sparkline>`|

## Rendering

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable canvas rendering| **Property:** *enableCanvasRendering*<br/><br/> `<ej-spark-line id="sparkline" enable-canvas-rendering="true"></ej-spark-line>` | Not applicable |

## Localization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Localization| **Property:** *locale*<br/><br/> `<ej-spark-line id="sparkline" locale="en-US"></ej-spark-line>` | **Property:** *type*<br/><br/> `<ejs-sparkline id="sparkline" locale="en-US"></ejs-sparkline>` |

## Methods

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Dynamically updating sparkline| **Method:** *redraw*<br/><br/> `var sparkline = $("#container").ejSparkline("instance");`</br>`sparkline.redraw();` | **Method:** *refresh*<br/><br/> `var sparkline = document.getElementById("container").ej2_instances[0];`</br>`sparkline.refresh();` |

## Events

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Load| **Event:** *load*<br/><br/> `<ej-spark-line id="sparkline" load="load">       </ej-spark-line>`<br/><br/>`function load(args) { }` | **Event:** *load*<br/><br/> `<ejs-sparkline id="sparkline" load="load"></ejs-sparkline>`<br/><br/>`function load(args) { }` |
|Load completed| **Event:** *loaded*<br/><br/> `<ej-spark-line id="sparkline" loaded="loaded">       </ej-spark-line>`<br/><br/>`function loaded(args) { }` | **Event:** *loaded*<br/><br/> `<ejs-sparkline id="sparkline" loaded="loaded"></ejs-sparkline>`<br/><br/>`function loaded(args) { }` |
|Initialize tooltip| **Event:** *tooltipInitialize*<br/><br/> `<ej-spark-line id="sparkline" tooltip-initialize="tooltipInitialize"></ej-spark-line>`<br/><br/>`function tooltipInitialize(args) { }` | **Event:** *tooltipInitialize*<br/><br/> `<ejs-sparkline id="sparkline" tooltipInitialize="tooltipInitialize"></ejs-sparkline>`<br/><br/>`function tooltipInitialize(args) { }` |
|Series rendering| **Event:** *seriesRendering*<br/><br/> `<ej-spark-line id="sparkline" series-rendering="seriesRendering"></ej-spark-line>`<br/><br/>`function seriesRendering(args) { }` | **Event:** *seriesRendering*<br/><br/> `<ejs-sparkline id="sparkline" seriesRendering="seriesRendering"></ejs-sparkline>`<br/><br/>`function seriesRendering(args) { }` |
|Region mouse move| **Event:** *pointRegionMouseMove*<br/><br/> `<ej-spark-line id="sparkline" point-region-mouse-move="pointRegionMove"></ej-spark-line>`<br/><br/>`function pointRegionMove(args) { }` | **Event:** *pointRegionMouseMove*<br/><br/> `<ejs-sparkline id="sparkline" pointRegionMouseMove="pointRegionMouseMove"></ejs-sparkline>`<br/><br/>`function pointRegionMouseMove(args) { }` |
|Region click| **Event:** *pointRegionMouseClick*<br/><br/> `<ej-spark-line id="sparkline" point-region-mouse-click="pointRegionClick"></ej-spark-line>`<br/><br/>`function pointRegionClick(args) { }` | **Event:** *pointRegionMouseClick*<br/><br/> `<ejs-sparkline id="sparkline" pointRegionMouseClick="pointRegionMouseClick"></ejs-sparkline>`<br/><br/>`function pointRegionMouseClick(args) { }` |
|Mouse move| **Event:** *sparklineMouseMove*<br/><br/> `<ej-spark-line id="sparkline" sparkline-mouse-move="mouseMove">  </ej-spark-line>`<br/><br/>`function mouseMove(args) { }` | **Event:** *sparklineMouseMove*<br/><br/> `<ejs-sparkline id="sparkline" sparklineMouseMove="sparklineMouseMove"></ejs-sparkline>`<br/><br/>`function sparklineMouseMove(args) { }` |
|Mouse leave| **Event:** *sparklineMouseLeave*<br/><br/> `<ej-spark-line id="sparkline" sparkline-mouse-leave="mouseLeave"></ej-spark-line>`<br/><br/>`function mouseLeave(args) { }` | Not applicable |
|Click| **Event:** *click*<br/><br/> `<ej-spark-line id="sparkline" sparkline-mouse-click="sparklineMouseClick">       </ej-spark-line>`<br/><br/>`function sparklineMouseClick(args) { }` | **Event:** *sparklineMouseClick*<br/><br/> `<ejs-sparkline id="sparkline" sparklineMouseClick="sparklineMouseClick"></ejs-sparkline>`<br/><br/>`function sparklineMouseClick(args) { }` |
|doubleClick| **Event:** *doubleClick*<br/><br/>`<ej-spark-line id="sparkline" ldouble-click="doubleClick">       </ej-spark-line>`<br/><br/>`function doubleClick(args) { }` | Not applicable |
|rightClick| **Event:** *rightClick*<br/><br/> `<ej-spark-line id="sparkline" right-click="rightClick">       </ej-spark-line>`<br/><br/>`function rightClick(args) { }` | Not applicable |
|axisRendering| Not applicable | **Event:** *axisRendering*<br/><br/> `<ejs-sparkline id="sparkline" axisRendering="axisRendering"></ejs-sparkline>`<br/><br/>`function axisRendering(args) { }` |
|dataLabelRendering| Not applicable | **Event:** *dataLabelRendering*<br/><br/> `<ejs-sparkline id="sparkline" dataLabelRendering="dataLabelRendering"></ejs-sparkline>`<br/><br/>`function dataLabelRendering(args) { }` |
|markerRendering| Not applicable | **Event:** *markerRendering*<br/><br/> `<ejs-sparkline id="sparkline" markerRendering="markerRendering"></ejs-sparkline>`<br/><br/>`function markerRendering(args) { }` |
|pointRendering| Not applicable | **Event:** *pointRendering*<br/><br/> `<ejs-sparkline id="sparkline" pointRendering="pointRendering"></ejs-sparkline>`<br/><br/>`function pointRendering(args) { }` |
|resize| Not applicable | **Event:** *resize*<br/><br/> `<ejs-sparkline id="sparkline" resize="resize"></ejs-sparkline>`<br/><br/>`function resize(args) { }` |