---
layout: post
title: Save and open Spreadsheet data as a Base64 string in ##Platform_Name## Spreadsheet control | Syncfusion
description: Learn here all about save and open Spreadsheet data as a Base64 string in Syncfusion ##Platform_Name## Spreadsheet control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Save and open Spreadsheet data as a Base64 string in ##Platform_Name## Spreadsheet control

In the Spreadsheet control, there is currently no direct option to save and open data as a `Base64` string. You can achieve this by saving the Spreadsheet data as blob data and then converting that saved blob data to a `Base64` string using `FileReader`. 

> You can get the Spreadsheet data as blob in the [saveComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SaveComplete) event when you set the  `needBlobData` as **true** and `isFullPost` as **false** in the [beforeSave](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.spreadsheet.spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_BeforeSave) event.

The following code example shows how to save and open the spreadsheet data as base64 string.

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
