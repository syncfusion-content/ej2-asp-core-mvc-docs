---
title: "Migration from Essential JS 1"
component: "Maps"
description: "Explains the common steps for migrating from Essential JS 1 application to Essential JS 2 components especially, maps component."
---

<!-- markdownlint-disable MD038 -->

# Migration from Essential JS 1

This article describes the API migration process of Maps component from Essential JS 1 to Essential JS 2.

## Size Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Height| Not Applicable |**Property:** *height*<br/><br/>`@Html.EJS().Maps("container")`<br/>`.Load("load")`<br/>`.Height('300px')Render()`|
|Width| Not Applicable |**Property:** *width*<br/><br/> `@Html.EJS().Maps("container")`<br/>`.Load("load")`<br/>`.Width('400px').Render()`|

## Title and Subtitle Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Title Text| Not Applicable |**Property:** *title.text*<br/><br/> `@Html.EJS().Maps("container")`<br/>`.Load("load").TitleSettings`<br/>`(new Syncfusion.EJ2.Maps.MapsTitleSettings`<br/>`{Text="Members of the UN Security Council"}}).Render()`|
|Subtitle Text| Not Applicable |**Property:** *title.subtitle.text*<br/><br/> `@Html.EJS().Maps("container")`<br/>`.Load("load")`<br/>`.TitleSettings(title =>SubtitleSettings`<br/>`(new MapsSubTitleSettings`<br/>`{Text="- In 2017"})).Render()`|
|Title Alignment| Not Applicable |**Property:** *title.alignment*<br/><br/> `@Html.EJS().Maps("container")`<br/>`.Load("load").TitleSettings`<br/>`(new Syncfusion.EJ2.Maps.MapsTitleSettings`<br/>`{Text="Members of the UN Security Council",`<br/>`Alignment('Far')}}).Render()`)|
|Subtitle Alignment| Not Applicable |**Property:** *title.subtitle.alignment*<br/><br/>  `@Html.EJS().Maps("container")`<br/>`.Load("load")`<br/>`.TitleSettings(title =>SubtitleSettings`<br/>`(new MapsSubTitleSettings`<br/>`{Text="- In 2017",`<br/>`Alignment='Far' })).Render()`|

