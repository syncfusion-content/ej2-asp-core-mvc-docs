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
| Localization | **Property** : Locale<br/> <br/>`@Html.EJ().DropDownList("locale").Locale("de-DE")` | **Property** : Locale<br/> <br/>`@Html.EJS().MultiSelect("locale").Locale("de-DE").Render()`  |
| Right to left | **Property:** EnableRTL<br/><br/>`@Html.EJ().DropDownList("rtl").EnableRTL(true)` | **Property:** EnableRtl<br/> <br/>`@Html.EJS().MultiSelect("rtl").EnableRtl(true).Render()` |

## Animation

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Animation | **Property** : EnableAnimation<br/> <br/>`@Html.EJ().DropDownList("default").EnableAnimation(true)` |  Not Applicable  |

## Template

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Header Template | **Property** : HeaderTemplate<br/> <br/>`@Html.EJ().DropDownList("DropDownList1").Datasource((IEnumerable<Employee1>)ViewData["LocalDataSource"]).HeaderTemplate("<div class='eheader'><span>PHOTO</span> <span>DETAILS</span></div>")` |  **Property** : HeaderTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").HeaderTemplate("<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>").Render()` |
| Item Template | **Property** :ItemTemplate<br/> <br/>` @Html.EJ().DropDownList("DropDownList1").Datasource((IEnumerable<Employee1>)ViewData["LocalDataSource"]).Template("<div><Image class='ImageId' src='../Content/Employees/${Image}.png' alt='employee'/> <div class='ename'> ${Text} </div><div class='role'> ${Role} </div><div class='cont'> ${Country} </div></div>")` |  **Property** : ItemTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").ItemTemplate("<div><span class='name'>${FirstName}</span><span class ='city'>${City}</span></div>").Render()`  |
| Footer Template | **Property** : Not Applicable |  **Property** : FooterTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").FooterTemplate("<span class='foot'> Total list items: " + 4 + "</span>").Render()`  |
| Group Template | **Property** : Not Applicable |  **Property** : GroupTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").GroupTemplate("<strong>${City}</strong>").Render()`  |
| Value Template | **Property** : Not Applicable |  **Property** : ValueTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").ValueTemplate("<span>${FirstName} - ${City}</span>").Render()`  |
| No Records Template | **Property** : Not Applicable |  **Property** : NoRecordsTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").NoRecordsTemplate("<span class='norecord'> NO DATA AVAILABLE</span>").Render()`  |
| Action Failure Template | **Property** : Not Applicable |  **Property** : actionFailureTemplate<br/> <br/>`@Html.EJS().MultiSelect("remote").ActionFailureTemplate("<span class='action-failure'> Data fetch get fails</span>").Render()`  |

