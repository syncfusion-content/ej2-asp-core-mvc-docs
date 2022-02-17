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
| **Default** | **Property:** *dataSource* <br/>`<ej-autocomplete datasource="(IEnumerable<CarsList>)ViewBag.datasource"></ej-autocomplete>`| **Property:** *datasource*<br/>`<ejs-autocomplete datasource="@ViewBag.data"></ejs-autocomplete>`|
| **Fields for mapping** | **Property:** *e-autocomplete-fields*<br/>`<ej-autocomplete id="autocomplete" ><e-autocomplete-fields text="Text" key="UniqueKey" /></ej-autocomplete>`| **Property:** *e-autocomplete-fields*<br/>`<ejs-autocomplete id="country"><e-autocomplete-fields value="name" text="code"></e-autocomplete-fields></ejs-autocomplete>` |
| **Query** | **Property**: *query*<br/>`<ej-autocomplete id="autocomplete" query="ej.Query().from('Customers').take(10)"></ej-autocomplete>`| **Property**: *query*<br/>`<ejs-autocomplete id="autocomplete" query="ej.Query().from('Customers').take(10)"></ejs-autocomplete>`|
| **Begin event** | **Event**: *action-begin*<br/>`<ej-autocomplete id="autocomplete" action-begin="onBegin"></ej-autocomplete>`|**Event**: *actionBegin*<br/> `<ejs-autocomplete id="autocomplete" actionBegin="onBegin"></ejs-autocomplete>`|
| **Complete event** | **Event**: *action-complete*<br/>`<ej-autocomplete id="autocomplete" action-complete="onComplete"></ej-autocomplete>`|**Event**: *actionComplete* <br/> `<ejs-autocomplete id="autocomplete" actionComplete="onComplete"></ejs-autocomplete>` |
| **Failure event** | **Event**: *action-failure*<br/>`<ej-autocomplete id="autocomplete" action-failure="onFailure"></ej-autocomplete>` |**Event**: *actionFailure* <br/> `<ejs-autocomplete id="autocomplete" actionFailure="onFailure"></ejs-autocomplete>`|
| **Success event** | **Event**: *action-sucess* <br/>`<ej-autocomplete id="autocomplete" action-Success="onSuccess"></ej-autocomplete>` |**Not Applicable** |

## Filtering

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Case sensitivity** | **Property**: *case-sensitive-search*<br/>`<ej-autocomplete id="autocomplete" case-sensitive-search="true"></ej-autocomplete>`|**Property:** *ignoreCase*<br/>`<ejs-autocomplete id="autocomplete" ignoreCase="true"></ejs-autocomplete>`|
| **Accent effective search** | **Not applicable** | **Property** : *ignoreAccent* <br/>`ejs-autocomplete id="autocomplete" ignoreAccent="true"></ejs-autocomplete>`|
| **Filtering Type** | **Property:** *filter-type*<br/>`<ej-autocomplete id="autocomplete" filter-type=(FilterType.Contains)></ej-autocomplete>`| **Property**: *filterType*<br/>`<ejs-autocomplete id="autocomplete" filterType="StartsWith"></ejs-autocomplete>` |
| **Autofill** | **Property:** *enable-auto-fill*<br/>`<ej-autocomplete id="autocomplete" enable-auto-fill="true"></ej-autocomplete>` | **Property:**: *autoFill* <br/>`ejs-autocomplete id="autocomplete" autoFill="true"></ejs-autocomplete>`|
| **Highlight the search word** | **Property**: *highlight-search* `<ej-autocomplete id="autocomplete" highlight-search="true"></ej-autocomplete>`|**Property:** *highlight* <br/>`ejs-autocomplete id="autocomplete" highlight="true"></ejs-autocomplete>` |
| **No of items to be shown** | **Property:** *items-count*<br/>`<ej-autocomplete id="autocomplete" items-count=2></ej-autocomplete>` |**Property:** *suggestionCount*<br/>`<ejs-autocomplete id="autocomplete" suggestionCount="5"></ejs-autocomplete>` |
| **Minimum characters to enter** | **Property:** *min-character*<br/> `<ej-autocomplete id="autocomplete" min-character=2></ej-autocomplete>` |**Property:** *minLength* <br/>`ejs-autocomplete id="autocomplete" minLength="3"></ejs-autocomplete>` |
| **Search** | **Method:** *search* <br/>`<ej-autocomplete id="autocomplete"></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutocomplete("search");` | **Not applicable** |

