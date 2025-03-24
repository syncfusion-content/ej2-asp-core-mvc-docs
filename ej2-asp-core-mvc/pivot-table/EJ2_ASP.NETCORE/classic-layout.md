---
layout: post
title: Classic layout in ##Platform_Name## Syncfusion Pivot Table Component
description: Learn here all about Classic layout in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Classic Layout
publishingplatform: ##Platform_Name##
documentation: ug
---


# Classic Layout in ##Platform_Name## Pivot Table Component

N> The classic layout supports only relational data sources and operates exclusively with client-side engine.

The classic layout in the Syncfusion Pivot Table offers a structured, tabular presentation of data, improving both readability and usability. In this layout, fields in the row axis are displayed side by side in separate columns, making data interpretation and analysis easier. By default, grand totals appear at the end of all rows, while subtotals are placed in a separate row beneath each group. All other features of the pivot table, such as filtering, sorting, drag-and-drop, expand/collapse functionality, and more, remain the same as in the compact layout, which serves as the default hierarchical format of the pivot table.

To enable the classic layout, set the [layout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_Layout) property in the [e-gridSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) tag to **Tabular**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/classic-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ClassicLayout.cs" %}
{% include code-snippet/pivot-table/classic-layout/ClassicLayout.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/classic-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClassicLayout.cs" %}
{% include code-snippet/pivot-table/classic-layout/ClassicLayout.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Classic Layout](images/classic-layout.png)

**Limitations**

* Subtotals at the "Top" position are not supported for row subtotals.
