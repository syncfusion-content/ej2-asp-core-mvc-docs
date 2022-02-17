---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Auto Complete Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Migration from Essential JS 1

This article describes the API migration process of  AutoComplete component from Essential JS 1 to Essential JS 2.
> MultiSelect concept is not present in EJ2-AutoComplete.  If you want to use multiselection support in autocomplete, we suggest you to use MultiSelect component.

## DataBinding

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *Datasource* <br/>`@Html.EJ().Autocomplete("autocomplete").Datasource((IEnumerable<CarsList>)ViewBag.datasource)`| **Property:** *DataSource*<br/>`@Html.EJS().AutoComplete("games").DataSource((IEnumerable<object>)ViewBag.localdata).Render()`|
| **Fields for mapping** | **Property:** *AutocompleteFields*<br/>`@Html.EJ().Autocomplete("autocomplete").AutocompleteFields(field => field.Key("UniqueKey").Text("Text"))`| **Property:** *e-autocomplete-fields*<br/>`@Html.EJS().AutoComplete("games").Fields(new AutoCompleteFieldSettings { Text = "Game" }).Render()` |
| **Query** | **Property**: *Query*<br/>`@Html.EJ().Autocomplete("selectCar").Query("ej.Query().from('Customers').take(10)")`| **Property**: *Query*<br/>`@Html.EJS().AutoComplete("customers").Query((string)ViewBag.query).Render()`|
| **Begin event** | **Event**: *ActionBegin*<br/>`@Html.EJ().Autocomplete("selectCar").ActionBegin("onBegin")`|**Event**: *ActionBegin*<br/> `@Html.EJS().AutoComplete("customers").ActionBegin("onBegin").Render()`|
| **Complete event** | **Event**: *ActionComplete*<br/>`@Html.EJ().Autocomplete("selectCar").ActionComplete("onComplete")`|**Event**: *ActionComplete* <br/> `@Html.EJS().Autocomplete("selectCar").ActionComplete("onComplete").Render()`|
| **Failure event** | **Event**: *ActionFailure*<br/>`@Html.EJ().Autocomplete("selectCar").ActionFailure("onFailure")` |**Event**: *ActionFailure* <br/> `@Html.EJS().Autocomplete("selectCar").ActionFailure("onFailure").Render()`|
| **Success event** | **Event**: *ActionSuccess* <br/>`@Html.EJ().Autocomplete("selectCar").ActionSuccess("onSuccess")` |**NotApplicable** |

## Filtering

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Case sensitivity** | **Property**: *CaseSensitiveSearch*<br/>`@Html.EJ().Autocomplete("selectCar").CaseSensitiveSearch(true)`|**Property:** *ignoreCase*<br/>`@Html.EJS().Autocomplete("selectCar").IgnoreCase(true).Render()`|
| **Accent effective search** | **Not applicable** | **Property** : *ignoreAccent* <br/>`@Html.EJS().Autocomplete("selectCar").IgnoreAccent(true).Render()`|
| **Filtering Type** | **Property:** *FilterType*<br/>`@Html.EJ().Autocomplete("selectCar").FilterType(SortOrder.None)`| **Property**: *FilterType*<br/>`@Html.EJS().Autocomplete("selectCar").FilterType(FilterType.Contains).Render()` |
| **Autofill** | **Property:** *EnableAutoFill*<br/>`@Html.EJ().Autocomplete("selectCar").EnableAutoFill(true)` | **Property:**: *AutoFill* <br/>`@Html.EJS().Autocomplete("selectCar").AutoFill(true).Render()`|
| **Highlight the search word** | **Property**: *HighlightSearch* `@Html.EJ().Autocomplete("selectCar").HighlightSearch(true)`|**Property:** *Highlight* <br/>`@Html.EJS().Autocomplete("selectCar").Highlight(true).Render()`|
| **No of items to be shown** | **Property:** *ItemsCount*<br/>`@Html.EJ().Autocomplete("selectCar").ItemsCount(3)` |**Property:** *SuggestionCount*<br/>`@Html.EJS().Autocomplete("selectCar").SuggestionCount(3).Render()` |
| **Minimum characters to enter** | **Property:** *MinCharacter*<br/> `@Html.EJ().Autocomplete("selectCar").MinCharacter(3)` |**Property:** *MinLength* <br/>`@Html.EJ()S.Autocomplete("selectCar").MinLength(3).Render()` |
| **Search** | **Method:** *search* <br/>`@Html.EJ().Autocomplete("selectCar")`<br/><br/>`$("#selectCar").ejAutocomplete("search");` | **Not applicable** |

