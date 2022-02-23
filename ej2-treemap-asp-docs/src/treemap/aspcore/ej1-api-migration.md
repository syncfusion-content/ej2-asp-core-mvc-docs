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
|Datasource| **Property:** *dataSource*<br/><br/> `public IActionResult TreeMap() {` <br/> &nbsp; `ViewBag.datasource = [{` <br/> &nbsp; &nbsp; `Continent: "Asia", Population: 1749046000` <br/> &nbsp;`}];` <br/> `}` <br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `datasource="ViewBag.datasource">` <br/> `</ej-tree-map>`|**Property:** *dataSource*<br/><br/> `public IActionResult TreeMap() {` <br/> &nbsp; `ViewBag.datasource = [{` <br/> &nbsp; &nbsp; `Continent: "Asia", Population: 1749046000` <br/> &nbsp;`}];` <br/> `}` <br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `dataSource="ViewBag.dataSource">` <br/> `</ejs-treemap>`|

## Appearance

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Layout| **Property:** *itemsLayoutMode*<br/><br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `items-layout-mode="SliceAndDiceAuto">` <br/> `</ej-tree-map>`|**Property:** *layoutType*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `layoutType="SliceAndDiceAuto">` <br/> `</ejs-treemap>`|
|Weight Value Path| **Property:** *weightValuePath*<br/><br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `weight-value-path="Population">` <br/> `</ej-tree-map>`|**Property:** *weightValuePath*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `weightValuePath="Population">` <br/> `</ejs-treemap>`|
|Range Color Value Path| **Property:** *colorValuePath*<br/><br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `color-value-path="Continent">` <br/> `</ej-tree-map>`|**Property:** *rangeColorValuePath*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `rangeColorValuePath="Continent">` <br/> `</ejs-treemap>`|
|Equal Color Value Path| Not Applicable|**Property:** *equalColorValuePath*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `equalColorValuePath="Asia">` <br/> `</ejs-treemap>`|
|Height| **Property:** *height*<br/><br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `height="50px">` <br/> `</ej-tree-map>`|**Property:** *height*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `height="50px">` <br/> `</ejs-treemap>`|
|Width| **Property:** *width*<br/><br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `width="400px">` <br/> `</ej-tree-map>`|**Property:** *width*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `width="400px">` <br/> `</ejs-treemap>`|
|Theme| Not Applicable|**Property:** *theme*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `theme="Highcontrast">` <br/> `</ejs-treemap>`|
|Localization| Not Applicable|**Property:** *locale*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `locale="en-US">` <br/> `</ejs-treemap>`|
|Palette Colors| **Property:** *paletteColorMapping.colors*<br/><br/> `TreeMapPaletteColorMapping palette =` <br/> &nbsp; `new TreeMapPaletteColorMapping();` <br/> `palette.Colors.Add("green");` <br/> `palette.Colors.Add("red");` <br/> `<ej-tree-map id="treemap"` <br/> &nbsp; `tree-map-palette-color-mapping="palette">` <br/> `</ej-tree-map>`|**Property:** *palette*<br/><br/> `var color =  ['#C33764', '#AB3566'];` <br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `palette="color">` <br/> `</ejs-treemap>`|
|Margin| Not Applicable|**Property:** *margin*<br/><br/> `var margin = new TreeMapMargin {` <br/> &nbsp; `Left = 5, Top = 8` <br/> `};` <br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `margin="margin">` <br/> `</ejs-treemap>`|
|Resize| **Property:** *enableResize*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `enable-resize="true">` <br/> `</ej-treemap>`|Not Applicable|
|Responsive| **Property:** *isResponsive*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `is-responsive="true">` <br/> `</ej-treemap>`|Not Applicable|