## Data Binding

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Data Source | **Property** : Datasource<br/> <br/>`@Html.EJ().DropDownList("DropDownList1").Datasource((IEnumerable<Employee>)ViewData["LocalDataSource"]).DropDownListFields(Df => Df.Text("Text").Value("Country"))` |  **Property** : Datasource <br/><br/> ` @Html.EJS().MultiSelect("default").DataSource((IEnumerable<object>)ViewBag.localdata).Render()`  |
| Query| **Property** : Query<br/> <br/>`@Html.EJ().DropDownList("customerList").Datasource(ds => ds.URL("https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/").CrossDomain(true)).Query("ej.Query().from('Customers').take(6)").DropDownListFields(f => f.Text("CustomerID"))` |  **Property** : Query<br/> <br/>`@Html.EJS().MultiSelect("remote").Query((string)ViewBag.query).DataSource(obj => obj.Url("http://services.odata.org/V4/Northwind/Northwind.svc/").CrossDomain(true).Adaptor("ODataV4Adaptor")).Fields( new MultiSelectFieldSettings { Text = "FirstName", Value = "EmployeeID" }).Render()` |
| Fields | **Property** : Fields<br/> <br/>`@Html.EJ().DropDownList("customerList").Datasource(ds => ds.URL("https://js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/").CrossDomain(true)).Query("ej.Query().from('Customers').take(6)").DropDownListFields(f => f.Text("CustomerID"))` |  **Property** : Fields<br/> <br/>`@Html.EJS().MultiSelect("remote").Query((string)ViewBag.query).DataSource(obj => obj.Url("http://services.odata.org/V4/Northwind/Northwind.svc/").CrossDomain(true).Adaptor("ODataV4Adaptor")).Fields( new MultiSelectFieldSettings { Text = "FirstName", Value = "EmployeeID" }).Render()`  |
| Action Begin | **Event** : ActionBegin<br/> <br/>` @Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.ActionBegin("onActionBegin")` |  **Event** : ActionBegin<br/> <br/>`@Html.EJS().MultiSelect("list").ActionBegin("onActionBegin").Render()`  |
| Action Complete | **Event** : ActionComplete<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.ActionComplete("onActionComplete")` |  **Event** : ActionComplete<br/> <br/>`@Html.EJS().MultiSelect("list").ActionComplete("onActionComplete").Render()`  |
| Action Failure | **Event** : ActionFailure<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.ActionFailure("onActionFailure")` |  **Event** : ActionFailure<br/> <br/>`@Html.EJS().MultiSelect("list").ActionFailure("onActionFailure").Render()`  |
| Action Success | **Event** :ActionSuccess<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.ActionSuccess("onActionSuccess")` | Not Applicable  |
| Data Bound | **Event** : DataBound<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.DataBound("onDataBound")` |  **Event** : DataBound<br/> <br/>`@Html.EJS().MultiSelect("list").DataBound("onDataBound").Render()`  |

