---
layout: post
title: Columns in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Columns in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Columns in ASP.NET Core Grid Component

In Syncfusion ASP.NET Core Grid, Columns are fundamental elements that play a pivotal role in organizing and displaying data within your application. They serve as the building blocks for data presentation, allowing you to specify what data fields to show, how to format and style them, and how to enable various interactions within the grid.

## Column types

The Syncfusion Grid component allows you to specify the type of data that a column binds using the `columns.type` property. The `type` property is used to determine the appropriate `format`, such as [number](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#number-formatting) or [date](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#manipulating-datetime), for displaying the column data. 

Grid supports the following column types:

* **string**: Represents a column that binds to string data. This is the default type if the `type` property is not defined.
* **number**: Represents a column that binds to numeric data. It supports formatting options for displaying numbers.
* **boolean**: Represents a column that binds to boolean data. It displays checkboxes for boolean values.
* **date**: Represents a column that binds to date data. It supports formatting options for displaying dates.
* **datetime**: Represents a column that binds to date and time data. It supports formatting options for displaying date and time values.
* **checkbox**: Represents a column that displays checkboxes.

Here is an example of how to specify column types in a grid using the types mentioned above.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-type/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnType.cs" %}
{% include code-snippet/grid/columns/column-type/column-type.cs %}
{% endhighlight %}
{% endtabs %}

![Column Type](../images/columns/Column-type.png)

>* If the `type` is not defined, then it will be determined from the first record of the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_DataSource).
>* Incase if the first record of the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) is null/blank value for a column then it is necessary to define the `type` for that column. This is because the grid uses the column type to determine which filter dialog to display for that column.

### Difference between boolean type and checkbox type column 

1. Use the **boolean** column type when you want to bind boolean values from your datasource and/or edit boolean property values from your type.
2. Use the **checkbox** column type when you want to enable selection/deselection of the whole row.
3. When the grid column `type` is a **checkbox**, the selection type of the grid `selectionSettings` will be multiple. This is the default behavior.
4. If you have more than one column with the column type as a **checkbox**, the grid will automatically enable the other column's checkbox when selecting one column checkbox.

> To learn more about how to render boolean values as checkboxes in a Syncfusion GridColumn, please refer to the [Render Boolean Values as Checkbox](https://ej2.syncfusion.com/aspnetcore/documentation/grid/columns/columns#render-boolean-value-as-checkbox) section.

## Column width

To adjust the column width in a Grid, you can use the [width](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Width) property within the [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) property of the Grid configuration. This property enables you to define the column width in pixels or as a percentage. You can set the width to a specific value, like **100** for 100 pixels, or as a percentage value, such as **25%** for 25% of the available width.

1. Grid column width is calculated based on the sum of column widths. For example, a grid container with 4 columns and a width of 800 pixels will have columns with a default width of 200 pixels each.
2. If you specify widths for some columns but not others, the Grid will distribute the available width equally among the columns without explicit widths. For example, if you have 3 columns with widths of 100px, 200px, and no width specified for the third column, the third column will occupy the remaining width after accounting for the first two columns.
3. Columns with percentage widths are responsive and adjust their width based on the size of the grid container. For example, a column with a width of 50% will occupy 50% of the grid width and will adjust proportionally when the grid container is resized to a smaller size.
4. When you manually resize columns in Syncfusion Grid, a minimum width is set to ensure that the content within the cells remains readable. By default, the minimum width is set to 10 pixels if not explicitly specified for a column.
5. If the total width of all columns exceeds the width of the grid container, a horizontal scrollbar will automatically appear to allow horizontal scrolling within the grid.
6. When the columns is hide using the column chooser, the width of the hidden columns is removed from the total grid width, and the remaining columns will be resized to fill the available space.
7. If the parent element has a fixed width, the grid component will inherit that width and occupy the available space. However, if the parent element does not have a fixed width, the grid component will adjust its width dynamically based on the available space.

**Supported types for column width**

Syncfusion Grid supports the following three types of column width:

**1. Auto**

The column width is automatically calculated based on the content within the column cells. If the content exceeds the width of the column, it will be truncated with an ellipsis (...) at the end. You can set the width for columns as **auto** in your Grid configuration as shown below:

```html
  <e-grid-column field="OrderID" headerText="Order ID" textAlign='Right' width='auto'></e-grid-column>
```

**2. Percentage**

The column width is specified as a percentage value relative to the width of the grid container. For example, a column width of 25% will occupy 25% of the total grid width. You can set the width for columns as **percentage** in your Grid configuration as shown below:

```html
  <e-grid-column field='OrderID' headerText='Order ID' textAlign='Right' width='25%'></e-grid-column>
```

**3. Pixel**

The column width is specified as an absolute pixel value. For example, a column width of 100px will have a fixed width of 100 pixels regardless of the grid container size. You can set the width for columns as **pixel** in your Grid configuration as shown below:

```html
  <e-grid-column field='OrderID' headerText='Order ID' textAlign='Right' width='100'></e-grid-column>
```

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnwidth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnWidth.cs" %}
{% include code-snippet/grid/columns/columnwidth/columnwidth.cs %}
{% endhighlight %}
{% endtabs %}

![Column Width](../images/columns/columnwidth.png)    

## Column formatting

Column formatting is a powerful feature in Syncfusion Grid that allows you to customize the display of data in grid columns. You can apply different formatting options to columns based on your requirements, such as displaying numbers with specific formats, formatting dates according to a specific locale, and using templates to format column values.

You can use the `columns.format` property to specify the format for column values. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/format/format.cs %}
{% endhighlight %}
{% endtabs %}

