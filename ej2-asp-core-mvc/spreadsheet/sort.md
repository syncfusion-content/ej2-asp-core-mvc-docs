---
layout: post
title: Sort in ##Platform_Name## Spreadsheet Component
description: Learn here all about Sort in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Sort
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sorting

Sorting helps arranging the data to a specific order in a selected range of cells. You can use the [`allowSorting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowSorting) property to enable or disable sorting functionality.

> * The default value for `allowSorting` property is `true`.

By default, the `sort` module is injected internally into Spreadsheet to perform sorting.

## Sort by cell value

In the active Spreadsheet, select a range of cells to sort by cell value. The range sort can be done by any of the following ways:
* Select the sort item in the Ribbon toolbar and choose the ascending or descending item.
* Right-click the sheet, select the sort item in the context menu and choose the ascending/descending item.
* Use the `sort()` method programmatically.

The cell values can be sorted in the following orders:
* Ascending
* Descending

> * Ascending is the default order for sorting.

The `sort()` method with empty arguments will sort the selected range by active cell’s column as sort column in ascending order.

> * The `beforeSort` event will be triggered before sorting the specified range.
> * The `sortComplete` event will be triggered after the sort action is completed successfully.

The following code example shows `sort` functionality in the Spreadsheet control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/sort-by-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SortController.cs" %}
{% include code-snippet/spreadsheet/sort-by-cell/sortController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/sort-by-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SortController.cs" %}
{% include code-snippet/spreadsheet/sort-by-cell/sortController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data contains header

You can specify whether the selected range of cells contains header. To specify, you need to set the `containsHeader` property to `true` and pass it as `sortOption` arguments of the sort() method.

> * If the `containsHeader` property is not set and active cell column’s first cell value type is differed from the second cell value type, the first row data in the range are marked as column headers.

You can also enable or disable this property using `beforeSort` event arguments,

```javascript

   function beforeSort(args) {
        args.sortOptions.containsHeader = true;
    }
```

In the custom sort dialog, the `Data contains header` checkbox is checked on load. Thus, the default value for `containsHeader` is `true` in custom sort dialog.

## Case sensitive sort

The default sort functionality of Spreadsheet is a case insensitive sorting. When you want to perform sorting with case sensitive, you need to set the `caseSensitive` property to `true` and pass it as `sortOption` arguments of the sort() method.

Case sensitive sorting is applicable only for cells with alphabets. In ascending order sorting with case sensitive enabled, the cells with lower case text will be placed above the cells with upper case text.

> * The default value for the `caseSensitive` property is `false`.

You can also enable or disable this property using `beforeSort` event arguments,

```javascript

    function beforeSort (args) {
        args.sortOptions.caseSensitive = true;
    }

```

In the custom sort dialog, the `Case sensitive` checkbox is unchecked on load as the default value is `false`.

## Sort multiple columns

When you want to perform sorting on multiple columns, it can be done by any of the following ways:
* Select the `Custom sort…` menu item from the Ribbon toolbar item or context menu item.
* Use the `sort()` method programmatically by providing sort criteria.

> * The current sorting functionality supports sorting based on cell values only.

### Custom sort dialog

The custom sort dialog helps sorting multiple columns in the selected range by utilizing the rich UI. This dialog will be appeared while choosing the `Custom sort…` from the Ribbon item or context menu item. By default, sort criteria with the first column name from the selected range will be appeared in the dialog on initial load and it cannot be removed.

You can add multiple criteria using the `Add Column` button at the bottom of the dialog. Thus, multiple columns can be specified with different sort order. The newly added sort criteria items can be removed using the `delete` icons at the end of each items.

You can refer to the [`Data contains header`](./sort/#data-contains-header) topic to learn more about `Data contains header` checkbox. To learn more about `Case sensitive` checkbox, you can refer to [`Case sensitive sort`](./sort/#case-sensitive-sort) topic.

### Passing sort criteria manually

The multi-column sorting can also be performed manually by passing sort options to the `sort()` method programmatically. The `sortOption` have the following arguments:
* `sortDescriptors` – Sort criteria collection that holds the collection of field name, sort order, and `sortComparer`.
* `containsHeader` – Boolean argument that specifies whether the range has headers in it.
* `caseSensitive` – Boolean argument that specifies whether the range needs to consider case.

> * All the arguments are optional.
> * When a `sortDescriptor` is specified without field, the field of the first `sortDescriptor` from the collection will be assigned from active cell’s column name and others will be ignored. Hence, it will act as single column sorting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/passing-sort/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PassingSortController.cs" %}
{% include code-snippet/spreadsheet/passing-sort/passingSortController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/passing-sort/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PassingSortController.cs" %}
{% include code-snippet/spreadsheet/passing-sort/passingSortController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom sort comparer

The [`sortDescriptor`](../api/spreadsheet/#sortdescriptor) holds the [`sortComparer`](../api/spreadsheet/#sortcomparer) property, which is a function and it is used to customize the sort comparer for specific sort criteria. Each `sortDescriptor` can be customized using the custom sort comparer function.

By customizing sort comparer, you can define the sort action as desired.

> * The `sortComparer` is an optional property of `sortDescriptor`.

For custom sort comparer example, refer to the [`Sort a range by custom list`](./how-to/sort-a-range-by-custom-list) in the `how-to` section.

## Known error validations

The following errors have been handled for sorting,
* *Out of range validation:* When the selected range is not a used range of the active sheet, it is considered as invalid and the out of range alert with the message `Select a cell or range inside the used range and try again` will be displayed. No sort will be performed if the range is invalid.

* *Empty field validation:* When the sort criteria does not have a column selected (empty) in the custom sort dialog, it will become invalid, and an error message `Sort criteria column should not be empty` will be displayed on `OK` button click.

* *Duplicate field validation:* When the column names of added sort criteria are repeated more than once in the custom sort dialog, it will become invalid and an error message `<Column name> is mentioned more than once. Duplicate columns must be removed` will be displayed on `OK` button click.

## Limitations

* Sorting is not supported with formula contained cells.

## See Also

* [Sort a range by custom list](./how-to/sort-a-range-by-custom-list.md)
* [Hyperlink](./link)
* [Filtering](./filter)
* [Undo Redo](./undo-redo)
