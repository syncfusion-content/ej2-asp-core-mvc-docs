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
| --- | --- | --- |
| **Default** | **Property**: *dataSource* <br/>`<ej-drop-down-list datasource="ViewBag.datasource"></ej-drop-down-list>` | **Property**: *dataSource* <br/>`<ejs-dropdownlist dataSource="@ViewBag.data"></ejs-dropdownlist>`|
| **Fields for mapping** | **Property**: *fields* <br/>`<ej-drop-down-list><e-drop-down-list-fields text="CustomerID" table-name="Customers" /></ej-drop-down-list>`| **Property**: *fields* <br/>`<ejs-dropdownlist><e-dropdownlist-fields text="Vegetable" value="Id"></e-dropdownlist-fields></ejs-dropdownlist>`|
| **Query** | **Property**: *query* <br/>`<ej-drop-down-list query="ej.Query().from('Customers').take(6)"></ej-drop-down-list>`| **Property**: *query*<br/>`<ejs-dropdownlist query="new ej.data.Query().from('Customers').select(['ContactName', 'CustomerID']).take(6)"></ejs-dropdownlist>`|
| **Begin event** | **Event** :*action-begin* <br/>`<ej-drop-down-list actionBegin="actionBegin"></ej-drop-down-list>` | **Event** : *actionBegin* <br/>`<ejs-dropdownlist id="customers" actionBegin="actionBegin"></ejs-dropdownlist>`|
| **Complete event** | **Event**: *action-complete* <br/>`<ej-drop-down-list actionBegin="actionComplete"></ej-drop-down-list>` | **Event**: *actionComplete* <br/>`<ejs-dropdownlist id="customers" actionComplete="actionComplete"></ejs-dropdownlist>`|
| **Failure event** | **Event**: *action-failure* <br/>`<ej-drop-down-list actionFailure="actionFailure"></ej-drop-down-list>`| **Event**: *actionFailure* <br/>`<ejs-dropdownlist id="customers" actionFailure="actionFailure"></ejs-dropdownlist>`|
| **Success event**| **Event**: *action-sucess* <br/>`<ej-drop-down-list actionSuccess="actionSuccess"></ej-drop-down-list>`| **Not Applicable** |
| **Data binding event** | **Event**: *dataBound* <br/> `<ej-drop-down-list dataBound="dataBound"></ej-drop-down-list>`| **Event**: *dataBound* <br/>`<ejs-dropdownlist id="customers" dataBound="dataBound"></ejs-dropdownlist>`|

## Filtering

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** |	**Property**: *enable-filter-search* <br/>`<ej-drop-down-list enable-filter-search=true></ej-drop-down-list>`| **Property**: *allowFiltering* <br/>`<ejs-dropdownlist allowFiltering="true"></ejs-dropdownlist>` |
| **Server filtering** | **Property**: *enable-server-filtering* <br/>`<ej-drop-down-list enable-server-filtering=true></ej-drop-down-list>`| **Property**: *allowFiltering* <br/>`<ejs-dropdownlist allowFiltering="true"></ejs-dropdownlist>` |
| **Filter type** | **Property**: *filter-type* <br/>`<ej-drop-down-list filter-type="@SearchFilterType.StartsWith"></ej-drop-down-list>` |<https://ej2.syncfusion.com/demos/#/material/drop-down-list/filtering.html> |
| **No Records Template** |	**Not Applicable** | **Property**: *noRecordsTemplate* <br/> `<ejs-dropdownlist noRecordsTemplate="@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")"></ejs-dropdownlist>` |
| **Filter Bar watermarktext** | **Not Applicable** | **Property**: *filterBarPlaceholder* <br/>`<ejs-dropdownlist filterBarPlaceholder="Search" ></ejs-dropdownlist>` |
| **Ignore casing and diacritics** | **Not Applicable** |**Property**: *ignoreAccent*<br/>`<ejs-dropdownlist ignoreAccent="true"></ejs-dropdownlist>` |
| **Incremental search**| **Property**: *enable-incremental-search*<br/>`<ej-drop-down-list enable-incremental-search="true"></ej-drop-down-list>` | **By default it is true** |
| **Case sensitivity** | **Property**: *case-sensitive-search*<br/>`<ej-drop-down-list case-sensitive-search="true"></ej-drop-down-list>` | <https://ej2.syncfusion.com/demos/#/material/drop-down-list/filtering.html> |
| **Search event** | **Event**: *search* <br/>`<ej-drop-down-list search="onSearth"></ej-drop-down-list>` | **Event**: *filtering* <br/>`<ejs-dropdownlist filtering="onFiltering"></ejs-dropdownlist>` |

