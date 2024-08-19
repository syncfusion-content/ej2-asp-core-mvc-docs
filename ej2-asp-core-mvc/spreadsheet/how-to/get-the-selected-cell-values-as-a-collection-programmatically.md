---
layout: post
title: Get the selected cell values as a collection programmatically in ##Platform_Name## Spreadsheet control | Syncfusion
description: Learn here all about how to get the selected cell values as a collection programmatically in Syncfusion ##Platform_Name## Spreadsheet control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

# Get the selected cell values as a collection programmatically in ##Platform_Name## Spreadsheet Control

{% if page.publishingplatform == "aspnet-core" %}

You can select single or multiple cells, rows, or columns using mouse and keyboard interactions. Additionally, you can also programmatically perform selection using the [selectRange](https://helpej2.syncfusion.com/documentation/api/spreadsheet/#selectrange) method. This selection behavior is controlled based on the [selectionSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SelectionSettings) property. Now, retrieving the selected cell values as a collection is achievable using the [getData](https://helpej2.syncfusion.com/documentation/api/spreadsheet/#getdata) method.

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can select single or multiple cells, rows, or columns using mouse and keyboard interactions. Additionally, you can also programmatically perform selection using the [selectRange](https://helpej2.syncfusion.com/documentation/api/spreadsheet/#selectrange) method. This selection behavior is controlled based on the [selectionSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_SelectionSettings) property. Now, retrieving the selected cell values as a collection is achievable using the [getData](https://helpej2.syncfusion.com/documentation/api/spreadsheet/#getdata) method.

{% endif %}

Below is a code example demonstrating how to retrieve the selected cell values as a collection programmatically:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/selected-cell-values/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectedCellValuesController.cs" %}
{% include code-snippet/spreadsheet/selected-cell-values/selectedCellValuesController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/selected-cell-values/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectedCellValuesController.cs" %}
{% include code-snippet/spreadsheet/selected-cell-values/selectedCellValuesController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
