---
layout: post
title: Global Local in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Global Local in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Global Local
publishingplatform: ##Platform_Name##
documentation: ug
---

# Global local in ASP.NET MVC Grid component

The Syncfusion ASP.NET MVC Grid component provides a feature known as Globalization (global and local), which makes the application more accessible and useful for individuals from different regions and language backgrounds. You have the ability to view data in your preferred language and format, resulting in an enhanced overall experience.

## Localization

The Syncfusion ASP.NET MVC Grid provides a built-in [Localization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization) library, enabling you to customize the text used in the grid to suit different languages or cultural preferences. With this library, you can change static text on various elements, such as **group drop area text** and **pager information text**, to different cultures, such as **Arabic**, **Deutsch**, **French**, and more.

This can be achieved by defining the [Locale](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property and translation object.

The following list of properties and its values are used in the grid.

**Data Rendering**

Locale key words |Text | Example 
-----|-----|-----
EmptyRecord | No records to display | ![Locale Empty Record](images/globalization/locale-empty-record.png)
EmptyDataSourceError | DataSource must not be empty at initial load since columns are generated from dataSource in AutoGenerate Column Grid()

**Columns**

Locale key words |Text | Example 
-----|-----|-----
True | true | ![Locale true](images/globalization/locale-true.png)
False | false | ![Locale false](images/globalization/locale-false.png)
ColumnHeader | column header  | ![Locale column header](images/globalization/locale-column-header.png)
TemplateCell | is template cell | ![Locale template cell](images/globalization/locale-templatecell.png)
ClipBoard | clipboard | ![Locale clipboard](images/globalization/locale-clipboard.png)
CheckBoxLabel | checkbox | ![Locale checkbox label](images/globalization/locale-checkbox-label.png)

**ColumnChooser**

Locale key words |Text | Example 
-----|-----|-----
Columnchooser | Columns | ![Locale columnchooser](images/globalization/locale-column-chooser.png)
ChooseColumns | Choose Column | ![Locale choose columns](images/globalization/locale-choose-columns.png)
ColumnChooserDialogARIA | Column chooser | ![Locale columnchooser dialog ARIA](images/globalization/locale-columnchooser-dialog-ARIA.png)

**Editing**

Locale key words |Text | Example 
-----|-----|-----
Add | Add | ![Locale add](images/globalization/locale-add.png)
Edit| Edit | ![Locale edit](images/globalization/locale-edit.png)
Cancel| Cancel | ![Locale cancel](images/globalization/locale-cancel.png)
Update| Update | ![Locale update](images/globalization/locale-update.png)
Delete | Delete | ![Locale delete](images/globalization/locale-delete.png)
Save | Save | ![Locale save](images/globalization/locale-save.png)
EditOperationAlert | No records selected for edit operation | ![Locale edit operation alert](images/globalization/locale-edit-operation-alert.png)
DeleteOperationAlert | No records selected for delete operation | ![Locale delete operation alert](images/globalization/locale-delete-operation-alert.png)
SaveButton | Save | ![Locale save button](images/globalization/locale-save-button.png)
OKButton | OK | ![Locale ok button](images/globalization/locale-ok-button.png)
CancelButton | Cancel | ![Locale cancel button](images/globalization/locale-cancel-button.png)
EditFormTitle | Details of | ![Locale edit form title](images/globalization/locale-edit-form-title.png)
AddFormTitle | Add New Record | ![Locale add form title](images/globalization/locale-add-form-title.png)
BatchSaveConfirm | Are you sure you want to save changes? | ![Locale batch save confirm](images/globalization/locale-batch-save-confirm.png)
BatchSaveLostChanges | Unsaved changes will be lost. Are you sure you want to continue? | ![Locale batch save lost changes](images/globalization/locale-batch-save-lost-changes.png)
ConfirmDelete | Are you sure you want to Delete Record? | ![Locale confirm delete](images/globalization/locale-confirm-delete.png)
CancelEdit | Are you sure you want to Cancel the changes? | ![Locale cancel edit](images/globalization/locale-cancel-edit.png)
DialogEditARIA | Edit dialog | 
CommandColumnAria | is Command column column header  | ![Locale command column aria](images/globalization/locale-command-column-aria.png)
DialogEdit | Dialog edit | ![Locale dialog edit](images/globalization/locale-dialog-edit.png)

**Grouping**

Locale key words |Text | Example 
-----|-----|-----
GroupDropArea | Drag a column header here to group its column | ![Locale group drop area](images/globalization/locale-group-drop-area.png)
UnGroup | Click here to ungroup | ![Locale un group](images/globalization/locale-un-group.png)
GroupDisable | Grouping is disabled for this column | ![Locale group disable](images/globalization/locale-group-disable.png)
Item | item | ![Locale Item](images/globalization/locale-item.png)
Items | items | ![Locale Items](images/globalization/locale-items.png)
UnGroupButton | Click here to ungroup |
GroupDescription | Press Ctrl space to group | ![Locale group description](images/globalization/locale-group-description.png)
GroupButton | Group button | ![Locale group button](images/globalization/locale-group-button.png)
UnGroupAria | ungroup button | ![Locale ungroup aria](images/globalization/locale-ungroup-aria.png)
GroupSeperator | Separator for the grouped columns | ![Locale group seperator](images/globalization/locale-group-seperator.png)
UnGroupIcon | ungroup the grouped column  | ![Locale ungroup icon](images/globalization/locale-ungroup-icon.png)
GroupedSortIcon | sort the grouped column  | ![Locale grouped sort icon](images/globalization/locale-grouped-sort-icon.png)
GroupedDrag | Drag the grouped column | ![Locale grouped drag](images/globalization/locale-grouped-drag.png)
GroupCaption | is groupcaption cell | ![Locale group caption](images/globalization/locale-group-caption.png)
Expanded | Expanded | ![Locale expanded](images/globalization/locale-expanded.png)
Collapsed | Collapsed | ![Locale collapsed](images/globalization/locale-collapsed.png)

**Filtering**

Locale key words |Text | Example 
-----|-----|-----
InvalidFilterMessage | Invalid Filter Data
FilterbarTitle | \s filter bar cell | ![Locale filterbar title](images/globalization/locale-filterbar-title.png)
Matchs | No Matches Found | ![Locale matchs](images/globalization/locale-matchs.png)
FilterButton | Filter | ![Locale filter button](images/globalization/locale-filter-button.png)
ClearButton | Clear | ![Locale clear button](images/globalization/locale-clear-button.png)
StartsWith | Starts With | ![Locale starts with](images/globalization/locale-starts-with.png)
EndsWith | Ends With | ![Locale ends with](images/globalization/locale-ends-with.png)
Contains | Contains | ![Locale contains](images/globalization/locale-contains.png)
Equal | Equal | ![Locale equal](images/globalization/locale-equal.png)
NotEqual | Not Equal | ![Locale not equal](images/globalization/locale-not-equal.png)
LessThan | Less Than | ![Locale less than](images/globalization/locale-less-than.png)
LessThanOrEqual | Less Than Or Equal | ![Locale less than or equal](images/globalization/locale-less-than-or-equal.png)
GreaterThan | Greater Than | ![Locale greater than](images/globalization/locale-greater-than.png)
GreaterThanOrEqual | Greater Than Or Equal | ![Locale greater than or equal](images/globalization/locale-greater-than-or-equal.png)
ChooseDate | Choose a Date | ![Locale choose date](images/globalization/locale-choose-date.png)
EnterValue | Enter the value | ![Locale enter value](images/globalization/locale-enter-value.png)
SelectAll | Select All | ![Locale select all](images/globalization/locale-select-all.png)
Blanks | Blanks | ![Locale blanks](images/globalization/locale-blanks.png)
FilterTrue | True | ![Locale filter true](images/globalization/locale-filter-true.png)
FilterFalse | False | ![Locale filter false](images/globalization/locale-filter-false.png)
NoResult | No Matches Found | ![Locale no result](images/globalization/locale-no-result.png)
ClearFilter | Clear Filter | ![Locale clear filter](images/globalization/locale-clear-filter.png)
NumberFilter | Number Filters | ![Locale number filter](images/globalization/locale-number-filter.png)
TextFilter | Text Filters | ![Locale text filter](images/globalization/locale-text-filter.png)
DateFilter | Date Filters | ![Locale date filter](images/globalization/locale-date-filter.png)
DateTimeFilter | DateTime Filters | ![Locale date time filter](images/globalization/locale-date-time-filter.png)
MatchCase | Match Case | ![Locale match case](images/globalization/locale-match-case.png)
Between | Between | ![Locale between](images/globalization/locale-between.png)
CustomFilter | Custom Filter | ![Locale custom filter](images/globalization/locale-custom-filter.png)
CustomFilterPlaceHolder | Enter the value | ![Locale custom filter placeholder](images/globalization/locale-custom-filter-placeholder.png)
CustomFilterDatePlaceHolder | Choose a date | ![Locale custom filter date placeholder](images/globalization/locale-custom-filter-date-placeholder.png)
AND | AND | ![Locale AND](images/globalization/locale-AND.png)
OR | OR | ![Locale OR](images/globalization/locale-OR.png)
ShowRowsWhere | Show rows where: | ![Locale show rows where](images/globalization/locale-show-rows-where.png)
NotStartsWith | Does Not Start With | ![Locale not starts with](images/globalization/locale-not-starts-with.png)
Like | Like | ![Locale like](images/globalization/locale-like.png)
NotEndsWith | Does Not End With | ![Locale not ends with](images/globalization/locale-not-ends-with.png)
NotContains | Does Not Contain | ![Locale not contains](images/globalization/locale-not-contains.png)
IsNull | Null | ![Locale is null](images/globalization/locale-is-null.png)
NotNull | Not Null | ![Locale not null](images/globalization/locale-not-null.png)
IsEmpty | Empty | ![Locale is empty](images/globalization/locale-is-empty.png)
IsNotEmpty | Not Empty | ![Locale is not empty](images/globalization/locale-is-not-empty.png)
AddCurrentSelection | Add current selection to filter | ![Locale add current selection](images/globalization/locale-add-current-selection.png)
FilterMenuDialogARIA | Filter menu dialog | ![Locale filter menu dialog ARIA](images/globalization/locale-filter-menu-dialog-ARIA.png)
ExcelFilterDialogARIA | Excel filter dialog | ![Locale excel menu dialog ARIA](images/globalization/locale-excel-menu-dialog-ARIA.png)
CustomFilterDialogARIA | Custom filter dialog | ![Locale Custom filter dialog ARIA](images/globalization/locale-custom-filter-dialog-ARIA.png)
SortAtoZ | Sort A to Z | ![Locale sort AtoZ](images/globalization/locale-sortAtoZ.png)
SortZtoA | Sort Z to A | ![Locale sort ZtoA](images/globalization/locale-sortZtoA.png)
SortByOldest | Sort by Oldest | ![Locale sort by oldest](images/globalization/locale-sort-by-oldest.png)
SortByNewest | Sort by Newest | ![Locale sort by newest](images/globalization/locale-sort-by-newest.png)
SortSmallestToLargest | Sort Smallest to Largest | ![Locale sort smallest to largest](images/globalization/locale-sort-smallest-to-largest.png)
SortLargestToSmallest | Sort Largest to Smallest | ![Locale sort largest to smallest](images/globalization/locale-sort-largest-to-smallest.png)
FilterDescription | Press Alt Down to open filter Menu | ![Locale filter description](images/globalization/locale-filter-description.png)

**Searching**

Locale key words |Text | Example 
-----|-----|-----
Search | Search | ![Locale search](images/globalization/locale-search.png)
SearchColumns | search columns
Clear | Clear | ![Locale clear](images/globalization/locale-clear.png)

**Sorting**

Locale key words |Text | Example 
-----|-----|-----
Sort | Sort | ![Locale sort](images/globalization/locale-sort.png)
SortDescription | Press Enter to sort | ![Locale sort description](images/globalization/locale-sort-description.png)

**Toolbar**

Locale key words |Text | Example 
-----|-----|-----
Print | Print | ![Locale print](images/globalization/locale-print.png)
Pdfexport | PDF Export | ![Locale pdfexport](images/globalization/locale-pdfexport.png)
Excelexport | Excel Export | ![Locale excelexport](images/globalization/locale-excelexport.png)
Csvexport | CSV Export | ![Locale csvexport](images/globalization/locale-csvexport.png)

**ColumnMenu**

Locale key words |Text | Example 
-----|-----|-----
FilterMenu | Filter | ![Locale filter menu](images/globalization/locale-filter-menu.png)
AutoFitAll | Autofit all columns |
AutoFit | Autofit this column |
ColumnMenuDialogARIA | Column menu dialog | ![Locale columnmenu dialog ARIA](images/globalization/locale-columnmenu-dialog-ARIA.png)
ColumnMenuDescription | Press Alt Down to open Column Menu | ![Locale columnmenu description](images/globalization/locale-columnmenu-description.png)

**ContextMenu**

Locale key words |Text | Example 
-----|-----|-----
Copy | Copy | ![Locale copy](images/globalization/locale-copy.png)
Group | Group by this column | ![Locale group](images/globalization/locale-group.png)
Ungroup | Ungroup by this column | ![Locale ungroup](images/globalization/locale-ungroup.png)
autoFitAll | Auto Fit all columns | ![Locale autofit all](images/globalization/locale-autofit-all.png)
autoFit | Auto Fit this column | ![Locale autofit](images/globalization/locale-autofit.png)
Export | Export | ![Locale export](images/globalization/locale-export.png)
FirstPage | First Page | ![Locale first page](images/globalization/locale-first-page.png)
LastPage | Last Page | ![Locale last page](images/globalization/locale-last-page.png)
PreviousPage | Previous Page | ![Locale previous page](images/globalization/locale-previous-page.png)
NextPage | Next Page | ![Locale next page](images/globalization/locale-next-page.png)
SortAscending | Sort Ascending | ![Locale sort ascending](images/globalization/locale-sort-ascending.png)
SortDescending | Sort Descending | ![Locale sort descending](images/globalization/locale-sort-descending.png)
EditRecord | Edit Record | ![Locale edit record](images/globalization/locale-edit-record.png)
DeleteRecord | Delete Record | ![Locale delete record](images/globalization/locale-delete-record.png)

**Pager**

Locale key words |Text | Example 
-----|-----|-----
currentPageInfo | {0} of {1} pages | ![Locale current page info](images/globalization/locale-current-page-info.png)
totalItemsInfo | ({0} items) | ![Locale total items info](images/globalization/locale-total-items-info.png)
firstPageTooltip | Go to first page | ![Locale first page tooltip](images/globalization/locale-first-page-tooltip.png)
lastPageTooltip | Go to last page | ![Locale last page tooltip](images/globalization/locale-last-page-tooltip.png)
nextPageTooltip | Go to next page | ![Locale next page tooltip](images/globalization/locale-next-page-tooltip.png)
previousPageTooltip | Go to previous page | ![Locale previous page tooltip](images/globalization/locale-previous-page-tooltip.png)
nextPagerTooltip | Go to next pager items | ![Locale next pager tooltip](images/globalization/locale-next-pager-tooltip.png)
previousPagerTooltip | Go to previous pager items | ![Locale previous pager tooltip](images/globalization/locale-previous-pager-tooltip.png)
pagerDropDown | Items per page | ![Locale pager drop down](images/globalization/locale-pager-drop-down.png)
pagerAllDropDown | Items | ![Locale pager all drop down](images/globalization/locale-pager-all-drop-down.png)
All | All | ![Locale pager all](images/globalization/locale-pager-all.png)
totalItemInfo | ({0} item) | ![Locale total item info](images/globalization/locale-pager-total-item-info.png)
Container | Pager Container | ![Locale pager container](images/globalization/locale-pager-container.png)
Information | Pager Information |
ExternalMsg | Pager external message | ![Locale pager external msg](images/globalization/locale-pager-external-msg.png)
Page | Page  |
Of |  of  | ![Locale pager of](images/globalization/locale-pager-of.png)
Pages |  Pages |

### Loading translations for de culture

The Syncfusion ASP.NET MVC Grid component provides a built-in Localization library that allows you to load translation objects for different cultures. By using the **Load** function of the **L10n** class, you can customize the text content of the Grid to be displayed in different languages. 

This feature allows you to specify translation objects for specific cultures, such as **Deutsch** (German), and display the Grid's content in the desired language.

The following example demonstrates how to load a translation object for **Deutsch (de)** culture, by using the **Load** function of **L10n** class from the **ej2-base** module and by defining the [locale](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) to **de-DE**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/globalization/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/grid/globalization/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

![Globalization-De-Culture](images/globalization/localization-de-culture.png)

### Loading translations for fr culture 

The Loading translations feature allows you to specify translation objects for different cultures, such as **Deutsch**, **Arabic**, **French** and display the Grid's content in the desired language.

The following example demonstrates how to load a translation object for **French (fr)** culture, by defining the [locale](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) to **fr-FR** and by using the **Load** function of **L10n** class from the **ej2-base** module.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/globalization/localization-fr-culture/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/grid/globalization/localization-fr-culture/localization-fr-culture.cs %}
{% endhighlight %}
{% endtabs %}