## Template

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** | **Property**: *template* <br/>`<ej-drop-down-list template="<div><img class='imgId' src='../Content/Employees/${Image}.png' alt='employee'/> <div class='ename'> ${Text} </div><div class='role'> ${Role} </div><div class='cont'> ${Country} </div></div>"></ej-drop-down-list>` |**Property**: *itemTemplate*<br/>`<ejs-dropdownlist itemTemplate="@Html.Raw("<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>")"></ejs-dropdownlist>`|
| **Group Template** | **Not Applicable** | **Property**: *groupTemplate* <br/>`<ejs-dropdownlist groupTemplate="@Html.Raw("<strong>${City}</strong>")"></ejs-dropdownlist>`|
| **ValueTemplate** | **Not Applicable** | **Property**: *valueTemplate* <br/>`<ejs-dropdownlist valueTemplate=""@Html.Raw("<span>${FirstName} - ${City}</span>")"></ejs-dropdownlist>`|
| **Header Template** | **Property**: *headerTemplate* <br/>`<ej-drop-down-list header-template="<div class='eheader'><span>PHOTO</span> <span>DETAILS</span></div>"></ej-drop-down-list>`| **Property**: *headerTemplate* <br/>`<ejs-dropdownlist headerTemplate="@Html.Raw("<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>")"></ejs-dropdownlist>`|
| **FooterTemplate** | **Not applicable** |	**Property**: *footerTemplate* <br/>`<ejs-dropdownlist footerTemplate="@Html.Raw("<span class='foot'> Total list items: " + 8 + "</span>")"></ejs-dropdownlist>`|
| **No records Template** | **Not applicable** | **Property**: *noRecordsTemplate* <br/>`<ejs-dropdownlist noRecordsTemplate="@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")"></ejs-dropdownlist>`|
| **Action failure Template** | **Not applicable** | **Property**: *actionFailureTemplate* <br/>`<ejs-dropdownlist actionFailureTemplate="@Html.Raw("<span class='action-failure'> Data fetch get fails</span>")"></ejs-dropdownlist>`|

## Virtual Scrolling

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** |	**Property**: *allow-virtual-scrolling* <br/>`<ej-drop-down-list allow-virtual-scrolling="true"></ej-drop-down-list>` | **Not applicable** |

## Applying CSS

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** | **Property**: *css-class* <br/>`<ej-drop-down-list css-class="customClass"></ej-drop-down-list>` | **Property**: *cssClass* <br/>`<ejs-dropdownlist cssClass="class"></ejs-dropdownlist>`|
| **showRoundedCorner** | **Property**: *show-rounded-corner* <br/>`<ej-drop-down-list show-rounded-corner="true"></ej-drop-down-list>` | **Property**: *cssClass* <br/>`<ejs-dropdownlist cssClass="class"></ejs-dropdownlist>`|

## Sorting

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** |	**Property**: *enable-sorting* <br/>`<ej-drop-down-list enable-sorting="true"></ej-drop-down-list>` | **Enabled only on using sortorder **Property**** |
| **Order of sorting** | **Property**: *sort-order* <br/>`<ej-drop-down-list sort-order="@SortOrder.Descending"></ej-drop-down-list>` | **Property**: *sortOrder* <br/>`<ejs-dropdownlist sortOrder="Ascending"></ejs-dropdownlist>`|

