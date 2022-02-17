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
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** |	**Property**: *dataSource*<br/>`<ej-combo-box datasource="(IEnumerable<CarsList>)ViewBag.datasource"></ej-combo-box>` | **Property**: *dataSource*<br/>`<ejs-combobox dataSource="@ViewBag.data"></ejs-combobox>` |
| **Fields for mapping** | **Property**: *fields*<br/>`<ej-combo-box ><e-combo-box-fields text="text" /></ej-combo-box>` | **Property**: *fields*<br/>`<ejs-combobox> <e-combobox-fields text="Game" value="Id"></e-combobox-fields></ejs-combobox>` |
|**Query** | **Property**: *query*<br/>`<ej-combo-box id="searchCustomer" query="ej.Query().from('Suppliers').select('SupplierID', 'ContactName')"/>` | **Property**: *query*<br/>`<ejs-combobox query="@ViewBag.query"></ejs-combobox>` |
| **Begin event** | **Event**:*action-begin*<br/>`<ej-combo-box action-begin = "begin"/>` | **Event**: *actionBegin*<br/>`<ejs-combobox actionBegin="actionBegin"></ejs-combobox>` |
| **Complete event** | **Event**:*action-complete*<br/>`<ej-combo-box action-complete = "complete"/>` | **Event**: *actionComplete*<br/>`<ejs-combobox actionComplete="actionComplete"></ejs-combobox>` |
| **Failure event** | **Event**:*action-failure*<br/>`<ej-combo-box action-failure = "failure"/>` | **Event**: *actionFailure*<br/>`<ejs-combobox actionFailure="actionFailure"></ejs-combobox>` |

## Filtering

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *allow-filtering*<br/>`<ej-combo-box allow-filtering = "true"/>` | **Property**: *allowFiltering*<br/>`<ejs-combobox allowFiltering="true"></ejs-combobox>` |
| **No records template** | **Property**: *no-records-template*<br/>`<ej-combo-box no-records-template="<span class='norecord'> NO DATA AVAILABLE</span>"/>` | **Property**: *noRecordsTemplate*<br/>`<ejs-combobox noRecordsTemplate="<span class='norecord'> NO DATA AVAILABLE</span>"></ejs-combobox>` |
| **Ignore casing and diacritics** | **Not Applicable** | **Property**: *ignoreAccent*<br/>`<ejs-combobox ignoreAccent = "true"/>` |
| **Custom value addition** | **Property**: *allow-custom*<br/>`<ej-combo-box allow-custom = "true"/>` | **Property**: *allowCustom*<br/>`<ejs-combobox allowCustom = "true"/>` |
| **Search event** | **Event**: *filtering*<br/>`<ej-combo-box filtering = "filtering"/>` | **Event**: *filtering*<br/>`<ejs-combobox filtering = "onFiltering"/>` |

## Template

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *item-template*<br/>`<ej-combo-box item-template="<div><img class='eimg' src='../images/combobox/${eimg}.png' alt='employee'/><div class='ename'> ${text} </div><div class='temp'> ${country} </div></div>"/>` | **Property**: *itemTemplate*<br/>`<ejs-combobox itemTemplate="<div><img class='eimg' src='../images/combobox/${eimg}.png' alt='employee'/><div class='ename'> ${text} </div><div class='temp'> ${country} </div></div>"></ejs-combobox>`|
| **Group Template** | **Property**: *group-template*<br/>`<ej-combo-box group-template="<strong>${country}</strong>"/>` | **Property**: *groupTemplate*<br/>`<ejs-combobox groupTemplate="<strong>${country}</strong>"></ejs-combobox>` |
| **ValueTemplate** | **Not Applicable** | **Property**: *valueTemplate*<br/>`<ejs-combobox valueTemplate="<span class='norecord'> NO DATA AVAILABLE</span>"></ejs-combobox>` |
| **Header Template** | **Property**: *header-template*<br/>`<ej-combo-box header-template="<div class='head'>  Photo  <span style='padding-left:42px'> Contact Info </span></div>"/>` |	**Property**: *headerTemplate*<br/>`<ejs-combobox headerTemplate="<div class='head'>  Photo  <span style='padding-left:42px'> Contact Info </span></div>"></ejs-combobox>` |
| **FooterTemplate** | **Property**: *footer-template*<br/>`<ej-combo-box footer-template="<div class='Foot'> Total Items Count: 5 </div>"/>` | **Property**: *footerTemplate*<br/>`<ejs-combobox footerTemplate="<div class='Foot'> Total Items Count: 5 </div>"></ejs-combobox>` |
| **No records Template** |	**Property**: *no-records-template*<br/>`<ej-combo-box no-records-template="<span class='norecord'> NO DATA AVAILABLE</span>"/>` | **Property**: *noRecordsTemplate*<br/>`<ejs-combobox noRecordsTemplate="<span class='norecord'> NO DATA AVAILABLE</span>"></ejs-combobox>` |
| **Auto fill** | **Property**: *auto-fill*<br/>`<ej-combo-box auto-fill="true"/>` | **Property**: *autofill*<br/>`<ejs-combobox autoFill="true"></ejs-combobox>` |
| **Action failure Template** |	**Property**: *action-failure-template*<br/>`<ej-combo-box action-failure-template="<span class='action-failure'>Data fetch get fails</span>"/>` | **Property**: *actionFailureTemplate*<br/>`<ejs-combobox actionFailureTemplate="<span class='action-failure'>Data fetch get fails</span>"></ejs-combobox>` |