## Layer Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Type | Not Applicable | **Property:** *layers.type*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.Type('Layer')}).Render()`|
| Layer Type | **Property:** *layers.layerType*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.LayerType(LayerType.Geometry)}))`| **Property:** *layers.layerType*<br/><br/>`@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.LayerType('Geometry')}).Render()`|
| Visible | Not Applicable | **Property:** *layers.visible*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.Visible(true)}).Render()`|
| Bing Map Type | **Property:** *layers.bingMapType*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LayerType(Syncfusion.JavaScript.DataVisualization.Models.LayerType.Bing)}))`| **Property:** *layers.bingMapType*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.BingMapType('Aerial')}).Render()`|
| Bing Map Key | **Property:** *layers.key*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.Key("")}))`
| **Property:** *layers.key*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.Key('')}).Render()`|
| URL Template | **Property:** *layers.urltemplate*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{ir.Urltemplate:'http://a.tile.openstreetmap.org/level/tileX/tileY.png' }))`| **Property:** *layers.urlTemplate*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.UrlTemplate:'http://a.tile.openstreetmap.org/level/tileX/tileY.png' }).Render()`|
| Shape Data | **Property:** *layers.shapeData*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeData(usmap).Add}))`| **Property:** *layers.shapeData*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.ShapeData('usmap')}).Render()`|
| Data Source | **Property:** *layers.dataSource*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.dataSource('PopulationData')}))`| **Property:** *layers.dataSource*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.DataSource('')}).Render()`|
| Query | Not Applicable | **Property:** *layers.query*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.Query('')}).Render()`|
| Shape Data Path | **Property:** *layers.shapeDataPath*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.shapeDataPath('population')}))`| **Property:** *layers.shapeDataPath*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.ShapeDataPath('')}).Render()`|
| Shape Property Path | **Property:** *layers.shapePropertyPath*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapePropertyPath('Continent')}))`| **Property:** *layers.shapePropertyPath*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.shapePropertyPath('')}).Render()`|
| Layer Animation | Not Applicable | **Property:** *layers.animationDuration*<br/><br/> `@Html.EJS().Maps("container").Load("load").Layers(lr =>{lr.ShapePropertyPath('')}).Render()`|

## Shape Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Shape Fill | **Property:** *layers.shapeSettings.fill*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(ss =>{ss.Fill('#626171')}})))`| **Property:** *layers.shapeSettings.fill*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{Fill="red" }).Render()`|
| Shape Palette | **Property:** *layers.shapeSettings.colorPalette*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(ss =>{ss.ColorPalette(ColorPalette.CustomPalette)}})))`<br/>`.CustomPalette(new List<string>{"#E51400", "#A4C400", "#730202",})`| **Property:** *layers.shapeSettings.palette*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{ColorMapping = ViewBag.colorMappings}).Render()`<br/>`ViewBag.colorMappings = data;`|
| Shape Point Radius | Not Applicable | **Property:** *layers.shapeSettings.circleRadius*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{circleRadius= 10 }).Render()`|
| Shape Color Value Path | **Property:** *layers.shapeSettings.colorValuePath*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(ss =>{ss.ColorValuePath('')}})))`| **Property:** *layers.shapeSettings.colorValuePath*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{ColorValuePath='' }).Render()`|
| Shape Value Path | **Property:** *layers.shapeSettings.valuePath*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(ss =>{ss.ValuePath('')}})))`| **Property:** *layers.shapeSettings.valuePath*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{ valuePath='population'}).Render()`|
| Shape DashArray | Not Applicable | **Property:** *layers.shapeSettings.dashArray*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{DashArray='1,2'}).Render()`|
| Shape Opacity | Not Applicable | **Property:** *layers.shapeSettings.opacity*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{ Opacity='0.5' }).Render()`|
| Range Color Mapping | **Property:** *layers.shapeSettings.colorMappings.rangeColorMapping*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(ss =>{ss..RangeColorMappings(cm =>cm.From(10).To(100).color('blue')}})))`| **Property:** *layers.shapeSettings.colorMapping*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{ColorMapping = ViewBag.ColorMapping }).Render()`<br/>`ViewBag.ColorMapping = colorMapping;`<br/>`colorMapping.Add(new MapsColorMapping{From =100, To=1000, Color = "#b3daff", Label = null})`|
| Equal Color Mapping | **Property:** *layers.shapeSettings.colorMappings.equalColorMapping*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(ss =>{ss.EqualColorMappings(cm =>cm.value('').color('blue'))))`| **Property:** *layers.shapeSettings.colorMapping*<br/><br/> `@Html.EJS().Maps("container").Load("load").ShapeSettings(new MapsShapeSettings{ColorMapping = ViewBag.ColorMapping }).Render()`<br/>`ViewBag.ColorMapping = colorMapping;`<br/>`colorMapping.Add(new MapsColorMapping{Value = "1", Color = "#b3daff", Label = null})`|

## Marker Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Marker Data Source | **Property:** *layers.markers*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.Markers(datasource)}))` <br/> `ViewData["datasource"]= Syncfusion_LocationData.GetSyncfusionLocationData();`<br/>`List<MapMarker> syncfusionLocationData = new List<MapMarker>{new LocationData {Name = "USA", Latitude =38.8833 , Longitude = -77.0167 }}`| **Property:** *layers.markerSettings.dataSource*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>` function mapsLoad(args){ args.maps.layers[0].markerSettings=[{dataSource:[{latitude: 37.6276571, longitude: -122.4276688, name: 'San Bruno' },}]`|
| Marker Template | **Property:** *layers.markerTemplate*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.Markers(datasource)..MarkerTemplate("template")}))`| **Property:** *layers.markerSettings.template*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{template:'Template'}]`|
| Marker Visible | Not Applicable | **Property:** *layers.markerSettings.visible*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{visible:true}]`|
| Marker Fill | Not Applicable | **Property:** *layers.markerSettings.fill*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{fill:'red'}]`|
| Marker Height | Not Applicable | **Property:** *layers.markerSettings.height*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{height:20}]`|
| Marker Width | Not Applicable | **Property:** *layers.markerSettings.width*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{width:20}]`|
| Marker Shape | Not Applicable | **Property:** *layers.markerSettings.shape*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{shape="Balloon"}]`|
| Marker ImageURL | Not Applicable | **Property:** *layers.markerSettings.imageUrl*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{imageUrl:''}]`|
| Marker Opacity | Not Applicable | **Property:** *layers.markerSettings.opacity*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{opacity:0.5}]`|
| Marker Legend Text | Not Applicable | **Property:** *layers.markerSettings.legendText*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{legendText:'China'}]`|
| Marker Offset | Not Applicable | **Property:** *layers.markerSettings.offset*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{offset:new Point(20, 20)}]`|
| Marker Animation Duration | Not Applicable | **Property:** *layers.markerSettings.animationDuration*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{animationDuration:2000}]`|
| Marker Animation Delay | Not Applicable | **Property:** *layers.markerSettings.animationDelay*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{animationDelay:100}]`|
| Marker DashArray | Not Applicable | **Property:** *layers.markerSettings.dashArray*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{dashArray:'2,3'}]`|
| Marker Selection | Not Applicable | **Property:** *layers.markerSettings.selectionSettings*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{ selectionSettings : { enable:true,fill:'#D2691E',opacity:1,enableMultiSelect:false }}]`|
| Marker Highlight | Not Applicable | **Property:** *layers.markerSettings.highlightSettings*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{ highlightSettings : { enable:true,fill:'#D2691E',opacity:1 }}]`|
| Marker Tooltip | Not Applicable | **Property:** *layers.markerSettings.tooltipSettings*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Render()`<br/>`function mapsLoad(args){ args.maps.layers[0].markerSettings =[{tooltipSettings : { visible:true,fill:'#363F4C',template:'TooltipTemplate', valuePath:'State', format:'${State}${District}' } }]`|

## Bubble Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Visible | **Property:** *layers.bubbleSettings.visible*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.ShowBubble(true) }})))`| **Property:** *layers.bubbleSettings.visible*<br/><br/>`@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.Visible=true`|
| ValuePath | **Property:** *layers.bubbleSettings.valuePath*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.ValuePath('Population') }})))`| **Property:** *layers.bubbleSettings.valuePath*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.ValuePath='Population'`|
| MinValue | **Property:** *layers.bubbleSettings.minValue*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.MinValue(20) }})))`| **Property:** *layers.bubbleSettings.minRadius*<br/><br/>`@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.MinRadius=10`|
| MaxValue | **Property:** *layers.bubbleSettings.maxValue*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.MaxValue(30) }})))`
| **Property:** *layers.bubbleSettings.maxRadius*<br/><br/> `@Html.EJS().Maps("container").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()` <br/><br/>`MapsBubble bubble = new MapsBubble();bubble.MaxRadius=20`|
| Bubble Type | Not Applicable | **Property:** *layers.bubbleSettings.bubbleType*<br/><br/>`@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.BubbleType='Circle'`|
| Color | **Property:** *layers.bubbleSettings.color*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.Color('red') }})))`| **Property:** *layers.bubbleSettings.fill*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.Fill='red'`|
| Opacity | **Property:** *layers.bubbleSettings.bubbleOpacity*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.BubbleOpacity(0.6) }})))`| **Property:** *layers.bubbleSettings.opacity*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{layer.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.Opacity=0.5`|
| Color Value Path | **Property:** *layers.bubbleSettings.colorValuePath*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.ColorValuePath('')}})))`| **Property:** *layers.bubbleSettings.colorValuePath*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{layer.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.ColorValuePath=''`|
| Enable Tooltip | **Property:** *layers.bubbleSettings.showTooltip*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.ShowTooltip(true) }})))`| **Property:** *layers.bubbleSettings.tooltipSettings.visible*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.TooltipSetting.Visible=true`|
| Tooltip Template | **Property:** *layers.bubbleSettings.tooltipTemplate*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs.TooltipTemplate('Template') }})))`| **Property:** *layers.bubbleSettings.tooltipSettings.template*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.TooltipSetting.Template='template'`|
| Bubble Selection | Not Applicable | **Property:** *layers.bubbleSettings.selectionSettings*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{layer.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.SelectionSetting.Enable=true`|
| Bubble Highlight | Not Applicable | **Property:** *layers.bubbleSettings.highlightSettings*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.HighlightSetting.Enable=true`|
| Range Color Mapping | **Property:** *layers.bubbleSettings.colorMappings.rangeColorMapping*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs. }})))`| **Property:** *layers.bubbleSettings.colorMapping*<br/><br/>`@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{lr.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.`|
| Equal Color Mapping | **Property:** *layers.bubbleSettings.colorMappings.equalColorMapping*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.BubbleSettings(bs =>{bs. }})))`| **Property:** *layers.bubbleSettings.colorMapping*<br/><br/> `@Html.EJS().Maps("container").Load("mapsLoad").Layer(lr=>{layer.BubbleSettings(ViewBag.bubbleSettings)}).Render()`<br/>`MapsBubble bubble = new MapsBubble();`<br/>`bubble.`|

## DataLabel Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Visible | **Property:** *layers.labelSettings.showLabels*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LabelSettings(lb =>{lb.ShowLabels(true)})}))`| **Property:** *layers.dataLabelSettings.visible*<br/><br/> `@Html.EJS().Maps("container").Layer({lr.DataLabelSettings(new MapsDataLabelSettings{Visible = true})).Render()`|
| Label Path | **Property:** *layers.labelSettings.labelPath*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.LabelSettings(lb =>{lb.LabelPath("iso_3166_2")})}))`| **Property:** *layers.dataLabelSettings.labelPath*<br/><br/> `@Html.EJS().Maps("container").Layer({lr.DataLabelSettings(new MapsDataLabelSettings{LabelPath = "name",})).Render()`|
| Enable Smart Label | **Property:** *layers.labelSettings.enableSmartLabel*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LabelSettings(lb =>{lb.EnableSmartLabel(true);})}))`| Not Applicable |
| Smart Label Size | **Property:** *layers.labelSettings.smartLabelSize*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LabelSettings(lb =>{lb.SmartLabelSize(20)})}))`| Not Applicable |
| Label Length | **Property:** *layers.labelSettings.labelLength*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LabelSettings(lb =>{lb.LabelLength(20) })}))`| Not Applicable |
| Opacity | Not Applicable | **Property:** *layers.dataLabelSettings.opacity*<br/><br/> `@Html.EJS().Maps("container").Layer({lr.DataLabelSettings(new MapsDataLabelSettings{Opacity=0.5})).Render()`|
| Smart Label Mode | Not Applicable | **Property:** *layers.dataLabelSettings.smartLabelMode*<br/><br/> `@Html.EJS().Maps("container").Layer({lr.DataLabelSettings(new MapsDataLabelSettings{ SmartLabelMode = SmartLabelMode.Trim})).Render()`|
| InterSectAction | Not Applicable | **Property:** *layers.dataLabelSettings.intersectionAction*<br/><br/> `@Html.EJS().Maps("container").Layer({lr.DataLabelSettings(new MapsDataLabelSettings{ IntersectionAction = IntersectionAction.Trim})).Render()`|
| Template | Not Applicable | **Property:** *layers.dataLabelSettings.template*<br/><br/> `@Html.EJS().Maps("container").Layer({lr.DataLabelSettings(new MapsDataLabelSettings{Template='Temaplate'})).Render()`|

