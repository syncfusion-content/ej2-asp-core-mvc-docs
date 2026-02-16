---
layout: post
title: Customize Empty Value Cells in ##Platform_Name## Pivot Table Component
description: Learn here all about Customize Empty Value Cells in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Empty Value Cells
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize empty value cells

When working with pivot table, certain combinations of row and column headers may not have corresponding data values, resulting in empty cells. The ASP.NET MVC Pivot Table component allows you to display custom text in these empty cells instead of leaving them blank, thereby improving the visual presentation and enhancing the user experience of your pivot table.

## Configuration

Use the [`EmptyCellsTextContent`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_EmptyCellsTextContent) property under [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) in the pivot table to define custom text for empty cells. This string option accepts any text value and applies it consistently across all empty cells in the pivot table.

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