## Leaf Items

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Border Color| **Property:** *leafItemSettings.borderBrush*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-leaf-item-settings` <br/> &nbsp; `border-brush="blue"/>` <br/> `</ej-treemap>`|**Property:** *leafItemSettings.border*<br/><br/> `var border = new TreeMapBorder{ Color = "blue"};` <br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `border="border"/>` <br/> `</ejs-treemap>`|
|Border Width| **Property:** *leafItemSettings.borderThickness*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-leaf-item-settings` <br/> &nbsp; `border-thickness="5"/>` <br/> `</ej-treemap>`|**Property:** *leafItemSettings.border*<br/><br/> `var border = new TreeMapBorder{ width = 5};` <br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `border="border"/>` <br/> `</ejs-treemap>`|
|Gap Value| Not Applicable|**Property:** *leafItemSettings.gap*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `gap="5"/>` <br/> `</ejs-treemap>`|
|Leaf Item Label| **Property:** *leafItemSettings.itemTemplate*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-leaf-item-settings` <br/> &nbsp; `show-labels="true"` <br/> &nbsp; `item-template="template"/>` <br/> `</ej-treemap>`|**Property:** *leafItemSettings.labelTemplate*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `labelTemplate="template"/>` <br/> `</ejs-treemap>`|
|Leaf Label Path| **Property:** *leafItemSettings.labelPath*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-leaf-item-settings` <br/> &nbsp; `show-labels="true"` <br/> &nbsp; `label-path="GaugeName"/>` <br/> `</ej-treemap>`|**Property:** *leafItemSettings.labelPath*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `labelPath="GaugeName"/>` <br/> `</ejs-treemap>`|
|Leaf Label Position| **Property:** *leafItemSettings.labelPosition*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-leaf-item-settings` <br/> &nbsp; `show-labels="true"` <br/> &nbsp; `label-position="TopCenter"/>` <br/> `</ej-treemap>`|**Property:** *leafItemSettings.labelPosition*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `labelPosition="Center"/>` <br/> `</ejs-treemap>`|
|Leaf Label Color| Not Applicable|**Property:** *leafItemSettings.fill*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `fill="red"/>` <br/> `</ejs-treemap>`|
|Random Colors| Not Applicable|**Property:** *leafItemSettings.autoFill*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `autoFill="true"/>` <br/> `</ejs-treemap>`|
|Format| Not Applicable|**Property:** *leafItemSettings.labelFormat*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `labelFormat="${Continent}-${Population}"/>` <br/> `</ejs-treemap>`|
|Labels Visibility| **Property:** *leafItemSettings.showLabels*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-leaf-item-settings` <br/> &nbsp; `show-labels="true"/>` <br/> `</ej-treemap>`|**Property:** *leafItemSettings.showLabels*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `showLabels="true"/>` <br/> `</ejs-treemap>`|
|Opacity| Not Applicable|**Property:** *leafItemSettings.opacity*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `opacity="0.7"/>` <br/> `</ejs-treemap>`|
|Padding| Not Applicable|**Property:** *leafItemSettings.padding*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `padding="5"/>` <br/> `</ejs-treemap>`|
|Font Customization| Not Applicable|**Property:** *leafItemSettings.labelStyle*<br/><br/> `var label = new` <br/> &nbsp; `LeafItemSettingsLabelStyleLeafItemSettings {` <br/> &nbsp; `Size = '12px', Color = "red", Opacity = 0.5 };` <br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `labelStyle="label"/>` <br/> `</ejs-treemap>`|
|Position of Template| Not Applicable|**Property:** *leafItemSettings.templatePosition*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-leafitemsettings` <br/> &nbsp; `templatePosition="Center"/>` <br/> `</ejs-treemap>`|

## Legend

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Legend Alignment| **Property:** *legendSettings.alignment*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `alignment="Far"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.alignment*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `alignment="Near"/>` <br/> `</ejs-treemap>`|
|Legend Visibility| **Property:** *showLegend*<br/><br/> `<ej-treemap id="treemap" show-legend="true">` <br/> `</ej-treemap>`|**Property:** *legendSettings.visible*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `visible="true"/>` <br/> `</ejs-treemap>`|
|Legend Position| **Property:** *legendSettings.dockPosition*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `dock-position="Bottom"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.position*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `position="Top"/>` <br/> `</ejs-treemap>`|
|Legend Height| **Property:** *legendSettings.height*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `height="40"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.height*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `height="40px"/>` <br/> `</ejs-treemap>`|
|Legend Width| **Property:** *legendSettings.width*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `width="100"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.width*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `width="100"/>` <br/> `</ejs-treemap>`|
|Shape Height| **Property:** *legendSettings.iconHeight*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `icon-height="15"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.shapeHeight*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `shapeHeight="15"/>` <br/> `</ejs-treemap>`|
|Shape Width| **Property:** *legendSettings.iconWidth*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `icon-width="8"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.shapeWidth*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `shapeWidth="8"/>` <br/> `</ejs-treemap>`|
|Padding| Not Applicable|**Property:** *legendSettings.shapePadding*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `shapePadding="10"/>` <br/> `</ejs-treemap>`|
|Legend Title| **Property:** *legendSettings.title*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `title="Population"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.title*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `title="Population"/>` <br/> `</ejs-treemap>`|
|Legend Shape| Not Applicable|**Property:** *legendSettings.shape*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `shape="Rectangle"/>` <br/> `</ejs-treemap>`|
|Legend Mode| **Property:** *legendSettings.mode*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `mode="Interactive"/>` <br/> `</ej-treemap>`|**Property:** *legendSettings.mode*<br/><br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `mode="Interactive"/>` <br/> `</ejs-treemap>`|
|Legend Text Customization| Not Applicable|**Property:** *legendSettings.textStyle*<br/><br/> `var style = new` <br/> &nbsp; `LegendSettingsTextStyleLegendSettings {` <br/> &nbsp; `Size = '10px', Opacity = 0.5, Color = "red" };` <br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `textStyle="style"/>` <br/> `</ejs-treemap>`|
|Legend Title Customization| Not Applicable|**Property:** *legendSettings.titleStyle*<br/><br/> `var style = new` <br/> &nbsp; `LegendSettingsTitleStyleLegendSettings {` <br/> &nbsp; `Size = '10px', Opacity = 0.5, Color = "red" };` <br/> `<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `titleStyle="style"/>` <br/> `</ejs-treemap>`|
|Legend Shape Border| Not Applicable|**Property:** *legendSettings.shapeBorder*<br/><br/> `var style = new` <br/> &nbsp; `LegendSettingsBorderLegendSettings {` <br/> &nbsp; `Color = "red", Width = 2 };` <br/>`<ejs-treemap id="treemap">` <br/> `<e-treemap-legendsettings` <br/> &nbsp; `shapeBorder="style"/>` <br/> `</ejs-treemap>`|
|Legend Template| **Property:** *legendSettings.template*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `template="template"/>` <br/> `</ej-treemap>`| Not Applicable|
|Left Label| **Property:** *legendSettings.leftLabel*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `left-label="10Million"/>` <br/> `</ej-treemap>`| Not Applicable|
|Right Label| **Property:** *legendSettings.rightLabel*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-legend-settings` <br/> &nbsp; `right-label="100Million"/>` <br/> `</ej-treemap>`| Not Applicable|
|Legend Shape Image| Not Applicable|**Property:** *legendSettings.imageUrl*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-treemap-legendsettings` <br/> &nbsp; `imageUrl="image.png"/>` <br/> `</ej-treemap>`|
|Position in Intractive Legend| Not Applicable|**Property:** *legendSettings.labelPosition*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-legendsettings` <br/> &nbsp; `labelPosition="Before"/>` <br/> `</ejs-treemap>`|
|Legend Orientation| Not Applicable|**Property:** *legendSettings.orientation*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-legendsettings` <br/> &nbsp; `orientation="Horizontal"/>` <br/> `</ejs-treemap>`|

## Levels

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Random Colors| Not Applicable|**Property:** *levels.autoFill*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level autoFill="true"/>` <br/> &nbsp;`</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Level Background Color| **Property:** *levels.groupBackground*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level group-background="white"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.fill*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level fill="white"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Level Border Color| **Property:** *levels.groupBorderColor*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level group-border-color="#58585B"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.border.color*<br/><br/> `var border = new TreeMapBorder { Color = "#58585B" };` <br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level border="border"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Level Border Width| **Property:** *levels.groupBorderThickness*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level group-border-thickness="2"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.border.width*<br/><br/> `var border = new TreeMapBorder { Width = 2 };` <br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level border="border"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Group Gap| **Property:** *levels.groupGap*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level group-gap="2"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.groupGap*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level groupGap="2"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Group Padding| **Property:** *levels.groupPadding*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level group-padding="1"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.groupPadding*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level groupPadding="1"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Group Path| **Property:** *levels.groupPath*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level group-path="pathname"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.groupPath*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level groupPath="pathname"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Height of Header Level| **Property:** *levels.headerHeight*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level header-height="20"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.headerHeight*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level headerHeight="20"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Header Template| **Property:** *levels.headerTemplate*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level header-template="template"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.headerTemplate*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level headerTemplate="template"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Opacity of Color| Not Applicable| **Property:** *levels.opacity*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level opacity="0.5"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Header Visibility| **Property:** *levels.showHeader*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level show-header="false"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.showHeader*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level showHeader="true"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Template Position| **Property:** *levels.labelPosition*<br/><br/> `<ej-treemap id="treemap">` <br/>`<e-levels>` <br/> &nbsp; `<e-level label-position="TopLeft"/>` <br/> `</e-levels>` <br/> `</ej-treemap>`| **Property:** *levels.templatePosition*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level templatePosition="Center"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Header Style| Not Applicable| **Property:** *levels.headerStyle*<br/><br/> `var style = new` <br/> &nbsp; `LeafItemSettingsLabelStyleLeafItemSettings {` <br/> &nbsp; `Size = '16px', Color = 'red', Opacity = 0.7 };` <br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level headerStyle="style"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Header Format| Not Applicable| **Property:** *levels.headerFormat*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level headerFormat="${Continent}"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|
|Header Alignment| Not Applicable| **Property:** *levels.headerAlignment*<br/><br/> `<ejs-treemap id="treemap">` <br/>`<e-treemap-levels>` <br/> &nbsp; `<e-treemap-level headerAlignment="Center"/>` <br/> `</e-treemap-levels>` <br/> `</ejs-treemap>`|

## Selection

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Selection| **Property:** *selectionMode*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `selection-mode="Default">` <br/> `</ej-treemap>`| **Property:** *selectionSettings.mode*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-selectionsettings` <br/> &nbsp; `enable="true", mode="Item"/>` <br/> `</ejs-treemap>`|
|Selection Color| Not Applicable| **Property:** *selectionSettings.fill*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-selectionsettings` <br/> &nbsp; `enable="true", fill="blue"/>` <br/> `</ejs-treemap>`|
|Selection Color Opacity| Not Applicable| **Property:** *selectionSettings.opacity*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-selectionsettings` <br/> &nbsp; `enable="true", opacity="0.6"/>` <br/> `</ejs-treemap>`|
|Border for selection| Not Applicable| **Property:** *selectionSettings.border*<br/><br/> `var border = new` <br/> &nbsp; `SelectionSettingsBorderSelectionSettings {` <br/> &nbsp; `Color = "white", Width = 0.5 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-selectionsettings` <br/> &nbsp; `border="border"/>` <br/> `</ejs-treemap>`|