## Legend Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Visible | **Property:** *layers.legendSettings.showLegend*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.ShowLegend(true})}))`| **Property:** *legendSettings.visible*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ Visible = true}).Render()`|
| Toggle Visibility | **Property:** *layers.legendSettings.toggleVisibility*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.ToggleVisibility(true)})}))`| **Property:** *legendSettings.toggleVisibility*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ToggleVisibility = true}).Render()`|
| Legend Location X | **Property:** *layers.legendSettings.positionX*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.PositionX(250)})}))`| **Property:** *legendSettings.location*<br/><br/>`@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ }).Render()`|
| Legend Location Y | **Property:** *layers.legendSettings.positionY*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.PositionY(250)})}))`| **Property:** *legendSettings.location*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ }).Render()`|
| Legend Type | **Property:** *layers.legendSettings.type*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Type:'Layers'})}))`| **Property:** *legendSettings.type*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ Type = Syncfusion.EJ2.Maps.LegendType.Layers}).Render()`|
| Label Orientation | **Property:** *layers.legendSettings.labelOrientation*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.LabelOrientation('Vertical')})}))`| Not Applicable |
| Legend Title | **Property:** *layers.legendSettings.title*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Title:'Union territories of India'})}))`| **Property:** *legendSettings.title*<br/><br/>`@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{  Title= ""}).Render()`|
| Legend Mode | **Property:** *layers.legendSettings.mode*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Mode('Default')})}))`| **Property:** *legendSettings.mode*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ Mode = Syncfusion.EJ2.Maps.LegendMode.Default, }).Render()`|
| Legend Position | **Property:** *layers.legendSettings.position*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Position('TopLeft')})}))`| **Property:** *legendSettings.position*<br/><br/>`@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{Position = Syncfusion.EJ2.Maps.LegendPosition.Bottom, }).Render()`|
| Legend DockOnMap | **Property:** *layers.legendSettings.dockOnMap*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.DockOnMap(true)})}))`| Not Applicable |
| Legend Alignment | **Property:** *layers.legendSettings.dockPosition*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.DockPosition('Right')})}))`| **Property:** *legendSettings.alignment*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{Alignment = Syncfusion.EJ2.Maps.Alignment.Center }).Render()`|
| Legend Left Label | **Property:** *layers.legendSettings.leftLabel*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.LeftLabel('1000M')})}))`| Not Applicable |
| Legend Right Label | **Property:** *layers.legendSettings.rightLabel*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls. RightLabel('3000M')})}))`| Not Applicable |
| Legend Shape | **Property:** *layers.legendSettings.icon*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Icon('Circle')})}))`| **Property:** *legendSettings.shape*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{Shape= Syncfusion.EJ2.Maps.LegendShape.Circle }).Render()`|
| Legend Shape Height | **Property:** *layers.legendSettings.iconHeight*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.IconHeight(20)})}))`| **Property:** *legendSettings.shapeHeight*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ShapeHeight=20 }).Render()`|
| Legend Shape Width | **Property:** *layers.legendSettings.iconWidth*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.IconWidth(20)})}))`| **Property:** *legendSettings.shapeWidth*<br/><br/>`@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ShapeWidth=20 }).Render()`|
| Height | **Property:** *layers.legendSettings.height*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Height(50)})}))`| **Property:** *legendSettings.width*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{Height='50'}).Render()`|
| Width | **Property:** *layers.legendSettings.width*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.Width(50)})}))`| **Property:** *legendSettings.width*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ Width='150' }).Render()`|
| Show Labels | **Property:** *layers.legendSettings.showLabels*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.LegendSettings(ls =>{ls.ShowLabels(true)})}))`| Not Applicable |
| Background | Not Applicable | **Property:** *legendSettings.background*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{Background='transparent' }).Render()`|
| Label Position | Not Applicable | **Property:** *legendSettings.labelPosition*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{LabelPosition = Syncfusion.EJ2.Maps.LabelPosition.After }).Render()`|
| Label Display Mode | Not Applicable | **Property:** *legendSettings.labelDisplayMode*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{LabelDisplayMode = Syncfusion.EJ2.Maps.LabelIntersectAction.Trim, }).Render()`|
| Legend Orientation | Not Applicable | **Property:** *legendSettings.orientation*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{Orientation = Syncfusion.EJ2.Maps.LegendArrangement.Horizontal, }).Render()`|
| Legend Item Fill | Not Applicable | **Property:** *legendSettings.fill*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ Fill='red'}).Render()`|
| Legend Shape Padding | Not Applicable | **Property:** *legendSettings.shapePadding*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{  ShapePadding=20}).Render()`|
| Legend Shape Border Color | Not Applicable | **Property:** *legendSettings.shapeBorder.color*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ShapeBorder = { Color="green" }, }).Render()`|
| Legend Shape Border Width | Not Applicable | **Property:** *legendSettings.shapeBorder.width*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ShapeBorder = { Width=30 }, }).Render()`|
| Inverter Pointer | Not Applicable | **Property:** *legendSettings.invertedPointer*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{InvertedPointer= true }).Render()`|
| Item Text Style | Not Applicable | **Property:** *legendSettings.textStyle*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{TextStyle = new MapsFont { Size = "14px" } }).Render()`|
| Title Style | Not Applicable | **Property:** *legendSettings.textStyle*<br/><br/> `@Html.EJS().Maps("container").LegendSettings(new Syncfusion.EJ2.Maps.MapsLegendSettings{ TitleStyle= new MapsFont { Size = "14px" }}).Render()`|

## Zooming Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Enable| Not Applicable | **Property:** *zoomSettings.enableZoom*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{ Enable=true}).Render()`|
|Minimum Zoom| **Property:** *zoomSettings.minValue*<br/><br/>`@(Html.EJ().Map("container").ZoomSettings(zm=>{zm.MinValue(2)}))`| **Property:** *zoomSettings.minZoom*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{MinZoom=2,}).Render()`|
|Maximum Zoom| **Property:** *zoomSettings.maxValue*<br/><br/> `@(Html.EJ().Map("container").ZoomSettings(zm=>{zm.MaxValue(50)}))`| **Property:** *zoomSettings.maxZoom*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{MaxZoom=4,}).Render()`|
|Mouse Wheel Zoom| **Property:** *zoomSettings.enableMouseWheelZoom*<br/><br/> `@(Html.EJ().Map("container").ZoomSettings(zm=>{zm.EnableMouseWheelZoom(true)}))`| **Property:** *zoomSettings.maxZoom*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{MouseWheelZoom=true}).Render()`|
| Double Click Zoom | Not Applicable | **Property:** *zoomSettings.doubleClickZoom*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{DoubleClickZoom=true}).Render()`|
| Pinch Zoom | Not Applicable | **Property:** *zoomSettings.pinchZooming*<br/><br/>`@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{PinchZooming=true}).Render()`|
| Single Click Zoom | **Property:** *zoomSettings.enableZoomOnSelection*<br/><br/> `@(Html.EJ().Map("container").ZoomSettings(zm=>{zm.EnableZoomOnSelection(true)}))`| **Property:** *zoomSettings.zoomOnClick*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{ZoomOnClick=true}).Render()`|
| Zoom Factor | **Property:** *zoomSettings.factor*<br/><br/> `@(Html.EJ().Map("container").ZoomSettings(zm=>{zm.Factor(2)}))`| **Property:** *zoomSettings.zoomFactor*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{ ZoomFactor=2,}).Render()`|
| Toolbars | Not Applicable | **Property:** *zoomSettings.toolbars*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{Toolbars =['ZoomIn']}).Render()`|
| Toolbar Orientation | Not Applicable | **Property:** *zoomSettings.toolBarOrientation*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{ToolBarOrientation= Syncfusion.EJ2.Maps.Orientation.Horizontal}).Render()`|
| Toolbar Vertical Alignment | Not Applicable | **Property:** *zoomSettings.verticalAlignment*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{VerticalAlignment = Syncfusion.EJ2.Maps.Alignment.Center}).Render()`|
| Toolbar Horizontal Alignment | Not Applicable | **Property:** *zoomSettings.horizontalAlignment*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{HorizontalAlignment=Syncfusion.EJ2.Maps.Alignment.Center}).Render()`|
| Toolbar Highlight Color | Not Applicable | **Property:** *zoomSettings.highlightColor*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{HighlightColor="#e61576"}).Render()`|
| Toolbar Selection Color | Not Applicable | **Property:** *zoomSettings.selectionColor*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{SelectionColor="#e61576"}).Render()`|
| Toolbar Fill Color | Not Applicable | **Property:** *zoomSettings.color*<br/><br/> `@Html.EJS().Maps("container").ZoomSettings(new Syncfusion.EJ2.Maps.MapsZoomSettings{Color="#e61576"}).Render()`|

