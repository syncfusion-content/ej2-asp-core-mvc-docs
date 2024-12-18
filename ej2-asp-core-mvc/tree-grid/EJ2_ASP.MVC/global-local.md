---
layout: post
title: Global Local in ##Platform_Name## Tree Grid Component
description: Learn here all about Global Local in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Global Local
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ASP.NET MVC Tree Grid control

## Localization

The [Localization](https://ej2.syncfusion.com/aspnetmvc/documentation/common/localization/) library allows you to localize default text content of the TreeGrid. The treegrid component has static text on some features (like toolbar area text, filter menu text, pager information text, etc.) that can be changed to other cultures (Arabic, Deutsch, French, etc.) by defining the [Locale](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Locale.html) value and translation object.

The following list of properties and its values are used in the treegrid.

| Locale keywords | Text |
|-----------------|------|
EmptyRecord | No records to display
True | true
False | false
ExpandAll | Expand All
CollapseAll | Collapse All
RowIndent | Indent
RowOutdent | Outdent
InvalidFilterMessage | Invalid Filter Data
FilterbarTitle | \s filter bar cell
Add | Add
Edit| Edit
Cancel| Cancel
Update| Update
Delete | Delete
Print | Print
Pdfexport | PDF Export
Excelexport | Excel Export
Wordexport | Word Export
Csvexport | CSV Export
Search | Search
Save | Save
EditOperationAlert | No records selected for edit operation
DeleteOperationAlert | No records selected for delete operation
SaveButton | Save
OKButton | OK
CancelButton | Cancel
EditFormTitle | Details of
AddFormTitle | Add New Record
ConfirmDelete | Are you sure you want to Delete Record?
SearchColumns | search columns
Matchs | No Matches Found
FilterButton | Filter
ClearButton | Clear
StartsWith | Starts With
EndsWith | Ends With
Contains | Contains
Equal | Equal
NotEqual | Not Equal
LessThan | Less Than
LessThanOrEqual | Less Than Or Equal
GreaterThan | Greater Than
GreaterThanOrEqual | Greater Than Or Equal
ChooseDate | Choose a Date
EnterValue | Enter the value
autoFitAll | Auto Fit all columns
autoFit | Auto Fit this column
Export | Export
FirstPage | First Page
LastPage | Last Page
PreviousPage | Previous Page
NextPage | Next Page
SortAscending | Sort Ascending
SortDescending | Sort Descending
EditRecord | Edit Record
DeleteRecord | Delete Record
Above | Above
Below | Below
AddRow | Add Row
FilterMenu | Filter
SelectAll | Select All
Blanks | Blanks
FilterTrue | True
FilterFalse | False
NoResult | No Matches Found
ClearFilter | Clear Filter
NumberFilter | Number Filters
TextFilter | Text Filters
DateFilter | Date Filters
MatchCase | Match Case
Between | Between
CustomFilter | Custom Filter
CustomFilterPlaceHolder | Enter the value
CustomFilterDatePlaceHolder | Choose a date
AND | AND
OR | OR
ShowRowsWhere | Show rows where:
currentPageInfo | {0} of {1} pages
totalItemsInfo | ({0} items)
firstPageTooltip | Go to first page
lastPageTooltip | Go to last page
nextPageTooltip | Go to next page
previousPageTooltip | Go to previous page
nextPagerTooltip | Go to next pager items
previousPagerTooltip | Go to previous pager items
pagerDropDown | Items per page
pagerAllDropDown | Items
All | All

### Loading translations

To load translation object in an application, use **load** function of the **L10n** class.

The following example demonstrates the TreeGrid in **Deutsch** culture.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/global-local/global/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Global.cs" %}
{% include code-snippet/tree-grid/global-local/global/global.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/global-local/global/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Global.cs" %}
{% include code-snippet/tree-grid/global-local/global/global.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Localization of dependent components in TreeGrid

When localizing TreeGrid, it's important to include dependent components like DatePicker, Form Validator, and Grid, as they have their own static text that requires localization. Follow these steps to localize these components:

1. **DatePicker**: Localize placeholders, "today" text, etc., using the [DatePicker localization keys](https://ej2.syncfusion.com/javascript/documentation/datepicker/globalization)

    Example localization keys for the date picker:
    ```json
   "datepicker": {
            "placeholder": "Wählen Sie ein Datum",
            "today": "heute"
        }
    ```


2. **Form Validator**: Localize validation messages (e.g., required fields, email validation) using the [Form Validator localization keys](https://ej2.syncfusion.com/documentation/form-validator/localization).

    Example keys for form validation localization:
    ```json
    "formValidator":{
        "required": "This field is required",
        "email": "Please enter a valid email address",
        "minLength": "Please enter at least {0} characters"
    }
    ```
3. **Grid Keys**: For additional TreeGrid-related keys, use the [Grid localization keys](https://ej2.syncfusion.com/javascript/documentation/grid/global-local#localization).

   Example keys for grid keys localization:
    ```json
    "grid" :{
        "True": "true",
        "False": "false",
        "Item": "item",
        "Items": "items",
        "OKButton": "OK",
    }
    ```



    Below is an example JSON snippet consolidating the localization keys for dependent components used in TreeGrid using  [`load`](../api/base/l10n/#load) function of the `L10n` class and update the `locale` property of treegrid with the culture name used in the `load` function:

    ```json
    ej.base.L10n.load({
    
        'de-DE': {
    
        "datepicker": {
                "placeholder": "Wählen Sie ein Datum",
                "today": "heute"
            },
    
        "formValidator":{
            "required": "This field is required",
            "email": "Please enter a valid email address",
            "minLength": "Please enter at least {0} characters"
        },
    
        "grid" :{
            "True": "true",
            "False": "false",
            "Item": "item",
            "Items": "items",
            "OKButton": "OK",
        }
    }
    });
    ```



## Internationalization

The [`Internationalization`](../../common/internationalization/) library is used to globalize number, date, and time values in treegrid component using format strings in the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/global-local/internalization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Internalization.cs" %}
{% include code-snippet/tree-grid/global-local/internalization/internalization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/global-local/internalization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Internalization.cs" %}
{% include code-snippet/tree-grid/global-local/internalization/internalization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> In the above sample, **Price** column is formatted by **NumberFormatOptions**.
<br/> By default, [`Locale`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Locale.html) value is **en-US**. If you want to change the **en-US** culture to a different culture, you have to change  the [`Locale`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Locale.html) accordingly.

## Right to left (RTL)

RTL provides an option to switch the text direction and layout of the TreeGrid component from right to left. It improves the user experiences and accessibility for users who use right-to-left languages (Arabic, Farsi, Urdu, etc.). To enable RTL Grid, set the [`EnableRtl`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~EnableRtl.html) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/global-local/enableRtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableRtl.cs" %}
{% include code-snippet/tree-grid/global-local/enableRtl/enableRtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/global-local/enableRtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableRtl.cs" %}
{% include code-snippet/tree-grid/global-local/enableRtl/enableRtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Internationalization](../../common/internationalization)
* [Localization](../../common/localization)

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.
