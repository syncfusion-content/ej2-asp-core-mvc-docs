---
title: "Migration from Essential JS 1"
component: "TreeMap"
description: "Explains the common steps for migrating from Essential JS 1 application to Essential JS 2 components especially, treemap component."
---

# Migration from Essential JS 1

This article describes the API migration process of Accordion component from Essential JS 1 to Essential JS 2.

## Data Binding

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Datasource| **Property:** *dataSource*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`DataSource(datasource)`<br/>`.WeightValuePath("population"))`<br>&nbsp;`@section ControlsSection{@{ var datasource = ViewData["medals"];}`<br><br>**script**:<br><br>`public ActionResult Customization()`<br/>`{ViewData["medals"] = MedalData.GetPopulation();`<br/>`return View();}public class MedalData{`<br/>`public static List<MedalData> GetPopulation()`<br/>`List<MedalData> medals = new List<MedalData>();`<br/>`medals.Add(new MedalData(){`<br/>`Continent: "Asia", Population: 1749046000} return medals; }}`|**Property:** *dataSource*<br/>`@Html.EJS().TreeMap("container")`<br/>`.Load("load")`<br/>`.LayoutType(LayoutMode.Squarified).Render();`<br/>`function load(args)`<br/>`{var data=[{ Continent: "Asia", Population: 1749046000}];`<br/>`args.treemap.dataSource = data;}`|

## Appearance

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Layout| **Property:** *itemsLayoutMode*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`ItemsLayoutMode("SliceAndDiceAuto"))`|**Property:** *layoutType*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LayoutType(LayoutMode.Squarified)`<br/>`.Render();`|
|Weight Value Path| **Property:** *weightValuePath*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.WeightValuePath("Population"))`|**Property:** *weightValuePath*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.WeightValuePath("Population")`<br/>`.Render();`|
|Range Color Value Path| **Property:** *colorValuePath*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.ColorValuePath("Continent") )`|**Property:** *rangeColorValuePath*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.ColorValuePath("Continent")`<br/>`.Render();`|
|Equal Color Value Path| Not Applicable|**Property:** *equalColorValuePath*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`equalColorValuePath('Asia').Render();`|
|Height| **Property:** *height*<br/><br/>`@(Html.EJ().TreeMap("container").Height(50))`|**Property:** *height*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`Height('50px')`<br/>`.Render();`|
|Width| **Property:** *width*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`Width(400))`|**Property:** *width*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`Width('400px')`<br/>`.Render();`|
|Theme| Not Applicable|**Property:** *theme*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`theme('Highcontrast').Render();`|
|Localization| **Property:** *locale*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`Locale("en-US")`|**Property:** *locale*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`Locale("en-US")`<br/>`.Render();`|
|Palette Colors| **Property:** *paletteColorMapping.colors*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapPaletteColorMapping(`<br/>`colors(['red','green'] )`|**Property:** *palette*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`Palette(new string[]`<br/>`{'#C33764', '#AB3566'})`<br/>`.Render();`|
|Margin| Not Applicable|**Property:** *margin*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`Margin(mar=>mar.`<br/>`left(10).top('10'))`<br/>`.Render();`|
|Resize| **Property:** *enableResize*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`enableResize(true)`|Not Applicable|
|Responsive| **Property:** *isResponsive*<br/>`@(Html.EJ().TreeMap("container").`<br/>`isResponsive(true))`|Not Applicable|

## Leaf Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Border Color| **Property:** *leafItemSettings.borderBrush*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.LeafItemsSetting(lls =>{ lls.showLabels(true)`<br/>`.borderBrush("blue")`<br/>`})`|**Property:** *leafItemSettings.border*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf => leaf.Border(new TreeMapBorder`<br/>`{ Color = "white", Width = 0.5 })`<br/>`)`<br/>`.Render();`|
|Border Width| **Property:** *leafItemSettings.borderThickness*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.LeafItemsSetting(lls =>{ lls.showLabels(true) .borderThickness(5)`<br/>`})`|**Property:** *leafItemSettings.border*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>leaf.Border(new TreeMapBorder`<br/>`{  Width = 0.5 })`<br/>`)`<br/>`.Render();`|
|Gap Value| **Property:** *leafItemSettings.gap*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.LeafItemsSetting(lls =>{ lls.showLabels(true)`<br/>`.gap(5)`<br/>`})`|**Property:** *leafItemSettings.gap*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =><br/>leaf.Gap(5)`<br/>`)`<br/>`.Render();`|
|Leaf Item Label| **Property:** *leafItemSettings.itemTemplate*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.LeafItemsSetting(lls =>{lls.showLabels(true)`<br/>`.ItemTemplate("template")`<br/>`})`|**Property:** *leafItemSettings.labelTemplate*<br/>`@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.LabelTemplate('template')`<br/>`).Render();`|
|Leaf Label Path| **Property:** *leafItemSettings.labelPath*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.LeafItemsSetting(lls =>{ lls.showLabels(true)`<br/>`.LabelPath("GameName")`<br/>`})`|**Property:** *leafItemSettings.labelPath*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`.LabelPath('GameName') ).Render();`|
|Leaf Label Position| **Property:** *leafItemSettings.labelPosition*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.LeafItemsSetting(lls =>{ lls.showLabels( true)`<br/>`labelPosition: "topcenter"`<br/>`})`|**Property:** *leafItemSettings.labelPosition*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.LabelPosition('Center')`<br/>`)`<br/>`.Render();`|
|Leaf Label Color| Not Applicable|**Property:** *leafItemSettings.fill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.Fill('red')`<br/>`)`<br/>`.Render();`|
|Random Colors| Not Applicable|**Property:** *leafItemSettings.autoFill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.AutoFill(true)`<br/>`)`<br/>`.Render();`|
|Format| Not Applicable|**Property:** *leafItemSettings.labelFormat*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.LabelFormat('${Continent}-${Population}')<br/>).Render();`|
|Labels Visibility| **Property:** *leafItemSettings.showLabels*<br/><br/>`@(Html.EJ().TreeMap("container")`<br>&nbsp;`.LeafItemsSetting(lls =>{`<br>&nbsp;`lls.ShowLabels(true)`<br/>`})`|**Property:** *leafItemSettings.showLabels*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.ShowLabels(false)`<br/>`)`<br/>`.Render();`|
|Opacity| Not Applicable|**Property:** *leafItemSettings.opacity *<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.Opacity(0.7))`<br/>`.Render();`|
|Padding| Not Applicable|**Property:** *leafItemSettings.padding *<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.Padding(5) )`<br/>`.Render();`|
|Font Customization| Not Applicable|**Property:** *leafItemSettings.labelStyle*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.LabelStyle(new`<br/>`TreeMapFont {size= '12px', color= 'red', opacity= 0.5  })`<br/>`)`<br/>`.Render();`|
|Position of Template| Not Applicable|**Property:** *leafItemSettings.templatePosition*<br/>`@Html.EJS().TreeMap("container")`<br/>`.LeafItemSettings(`<br/>`leaf =>`<br/>`leaf.TemplatePosition('Center')`<br/>`)`<br/>`.Render();`|

## Legend

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Legend Alignment| **Property:** *legendSettings.alignment*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.Alignment("far")`<br/>`})`|**Property:** *legendSettings.alignment*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=> t1.Alignment("far")`<br/>`).Render();`|
|Legend Visibility| **Property:** *showLegend*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.ShowLegend(false)`<br/>`})`|**Property:** *legendSettings.visible*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.ShowLegend(false)`<br/>`).Render();`|
|Legend Position| **Property:** *legendSettings.dockPosition*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.DockPosition("bottom")`<br/>`})`|**Property:** *legendSettings.position*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=> t1.position('Top')`<br/>`).Render();`|
|Legend Height| **Property:** *legendSettings.height*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.Height(100)`<br/>`})`|**Property:** *legendSettings.height*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=> t1.Height('100px')`<br/>`).Render();`|
|Legend Width| **Property:** *legendSettings.width*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.Width(100)`<br/>`})`|**Property:** *legendSettings.width*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=> t1.Width('100')`<br/>`).Render();`|
|Shape Height| **Property:** *legendSettings.iconHeight*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.IconHeight(15)`<br/>`})`|**Property:** *legendSettings.shapeHeight*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=> t1.ShapeHeight('40px')`<br/>`).Render();`|
|Shape Width| **Property:** *legendSettings.iconWidth*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.IconWidth(8)`<br/>`})`|**Property:** *legendSettings.shapeWidth*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.ShapeWidth('40px')`<br/>`).Render();`|
|Padding| Not Applicable|**Property:** *legendSettings.shapePadding*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=> t1.ShapePadding (10)`<br/>`).Render();`|
|Legend Title| **Property:** *legendSettings.title*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.Title("Population")`<br/>`})`|**Property:** *legendSettings.title*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.Title('Legend')`<br/>`).Render();`|
|Legend Shape| Not Applicable|**Property:** *legendSettings.shape*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.Shape('Rectangle')`<br/>`).Render();`|
|Legend Mode| **Property:** *legendSettings.mode*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.mode("interactive")`<br/>`})`|**Property:** *legendSettings.mode*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.mode("interactive")`<br/>`).Render();`|
|Legend Text Customization| Not Applicable|**Property:** *legendSettings.textStyle*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`legend=>legend.TextStyle(new TreeMapFont`<br/>`{ Size= "10px", Opacity= 0.5, Color= "red"`<br/>`})`<br/>`).Render();`|
|Legend Title Customization| Not Applicable|**Property:** *legendSettings.titleStyle*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`legend=>`<br/>`legend.TitleStyle(new TreeMapFont`<br/>`{ Size= "10px", Opacity= 0.5, Color= "red" })`<br/>`).Render();`|
|Legend Shape Border| Not Applicable|**Property:** *legendSettings.shapeBorder*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`legend.ShapeBorder(new TreeMapBorder`<br/>`{ Color= "red", Width= 1 })`<br/>`).Render();`|
|Legend Template| **Property:** *legendSettings.template*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.template("template")`<br/>`})`| Not Applicable|
|Left Label| **Property:** *legendSettings.leftLabel*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.Mode("interactive")`<br/>`.LeftLabel("10Million")`<br/>`})`| Not Applicable|
|Right Label| **Property:** *legendSettings.rightLabel*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.TreeMapLegend(t1=>{t1.Mode("interactive")`<br/>`.LeftLabel("10Million")`<br/>`})`| Not Applicable|
|Legend Shape Image| Not Applicable|**Property:** *legendSettings.imageUrl*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.ImageUrl('')`<br/>`).Render();`|
|Position in Intractive Legend| Not Applicable|**Property:** *legendSettings.labelPosition*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.LabelPosition("Center")`<br/>`).Render();`|
|Legend Location| Not Applicable|**Property:** *legendSettings.location*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.Location({ x=10, y= 20 })`<br/>`).Render();`|
|Legend Orientation| Not Applicable|**Property:** *legendSettings.orientation*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.LegendSettings(`<br/>`t1=>t1.Orientation("Horizontal")`<br/>`).Render();`|

