---
layout: post
title: Summary Customization in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table shows or hides grand totals and subtotals via showGrandTotals, showRowGrandTotals, and showColumnGrandTotals.
platform: ej2-asp-core-mvc
control: Summary Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show or hide totals in ASP.NET Core Pivot Table

The ASP.NET Core Pivot Table component allows users to easily customize the display of grand totals and sub-totals. This documentation explains how to control their visibility and positioning to suit your data analysis needs.

## Show or hide grand totals

The ASP.NET Core Pivot Table component provides options to display or hide grand totals for rows, columns, or both. These options are configured using the following properties within the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) object:

- [`showGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals): Controls the visibility of grand totals for both rows and columns. Set this property to **false** to hide grand totals in both directions.
- [`showRowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowGrandTotals): When set to **false**, this property hides only the row grand totals.
- [`showColumnGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnGrandTotals): When set to **false**, this property hides only the column grand totals.

> By default, all of these properties—[`showGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals), [`showRowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowGrandTotals), and [`showColumnGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnGrandTotals)—are set to **true** in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) object.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/grand-total/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/grand-total/GrandTotal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/grand-total/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/grand-total/GrandTotal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Grand totals example](images/grandtotal.png)

## Set grand totals position

You can specify the position of grand totals for rows and columns in a Pivot Table by configuring the [`grandTotalsPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.GrandTotalsPosition.html) property within the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) object. You can choose to place the grand totals either at the top or at the bottom of the pivot table, depending on your preference.

To display grand totals at the top of both rows and columns, set the [`grandTotalsPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.GrandTotalsPosition.html) property to **Top**. To show grand totals at the bottom (which is the default setting), set it to **Bottom**. This property applies to both row and column grand totals simultaneously.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/grand-total-top/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/grand-total-top/GrandTotalTop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/grand-total-top/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/grand-total-top/GrandTotalTop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Show or hide sub-totals

The ASP.NET Core Pivot Table component enables showing or hiding sub-totals for rows, columns, or both. Use the following properties in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) object to configure these options:

- [`showSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSubTotals): Set to **false** to hide all sub-totals for rows and columns.
- [`showRowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowSubTotals): Set to **false** to hide row sub-totals only.
- [`showColumnSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnSubTotals): Set to **false** to hide column sub-totals only.

> By default, the [`showSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSubTotals), [`showRowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowSubTotals), and [`showColumnSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnSubTotals) properties in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) object are set to **true**, ensuring sub-totals are visible across the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/sub-total/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SubTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/sub-total/SubTotal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/sub-total/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SubTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/sub-total/SubTotal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Sub-totals example](images/sub-total.png)

## Show or hide sub-totals for specific fields

The ASP.NET Core Pivot Table component allows users to show or hide sub-totals for specific fields in the row and column axes. Set the `showSubTotals` property to **false** on an individual field entry inside the [`Row`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) array to hide the sub-total for that field only.

> By default, the `showSubTotals` property for fields in both the [`Row`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) and [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) axes is set to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/sub-total-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SubTotalSpecific.cs" %}
{% include code-snippet/pivot-table/summary-customization/sub-total-specific/SubTotalSpecific.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/sub-total-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SubTotalSpecific.cs" %}
{% include code-snippet/pivot-table/summary-customization/sub-total-specific/SubTotalSpecific.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Sub-totals for specific fields](images/subtotal2.png)

## Show sub-totals at top or bottom

You can configure the position of sub-totals within header groups for both rows and columns in the Pivot Table using the [`subTotalsPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.SubTotalsPosition.html) property in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) object. The available values are **Top**, **Bottom**, and **Auto** (the default). With **Auto**, column sub-totals appear at the bottom and row sub-totals appear at the top of their respective header groups.

To display sub-totals at the top of header groups for both rows and columns, set the [`subTotalsPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.SubTotalsPosition.html) property in [`showGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals) to **Top**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-top/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-top/subtotal-top.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-top/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-top/subtotal-top.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Subtotals top position](images/subTotalsPosition-Top.png)

To display sub-totals at the bottom of header groups for both rows and columns, set the [`subTotalsPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.SubTotalsPosition.html) property in [`showGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals) to **Bottom**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-bottom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-bottom/subtotal-bottom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-bottom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GrandTotal.cs" %}
{% include code-snippet/pivot-table/summary-customization/subtotal-bottom/subtotal-bottom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Subtotals bottom position](images/subTotalsPosition-Bottom.png)

## Show or hide totals using toolbar

You can show or hide grand totals and sub-totals in the Pivot Table using the built-in toolbar. To enable the toolbar, set the [`showToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) property to **true** in the Pivot Table component. Then, include **GrandTotal** and **SubTotal** in the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property. This displays "Show/Hide Grand Totals" and "Show/Hide Subtotals" icons in the toolbar, allowing users to quickly manage grand totals and sub-totals in the table.

The toolbar also includes options for "Grand Totals Position" and "Subtotals Position." These options allow users to specify whether grand totals and sub-totals appear at the top or bottom of rows and columns. This flexibility helps users position grand totals and sub-totals to best suit their reporting or data analysis needs.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar.cs" %}
{% include code-snippet/pivot-table/summary-customization/toolbar/Toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toolbar.cs" %}
{% include code-snippet/pivot-table/summary-customization/toolbar/Toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Grand Totals](images/toolbar-grandtotals.png)

![Sub Totals](images/toolbar-subtotals.png)