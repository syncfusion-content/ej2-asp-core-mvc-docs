---
layout: post
title: Hide specific columns in ##Platform_Name## Pivot Table Component
description: Learn here all about Hide specific columns in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Hide specific columns in pivot table 
documentation: ug
publishingplatform: ##Platform_Name##
---

# Hide specific columns in ##Platform_Name## Pivot Table Component

By using the [`columnRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html), you can hide specific column(s) in the pivot table. In the example below, the **"Units Sold"** column under **"FY 2016"** is hidden by setting its **visible** property to **false** via the [`columnRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event.

N> The **dot(.)** character in **FY 2016.Units Sold** is used by default to identify the header levels in the pivot table's row and column. It can be changed by setting the [`headerDelimiter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html#Syncfusion_EJ2_PivotView_PivotViewValueSortSettings_HeaderDelimiter) in the [`e-valuesortsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewValueSortSettings.html) property to any other delimiter instead of the default separator.

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