![Column Format](../images/columns/Column-format.png)

>* The grid uses the [Internalization](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization) library to format values based on the specified format and culture.
>* By default, the [number](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#number-formatting) and [date](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#formatting) values are formatted in **en-US** locale. You can localize the currency and date in different locale as explained [here](https://ej2.syncfusion.com/aspnetcore/documentation/common/localization).
>* The available format codes may vary depending on the data type of the column.
>* You can also customize the formatting further by providing a custom function to the `format` property, instead of a format string.
>* Make sure that the format string is valid and compatible with the data type of the column, to avoid unexpected results.

### Number formatting

Number formatting allows you to customize the display of numeric values in grid columns. You can use standard numeric format strings or custom numeric format strings to specify the desired format. The `columns.format` property can be used to specify the number format for numeric columns. For example, you can use the following format strings to format numbers:

Format |Description |Remarks
-------|-------|-------
N | Denotes numeric type. | The numeric format is followed by integer value as N2, N3. etc which denotes the number of precision to be allowed.
C | Denotes currency type. | The currency format is followed by integer value as C2, C3. etc which denotes the number of precision to be allowed.
P | Denotes percentage type | The percentage format expects the input value to be in the range of 0 to 1. For example the cell value **0.2** is formatted as **20%**. The percentage format is followed by integer value as P2, P3. etc which denotes the number of precision to be allowed.

The following example code demonstrates the formatting of data for **Mark 1** and **Mark 2** using the **'N'** format, **Percentage of Marks** using the **'P'** format, and **Fees** using the **'C'** format.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/numberformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NumberFormat.cs" %}
{% include code-snippet/grid/columns/numberformat/numberformat.cs %}
{% endhighlight %}
{% endtabs %}

![Column Number Format](../images/columns/Column-number-format.png)

>To learn more about number formatting, you can refer to the [number](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#number-formatting) section.

### Date formatting

Date formatting in grid columns allows you to customize how date values are displayed. You can use standard date format strings, such as **"d," "D," "MMM dd, yyyy,"** and more, or create your own custom format strings. To specify the desired date format, you can use the `format`property of the Grid columns. For example, you can set `columns.format` as a string like **"yMd"** for a built-in date format. 

Additionally, you can use custom format strings to format date values, and examples of custom formats and formatted date values are provided in the table below.

Format | Formatted value
-----|-----
{ type:'date', format:'dd/MM/yyyy' } | 04/07/1996
{ type:'date', format:'dd.MM.yyyy' } | 04.07.1996
{ type:'date', skeleton:'short' } | 7/4/96
{ type: 'dateTime', format: 'dd/MM/yyyy hh:mm a' } | 04/07/1996 12:00 AM
{ type: 'dateTime', format: 'MM/dd/yyyy hh:mm:ss a' } | 07/04/1996 12:00:00 AM

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/dateformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/dateformat/format.cs %}
{% endhighlight %}
{% endtabs %}

![Column Date Format](../images/columns/Column-Date-Format.png)

>To learn more about date formatting, you can refer to [Date formatting](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#formatting).

### Format the date column based on localization 

You can also format the date column based on the localization settings of the user's browser. You can use the `format` property of the Grid columns along with the [locale](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Locale) property to specify the desired date format based on the locale.

In this example, the format property specifies the date format as "**yyyy-MMM-dd**", and the locale property specifies the locale as **"es-AR"** for Spanish (Argentina).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-format-localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/column-format-localization/format-localization.cs %}
{% endhighlight %}
{% endtabs %}

![Column Format Localization](../images/columns/column-format-localization.png)

### Format template column value 

In the Syncfusion ASP.NET Core Grid, you have the ability to customize the display of data in a column through the use of template columns. Formatting template column values is essential for enhancing the visual representation of data in a web application. It allows the customization of the appearance of specific column data, such as dates and numbers, to improve readability and user understanding.

To illustrate how to format a template column value, consider the following example where the **OrderDate** column is formatted to display dates in the **‘dd/MMM/yyyy’** format.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-format-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/grid/columns/column-format-template/column-format-template.cs %}
{% endhighlight %}
{% endtabs %}