## Placeholder

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Watermark text** | **Property:** *WatermarkText* <br/>`@Html.EJ().Autocomplete("selectCar").WatermarkText("Select")`| **Property:** *Placeholder* <br/>`@Html.EJS().Autocomplete("selectCar").Placeholder("select").Render()`|
| **Floating  of waterMarkText** | **Not applicable**   | **Property:** *FloatLabelType* <br/>`@Html.EJS().Autocomplete("selectCar").FloatLabelType("Auto").Render()`|

## Popup

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **No records text** | **Property:** *EmptyResultText* <br/> `@Html.EJ().Autocomplete("selectCar").EmptyResultText("no records")`| **Property:** *NoRecordsTemplate*<br/> `@Html.EJS().Autocomplete("selectCar").NoRecordsTemplate("@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")").Render()`|
| **No records showing** | **Property:** *show-empty-result-text<br/> `@Html.EJ().Autocomplete("selectCar").ShowEmptyResultText("no records")` | **Not applicable** |
| **Popupbutton** | **Property:** *ShowPopupButton*<br/> `@Html.EJ().Autocomplete("selectCar").ShowPopupButton(true)` | **Property:** *ShowPopupButton*<br/>  `@Html.EJS().Autocomplete("selectCar").ShowPopupButton(true).Render()`|
| **Clear button** | **Property:** *ShowResetIcon* <br/> `@Html.EJ().Autocomplete("selectCar").ShowResetIcon(true)` | **Property:** *ShowClearButton* <br/>`@Html.EJS().Autocomplete("selectCar").ShowClearButton(true).Render()` |
| **Animation** | **Property:** *animate-type* <br/> `@Html.EJ().Autocomplete("selectCar").AnimateType("None")` | **Not Applicable** |
| **Focusing the list item** | **Property:** *AutoFocus*<br/> `@Html.EJ().Autocomplete("selectCar").AutoFocus("true")` |**Not applicable** |
| **Delaying the popup open time** | **Property:** *delay-suggestion-timeout*<br/> `@Html.EJ().Autocomplete("selectCar").DelaySuggestionTimeout(500)` | **Not applicable** |
| **Popup text when there is no popup items** | **Property:** *empty-result-text*<br/> `@Html.EJ().Autocomplete("selectCar").EmptyResultText("no records")`  |<https://ej2.syncfusion.com/aspnetmvc/AutoComplete/Template#/material> |
| **Enable/disable the duplicate option** | **Property:** *enable-distinct*<br/> `@Html.EJ().Autocomplete("selectCar").EnableDistinct(true)`|**Not applicable**  |
| **Popup height** | **Property:** *PopupHeight*<br/> `@Html.EJ().Autocomplete("selectCar").PopupHeight("300px")` |**Property:** *PopupHeight* <br/> `@Html.EJ().Autocomplete("selectCar").PopupHeight("300px").Render()` |
| **Popup Width** | **Property:** *PopupWidth*<br/> `@Html.EJ().Autocomplete("selectCar").PopupWidth("300px")` |**Property:** *PopupWidth* <br/> `@Html.EJ().Autocomplete("selectCar").PopupWidth("300px").Render()`|
| **Open popup** | **Method:** *open*<br/> `@Html.EJ().Autocomplete("autocomplete")`<br/><br/>`$("#autocomplete").ejAutocomplete("open");` | **Method:** *showPopup*<br/>`@Html.EJS().Autocomplete("autocomplete").Render()`<br/><br/>`$("#autocomplete").ejAutocomplete("showPopup");` |
| **Close event** | **Event:** *Close*<br/>`@Html.EJ().Autocomplete("autocomplete").close("onClose")` | **Event**: *Close* <br/> `@Html.EJS().Autocomplete("autocomplete").Close("close").Render()`|
| **Open event** | **Event:** *Open*<br/> `@Html.EJ().Autocomplete("autocomplete").open("onOpen')`| **Event:** *Open* <br/> `@Html.EJS().Autocomplete("autocomplete").Open(open).Render()`|