## Applying CSS

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *css-class* <br/>`<ej-combo-box css-class="customclass"/>` | **Property**: *cssClass*<br/>`<ejs-combobox cssClass="customclass"></ejs-combobox>` |
| **width** | **Property**: *width* <br/>`<ej-combo-box width="200px"/>` | **Property**: *width*<br/>`<ejs-combobox width="200px"></ejs-combobox>` |

## Grouping

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Default** | **Property**: *fields.groupBy*<br/>`<ej-combo-box><e-combo-box-fields group-by="SupplierID" /></ej-combo-box>` | **Property**: *fields.groupBy*<br/>`<ejs-combobox> <e-combobox-fields groupBy="Id"></e-combobox-fields></ejs-combobox>` |

## Accessibility

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Globalizaation** | **Property**: *locale*<br/>`<ej-combo-box locale="fr-FE"/>` | **Property**: *locale*<br/>`<ejs-combobox locale="fr-FE"/>` |
| **Rtl support** | **Property**: *enable-rtl*<br/>`<ej-combo-box enable-rtl="true"/>` | **Property**: *enableRtl*<br/>`<ejs-combobox enableRtl="true"/>` |

## Placeholder

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Watermark text** | **Property**: *placeholder*<br/>`<ej-combo-box placeholder="select"/>` | <br/>**Property**: *placeholder*<br/>`<ejs-combobox placeholder="select"/>` |
| **Floating  of waterMarkText** | **Not applicable** | **Property**: *floatLabelType*<br/>`<ejs-combobox floatLabelType="Auto"/>` |

## Miscellaneous

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Enable/disable** | **Property**: *enabled*<br/>`<ej-combo-box enabled="true"></ej-combo-box>` | **Property**: *enabled*<br/>`<ejs-combobox enabled="true"/>` |
| **Read only** | **Property**: *read-only*<br/>`<ej-combo-box read-only="true"></ej-combo-box>` | **Property**: *readOnly*<br/>`<ejs-combobox readOnly="true"/>` |
| **Addition of Html attributes** | **Property**: *html-Attributes*<br/>`<ej-combo-box html-attributes="@ViewBag.attr"></ej-combo-box>` | **Property**: *htmlAttributes*<br/>`<ejs-combobox htmlAttributes="@ViewBag.attr"/>` |

## Sorting

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Order of sorting** | **Property**: *sort-order*<br/>`<ej-combo-box sort-order="Ascending"></ej-combo-box>` | **Property**: *sortOrder*<br/>`<ejs-combobox sortOrder="Ascending"/>` |

