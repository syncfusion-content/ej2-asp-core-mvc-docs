---
layout: post
title: Set an imported excel file's active sheet in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about Set an imported excel file's active sheet in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Change the active sheet in the imported Excel file
publishingplatform: ##Platform_Name##
documentation: ug
---

## Set an imported excel file's active sheet in the Spreadsheet Control

You can change the active sheet of imported file by updating [`activeSheetIndex`](https://ej2.syncfusion.com/react/documentation/api/spreadsheet/#activesheetindex) property on the [`openComplete`](https://ej2.syncfusion.com/react/documentation/api/spreadsheet/#opencomplete) event.

The code sample below demonstrates how to set the active sheet when importing an Excel file.

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