## CSS

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *Cssclass* <br/> `@Html.EJ().Autocomplete("autocomplete").CssClass("CSSClass")` | **Property:** *cssClass* <br/> `@Html.EJS().Autocomplete("autocomplete").CssClass("class").Render()`|
| **Height** | **Property:** *Height* <br/> `@Html.EJ().Autocomplete("autocomplete").Height("300px")`| By using *css-class* property, you can acheive this. |
| **showRoundedCorner**   | **Property:** *ShowRoundedCorner*<br/> `@Html.EJ().Autocomplete("autocomplete").ShowRoundedCorner(true)` | **By using *css-class* property, you can acheive this**. |
| **Width** | **Property:** *width* <br/> `@Html.EJ().Autocomplete("autocomplete").Width("200px")`| **Property:** *width* <br/> `@Html.EJS().Autocomplete("autocomplete").Width("300px").Render()`|
| **Visibility** | **Property:** *visible* <br/>`@Html.EJ().Autocomplete("autocomplete").Visible(true)` | **By using *css-class* property, you can acheive this**. |

## Grouping

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *fields.groupBy*<br/> `@Html.EJ().Autocomplete("autocomplete").AutocompleteFields(field => field.GroupBy("UniqueKey"))`|**Property:** *fields.groupBy* `@Html.EJS().AutoComplete("games").Fields(new AutoCompleteFieldSettings { GroupBy = "Game" }).Render()`|

## Localization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *Locale* <br/>`@Html.EJ().Autocomplete("autocomplete").Locale("fr-FE")`| **Property:** *Locale* <br/>`@Html.EJS().AutoComplete("games").Locale("fr-FE").Render()`|

## Template

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *Template* `@Html.EJ().Autocomplete("autocomplete").Template("@Html.Raw("<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>")")`|**Property:** *ItemTemplate*<br/> `@Html.EJS().Autocomplete("autocomplete").ItemTemplate("@Html.Raw("<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>")")` |
| **Group Template** | **Not Applicable**  | **Property:** *GroupTemplate* <br/>`@Html.EJS().Autocomplete("autocomplete").GroupTemplate("@Html.Raw("<strong>${City}</strong>")")`|
| **ValueTemplate** | **Not applicable** | **Property:** *ValueTemplate* <br/>`@Html.EJS().Autocomplete("autocomplete").ValueTemplate("data")`|
| **Header Template** | **Not applicable** | **Property:** *HeaderTemplate* <br/> `@Html.EJS().Autocomplete("autocomplete").HeaderTemplate("@Html.Raw("<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>")")`|
| **FooterTemplate** | **Not applicable** | **Property:** *FooterTemplate* <br/>`@Html.EJS().Autocomplete("autocomplete").FooterTemplate("@Html.Raw( "<span class='foot'> Total list items: " + 7 + "</span>")")` |
| **No records Template** | **Not applicable** | **Property:** *NoRecordsTemplate* <br/>`@Html.EJS().Autocomplete("autocomplete").NoRecordsTemplate("@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")")` |
| **Action failure Template** | **Not applicable** | **Property:** *ActionFailureTemplate* <br/>`@Html.EJS().Autocomplete("autocomplete").ActionFailureTemplate("@Html.Raw("<div class=\"header\"> <span>Photo</span> <span class=\"info\">Employee Info</span></div>)")")` |

