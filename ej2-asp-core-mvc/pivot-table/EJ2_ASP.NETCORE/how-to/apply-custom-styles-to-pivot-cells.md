---
layout: post
title: Apply custom style to pivot cells in ##Platform_Name## Pivot Table Component
description: Learn here all about Apply custom style to pivot cells in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Apply custom style to pivot cells 
documentation: ug
publishingplatform: ##Platform_Name## 
---

# Apply custom style to pivot cells in ##Platform_Name## Pivot Table Component

The [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event in [`e-gridSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) can be used to apply custom style to row and value cells, and the [`headerCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event in [`e-gridSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) can be used to apply custom styles to column cells.

In the following example, a custom style has been applied to the column header **"Sold Amount"** under **"FY 2016"** via the [`headerCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event and to the row header **"Germany"** and its aggregated value via the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event by adding the **"e-custom"** class to the cell element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/apply-custom-styles/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomStyles.cs" %}
{% include code-snippet/pivot-table/apply-custom-styles/CustomStyles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/apply-custom-styles/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomStyles.cs" %}
{% include code-snippet/pivot-table/apply-custom-styles/CustomStyles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Apply custom style to pivot cells](../images/apply-custom-styles.png)

N> The **dot(.)** character in **FY 2016.Sold Amount** is used by default to identify the header levels in the pivot table's row and column. It can be changed by setting the [`headerDelimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderDelimiter) in the [`e-valuesortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html) property to any other delimiter instead of the default separator.