## Highlight And Selection Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Highlight Fill | **Property:** *layers.shapeSettings.highlightColor*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(sp =>{sp.HighlightColor('green') })}))`| **Property:** *fill*<br/><br/> l`@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{HighlightSettings = new MapsHighlightSettings{Fill='red'}}).Render()`|
| Enable Highlight | **Property:** *layers.enableMouseHover*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.EnableMouseHover(true)}))`| **Property:** *enable*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{HighlightSettings = new MapsHighlightSettings{Enable=true}}).Render()`|
| Highlight Border Color | **Property:** *layers.shapeSettings.highlightStroke*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(sp =>{sp.HighlightStroke('red')})}))`| **Property:** *layers.highlightSettings.border.color*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{HighlightSettings = new MapsHighlightSettings{Border={Color='green'}}}).Render()`|
| Highlight Border Width | **Property:** *layers.shapeSettings.highlightBorderWidth*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(sp =>{sp.HighlightBorderWidth=('2')})}))`| **Property:** *layers.highlightSettings.border.width*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{HighlightSettings = new MapsHighlightSettings{Border={Width=2}}}).Render()`|
| Highlight Opacity | Not Applicable | **Property:** layers.*layers.highlightSettings.opacity*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{HighlightSettings = new MapsHighlightSettings{Opacity=0.3}}).Render()`|
| Selection Fill | **Property:** *layers.shapeSettings.selectionColor*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(sp =>{sp.SelectionColor('blue')})}))`| **Property:** *layers.selectionSettings.fill*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{SelectionSettings = new MapsSelectionSettings{Fill='red'}}).Render()`|
| Selection Enable | **Property:** *layers.enableSelection*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.EnableSelection(true)}))`| **Property:** *layers.selectionSettings.enable*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{SelectionSettings = new MapsSelectionSettings{Enable= true}}).Render()`|
| Selection Border Width | **Property:** *layers.selectionSettings.selectionStrokeWidth*<br/><br/> `@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(sp =>{sp.SelectionStrokeWidth(2)})}))`| **Property:** *layers.selectionSettings.border.width*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{SelectionSettings = new MapsSelectionSettings{Border={Width=2}}}).Render()`|
| Selection Border Color | **Property:** *layers.selectionSettings.selectionStroke*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.ShapeSettings(sp =>{sp.SelectionStroke("white")})}))`| **Property:** *layers.selectionSettings.border.color*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{SelectionSettings = new MapsSelectionSettings{Border={Color='red'}}}).Render()`|
| Selection Opacity | Not Applicable | **Property:** *layers.selectionSettings.opacity*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{SelectionSettings = new MapsSelectionSettings{Opacity=0.3}}).Render()`|

## Navigation Line Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Visible | Not Applicable | **Property:** *layers.navigationLineSettings.visible*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{ visible: true}}`|
| Width | Not Applicable | **Property:** *layers.navigationLineSettings.width*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{width:2}}`|
| Longitude | Not Applicable | **Property:** *layers.navigationLineSettings.longitude*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{longitude: [-97.8717041015625, -89.6649169921875]}}`|
| Latitude | Not Applicable | **Property:** *layers.navigationLineSettings.latitude*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{Latitude= [22.403410892712124, 21.282336521195344] }}`|
| DashArray | Not Applicable | **Property:** *layers.navigationLineSettings.dashArray*<br/><br/>`@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{dashArray:"1,2"}}`|
| Color | Not Applicable | **Property:** *layers.navigationLineSettings.color*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{color:"green"}}`|
| Angle | Not Applicable | **Property:** *layers.navigationLineSettings.angle*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{angle:180}}`|
| Arrow Position | Not Applicable | **Property:** *layers.navigationLineSettings.arrow.position*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{arrow:{ position:"start" }}}`|
| Show Arrow | Not Applicable | **Property:** *layers.navigationLineSettings.arrow.showArrow*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{arrow:{ showArrow:true }}}`|
| Arrow size | Not Applicable | **Property:** *layers.navigationLineSettings.arrow.size*<br/><br/>`@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{ arrow:{ size:2 }}}`|
| Arrow Color | Not Applicable | **Property:** *layers.navigationLineSettings.arrow.color*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{arrow:{ color:'red' }}}`|
| Arrow Offset | Not Applicable | **Property:** *layers.navigationLineSettings.arrow.offSet*<br/><br/> `@Html.EJS().Maps("container").Render()`<br/>`function mapsLoad(args){args.maps.layers[0].navigationLineSettings{arrow:{ offSet:10 }}}`|

