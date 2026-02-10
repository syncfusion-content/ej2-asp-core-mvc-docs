---
layout: post
title: Chart Based On Pivot Table Selection in ##Platform_Name## Pivot Table Component
description: Learn here all about Chart Based On Pivot Table Selection in Syncfusion ##Platform_Name## Pivot Table component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Chart Based On Pivot Table Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render chart control based on cell selection

The ASP.NET MVC Pivot Table component supports creating charts based on cell selections within the pivot table. This customization allows charts to be plotted dynamically using data from selected cells, providing visual representation of specific data segments.

## Configuration

Cell selection is enabled using the [`AllowSelection`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowSelection) property. The selection behavior is configured through the [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) property to define selection type and mode.

## Implementation

The [`cellSelected`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CellSelected) event triggers when cells are selected in the pivot table. This event provides selected cell information including row header name, column header name, measure name, and values. Using this data, the [`chart`](https://ej2.syncfusion.com/aspnetmvc/documentation/chart/getting-started) control can be plotted accordingly.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/chart/Popup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/chart/Popup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Chart Based On Pivot Table Selection](../images/chart-selection.png)