## Hightlight

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Highlight Group Selection Mode| **Property:** *highlightGroupOnSelection*<br/><br/>  `<ej-treemap id="treemap"` <br/> &nbsp; `highlight-group-on-selection="true">` <br/> `</ej-treemap>`| **Property:** *highlightSettings.mode*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", mode="All"/>` <br/> `</ejs-treemap>`|
|Highlight Selection Mode| **Property:** *highlightOnSelection*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `highlight-on-selection="true">` <br/> `</ej-treemap>`| **Property:** *highlightSettings.mode*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", mode="Item"/>` <br/> `</ejs-treemap>`|
|Highlight Group Border Color| **Property:** *highlightGroupBorderBrush*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `highlight-border-brush="gray">` <br/> `</ej-treemap>`| **Property:** *highlightSettings.border.color*<br/><br/> `var border = new` <br/> &nbsp; `HighlightSettingsBorderHighlightSettings {` <br/> &nbsp; `Color = "gary" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", mode="All", border="border"/>` <br/> `</ejs-treemap>`|
|Highlight Group Border Width| **Property:** *highlightGroupBorderThickness*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `highlight-border-thickness="3">` <br/> `</ej-treemap>`| **Property:** *highlightSettings.border.width*<br/><br/> `var border = new` <br/> &nbsp; `HighlightSettingsBorderHighlightSettings {` <br/> &nbsp; `Width = 3 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", mode="All", border="border"/>` <br/> `</ejs-treemap>`|
|Highlight Selection Border Color| **Property:** *highlightBorderBrush*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `highlight-border-brush="gray">` <br/> `</ej-treemap>`| **Property:** *highlightSettings.border.color*<br/><br/> `var border = new` <br/> &nbsp; `HighlightSettingsBorderHighlightSettings {` <br/> &nbsp; `Color = "gary" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", mode="Item", border="border"/>` <br/> `</ejs-treemap>`|
|Highlight Selection Border Width| **Property:** *highlightBorderThickness*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `highlight-border-thickness="3">` <br/> `</ej-treemap>`| **Property:** *highlightSettings.border.width*<br/><br/> `var border = new` <br/> &nbsp; `HighlightSettingsBorderHighlightSettings {` <br/> &nbsp; `Width = 3 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", mode="Item", border="border"/>` <br/> `</ejs-treemap>`|
|Highlight Color| Not Applicable| **Property:** *highlightSettings.fill*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", fill="red"/>` <br/> `</ejs-treemap>`|
|Highlight Color Opacity| Not Applicable| **Property:** *highlightSettings.opacity*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-highlightsettings` <br/> &nbsp; `enable="true", fill="red", opacity="0.5"/>` <br/> `</ejs-treemap>`|

## Range ColorMapping

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|From value| **Property:** *rangeColorMapping.from*<br/><br/> `<ej-treemap id="treemap">` <br/> `<e-range-color-mappings>` <br/> &nbsp; `<e-range-color-mapping from="1000"/>` <br/> `</e-range-color-mappings>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.from*<br/><br/> `var map = new { from = 1000 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|To value| **Property:** *rangeColorMapping.to*<br/><br/> `<ej-treemap id="treemap">` <br/> `<e-range-color-mappings>` <br/> &nbsp; `<e-range-color-mapping to="10000"/>` <br/> `</e-range-color-mappings>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.to*<br/><br/> `var map = new { to = 10000 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|Color| **Property:** *rangeColorMapping.color*<br/><br/> `<ej-treemap id="treemap">` <br/> `<e-range-color-mappings>` <br/> &nbsp; `<e-range-color-mapping color="#77D8D8"/>` <br/> `</e-range-color-mappings>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.color*<br/><br/> `var map = new { color = "#77D8D8" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|Legend Label| **Property:** *rangeColorMapping.legendLabel*<br/><br/> `<ej-treemap id="treemap">` <br/> `<e-range-color-mappings>` <br/> &nbsp; `<e-range-color-mapping legendlabel="Growth"/>` <br/> `</e-range-color-mappings>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.label*<br/><br/> `var map = new { label = "Growth" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|

## Desaturation ColorMapping

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|From value| **Property:** *desaturationColorMapping.from*<br/><br/> `<ej-treemap id="treemap">` <br/> &nbsp; `<e-desaturation-color-mapping from = "1000"/>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.from*<br/><br/> `var map = new { from = 1000 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|To value| **Property:** *desaturationColorMapping.to*<br/><br/>  `<ej-treemap id="treemap">` <br/> &nbsp; `<e-desaturation-color-mapping to = "10000"/>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.to*<br/><br/> `var map = new { to = 10000 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|Color| **Property:** *desaturationColorMapping.color*<br/><br/> `<ej-treemap id="treemap">` <br/> &nbsp; `<e-desaturation-color-mapping color="#77D8D8"/>` <br/> `</ej-treemap>`| **Property:** *leafItemSettings.colorMapping.color*<br/><br/> `var map = new { color = "#77D8D8" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|Value| Not Applicable| **Property:** *leafItemSettings.colorMapping.value*<br/><br/> `var map = new { value = "Population" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|Minimum Opacity| Not Applicable| **Property:** *leafItemSettings.colorMapping.minOpacity*<br/><br/> `var map = new { minOpacity = 0.7 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|
|Maximum Opacity| Not Applicable| **Property:** *leafItemSettings.colorMapping.maxOpacity*<br/><br/> `var map = new { maxOpacity = 1 };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-leafitemsettings` <br/> &nbsp; `colorMapping="map"/>` <br/> `</ejs-treemap>`|

## Tooltip

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Tooltip| **Property:** *showTooltip*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `show-tooltip="true">` <br/> `</ej-treemap>`| **Property:** *tooltipSettings.visible*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `visible="true"/>` <br/> `</ejs-treemap>`|
|Tooltip Template| **Property:** *tooltipTemplate*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `tooltip-template="template">` <br/> `</ej-treemap>`| **Property:** *tooltipSettings.template*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `template="template"/>` <br/> `</ejs-treemap>`|
|Tooltip Border| Not Applicable| **Property:** *tooltipSettings.border*<br/><br/> `var border = new TreeMapBorder{ Color = "red", Width = 2 };` <br/>  `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `border="border"/>` <br/> `</ejs-treemap>`|
|Tooltip Color| Not Applicable| **Property:** *tooltipSettings.fill*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `fill="gray"/>` <br/> `</ejs-treemap>`|
|Tooltip Format| Not Applicable| **Property:** *tooltipSettings.format*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `format="${Population}"/>` <br/> `</ejs-treemap>`|
|Tooltip Marker Shape| Not Applicable| **Property:** *tooltipSettings.markerShapes*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `markerShapes="Circle"/>` <br/> `</ejs-treemap>`|
|Tooltip Color Opacity| Not Applicable| **Property:** *tooltipSettings.opacity*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `opacity="0.5"/>` <br/> `</ejs-treemap>`|
|Tooltip Text Style| Not Applicable| **Property:** *tooltipSettings.textStyle*<br/><br/> `var style = new` <br/> &nbsp; `TooltipSettingsTextStyleTooltipSettings {` <br/> &nbsp; `Size = '12px', Opacity = 0.5, Color = "red" };` <br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-tooltipsettings` <br/> &nbsp; `textStyle="style"/>` <br/> `</ejs-treemap>`|

## Drilldown

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
|Drilldown| **Property:** *enableDrillDown*<br/><br/>  `<ej-treemap id="treemap"` <br/> &nbsp; `enable-drill-down="true">` <br/> `</ej-treemap>`| **Property:** *enableDrillDown*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `enableDrillDown="true">` <br/> `</ejs-treemap>`|
|Drilldown Level| **Property:** *drillDownLevel*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `drill-down-level="1">` <br/> `</ej-treemap>`| **Property:** *InitialDrillSettings.groupIndex*<br/><br/> `<ejs-treemap id="treemap">` <br/> &nbsp; `<e-treemap-initialdrilldown` <br/> &nbsp; `groupIndex="1"/>` <br/> `</ejs-treemap>`|

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
|Treemap Load Event| Not Applicable| **Event:** *load*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `load="load"` <br/> `</ejs-treemap>` <br/> `function load(args) { }`|
|Treemap Loaded Event| Not Applicable| **Event:** *loaded*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `loaded="loaded"` <br/> `</ejs-treemap>` <br/> `function loaded(args) { }`|
|Event Before Print| Not Applicable| **Event:** *beforePrint*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `beforePrint="beforePrint"` <br/> `</ejs-treemap>` <br/> `function beforePrint(args) { }`|
|Click Event| **Event:** *click*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `click="click">` <br/> `</ej-treemap>` <br/> `function click(args) { }`| **Event:** *click*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `click="click"` <br/> `</ejs-treemap>` <br/> `function click(args) { }`|
|Drill Start Event| Not Applicable| **Event:** *drillStart*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `drillStart="drillStart"` <br/> `</ejs-treemap>` <br/> `function click(args) { }`|
|Drill End Event| Not Applicable| **Event:** *drillEnd*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `drillEnd="drillEnd"` <br/> `</ejs-treemap>` <br/> `function drillEnd(args) { }`|
|Event on Item Click| Not Applicable| **Event:** *itemClick*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `itemClick="itemClick"` <br/> `</ejs-treemap>` <br/> `function itemClick(args) { }`|
|Treemap Item Select Event| **Event:** *treeMapItemSelected*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `tree-map-item-selected="treeMapItemSelected">` <br/> `</ej-treemap>` <br/> `function treeMapItemSelected(args) { }`| **Event:** *itemSelected*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `itemSelected="itemSelected"` <br/> `</ejs-treemap>` <br/> `function itemSelected(args) { }`|
|Treemap Item Rendering Event| **Event:** *itemRendering*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `item-rendering="itemRendering">` <br/> `</ej-treemap>` <br/> `function itemRendering(args) { }`| **Event:** *itemRendering*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `itemRendering="itemRendering"` <br/> `</ejs-treemap>` <br/> `function itemRendering(args) { }`|
|Treemap Item Move Event| Not Applicable| **Event:** *itemMove*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `itemMove="itemMove"` <br/> `</ejs-treemap>` <br/> `function itemMove(args) { }`|
|Treemap Item Highlight Event| Not Applicable| **Event:** *itemHighlight*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `itemHighlight="itemHighlight"` <br/> `</ejs-treemap>` <br/> `function itemHighlight(args) { }`|
|Template Header Render Event| **Event:** *headerTemplateRendering*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `header-template-rendering="headerTemplateRendering">` <br/> `</ej-treemap>` <br/> `function headerTemplateRendering(args) { }`| Not Applicable|
|Drilldown Item Select Event| **Event:** *drillDownItemSelected*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `drill-down-item-selected="drillDownItemSelected">` <br/> `</ej-treemap>` <br/> `function drillDownItemSelected(args) { }`| Not Applicable|
|Mouse Event| Not Applicable| **Event:** *mouseMove*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `mouseMove="mouseMove"` <br/> `</ejs-treemap>` <br/> `function mouseMove(args) { }`|
|Resize Event| Not Applicable| **Event:** *resize*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `resize="resize"` <br/> `</ejs-treemap>` <br/> `function resize(args) { }`|
|Tooltip Render Event| Not Applicable| **Event:** *tooltipRendering*<br/><br/> `<ejs-treemap id="treemap"` <br/> &nbsp; `tooltipRendering="tooltipRendering"` <br/> `</ejs-treemap>` <br/> `function tooltipRendering(args) { }`|
|Double Click Event| **Event:** *doubleClick*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `double-click="doubleClick">` <br/> `</ej-treemap>` <br/> `function doubleClick(args) { }`| Not Applicable|
|Right Click Event| **Event:** *rightClick*<br/><br/> `<ej-treemap id="treemap"` <br/> &nbsp; `right-click="rightClick">` <br/> `</ej-treemap>` <br/> `function rightClick(args) { }`| Not Applicable|