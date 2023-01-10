---
layout: post
title: Searching in ##Platform_Name## Syncfusion Spreadsheet Component
description: Learn here all about Searching in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Searching
publishingplatform: ##Platform_Name##
documentation: ug
---


# Find and Replace in Spreadsheet control

Find and Replace helps you to search for the target text and replace the found text with alternative text within the sheet or workbook. You can use the [`allowFindAndReplace`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowFindAndReplace) property to enable or disable the Find and Replace functionality.

N> * The default value for `allowFindAndReplace` property is `true`.

## Find

Find feature is used to select the matched contents of a cell within the sheet or workbook. It is extremely useful when working with large set of data source.

**User Interface**:

Find can be done by any of the following ways:

* Select the Search icon in the Ribbon toolbar or use `Ctrl + F` key to open the Find dialog.
* Use find Next and find Previous buttons to search the given value in the workbook.
* Select the option button in Find dialog to open the Find and Replace dialog. Then, select the below properties for enhanced searching.

N> * `Search within`: To search the target in a sheet (default) or in an entire workbook.
<br/> * `Search by`: It enhance the search, either By Rows (default), or By Columns.
<br/> * `Match case`: To find the matched value with case sensitive.
<br/> * `Match exact cell contents`: To find the exact matched cell value with entire match cases.

* Using `find()` method to perform find operation.

## Replace

Replace feature is used to change the find contents of a cell within sheet or workbook. Replace All is used to change all the matched contents of a cell within sheet or workbook.

**User Interface**:

Replace can be done by any of the following ways:

* Use `Ctrl + H` key to open the Find and Replace dialog.
* Use Replace button to change the found value in sheet or workbook.
* Using Replace All button, all the matched criteria can be replaced with find value based on sheet or workbook.
* Using `replace()` method to perform replace operation by passing the argument `args.replaceby` as `replace`.
* Using `replace()` method to perform replace all operation by passing the argument `args.replaceby` as `replaceall`.

## Go to

Go to feature is used to navigate to a specific cell address in the sheet or workbook.

**User Interface**:

* Use `Ctrl + G` key to open the Go To dialog.
* Use `goTo()` method to perform Go To operation.

In the following sample, searching can be done by following ways:

* Select the Home tab in the Ribbon toolbar, and then select the Search icon.
* Enter any value in the search textbox.
* Select the next (or) previous button to find the entered value in the spreadsheet.
* You can have more options to find values by selecting the more options in the search toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SearchController.cs" %}
{% include code-snippet/spreadsheet/search/searchController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SearchController.cs" %}
{% include code-snippet/spreadsheet/search/searchController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

* Undo/redo for Replace All is not supported in this feature.