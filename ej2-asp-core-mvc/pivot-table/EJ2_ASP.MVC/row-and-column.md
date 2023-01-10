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

# Row and Column in ##Platform_Name## Pivot Table Component

## Width and Height

Allows end user to set the pivot table's height and width by using [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Height) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Width) properties in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class respectively. The supported formats to set [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Height) and [`Width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Width) properties are,

* Pixel: For example - 100, 200, "100px", "200px".
* Percentage: For example - "100%", "200%".
* Auto: It is applicable for [`Height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Height) property alone in-order to render the pivot table beyond its parent container height without vertical scrollbar. The parent container here would show its vertical scrollbar as soon as the component reaches beyond its dimension.

N> The pivot table will not be displayed less than **400px**, since it's the minimum width of the component.

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



![output](images/height-width.png)

## Row Height

Allows end user to set the height of each pivot table rows commonly using the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class.

N> By default, the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property is set as **36** pixels for desktop layout and **48** pixels for mobile layout.
<br/> The height of the column headers alone may vary when grouping bar feature is enabled.

In the below code sample, the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property is set as **60** pixels.


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



![output](images/row-height.png)

## Column Width

Allows end user to set the width of each pivot table columns commonly using the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class.

N> By default, the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property is set as **110** pixels to each columns except the first column. For first column, **250** pixels and **200** pixels are set respectively with and without grouping bar.

In the below example, the [`ColumnWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnWidth) property is set as **200** pixels.

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



![output](images/column-width.png)

### Adjust width based on columns

By default, if the component width set in code-behind is more than the width of the total columns, then the columns will be stretched to make it fit. To avoid the stretching, set the [`AllowAutoResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowAutoResizing) property in the [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) to **false**. By doing so, the component will be adjusted (shrinked) based on the width of total columns.

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



![output](images/allowautoresizing.png)

## Reorder

Allows end user to reorder a particular column header from one index to another index within the pivot table through drag-and-drop option. It can be enabled by setting the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowReordering) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class to **true**.

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



![output](images/reorder.png)

## Column Resizing

Allows end user to resize the columns by clicking and dragging the right edge of the column header. While dragging, the width of the respective column will be resized immediately. To enable column resizing option, set the [`AllowResizing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowResizing) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class to **true**.

N> By default, the column resizing option is enabled.
<br/> In RTL mode, user can click and drag the left edge of the header cell to resize the column.

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



![output](images/resize.png)

## Text Wrap

Allows end user to wrap the cell content to the next line when it exceeds the boundary of the cell width. To enable text wrap, set the [`AllowTextWrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowTextWrap) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class to **true**.

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



![output](images/textwrap.png)

## Text Align

Allows end user to align the content of the pivot table's row and column headers and value cells by using the [`TextAlign`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_TextAlign) and [`HeaderTextAlign`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_HeaderTextAlign) properties in the [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event under [`GridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html). The following alignments are:

* `Left` - It allows the content to be positioned on the left.
* `Right` - It allows the content to be positioned on the right.
* `Center` - It allows the content to be positioned in the middle.
* `Justify` - It allows the content to be as flexible as possible, when the cell does not occupy the entire available area.
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

Allows the user to fit the Pivot Table columns as wide as the content of the cell without wrapping. It auto fits all of the Pivot Table columns by invoking the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method from the grid instance.

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



![output](images/autofit-method.png)