## Levels

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Random Colors| Not Applicable|**Property:** *levels.autoFill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.AutoFill(true)`<br/>`).Render();`|
|Level Background Color| **Property:** *levels.groupBackground*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.GroupBackground("white")`<br/>`})`| **Property:** *levels.fill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=> l1.Fill('white')`<br/>`).Render();`|
|Level Border Color| **Property:** *levels.groupBorderColor*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.Levels(l1=>`<br/>`l1.GroupBorderColor("#58585B") {`<br/>`})`| **Property:** *levels.border.color*<br/>`@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.Border(new TreeMapBorder{color ='black'})`<br/>`).Render();`|
|Level Border Width| **Property:** *levels.groupBorderThickness*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.GroupBorderThickness(2)`<br/>`})`| **Property:** *levels.border.width*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.Border(new TreeMapBorder{width =0.5})`<br/>`).Render();`|
|Group Gap| **Property:** *levels.groupGap*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.groupGap(2)`<br/>`})`| **Property:** *levels.groupGap*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.GroupGap(2)`<br/>`).Render();`|
|Group Padding| **Property:** *levels.groupPadding*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`l1.GroupPadding(1){`<br/>`})`| **Property:** *levels.groupPadding*<br/>`@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=> l1.GroupPadding(1)`<br/>`).Render();`|
|Group Path| **Property:** *levels.groupPath*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.GroupPath("pathname")`<br/>`})`| **Property:** *levels.groupPath*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.GroupPath("pathname")`<br/>`).Render();`|
|Height of Header Level| **Property:** *levels.headerHeight*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.HeaderHeight(20)`<br/>`})`| **Property:** *levels.headerHeight*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.HeaderHeight(20)`<br/>`).Render();`|
|Header Template| **Property:** *levels.headerTemplate*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.HeaderTemplate("template")`<br/>`})`| **Property:** *levels.headerTemplate*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=> l1.HeaderTemplate("template")`<br/>`).Render();`|
|Opacity of Color| Not Applicable| **Property:** *levels.opacity*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.Opacity(0.5)`<br/>`).Render();`|
|Header Visibility| **Property:** *levels.showHeader*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.ShowHeader(false)`<br/>`})`| **Property:** *levels.showHeader*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.ShowHeader(false)`<br/>`).Render();`|
|Template Position| **Property:** *levels.labelPosition*<br/><br/>`@(Html.EJ().TreeMap("container").`<br/>`.Levels(l1=>`<br/>`{l1.labelPosition("topleft")`<br/>`})`| **Property:** *levels.templatePosition*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.TemplatePosition('Center')`<br/>`).Render();`|
|Header Style| Not Applicable| **Property:** *levels.headerStyle*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.HeaderStyle(new TreeMapFont {`<br/>`Color= 'red', Size= '16px', Opacity= 0.7 })`<br/>`).Render();`|
|Header Format| Not Applicable| **Property:** *levels.headerFormat*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=>l1.HeaderFormat('${Continent}')`<br/>`).Render();`|
|Header Alignment| Not Applicable| **Property:** *levels.headerAlignment*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Levels(`<br/>`l1=> l1.HeaderAlignment('Center')`<br/>`).Render();`|

## Selection

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Selection| **Property:** *selectionMode*<br/><br/> `@(Html.EJ().TreeMap("container").`<br/>`.selectionMode("default"))`| **Property:** *selectionSettings.mode*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.SelectionSettings(`<br/>`selectionSettings=>`<br/>`selectionSettings.Enable(true).Mode('Item')`<br/>`).Render();`|
|Selection Color| Not Applicable| **Property:** *selectionSettings.fill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.SelectionSettings(`<br/>`selectionSettings=>`<br/>`selectionSettings.Enable(true).Fill('blue')`<br/>`).Render();`|
|Selection Color Opacity| Not Applicable| **Property:** *selectionSettings.opacity*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.SelectionSettings(`<br/>`selectionSettings=>`<br/>`selectionSettings.Enable(true)`<br/>`.Opacity('0.5')`<br/>`).Render();`|
|Border for selection| Not Applicable| **Property:** *selectionSettings.border*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.SelectionSettings(`<br/>`selectionSettings=>`<br/>`selectionSettings.Enable(true).Border(new TreeMapBorder{`<br/>`Color= 'red', Width=2 })`<br/>`).Render();`|

## Hightlight

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Highlight Group Selection Mode| **Property:** *highlightGroupOnSelection*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.highlightGroupOnSelection(true))`| **Property:** *highlightSettings.mode*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`HighlightSettings`<br/>`(highlight =>`<br/>`highlight.Enable(true)`<br/>`.Mode('All')`<br/>`).Render();`|
|Highlight Selection Mode| **Property:** *highlightOnSelection*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.highlightOnSelection(true)`| **Property:** *highlightSettings.mode*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`HighlightSettings`<br/>`(highlight =>`<br/>`highlight.Enable(true)`<br/>`Mode('Item')`<br/>`).Render();`|
|Highlight Group Border Color| **Property:** *highlightGroupBorderBrush*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.highlightGroupBorderBrush('gray')`| **Property:** *highlightSettings.border.color*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`HighlightSettings`<br/>`(highlight =>`<br/>`highlight.Enable(true)`<br/>`.Mode('All')`<br/>`.Border(new TreeMapBorder`<br/>`{color="red"}).Render();`|
|Highlight Group Border Width| **Property:** *highlightGroupBorderThickness*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.highlightGroupBorderThickness(3)`| **Property:** *highlightSettings.border.width*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`HighlightSettings`<br/>`(highlight =>`<br/>`highlight.Enable(true)`<br/>`).Mode('All')`<br/>`.Border(new TreeMapBorder`<br/>`{Width=0.8}).Render();`|
|Highlight Color| Not Applicable| **Property:** *highlightSettings.fill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`HighlightSettings`<br/>`(highlight =>`<br/>`highlight.Enable(true)`<br/>`.Fill('red')`<br/>`).Render();`|
|Highlight Color Opacity| Not Applicable| **Property:** *highlightSettings.opacity*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`HighlightSettings`<br/>`(highlight =>`<br/>`highlight.Enable(true)`<br/>`Fill('red')`<br/>`.Opacity(0.5)).Render();`|

## Range ColorMapping

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|From value| **Property:** *rangeColorMapping.from*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.TreeMapRangeColorMappings(`<br/>`cm =>cm.From(1000)`<br/>`))`| **Property:** *leafItemSettings.colorMapping.from*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`from:1000}`<br/>`}`|
|To value| **Property:** *rangeColorMapping.to*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.TreeMapRangeColorMappings(`<br/>`cm =>cm.To(1000)`<br/>`))`| **Property:** *leafItemSettings.colorMapping.to*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`to:10000}`<br/>`}`|
|Color| **Property:** *rangeColorMapping.color*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.TreeMapRangeColorMappings(`<br/>`cm =>cm.Color('red')`<br/>`))`| **Property:** *leafItemSettings.colorMapping.color*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`color:'red'}`<br/>`}`|
|Legend Label| **Property:** *rangeColorMapping.legendLabel*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.TreeMapRangeColorMappings(`<br/>`cm =>cm.LegendLabel("Growth")`<br/>`))`| **Property:** *leafItemSettings.colorMapping.label*<br/>`@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`label: "Growth"}`<br/>`}`|

