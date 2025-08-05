---
layout: post
title: Change row and column header text in ##Platform_Name## Spreadsheet control | Syncfusion
description: Learn here all about changing row and column header text in Syncfusion ##Platform_Name## Spreadsheet control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

# Change row and column header text in Spreadsheet Control

To change the row and column header text in the  Spreadsheet component, you can use the `beforeCellRender` event. This event allows you to modify the header cells by checking for the `e-header-cell` class in the `element` and verifying the `rowIndex` and `colIndex` of the cell. If these conditions are met, you can set a custom header text by changing the `innerText` property of the header cell.

The following code example demonstrates how to change the row and column header text in Spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/change-row-and-column-header-text-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeHeaderTextController.cs" %}
{% include code-snippet/spreadsheet/change-row-and-column-header-text-cs1/changeHeaderTextController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/change-row-and-column-header-text-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeHeaderTextController.cs" %}
{% include code-snippet/spreadsheet/change-row-and-column-header-text-cs1/changeHeaderTextController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}