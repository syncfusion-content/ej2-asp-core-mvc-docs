---
layout: post
title: Apply custom style to pivot cells in ASP.NET Core | Syncfusion
description: Learn here all about Apply custom style to pivot cells in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Apply custom style to pivot cells 
documentation: ug
publishingplatform: ##Platform_Name## 
---

# Apply custom style to pivot cells in ASP.NET Core Pivotview component

The ASP.NET Core Pivot Table component allows you to alter the appearance of pivot cells using event handlers. This guide demonstrates how to apply custom styling to specific cells in your pivot table.

## Overview

You can apply custom styles to different types of cells in the pivot table:
- Use the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event to style row headers and value cells.
- Use the [`headerCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event to style column headers.

Both events are available through the [`e-gridSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) property of the Pivot Table component.

## Implementation example

The following example shows how to apply styles to:
- The column header **"Sold Amount"** under **"FY 2016"** using the [`headerCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_HeaderCellInfo) event.
- The row header **"Germany"** and its aggregated values using the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event.
- Styles are applied by adding the **"e-custom"** CSS class to the cell elements.

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