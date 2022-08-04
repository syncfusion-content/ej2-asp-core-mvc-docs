---
layout: post
title: Columns Core in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Columns Core in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Columns in ##Platform_Name## Tree Grid Component

The column definitions are used as the dataSource schema in the TreeGrid. This plays a vital role in rendering column values in the required format.
The treegrid operations such as sorting, filtering and searching etc. are performed based on column definitions. The [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) property of [`e-treegrid-columns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumns.html) tag helper is necessary to map the data source values in TreeGrid columns.

> 1. If the column [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the dataSource, the column values will be empty.
> 2. If the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) name contains “dot” operator, it is considered as complex binding.

[`treeColumnIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TreeColumnIndex.html) property denotes the column that is used to expand and collapse child rows.



## Format

To format cell values based on specific culture, use the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper. The TreeGrid uses [`Internalization`](../../common/internationalization/) library to format the number values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/format-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/tree-grid/columns-core/format-columns/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/tree-grid/columns-core/format-columns/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, the number and date values are formatted in **en-US** locale.

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

For built-in date format you can specify [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property as string (Example: `yMd`). Please refer to the link to know more about [`Date formatting`](../../common/internationalization/#manipulating-datetime).

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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/date-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dateformat.cs" %}
{% include code-snippet/tree-grid/columns-core/date-format/dateformat.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Dateformat.cs" %}
{% include code-snippet/tree-grid/columns-core/date-format/dateformat.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Lock Columns

You can lock columns by using [`column.lockColumn`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~LockColumn.html) property. The locked columns will be moved to the first position. Also you can’t reorder its position.

In the below example, Duration column is locked and its reordering functionality is disabled.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/lock/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Lock.cs" %}
{% include code-snippet/tree-grid/columns-core/lock/lock.cs %}
{% endhighlight %}
{% endtabs %}



## Column type

Column type can be specified using the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper. It specifies the type of data the column binds.

If the [`format`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) is defined for a column, the column uses [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) to select the appropriate format option ([number](../../common/internationalization/#number-formatting) or [date](../../common/internationalization/#manipulating-datetime)).

TreeGrid column supports the following types:
* string
* number
* boolean
* date
* datetime

> If the [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) is not defined, it will be determined from the first record of the [`dataSource`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~DataSource.html).



## Checkbox Column

To render checkboxes in existing column, you need to set [`showCheckbox`] property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) as **true**.

It is also possible to select the rows hierarchically using checkboxes in TreeGrid by enabling [`autoCheckHierarchy`] property. When we check on any parent record checkbox then the child record checkboxes will get checked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Controlling TreeGrid actions

You can enable or disable treegrid action for a particular column by setting the [`allowFiltering`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowFiltering.html), and [`allowSorting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~AllowSorting.html) properties of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/prevent-column-actions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnActions.cs" %}
{% include code-snippet/tree-grid/columns-core/prevent-column-actions/columnActions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ColumnActions.cs" %}
{% include code-snippet/tree-grid/columns-core/prevent-column-actions/columnActions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show/hide columns by external button

You can show or hide treegrid columns dynamically using external buttons by invoking the **showColumns** or **hideColumns** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/tree-grid/columns-core/show-hide/showHide.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ShowHide.cs" %}
{% include code-snippet/tree-grid/columns-core/show-hide/showHide.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## ValueAccessor

The [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) is used to access/manipulate the value of display data. You can achieve custom value formatting by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/value-accessor-formats/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor-formats/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor-formats/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Display array type columns

You can bind an array of objects in a column by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.
In this example, the name field has an array of two objects, FirstName and LastName. These two objects are joined and bound to a column using the
[`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/value-accessor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ValueAccessor.cs" %}
{% include code-snippet/tree-grid/columns-core/value-accessor/valueAccessor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Expression column

You can achieve the expression column by using the [`valueAccessor`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValueAccessor.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/expression-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Express.cs" %}
{% include code-snippet/tree-grid/columns-core/expression-columns/express.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Express.cs" %}
{% include code-snippet/tree-grid/columns-core/expression-columns/express.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to render boolean values as checkbox

To render boolean values as checkbox in columns, you need to set [`displayAsCheckBox`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisplayAsCheckBox.html) property as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/checkbox-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox-column/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/columns-core/checkbox-column/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.