## Placeholder

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Watermark text** | **Property:** *watermark-text* <br/>`<ej-autocomplete id="autocomplete" watermark-text="select"></ej-autocomplete>`| **Property:** *placeholder* <br/>`ejs-autocomplete id="autocomplete" placeholder="select"></ejs-autocomplete>`|
| **Floating  of waterMarkText** | **Not applicable**   | **Property:** *floatLabelType* <br/>`ejs-autocomplete id="autocomplete" floatLabelType="auto"></ejs-autocomplete>`|

## Popup

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **No records text** | **Property:** *empty-result-text* <br/> `<ej-autocomplete id="autocomplete" empty-result-text="no records"></ej-autocomplete>`| **Property:** *noRecordsTemplate*<br/> `<ejs-autocomplete id="autocomplete" noRecordsTemplate="@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")"></ejs-autocomplete>`|
| **No records showing** | **Property:** *show-empty-result-text<br/> `<ej-autocomplete id="autocomplete" show-empty-result-text="no records"></ej-autocomplete>` | **Not applicable** |
| **Popupbutton** | **Property:** *show-popup-button*<br/> `<ej-autocomplete id="autocomplete" show-popup-button="true"></ej-autocomplete>` | **Property:** *showPopupButton*<br/> `<ej-autocomplete id="autocomplete" showPopupButton="true"></ej-autocomplete>`|
| **Clear button** | **Property:** *show-reset-icon* <br/> `<ej-autocomplete id="autocomplete" show-reset-icon="true"></ej-autocomplete>` | **Property:** *showClearButton* <br/>`<ej-autocomplete id="autocomplete" show-clear-button="true"></ej-autocomplete>` |
| **Animation** | **Property:** *animate-type* <br/> `<ej-autocomplete id="autocomplete" animate-type=AnimateType.none></ej-autocomplete>` | **Not Applicable** |
| **Focusing the list item** | **Property:** *auto-focus*<br/> `<ej-autocomplete id="autocomplete" auto-focus="true"></ej-autocomplete>` |**Not applicable** |
| **Delaying the popup open time** | **Property:** *delay-suggestion-timeout*<br/> `<ej-autocomplete id="autocomplete" delay-suggestion-timeout=500></ej-autocomplete>` | **Not applicable** |
| **Popup text when there is no popup items** | **Property:** *empty-result-text*<br/> `<ej-autocomplete id="autocomplete" empty-result-text="no records"></ej-autocomplete>`  |<https://ej2.syncfusion.com/aspnetcore/AutoComplete/Template#/material> |
| **Enable/disable the duplicate option** | **Property:** *enable-distinct*<br/> `<ej-autocomplete id="autocomplete" enable-distinct="true"></ej-autocomplete>` |**Not applicable**  |
| **Popup height** | **Property:** *popup-height*<br/> `<ej-autocomplete id="autocomplete" popup-height="300px"></ej-autocomplete>` |**Property:** *popupHeight* <br/> `<ejs-autocomplete id="autocomplete" popupHeight="300px"></ejs-autocomplete>` |
| **Popup Width** | **Property:** *popup-width*<br/> `<ej-autocomplete id="autocomplete" popup-width="300px"></ej-autocomplete>` |**Property:** *popupWidth* <br/> `<ej-autocomplete id="autocomplete" popupWidth="300px"></ej-autocomplete>`|
| **Open popup** | **Method:** *open*<br/> `<ej-autocomplete id="autocomplete"></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutocomplete("open");` | **Method:** *showPopup*<br/> `<ej-autocomplete id="autocomplete"></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutocomplete("open");` |
| **Close event** | **Event:** *close*<br/> `<ej-autocomplete id="autocomplete" close="onClose"></ej-autocomplete>` | **Event**: *close* <br/> `<ej-autocomplete id="autocomplete" close="onClose"></ej-autocomplete>`|
| **Open event** | **Event:** *open*<br/> `<ej-autocomplete id="autocomplete" open="onOpen"></ej-autocomplete>`| **Event:** *open* <br/> `<ej-autocomplete id="autocomplete" open="onOpen"></ej-autocomplete>`|

