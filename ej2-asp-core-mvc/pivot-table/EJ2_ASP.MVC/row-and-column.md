---
layout: post
title: Row And Column in ##Platform_Name## Syncfusion Pivot Table Component
description: Learn here all about Row And Column in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row And Column
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD012 -->

# Row and column in ##Platform_Name## Pivot Table component

## Width and Height

Setting appropriate dimensions for the Pivot Table ensures optimal display and better user experience across different screen sizes and layouts. You can define the Pivot Table's dimensions using the [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Height) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Width) properties in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class respectively.

These dimension properties support multiple formats to accommodate various layout scenarios and provide flexibility in how you define the component's size:

**Supported formats:**

* **Pixel**: Specify exact dimensions using numeric values or pixel units. For example: `100`, `200`, `"100px"`, or `"200px"`.
* **Percentage**: Set dimensions relative to the parent container. For example: `"100%"` or `"200%"`.
* **Auto**: This option is available only for the [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Height) property. When set to **auto**, the Pivot Table expands beyond its parent container height without showing a vertical scrollbar within the component. Instead, the parent container displays its vertical scrollbar once the component exceeds its boundaries.

> **Note:** The Pivot Table maintains a minimum width of **400px** to ensure proper display and functionality, even if a smaller width is specified.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/pivot-table/grid-customization/size/Size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/pivot-table/grid-customization/size/Size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot table height and width example](images/height-width.png)

## Row Height

Adjusting the row height in the Pivot Table helps make your data easier to view and interact with, especially when there are many rows or large amounts of content. To make these adjustments, you can use the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class. This property allows you to control how much space each row occupies, so the Pivot Table remains clear and readable according to your needs.

> By default, the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) is set to **36** pixels for desktop layouts and **48** pixels for mobile layouts. However, if you enable the grouping bar option, note that only the column header height may change, while the rest of the rows maintain the specified height.

For example, in the sample code below, the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property is set to **60** pixels. This increases the space for each row, making the data easier to read and compare.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/pivot-table/grid-customization/row-height/RowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/pivot-table/grid-customization/row-height/RowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot table row height](images/row-height.png)

## Column Width

Controlling the width of columns allows users to view their data in the Pivot Table more clearly, making each column easy to read and ensuring that information is not cut off. To achieve this, you can use the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property, which is available under the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html).

> By default, the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) is set to **110** pixels for all columns except the first one. The first column is assigned a width of **250** pixels if the grouping bar is enabled, or **200** pixels when it is not. This ensures that the data in the row header is always easily visible.

In the following example, the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property is set to **200** pixels for all columns to provide a wider view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/column-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnWidth.cs" %}
{% include code-snippet/pivot-table/grid-customization/column-width/ColumnWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/column-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnWidth.cs" %}
{% include code-snippet/pivot-table/grid-customization/column-width/ColumnWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot table column width](images/column-width.png)

### Adjust width based on columns

By default, when the component width exceeds the total width of all columns, the columns are automatically stretched to fill the available space. To prevent this stretching behavior, set the [`AllowAutoResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowAutoResizing) property in the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html). This ensures that the Pivot Table adjusts its overall width to match the combined width of all columns, maintaining their original proportions and improving data readability.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/allowAutoResizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AllowAutoResizing.cs" %}
{% include code-snippet/pivot-table/grid-customization/allowAutoResizing/allowAutoResizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/allowAutoResizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AllowAutoResizing.cs" %}
{% include code-snippet/pivot-table/grid-customization/allowAutoResizing/allowAutoResizing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Auto resizing columns](images/allowautoresizing.png)

## Reorder

The reorder option provides users with the flexibility to reorganize column headers within the Pivot Table by dragging and dropping them to different positions. This allows users to customize the layout of their data for better analysis and presentation.

To enable this option, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowReordering) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class to **true**. Once enabled, users can simply click and drag any column header to move it to their desired position within the table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/re-order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrder.cs" %}
{% include code-snippet/pivot-table/grid-customization/re-order/ReOrder.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/re-order/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrder.cs" %}
{% include code-snippet/pivot-table/grid-customization/re-order/ReOrder.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Column reorder example](images/reorder.png)

## Column Resizing

Column resizing in the Pivot Table helps users adjust the column widths to better view and compare data. Users can easily resize columns by clicking and dragging the right edge of any column header. As the user drags, the column’s width is updated immediately, offering a responsive and comfortable viewing experience.

This option is enabled by default. To control column resizing, set the [`AllowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowResizing) property in the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) object to **true** or **false** as needed.

