---
layout: post
title: How to Customize Empty Cells in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to set custom text in empty ASP.NET Core Pivot Table value cells via the emptyCellsTextContent property under e-datasourcesettings.
platform: ej2-asp-core-mvc
control: Customize Empty Value Cells
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize empty value cells in ASP.NET Core Pivot Table

When working with the pivot table, certain combinations of row and column headers may not have corresponding data values, resulting in empty cells. The ASP.NET Core Pivot Table component allows you to display custom text in these empty cells instead of leaving them blank, thereby improving the visual presentation and enhancing the user experience of your pivot table.

## Configuration

Use the [`emptyCellsTextContent`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EmptyCellsTextContent) property under [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) in the pivot table to define custom text for empty cells. This string option accepts any text value and applies it consistently across all empty cells in the pivot table.

### Basic Implementation

The following example demonstrates how to configure custom text for empty value cells during the initial rendering of the Pivot Table component:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomText.cs" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/CustomText.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomText.cs" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/CustomText.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