![Globalization-FR-Culture](images/globalization/localization-fr-culture.png)

### Switch the different localization

The Synfusion ASP.NET MVC Grid allows you to switch the localization from one culture to another culture. This will be useful when you want to change the localization based on your requirements. 

To switch to a different localization, follow these steps:

**Step 1:** Import and load the required CLDR (Common Locale Data Repository) data for the desired culture using the loadCldr function.

```ts
loadCldr(
    cagregorian,
    currencies,
    numbers,
    timeZoneNames,
    numberingSystems
);
```

**Step 2:** To change the default culture and the currency code, you can use the methods `SetCulture` for setting the locale and `SetCurrencyCode` for setting the currency code.

To switch to the **French** culture and set the currency code as **EUR**, you can use the `SetCulture` method and the `SetCurrencyCode` method of the Grid on external button click. This is demonstrated below: 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/globalization/switch-localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/grid/globalization/switch-localization/switch-localization.cs %}
{% endhighlight %}
{% endtabs %}

![Globalization-Switch-Culture](images/globalization/switch-localization.gif)

### Set different locale for two Grids in same page

The Syncfusion Grid allows you to use different locales for multiple Grids on the same page. You can achieve this by setting the [locale](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property for each Grid individually.

In the following example, the first Grid is configured to use the French **de-DE** locale. This is achieved by setting the locale property to **de-DE** and loading the French translation object using the **L10n.load** function from the **ej2-base** module. For the second Grid, the locale property is set to **en-US**, which applies the default English locale.

This setup demonstrates how to display/apply different locale texts for each Grid on the same page by configuring the [locale](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property individually and loading the necessary translations.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/globalization/two-localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/grid/globalization/two-localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

## Internationalization

The Internationalization library in the Syncfusion ASP.NET MVC Grid provides a localized display of number, date, and time values in the Grid control based on the preferred language and region.

[Internationalization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization) library allows you to globalize number, date, and time values using format strings defined in the `Columns.Format` property.

You need to load the culture format files corresponding to the desired locale. This ensures that the Grid control uses the correct format strings for number, date, and time values based on the selected culture. This can be demonstrated in the below example,

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/globalization/internationalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internationalization.cs" %}
{% include code-snippet/grid/globalization/internationalization/internationalization.cs %}
{% endhighlight %}
{% endtabs %}

![Globalization-Internalization](images/globalization/internalization.png)

> * In the above sample, **Freight** column is formatted using the [NumberFormatOptions](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization#manipulating-numbers).
> * By default, [Locale](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Locale) value is **en-US**. If you wish to change the culture to something other than **en-US**, you can simply set the `Locale` property accordingly.

## Right to Left - RTL

The Right to Left (RTL) feature in the Syncfusion ASP.NET MVC Grid allows you to switch the text direction and layout from left-to-right to right-to-left. This feature is especially beneficial for interacting with the grid in languages that are written and read from right to left, such as **Arabic**, **Farsi,** **Urdu**, and others. Enabling RTL significantly improves the experience and accessibility for such languages.

To enable RTL in the Grid, you need to set the [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableRtl) property to **true**. By setting `EnableRtl`, the grid control's text direction and layout will be adjusted to support right-to-left languages.

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/getting-started) control is added to enable or diable the Right to Left (RTL) feature for the **Arabic (ar-AE)** locale. When the switch is toggled, the `Change` event is triggered and the `EnableRtl` property of the grid is updated accordingly. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/globalization/righttoleft/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Righttoleft.cs" %}
{% include code-snippet/grid/globalization/righttoleft/righttoleft.cs %}
{% endhighlight %}
{% endtabs %}

![Globalization-RTL](images/globalization/localization-rtl.gif)

## See Also

* [Internationalization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/internationalization)
* [Localization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization)