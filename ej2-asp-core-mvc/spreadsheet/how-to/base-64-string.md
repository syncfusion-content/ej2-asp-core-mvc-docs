---
layout: post
title: Load and Save the spreadsheet data as Base64 string in client side in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about load and save the spreadsheet data as Base64 string in client side in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Load and Save the spreadsheet data as Base64 string in client side in Spreadsheet Control

Currently spreadsheet don’t have direct option to save the data as Base64 string. However, this can be achievable by saving the spreadsheet data as `Blob data` and convert that saved blob data to `Base64 string` using `FileReader`. To get the Blob data in [`saveComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveComplete) event, you need to set the `needBlobData as true` and `isFullPost as false` in [`beforeSave`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event.

The following code example shows how to load and save the spreadsheet data as Base64 string in client side.

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
