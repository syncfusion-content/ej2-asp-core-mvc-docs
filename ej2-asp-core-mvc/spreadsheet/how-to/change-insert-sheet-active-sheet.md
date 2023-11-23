---
layout: post
title: Insert sheet programmatically and switch the inserted sheet as active sheet in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about insert sheet programmatically and switch the inserted sheet as active sheet in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Insert sheet programmatically and switch the inserted sheet as active sheet in Spreadsheet Control

You can insert sheet into the spreadsheet using `insertSheet` method. As the new sheet is inserted and populated with the data source using `goTo` method you can switch the inserted sheet as active sheet.

The following code example shows how to set the active sheet when importing an Excel file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/insert-sheet-change-active-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InsertSheetController.cs" %}
{% include code-snippet/spreadsheet/insert-sheet-change-active-sheet/insertSheetController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/insert-sheet-change-active-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InsertSheetController.cs" %}
{% include code-snippet/spreadsheet/insert-sheet-change-active-sheet/insertSheetController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
