---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Drop Down List Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Migration from Essential JS 1

This article describes the API migration process of  DropDownList component from Essential JS 1 to Essential JS 2.

## DataBinding

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *Datasource* <br/>`@Html.EJ().DropDownList("countryList").Datasource((IEnumerable<Countries>)ViewBag.datasource1)` | **Property**: *dataSource* <br/>`@Html.EJS().DropDownList("games").DataSource((IEnumerable<object>)ViewBag.localdata).Render()` |
| **Fields for mapping** | **Property**: *DropDownListFields* <br/>`@Html.EJ().DropDownList("groupsList").DropDownListFields(f => f.Value("parentId").Text("text"))` | **Property**: *Fields* <br/>`@Html.EJS().DropDownList("games").Fields(new DropDownListFieldSettings { Text = "Game" }).Render()` |
| **Query** | **Property**: *Query* <br/>`@Html.EJ().DropDownList("groupsList").Query("ej.Query().from('Customers').take(6)")` | **Property**: *Query*<br/>`@Html.EJS().DropDownList("games").Query((string)ViewBag.query).Render()` |
| **Begin event** | **Event** :*ActionBegin* <br/>`@Html.EJ().DropDownList("selectCompany").ActionBegin("onBegin")` | **Event** : *actionBegin* <br/>`@Html.EJS().DropDownList("customers").ActionBegin("onBegin").Render()` |
| **Complete event** | **Event**: *ActionComplete* <br/>`@Html.EJ().DropDownList("selectCompany").ActionComplete("onBegin")` | **Event**: *ActionComplete* <br/>`@Html.EJS().DropDownList("customers").ActionComplete("ActionComplete").Render()` |
| **Failure event** | **Event**: *ActionFailure* <br/>`@Html.EJ().DropDownList("selectCompany").ActionFailure("onFailure")` | **Event**: *ActionFailure* <br/>`@Html.EJS().DropDownList("customers").ActionFailure("ActionFailure").Render()` |
| **Success event** | **Event**: *ActionSuccess* <br/>`@Html.EJ().DropDownList("selectCompany").ActionSuccess("onsuccess")` | **Not Applicable** |
| **Data binding event** | **Event**: *DataBound* <br/> `@Html.EJ().DropDownList("selectCompany").DataBound("onBound")` | **Event**: *DataBound* <br/>`@Html.EJS().DropDownList("customers").DataBound("onBound").Render()` |

## Filtering

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** |	**Property**: *EnableFilterSearch* <br/>`@Html.EJ().DropDownList("selectCompany").EnableFilterSearch(true)` | **Property**: *AllowFiltering* <br/>`@Html.EJS().DropDownList("customers").AllowFiltering(true).Render()` |
| **Server filtering** | **Property**: *EnableServerFiltering* <br/>`@Html.EJ().DropDownList("selectCompany").EnableServerFiltering(true)` | **Property**: *AllowFiltering* <br/>`@Html.EJS().DropDownList("customers").AllowFiltering(true).Render()` |
| **Filter type** | **Property**: *FilterType* <br/>`@Html.EJ().DropDownList("selectCompany").FilterType(SearchFilterType.StartsWith)` | <https://ej2.syncfusion.com/aspnetmvc/DropDownList/Filtering#/material> |
| **No Records Template** |	**Not Applicable** | **Property**: *NoRecordsTemplate* <br/> `@Html.EJS().DropDownList("games").NoRecordsTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()` |
| **Filter Bar watermarktext** | **Not Applicable** | **Property**: *FilterBarPlaceholder* <br/>`@Html.EJS().DropDownList("customers").FilterBarPlaceholder(true).Render()` |
| **Ignore casing and diacritics** | **Not Applicable** | **Property**: *IgnoreAccent*<br/>`@Html.EJS().DropDownList("customers").IgnoreAccent(true).Render()` |
| **Incremental search** | **Property**: *EnableIncrementalSearch*<br/>`@Html.EJ().DropDownList("selectCompany").EnableIncrementalSearch(true)` | **By default it is true** |
| **Case sensitivity** | **Property**: *CaseSensitiveSearch*<br/>`@Html.EJ().DropDownList("selectCompany").CaseSensitiveSearch(true)` | <https://ej2.syncfusion.com/aspnetmvc/DropDownList/Filtering#/material> |
| **Search event** | **Event**: *Search* <br/>`@Html.EJ().DropDownList("selectCompany").Search("onSearch")` | **Event**: *Filtering* <br/>`@Html.EJS().DropDownList("customers").Filtering("filtering").Render()` |