## CSS

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *css-class* <br/> `<ej-autocomplete id="autocomplete" css-class="customclass"></ej-autocomplete>` | **Property:** *cssClass* <br/> `<ej-autocomplete id="autocomplete" cssClass="customClass"></ej-autocomplete>`|
| **Height** | **Property:** *height* <br/> `<ej-autocomplete id="autocomplete" height="300px"></ej-autocomplete>`| By using *css-class* property, you can acheive this. |
| **showRoundedCorner**   | **Property:** *show-rounded-corner*<br/> `<ej-autocomplete id="autocomplete" show-rounded-corner="true"></ej-autocomplete>` | **By using *css-class* property, you can acheive this**.|
| **Width** | **Property:** *width* <br/> `<ej-autocomplete id="autocomplete" width="300px"></ej-autocomplete>`| **Property:** *width* <br/> `<ej-autocomplete id="autocomplete" width="300px"></ej-autocomplete>`|
| **Visibility** | **Property:** *visible* <br/> `<ej-autocomplete id="autocomplete" visisble="true"></ej-autocomplete>` | **By using *css-class* property, you can acheive this**. |

## Grouping

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *fields.groupBy*<br/> `<ej-autocomplete id="autocomplete"><e-autocomplete-fields group-by="Text" /></ej-autocomplete>`  |**Property:** *fields.groupBy* `<ejs-autocomplete id="country"><e-autocomplete-fields groupBy="name"></e-autocomplete-fields></ejs-autocomplete>`|

## Localization

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *locale* <br/>`<ej-autocomplete id="autocomplete" locale="fr-FE"></ej-autocomplete>`| **Property:** *locale* <br/>`<ejs-autocomplete id="country" locale="fr-FE"></ejs-autocomplete>`|

## Template

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *template* `<ej-autocomplete id="autocomplete" template="@Html.Raw("<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>")">></ej-autocomplete>`|**Property:** *itemTemplate*<br/> `<ejs-autocomplete id="employees" itemTemplate="@Html.Raw("<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>")">></ejs-autocomplete>` |
| **Group Template** | **Not Applicable**  | **Property:** *groupTemplate* <br/>`<ejs-autocomplete id="employees" groupTemplate="@Html.Raw("<strong>${City}</strong>")"></ejs-autocomplete>`|
| **ValueTemplate** | **Not applicable** | **Property:** *valueTemplate* <br/>`<ejs-autocomplete id="employees" valueTemplate="data"></ejs-autocomplete>`|
| **Header Template** | **Not applicable** | **Property:** *headerTemplate* <br/> `<ejs-autocomplete id="employees" headerTemplate="@Html.Raw("<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>")"></ejs-autocomplete>`|
| **FooterTemplate** | **Not applicable** | **Property:** *footerTemplate* <br/>`<ejs-autocomplete id="employees" footerTemplate="@Html.Raw( "<span class='foot'> Total list items: " + 7 + "</span>")"></ejs-autocomplete>`|
| **No records Template** | **Not applicable** | **Property:** *noRecordsTemplate* <br/>`<ejs-autocomplete id="employees" noRecordsTemplate="@Html.Raw("<span class='norecord'> NO DATA AVAILABLE</span>")"></ejs-autocomplete>`|
| **Action failure Template** | **Not applicable** | **Property:** *actionFailureTemplate* <br/>`<ejs-autocomplete id="employees" actionFailureTemplate="@Html.Raw("<div class=\"header\"> <span>Photo</span> <span class=\"info\">Employee Info</span></div>)")"></ejs-autocomplete>`|

