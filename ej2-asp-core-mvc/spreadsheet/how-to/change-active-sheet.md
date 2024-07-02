---
layout: post
title: Changing the active sheet while importing a file in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about changing the active sheet index while importing a file in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Changing the active sheet while importing a file in Spreadsheet Control

You can change the active sheet of imported file by updating [`activeSheetIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_ActiveSheetIndex) property on the [`openComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_OpenComplete) event.

The following code example shows how to set the active sheet when importing an Excel file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/change-active-sheet/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/change-active-sheet/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/change-active-sheet/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OpenController.cs" %}
{% include code-snippet/spreadsheet/change-active-sheet/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
