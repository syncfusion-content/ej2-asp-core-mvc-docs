---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Multi Select Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of multiselect component from Essential JS 1 to Essential JS 2.

## Accessibility and Localization

<!-- markdownlint-disable MD033 -->
<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Localization | **Property** : locale<br/> <br/>`<ej-drop-down-list locale="en-US"></ej-drop-down-list>` | **Property** : locale<br/> <br/>`<ejs-multiselect locale="en-US" />`  |
| Right to left | **Property:** enable-rtl <br/> <br/>`<ej-drop-down-list enable-rtl="true"></ej-drop-down-list>` | **Property:** enableRtl<br/> <br/>`<ejs-multiselect enableRtl="true" /> ` |

## Animation

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Animation | **Property** : enable-animation<br/> <br/>`<ej-drop-down-list enable-animation="true "></ej-drop-down-list>` |  Not Applicable  |

## Template

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Header Template | **Property** : header-template<br/> <br/>`<ej-drop-down-list header-template="<div class='eheader'><span>PHOTO</span> <span>DETAILS</span></div>" ></ej-drop-down-list>` |  **Property** : headerTemplate<br/> <br/>`<ejs-multiselect headerTemplate="@Html.Raw("<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>")" />`  |
| Item Template | **Property** : item-template<br/> <br/>`<ej-drop-down-list template="<div><div class='ename'> ${Text} </div></div>" ></ej-drop-down-list>` |  **Property** : itemTemplate<br/> <br/>`<ejs-multiselect itemTemplate="@Html.Raw("<span class='item' ><span class='name'>${FirstName}</span><span class='city'>${City}</span></span>")"/>`  |
| Footer Template | **Property** : Not Applicable |  **Property** : footerTemplate<br/> <br/>`<ejs-multiselect footerTemplate="@Html.Raw("<span class='foot'> Total list items: " + 4 + "</span>")"/>`  |
| Group Template | **Property** : Not Applicable |  **Property** : groupTemplate<br/> <br/>`<ejs-multiselect groupTemplate="@Html.Raw("<strong>${City}</strong>")"/>`  |
| Value Template | **Property** : Not Applicable |  **Property** : valueTemplate<br/> <br/>`<ejs-multiselect valueTemplate="@Html.Raw("<div><span class='name'>${FirstName}</span><span class ='city'>${City}</span></div>")" />`  |
| No Records Template | **Property** : Not Applicable |  **Property** : noRecordsTemplate<br/> <br/>`<ejs-multiselect noRecordsTemplate="@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")"/>`  |
| Action Failure Template | **Property** : Not Applicable |  **Property** : actionFailureTemplate<br/> <br/>`<ejs-multiselect actionFailureTemplate="@Html.Raw("<span class='action-failure'> Data fetch get fails</span>")" />`  |

## Data Binding

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Data Source | **Property** : data-source<br/> <br/>`<ej-drop-down-list data-source="(IEnumerable&lt; groups>)ViewBag.datasource"></ej-drop-down-list>` |  **Property** : dataSource <br/><br/> `<ejs-multiselect dataSource="@ViewBag.data" /> `  |
| Query| **Property** : query<br/> <br/>`<ej-drop-down-list query="ej.Query().from('Customers').take(6)"><e-datamanager url="https://mvc.syncfusion.com/Services/Northwnd.svc/"></e-datamanager><e-drop-down-list-fields text="CustomerID" table-name="Customers" /></ej-drop-down-list>` |  **Property** : query<br/> <br/>`<ejs-multiselect query="new ej.data.Query().from('Customers').select(['ContactName','CustomerID']).take(6)"><e-multiselect-fields text="ContactName" value="CustomerID"></e-multiselect-fields><e-datamanager url=http://services.odata.org/V4/Northwind/Northwind.svc/ adaptor="ODataV4Adaptor" crossDomain="true"></e-datamanager></ejs-multiselect> ` |
| Fields | **Property** : fields<br/> <br/>`<ej-drop-down-list datasource="(IEnumerable&lt; groups>)ViewBag.datasource<e-drop-down-list-fields text="CustomerID" table-name="Customers" /></ej-drop-down-list>` |  **Property** : fields<br/> <br/>`<ejs-multiselect dataSource = "@ViewBag.data"><e-multiselect-fields text="ContactName" value="CustomerID"></e-multiselect-fields></ejs-multiselect> `  |
| Action Begin | **Event** : action-begin<br/> <br/>`<ej-drop-down-list action-begin="onActionBeign" />` |  **Event** : actionBegin<br/> <br/>`<ejs-multiselect actionBegin=" onactionBegin"/>`  |
| Action Complete | **Event** : action-complete<br/> <br/>`<ej-drop-down-list action-complete=" onActionComplete" />` |  **Event** : actionComplete<br/> <br/>`<ejs-multiselect actionComplete=" onActionComplete"/> `  |
| Action Failure | **Event** : action-failure<br/> <br/>`<ej-drop-down-list action-failure="onActionFailure" />` |  **Event** : actionFailure<br/> <br/>`<ejs-multiselect actionFailure =" onActionFailure"/>`  |
| Action Success | **Event** : action-success<br/> <br/>`<ej-drop-down-list action-success="onActionSuccess" />` | Not Applicable  |
| Data Bound | **Event** : data-bound<br/> <br/>`<ej-drop-down-list data-bound="onBound" />` |  **Event** : dataBound<br/> <br/>`<ej-multiselect dataBound ="onBound" />`  |