## Sorting

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Default** | **Property:** *allow-sorting* <br/>`<ej-autocomplete id="autocomplete" allow-sorting="true"></ej-autocomplete>` | **It is applicable when the sortOrder is defined.** |
| **Order of sorting** | **Property:** *sort-order* <br/>`<ej-autocomplete id="autocomplete" sort-order="Ascending"></ej-autocomplete>`|**Property:** *sortOrder*<br/> `<ejs-autocomplete id="country" sortOrder="Ascending"></ejs-autocomplete>`|

## Accessibility

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **RTL support** | **Property:** *enable-rtl* <br/>`<ej-autocomplete id="autocomplete" enable-rtl="true"></ej-autocomplete>` | **Property:** *enableRtl* <br/>`<ejs-autocomplete id="country" enableRtl="true"></ejs-autocomplete>`|

## Selection

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| ------------ | ------------ | ----------- |
|**Selecting particular value**| **Property**: *select-value-by-key* <br/>`<ej-autocomplete id="autocomplete" selectValueByKey="13"></ej-autocomplete>`|**Achievable through value property** |
| **Selecting particular value** | **Property**: *value*<br/>`<ej-autocomplete id="autocomplete" value="data"></ej-autocomplete>` | **Property:** *value*<br/> `<ejs-autocomplete id="country" value="data"></ejs-autocomplete>`|
| **Selecting particular text** | **Property:** *text*<br/> `<ej-autocomplete id="autocomplete" text="data"></ej-autocomplete>` | **By using text property, you can acheive this.** |
| **Selecting particular value** |**Method:** *selectValueByKey*<br/>`<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/> `$("#autocomplete").selectValueByKey("key")`| **Achievable through value property**   |
| **Selecting particular text** |**Method:** *selectValueByText* <br/> `<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/> `$("#autocomplete").selectValueByText("key")`|**Achievable through text property** |
| **Select event** |**Event**: *select*<br/>`<ej-autocomplete id="autocomplete" select="onSelect"></ej-autocomplete>` | **Event:** *select* <br/> `<ejs-autocomplete id="country" sortOrder="auto"></ejs-autocomplete>`|

## Miscellaneous

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Enable/disable** | **Property:** *enabled*<br/>`<ej-autocomplete id="autocomplete" enabled="true"></ej-autocomplete>` | **Property:** *enabled* <br/>`<ejs-autocomplete id="country" enabled="true"></ejs-autocomplete>`|
| **Enable persistence** | **Property:** *enable-persistence*<br/> `<ej-autocomplete id="autocomplete" enable-persistence="true"></ej-autocomplete>`  | **Property:** *enablePersistence* <br/> `<ejs-autocomplete id="country" enablePersistence="true"></ejs-autocomplete>`|
| **Loading icon** | **Property:** *show-loading-icon* <br/>`<ej-autocomplete id="autocomplete" show-loading-icon="true"></ej-autocomplete>` | **By default,it is showing** |
| **Read only** | **Property: read-only** <br/> `<ej-autocomplete id="autocomplete" read-only="true"></ej-autocomplete>` | **Property: readOnly**  `<ej-autocomplete id="autocomplete" r="true"></ej-autocomplete>`  |
| **Disable** | **Method:** *disable*<br/> `<ej-autocomplete id="autocomplete" read-only="true"></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutoComplete("disable");` | **Enabled property can be used here**  |

## Common

