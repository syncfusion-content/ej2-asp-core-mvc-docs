---
layout: post
title: Paging in ##Platform_Name## Pivot Table Component
description: Learn here all about Paging in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Paging

Paging allows you to load large amounts of data that can be divided and displayed page by page in the pivot table. It can be enabled by setting the [`EnablePaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnablePaging) property to **true**. It can be configured at code-behind by using the [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PageSettings) property, during initial rendering of the component. The properties required are:

* [`CurrentRowPage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentRowPage): Allows user to set the current row page number to be displayed in the pivot table.
* [`CurrentColumnPage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentColumnPage): Allows user to set the current column page number to be displayed in the pivot table.
* [`RowPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_RowPageSize): Allows user to set the total number of records to be displayed on each page of the pivot table's row axis.
* [`ColumnPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_ColumnPageSize): Allows user to set the total number of records to be displayed on each page of the pivot table's column axis.

## Pager UI

When paging is enabled, a built-in pager UI appears at the bottom of the pivot table, allowing you to change the current page in the row and column axes by navigating to a desired page using the navigation buttons or an input text box, as well as change the page size via dropdown at runtime.

You can also change the position, visibility, compact view, and template of the row and column pagers by using the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings).

> In order to see and use the pager UI, insert the `Pager` module into the pivot table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/default/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/default/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/Paging_UI.png)

### Show pager UI at top or bottom

You can display the pager UI at top or bottom of the pivot table by using the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Position) property. To show the pager UI at top of the pivot table, set the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Position) property in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) to **Top**.

> By default, the pager UI appears at the bottom of the pivot table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/position/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/position/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerPosition.png)

### Inverse pager

Toggles and displays row and column pager. To show the column pager on the left side of the pager UI, set the [`IsInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_IsInversed) property in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) to **true**.

> By default, the row pager is displayed on the left side of the pager UI, while the column pager is displayed on the right side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/inverse-pager/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/inverse-pager/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/inverse-pager/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/inverse-pager/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerInverse.png)

### Compact view

By hiding all except the previous and next navigation buttons, the pager UI can be displayed with the absolute minimum of paging options. The compact view can be enabled by setting the [`EnableCompactView`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_EnableCompactView) property in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/compact-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/compact-view/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/compact-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/compact-view/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerCompactView.png)

### Show or hide paging option

By using the [`ShowRowPager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPager) and [`ShowColumnPager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowColumnPager) properties in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings), you can show or hide row and column pager separately in the pager UI.

In the following example, row pager has been disabled by setting the [`ShowRowPager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPager) property in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) to **false**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/show-hide-pager/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/show-hide-pager/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/show-hide-pager/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/show-hide-pager/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerHide.png)

### Show or hide page size

By using the [`ShowRowPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPageSize) and [`ShowColumnPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowColumnPageSize) properties in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings), you can show or hide "Rows per page" and "Columns per page" dropdown menu. The dropdown menu contains a list of pre-defined or user-defined page sizes, which will be displayed in the "Rows per page" and "Columns per page" dropdowns, allowing you to change the page size for the row and column axes at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/show-hide-page-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/show-hide-page-size/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/show-hide-page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/show-hide-page-size/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerSizeHide.png)

### Customize page size

By using the [`RowPageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_RowPageSizes) and [`ColumnPageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ColumnPageSizes) properties in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings), you can specify a set of desired page sizes, which will be displayed in the "Rows per page" and "Columns per page" dropdowns, allowing you to change the page size for the row and column axes at runtime.

> By default, the "Rows per page" dropdown have pre-defined page sizes of **10, 50, 100, and 200**, while the "Columns per page" dropdown have pre-defined page sizes of **5, 10, 20, 50, and 100**.

In the following example, the "Rows per page" dropdown is set with user-defined page sizes of **10, 20, 30, 40, and 50** and the "Columns per page" dropdown is set with user-defined page sizes of **5, 10, 15, 20, and 30**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/page-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/page-size/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/page-size/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerSize.png)

### Template

The [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property allows to change the appearance of the pager UI by displaying user-defined HTML elements instead of built-in HTML elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/template/Paging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/paging/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paging.cs" %}
{% include code-snippet/pivot-table/paging/template/Paging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![output](images/PagerTemplate.png)