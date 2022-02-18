---
layout: post
title: Columns Mvc in ##Platform_Name## Tree Grid Component
description: Learn here all about Columns Mvc in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Columns Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Columns

The column definitions are used as the [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html) schema in the TreeGrid. This plays a vital role in rendering column values in the required format.
The treegrid operations such as sorting, filtering and searching etc. are performed based on column definitions. The [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property of the [`Columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~Columns.html)
is necessary to map the data source values in TreeGrid Columns.

> 1. If the column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the dataSource, the column values will be empty.
> 2. If the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) name contains “dot” operator, it is considered as complex binding.

[`TreeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridBuilder~TreeColumnIndex.html) property denotes the column that is used to expand and collapse child rows.

## Header Template

You can customize the header element by using the [`HeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderTemplate.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header text

By default, column header title is displayed from column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) value. To override the default header title, you have to define the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If both the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) and [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html)
are not defined in the column, the column renders with “empty” header text.

## Format

To format cell values based on specific culture, use the [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html). The TreeGrid uses [Internalization](../../common/internationalization/) library to format [`number`](../../common/internationalization/#number-formatting) and [`date`](../../common/internationalization/#manipulating-datetime)
values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/tree-grid/columns-mvc/formatting/formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/tree-grid/columns-mvc/formatting/formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, the [`number`](../../common/internationalization/#number-formatting) and [`date`](../../common/internationalization/#manipulating-datetime) values are formatted in `en-US` locale.

### Number formatting

The number or integer values can be formatted using the below format strings.

Format |Description |Remarks
-----|-----
N | Denotes numeric type. | The numeric format is followed by integer value as N2, N3. etc which denotes the number of precision to be allowed.
C | Denotes currency type. | The currency format is followed by integer value as C2, C3. etc which denotes the number of precision to be allowed.
P | Denotes percentage type | The percentage format expects the input value to be in the range of 0 to 100. For example the cell value `0.2` is formatted as `20%`. The percentage format is followed by integer value as P2, P3. etc which denotes the number of precision to be allowed.

Please refer to the link to know more about [`Number formatting`](../../common/internationalization/#number-formatting).

### Date formatting

You can format date values either using built-in date format string or custom format string.

For built-in date format you can specify [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property as string   (Example: `yMd`). Please refer to the link to know more about [`Date formatting`](../../common/internationalization/#manipulating-datetime).

You can also use custom format string to format the date values. Some of the custom formats and the formatted date values are given in the below table.

Format | Formatted value
-----|-----
{ type:'date', format:'dd/MM/yyyy' } | 04/07/1996
{ type:'date', format:'dd.MM.yyyy' } | 04.07.1996
{ type:'date', skeleton:'short' } | 7/4/96
{ type: 'dateTime', format: 'dd/MM/yyyy hh:mm a' } | 04/07/1996 12:00 AM
{ type: 'dateTime', format: 'MM/dd/yyyy hh:mm:ss a' } | 07/04/1996 12:00:00 AM

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Dateformatting.cs" %}
{% include code-snippet/tree-grid/columns-mvc/dateformatting/dateformatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/dateformatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dateformatting.cs" %}
{% include code-snippet/tree-grid/columns-mvc/dateformatting/dateformatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## AutoFit specific columns

The [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method resizes the column to fit the widest cell's content without wrapping. You can autofit a specific column at initial rendering by invoking the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method in [`DataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataBound.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-mvc/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/autofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/tree-grid/columns-mvc/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can autofit all the columns by invoking the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method without column names.

## Reorder

Reordering can be done by drag and drop of a particular column header from one index to another index within the treegrid. To enable reordering, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowReordering.html) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/reorder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorder.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorder/reorder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable reordering a particular column by setting the [`AllowReordering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowReordering.html) of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) to false.

### Reorder Multiple Columns

Multiple columns can be reordered at a time by using the [`reorderColumns`](https://ej2.syncfusion.com/documentation/api/grid/#reordercolumns) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="ReorderbyColumn.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorderbyColumn/reorderbyColumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/reorderbyColumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReorderbyColumn.cs" %}
{% include code-snippet/tree-grid/columns-mvc/reorderbyColumn/reorderbyColumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Lock Columns

You can lock columns by using [`LockColumn`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~LockColumn.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html). The locked columns will be moved to the first position. Also you can’t reorder its position.

In the below example, Duration column is locked and its reordering functionality is disabled.


{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/lock/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Lock.cs" %}
{% include code-snippet/tree-grid/columns-mvc/lock/lock.cs %}
{% endhighlight %}
{% endtabs %}




## Column resizing

Column width can be resized by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. Each column can be auto resized by double-clicking the right edge of the column header to fit the width of that column based on the widest cell content. To enable column resize, set the [`AllowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowResizing.html) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Resizing.cs" %}
{% include code-snippet/tree-grid/columns-mvc/resizing/resizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/resizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Resizing.cs" %}
{% include code-snippet/tree-grid/columns-mvc/resizing/resizing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable resizing for a particular column by setting the [`AllowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) property of [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) to false.
> In RTL mode, you can click and drag the left edge of the header cell to resize the column.

### Min and max width

Column resize can be restricted between minimum and maximum width by defining the [`MinWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MinWidth.html) and [`MaxWidth`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~MaxWidth.html) in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) API.

In the following sample, minimum and maximum width are defined for **Duration**, and **Task Name** columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Minmax.cs" %}
{% include code-snippet/tree-grid/columns-mvc/minmax/minmax.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/minmax/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Minmax.cs" %}
{% include code-snippet/tree-grid/columns-mvc/minmax/minmax.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Resize Stacked Column

Stacked columns can be resized by clicking and dragging the right edge of the stacked column header. While dragging, the width of the respective child columns will be resized at the same time. You can disable resize for particular stacked column by setting [`AllowResizing`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowResizing.html) as **false** to its columns.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/stackedresize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stackedresize.cs" %}
{% include code-snippet/tree-grid/columns-mvc/stackedresize/stackedresize.cs %}
{% endhighlight %}
{% endtabs %}

### Touch interaction

When the right edge of the header cell is tapped, a floating handler will be visible over the right border of the column. To resize the column, tap and drag the floating handler as needed.

The following screenshot represents the column resizing in touch device.

<!-- markdownlint-disable MD033 -->
<img src="/tree-grid/images/column-resizing.png" alt="Touch interaction image" style="width:320px;height: 620px">
<!-- markdownlint-enable MD033 -->

## Column template

The column [`Template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Template.html) has options to display custom element instead of a field value in the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Column-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/column-template/column-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/column-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/column-template/column-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> TreeGrid actions such as editing, filtering and sorting etc. will depend upon the column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html). If the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the
template column, the treegrid actions cannot be performed.

### Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Approved** field value.

```html
  <script id="template" type="text/x-template">
            <div class="template_checkbox">
                ${if(approved)}
                <input type="checkbox" checked> ${else}
                <input type="checkbox"> ${/if}
            </div>
        </script>
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Using-condition-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/using-condition-template/using-condition-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/using-condition-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Using-condition-template.cs" %}
{% include code-snippet/tree-grid/columns-mvc/using-condition-template/using-condition-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column type

Column type can be specified using the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) property in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html). It specifies the type of data the column binds.

If the [`Format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html)  is defined for a column, the column uses [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) to select the appropriate format option ([number](../../common/internationalization/#number-formatting)
 or [date](../../common/internationalization/#manipulating-datetime)).

TreeGrid column supports the following types:
* string
* number
* boolean
* date
* datetime

> If the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) is not defined, it will be determined from the first record of the [`DataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html).

## Column Chooser

The column chooser has options to show or hide columns dynamically. It can be enabled by defining the
[`ShowColumnChooser`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ShowColumnChooser.html) as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnchooser.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnchooser/columnchooser.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can hide the column names in column chooser by defining the [`ShowInColumnChooser`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowInColumnChooser.html) as false.

### Open column chooser by external button

The Column chooser can be displayed on a page through external button by invoking the **openColumnChooser** method with X and Y axis positions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Externalbutton.cs" %}
{% include code-snippet/tree-grid/columns-mvc/externalbutton/externalbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Column menu

The column menu has options to integrate features like sorting, filtering, and autofit. It will show a menu with the integrated feature when users click on multiple icon of the column. To enable column menu, you need to define the [`ShowColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ShowColumnMenu.html) property as true.

The default items are displayed in following table.

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `Filter` | Show the filter option as given in `filterSettings.type` |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable column menu for a particular column by defining the [`ShowColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowColumnMenu.html) in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) as false.

## Checkbox Column

To render checkboxes in existing column, you need to set [`ShowCheckbox`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowCheckbox.html) property as **true**.

It is also possible to select the rows hierarchically using checkboxes in TreeGrid by enabling [`AutoCheckHierarchy`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AutoCheckHierarchy.html) property. When we check on any parent record checkbox then the child record checkboxes will get checked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-mvc/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-mvc/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Responsive columns

You can toggle column visibility based on media queries which are defined
at the [`HideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html).
The [`HideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html ).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Responsive-columns.cs" %}
{% include code-snippet/tree-grid/columns-mvc/responsive-columns/responsive-columns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/responsive-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive-columns.cs" %}
{% include code-snippet/tree-grid/columns-mvc/responsive-columns/responsive-columns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Controlling TreeGrid actions

You can enable or disable treegrid action for a particular column by setting the [`AllowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html), and [`AllowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowSorting.html) properties in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Gridaction.cs" %}
{% include code-snippet/tree-grid/columns-mvc/gridaction/gridaction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/gridaction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gridaction.cs" %}
{% include code-snippet/tree-grid/columns-mvc/gridaction/gridaction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show/hide columns by external button

You can show or hide treegrid columns dynamically using external buttons by invoking the [`showColumns`](https://ej2.syncfusion.com/documentation/api/grid/#showcolumns) or [`hideColumns`](https://ej2.syncfusion.com/documentation/api/grid/#hidecolumns) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Showhide.cs" %}
{% include code-snippet/tree-grid/columns-mvc/showhide/showhide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/showhide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide.cs" %}
{% include code-snippet/tree-grid/columns-mvc/showhide/showhide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Complex data binding

You can achieve complex data binding in the treegrid by using the dot(.) operator in the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/tree-grid/columns-mvc/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/complexbinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexbinding.cs" %}
{% include code-snippet/tree-grid/columns-mvc/complexbinding/complexbinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## ValueAccessor

The [`ValueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) is used to access/manipulate the value of display data. You can achieve custom value formatting by using the [`ValueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/tree-grid/columns-mvc/value/value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/tree-grid/columns-mvc/value/value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Display array type columns

You can bind an array of objects in a column by using the [`ValueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.
In this example, the name field has an array of two objects, FirstName and LastName. These two objects are joined and bound to a column using the
[`ValueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Valuearray.cs" %}
{% include code-snippet/tree-grid/columns-mvc/valuearray/valuearray.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/valuearray/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Valuearray.cs" %}
{% include code-snippet/tree-grid/columns-mvc/valuearray/valuearray.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Expression column

You can achieve the expression column by using the [`ValueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Expression.cs" %}
{% include code-snippet/tree-grid/columns-mvc/expression/expression.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/expression/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Expression.cs" %}
{% include code-snippet/tree-grid/columns-mvc/expression/expression.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to render boolean values as checkbox

To render boolean values as checkbox in columns, you need to set [`DisplayAsCheckBox`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisplayAsCheckBox.html) property as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Displayascheckbox.cs" %}
{% include code-snippet/tree-grid/columns-mvc/displayascheckbox/displayascheckbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/displayascheckbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Displayascheckbox.cs" %}
{% include code-snippet/tree-grid/columns-mvc/displayascheckbox/displayascheckbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.