## Template

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *Template* <br/>`@Html.EJ().DropDownList("selectCompany").Template("<div><img class='imgId' src='../Content/Employees/${Image}.png' alt='employee'/> <div class='ename'> ${Text} </div><div class='role'> ${Role} </div><div class='cont'> ${Country} </div></div>")` | **Property**: *ItemTemplate*<br/>`@Html.EJS().DropDownList("customers").ItemTemplate("@Html.Raw("<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>")").Render()` |
| **Group Template** | **Not Applicable** | **Property**: *GroupTemplate* <br/>`@Html.EJS().DropDownList("customers").GroupTemplate("@Html.Raw("<strong>${City}</strong>")").Render()` |
| **ValueTemplate** | **Not Applicable** | **Property**: *ValueTemplate* <br/>`@Html.EJS().DropDownList("customers").ValueTemplate(""@Html.Raw("<span>${FirstName} - ${City}</span>")").Render()` |
| **Header Template** | **Property**: *HeaderTemplate* <br/>`@Html.EJ().DropDownList("selectCompany").HeaderTemplate("<div class='eheader'><span>PHOTO</span> <span>DETAILS</span></div>").Render()` | **Property**: *HeaderTemplate* <br/>`@Html.EJS().DropDownList("customers").HeaderTemplate("@Html.Raw("<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>")").Render()` |
| **FooterTemplate** | **Not applicable** |	**Property**: *FooterTemplate* <br/>`@Html.EJS().DropDownList("customers").FooterTemplate("@Html.Raw("<span class='foot'> Total list items: " + 8 + "</span>")").Render()` |
| **No records Template** | **Not applicable** | **Property**: *NoRecordsTemplate* <br/>`@Html.EJS().DropDownList("customers").NoRecordsTemplate("@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")").Render()` |
| **Action failure Template** | **Not applicable** | **Property**: *ActionFailureTemplate* <br/>`@Html.EJS().DropDownList("customers").ActionFailureTemplate("@Html.Raw("<span class='action-failure'> Data fetch get fails</span>")").Render()` |

## Virtual Scrolling

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** |	**Property**: *AllowVirtualScrolling* <br/>`@Html.EJ().DropDownList("customers").AllowVirtualScrolling(true)` | **Not applicable** |

## Applying CSS

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *CssClass* <br/>`@Html.EJ().DropDownList("customers").CssClass("customClass")` | **Property**: *CssClass* <br/>`@Html.EJS().DropDownList("customers").CssClass("class").Render()` |
| **showRoundedCorner** | **Property**: *ShowRoundedCorner* <br/>`@Html.EJ().DropDownList("customers").ShowRoundedCorner(true)` | **Property**: *CssClass* <br/>`@Html.EJS().DropDownList("customers").CssClass("class").Render()` |

## Sorting

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** |	**Property**: *EnableSorting* <br/>`@Html.EJ().DropDownList("customers").EnableSorting(true)` | **Enabled only on using sortorder **Property**** |
| **Order of sorting** | **Property**: *SortOrder* <br/>`@Html.EJ().DropDownList("customers").SortOrder("SortOrder.Descending")` | **Property**: *SortOrder* <br/>`@Html.EJS().DropDownList("customers").SortOrder("Ascending").Render()`|

