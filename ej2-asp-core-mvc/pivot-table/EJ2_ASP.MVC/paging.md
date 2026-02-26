---
layout: post
title: Paging in ##Platform_Name## Syncfusion Pivot Table Component
description: Learn here all about Paging in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paging
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Paging in ##Platform_Name## Pivot Table Component

The paging feature in the Pivot Table component is designed to handle large datasets efficiently by dividing the data into manageable pages. This prevents performance issues associated with rendering large amounts of data at once, allowing users to navigate through rows and columns page by page.

To enable paging, set the [`EnablePaging`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnablePaging) property to **true**. Paging can be configured in the code-behind during the initial rendering of the component using the [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html) property. This allows you to define the initial page setup for rows and columns. The key properties within [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html) include:

* [`CurrentRowPage`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentRowPage): Allows user to set the current row page number to be displayed in the pivot table.
* [`CurrentColumnPage`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentColumnPage): Allows user to set the current column page number to be displayed in the pivot table.
* [`RowPageSize`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_RowPageSize): Allows user to set the total number of records to be displayed on each page of the pivot table's row axis.
* [`ColumnPageSize`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_ColumnPageSize): Allows user to set the total number of records to be displayed on each page of the pivot table's column axis.

N> The [Virtualization](./virtual-scrolling) and Paging features in the Pivot Table should not be enabled simultaneously. You can use either feature at a time, but not both together, as they are designed to handle data rendering differently and may conflict when used together.

## Pager UI

When paging is enabled, a built-in pager UI appears at the bottom of the Pivot Table by default. This user-friendly interface enables seamless navigation across row and column axis pages using navigation buttons or an input box, and allows dynamic page size adjustments via dropdown menus.

You can also change the position, visibility, compact view, and template of the row and column pagers by using the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings).

> In order to see and use the pager UI, insert the `Pager` module into the pivot table using the `services` tag.

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

![Normal mode of Pager UI](images/Paging_UI.png)

### Show pager UI at top or bottom

The Pivot Table component allows you to configure the placement of the pager UI to match your layout preferences. You can display the pager UI either at the top or bottom of the pivot table by setting the [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Position) property within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, the pager UI appears at the bottom, but setting the position property to **Top** places it above the pivot table. This can be ideal for layouts where navigation controls are preferred at the top for better visibility or alignment with other UI elements.

The following code demonstrates how to configure the pager UI to appear at the top of the pivot table:

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

![Pager UI at Top position](images/PagerPosition.png)

### Inverse pager

The Pivot Table allows you to toggle the positions of the row and column pagers in the pager UI. By default, the row pager appears on the left side of the pager UI, and the column pager appears on the right. To swap these positions—displaying the column pager on the left and the row pager on the right—set the [`IsInversed`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_IsInversed) property to **true** within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration.

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

![Inverse pager UI](images/PagerInverse.png)

### Compact view

The Pivot Table provides a compact view for the pager UI, displaying only the previous and next navigation buttons to minimize the interface. To enable the compact view, set the [`EnableCompactView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_EnableCompactView) property to **true** within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. This streamlined layout focuses on essential navigation controls, ideal for layouts requiring a simplified paging experience.

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

![Compact view of pager UI](images/PagerCompactView.png)

### Show or hide paging option

The Pivot Table allows you to control the visibility of the row and column pagers in the pager UI using the [`ShowRowPager`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPager) and [`ShowColumnPager`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowColumnPager) properties within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, both row and column pagers are visible in the pager UI. To hide either the row pager or the column pager, set the corresponding property to **false**. This allows you to display only the necessary navigation controls based on your layout requirements.

The following code demonstrates how to hide the row pager by setting the [`ShowRowPager`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPager) property in [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) to **false**.


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

![Hided Row paging option](images/PagerHide.png)

### Show or hide page size

The Pivot Table allows you to control the visibility of the "Rows per page" and "Columns per page" dropdowns in the pager UI using the [`ShowRowPageSize`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPageSize) and [`ShowColumnPageSize`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowColumnPageSize) properties within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. These dropdowns display a list of predefined or user-defined page sizes, enabling you to adjust the number of rows or columns displayed per page at runtime. By default, both dropdowns are visible in the pager UI. To hide either the "Rows per page" or "Columns per page" dropdown, set the corresponding property to **false**.

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

![Hided Row and Column Page sizes](images/PagerSizeHide.png)

### Customize page size

The Pivot Table allows you to specify a list of page sizes for the "Rows per page" and "Columns per page" dropdowns in the pager UI using the [`RowPageSizes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_RowPageSizes) and [`ColumnPageSizes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ColumnPageSizes) properties within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, the "Rows per page" dropdown includes page sizes of 10, 50, 100, and 200, while the "Columns per page" dropdown includes page sizes of 5, 10, 20, 50, and 100. To define a different set of page sizes, assign an array of numbers to the [`RowPageSizes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_RowPageSizes) or [`ColumnPageSizes`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ColumnPageSizes) properties.

The following example sets the "Rows per page" dropdown with page sizes of 10, 20, 30, 40, and 50, and the "Columns per page" dropdown with page sizes of 5, 10, 15, 20, and 30:

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

![Customizing page size](images/PagerSize.png)

### Template

The Pivot Table allows you to define a custom layout for the pager UI using the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property within the [`PagerSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, the pager UI displays built-in navigation controls. To replace these with custom HTML elements, assign the ID of the custom elements to the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property. This enables you to create a unique pager interface that aligns with your application’s design requirements.

This following example shows how to create a custom template for both row and column pagers. The HTML code is embedded within the JSX or TSX file and assigned to the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property. Then, during the [`DataBound`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event, the Syncfusion `Pager` control is appended to the designated HTML elements. You can configure the pager by setting properties like `pageSize`, `totalRecordsCount`, and `currentPage`. When you click on a custom row or column pager, the [`CurrentRowPage`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentRowPage) and [`CurrentColumnPage`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentColumnPage) properties in [`PageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html) are updated, enabling navigation with the custom pager.

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

![Pager UI customized by Template property](images/PagerTemplate.png)