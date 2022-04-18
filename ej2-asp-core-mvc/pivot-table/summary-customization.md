---
layout: post
title: Summary Customization in ##Platform_Name## PivotTable Component
description: Learn here all about Load Balancing Environment in Syncfusion ##Platform_Name## PivotTable component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Summary Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show or hide totals

## Show or hide grand totals

Allows to show or hide grand totals in rows and columns using the [`ShowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals) property. To hide the grand totals in rows and columns, set the property [`ShowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals) in [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class to **false**.
End user can also hide grand totals for row or columns separately by setting the property [`ShowRowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowGrandTotals) or [`ShowColumnGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnGrandTotals) in [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class to **false** respectively.

> By default, [`ShowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowGrandTotals), [`ShowRowGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowGrandTotals) and [`ShowColumnGrandTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnGrandTotals) properties in [`PivotViewDataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class are set as **true**.

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

![output](images/grandtotal.png)

## Show or hide sub-totals

Allows to show or hide sub-totals in rows and columns using the [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowSubTotals) property. To hide all the sub-totals in rows and columns, set the property [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowSubTotals) in [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class to **false**. End user can also hide sub-totals for rows or columns separately by setting the property [`ShowRowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowSubTotals) or [`ShowColumnSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnSubTotals) in [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class to **false** respectively.

> By default, [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowSubTotals), [`ShowRowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowRowSubTotals) and [`ShowColumnSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettings_ShowColumnSubTotals) in [`DataSourceSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html) class are set as **true**.

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

![output](images/sub-total.png)

## Show or hide sub-totals for specific fields

Allows to show or hide sub-totals for specific fields in rows and columns using the [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSubTotals)) property. To hide sub-totals for a specific field in row or column axis, set the property [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSubTotals) property in [`Row`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [`Column`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) class to **false** respectively.

> By default, [`ShowSubTotals`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html#Syncfusion_EJ2_PivotView_PivotViewRow_ShowSubTotals) property in [`Row`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewRow.html) or [`Column`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.ColumnsDataSourceSettings.html) class is set as **true**.

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

![output](images/subtotal2.png)

## Show or hide totals using toolbar

It can also be achieved using built-in toolbar options by setting the [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**. Also, include the items **GrandTotal** and **SubTotal** within the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class. End user can now see "Show/Hide Grand totals" and "Show/Hide Sub totals" icons in toolbar UI automatically.

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

![output](images/grand_toolbar.png)
<br/>
![output](images/sub_toolbar.png)

Additionally, with the built-in option available in the grand totals drop-down menu, the grand totals can be dynamically displayed at the top or bottom of the pivot table's row and column axes. By default, the grand totals are displayed at the bottom of the pivot table's row and column axes.

![output](images/grandtotals-position.png)