> In right-to-left (RTL) mode, users should click and drag the left edge of the header cell to resize the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/column-resizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnResizing.cs" %}
{% include code-snippet/pivot-table/grid-customization/column-resizing/ColumnResizing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/column-resizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnResizing.cs" %}
{% include code-snippet/pivot-table/grid-customization/column-resizing/ColumnResizing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Column resizing example](images/resize.png)

## Text Wrap

The Pivot Table allows users to wrap cell content to the next line when the content exceeds the boundary of the cell width. To enable text wrap, set the [`AllowTextWrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowTextWrap) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/text-wrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextWrap.cs" %}
{% include code-snippet/pivot-table/grid-customization/text-wrap/TextWrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/text-wrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextWrap.cs" %}
{% include code-snippet/pivot-table/grid-customization/text-wrap/TextWrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Text wrap in pivot table](images/textwrap.png)

## Text Align

Text alignment provides flexibility in positioning content within cells, making the data presentation more organized and visually appealing. You can align the content of the Pivot Table's row headers, column headers, and value cells using the [`TextAlign`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_TextAlign) and [`HeaderTextAlign`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderTextAlign) properties in the [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event under [`GridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html). The available alignment options are:

* `Left` - Positions the content on the left side of the cell.
* `Right` - Positions the content on the right side of the cell.
* `Center` - Positions the content in the center of the cell.
* `Justify` - Distributes the content evenly across the cell width for optimal space utilization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/text-align/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextWrap.cs" %}
{% include code-snippet/pivot-table/grid-customization/text-align/TextAlign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/text-align/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextWrap.cs" %}
{% include code-snippet/pivot-table/grid-customization/text-align/TextAlign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![TextAlign](images/textalign.png)

## AutoFit

The AutoFit option allows users to easily adjust Pivot Table columns so that each column matches the width of its content, making the data easier to read without cell content being cut off or wrapped unnecessarily. To accomplish this, you can use the [`AutoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method from the grid instance, which automatically resizes all Pivot Table columns based on the content of their cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/autofit-method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofitmethod.cs" %}
{% include code-snippet/pivot-table/grid-customization/autofit-method/autofitmethod.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/autofit-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofitmethod.cs" %}
{% include code-snippet/pivot-table/grid-customization/autofit-method/autofitmethod.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Autofit columns example](images/autofit-method.png)

> When the grouping bar is enabled, the first column in the Pivot Table has a minimum width of **250** pixels, which cannot be decreased. In such cases, if you want to auto fit the remaining columns, you can call the [`AutoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method from the grid instance, passing the field names of the Pivot Table columns except the first column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/autofit-groupingbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit-groupingbar.cs" %}
{% include code-snippet/pivot-table/grid-customization/autofit-groupingbar/autofit-groupingbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/autofit-groupingbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit-groupingbar.cs" %}
{% include code-snippet/pivot-table/grid-customization/autofit-groupingbar/autofit-groupingbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Autofit with grouping bar](images/autofit-grouping.png)

### Autofit Specific Columns

The autofit option for specific columns enables users to precisely control which columns automatically resize to fit their content, rather than adjusting all columns simultaneously. This targeted approach allows for greater customization of the Pivot Table layout based on specific content needs.

To implement this functionality during the initial rendering of the Pivot Table, set the `autoFit` parameter to **true** in the [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event. This event, available under the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) property, allows you to selectively apply autofit to columns based on your requirements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/autofit-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit-event.cs" %}
{% include code-snippet/pivot-table/grid-customization/autofit-event/autofit-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/autofit-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofit-event.cs" %}
{% include code-snippet/pivot-table/grid-customization/autofit-event/autofit-event.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Autofit specific columns](images/autofit-event.png)

## Grid Lines

The grid lines option provides visual structure to the Pivot Table by displaying cell borders, making it easier for users to read and analyze data. You can control the display of grid lines using the [`GridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_GridLines) property within the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) configuration.

The following grid line modes are available:

| Mode | Description |
|------|-------------|
| Both | Shows both horizontal and vertical grid lines around each cell |
| None | Hides all grid lines for a clean appearance |
| Horizontal | Shows only horizontal grid lines between rows |
| Vertical | Shows only vertical grid lines between columns |
| Default | Shows grid lines based on the applied theme settings |

> The Pivot Table displays grid lines in **Both** mode by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/grid-lines/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GridLines.cs" %}
{% include code-snippet/pivot-table/grid-customization/grid-lines/GridLines.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/grid-lines/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GridLines.cs" %}
{% include code-snippet/pivot-table/grid-customization/grid-lines/GridLines.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Grid lines example](images/gridlines.png)

## Selection

Selection in the Pivot Table allows users to easily highlight rows, columns, or individual cells for better data focus and visualization. This makes it simple to compare and analyze specific data points within your table.

To enable selection, set the [`AllowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowSelection) property to **true** within the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) configuration. This allows users to select table elements using a mouse click or arrow keys.

The Pivot Table provides two selection modes, controlled by the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Type) property in [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html):

- **Single**: Allows you to select only one row, column, or cell at a time. This is the default mode.
- **Multiple**: Lets you select several rows, columns, or cells. To select multiple items, hold down the "CTRL" key and click the rows or cells you wish to select. To select a range, hold the "SHIFT" key and click the first and last item in the range.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/pivot-table/grid-customization/selection/Selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/pivot-table/grid-customization/selection/Selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot table selection](images/selection.png)

### Selection mode

You can choose how selection works by setting the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Mode) property within the [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) configuration. The Pivot Table offers four simple options for selection mode:

- **Row**: This is the default mode. It lets the user select an entire row with a single click.
- **Column**: In this mode, only entire columns can be selected.
- **Cell**: This mode allows the user to select one or more individual cells.
- **Both**: This option lets users select both rows and columns at the same time, providing more flexibility.

By choosing the right selection mode, users can quickly highlight and review the data that matters most to them.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/selection-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionMode.cs" %}
{% include code-snippet/pivot-table/grid-customization/selection-mode/SelectionMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/selection-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectionMode.cs" %}
{% include code-snippet/pivot-table/grid-customization/selection-mode/SelectionMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Selection mode example](images/selection2.png)

### Cell Selection Mode

To set the cell selection mode, use the [`CellSelectionMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_CellSelectionMode) option within the [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html). The available modes are:

- **Flow** (default): Selects a continuous range of cells from the starting cell to the ending cell, including all rows in between.
- **Box**: Selects a rectangular block of cells that spans from the starting cell to the ending cell, covering all intermediate rows and columns within the selected range.
- **BoxWithBorder**: This mode works like Box mode but also highlights the selected cells with borders for better visibility.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> To use cell selection modes, ensure that the [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Mode) property in [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) is set to **Cell** or **Both** and the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Type) property is set to **Multiple**. This allows users to select more than one cell at a time for better comparison and review.

![Cell selection modes](images/cell-selection.png)

### Changing background color of the selected cell

Highlighting selected cells in the Pivot Table with a different background color helps users quickly identify and focus on important data. To achieve this effect seamlessly, you can apply built-in CSS classes that customize the appearance of selected cells.

In the example below, selected cells appear with a **green-yellow** background. Simply add the custom styles to your stylesheet, and they will be applied when you select a cell using the mouse or arrow keys.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection-color/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-selection-color/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Selected cell color example](images/cell-selection-color.png)

### Event

#### CellSelected

When a user finishes selecting cells, the `CellSelected` event is triggered. This event provides details about the selected cells, including the related row and column headers. The event holds three important parameters: `selectedCellsInfo`, `currentCell`, and `target`. Users can use this information to easily identify the selected data and share it with other parts of their application, such as for data binding or additional processing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-event/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-event/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Cell selected event](images/cellselected_event.png)

#### CellSelecting

The [`CellSelecting`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CellSelecting) event triggers before a cell selection is completed. It helps users preview the details of the cell, including the related row and column headers, before making a final selection. The event also allows users to cancel the selection action if needed. This event includes the following parameters:

- `currentCell`: Contains information about the cell that the user is about to select.
- `data`: Displays the data linked to the current cell, along with its row and column headings.
- `cancel`: Allows users to stop the cell from being selected if certain conditions are met.

You can use these parameters to decide whether or not the cell should be selected, or to update other parts of your application based on the selection about to happen.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-selecting-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-selecting-event/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-selecting-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellSelection.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-selecting-event/CellSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Limitations

The [grouping](./grouping) feature is applied based on the selected row or column headers using the following [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html): selection [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Mode) set to **Cell**, selection [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Type) set to **Multiple**, and [`CellSelectionMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_CellSelectionMode) set to **Box** by default. When using the selection and [grouping](./grouping.md) features together, cell selection is limited to row or column headers with these settings. Other settings, such as selection [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Mode) set to **Row** or **Column**, selection [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Type) set to **Single**, or [`CellSelectionMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_CellSelectionMode) set to **Flow**, are incompatible with [grouping](./grouping.md) in the pivot table.

## Clip Mode

The clip mode option in the Pivot Table determines how cell content is displayed when it exceeds the cell’s boundaries. You can set this option using the [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ClipMode) property within the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) configuration. The Pivot Table provides the following clip mode options:

- **Clip**: Cuts off any part of the cell content that does not fit within the cell.
- **Ellipsis**: Shows an ellipsis (`...`) at the end of the cell if the content is too long to fit.
- **EllipsisWithTooltip**: Shows an ellipsis (`...`) for overflowing content, and also displays the full content in a tooltip when the user hovers over the ellipsis.

> By default, the [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ClipMode) property is set to **Ellipsis**. This helps users quickly identify when there is more content hidden and easily view the complete information by hovering over the cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/clip-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ClipMode.cs" %}
{% include code-snippet/pivot-table/grid-customization/clip-mode/ClipMode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/clip-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClipMode.cs" %}
{% include code-snippet/pivot-table/grid-customization/clip-mode/ClipMode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Clip mode example](images/clipmode.png)

## Cell Template

You can change how each cell in the Pivot Table looks by using the [`CellTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CellTemplate) option. With [`CellTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CellTemplate), you can use either an HTML string or the ID of an HTML element to add custom content to every cell. This helps you display cell values in any format you prefer, such as adding icons, colors, or other elements for better understanding.

For example, in the following sample, each year's revenue cost is shown along with trend icons. This gives users a clear and quick way to see changes in data at a glance.

> The [`CellTemplate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CellTemplate) property is triggered whenever the Pivot Table report configuration is updated through code-behind or UI actions such as sorting, filtering, and more. Therefore, binding a large dataset to the Pivot Table while defining a template for this property, or assigning a complex template to it, may lead to flickering issues in the Pivot Table UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-template.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-template/cell-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-template.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-template/cell-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Pivot table cell template](images/cell_template.png)

## Events

### QueryCellInfo

The [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_QueryCellInfo) event is triggered when a row or value cell is rendered in the Pivot Table. This event gives users the ability to change the appearance or content of each table cell according to their needs. The following parameters are available within the event:

- `cell`: Provides information about the specific cell currently being rendered.
- `data`: Contains all data related to the row in which the cell appears.
- `column`: Offers information about the column for the current cell.
- `pivotview`: Refers to the current instance of the Pivot Table.
- `colSpan`: Indicates how many columns the cell should span.
- `rowSpan`: Indicates how many rows the cell should span.
- `foreignKeyData`: Displays any related row data linked through a foreign key for this column.
- `requestType`: Shows the type of action or request currently taking place.

By using these parameters in the event, users can highlight cells, format values, or display extra information to make data analysis clearer and easier in the Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/querycell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="QueryCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/querycell/QueryCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/querycell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="QueryCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/querycell/QueryCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### HeaderCellInfo

The `headerCellInfo` event is triggered when the Pivot Table renders a header cell. This event allows users to easily modify the appearance or content of each header cell as it is displayed. It includes the following parameters:

- `node`: Contains details about the current header cell’s content and structure.
- `cell`: Represents the specific cell being rendered.

By using these parameters, users can update header cell styles, add tooltips, or include icons based on their needs.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/headercell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/headercell/HeaderCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/headercell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderCell.cs" %}
{% include code-snippet/pivot-table/grid-customization/headercell/HeaderCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### ColumnRender

The [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event occurs while creating each column for display in the Pivot Table. This event lets users change how individual columns appear and behave. For example, users can set the text alignment, show or hide specific columns, enable autofit, allow reordering, and set minimum or maximum widths for each column.

The event provides the following parameters:

- `columns`: Contains information about leaf-level columns, also known as value headers.
- `dataSourceSettings`: Contains the current data source settings, such as the input data, rows, columns, values, filters, and format settings.
- `stackedColumns`: Contains information about drilled columns, including both column and value headers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/columnRender/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextWrap.cs" %}
{% include code-snippet/pivot-table/grid-customization/columnRender/ColumnRender.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/columnRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextWrap.cs" %}
{% include code-snippet/pivot-table/grid-customization/columnRender/ColumnRender.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### CellClick

The [`CellClick`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CellClick) event occurs when a user clicks a cell in the Pivot Table. With this event, users can update the style of the selected cell, edit its value, or perform other actions on the cell's content. The event provides the following parameters:

- `currentCell`: Contains details about the clicked cell.
- `data`: Contains the clicked cell’s information, such as the axis, formatted text, raw text, row header, column header, and value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellClick.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-click/CellClick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/grid-customization/cell-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellClick.cs" %}
{% include code-snippet/pivot-table/grid-customization/cell-click/CellClick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}




## See Also

* [Show/hide tooltip](./tool-tip)