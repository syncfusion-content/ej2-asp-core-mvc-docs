---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Combo Box Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Combo Box component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Migration from Essential JS 1

This article describes the API migration process of ComboBox component from Essential JS 1 to Essential JS 2.

## DataBinding

<!-- markdownlint-disable MD010 -->
| Behavior	| API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** |	**Property**: *Datasource*<br/>`Html.EJ().ComboBox("select").Datasource((IEnumerable<CarsList>)ViewBag.datasource).Render()`|**Property**: *DataSource*<br/>`@Html.EJS().ComboBox("games").DataSource((IEnumerable<object>)ViewBag.localdata).Render()`|
| **Fields for mapping** | **Property**: *ComboBoxFields*<br/>`Html.EJ().ComboBox("select").ComboBoxFields(f=>f.Text("text")).Render()`|**Property**: *Fields*<br/>`@Html.EJS().ComboBox("games").Fields(new ComboBoxFieldSettings { Text = "Game", Value = "Id" }).Render()` |
|**Query** | **Property**: *Query*<br/>`Html.EJ().ComboBox("select").Query("ej.Query().from('Suppliers').select('SupplierID', 'ContactName')").Render()` | **Property**: *Query*<br/>`@Html.EJS().ComboBox("games").Query((string)ViewBag.query).Render()` |
| **Begin event** | **Event**:*ActionBegin*<br/>`Html.EJ().ComboBox("select").ActionBegin("onBegin").Render()` | **Event**: *ActionBegin*<br/>`Html.EJ().ComboBox("select").ActionBegin("onBegin").Render()` |
| **Complete event** | **Event**:*ActionComplete*<br/>`Html.EJS().ComboBox("select").ActionComplete("onComplete").Render()` | **Event**: *ActionComplete*<br/>`Html.EJS().ComboBox("select").ActionComplete("onComplete").Render()`|
| **Failure event** |**Event**:*ActionFailure*<br/>`Html.EJ().ComboBox("select").ActionFailure("onFailure").Render()` | **Event**: *ActionFailure*<br/>`Html.EJS().ComboBox("select").ActionFailure("onFailure").Render()` |

## Filtering

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default**| **Property**: *AllowFiltering*<br/>`Html.EJ().ComboBox("select").AllowFiltering(true).Render()`| **Property**: *AllowFiltering*<br/>`Html.EJS().ComboBox("select").AllowFiltering(true).Render()`|
| **No records template** | **Property**: *NoRecordsTemplate*<br/>`Html.EJ().ComboBox("select").NoRecordsTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()` |**Property**: *NoRecordsTemplate*<br/>`Html.EJS().ComboBox("select").NoRecordsTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()` |
| **Ignore casing and diacritics**| **Not Applicable** | **Property**: *IgnoreAccent*<br/>`Html.EJS().ComboBox("select").AllowFiltering(true).Render()` |
| **Custom value addition** | **Property**: *AllowCustom*<br/>`Html.EJ().ComboBox("select").AllowCustom(true).Render()` | <https://ej2.syncfusion.com/aspnetmvc/ComboBox/CustomValue#/material> |
| **Search event** | **Event**: *Filtering*<br/>`Html.EJ().ComboBox("select").Filtering("Filtering").Render()` | **Event**: *Filtering*<br/>`Html.EJS().ComboBox("select").Filtering("Filtering").Render()` |

## Template

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** | **Property**: *ItemTemplate*<br/>`Html.EJ().ComboBox("select").ItemTemplate("<div><img class='eimg' src='../images/combobox/${eimg}.png' alt='employee'/><div class='ename'> ${text} </div><div class='temp'> ${country} </div></div>").Render()` | **Property**: *ItemTemplate*<br/>`Html.EJS().ComboBox("select").ItemTemplate("<div><img class='eimg' src='../images/combobox/${eimg}.png' alt='employee'/><div class='ename'> ${text} </div><div class='temp'> ${country} </div></div>").Render()`|
| **Group Template** | **Property**: *GroupTemplate*<br/>`Html.EJ().ComboBox("select").GroupTemplate("<strong>${country}</strong>").Render()` | **Property**: *GroupTemplate*<br/>`Html.EJS().ComboBox("select").GroupTemplate("<strong>${country}</strong>").Render()`|
| **ValueTemplate** | **Not Applicable** |**Property**: *ValueTemplate*<br/>`Html.EJS().ComboBox("select").ValueTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()` |
| **Header Template** | **Property**: *HeaderTemplate*<br/>`Html.EJ().ComboBox("select").HeaderTemplate("<div class='head'>  Photo  <span style='padding-left:42px'> Contact Info </span></div>").Render()` |	**Property**: *HeaderTemplate*<br/>`Html.EJS().ComboBox("select").HeaderTemplate("<div class='head'>  Photo  <span style='padding-left:42px'> Contact Info </span></div>").Render()` |
| **FooterTemplate**| **Property**: *FooterTemplate*<br/>`Html.EJ().ComboBox("select").FooterTemplate("<div class='Foot'> Total Items Count: 5 </div>").Render()`| **Property**: *FooterTemplate*<br/>`Html.EJS().ComboBox("select").FooterTemplate("<div class='Foot'> Total Items Count: 5 </div>").Render()` |
| **No records Template** |	**Property**: *NoRecordsTemplate*<br/>`Html.EJ().ComboBox("select").NoRecordsTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()`| **Property**: *NoRecordsTemplate*<br/>`Html.EJS().ComboBox("select").NoRecordsTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()` |
| **Auto fill** | **Property**: *AutoFill*<br/>`Html.EJ().ComboBox("select").AutoFill(true).Render()`|**Property**: *AutoFill*<br/>`Html.EJS().ComboBox("select").AutoFill(true).Render()`|
| **Action failure Template** |	**Property**: *ActionFailureTemplate*<br/>`Html.EJ().ComboBox("select").ActionFailureTemplate("<span class='action-failure'>Data fetch get fails</span>").Render()`|**Property**: *ActionFailureTemplate*<br/>`Html.EJS().ComboBox("select").ActionFailureTemplate("<span class='action-failure'>Data fetch get fails</span>").Render()`|