| **Behavior** | **API in Essential JS 1** | **API in Essential JS 2** |
| --- | --- | --- |
| **Addition of new option watermarktext** | **Property:** *add-new-text* <br/>`<ej-autocomplete id="autocomplete" add-new-text="data"></ej-autocomplete>` | **Not applicable** |
| **Addition of new item** | **Property:**  *allow-add-new* <br/>`<ej-autocomplete id="autocomplete" allow-add-new="true"></ej-autocomplete>`  | **Property:** *allowCustom*<br/> `<ej-autocomplete id="autocomplete" allowCustom="true"></ej-autocomplete>`|
| **Reset the autocomplete** | **Property:** *show-reset-icon* <br/>`<ej-autocomplete id="autocomplete" show-reset-icon="true"></ej-autocomplete>`|**Property:** *showClearIcon* `<ejs-autocomplete id="country" showClearIcon="true"></ejs-autocomplete>` |
| **Destroy** | **Method:** *destroy*<br/> `<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutoComplete("destroy");`| **Method:** *destroy* <br/>`<ejs-autocomplete id="country"></ejs-autocomplete>`<br/> <br/>`var autoObj = document.getElementById("country").ej2_Instances[0];`<br/><br/>`autoObj.destroy();`|
| **Reset the autocomplete** | **Method:** *clearText*<br/>`<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutoComplete("clearText");`  | **By passing empty value to the value property, you can acheive this**   |
| **Multicolumn** | **Property:** *multiColumnSettings*<br/> `<ej-autocomplete id="autocomplete" datasource="ViewBag.datasource"><e-multicolumnsettings enable="true" show-header="true" string-format="{0} ({1})" search-column-indices="@val.SearchColumnIndices"><e-multi-columns><e-multi-column field="UniqueKey" header-text="Unique Key"></e-multi-column><e-multi-column field="Text" header-text="Text"></e-multi-column></e-multi-columns></e-multicolumnsettings></ej-autocomplete>` |**Not applicable** |
| **Hide the Autocomplete** | **Method:** *hide*<br/>`<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutoComplete("hide");` | **By using *css-class* property, you can acheive this.**
| **Getting particular text** | **Method:** *getActiveText* <br/>`<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutoComplete("getActiveText");`|**By using text property, you can get it.** |
| **Getting particular value** | **Method:** *getValue*<br/> `<ej-autocomplete id="autocomplete" ></ej-autocomplete>`<br/><br/>`$("#autocomplete").ejAutoComplete("getValue");` |** By using value property, you can get it.** |
| **Change event** | **Event:** *change*<br/>`<ej-autocomplete id="autocomplete" change="onChange"></ej-autocomplete>`|**Event:** *change* <br/>`<ejs-autocomplete id="country" change="onChange"></ejs-autocomplete>`|
| **Create event** | **Event:** *create* <br/>`<ej-autocomplete id="autocomplete" change="onChange"></ej-autocomplete>`|**Event:** *created* <br/>`<ejs-autocomplete id="country" created="onCreated"></ejs-autocomplete>`|
| **Destroy event** | **Event:** *destroy* <br/>`<ej-autocomplete id="autocomplete" destroy="onDestroy"></ej-autocomplete>` |**Event:** *destroyed* <br/>`<ejs-autocomplete id="country" destroyed="onDestroy"></ejs-autocomplete>`|
| **Focus out event** | **Event**: *focus-out*<br/>`<ej-autocomplete id="autocomplete" focus-out="onfocusout"></ej-autocomplete>`| **Event:** *blur* <br/>`<ejs-autocomplete id="country" blur="onChange"></ejs-autocomplete>` |
| **Focus in event** | **Event** : *focus-in*<br/>`<ej-autocomplete id="autocomplete" focus-in="onfocus"></ej-autocomplete>` | **Event:** *focus* <br/>`<ejs-autocomplete id="country" focus="onFocus"></ejs-autocomplete>` |