## Desaturation ColorMapping

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|From value| **Property:** *desaturationColorMapping.from*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.TreeMapDesaturationColorMapping(`<br/>`cm =>`<br/>`cm.From(1)))`| **Property:** *leafItemSettings.colorMapping.from*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`from:1000`<br/>`} }`|
|To value| **Property:** *desaturationColorMapping.to*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.TreeMapDesaturationColorMapping(`<br/>`cm =>`<br/>`cm.To(0.2)))`| **Property:** *leafItemSettings.colorMapping.to*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`to:10000`<br/>`} }`|
|Color| **Property:** *desaturationColorMapping.color*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.TreeMapDesaturationColorMapping(`<br/>`cm =>`<br/>`cm.color('red')))`| **Property:** *leafItemSettings.colorMapping.color*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`color:'red'`<br/>`} }`|
|Value| Not Applicable| **Property:** *leafItemSettings.colorMapping.value*<br/>`@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`value: "Population"`<br/>`} }`|
|Minimum Opacity| Not Applicable| **Property:** *leafItemSettings.colorMapping.minOpacity*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`minOpacity: 0.7`<br/>`} }`|
|Maximum Opacity| Not Applicable| **Property:** *leafItemSettings.colorMapping.maxOpacity*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`.Load("load").Render();`<br/>`function load(args)`<br/>`{args.treemap.leafItemSettings`<br/>`.colorMapping[0] =`<br/>`{`<br/>`maxOpacity: 0.7}`<br/>`}`|