## Tooltip Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Tooltip Enable | **Property:** *layers.showTooltip*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.ShowTooltip(true)}))` | **Property:** *layers.tooltipSettings.visible*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{Visible= true }}}).Render()`|
| Tooltip Template | **Property:** *layers.tooltipTemplate*<br/><br/>`@(Html.EJ().Map("container").Layers(lr =>{lr.ToolTipTemplate('myTooltip').Add}))`| **Property:** *layers.tooltipSettings.visible*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{Template='tremplate'}}}).Render()`|
| Value Path | Not Applicable | **Property:** *layers.tooltipSettings.valuePath*<br/><br/>`@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{ValuePath = "State"}}}).Render()`|
| Format | Not Applicable | **Property:** *layers.tooltipSettings.format*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{Format='${State}}}}).Render()`|
| Border Color | Not Applicable | **Property:** *layers.tooltipSettings.border.color*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{Border={ color:'red' } }}}).Render()`|
| Border Width | Not Applicable | **Property:** *layers.tooltipSettings.border.width*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{Border={ width:'' }}}}).Render()`|
| Text Style | Not Applicable | **Property:** *layers.tooltipSettings.textStyle*<br/><br/> `@Html.EJS().Maps("container").Layers(new List<Syncfusion.EJ2.Maps.MapsLayer>{ new Syncfusion.EJ2.Maps.MapsLayer{ TooltipSettings = new MapsTooltipSettings{TextStyle= { Size="15px", Color="red", FontFamily="arial", FontWeight="bold", FontStyle="normal", Opacity=0.8 }}}}).Render()`|