## Filtering

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Filtering | **Property** : enable-filter-search<br/> <br/>`<ej-drop-down-list enable-filter-search = "true" ></ej-drop-down-list>` |  **Property** : allowFiltering<br/> <br/>`<ejs-multiselect allowFiltering ="true" />`  |
| Server Filtering | **Property** : enable-server-filtering<br/> <br/>`<ej-drop-down-list enable-server-filtering = "true" ></ej-drop-down-list>` |  **Event** : filtering<br/> <br/>`<ej-multiselect filtering="onFiltering" />`  |
| Sorting | **Property** : enable-sorting<br/> <br/>`<ej-drop-down-list enable-sorting = "true" ></ej-drop-down-list>` |  **Property** : sortOrder<br/> <br/>`<ejs-multiselect sortOrder =" Ascending " />`  |
| Case Sensitive Search | **Property** : case-sensitive-search<br/> <br/>`<ej-drop-down-list case-sensitive-search ="true"></ej-drop-down-list>` |  **Property** : ignoreCase<br/> <br/>`<ejs-multiselect ignoreCase=" custom-style" /> `  |
| Ignore Accent | Not Applicable |  **Property** : ignoreAccent<br/> <br/>`<ejs-multiselect ignoreAccent ="true"/> `  |
| Filter Bar Placeholder | Not Applicable |  **Property** : filterBarPlaceholder<br/> <br/>`<ejs-multiselect mode="CheckBox" filterBarPlaceholder ="Search Employee"/>`  |
| Search | **Event** : search<br/> <br/>`<ej-drop-down-list search="onSearch" />` |  **Event** : filtering<br/> <br/>`<ej-multiselect filtering="onFiltering" /> `  |