## Popup

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|--- | --- | --- |
| **Popup height** | **Property**: *popup-height* <br/>`<ej-drop-down-list popup-height="550px">    </ej-drop-down-list>`| **Property**: popupheight <br/>`<ejs-dropdownlist popupHeight="220px"></ejs-dropdownlist>`|
| **Popup width** |	**Property**: *popup-width* <br/>`<ej-drop-down-list popup-width="550px">    </ej-drop-down-list>` | **Property**: *popupWidth* <br/>`<ejs-dropdownlist popupWidth="300px"></ejs-dropdownlist>`|
| **Popup show on load** |	**Property**: *show-popup-on-load* <br/> `<ej-drop-down-list show-popup-on-load="true">    </ej-drop-down-list>`|	**By default, the data load on demand.** |
| **enableAnimation** |	**Property**: *enable-animation* <br/>`<ej-drop-down-list enable-animation="true">    </ej-drop-down-list>`| **Not applicable** |
| **Popup resizing** | **Property**: *enable-popup-resize* <br/>`<ej-drop-down-list enable-popup-resize="true">    </ej-drop-down-list>`| **Not applicable** |
| **Maximum Popup height** | **Property**: *max-popup-height* <br/>`<ej-drop-down-list max-popup-Height="550px">    </ej-drop-down-list>`| **Not applicable** |
| **Minimum Popup height** | **Property**: *min-popup-height*<br/>`<ej-drop-down-list min-popup-Height="550px"></ej-drop-down-list>`<br/>}); | **Not applicable** |
| **Maximum Popup width** | **Property**: *max-popup-width* <br/>`<ej-drop-down-list max-popup-width="550px"></ej-drop-down-list>`| **Not applicable** |
| **Minimum Popup width** |	**Property**: *min-popup-width* <br/>`<ej-drop-down-list min-popup-Width="550px"></ej-drop-down-list>` | **Not applicable** |
| **Loading data** | **Property**: *load-on-demand* <br/>`<ej-drop-down-list load-on-demand="true"></ej-drop-down-list>` | **By default, it is true** |
| **Popup showing manually** | **Method**: *showPopup* <br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('showPopup')` | **Method**: *showPopup* <br/>`<ejs-dropdownlist/>`<br/><br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.showPopup();`|
| **Popup hiding manually** |**Method**: *hidePopup* <br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('hidePopup')` | **Method**: *hidePopup*<br/>`<ejs-dropdownlist/>`<br/><br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.hidePopup();`|
| **Before Popup hide event** | **Event**: *before-popup-hide* <br/>`<ej-drop-down-list before-popup-hide="event"></ej-drop-down-list>`| **Not applicable** |
| **Before Popup shown event** | **Event**: *before-popup-shown*<br/>`<ej-drop-down-list before-popup-shown="event"></ej-drop-down-list>`| **Event**: *beforeOpen* <br/>`<ejs-dropdownlist beforeOpen="onOpen"/>`|
| **Popup hide event** | **Event**: *popup-hide*<br/>`<ej-drop-down-list popup-hide="event"></ej-drop-down-list>`|**Event**: *close* <br/>`<ejs-dropdownlist close="onClose"/>` |
| **Popup resize event** | **Event**: *popup-resize*<br/>`<ej-drop-down-list popup-resize="event"></ej-drop-down-list>`|	**Not applicable** |
| **Popup resize start event**| **Event**: *popup-resize-start*<br/>`<ej-drop-down-list popup-resize-start="event"></ej-drop-down-list>`|	**Not applicable** |
| **Popup resize stop event** | **Event**: *popup-resize-stop*<br/>`<ej-drop-down-list popup-resize-stop="event"></ej-drop-down-list>`| **Not applicable** |
| **Popup shown event** | **Event**: *popup-shown*<br/>`<ej-drop-down-list popup-shown="event"></ej-drop-down-list>`| **Event**: *open*<br/> `<ejs-dropdownlist open="onOpen"/>`|

## Placeholder

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Watermark text** | **Property**: *watermark-Text* <br/>`<ej-drop-down-list watermark-text="Select an Item"></ej-drop-down-list>`| **Property**: *placeholder* <br/>`<ejs-dropdownlist placeholder="select"/>`|
| **Floating  of waterMarkText** | **Not applicable** |	**Property**: *floatLabelType* <br/>`<ejs-dropdownlist floatLabelType="Auto"/>`|

