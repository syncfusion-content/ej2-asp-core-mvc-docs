---
layout: post
title: Paging in ASP.NET Core Pivot Table | Syncfusion
description: Learn how the ASP.NET Core Pivot Table paginates rows and columns using pageSettings to navigate large datasets efficiently.
control: Pivot Table
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

<!-- markdownlint-disable MD036 -->

# Paging in ASP.NET Core Pivot Table

Paging divides the Pivot Table data into manageable pages so the component can render large datasets efficiently. The row axis (members of the row fields) and the column axis (members of the column and value fields) are paginated independently. Users navigate rows and columns page by page using the built-in pager UI or custom controls.

To enable paging, set the [`EnablePaging`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnablePaging) property to **true** (type `boolean`, default `false`).

Paging can be configured at initial render using the [`e-pageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PageSettings) property, which accepts the following options:

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| [`CurrentRowPage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentRowPage) | `double` | `1` | The current row page number to display. |
| [`CurrentColumnPage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentColumnPage) | `double` | `1` | The current column page number to display. |
| [`RowPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_RowPageSize) | `double` | `10` | The number of records displayed on each page of the row axis. |
| [`ColumnPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_ColumnPageSize) | `double` | `5` | The number of records displayed on each page of the column axis. |

N> The [Virtualization](./virtual-scrolling) and Paging features in the Pivot Table should not be enabled simultaneously. You can use either feature at a time, but not both together, as they are designed to handle data rendering differently and may conflict when used together.

## Pager UI

When paging is enabled, a built-in pager UI appears at the bottom of the Pivot Table by default. The UI provides navigation buttons, a page-input box, and dropdowns for changing the page size on each axis.

You can change the position, visibility, compact view, and template of the row and column pagers using the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) property. The available sub-properties are summarized below:

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `Position` | [`PagerPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Position) | `Bottom` | Places the pager UI at the `Top` or `Bottom` of the Pivot Table. |
| `IsInversed` | `boolean` | `false` | When `true`, swaps the column pager to the left and the row pager to the right. |
| `EnableCompactView` | `boolean` | `false` | When `true`, shows only the previous and next navigation buttons. |
| `ShowRowPager` | `boolean` | `true` | Shows or hides the row pager. |
| `ShowColumnPager` | `boolean` | `true` | Shows or hides the column pager. |
| `ShowRowPageSize` | `boolean` | `true` | Shows or hides the "Rows per page" dropdown. |
| `ShowColumnPageSize` | `boolean` | `true` | Shows or hides the "Columns per page" dropdown. |
| `RowPageSizes` | `double[]` | `null` | The list of page sizes offered in the "Rows per page" dropdown. |
| `ColumnPageSizes` | `double[]` | `null` | The list of page sizes offered in the "Columns per page" dropdown. |
| `Template` | `string` | `null` | The ID of an HTML element that replaces the built-in pager UI. |

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

The Pivot Table component lets you place the pager UI at the top or bottom of the Pivot Table by setting the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Position) property within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default the pager UI appears at the bottom; set `Position` to `'Top'` to place it above the Pivot Table.

The following example demonstrates how to configure the pager UI to appear at the top of the Pivot Table:

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

By default, the row pager appears on the left side of the pager UI and the column pager on the right. To swap these positions, set the [`IsInversed`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_IsInversed) property to **true** within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration.

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

The Pivot Table provides a compact view for the pager UI, displaying only the previous and next navigation buttons to minimize the interface. To enable the compact view, set the [`EnableCompactView`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_EnableCompactView) property to **true** within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. This streamlined layout focuses on essential navigation controls, which is ideal for layouts requiring a simplified paging experience.

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

The Pivot Table allows you to control the visibility of the row and column pagers in the pager UI using the [`ShowRowPager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPager) and [`ShowColumnPager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowColumnPager) properties within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, both row and column pagers are visible in the pager UI. To hide either the row pager or the column pager, set the corresponding property to **false**. This allows you to display only the necessary navigation controls based on your layout requirements.

The following code demonstrates how to hide the row pager by setting the [`ShowRowPager`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPager) property to **false**:

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

The Pivot Table allows you to control the visibility of the "Rows per page" and "Columns per page" dropdowns in the pager UI using the [`ShowRowPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowRowPageSize) and [`ShowColumnPageSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ShowColumnPageSize) properties within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. These dropdowns display a list of predefined or user-defined page sizes, enabling you to adjust the number of rows or columns displayed per page at runtime. By default, both dropdowns are visible in the pager UI. To hide either the "Rows per page" or "Columns per page" dropdown, set the corresponding property to **false**.

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

The Pivot Table allows you to specify a list of page sizes for the "Rows per page" and "Columns per page" dropdowns in the pager UI using the [`RowPageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_RowPageSizes) and [`ColumnPageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ColumnPageSizes) properties within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, the "Rows per page" dropdown includes page sizes of 10, 50, 100, and 200, while the "Columns per page" dropdown includes page sizes of 5, 10, 20, 50, and 100. To define a different set of page sizes, assign an array of numbers to the [`RowPageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_RowPageSizes) or [`ColumnPageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_ColumnPageSizes) properties.

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

The Pivot Table allows you to define a custom layout for the pager UI using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property within the [`e-pagerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PagerSettings) configuration. By default, the pager UI displays built-in navigation controls. To replace these with custom HTML elements, assign the ID of the custom elements to the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property. This enables you to create a unique pager interface that aligns with your application’s design requirements.

The following example shows how to create a custom template for both row and column pagers. The HTML element IDs are assigned to the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPagerSettings.html#Syncfusion_EJ2_PivotView_PivotViewPagerSettings_Template) property. Then, during the [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_DataBound) event, the Syncfusion `Pager` control is appended to the designated HTML elements. You can configure the pager by setting properties like `PageSize`, `TotalRecordsCount`, and `CurrentPage`. When you click on a custom row or column pager, the [`CurrentRowPage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentRowPage) and [`CurrentColumnPage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPageSettings.html#Syncfusion_EJ2_PivotView_PivotViewPageSettings_CurrentColumnPage) properties in [`e-pageSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_PageSettings) are updated, enabling navigation with the custom pager.

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

## See also

* [Virtual Scrolling](./virtual-scrolling)
* [Getting Started](./getting-started)