## Annotation Cutomization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Content | Not Applicable | **Property:** *legendSettings.annotations.content*<br/><br/> `@Html.EJS().Maps("container")Load("mapsLoad").Render()`<br/>`function mapsLoad(args){args.maps.annotations=[{ content:'USA Population 2018}]}`|
| Location X | Not Applicable | **Property:** *legendSettings.annotations.x*<br/><br/> `@Html.EJS().Maps("container")Load("mapsLoad").Render()`<br/>`function mapsLoad(args){args.maps.annotations=[{x:'250px' }]}`|
| Location Y | Not Applicable | **Property:** *legendSettings.annotations.y*<br/><br/> `@Html.EJS().Maps("container")Load("mapsLoad").Render()`<br/>`function mapsLoad(args){args.maps.annotations=[{ y:'150px'}]}`|
| Vertical Alignment | Not Applicable | **Property:** *legendSettings.annotations.verticalAlignment*<br/><br/> `@Html.EJS().Maps("container")Load("mapsLoad").Render()`<br/>`function mapsLoad(args){args.maps.annotations=[{verticalAlignment:'Center'}]}`|
| Horizontal Alignment | Not Applicable | **Property:** *legendSettings.annotations.horizontalAlignment*<br/><br/> `@Html.EJS().Maps("container")Load("mapsLoad").Render()`<br/>`function mapsLoad(args){args.maps.annotations=[{horizontalAlignment:'Center'}]}`|
| Zindex | Not Applicable | **Property:** *legendSettings.annotations.zIndex*<br/><br/> `@Html.EJS().Maps("container")Load("mapsLoad").Render()`<br/>`function mapsLoad(args){args.maps.annotations=[{ zIndex:'-1' }]}`|