## Tooltip

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Tooltip| **Property:** *showTooltip*<br/>`@(Html.EJ().TreeMap("container")`<br/>`.ShowTooltip(true))`| **Property:** *tooltipSettings.visible*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{Visible =true}`<br/>`).Render();`|
|Tooltip Template| **Property:** *tooltipTemplate*<br/><br/> `@(Html.EJ().TreeMap("container")`<br/>`.ShowTooltip(true)`<br/>`.TooltipTemplate("template"))`| **Property:** *tooltipSettings.template*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{`<br/>`Visible =true,`<br/>`template='template'}`<br/>`).Render();`|
|Tooltip Border| Not Applicable| **Property:** *tooltipSettings.border*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{`<br/>`Visible=true,`<br/>`Border=(new TreemapBorder{Color='red'}) }`<br/>`).Render();`|
|Tooltip Color| Not Applicable| **Property:** *tooltipSettings.fill*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{`<br/>`Visible =true , Fill='red'}`<br/>`).Render();`|
|Tooltip Format| Not Applicable| **Property:** *tooltipSettings.format*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{`<br/>`Visible =true, Format='${Population}'}`<br/>`).Render();`|
|Tooltip Marker Shape| Not Applicable| **Property:** *tooltipSettings.markerShapes*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{`<br/>`Visible =true, MarkerShapes='Circle' }`<br/>`).Render();`|
|Tooltip Color Opacity| Not Applicable| **Property:** *tooltipSettings.opacity*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings{`<br/>`Visible =true, Opacity: 0.5 }`<br/>`).Render();`|
|Tooltip Text Style| Not Applicable| **Property:** *tooltipSettings.textStyle*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.TooltipSettings(new TreeMapTooltipSettings {`<br/>`Visible =true`<br/>`TextStyle=(new TreeMapFont { Color= 'red', Opacity=0.5, Size= '12px'  })}).Render();`|

