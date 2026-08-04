---
layout: post
title: How to Hide Specific Columns in ASP.NET MVC Pivot Table | Syncfusion
description: Learn how to hide a specific column in the ASP.NET MVC Pivot Table via the ColumnRender event in PivotViewGridSettings, setting the column's visible property to false.
platform: ej2-asp-core-mvc
control: Hide specific columns in pivot table 
documentation: ug
publishingplatform: ##Platform_Name##
---

# How to Hide Specific Columns in ASP.NET MVC Pivot Table

By using the [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender)event in the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html), you can hide specific column(s) in the pivot table. In the example below, the **"Units Sold"** column under **"FY 2016"** is hidden by setting its **visible** property to **false** via the [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender)event.

N> The **dot(.)** character in **FY 2016.Units Sold** is used by default to identify the header levels in the pivot table's row and column. It can be changed by setting the [`HeaderDelimiter`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderDelimiter) in the [`PivotViewValueSortSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html) property to any other delimiter instead of the default separator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hide-specific-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HideSpecificColumn.cs" %}
{% include code-snippet/pivot-table/hide-specific-column/HideSpecificColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hide-specific-column/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HideSpecificColumn.cs" %}
{% include code-snippet/pivot-table/hide-specific-column/HideSpecificColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Hide specific columns in Pivot Table](../images/hide-specific-column.png)