## Grouping

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Default** | **Property**: *fields.groupBy* <br/>`<ej-drop-down-list watermark-text="Select an Item"><e-drop-down-list-fields group-by="Category" /></ej-drop-down-list>`|**Property**: *fields.groupBy*<br/>>`<ejs-dropdownlist> <e-dropdownlist-fields groupBy="Name"></e-dropdownlist-fields></ejs-dropdownlist>`|
| **Group Template**| **Not applicable** | **Property**: *groupTemplate*<br/>`<ejs-dropdownlist groupTemplate="@Html.Raw("<strong>${City}</strong>")"></ejs-dropdownlist>` |

## Accessibility

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Globalization** | **Property**: *locale*<br/>`<ej-drop-down-list locale="fr-FE"/>`| **Property**: *locale*<br/>`<ejs-dropdownlist locale="en-US"></ejs-dropdownlist>` |
| **Rtl support** |	**Property**: *enable-rtl*<br/>`<ej-drop-down-list enable-rtl="true"/>` | **Property**: *enableRtl*<br/>`<ejs-dropdownlist enableRtl="true"></ejs-dropdownlist>` |

## Miscellaneous

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Enable/disable** | **Property**: *enabled*<br/>`<ej-drop-down-list enabled="true"/>` | **Property**: *enabled* <br/>`<ejs-dropdownlist enabled="true"></ejs-dropdownlist>` |
| Read only | **Property**: *read-only* <br/>`<ej-drop-down-list read-only="true"/>` | <br/>**Property**: *readOnly*<br/>`<ejs-dropdownlist readOnly="true"></ejs-dropdownlist>` |
| Persistence of data | **Property**: *enable-persistence*<br/>`<ej-drop-down-list enable-presistence="true"/>` |**Property**: *enablePersistence*<br/>`<ejs-dropdownlist enablePersistence="true"></ejs-dropdownlist>` |
| **Disable** |	**Method**: *disable*<br/>`<ej-drop-down-list />`<br/> <br/>$('#dropdown').ejDropDownList('disable')|**Property**: *enabled*<br/>`<ejs-dropdownlist enabled="false"></ejs-dropdownlist>`|
| **Enable** | **Method**: *enable*<br/>`<ej-drop-down-list />`<br/> <br/>$('#dropdown').ejDropDownList('enable')| **Property**: *enabled*<br/>`<ejs-dropdownlist enabled="true"></ejs-dropdownlist>`|
| **Height** | **Property**: *height* <br/>`<ej-drop-down-list height="300px"/>`| **Property**: *height* <br/>`<ejs-dropdownlist height="300px"></ejs-dropdownlist>`|
| **Width** |	**Property**: *width* <br/>`<ej-drop-down-list width="300px"/>` | **Property**: *width* <br/>`<ejs-dropdownlist width="300px"></ejs-dropdownlist>`|

## Selection