## Filtering

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Filtering | **Property** : EnableFilterSearch<br/> <br/>`@Html.EJ().DropDownList("default").EnableFilterSearch(true)` |  **Property** : AllowFiltering<br/> <br/>`@Html.EJS().MultiSelect("default").AllowFiltering(true).Render()`  |
| Server Filtering | **Property** : EnableServerFiltering<br/> <br/>`@Html.EJ().DropDownList("default").EnableServerFiltering(true)` |  **Event** : Filtering<br/> <br/>`@Html.EJS().MultiSelect("list").Filtering("onFiltering").Render()`  |
| Sorting | **Property** : EnableSorting<br/> <br/>`@Html.EJ().DropDownList("default").EnableSorting(true)` |  **Property** : SortOrder<br/> <br/>`@Html.EJS().MultiSelect("default").SortOrder('Ascending').Render()`  |
| Case Sensitive Search | **Property** : CaseSensitiveSearch<br/> <br/>`@Html.EJ().DropDownList("default").CaseSensitiveSearch(true)` |  **Property** : IgnoreCase<br/> <br/>`@Html.EJS().MultiSelect("default").IgnoreCase(true).Render()`  |
| Ignore Accent | Not Applicable |  **Property** : IgnoreAccent<br/> <br/>`@Html.EJS().MultiSelect("default").IgnoreAccent(true).Render() `  |
| Filter Bar Placeholder | Not Applicable |  **Property** : FilterBarPlaceholder<br/> <br/>`@Html.EJS().MultiSelect("default").Mode('CheckBox').FilterBarPlaceholder('search the value').Render()`  |
| Search | **Event** : Search<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.Search("onSearch")` |  **Event** : Filtering<br/> <br/>`@Html.EJS().MultiSelect("list").Filtering("onFiltering").Render() ` |

## Popups

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Popup Resize | **Property** : EnablePopupResize<br/> <br/>`@Html.EJ().DropDownList("default").EnablePopupResize(true)` | Not Applicable |
| Maximum Popup Height | **Property** : MaxPopupHeight<br/> <br/>`@Html.EJ().DropDownList("default").MaxPopupHeight(300)` | Not Applicable |
| Minimum  Popup Height | **Property** : MinPopupHeight<br/> <br/>`@Html.EJ().DropDownList("default").MinPopupHeight(200)` | Not Applicable |
| Maximum Popup Width | **Property** : MaxPopupWidth<br/> <br/>`@Html.EJ().DropDownList("default").MaxPopupWidth(300)` | Not Applicable |
| Minimum Popup Width | **Property** : MinPopupWidth<br/> <br/>`@Html.EJ().DropDownList("default").MinPopupWidth(100)` | Not Applicable |
| Popup Height | **Property** : PopupHeight<br/> <br/>`@Html.EJ().DropDownList("default").PopupHeight(500)` |  **Property** : PopupHeight<br/> <br/>`@Html.EJS().MultiSelect("default").PopupHeight(500).Render() ` |
| Popup Width | **Property** : PopupWidth <br/> <br/>`@Html.EJ().DropDownList("default").PopupWidth(300)` |  **Property** : popupWidth<br/> <br/>`@Html.EJS().MultiSelect("default").popupWidth(300).Render() `  |
| Show Popup On Load | **Property** : showPopupOnLoad <br/> <br/>`@Html.EJ().DropDownList("default").showPopupOnLoad(true)` | Not Applicable |
| Close Popup On Select | Not Applicable | **Property** : ClosePopupOnSelect <br/> <br/>`@Html.EJS().MultiSelect("default").ClosePopupOnSelect(true).Render()` |
| Open On Click | Not Applicable | **Property** : OpenOnClick <br/> <br/>`@Html.EJS().MultiSelect("default").OpenOnClick(true).Render()` |
| hidePopup | **Method** : hidePopup <br/> <br/>`@Html.EJ().DropDownList("default")`<br/> <br/>$('#dropdown').ejDropDownList('hidePopup') | **Method** : hidePopup <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.hidePopup()` |
| showPopup | **Method** : showPopup <br/> <br/>`@Html.EJ().DropDownList("default")`<br/> <br/>$('#dropdown').ejDropDownList('showPopup') | **Method** : showPopup <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.showPopup()` |
| Popup Hide | **Event** : PopupHide<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.PopupHide("onPopupHide")` |  **Event** : Close<br/> <br/>`@Html.EJS().MultiSelect("list").Close("onClose").Render()`  |
| Popup Shown | **Event** : PopupShown<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.PopupShown("onPopupShown")` |  **Event** : Open<br/> <br/>`@Html.EJS().MultiSelect("list").Open("onOpen").Render()`  |
| Popup Resize | **Event** : PopupResize<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.PopupResize("onPopupResize")` | Not Applicable |
| Popup Resize Start | **Event** : PopupResizeStart<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.PopupResizeStart("onPopupResizeStart")` | Not Applicable |
| Popup Resize Stop | **Event** : PopupResizeStop<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.PopupResizeStop("onPopupResizeStop")` | Not Applicable |
| Before Popup Hide | **Event** : BeforePopupHide<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.BeforePopupHide("onBeforePopupHide")` | Not Applicable |
| Before Popup Shown | **Event** : BeforePopupShown<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.BeforePopupShown("onBeforePopupShown")` | Not Applicable |