## Popups

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Popup Resize | **Property** : enable-popup-resize<br/> <br/>`<ej-drop-down-list enable-popup-resize = "true" ></ej-drop-down-list>` | Not Applicable |
| Maximum Popup Height | **Property** : max-popup-height<br/> <br/>`<ej-drop-down-list max-popup-height="300px" />` | Not Applicable |
| Minimum  Popup Height | **Property** : min-popup-height<br/> <br/>`<ej-drop-down-list min-popup-height="200px" />` | Not Applicable |
| Maximum Popup Width | **Property** : max-popup-width<br/> <br/>`<ej-drop-down-list max-popup-width="200px" />` | Not Applicable |
| Maximum Popup Width | **Property** : min-popup-width<br/> <br/>`<ej-drop-down-list max-popup-width="100px" />` | Not Applicable |
| Popup Height | **Property** : popup-height<br/> <br/>`<ej-drop-down-list popup-feight="500px" />` |  **Property** : popupHeight<br/> <br/>`<ejs-multiselect popupHeight ="500px" /> `  |
| Popup Width | **Property** : popup-width <br/> <br/>`<ej-drop-down-list popup-width="500px" />` |  **Property** : popupWidth<br/> <br/>`<ejs-multiselect popupWidth="500px" /> `  |
| Show Popup On Load | **Property** : show-popup-on-load <br/> <br/>`<ej-drop-down-list show-popup-on-load ="true" />` | Not Applicable |
| Close Popup On Select | Not Applicable | **Property** : closePopupOnSelect <br/> <br/>`<ejs-multiselect closePopupOnSelect =" true"/>` |
| Open On Click | Not Applicable | **Property** : openOnClick <br/> <br/>`<ejs-multiselect openOnClick ="true"/>` |
| hidePopup | **Method** : hidePopup <br/> <br/>`<ej-drop-down-list />`<br/> <br/>$('#dropdown').ejDropDownList('hidePopup') | **Method** : hidePopup <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.hidePopup()` |
| showPopup | **Method** : showPopup <br/> <br/>`<ej-drop-down-list />`<br/> <br/>$('#dropdown').ejDropDownList('showPopup') | **Method** : showPopup <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.showPopup()` |
| Popup Hide | **Event** : popup-hide<br/> <br/>`<ej-drop-down-list popup-hide="onPopupHide" />` |  **Event** : close<br/> <br/>`<ej-multiselect close ="onClose" />`  |
| Popup Shown | **Event** : popup-shown<br/> <br/>`<ej-drop-down-list popup-shown="onPopupShow" />` |  **Event** : open<br/> <br/>`<ej-multiselect open ="onOpen" />`  |
| Popup Resize | **Event** : popup-resize<br/> <br/>`<ej-drop-down-list popup-resize="onPopupResize" />` | Not Applicable |
| Popup Resize Start | **Event** : popup-resize-start<br/> <br/>`<ej-drop-down-list popup-resize-start="onPopupResizeStart" />` | Not Applicable |
| Popup Resize Stop | **Event** : popup-resize-stop<br/> <br/>`<ej-drop-down-list popup-resize-stop="onPopupResizeStop" />` | Not Applicable |
| Before Popup Hide | **Event** : before-popup-hide<br/> <br/>`<ej-drop-down-list before-popup-hide="onPopupHide" />` | Not Applicable |
| Before Popup Shown | **Event** : before-popup-shown<br/> <br/>`<ej-drop-down-list before-popup- shown ="onPopupShown" />` | Not Applicable |

