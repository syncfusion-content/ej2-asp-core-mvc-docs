---
layout: post
title: ##Platform_Name## Grid Excel Like Filter | Syncfusion
description: Learn how to use Excel Like Filter in ##Platform_Name## Data Grid with multi-condition filtering, checkbox lists, search, remote binding, and template.
platform: ej2-asp-core-mvc
control: Excel Like Filter
publishingplatform: ##Platform_Name##
documentation: ug
---

# Excel Like Filter in ASP.NET Core Data Grid

The Data Grid component offers an Excel-like filter feature that provides a familiar, Excel-style interface for filtering data within the grid. Excel-like filter displays a dialog with a checkbox list, search box, and sorting options, similar to Microsoft Excel's filter. This filtering type simplifies complex filtering operations on specific columns, allowing for quick data location and manipulation. Excel-like filtering is especially useful when dealing with large datasets and columns containing distinct categorical values (such as status, category, country, or department names).

The dialog displays all unique values from that column as a checkbox list. Values can be selected or deselected to include or exclude them from the grid results, and the "OK" button can be clicked to apply the filter.

## Enable Excel filtering

To enable the Excel-like filtering, set the [filterSettings.type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) property to `Excel`. This property determines the type of filter UI rendered in the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excel-filter.gif)

> * The Excel-like filter feature supports various filter conditions, including text-based, number-based, date-based, and boolean-based filters.
> * The filter dialog provides additional options, such as sorting filter values, searching for specific values, and clearing applied filters.

## Enable CheckBox filtering

Checkbox filtering is the core mechanism of Excel-like filter. When the filter dialog opens, all unique values from the selected column appear as a checkbox list. Multiple values can be selected by checking their boxes to include them in the filtered results. Values can be unchecked to exclude them from the results.

The checkbox list supports search functionality: typing in the search box filters the checkbox list to show only matching values, making it easier to find specific items in long lists.

The following example illustrates checkbox filtering in the Data Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-checkbox/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excel-filter-checbox.gif)

## Add current selection to filter Checkbox/Excel

By default, the `Excel/CheckBox` filter in the Data Grid applies filtering based solely on currently selected items. When multiple filtering actions are performed sequentially on the same column, previously filtered values are cleared and replaced with the new selection.

The `Add current selection to filter` checkbox functionality enables retention of previous filter values while performing new searches. This checkbox appears when searching data in the Excel/CheckBox filter search bar and allows new selections to be included without removing previously applied filters. This cumulative filtering approach provides greater flexibility for complex filtering scenarios.

The following image illustrates the `Add current selection to filter` functionality:

![Add current selection to filter option.](../images/checkboxfilter.png)

## Filter modes
 
The Data Grid `Excel` and `CheckBox` filtering features support two modes, `Default` and `Immediate`. In `Default` mode, filter changes are applied only after clicking the "Filter" or "OK" button in the filter dialog, which is the default behavior. In `Immediate` mode, filters are applied automatically when filter items are checked or unchecked in the filter dialog.
 
The following example enables immediate mode by setting the `filterSettings.mode` property to `Immediate`:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-checkbox1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-checkbox1/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

## Customize the filter choice count

By default, the filter choice count is set to "1000", which means the filter dialog displays a maximum of "1000" distinct values for each column as a checkbox list. This default value ensures the filter operation remains efficient, even with large datasets. Remaining records (those beyond the first "1000") are accessible through the search box within the filter dialog.

**Why this limit exists**: Loading all distinct values from a column with tens of thousands of unique entries would cause the filter dialog to open slowly or freeze. The "1000" value limit prevents this performance issue while still providing access to all data via search.

The Data Grid component allows customization of the number of distinct values displayed in the checkbox list of the Excel/CheckBox filter dialog. The filter choice count can be adjusted by modifying the `FilterChoiceCount` value. The count can be increased to display more initial options, or decreased to improve dialog opening speed for extremely large datasets.

The following example demonstrates how to customize the filter choice count in the checkbox list of the filter dialog. In the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event, the code checks if the `requestType` is either `filterChoiceRequest` or `filterSearchBegin`, and then sets the `filterChoiceCount` property to the desired value.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-choice-count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-choice-count/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excelfilter-count.gif)

> The filter choice count determines the number of unique items displayed in the checkbox list of the `Excel/CheckBox` filter dialog. Higher values may result in rendering delays when opening the filter dialog. Setting a reasonable filter choice count is recommended for optimal performance.

## Customize checkbox list items using templates

The Data Grid component provides flexibility to customize the items displayed in the `Excel/CheckBox` filter options. Text customization is achieved by defining a `filterItemTemplate` and binding it to the target column. The `filterItemTemplate` property enables creation of custom templates for filter items, supporting text, icons, or any HTML elements within the template to display the desired content.

### Customize checkbox list text

This customization enables modification of default text to provide more meaningful and contextual labels for filtering values.

In the following example, the text displayed in the filter checkbox list for the "Delivered" column is customized. This is accomplished by defining a `filterItemTemplate` within the column definition for that specific column. Within the template, ASP.Net MVC's template syntax conditionally displays "Delivered" if the data value is `true` and "Not delivered" if the value is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-show-customized-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-show-customized-text/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excel-filter-template-customized-list.gif)