![Column Format Template](../images/columns/column-format-template.png)

### Custom formatting

Syncfusion Grid allows you to customize the formatting of data in the grid columns. You can apply custom formats to numeric or date columns to display data in a specific way according to the requirements. To apply custom formatting to grid columns in Syncfusion Grid, you can use the `format` property. Here's an example of how you can use custom formatting for numeric and date columns:

In the below example, the **numberFormatOptions** object is used as the `format` property for the **'Freight'** column to apply a custom numeric format with four decimal places. Similarly, the **dateFormatOptions** object is used as the `format` property for the **'OrderDate'** column to apply a custom date format displaying the date in the format of day-of-the-week, month abbreviation, day, and 2-digit year (e.g. Sun, May 8, '23).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/custom-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomFormat.cs" %}
{% include code-snippet/grid/columns/custom-format/custom-format.cs %}
{% endhighlight %}
{% endtabs %}

![Column Custom Format](../images/columns/customFormat.png)

>To learn more about custom formatting, you can refer to [Custom Date formatting](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#custom-formats) and [Custom Number formatting](https://ej2.syncfusion.com/aspnetcore/documentation/common/internationalization#custom-number-formatting-and-parsing). 

## Align the text of content

You can align the text in the content of a Grid column using the `textAlign` property. This property allows you to specify the alignment of the text within the cells of a particular column in the Grid. By default, the text is aligned to the left, but you can change the alignment by setting the value of the `textAlign` property to one of the following options:

*	**Left**: Aligns the text to the left (default).
*	**Center**: Aligns the text to the center.
*	**Right**: Aligns the text to the right.
*	**Justify**: Align the text to the justify.

Here is an example of using the `textAlign` property to align the text of a Grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Alignment.cs" %}
{% include code-snippet/grid/columns/alignment/alignment.cs %}
{% endhighlight %}
{% endtabs %}

![Column Alignment](../images/columns/Alignment-column.gif)

>* The `textAlign` property only changes the alignment content not the column header. If you want to align both the column header and content, you can use the `headerTextAlign` property.

## Render boolean value as checkbox

The Grid control allows you to render boolean values as checkboxes in columns. This can be achieved by using the `displayAsCheckBox` property, which is available in the [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns). This property is useful when you have a boolean column in your Grid and you want to display the values as checkboxes instead of the default text representation of **true** or **false**.

To enable the rendering of boolean values as checkboxes, you need to set the `displayAsCheckBox` property of the `columns` to **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/booleanascheckbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Booleanascheckbox.cs" %}
{% include code-snippet/grid/columns/booleanascheckbox/booleanascheckbox.cs %}
{% endhighlight %}
{% endtabs %}

![Column Render Boolean Value](../images/columns/Render-boolean.png)

>* The `displayAsCheckBox` property is only applicable to boolean values in Grid columns.
>* When `displayAsCheckBox` is set to **true**, the boolean values will be rendered as checkboxes in the Grid column, with checked state indicating **true** and unchecked state indicating **false**.

## How to prevent checkbox in the blank row

To prevent the checkbox in the blank row of the Grid, even if the `displayAsCheckBox` property is set to true for that column, you can use the [rowDataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event and check for empty or null values in the row data. If all the values in the row are empty or null, you can set the inner HTML of the corresponding cell to an empty string to hide the checkbox.

Here is an example of how you can prevent a checkbox from being displayed in a blank row in a Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/blank-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Blank-row.cs" %}
{% include code-snippet/grid/columns/blank-row/blank-row.cs %}
{% endhighlight %}
{% endtabs %}

![Column Prevent Checkbox in Blank Row](../images/columns/blank-row.png)

## AutoFit columns

The Grid has a feature that allows to automatically adjust column widths based on the maximum content width of each column when you double-click on the resizer symbol located in a specific column header. This feature ensures that all data in the grid rows is displayed without wrapping. To use this feature, you need to enable the resizer symbol in the column header by setting the [allowResizing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing) property to true in the grid.

### Resizing a column to fit its content using AutoFit method

The `autoFitColumns` method resizes the column to fit the widest cell's content without wrapping. You can AutoFit specific columns at initial rendering by invoking the `autoFitColumns` method in [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit.cs" %}
{% include code-snippet/grid/columns/autofit/autofit.cs %}
{% endhighlight %}
{% endtabs %}

![Column AutoFit](../images/columns/autofit.png)

> You can autoFit all the columns by invoking the `autoFitColumns` method without specifying column names.

### AutoFit columns with empty space

The AutoFit feature is utilized to display columns in a grid based on the defined width specified in the columns declaration. If the total width of the columns is less than the width of the grid, this means that white space will be displayed in the grid instead of the columns auto-adjusting to fill the entire grid width.

You can enable this feature by setting the [autoFit](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AutoFit) property set to **true**. This feature ensures that the column width is rendered only as defined in the Grid column definition.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFit.cs" %}
{% include code-snippet/grid/columns/autofit-column/autofit.cs %}
{% endhighlight %}
{% endtabs %}

![Column AutoFit Empty Space](../images/columns/autofit-empty-space.png)

> If any one of the column width is undefined, then the particular column will automatically adjust to fill the entire width of the grid table, even if you have enabled the `autoFit` property of grid.

### AutoFit columns when changing column visibility using column chooser

In Syncfusion Grid, you can auto-fit columns when the column visibility is changed using the column chooser. This can be achieved by calling the `autoFitColumns` method in the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event. By using the **requestType** property in the event arguments, you can differentiate between different actions, and then call the `autoFitColumns` method when the request type is **columnState**.

Here's an example code snippet in ASP.NET Core that demonstrates how to AutoFit columns when changing column visibility using column chooser:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofit-column-chooser/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFit.cs" %}
{% include code-snippet/grid/columns/autofit-column-chooser/autofit-column-chooser.cs %}
{% endhighlight %}
{% endtabs %}

![Column AutoFit Column Chooser](../images/columns/Autofit-column-chooser.gif)

### AutoFit columns with specific rows

To adjust the column widths of a specific range of rows based on their content, you can use the `autoFitColumns` method by simply passing the second and third parameters (optional) as the start and end index for the column you want to fit. You can AutoFit specific columns at initial rendering by invoking the `autoFitColumns` method in [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event.

This feature will calculate the appropriate width based on the maximum content width of the specified range of rows or the header text width. Subsequently, the maximum width of the content of the specified rows or header text will be applied to the entire column of the grid.

Here is an example of how to AutoFit columns with specific rows. The first parameter is an array containing the specific column field names, such as  **Inventor**, **Number of INPADOC patents** and **Main fields of invention**  is passed to apply the AutoFit functionality to these columns. After, the second parameter are start index is set to **1** and third parameter are end index is set to **3**. When specifying these start and end index, the AutoFit operation is applied only to the range of rows from 1 to 3 for column width adjustment.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/autofitspecificcolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoFitSpecificColumn.cs" %}
{% include code-snippet/grid/columns/autofitspecificcolumn/autofitspecificcolumn.cs %}
{% endhighlight %}
{% endtabs %}

![Column AutoFit Specific Row](../images/columns/Autofit-Specific-columns.gif)

## Locked columns

The Syncfusion Grid allows you to lock columns, which prevents them from being reordered and moves them to the first position. This functionality can be achieved by setting the `column.lockColumn` property to **true**, which locks the column and moves it to the first position in the grid.

Here's an example of how you can use the `lockColumn` property to lock a column in the Syncfusion Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/lock/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Lock.cs" %}
{% include code-snippet/grid/columns/lock/lock.cs %}
{% endhighlight %}
{% endtabs %}

![Lock-Column](../images/columns/Lock-column.png)

## Show or hide columns

The Syncfusion Grid control allows you to show or hide columns dynamically by using property or methods available in the grid. This feature can be useful when you want to customize the visibility of columns in the Grid based on the requirements.

> To work with showing and hiding columns, it is necessary to have at least one column of the grid in a visible state

### Using property

You can show or hide columns in the ASP.NET Core Grid using the `visible` property of each column. By setting the `visible` property to **true** or **false**, you can control whether the column should be visible or hidden in the grid. Here's an example of how to show or hide a column in the ASP.NET Core Grid using the visible property:

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added to enable and disable the `visible` property. When the switch is toggled, the `change` event is triggered and the `visible` property of the **ShipCity** column is updated accordingly. The `refreshColumns` method is called to refresh the grid and display the updated content. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/column-using-property/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-Hide-Column.cs" %}
{% include code-snippet/grid/columns/column-using-property/column-using-property.cs %}
{% endhighlight %}
{% endtabs %}

![Show-Column-Property](../images/columns/Visible-column-disable.png)
![Hide-Column-Property](../images/columns/Visible-column-enable.png)

>* Hiding a column using the `visible` property only affects the UI representation of the grid. The data for the hidden column will still be available in the underlying data source, and can be accessed or modified programmatically.
>* When a column is hidden, its width is not included in the calculation of the total grid width.
>* To hide a column permanently, you can set its visible property to false in the column definition, or remove the column definition altogether.

### Using methods

You can also show or hide columns in the ASP.NET Core Grid using the `showColumns` and `hideColumns` methods of the grid control. These methods allow you to show or hide columns based on either the `headerText` or the `field` of the column.

**Based on header text**

You can dynamically show or hide columns in the Grid based on the header text by invoking the `showColumns` or `hideColumns` methods. These methods take an array of column header texts as the first parameter, and the value `headerText` as the second parameter to specify that you are showing or hiding columns based on the header text.

Here's an example of how to show or hide a column based on the headerText in the ASP.NET Core Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/show-hide-using-method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-Hide-Column.cs" %}
{% include code-snippet/grid/columns/show-hide-using-method/show-hide-using-method.cs %}
{% endhighlight %}
{% endtabs %}

![Show-Column-Headertext](../images/columns/show-column.png)
![Hide-Column-Headertext](../images/columns/hide-column.png)

**Based on field**

You can dynamically show or hide columns in the Grid using external buttons based on the field by invoking the `showColumns` or `hideColumns` methods. These methods take an array of column fields as the first parameter, and the value `field` as the second parameter to specify that you are showing or hiding columns based on the field.

Here's an example of how to show or hide a column based on the field in the ASP.NET Core Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/show-hide-field/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-Hide-Column.cs" %}
{% include code-snippet/grid/columns/show-hide-field/show-hide-field.cs %}
{% endhighlight %}
{% endtabs %}

![Show-Column-Field](../images/columns/show-column.png)
![Hide-Column-Field](../images/columns/hide-column.png)

## Controlling Grid actions

You can control various actions such as filtering, grouping, sorting, resizing, reordering, editing, and searching for specific columns in the Syncfusion ASP.NET Core Grid using the following properties:

* `allowEditing`: Enables or disables editing for a column.
* [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering): Enables or disables filtering for a column.
* [allowGrouping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowGrouping): Enables or disables grouping for a column.
* [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSorting): Enables or disables sorting for a column.
* [allowReordering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowReordering): Enables or disables reordering for a column.
* [allowResizing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowResizing): Enables or disables resizing for a column
* `allowSearching`: Enables or disables searching for a column

Here is an example code that demonstrates how to control grid actions for specific columns:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/controllingactions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controllingactions.cs" %}
{% include code-snippet/grid/columns/controllingactions/controllingactions.cs %}
{% endhighlight %}
{% endtabs %}

![Column Grid Action](../images/columns/grid-action.png)

## Customize column styles

Customizing the grid column styles allows you to modify the appearance of columns in the Grid control to meet your design requirements. You can customize the font, background color, and other styles of the columns. To customize the columns styles in the grid, you can use grid event, css, property or method support.

For more information check on this [documentation](https://ej2.syncfusion.com/aspnetcore/documentation/grid/cell#customize-cell-styles).

## Manipulating columns

The Syncfusion Grid for ASP.NET Core provides powerful features for manipulating columns in a grid. This section explains how to access columns, update column definitions, and add/remove columns using Syncfusion Grid properties, methods, and events.

### Accessing Columns

To access columns in the Syncfusion Grid, you can use the following methods in the grid.

* **`getColumns`**:

This method returns the array of columns defined in the grid.

```ts
let columns = grid.getColumns();
```

* **`getColumnByField`**:

This method returns the column object that matches the specified field name.

```ts
let column = grid.getColumnByField('ProductName');
```

* **`getColumnByUid`**:

This method returns the column object that matches the specified UID.

```ts
let column = grid.getColumnByUid();
```

* **`getVisibleColumns`**:

This method returns the array of visible columns.

```ts
let visibleColumns = grid.getVisibleColumns();
```

* **`getForeignKeyColumns`**:

This method returns the array of foreignkey columns.

```ts
let foreignKeyColumns = grid.getForeignKeyColumns();
```

* **`getColumnFieldNames`**

This method returns an array of field names of all the columns in the Grid.

```ts
let fieldNames = grid.getColumnFieldNames()
```

> For a complete list of column methods and properties, refer to this [section](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html).

### Updating column definitions

You can update the column definitions in the Grid using the [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) property. You can modify the properties of the column objects in the columns array to update the columns dynamically. For example, you can change the headerText, width, visible, and other properties of a column to update its appearance and behavior in the grid and then call the `refreshColumns` method to apply the changes to the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/update-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/grid/columns/update-column/update-column.cs %}
{% endhighlight %}
{% endtabs %}

![Update Column](../images/columns/Update-column.png)

### Adding/Removing Columns

The Grid control allows you to dynamically add or remove columns to and from the grid using the [columns](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) property, which can be accessed through the instance of the Grid.

To add a new column to the Grid, you can directly **push** the new column object to the columns property.To remove a column from the Grid, you can use the **pop** method, which removes the last element from the columns array of the Grid. Alternatively, you can use the splice method to remove a specific column from the columns array.

Here's an example of how you can add and remove a column from the grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/add-delete-column/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column.cs" %}
{% include code-snippet/grid/columns/add-delete-column/add-delete-column.cs %}
{% endhighlight %}
{% endtabs %}

![Column Add-Delete](../images/columns/Add-Delete-Column.png)

### How to refresh columns

You can use the `refreshColumns` method of the Syncfusion Grid to refresh the columns in the grid. This method can be used when you need to update the grid columns dynamically based on user actions or data changes.

```ts
grid.refreshColumns();
```

## Responsive columns

The Syncfusion ASP.NET Grid Core provides a built-in feature to toggle the visibility of columns based on media queries using the [hideAtMedia](../../api/grid/column/#hideatmedia) property of the column object. The `hideAtMedia` accepts valid [Media Queries](http://cssmediaqueries.com/what-are-css-media-queries.html). 

In this example, we have a Grid that displays data with three columns: **Order ID, Customer ID, and Freight**. We have set the `hideAtMedia` property of the **OrderID** column to (min-width: 700px) which means that this column will be hidden when the browser screen width is less than or equal to 700px.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/responsivecolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsivecolumns.cs" %}
{% include code-snippet/grid/columns/responsivecolumns/responsivecolumns.cs %}
{% endhighlight %}
{% endtabs %}

![Column Responsive](../images/columns/responsive-coulmn.png)

## See Also

* [Group Column by Format](../grouping#group-by-format)
* [How to set complex column as Foreignkey column](../how-to/complex-column-as-foreign-key-column)
* [Complex Data Binding with list of Array Of Objects](../how-to/list-of-array-of-objects)
* [How to display image on the base64 Grid column](https://support.syncfusion.com/kb/article/9862/how-to-display-a-picture-on-the-base64-grid-column-in-javascript-application)
* [How to change the data source or columns dynamically](../data-binding/how-to-change-the-data-source-or-columns-dynamically)