## Popup

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Popup height** | **Property**: *PopupHeight* <br/>`@Html.EJ().DropDownList("customers").PopupHeight("550px")` | **Property**: PopupHeight <br/>`@Html.EJS().DropDownList("customers").PopupHeight("220px").Render()` |
| **Popup width** |	**Property**: *PopupWidth* <br/>`@Html.EJ().DropDownList("customers").PopupWidth("550px")` | **Property**: *PopupWidth* <br/>`@Html.EJS().DropDownList("customers").PopupWidth("300px").Render()` |
| **Popup show on load** | **Property**: *ShowPopupOnLoad* <br/> `@Html.EJ().DropDownList("customers").ShowPopupOnLoad(true)` | **By default, the data load on demand.** |
| **enableAnimation** |	**Property**: *EnableAnimation* <br/>`@Html.EJ().DropDownList("customers").EnableAnimation(true)` | **Not applicable** |
| **Popup resizing** | **Property**: *EnablePopupResize* <br/>`@Html.EJ().DropDownList("customers").EnablePopupResize(true)` | **Not applicable** |
| **Maximum Popup height** | **Property**: *MaxPopupHeight* <br/>`@Html.EJ().DropDownList("customers").MaxPopupHeight("550px")` | **Not applicable** |
| **Minimum Popup height** | **Property**: *min-popup-height*<br/>`@Html.EJ().DropDownList("customers").MinPopupHeight("550px")`<br/>}); | **Not applicable** |
| **Maximum Popup width** | **Property**: *MaxPopupWidth* <br/>`@Html.EJ().DropDownList("customers").MaxPopupWidth("550px")` | **Not applicable** |
| **Minimum Popup width** |	**Property**: *MinPopupWidth* <br/>`@Html.EJ().DropDownList("customers").MinPopupWidth("550px")` | **Not applicable** |
| **Loading data** | **Property**: *LoadOnDemand* <br/>`@Html.EJ().DropDownList("customers").LoadOnDemand(true)` | **By default, it is true** |
| **Popup showing manually** | **Method**: *showPopup* <br/>`@Html.EJ().DropDownList("dropdown")`<br/><br/>`$('#dropdown').ejDropDownList('showPopup')` | **Method**: *showPopup* <br/>`@Html.EJS().DropDownList("dropdown").Render()`<br/><br/>`var ddlObj = document.getElementById('dropdown').ej2_Instances[0];`<br/><br/>`ddlObj.showPopup();` |
| **Popup hiding manually** | **Method**: *hidePopup* <br/>`@Html.EJ().DropDownList("dropdown")`<br/><br/>`$('#dropdown').ejDropDownList('hidePopup')` | **Method**: *HidePopup*<br/>`@Html.EJS().DropDownList("dropdownlist").Render()`<br/><br/>`var ddlObj = document.getElementById("dropdownlist").ej2_Instances[0];`<br/><br/>`ddlObj.hidePopup();` |
| **Before Popup hide event** | **Event**: *BeforePopupHide* <br/>`@Html.EJ().DropDownList("dropdown").BeforePopupHide("event")`| **Not applicable** |
| **Before Popup shown event** | **Event**: *BeforePopupShown*<br/>`@Html.EJ().DropDownList("dropdown").BeforePopupShown("event")` | **Event**: *BeforeOpen* <br/>`@Html.EJS().DropDownList("dropdown").BeforeOpen("event").Render()` |
| **Popup hide event** | **Event**: *PopupHide*<br/>`@Html.EJ().DropDownList("dropdown").PopupHide("event")` | **Event**: *Close* <br/>`@Html.EJS().DropDownList("dropdown").Close("event").Render()` |
| **Popup resize event** | **Event**: *PopupResize*<br/>`@Html.EJ().DropDownList("dropdown").PopupResize("event")` |	**Not applicable** |
| **Popup resize start event** | **Event**: *PopupResizeStart*<br/>`@Html.EJ().DropDownList("dropdown").PopupResizeStart("event")` | **Not applicable** |
| **Popup resize stop event** | **Event**: *popupResizeStop*<br/>`@Html.EJ().DropDownList("dropdown").PopupResizeStop("event")` | **Not applicable** |
| **Popup shown event** | **Event**: *Popupshown*<br/>`@Html.EJ().DropDownList("dropdown").PopupShown("event")` | **Event**: *Open*<br/> `@Html.EJS().DropDownList("dropdown").Open("event").Render()` |