## Selection

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Selected Index| **Property** : SelectedIndex<br/> <br/>`@Html.EJ().DropDownList("default").SelectedIndex(2)` | Not Applicable |
| Selected Indices | **Property** : SelectedIndices <br/> <br/>`@Html.EJ().DropDownList("default").ShowCheckbox(true).SelectedIndices(new List<int> { 1,2 })` | **Property** : Value <br/><br/> `viewBag.vlue = [1,2]` <br/><br/> `@Html.EJS().MultiSelect("default").Value(ViewBag.value).Render()` |
| Maximum Selection Length | Not Applicable | **Property** : MaximumSelectionLength <br/><br/> `@Html.EJS().MultiSelect("default").MaximumSelectionLength(5).Render()` |
| Select All Text | Not Applicable | **Property** : SelectAllText <br/><br/> `@Html.EJS().MultiSelect("default").SelectAllText('Check All').Render()` |
| Un Select All Text | Not Applicable | **Property** : UnSelectAllText <br/><br/> `@Html.EJS().MultiSelect("default").UnSelectAllText('Un Check All').Render()` |
| Selection Order | Not Applicable | **Property** : EnableSelectionOrder <br/><br/> `@Html.EJS().MultiSelect("default").EnableSelectionOrder(true).Render() ` |
| Hide Selected Item | Not Applicable | **Property** : HideSelectedItem <br/><br/> `@Html.EJS().MultiSelect("default").HideSelectedItem(true).Render() ` |
| Get Selected Item | **Method** : getSelectedItem() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedItem') | **Property** : value <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.value` |
| Get Selected Value | **Method** : getSelectedValue() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>$('#dropdown').ejDropDownList('getSelectedValue') | **Property** : value <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.value` |
| Select Items By Indices | **Method** : selectItemsByIndices() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.selectItemsByIndices("2,3") | Not Applicable |
| Select Item By Text | **Method** : selectItemByText() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.selectItemByText("Computer IT ,Comics ") | Not Applicable |
| Select Item By Value | **Method** : selectItemByValue() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.selectItemByValue("Computer IT ,Comics ") | Not Applicable |
| Un select Items By Indices | **Method** : unselectItemsByIndics() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unselectItemsByIndices ("2,3") | Not Applicable |
| Un select Item By Text | **Method** : unselectItemByText() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unselectItemByText ("Computer IT ,Comics ") | Not Applicable |
| Un select Item By Value | **Method** : unselectItemByValue() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/>var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unselectItemByValue ("Computer IT ,Comics ") | Not Applicable |
| Selected All | **Method** : checkAll() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.checkAll() | **Method** : selectAll <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.selectAll(true)` |
| Un Selected All | **Method** : unCheckAll() <br/> <br/>`@Html.EJ().DropDownList("selectCompany")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.unCheckAll() | **Method** : selectAll <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.selectAll(false)` |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------- | ------------------------- |
| Virtual Scrolling| **Property** : AllowVirtualScrolling<br/> <br/>`@Html.EJ().DropDownList("default").AllowVirtualScrolling(true)` | It will be acheived in sample level using `actionComplete` event |
| Virtual Scroll Mode | **Property** : VirtualScrollMode<br/> <br/>`@Html.EJ().DropDownList("default").AllowVirtualScrolling(true).VirtualScrollMode(VirtualScrollMode.Normal)` | Not Applicable |
| Custom class | **Property** : CssClass<br/> <br/>`@Html.EJ().DropDownList("default").CssClass('customstyle')` | **Property** : CssClass<br/> <br/>`@Html.EJS().MultiSelect("default").CssClass('customstyle').Render()` |
| Delimiter Char | **Property** : DelimiterChar<br/> <br/>`@Html.EJ().DropDownList("default").DelimiterChar('.')` |  **Property** : DelimiterChar<br/> <br/>`@Html.EJS().MultiSelect("default").DelimiterChar('.').Render()` |
| Enable | **Property** : Enable<br/> <br/>`<@Html.EJ().DropDownList("default").Enable(true)` |  **Property** : Enabled <br/> <br/>`@Html.EJS().MultiSelect("default").Enabled(true).Render()` |
| Persistence | **Property** : EnablePersistence<br/> <br/>`@Html.EJ().DropDownList("default").EnablePersistence(true)` |  **Property** : EnablePersistence <br/> <br/>`@Html.EJS().MultiSelect("default").EnablePersistence(true).Render() ` |
| Load On Demand | **Property** : LoadOnDemand<br/> <br/>`@Html.EJ().DropDownList("default").LoadOnDemand(true)` | By default, provided load on demand support |
| Height | **Property** : Height<br/> <br/>`@Html.EJ().DropDownList("default").Height(100)` | Not Applicable |
| Html Attributes | **Property** : HtmlAttributes <br/> <br/>`@Html.EJ().DropDownList("default").HtmlAttributes((IDictionary<string,object>)ViewData["HtmlAttrData"])` |  **Property** : HtmlAttributes <br/> <br/>`@Html.EJS().MultiSelect("default").HtmlAttributes((IDictionary<string,object>)ViewData.htmlAttrData).Render() ` |
| Width | **Property** : Width <br/> <br/>`@Html.EJ().DropDownList("default").Width(500)` |  **Property** : Width <br/> <br/>`@Html.EJS().MultiSelect("default").Width(400).Render()` |
| Mode | **Property** : MultiSelectMode <br/> <br/>`@Html.EJ().DropDownList("default").MultiSelectMode(MultiSelectModeTypes.Delimiter)` |  **Property** : Mode <br/><br/>` 1. Delimeter `<br/><br/>` 2. Box `<br/><br/>` 3. Default `<br/><br/>` 4. CheckBox `<br/><br/> `@Html.EJS().MultiSelect("default").Mode('Delimeter').Render()` |
| Read Only | **Property** : ReadOnly <br/> <br/>`@Html.EJ().DropDownList("default").ReadOnly(true)` |  **Property** : Readonly <br/><br/> `@Html.EJS().MultiSelect("default").Readonly(true).Render()` |
| Checkbox | **Property** : ShowCheckbox <br/> <br/>`@Html.EJ().DropDownList("default").ShowCheckbox(true)` |  **Property** : Mode <br/><br/> `@Html.EJS().MultiSelect("default").Mode('CheckBox').Render()` |
| Rounded Corner | **Property** : ShowRoundedCorner <br/> <br/>`@Html.EJ().DropDownList("default").ShowRoundedCorner(true)` | Not Applicable |
| Target ID | **Property** : TargetID <br/> <br/>`@Html.EJ().DropDownList("DropDownList1").TargetID("mail")<div id="mail"><ul><li><div class="mailtools categorize"></div>Categorize and Move</li></ul></div>` | Not Applicable |
| Text | **Property** : Text <br/> <br/>`@Html.EJ().DropDownList("DropDownList1").Text("Employee Name")` |  **Property** : Text <br/><br/> `@Html.EJS().MultiSelect("default").Text("Employee Name").Render()` |
| Validation Message | **Property** : ValidationMessage <br/> <br/>`@Html.EJ().DropDownList("DropDownList1").Datasource((IEnumerable<Data>)ViewData["DropDownSource"]).DropDownListFields(Df => Df.Text("Text").Value("Value")).ValidationMessage(message => message.AddMessage("required", "* Required").AddMessage("min","Select > 30")))` |  The default error message for a rule can be customizable by defining it along with concern rule. |
| Validation Rules | **Property** : ValidationRules <br/> <br/>`@Html.EJ().DropDownList("DropDownList1").Datasource((IEnumerable<Data>)ViewData["DropDownSource"]).DropDownListFields(Df => Df.Text("Text").Value("Value")).ValidationRules(vr => vr.AddRule("required", true).AddRule("min",30))` |  Use Form validator to validate the multiselect component and set validation rules. |
| Value | **Property** : Value <br/> <br/>`@Html.EJ().DropDownList("DropDownList1").Value("Employee Value")` |  **Property** : Value <br/><br/> `@Html.EJS().MultiSelect("default").Value(ViewBag.value).Render()` |
| Watermark Text | **Property** : WatermarkText <br/> <br/>`@Html.EJ().DropDownList("DropDownList1").WatermarkText("Select employee")` |  **Property** : Placeholder <br/><br/> `@Html.EJS().MultiSelect("default").Placeholder('Select employee').Render()` |
| Custom Value | Not Applicable |  **Property** : AllowCustomValue <br/><br/> `@Html.EJS().MultiSelect("default").AllowCustomValue(true).Render() ` |
| Clear Button | Not Applicable |  **Property** : ShowClearButton <br/><br/> `@Html.EJS().MultiSelect("default").ShowClearButton(true).Render()` |
| DropDown Icon | Not Applicable |  **Property** : ShowDropDownIcon  <br/><br/> `@Html.EJS().MultiSelect("default").ShowDropDownIcon(true).Render()` |
| Show Select All | Not Applicable |  **Property** : ShowSelectAll <br/><br/> `@Html.EJS().MultiSelect("default").ShowSelectAll(true).Render()` |
| z-Index | Not Applicable |  **Property** : ZIndex <br/><br/> `@Html.EJS().MultiSelect("default").ZIndex(1000).Render()` |
| Add Item | **Method** : addItem(object) <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.addItem({ text :"new item"});  | **Method** : addItem(object) <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.addItem({ text :"new item"})` |
| Clear Text| **Method** : clearText() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.clearText();  | **Property** : value <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.value = null` |
| destroy| **Method** : destroy() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.destroy();  | **Property** : destroy <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.destroy()` |
| Disable| **Method** : disable() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.disable();  | **Property** : Enabled <br/> <br/>`@Html.EJS().MultiSelect("default").Enabled(false).Render() />` |
| Enable| **Method** : enable() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.enable();  | **Property** : Enabled <br/> <br/>`@Html.EJS().MultiSelect("default").Enabled(true).Render()` |
| Disable Items By Indices| **Method** : disableItemsByIndics() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.disableItemsByIndics(“3,4,5”);  | Not Applicable |
| Enable  Items By Indices| **Method** : enableItemsByIndices() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.enableItemsByIndices(“3,4,5”);  | Not Applicable |
| Get Item Data By Value | **Method** : getItemDataByValue("value") <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.getItemDataByValue("value");  | **Method** : getDataByValue("value") <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.getDataByValue(“value”)` |
| Get List Data | **Method** : getListData() <br/> <br/>`@Html.EJ().DropDownList("DropDownList1")`<br/> <br/> var dropdown = $("#dropdown ").data("ejDropDownList"); dropdown.getListData();  | Not Applicable |
| Hide Spinner | Not Applicable  | **Method** : hideSpinner() <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.hideSpinner()` |
| Show Spinner | Not Applicable  | **Method** : showSpinner() <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.showSpinner()` |
| Refresh | Not Applicable  | **Method** : refresh() <br/> <br/>`@Html.EJS().MultiSelect("default").Render()`<br/> <br/>`var mulObj = document.getElementById('multiselect').ej2_Instances[0];`<br/><br/>` mulObj.refresh()` |
| Change | **Event** : Change<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.Change("onChange")` |  **Event** : Change<br/> <br/>`@Html.EJS().MultiSelect("list").Change("onChange").Render()`  |
| Check Change | **Event** : CheckChange<br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.CheckChange("onCheckChange")` |  Not Applicable  |
| Create | **Event** : Create <br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.Create("onCreate")` |  **Event** : Created <br/> <br/>`@Html.EJS().MultiSelect("list").Created("onCreated").Render()`  |
| Destroy | **Event** : Destroy <br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.Destroy("onDestroy")` |  **Event** : Destroyed <br/> <br/>`@Html.EJS().MultiSelect("list").Destroyed("onDestroyed").Render()`  |
| Focus In | **Event** : FocusIn <br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.FocusIn("onFocusIn")` |  **Event** : Focus <br/> <br/>`@Html.EJS().MultiSelect("list").Focus("onFocus").Render()`  |
| Focus Out | **Event** : FocusOut <br/> <br/>`@Html.EJ().DropDownList("selectCompany").ClientSideEvents(e => e.FocusOut("onFocusOut")` |  **Event** : Blur <br/> <br/>`@Html.EJS().MultiSelect("list").Blur("onBlur").Render()`  |
| Chip Selection | Not Applicable |  **Event** : ChipSelection <br/> <br/>`@Html.EJS().MultiSelect("list").ChipSelection("onChipSelection").Render()`  |
| Custom Value Selection | Not Applicable |  **Event** : CustomValueSelection <br/> <br/>`@Html.EJS().MultiSelect("list").CustomValueSelection("onCustomValueSelection").Render()`  |
| Removed | Not Applicable |  **Event** : Removed <br/> <br/>`@Html.EJS().MultiSelect("list").Removed("onRemoved").Render()`  |
| Removing | Not Applicable |  **Event** : Removing <br/> <br/>`@Html.EJS().MultiSelect("list").Removing("onRemoving").Render()`  |
| Tagging | Not Applicable |  **Event** : Tagging <br/> <br/>`@Html.EJS().MultiSelect("list").Tagging("onTagging").Render()`  |