## Maps Other Properties Customization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Projection Type | Not Applicable | **Property:** *projectionType*<br/><br/> `@Html.EJS().Maps("container").ProjectionType(ProjectionType.Eckert3).Render()`|
| Background | **Property:** *background*<br/><br/>`@Html.EJ().Maps("container").Background('red'))`| **Property:** *background*<br/><br/> `@Html.EJS().Maps("container").Background("red").Render()`|
| Enable Group Separator | **Property:** *enableGroupSeparator*<br/><br/> `@Html.EJ().Maps("container").UseGroupingSeparator(true))`| **Property:** *useGroupingSeparator*<br/><br/> `@Html.EJS().Maps("container").UseGroupingSeparator(true).Render()`|
| Base Layer Index | **Property:** *baseMapIndex*<br/><br/> `@Html.EJ().Maps("container").BaseLayerIndex(1))`| **Property:** *baseLayerIndex*<br/><br/>  `@Html.EJS().Maps("container").BaseLayerIndex(1).Render()`|
| locale | **Property:** *locale*<br/><br/> `@(Html.EJ().Map("container").Locale('en-us')` | Not Applicable |
| Responsive | **Property:** *isResponsive*<br/><br/> `@(Html.EJ().Map("container").IsResponsivet(true)`| Not Applicable |
| Enable Pan | **Property:** *enablePan*<br/><br/> `@(Html.EJ().Map("container").EnablePan(true)`| Not Applicable |
| Enable Navigation | **Property:** *navigationControl.enableNavigation*<br/><br/>  `@(Html.EJ().Map("container").NavigationControl(new{ enableNavigation=true })`| Not Applicable |
| Navigation Orientation | **Property:** *navigationControl.orientation*<br/><br/> `@(Html.EJ().Map("container").NavigationControl(new{ orientation='vertical' })`| Not Applicable |
| Navigation Dock Position | **Property:** *navigationControl.dockPosition*<br/><br/>`@(Html.EJ().Map("container").NavigationControl(new{ dockPosition='centerleft' })`| Not Applicable |
| Navigation Absolute Position | **Property:** *navigationControl.absolutePosition*<br/><br/> `@(Html.EJ().Map("container").NavigationControl(new{ absolutePosition={ x: 100, y : 100 }  })`| Not Applicable |
| Dragging Selection | **Property:** *draggingOnSelection*<br/><br/> `@(Html.EJ().Map("container").DraggingOnSelection(true)`| Not Applicable |
| Resize | **Property:** *enableResize*<br/><br/>`@(Html.EJ().Map("container").EnableResize(true))`| Not Applicable |
| Enable Animation | **Property:** *enableAnimation*<br/><br/> `@(Html.EJ().Map("container").EnableAnimation(true))`| Not Applicable |
| Enable Layer Animation | **Property:** *enableLayerChangeAnimation*<br/><br/>`@(Html.EJ().Map("container").EnableLayerChangeAnimation(true))`| Not Applicable |
| Center Position | **Property:** *centerPosition*<br/><br/> `@Html.EJS().Maps("container").CenterPosition(new { latitude = 35.65, longitude = -97.3 }))`| **Property:** *centerPosition*<br/><br/> `@Html.EJS().Maps("container").CenterPosition(new { latitude = 35.65, longitude = -97.3 }).Render()`|