## Placeholder

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Watermark text** | **Property**: *WatermarkText* <br/>`@Html.EJ().DropDownList("dropdown").WatermarkText("Select")` | **Property**: *Placeholder* <br/>`@Html.EJS().DropDownList("dropdown").PlaceHolder("Select").Render()` |
| **Floating  of waterMarkText** | **Not applicable** |	**Property**: *FloatLabelType* <br/>`@Html.EJS().DropDownList("dropdown").FloatLabelType("Auto").Render()` |

## Grouping

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *fields.groupBy* <br/>`@Html.EJ().DropDownList("groupsList").DropDownListFields(f => f.GroupBy("parentId"))` | **Property**: *fields.groupBy*<br/>>`@Html.EJS().DropDownList("games").Fields(new DropDownListFieldSettings { GroupBy = "Game" }).Render()` |
| **Group Template** | **Not applicable** | **Property**: *GroupTemplate*<br/>`@Html.EJS().DropDownList("customers").GroupTemplate("@Html.Raw("<strong>${City}</strong>")").Render()` |

## Accessibility

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Globalization** | **Property**: *Locale*<br/>`@Html.EJ().DropDownList("customers").Locale("fr-FE")` | **Property**: *Locale*<br/>`@Html.EJS().DropDownList("customers").Locale("fr-FE").Render()` |
| **Rtl support** |	**Property**: *EnableRtl*<br/>`@Html.EJ().DropDownList("customers").EnableRtl(true)` | **Property**: *EnableRtl*<br/>`@Html.EJS().DropDownList("customers").EnableRtl(true).Render()` |

## Miscellaneous

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Enable/disable** | **Property**: *Enabled*<br/>`@Html.EJ().DropDownList("customers").Enabled(true)` | **Property**: *Enabled* <br/>`@Html.EJS().DropDownList("customers").Enabled(true).Render()` |
| Read only | **Property**: *ReadOnly* <br/>`@Html.EJ().DropDownList("customers").ReadOnly(true)` | <br/>**Property**: *ReadOnly*<br/>`@Html.EJS().DropDownList("customers").ReadOnly(true).Render()` |
| Persistence of data | **Property**: *EnablePersistence*<br/>`@Html.EJ().DropDownList("customers").EnablePersistence(true)` |**Property**: *EnablePersistence*<br/>`@Html.EJS().DropDownList("customers").EnablePersistence(true).Render()` |
| **Disable** |	**Method**: *disable*<br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('disable') |**Property**: *Enabled*<br/>`@Html.EJS().DropDownList("customers").Enabled(false).Render()` |
| **Enable** | **Method**: *enable*<br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('enable') | **Property**: *Enabled*<br/>`@Html.EJS().DropDownList("customers").Enabled(true).Render()` |
| **Height** | **Property**: *Height* <br/>`@Html.EJ().DropDownList("dropdown").Height("300px")` | **Property**: *Height* <br/>`@Html.EJS().DropDownList("customers").Height("300px").Render()` |
| **Width** | **Property**: *Width* <br/>`@Html.EJ().DropDownList("dropdown").Width("300px")` | **Property**: *Width* <br/>`@Html.EJS().DropDownList("customers").Width("300px").Render()` |