## Selection

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 | API in Essential JS 2 |
|----------|-----------------------|-----------------------|
| **Selecting particular index** | **Property**: *index*<br/>`<ej-combo-box index="1"></ej-combo-box>` | **Property**: *index*<br/>`<ejs-combobox index="1"/>` |
| **Selecting particular value** | **Property**: *value*<br/>`<ej-combo-box value="car"></ej-combo-box>` | **Property**: *value*<br/>`<ejs-combobox value="car"/>` |
| **Selecting particular text** | **Property**: *text* <br/>`<ej-combo-box text="data"></ej-combo-box>` | **Property**: *text*<br/>`<ejs-combobox text="data"/>` |
| **Getting data by using value** |	**Method**: *getItemDataByValue*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejDropDownList('getItemDataByValue',"data") | **Method**: *getDataByValue*<br/>`<ejs-combobox />`<br/> <br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.getDataByValue("data"); |
| **Select event** | **Event**: *select*<br/>`<ej-combo-box select="onSelect"></ej-combo-box>` | **Event**: *select*<br/>`<ejs-combobox select="onSelect"/>` |

## Popup

<!-- markdownlint-disable MD010 -->
| Behavior| API in Essential JS 1 | API in Essential JS 2 |
| --- | --- | --- |
| **Popup height** | **Property**: *popup-height*<br/>`<ej-combo-box popup-height="300px"></ej-combo-box>`|**Event**:*popupHeight*<br/>`<ejs-combobox popupHeight="300px"/>`|
| **Popup width** | **Property**: *popup-width*<br/>`<ej-combo-box popup-width="300px"></ej-combo-box>`|**Event**:*popupWidth*<br/>`<ejs-combobox popupWidth="300px"/>` |
| **Popup showing manually** | **Method**: *showPopup*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejComboBox("showPopup");|	**Method**: *showPopup*<br/>`<ejs-combobox />`<br/> <br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/>cmbObj.showPopup(); |
| **Popup hiding manually** | **Method**: *hidePopup*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejComboBox("hidePopup"); | **Method**: *hidePopup*<br/>`<ejs-combobox />`<br/> <br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.hidePopup(); |
| **Popup hide event** | **Event**: *close*<br/>`<ej-combo-box close="onClose"></ej-combo-box>` | **Event**: *close*<br/>`<ejs-combobox close="onClose"/>`|
| **Popup shown event** | **Event**: *open*<br/>`<ej-combo-box open="open"></ej-combo-box>`| **Event**: *open*<br/>`<ejs-combobox open="onopen"/>`|

## Common

<!-- markdownlint-disable MD010 -->
| Behavior | API in Essential JS 1 |API in Essential JS 2 |
| --- | --- | --- |
| **Adding new item** | **Method** : *addItem*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejComboBox("addItem", { text :"India"});| **Method**: *addItem*<br/>`<ejs-combobox />`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.addItem({Id: 'id', Game: 'Golf'},2);|
| **Focus out event** | **Not applicable** | **Event**: *blur*<br/>`<ejs-combobox blur="onblur"/>` |
| **Focus in event** | **Event**: *focus*<br/>`<ej-combo-box focus="focus"></ej-combo-box>` | **Event**: *focusIn*<br/>`<ejs-combobox focusIn="onopen"/>` |
| **Focus out** | **Method**: *focusOut*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejComboBox("focusOut");| **Method**: *focusOut*<br/>`<ejs-combobox />`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.focusOut(); |
| **Focus in** | **Method**: *focusIn*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejComboBox("focusIn"); | **Method**: *focusIn*<br/>`<ejs-combobox />`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.focusIn(); |
| **Getting the data** | **Method** : *getItems*<br/>`<ej-combo-box></ej-combo-box>` <br/> <br/>$('#dropdown').ejComboBox("getItems"); | **Method**: *getItems*<br/>`<ejs-combobox />`<br/><br/>var cmbObj = document.getElementById(combobox).ej2_Instances[0];<br/><br/> cmbObj.getItems();|
| **Create event** | **Event**: *create*<br/>`<ej-combo-box create="create"></ej-combo-box>` |	**Event**: *created*<br/>`<ejs-combobox created="created"/>` |
| **Change event** | **Event**: *change*<br/>`<ej-combo-box change="change"></ej-combo-box>` | **Event**: *change*<br/>`<ejs-combobox change="change"/>` |
| **Custom value event** | **Event**: *custom-value-specifier*<br/>`<ej-combo-box custom-value-specifier="customValueSpecifier"></ej-combo-box>` | **Event**: *customValueSpecifier*<br/>`<ejs-combobox customValueSpecifier="event"/>` |