## Events

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| Shape Selected | **Property:** *shapeSelected*<br/><br/>`@(Html.EJ().Map("container").ShapeSelected("shapeSelected"))`<br/>`function shapeSelected(args){}`| **Property:** *shapeSelected*<br/><br/> `@Html.EJS().Maps("container").ShapeSelected("shapeSelected").Render()`<br/>`function shapeSelected(args){}`|
| Marker Selected | **Property:** *markerSelected*<br/><br/> `@(Html.EJ().Map("container").MarkerClick("markerClick"))`<br/>`function markerClick(args){}` | **Property:** *markerClick*<br/><br/> `@Html.EJS().Maps("container").Load("mapLoad").Render()`<br/>`function mapLoad(args){}`|
| Marker Move | **Property:** *markerEnter*<br/><br/> `@(Html.EJ().Map("container"). MarkerClick(" markerClick"))`<br/>`function  markerClick(args){}`| **Property:** *markerMouseMove*<br/><br/> `@Html.EJS().Maps("container").Load("mapLoad").Render()`<br/>`function mapLoad(args){}`|
| Marker Leave | **Property:** *markerLeave*<br/><br/> `@(Html.EJ().Map("container").MarkerLeave("markerLeave"))`<br/>`function markerLeave(args){}`| Not Applicable |
| Legend Item Rendering | **Property:** *legendItemRendering*<br/><br/> `@(Html.EJ().Map("container").LegendItemRendering("legendItemRendering"))`<br/>`function legendItemRendering(args){}`| Not Applicable |
| Display Text Rendering | **Property:** *displayTextRendering*<br/><br/> `@(Html.EJ().Map("container").DisplayTextRendering("displayTextRendering"))`<br/>`function displayTextRendering(args){}`| **Property:** *dataLabelRendering*<br/><br/> `@Html.EJS().Maps("container").DataLabelRendering("dataLabelRendering").Render()`<br/>`function dataLabelRendering(args){}`|
| Legend Item Click | **Property:** *legendItemClick*<br/><br/>`@(Html.EJ().Map("container").LegendItemClick("legendItemClick"))`<br/>`function legendItemClick(args){}`| Not Applicable |
| Bubble Rendering | **Property:** *bubbleRendering*<br/><br/>`@(Html.EJ().Map("container").BubbleRendering("bubbleRendering"))`<br/>`function bubbleRendering(args){}`| **Property:** *bubbleRendering*<br/><br/> `@Html.EJS().Maps("container").BubbleRendering("bubbleRendering").Render()`<br/>`function bubbleRendering(args){}`|
| Shape Rendering | **Property:** *shapeRendering*<br/><br/> `@(Html.EJ().Map("container").ShapeRendering("shapeRendering"))`<br/>`function shapeRendering(args){}` | **Property:** *shapeRendering*<br/><br/> `@Html.EJS().Maps("container").ShapeRendering("shapeRendering").Render()`<br/>`function shapeRendering(args){}`|
| Zoomed In | **Property:** *zoomedIn*<br/><br/> `@(Html.EJ().Map("container"). ZoomedIn("zoomedIn"))`<br/>`function zoomedIn(args){}`| Not Applicable |
| Render Completed | **Property:** *onRenderComplete*<br/><br/> `@(Html.EJ().Map("container").OnRenderComplete("onRenderComplete"))`<br/>`function onRenderComplete(args){}`| **Property:** *loaded*<br/><br/> `@Html.EJS().Maps("container").Click("click").Render()`<br/>`function click(args){}`|
| Panned | **Property:** *panned*<br/><br/> `@(Html.EJ().Map("container").Panned("panned"))`<br/>`function panned(args){}`| Not Applicable |
| zoomed Out | **Property:** *zoomedOut*<br/><br/>`@(Html.EJ().Map("container").ZoomedOut("zoomedOut"))`<br/>`function zoomedOut(args){}` | Not Applicable |
| Mouse Over | **Property:** *mouseover*<br/><br/> `@(Html.EJ().Map("container").Mouseover("mouseover"))`<br/>`function mouseover(args){}`| Not Applicable |
| Mouse Leave | **Property:** *mouseleave*<br/><br/>`@(Html.EJ().Map("container").MouseLeave("mouseLeave"))`<br/>`function mouseLeave(args){}`| Not Applicable |
| Click | **Property:** *click*<br/><br/> `@(Html.EJ().Map("container").Click("click"))`<br/>`function markerSelected(args){}`|
| Double Click | **Property:** *doubleClick*<br/><br/>`@(Html.EJ().Map("container"). DoubleClick("doubleClick"))`<br/>`function doubleClick(args){}`| **Property:** *doubleClick*<br/><br/> `@Html.EJS().Maps("container").DoubleClick("doubleClick").Render()`<br/>`function doubleClick(args){}`|
| Right Click | **Property:** *rightClick*<br/><br/> `@(Html.EJ().Map("container").RightClick("rightClick"))`<br/>`function rightClick(args){}`| **Property:** *rightClick*<br/><br/> `@Html.EJS().Maps("container").RightClick("rightClick").Render()`<br/>`function rightClick(args){}`|
| Initial Load | **Property:** *onLoad*<br/><br/> `@(Html.EJ().Map("container"). OnLoad("onLoad"))`<br/>`function onLoad(args){}`| **Property:** *load*<br/><br/> `@Html.EJS().Maps("container").Load("mapLoad").Render()`<br/>`function mapLoad(args){}`|
| Before Print | Not Applicable | **Property:** *beforePrint*<br/><br/> `@Html.EJS().Maps("container").BeforePrint("beforePrint").Render()`<br/>`function beforePrint(args){}`|
| Resize | Not Applicable | **Property:** *resize*<br/><br/> `@Html.EJS().Maps("container").Resize("resize").Render()`<br/>`function resize(args){}`|
| Tooltip Render | Not Applicable | **Property:** *tooltipRender*<br/><br/>`@Html.EJS().Maps("container").TooltipRender("tooltipRender").Render()`<br/>`function tooltipRender(args){}`|
| Item Selection | Not Applicable | **Property:** *itemSelection*<br/><br/> `@Html.EJS().Maps("container").ItemSelection("itemSelection").Render()`<br/>`function itemSelection(args){}`|
| Item Highlight | Not Applicable | **Property:** *itemHighlight*<br/><br/> `@Html.EJS().Maps("container").ItemHighlight("itemHighlight").Render()`<br/>`function itemHighlight(args){}`|
| Shape Highlight | Not Applicable | **Property:** *shapeHighlight*<br/><br/> `@Html.EJS().Maps("container").ShapeHighlight("shapeHighlight").Render()`<br/>`function shapeHighlight(args){}`|
| Layer Rendering | Not Applicable | **Property:** *layerRendering*<br/><br/> `@Html.EJS().Maps("container").LayerRendering("layerRendering").Render()`<br/>`function layerRendering(args){}`|
| Marker Rendering | Not Applicable | **Property:** *markerRendering*<br/><br/> `@Html.EJS().Maps("container").MarkerRendering("markerRendering").Render()`<br/>`function markerRendering(args){}`|
| Bubble Mouse Move | Not Applicable | **Property:** *bubbleMouseMove*<br/><br/> `@Html.EJS().Maps("container").BubbleMouseMove("bubbleMouseMove").Render()`<br/>`function bubbleMouseMove(args){}`|
| Bubble Mouse Move | Not Applicable | **Property:** *annotationRendering*<br/><br/> `@Html.EJS().Maps("container").AnnotationRendering("annotationRendering").Render()`<br/>`function annotationRendering(args){}`|
| Animation Complete | Not Applicable | **Property:** *animationComplete*<br/><br/> `@Html.EJS().Maps("container").AnimationComplete("animationComplete").Render()`<br/>`function animationComplete(args){}`|