## Sorting

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *AllowSorting* <br/> `@Html.EJ().Autocomplete("autocomplete").AllowSorting(true)` | **It is applicable when the sortOrder is defined.** |
| **Order of sorting** | **Property:** *SortOrder* <br/>`@Html.EJS().Autocomplete("autocomplete").SortOrder("Ascending")`|**Property:** *SortOrder*<br/> `@Html.EJS().AutoComplete("games").SortOrder("Ascending").Render()` |

## Accessibility

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **RTL support** | **Property:** *EnableRtl* <br/>`@Html.EJ().Autocomplete("autocomplete").EnableRtl(true)` | **Property:** *EnableRtl* <br/>`@Html.EJS().AutoComplete("games").EnableRtl(true).Render()`|

## Selection

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------ | ----------- |
|**Selecting particular value**| **Property**: *SelectValueByKey* <br/>`@Html.EJ().Autocomplete("autocomplete").SelectValueByKey(12)`|**Achievable through value property** |
| **Selecting particular value** | **Property**: *value*<br/>`@Html.EJ().Autocomplete("autocomplete").Vallue("data")` | **Property:** *value*<br/> `@Html.EJS().AutoComplete("games").Value("data").Render()`|
| **Selecting particular text** | **Property:** *text*<br/> `@Html.EJ().Autocomplete("autocomplete").Text("data")` | **By using text property, you can acheive this.** |
| **Selecting particular value** |**Method:** *SelectValueByKey*<br/>`@Html.EJ().Autocomplete("autocomplete")`<br/><br/> `$("#autocomplete").selectValueByKey("key")`| **Achievable through value property**   |
| **Selecting particular text** |**Method:** *SelectValueByText* <br/> `@Html.EJ().Autocomplete("autocomplete")`<br/><br/> `$("#autocomplete").selectValueByText("key")`|**Achievable through text property** |
| **Select event** |**Event**: *Select*<br/>`@Html.EJ().Autocomplete("autocomplete").Select("onSelect")` | **Event:** *Select* <br/> `@Html.EJS().AutoComplete("games").Select("onSelect").Render()`|

