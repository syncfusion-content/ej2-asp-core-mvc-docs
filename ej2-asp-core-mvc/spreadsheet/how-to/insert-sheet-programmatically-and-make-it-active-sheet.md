---
layout: post
title: Insert a sheet programmatically and set the inserted sheet as the active sheet in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about insert a sheet programmatically and set the inserted sheet as active sheet in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Insert a sheet programmatically and make it the active sheet in Spreadsheet Control

Sheet is a collection of cells organized in the form of rows and columns that allows you to store, format, and manipulate the data. Using `insertSheet` method, you can insert one or more sheets at your desired index. Now, you can make the inserted sheet as active sheet by focusing the start cell of that sheet using `goTo` method.

The following code example shows how to insert a sheet programmatically and make it the active sheet.

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