## Applying CSS

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | ---|
| **Default** | **Property**: *CssClass* <br/>`Html.EJ().ComboBox("select").CssClass("customclass").Render()`| **Property**: *CssClass*<br/>`Html.EJS().ComboBox("select").CssClass("customclass").Render()` |
| **width** | **Property**: *Width* <br/>`Html.EJ().ComboBox("select").Width("300px").Render()` | **Property**: *Width*<br/>`Html.EJS().ComboBox("select").Width("300px").Render()` |

## Grouping

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2|
| --- | --- | --- |
| **Default** | **Property**: *ComboBoxFields*<br/>`Html.EJ().ComboBox("select").ComboBoxFields(f=>f.GroupBy("text")).Render()`| **Property**: *Fields*<br/>`@Html.EJS().ComboBox("games").Fields(new ComboBoxFieldSettings { GroupBy = "Game" }).Render()` |

## Accessibility

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2|
| --- | --- | --- |
| **Globalizaation** | **Property**: *Locale*<br/>`Html.EJ().ComboBox("select").Locale("fr-FE").Render()`| **Property**: *Locale*<br/>`Html.EJS().ComboBox("select").Locale("fr-FE").Render()` |
| **Rtl support**| **Property**: *EnableRtl*<br/>`Html.EJ().ComboBox("select").EnableRtl(true).Render()`|**Property**: *EnableRtl*<br/>`Html.EJS().ComboBox("select").EnableRtl(true).Render()`|

## Placeholder

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2|
| --- | --- | --- |
| **Watermark text** | **Property**: *Placeholder*<br/>`Html.EJ().ComboBox("select").Placeholder("Select").Render()`|<br/>**Property**: *Placeholder*<br/>`Html.EJS().ComboBox("select").Placeholder("Select").Render()` |
| **Floating  of waterMarkText**| **Not applicable** |**Property**: *FloatLabelType*<br/>`Html.EJS().ComboBox("select").FloatLabelType(FloatLabelType .Auto).Render()` |

## Miscellaneous

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2|
| --- | --- | --- |
| **Enable/disable** | **Property**: *Enabled*<br/>`Html.EJ().ComboBox("select").Enabled(true).Render()`|**Property**: *Enabled*<br/>`Html.EJS().ComboBox("select").Enabled(true).Render()` |
| **Read only** | **Property**: *ReadOnly*<br/>`Html.EJ().ComboBox("select").ReadOnly(true).Render()` |**Property**: *ReadOnly*<br/>`Html.EJS().ComboBox("select").ReadOnly(true).Render()`|
| **Addition of Html attributes** | **Property**: *HtmlAttributes*<br/>`Html.EJ().ComboBox("select").HtmlAttributes(ViewBag.attr).Render()` | **Property**: *HtmlAttributes*<br/>`Html.EJS().ComboBox("select").HtmlAttributes(ViewBag.attr).Render()`|

## Sorting

<!-- markdownlint-disable MD010 -->
|Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Order of sorting** | **Property**: *SortOrder*<br/>`Html.EJ().ComboBox("select").SortOrder(SortOrder.Ascending).Render()` | **Property**: *SortOrder*<br/>`Html.EJS().ComboBox("select").SortOrder(SortOrder.Ascending).Render()`|

