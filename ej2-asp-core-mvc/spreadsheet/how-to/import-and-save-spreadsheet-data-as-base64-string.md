---
layout: post
title: Import and save Spreadsheet data as a Base64 string in ##Platform_Name## Spreadsheet Control | Syncfusion
description: LLearn here all about import and save Spreadsheet data as a Base64 string in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Import and save Spreadsheet data as a Base64 string in Spreadsheet Control

The Spreadsheet component saves its data, style, format, and more as an Excel file document and opens an Excel document with its data, style, format, and more.

Currently, there is no direct option to open and save data as a Base64 string. However, you can do this by saving the Spreadsheet data as `Blob data` and then converting that saved blob data to `Base64 string` using `FileReader`. 

You can get the Spreadsheet data as blob in the [saveComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveComplete) event when you set the `needBlobData as true` and `isFullPost as false` in the [beforeSave](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event.

The following code example shows how to import and save the spreadsheet data as base64 string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/base-64-string/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/base-64-string/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/base-64-string/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/base-64-string/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