## Selection

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| Selecting particular index | **Property**: *selected-index*<br/>`@Html.EJ().DropDownList("dropdown").Index(3)` | **Property**: *index*<br/>`@Html.EJS().DropDownList("customers").Index(3).Render()` |
| **Selecting particular value** | **Property**: *value*<br/>`@Html.EJ().DropDownList("dropdown").Value(3)` | **Property**: *value*<br/>`@Html.EJS().DropDownList("customers").Value(3).Render()` |
| **Selecting particular text** | **Property**: *text* <br/>`@Html.EJ().DropDownList("dropdown").Text("data")` | **Property**: *text*<br/>`@Html.EJS().DropDownList("customers").Text("data").Render()` |
| **Target id** | **Property**: *targetId* <br/>`@Html.EJ().DropDownList("dropdown").TargetId("data")` | **Not applicable** |
| **Selecting item using text**	| **Method**: *selectItemByText* <br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('selectItemByText','car') | **Not applicable** |
| **Unselect item using text** | **Method**: *unselectItemByText*<br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('unselectItemByText','car') | **Not applicable** |
| **Selecting item using value** | **Method**: *selectItemByValue*<br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('selectItemByValue','car') | **Not applicable** |
| **Getting data by using value** |	**Method**: *getItemDataByValue*<br/>`@Html.EJ().DropDownList("dropdown")`<br/><br/>`$('#dropdown').ejDropDownList('unselectItemByValue','car')` | **Method**: *getDataByValue*<br/>`@Html.EJS().DropDownList("dropdownlist").Render()`<br/><br/>`var ddlObj = document.getElementById("dropdownlist").ej2_Instances[0];`<br/><br/>`ddlObj.getItemDataByValue("data");` |
| **Get selected value** | **Method**: *getSelectedItem*<br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedItem') | **Not applicable** |
| **Get selected text** | **Method**: *getSelectedText*<br/>`@Html.EJ().DropDownList("dropdown")`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedText') | **Property**: *text*<br/>`@Html.EJS().DropDownList("customers").Text("data").Render()` |
| **Select event** | **Event**: *select*<br/>`@Html.EJ().DropDownList("dropdown").select("onSelect")` | **Event**: *select*<br/>`@Html.EJS().DropDownList("customers").Select("onSelect").Render()` |
| **Addition of Html attributes** | **Property**: *html-attributes*<br/>`@Html.EJS().DropDownList("customers").HtmlAttributes((IDictionary<string,object>)ViewData["HtmlAttrData"])` | **Property**: *htmlAttributes*<br/>`@Html.EJS().DropDownList("customers").HtmlAttributes(@ViewBag.data).Render()` |

## Common

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Adding new item** | **Method** : *addItem*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList("addItem", {text:"India"});` | **Method**: *addItem*<br/>`<ejs-dropdownlist/>`<br/> <br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.addItem({Id: 'game4', Game: 'Golf'}, 2);` |
| **Clearing the text** | **Method** : *clearText*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/> <br/>`$('#dropdown').ejDropDownList('clearText')` | **Property**:* showClearButton*<br/>`<ejs-dropdownlist showClearButton=true/>` |
| **Destroy the component** | **Method** : *destroy*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('destroy')` | **Method**: *destroy*<br/>`<ejs-dropdownlist/>`<br/> <br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.destroy;` |
| **Getting the data** | **Method** : *getListData*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('getListData')` | **Method** : *getItems*<br/>`<ejs-dropdownlist/>`<br/><br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.getItems;` |
| **Create event** | **Event**: *create*<br/>`<ej-drop-down-list create="onCreate"></ej-drop-down-list>` | **Event**: *created*<br/>`<ejs-dropdownlist created ="created" />` |
| **Destroy event** | **Event**: *destroy*<br/>`<ej-drop-down-list destroy="ondestroy"></ej-drop-down-list>` | **Event**: *destroyed*<br/>`<ejs-dropdownlist destroyed ="destroy" />` |
| **Cascade  event** | **Event**: *cascade*<br/>`<ej-drop-down-list cascade="cascade"></ej-drop-down-list>` |<https://ej2.syncfusion.com/demos/#/material/drop-down-list/cascading.html> |
| **Change event** | **Event**: *change*<br/>`<ej-drop-down-list create="change"></ej-drop-down-list>` | **Event**: *change*<br/>`<ejs-dropdownlist change ="change" />` |
| **Focus out event** |	**Event**: *focusOut*<br/>`<ej-drop-down-list focus-out="focus"></ej-drop-down-list>` | **Event**: *blur*<br/>`<ejs-dropdownlist blur ="blur" />` |
| **Focus in event**| **Event**: *focusIn*<br/><br/>`<ej-drop-down-list focus-in="focus"></ej-drop-down-list>` | **Event**: *focus*<br/>`<ejs-dropdownlist focus ="onfofus" />` |