## Selection

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Selected Index| **Property** : selected-index<br/> <br/>`<ej-drop-down-list selected-index="2" />` | Not Applicable |
| Selected Indices | **Property** : selected-Indices <br/> <br/>`@{List<int> index= new List<int> { 1,2 };}`<br/> <br/>`<ej-drop-down-list selected-indices ="index" />` | **Property** : value <br/><br/> `viewBag.vlue = [1,2]` <br/><br/> `<ejs-multiselect value = "@ViewBag.value"/>` |
| Maximum Selection Length | Not Applicable | **Property** : maximumSelectionLength <br/><br/> `<ejs-multiselect maximumSelectionLength ="5"/>` |
| Select All Text | Not Applicable | **Property** : selectAllText <br/><br/> `<ejs-multiselect mode="CheckBox" selectAllText ="Check All"/>` |
| Un Select All Text | Not Applicable | **Property** : unSelectAllText <br/><br/> `<ejs-multiselect mode="CheckBox" unSelectAllText ="Un Check All"/>` |
| Selection Order | Not Applicable | **Property** : enableSelectionOrder <br/><br/> `<ejs-multiselect mode="CheckBox" enableSelectionOrder ="true"/> ` |
| Hide Selected Item | Not Applicable | **Property** : hideSelectedItem <br/><br/> `<ejs-multiselect hideSelectedItem ="true"/> ` |
| Get Selected Item | **Method** : getSelectedItem() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedItem') | **Property** : value <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.value` |
| Get Selected Value | **Method** : getSelectedValue() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedValue') | **Property** : value <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.value` |
| Select Items By Indices | **Method** : selectItemsByIndices() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.selectItemsByIndices("2,3") | Not Applicable |
| Select Item By Text | **Method** : selectItemByText() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.selectItemByText("Computer IT ,Comics ") | Not Applicable |
| Select Item By Value | **Method** : selectItemByValue() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.selectItemByValue("Computer IT ,Comics ") | Not Applicable |
| Un select Items By Indices | **Method** : unselectItemsByIndics() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unselectItemsByIndices ("2,3") | Not Applicable |
| Un select Item By Text | **Method** : unselectItemByText() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unselectItemByText ("Computer IT ,Comics ") | Not Applicable |
| Un select Item By Value | **Method** : unselectItemByValue() <br/> <br/>`<ej-drop-down-list />`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unselectItemByValue ("Computer IT ,Comics ") | Not Applicable |
| Selected All | **Method** : checkAll() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.checkAll() | **Method** : selectAll(boolean) <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.selectAll(true)` |
| Un Selected All | **Method** : unCheckAll() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unCheckAll() | **Method** : selectAll(boolean) <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.selectAll(false)` |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Virtual Scrolling| **Property** : allow-virtual-scrolling<br/> <br/>`<ej-drop-down-list allow-virtual-scrolling ="true "></ej-drop-down-list>` | It will be acheived in sample level using `actionComplete` event |
| Virtual Scroll Mode | **Property** : virtual-scroll-mode<br/> <br/>`<ej-drop-down-list allow-virtual-scrolling ="true" virtual-scroll-mode=@VirtualScrollMode.Normal></ej-drop-down-list>` | Not Applicable |
| Custom class | **Property** : css-class<br/> <br/>`<ej-drop-down-list cssClass ="custom-style"></ej-drop-down-list>` | **Property** : cssClass<br/> <br/>`<ejs-multiselect cssClass=" custom-style" />` |
| Delimiter Char | **Property** : delimiter-char<br/> <br/>`<ej-drop-down-list delimiter-char = "." ></ej-drop-down-list>` |  **Property** : delimiterChar<br/> <br/>`<ejs-multiselect delimiterChar ="." />` |
| Enable | **Property** : enable<br/> <br/>`<ej-drop-down-list enable = "true" ></ej-drop-down-list>` |  **Property** : enabled <br/> <br/>`<ejs-multiselect enabled ="true" />` |
| Persistence | **Property** : enable-persistence<br/> <br/>`<ej-drop-down-list enable-persistence = "true" ></ej-drop-down-list>` |  **Property** : enablePersistence <br/> <br/>`<ejs-multiselect enablePersistence ="true" /> ` |
| Load On Demand | **Property** : load-on-demand<br/> <br/>`<ej-drop-down-list load-on-demand = "true" ></ej-drop-down-list>` | By default, provided load on demand support |
| Height | **Property** : height<br/> <br/>`<ej-drop-down-list height= "100" ></ej-drop-down-list>` | Not Applicable |
| Html Attributes | **Property** : html-attributes <br/> <br/>`<ej-drop-down-list html-attributes="@ViewBag.attributes" />` |  **Property** : htmlAttributes <br/> <br/>`<ejs-multiselect htmlAttributes =" ="@ViewBag.attributes" /> ` |
| Width | **Property** : width <br/> <br/>`<ej-drop-down-list width="500px" />` |  **Property** : width <br/> <br/>`<ejs-multiselect width="500px" />` |
| Mode | **Property** : multi-select-mode <br/> <br/>`<ej-drop-down-list multi-select-mode="@MultiSelectModeTypes.Delimiter" />` |  **Property** : mode <br/><br/>` 1. Delimeter `<br/><br/>` 2. Box `<br/><br/>` 3. Default `<br/><br/>` 4. CheckBox `<br/><br/> `<ejs-multiselect mode="Delimiter" />` |
| Read Only | **Property** : read-only <br/> <br/>`<ej-drop-down-list read-oly="true" />` |  **Property** : readonly <br/><br/> `<ejs-multiselect readonly ="true" />` |
| Checkbox | **Property** : show-checkbox <br/> <br/>`<ej-drop-down-list show-checkbox="true" />` |  **Property** : mode <br/><br/> `<ejs-multiselect mode="CheckBox" />` |
| Rounded Corner | **Property** : show-rounded-corner <br/> <br/>`<ej-drop-down-list show-rounded-corner ="true" />` | Not Applicable |
| Target ID | **Property** : target-id <br/> <br/>`<ej-drop-down-list id="customerList" target-id="mailtoolslist"></ej-drop-down-list><div id="mailtoolslist"><ul><li><div class="mailtools categorize"></div>Categorize and Move</li></ul></div>` | Not Applicable |
| Text | **Property** : text <br/> <br/>`<ej-drop-down-list text ="Employee Name" />` |  **Property** : text <br/><br/> `<ejs-multiselect text="Employee Name" />` |
| Validation Message | **Property** : validation-message <br/> <br/>`<ej-drop-down-list validation-message="@viewBag.validation" />` |  The default error message for a rule can be customizable by defining it along with concern rule. |
| Validation Rules | **Property** : validation-rules <br/> <br/>`<ej-drop-down-list validation-rules="@viewBag.validation" />` |  Use Form validator to validate the multiselect component and set validation rules. |
| Value | **Property** : value <br/> <br/>`<ej-drop-down-list value ="Employee Value" />` |  **Property** : value <br/><br/> `<ejs-multiselect value="@ViewBag.value"/>` |
| Watermark Text | **Property** : watermark-text <br/> <br/>`<ej-drop-down-list watermark-text="Select employee"/>` |  **Property** : placeholder <br/><br/> `<ejs-multiselect placeholder =" Select employee"/>` |
| Custom Value | Not Applicable |  **Property** : allowCustomValue <br/><br/> `<ejs-multiselect mode=”Default”  allowCustomValue=" true"/> ` |
| Clear Button | Not Applicable |  **Property** : showClearButton <br/><br/> `<ejs-multiselect showClearButton ="true"/>` |
| DropDown Icon | Not Applicable |  **Property** : showDropDownIcon <br/><br/> `<ejs-multiselect showDropDownIcon ="true"/>` |
| Show Select All | Not Applicable |  **Property** : showSelectAll <br/><br/> `<ejs-multiselect showSelectAll ="true"/>` |
| z-Index | Not Applicable |  **Property** : zIndex <br/><br/> `<ejs-multiselect zIndex ="10000"/>` |
| Add Item | **Method** : addItem(object) <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.addItem({ text :"new item"});  | **Method** : addItem(object) <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.addItem({ text :"new item"})` |
| Clear Text| **Method** : clearText() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.clearText();  | **Property** : value <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.value = null` |
| destroy| **Method** : destroy() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.destroy();  | **Property** : destroy <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.destroy()` |
| Disable| **Method** : disable() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.disable();  | **Property** : enabled <br/> <br/>`<ejs-multiselect enabled ="false" />` |
| Enable| **Method** : enable() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.enable();  | **Property** : enabled <br/> <br/>`<ejs-multiselect enabled ="true" />` |
| Disable Items By Indices| **Method** : disableItemsByIndics() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.disableItemsByIndics(“3,4,5”);  | Not Applicable |
| Enable  Items By Indices| **Method** : enableItemsByIndices() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.enableItemsByIndices(“3,4,5”);  | Not Applicable |
| Get Item Data By Value | **Method** : getItemDataByValue("value") <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.getItemDataByValue("value");  | **Method** : getDataByValue("value") <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.getDataByValue(“value”)` |
| Get List Data | **Method** : getListData() <br/> <br/>`<ej-drop-down-list />`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.getListData();  | Not Applicable |
| Hide Spinner | Not Applicable  | **Method** : hideSpinner() <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.hideSpinner()` |
| Show Spinner | Not Applicable  | **Method** : showSpinner() <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.showSpinner()` |
| Refresh | Not Applicable  | **Method** : refresh() <br/> <br/>`<ejs-multiselect/>`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.refresh()` |
| Change | **Event** : change<br/> <br/>`<ej-drop-down-list change="onChange" />` |  **Event** : change<br/> <br/>`<ejs-multiselect change=" onChange"/>`  |
| Check Change | **Event** : check-change<br/> <br/>`<ej-drop-down-list check-change ="onCheckChange" />` |  Not Applicable  |
| Create | **Event** : create <br/> <br/>`<ej-drop-down-list create="onCreate" />` |  **Event** : created <br/> <br/>`<ejs-multiselect created="onCreate" />`  |
| Destroy | **Event** : destroy <br/> <br/>`<ej-drop-down-list destroy="onDestroy" />` |  **Event** : created <br/> <br/>`<ejs-multiselect destroy="onDestroy" />`  |
| Focus In | **Event** : focus-in <br/> <br/>`<ej-drop-down-list focus-in="onFocusIn" />` |  **Event** : focus <br/> <br/>`<ejs-multiselect focus="onFocus" />`  |
| Focus Out | **Event** : focus-out <br/> <br/>`<ej-drop-down-list focus-out="onFocusOut" />` |  **Event** : blur <br/> <br/>`<ej-multiselect blur="onBlur" />`  |
| Chip Selection | Not Applicable |  **Event** : chipSelection <br/> <br/>`<ej-multiselect mode="Box" chipSelection ="onChipSelection " />`  |
| Custom Value Selection | Not Applicable |  **Event** : customValueSelection <br/> <br/>`<ej-multiselect mode="Box" customValueSelection ="onCustomValSel "/>`  |
| Removed | Not Applicable |  **Event** : removed <br/> <br/>`<ej-multiselect removed ="onRemoved" />`  |
| Removing | Not Applicable |  **Event** : removing <br/> <br/>`<ej-multiselect removing ="onRemoving" />`  |
| Tagging | Not Applicable |  **Event** : tagging <br/> <br/>`<ej-multiselect tagging ="onTagging" />`  |