## Drilldown

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Drilldown| **Property:** *enableDrillDown*<br/>`@(Html.EJ().TreeMap("container")`<br/>`.EnableDrillDown(true))`| **Property:** *enableDrillDown*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.EnableDrillDown(true).Render();`|
|Drilldown Level| **Property:** *drillDownLevel*<br/>`@(Html.EJ().TreeMap("container")`<br/>`.DrillDownLevel(1))`| **Property:** *InitialDrillSettings.groupIndex*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.EnableDrillDown(true)`<br/>`InitialDrillDown`<br/>`(new TreeMapInitialDrillSettings`<br/>`{ GroupIndex =1}).Render();`|

## Methods

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Treemap Refresh Method| **Method:** *refresh*<br/><br/> `var treemap =` <br/> &nbsp; `$("#container").ejTreeMap("instance");` <br/> `treemap.refresh();`| **Method:** *refresh*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.refresh();`|
|Method to Drilldown| **Method:** *drillDown*<br/><br/> `var treemap =` <br/> &nbsp; `$("#container").ejTreeMap("instance");` <br/> `treemap.drillDown();`|Not Applicable|
|Append to Method| Not Applicable| **Method:** *appendTo*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.appendTo();`|
|Add Event Listener Method| Not Applicable| **Method:** *addEventListener*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.addEventListener();`|
|Treemap Destroy Method| Not Applicable| **Method:** *destroy*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.destroy();`|
|Treemap Exporting Method| Not Applicable| **Method:** *export*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.export();`|
|Get the Module Name| Not Applicable| **Method:** *getModuleName*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.getModuleName();`|
|Printing the Treemap| Not Applicable| **Method:** *print*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.print();`|
|Resizing the Treemap| Not Applicable| **Method:** *resizeOnTreeMap*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.resizeOnTreeMap();`|
|Inject Method (Tooltip)| Not Applicable| **Method:** *resizeOnTreeMap*<br/><br/> `TreeMap.Inject(TreeMapTooltip);` <br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.resizeOnTreeMap();`|
|Remove Event Listener Method| Not Applicable| **Method:** *removeEventListener*<br/><br/> `var treemap =` <br/> &nbsp; `document.getElementById('container').ej2_instances[0];` <br/> `treemap.removeEventListener();`|

## Events

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Treemap Load Event| Not Applicable| **Event:** *load*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`. Load(" load").Render();`<br/>`function itemMove(args)`<br/>`{`<br/>`}`|
|Treemap Loaded Event| Not Applicable| **Event:** *loaded*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Loaded("load").Render();`<br/>`function  load(args)`<br/>`{`<br/>`}`|
|Event Before Print| Not Applicable| **Event:** *beforePrint*<br/><br/>`@Html.EJS().TreeMap("container")`<br/>`.BeforePrint("beforePrint").Render();`<br/>`function beforePrint(args)`<br/>`{`<br/>`}`|
|Click Event| **Event:** *click*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.Click("click"))`<br/>`<script>`<br/>`function click(args)`<br/>`{`<br/>`}`| **Event:** *click*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.Click("click").Render();`<br/>`function click(args)`<br/>`{`<br/>`}`|
|Drill Start Event| **Event:** *drillStarted*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.DrillStarted("drillStarted"))`<br/>`<script>`<br/>`function drillStarted(args)`<br/>`{`<br/>`}`| **Event:** *drillStart*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.DrillStart("drillStart").Render();`<br/>`function drillStart(args)`<br/>`{`<br/>`}`|
|Drill End Event| Not Applicable| **Event:** *drillEnd*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.DrillEnd("drillEnd").Render();`<br/>`function drillEnd(args)`<br/>`{`<br/>`}`|
|Event on Item Click| Not Applicable| **Event:** *itemClick*<br/><br/> `@Html.EJS().TreeMap("container")`<br/>`.ItemClick("itemClick").Render();`<br/>`function itemClick(args)`<br/>`{`<br/>`}`|
|Event Before Print| Not Applicable| **Event:** *beforePrint*<br/><br/>`@Html.EJS().TreeMap("container")`</br>`.BeforePrint("beforePrint").Render();`<br/>`function beforePrint(args)`<br/>`{`<br/>`}`|
|Click Event| **Event:** *click*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.Click("click"))`</br>`<script>`</br>`function click(args)`</br>`{`</br>`}`| **Event:** *click*<br/><br/> `@Html.EJS().TreeMap("container")`</br>`.Click("click").Render();`<br/>`function click(args)`<br/>`{`<br/>`}`|
|Drill Start Event| **Event:** *drillStarted*<br/><br/>`@(Html.EJ().TreeMap("container")`<br/>`.DrillStarted("drillStarted"))`</br>`function drillStarted(args)`</br>`{}`| **Event:** *drillStart*<br/><br/> `@Html.EJS().TreeMap("container")`</br>`.DrillStart("drillStart").Render();`<br/>`function drillStart(args)`<br/>`{`<br/>`}`|
|Drill End Event| Not Applicable| **Event:** *drillEnd*<br/><br/> `@Html.EJS().TreeMap("container")`</br>`.DrillEnd("drillEnd").Render();`<br/>`function drillEnd(args)`<br/>`{`<br/>`}`|
|Event on Item Click| Not Applicable| **Event:** *itemClick*<br/><br/> `@Html.EJS().TreeMap("container").ItemClick("itemClick").Render();`<br/>`function itemClick(args)`<br/>`{`<br/>`}`|
|Treemap Item Select Event| **Event:** *treeMapItemSelected*<br/><br/> `@(Html.EJ().TreeMap("container")` <br/> `.TreeMapItemSelected("treeMapItemSelected"))` <br/> `function treeMapItemSelected(args)`</br>`{` </br> `}`| **Event:** *itemSelected*<br/><br/> `@Html.EJS().TreeMap("container")` <br/> `.ItemSelected("itemSelected").Render();`<br/>`function  itemSelected(args)` <br/> `{` <br/>`}`|