<!-- markdownlint-disable MD010 -->
| Behavior	| API in Essential JS 1	| API in Essential JS 2 |
|--- | --- | --- |
| Selecting particular index | **Property**: *selected-index*<br/>`<ej-drop-down-list selected-index="3"/>` | **Property**: *index*<br/>`<ejs-dropdownlist index="3"></ejs-dropdownlist>` |
| **Selecting particular value** | **Property**: *value*<br/>`<ej-drop-down-list value="3"/>` | **Property**: *value*<br/>`<ejs-dropdownlist value="3"></ejs-dropdownlist>`|
| **Selecting particular text** | **Property**: *text* <br/>`<ej-drop-down-list text="3"/>`|**Property**: *text*<br/>`<ejs-dropdownlist text="data"></ejs-dropdownlist>` |
| **Target id** | **Property**: *targetId* <br/>`<ej-drop-down-list target-id="carsList"/>` | **Not applicable** |
| **Selecting item using text**	| **Method**: *selectItemByText* <br/>`<ej-drop-down-list/>`<br/> <br/>$('#dropdown').ejDropDownList('selectItemByText','car') |	**Not applicable** |
| **Unselect item using text** | **Method**: *unselectItemByText*<br/>`<ej-drop-down-list/>`<br/> <br/>$('#dropdown').ejDropDownList('unselectItemByText','car')| **Not applicable** |
| **Selecting item using value**| **Method**: *selectItemByValue*<br/>`<ej-drop-down-list/>`<br/> <br/>$('#dropdown').ejDropDownList('selectItemByValue','car') | **Not applicable** |
| **Getting data by using value** |	**Method**: *getItemDataByValue*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('unselectItemByValue','car')` | **Method**: *getDataByValue*<br/>`<ejs-dropdownlist></ejs-dropdownlist>`<br/><br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.getItemDataByValue("data");`|
| **Get selected value** | **Method**: *getSelectedItem*<br/>`<ej-drop-down-list/>`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedItem') |**Not applicable** |
| **Get selected text** | **Method**: *getSelectedText*<br/>`<ej-drop-down-list/>`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedText')| **Property**: *text*<br/>`<ejs-dropdownlist text="data"></ejs-dropdownlist>` |
| **Select event** | **Event**: *select*<br/>`<ej-drop-down-list select="onSelect"/>`| **Event**: *select*<br/>`<ejs-dropdownlist select="onSelect"></ejs-dropdownlist>`|
| **Addition of Html attributes** | **Property**: *html-attributes*<br/>`<ej-drop-down-list html-attributes="attrib"></ej-drop-down-list>`| **Property**: *htmlAttributes*<br/>`<ejs-dropdownlist htmlAttributes =" ="@ViewBag.attributes" />` |

## Common

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Adding new item** | **Method** : *addItem*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList("addItem", {text:"India"});` | **Method**: *addItem*<br/>`<ejs-dropdownlist/>`<br/> <br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.addItem({Id: 'game4', Game: 'Golf'}, 2);` |
| **Clearing the text**| **Method** : *clearText*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/> <br/>`$('#dropdown').ejDropDownList('clearText')` | **Property**:* showClearButton*<br/>`<ejs-dropdownlist showClearButton=true/>`|
| **Destroy the component** | **Method** : *destroy*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('destroy')`| **Method**: *destroy*<br/>`<ejs-dropdownlist/>`<br/> <br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.destroy;` |
| **Getting the data** | **Method** : *getListData*<br/>`<ej-drop-down-list></ej-drop-down-list>`<br/><br/>`$('#dropdown').ejDropDownList('getListData')` |**Method** : *getItems*<br/>`<ejs-dropdownlist/>`<br/><br/>`var ddlObj = document.getElementById(dropdownlist).ej2_Instances[0];`<br/><br/>`ddlObj.getItems;` |
| **Create event** | **Event**: *create*<br/>`<ej-drop-down-list create="onCreate"></ej-drop-down-list>` | **Event**: *created*<br/>`<ejs-dropdownlist created ="created" />` |
| **Destroy event** | **Event**: *destroy*<br/>`<ej-drop-down-list destroy="ondestroy"></ej-drop-down-list>`|**Event**: *destroyed*<br/>`<ejs-dropdownlist destroyed ="destroy" />` |
| **Cascade  event** | **Event**: *cascade*<br/>`<ej-drop-down-list cascade="cascade"></ej-drop-down-list>`|<https://ej2.syncfusion.com/demos/#/material/drop-down-list/cascading.html> |
| **Change event** | **Event**: *change*<br/>`<ej-drop-down-list create="change"></ej-drop-down-list>`| **Event**: *change*<br/>`<ejs-dropdownlist change ="change" />` |
| **Focus out event** |	**Event**: *focusOut*<br/>`<ej-drop-down-list focus-out="focus"></ej-drop-down-list>`| **Event**: *blur*<br/>`<ejs-dropdownlist blur ="blur" />`|
| **Focus in event**| **Event**: *focusIn*<br/><br/>`<ej-drop-down-list focus-in="focus"></ej-drop-down-list>` | **Event**: *focus*<br/>`<ejs-dropdownlist focus ="onfofus" />` |