## Miscellaneous

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Enable/disable** | **Property:** *Enabled*<br/>`@Html.EJ().AutoComplete("autocomplete").Enabled(true)` | **Property:** *Enabled* <br/>`@Html.EJS().AutoComplete("games").Enabled(true).Render()`|
| **Enable persistence** | **Property:** *EnablePersistence*<br/> `@Html.EJ().AutoComplete("autocomplete").EnablePersistence(true)` | **Property:** *EnablePersistence* <br/> `@Html.EJS().AutoComplete("games").EnablePersistence(true).Render()`|
| **Loading icon** | **Property:** *ShowLoadingIcon* <br/>`@Html.EJ().AutoComplete("autocomplete").ShowLoadingIcon(true)` | **By default,it is showing** |
| **Read only** | **Property:** *ReadOnly* <br/> `@Html.EJ().AutoComplete("autocomplete").ReadOnly(true)` | **Property:** *ReadOnly*  `@Html.EJS().AutoComplete("games").ReadOnly(true).Render()`  |
| **Disable** | **Method:** *disable*<br/> `@Html.EJ().AutoComplete("autocomplete")`<br/><br/>`$("#autocomplete").ejAutoComplete("disable");` | **Enabled property can be used here**  |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Addition of new option watermarktext** | **Property:** *AddNewText*<br/> `@Html.EJ().Autocomplete("autocomplete").AddNewText("data")`|**Not applicable** |
| **Addition of new item** | **Property:**  *AllowAddNew* <br/>`@Html.EJ().Autocomplete("autocomplete").AllowAddNew(true)`|**Property:** *AllowCustom*<br/> `@Html.EJS().Autocomplete("autocomplete").AllowCustom(true).Render()`|
| **Reset the autocomplete** | **Property:** *ShowResetIcon* <br/>`@Html.EJ().Autocomplete("autocomplete").ShowResetIcon(true)`|**Property:** *ShowClearIcon* <br/> `@Html.EJS().Autocomplete("autocomplete").ShowClearIcon(true).Render()`|
| **Destroy** | **Method:** *destroy*<br/> `@Html.EJ().Autocomplete("autocomplete").AllowSorting(true)`<br/><br/>`$("#autocomplete").ejAutoComplete("destroy");`| **Method:** *destroy* <br/>`@Html.EJS().Autocomplete("autocomplete").Render()`<br/> <br/>`var autoObj = document.getElementById("autocomplete").ej2_Instances[0];`<br/><br/>`autoObj.destroy();`|
| **Reset the autocomplete** | **Method:** *clearText*<br/>`@Html.EJ().Autocomplete("autocomplete")`<br/><br/>`$("#autocomplete").ejAutoComplete("clearText");`  | **By passing empty value to the value property, you can acheive this**   |
| **Multicolumn** | **Property:** *MultiColumnSettings*<br/> `@Html.EJ().Autocomplete("autocomplete").Datasource((IEnumerable<CarsList>ViewBag.datasource).`<br/>`MultiColumnSettings(obj => obj.Enable(true).Columns(obj1 =>{obj1.Field("EmployeeID").HeaderText("EmployeeID").Add();obj1.Field("FirstName").HeaderText("FirstName").Add();obj1.Field("City").HeaderText("City").Add();}).ShowHeader(true).SearchColumnIndices(new List<int> { 0,1,2 }).StringFormat("{0}"))` |**Not applicable** |
| **Hide the Autocomplete** | **Method:** *hide*<br/><br/>`@Html.EJ().Autocomplete("autocomplete")`<br/><br/>`$("#autocomplete").ejAutoComplete("hide");` | **By using *css-class* property, you can acheive this.**
| **Getting particular text** | **Method:** *GetActiveText* <br/>`@Html.EJ().Autocomplete("autocomplete")`<br/><br/>`$("#autocomplete").ejAutoComplete("getActiveText");`|**By using text property, you can get it.** |
| **Getting particular value** | **Method:** *getValue*<br/> `@Html.EJ().Autocomplete("autocomplete")`<br/><br/>`$("#autocomplete").ejAutoComplete("getValue");` |**By using value property, you can get it.** |
| **Change event** | **Event:** *Change*<br/>`@Html.EJ().Autocomplete("autocomplete").Change("onChange")`|**Event:** *Change* <br/>`@Html.EJS().Autocomplete("autocomplete").Change("onChange").Render()`|
| **Create event** | **Event:** *Create* <br/>`@Html.EJ().Autocomplete("autocomplete").Created("onCreate")`|**Event:** *Created* <br/>`@Html.EJS().Autocomplete("autocomplete").Created("onCreate").Render()`|
| **Destroy event** | **Event:** *Destroy* <br/>`@Html.EJ().Autocomplete("autocomplete").Destroy("onDestroy")` |**Event:** *Destroyed* <br/>`@Html.EJS().Autocomplete("autocomplete").Destroyed("ondestroy").Render()`|
| **Focus out event** | **Event**: *FocusOut*<br/>`@Html.EJ().Autocomplete("autocomplete").FocusOut("onFocusOut")`| **Event:** *Blur* <br/>`@Html.EJS().Autocomplete("autocomplete").Blur("onBlur").Render()` |
| **Focus in event** | **Event** : *FocusIn*<br/>`@Html.EJ().Autocomplete("autocomplete").FocusIn("onFocus")` | **Event:** *Focus* <br/>`@Html.EJS().Autocomplete("autocomplete").FocusIn("onFocus").Render()` |