N> The minimum width of 250 pixels is set by default with the grouping bar UI for the first column and cannot be reduced further. So, when the grouping bar is enabled, one can auto fit the Pivot Table columns by calling the [`autoFitColumns`](https://ej2.syncfusion.com/documentation/api/grid/#autofitcolumns) method from the grid instance with the parameter contained pivot table columns field name excluding first column.

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



![output](images/autofit-grouping.png)

### Autofit specific columns

During initial rendering, the parameter `autoFit` in the [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) event under [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) can be set to **true** to auto fit specific columns.

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



![output](images/autofit-event.png)

## Grid Lines

Allows end user to display cell border for each cells using [`GridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_GridLines) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class.

Available mode of grid lines are:

| Modes | Actions |
|-------|---------|
| Both | Displays both the horizontal and vertical grid lines.|
| None | No grid lines are displayed.|
| Horizontal | Displays the horizontal grid lines only.|
| Vertical | Displays the vertical grid lines only.|
| Default | Displays grid lines based on the theme.|

N> By default, pivot table renders grid lines in **Both** mode.

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



![output](images/gridlines.png)

## Selection

Selection provides an option to highlight a row or a column or a cell. It can be done through simple mouse down or arrow keys. To enable selection in the pivot table, set the [`AllowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_AllowSelection) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class to **true**.

The pivot table supports two types of selection that can be set using [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Type) property in [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) class. The selection types are:

* `Single`: It is set by default, and it only allows selection of a single row or a column or a cell.
* `Multiple`: Allows you to select multiple rows or columns or cells.
To perform multi-selection, press and hold "CTRL" key and click the desired rows or cells. To select range of rows or cells, press and hold the "SHIFT" key and click the rows or columns or cells.

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



![output](images/selection.png)

### Selection Mode

The pivot table supports four types of selection mode that can be set using [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Mode) property in [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) class.. The selection modes are:

* [**SelectionMode.Row**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SelectionMode.html): It is set by default, and allows user to select only rows.
* [**SelectionMode.Column**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SelectionMode.html): Allows user to select only columns.
* [**SelectionMode.Cell**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SelectionMode.html): Allows user to select only cells.
* [**SelectionMode.Both**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SelectionMode.html): Allows user to select rows and columns at the same time.

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



![output](images/selection2.png)

### Cell Selection Mode

The pivot table supports two types of cell selection mode that can be set using [`CellSelectionMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_CellSelectionMode) in [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) class. The cell selection modes are:

* [**PivotCellSelectionMode.Flow**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotCellSelectionMode.html): It is set by default. The range of cells are selected between the start index and end index that includes in-between cells of rows.
* [**PivotCellSelectionMode.Box**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotCellSelectionMode.html): Range of cells are selected from the start and end column indexes that includes in-between cells of rows within the range.

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



N> Cell selection requires [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Mode) property in [`PivotViewSelectionSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html) class to be [**SelectionMode.Cell**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SelectionMode.html) or [**SelectionMode.Both**](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.SelectionMode.html), and [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewPivotSelectionSettings.html#Syncfusion_EJ2_PivotView_PivotViewPivotSelectionSettings_Type) property should be `Multiple`.

![output](images/cell-selection.png)

### Changing background color of the selected cell

The background-color of the selected cell can be changed using built-in CSS names. To do so, refer to the code sample below, which shows that the selected cells are changed to a **green yellow** color.

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



![output](images/cell-selection-color.png)

### Event

#### CellSelected

The event `CellSelected` is triggered when cell selection gets completed. It provides selected cells information with its corresponding column and row headers. It has following parameters - `selectedCellsInfo`, `currentCell` and `target`. This event allows user to view selected cells information and user can pass those selected cells information to any external component for data binding.

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



![output](images/cellselected_event.png)

#### CellSelecting

The event `CellSelecting` triggers before cell gets selected gets completed. It provides selected cells information with its corresponding column and row headers. It has following parameters - `currentCell`, `data` and `cancel`.

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



## Clip Mode

The clip mode provides options to display its overflow cell content in the pivot table. It can be configured using the [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ClipMode) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html) class. The pivot table supports three types of clip modes which are:

* `Clip`: Truncates the cell content when it overflows its area.
* `Ellipsis`: Displays ellipsis when the cell content overflows its area.
* `EllipsisWithTooltip`: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied.

N>By default, [`ClipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ClipMode) value is set to `Ellipsis`.

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



![output](images/clipmode.png)


## Cell Template

User can customize the pivot table cell element by using the `CellTemplate` property in `PivotViewTemplates` class. The `CellTemplate` property accepts either an HTML string or the element's ID, which can be used to append additional HTML elements to showcase each cell with custom format.

In this demo, the revenue cost for each year is represented with trend icons.

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



![output](images/cell_template.png)

## Events

### QueryCellInfo

The event `queryCellInfo` triggers while rendering each row and value cells in the pivot table. It allows the user to customize the current cell like adding or removing styles, editing value, etc. It has the following parameters:

* `cell` - It holds the current cell information.
* `data` - It holds the entire row data besides the current cell.
* `column` - It holds the entire column data besides the current cell.
* `pivotview` - It holds pivot table instance.

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

The event `headerCellInfo` triggers while rendering each column header cell in the pivot table. It allows the user to customize the element of the current header cell like adding or removing styles, editing value, etc. It has the following parameters:

* `node` - It holds the current header cell information.

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

The event [`ColumnRender`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_ColumnRender) triggers while framing each columns for rendering in the pivot table. It allows the user to customize the text alignment, column visibility, autofit, re-ordering, minimum and maximum width for a specific column. It has the following parameters:

* `columns` - It holds the leaf level columns (i.e., value headers) information.
* `dataSourceSettings` - It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.
* `name` - It holds the name of the event.
* `stackedColumns` - It holds the drilled columns (i.e., including column and value headers) information.

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

The event `CellClick` triggers while clicking a cell in the pivot table. For instance, using this event end-user can either add or remove styles, edit value and also perform any other DOM manipulations. It has the following parameters:

* `currentCell` - It holds the current cell information.
* `data` - It holds the clicked cell's data like axis, formatted text, actual text, row header, column header and value informations.

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