### Customize checkbox list items with icons

The following example demonstrates usage of `filterItemTemplate` to render custom UI or additional information—such as icons, text, or any HTML elements—alongside the default filter items in the filter checkbox list for a specific column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-show-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-show-template/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excelfilter-show-template.gif)

## Customize the excel filter dialog using CSS

The Data Grid provides flexibility for enhancing the visual presentation of the Excel filter dialog through CSS customization. This capability allows modification of the dialog's appearance to align with specific application requirements and aesthetic preferences.

**Removing context menu option**

The Excel filter dialog includes several features such as `context menu`, `search box`, and `checkbox list` that may not be required in certain scenarios. These options can be selectively removed using CSS targeting through the `className` attribute in the Data Grid component.

To remove the context menu option from the Excel filter dialog, apply the following CSS rule:

```css
.e-grid .e-excelfilter .e-contextmenu-wrapper 
{
    display: none;
}
```

The following example demonstrates context menu removal in the Excel filter dialog using the above CSS customization:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-customize-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-customize-dialog/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excelfilter-customize-dialog.gif)


## Hide sorting options in the filter dialog

The Excel-like filter dialog in the grid includes built-in sorting options (ascending and descending) by default within the context menu. To hide these sorting options, the `display` property of the following CSS classes can be set to `none`.

```css
.e-excel-ascending,
.e-excel-descending,
.e-separator.e-excel-separator {
 display: none;
}
```

The following example demonstrates hiding sorting options in the Excel filter dialog.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-hide-sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-hide-sorting/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excelfilter-hide-sorting.gif)

## Bind custom remote data source for Excel/CheckBox filtering

The Data Grid allows dynamic change of the filter data source for the Excel/CheckBox filter module using custom remote data. This capability enables the filter dialog to display values from a different data source than the Data Grid's main data source.

This can be accomplished by assigning a custom remote `DataManager` as the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) or by fetching the data initially and storing it in a global variable. This data can then be bound directly to the filter module's `dataSource` in the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event for the `filterBeforeOpen` `requestType`, as detailed in the [knowledge base](https://support.syncfusion.com/kb/article/10065/how-to-change-the-data-source-for-checkbox-filter-popup-in-grid).

The following example demonstrates dynamically changing the remote custom data source for all columns in the Excel/CheckBox filter dialog using a `DataManager` with `WebApiAdaptor`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-custom-datasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-custom-datasource/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/custom-binding.png)

## Enable on-demand loading for the Excel/CheckBox filter

The `Excel/CheckBox` filter types display only the first "1000" sorted unique values in the filter dialog to ensure responsive loading. Rendering all unique values (for example, "50,000" distinct entries) can significantly delay or freeze the dialog when it opens. Searching and filtering continue to consider all unique values in the column.

To improve the filtering experience for large datasets, enable on-demand loading by setting the [filterSettings.enableInfiniteScrolling](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_EnableInfiniteScrolling) property to `true`. This loads additional filter values as scroll through the checkbox list, improving performance while preserving the applied filter selection.

**On-Demand loading in the filter dialog**: Similar to infinite scrolling in social media feeds, the filter dialog loads the next batch of values automatically as the scroll position reaches the bottom of the current list. This process repeats until all unique values have been loaded or the search box is used to narrow results.

The `Excel/CheckBox` filter retrieves distinct data in ascending order, governed by the [filterSettings.itemsCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ItemsCount) property with a default value of "50". As the checkbox list data scroller reaches its end, the next dataset is fetched and displayed. This process only requests new checkbox list data without redundantly fetching existing loaded datasets.

### Customize the items count for initial rendering

Based on the items count value, the `Excel/CheckBox` filter retrieves unique data and displays it in the `Excel/CheckBox` filter content dialog. The count of on-demand data rendering for the Excel/CheckBox filter can be customized by adjusting the [filterSettings.itemsCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ItemsCount) property. The default value is `50`

```ts
<e-grid-filterSettings type="Excel" enableInfiniteScrolling="true" itemsCount="40"></e-grid-filterSettings>
```

> Keep the itemsCount value below "300". Higher values may result in unwanted whitespace due to DOM maintenance performance degradation.

### Customize the loading animation effect

A loading effect indicates that data loading is in progress when the checkbox list data scroller reaches the end and there is a delay in receiving the data response from the server. The loading effect during on-demand data retrieval for the Excel/CheckBox filter can be customized using the [filterSettings.loadingIndicator](Syncfusion_EJ2_Grids_GridFilterSettings_LoadingIndicator) property. The default value is `Shimmer`.

**Example configuration**:

```ts
<e-grid-filterSettings type="Excel" enableInfiniteScrolling="true" loadingIndicator="Spinner"></e-grid-filterSettings>
```

The following example demonstrates on-demand loading for the Excel filter in the Data Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter-animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter-animation/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/excelfilter-animation.gif)

## See also

* [How to perform filter by using Wildcard and LIKE operator filter](./filtering#wildcard-and-like-filters)