## Selection

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Selecting particular index** | **Property**: *Index*<br/>`Html.EJ().ComboBox("select").Index(1).Render()` | **Property**: *Index*<br/>`Html.EJS().ComboBox("select").Index(1).Render()` |
| **Selecting particular value** | **Property**: *Value*<br/>`Html.EJ().ComboBox("select").Value("Car").Render()`| **Property**: *Value*<br/>`Html.EJS().ComboBox("select").Value("Car").Render()` |
| **Selecting particular text** | **Property**: *Text* <br/>`Html.EJ().ComboBox("select").Text("Car").Render()` | **Property**: *Text*<br/>`Html.EJ()S.ComboBox("select").Text("Car").Render()`|
| **Getting data by using value** |	**Method**: *getItemDataByValue*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejDropDownList('getItemDataByValue',"data") | **Method**: *getDataByValue*<br/>`Html.EJ().ComboBox("combobox").Render()`<br/> <br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.getDataByValue("data"); |
| **Select event** | **Event**: *Select*<br/>`Html.EJ().ComboBox("dropdown").Select("onSelect").Render()`| **Event**: *Select*<br/>`Html.EJS().ComboBox("dropdown").Select("onSelect").Render()`|

## Popup

<!-- markdownlint-disable MD010 -->
| Behavior| API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Popup height** | **Property**: *PopupHeight*<br/>`Html.EJ().ComboBox("dropdown").PopupHeight("300px").Render()`|**Event**:*Popupheight*<br/>`Html.EJS().ComboBox("dropdown").PopupHeight("300px").Render()`|
| **Popup width** | **Property**: *PopupWidth*<br/>`Html.EJ().ComboBox("dropdown").PopupWidth("300px").Render()`|**Event**:*PopupWidth*<br/>`Html.EJS().ComboBox("dropdown").PopupWidth("300px").Render()` |
| **Popup showing manually** | **Method**: *showPopup*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejComboBox("showPopup");|	**Method**: *showPopup*<br/>`Html.EJS().ComboBox("combobox").Render()`<br/> <br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/>cmbObj.showPopup(); |
| **Popup hiding manually** | **Method**: *hidePopup*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejComboBox("hidePopup"); | **Method**: *hidePopup*<br/>`Html.EJS().ComboBox("combobox").Render()`<br/> <br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.hidePopup(); |
| **Popup hide event** | **Event**: *Close*<br/>`Html.EJ().ComboBox("dropdown").Close("onClose").Render()` | **Event**: *Close*<br/>`Html.EJS().ComboBox("dropdown").Close("onClose").Render()`|
| **Popup shown event** | **Event**: *Open*<br/>`Html.EJ().ComboBox("dropdown").Open("onOpen").Render()`| **Event**: *Open*<br/>`Html.EJS().ComboBox("dropdown").Open("onOpen").Render()`|

## Common

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 |API in Essential JS 2 |
| --- | --- | --- |
| **Adding new item** | **Method** : *addItem*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejComboBox("addItem", { text :"India"});| **Method**: *addItem*<br/>`Html.EJ().ComboBox("combobox").Render()`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.addItem({Id: 'id', Game: 'Golf'},2);|
| **Focus out event** | **Not applicable** | **Event**: *Blur*<br/>`Html.EJS().ComboBox("dropdown").Blur("onBlur").Render()` |
| **Focus in event** | **Event**: *Focus*<br/>`Html.EJ().ComboBox("dropdown").Focus("onFocus").Render()` | **Event**: *FocusIn*<br/>`Html.EJS().ComboBox("dropdown").Focus("onFocus").Render()` |
| **Focus out** | **Method**: *focusOut*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejComboBox("focusOut");| **Method**: *focusOut*<br/>`Html.EJS().ComboBox("combobox").Render()`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.focusOut(); |
| **Focus in** | **Method**: *focusIn*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejComboBox("focusIn"); | **Method**: *focusIn*<br/>`Html.EJS().ComboBox("combobox").Render()`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.focusIn(); |
| **Getting the data** | **Method** : *getItems*<br/>`Html.EJ().ComboBox("dropdown").Render()` <br/> <br/>$('#dropdown').ejComboBox("getItems"); | **Method**: *getItems*<br/>`Html.EJS().ComboBox("combobox").Render()`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.getItems();|
| **Create event** | **Event**: *Create*<br/>`Html.EJ().ComboBox("dropdown").Create("onCreate").Render()` |	**Event**: *Created*<br/>`Html.EJS().ComboBox("dropdown").Created("onCreate").Render()` |
| **Change event** | **Event**: *Change*<br/>`Html.EJ().ComboBox("dropdown").Change("onChange").Render()` | **Event**: *Change*<br/>`Html.EJS().ComboBox("dropdown").Change("onChange").Render()` |
| **Custom value event** | **Event**: *custom-value-specifier*<br/>`Html.EJ().ComboBox("dropdown").CustomValueSpecifier("fucntion").Render()` | **Event**: *CustomValueSpecifier*<br/>`Html.EJS().ComboBox("dropdown").CustomValueSpecifier("fucntion").Render()` |
