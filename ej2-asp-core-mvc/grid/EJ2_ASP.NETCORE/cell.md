---
layout: post
title: Cell in ##Platform_Name##  Syncfusion Grid Component
description: Learn here all about Cell in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Cell
publishingplatform: ##Platform_Name##
documentation: ug
---

# Cell in ASP.NET Core Syncfusion Grid component

In the Syncfusion ASP.NET Core Grid, a **cell** refers to an individual data point or a unit within a grid column that displays data. It represents the intersection of a row and a column, and it contains specific information associated with that row and column. Each cell can display text, numbers, or other content related to the data it represents. 

The Grid component allows you to customize the appearance and behavior of cells using various features and options. You can define templates, format cell values, enable or disable editing, and perform various other operations on the cells to create interactive and informative data grids in your web applications.

## Displaying the HTML content

Displaying HTML content in a Grid can be useful in scenarios where you want to display formatted content, such as images, links, or tables, in a tabular format. Grid component allows you to display HTML tags in the Grid header and content. By default, the HTML content is encoded to prevent potential security vulnerabilities. However, you can enable the `disableHtmlEncode` property by setting the value as **false** to display HTML tags without encoding. This feature is useful when you want to display HTML content in a grid cell.

In the following example, the [EJ2 Toggle Switch Button](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) component is added  to enable and disable the `disableHtmlEncode` property. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered and the `disableHtmlEncode` property of the column is updated accordingly. The `refreshColumns` method is called to refresh the grid and display the updated content.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/display-html-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/display-html-content/html.cs %}
{% endhighlight %}
{% endtabs %}

![Display HTML content](images/cell/display-html-content.gif)

> * The `disableHtmlEncode` property disables HTML encoding for the corresponding column in the grid. 
> * If the property is set to **true**, any HTML tags in the column's data will be displayed. 
> * If the property is set to **false**, the HTML tags will be removed and displayed as plain text.
> * Disabling HTML encoding can potentially introduce security vulnerabilities, so use caution when enabling this feature.
> * If [enableHtmlSanitizer](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableHtmlSanitizer) property of grid is set to true, then the content is sanitized to prevent any potential security vulnerabilities.
> * You can also disable the `disableHtmlEncode` property of the column using `getColumns` method on [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event of Switch component.This is demonstrated in the below code snippet, 

```javascript
function change(args) {
  if (args.checked) {
    grid.getColumns()[1].disableHtmlEncode = false;
  } else {
    grid.getColumns()[1].disableHtmlEncode = true;
  }
  grid.refresh();
}
```

## Autowrap the content

The auto wrap feature allows the cell content in the grid to wrap to the next line when it exceeds the boundary of the specified cell width. The cell content wrapping works based on the position of white space between words. To support the Autowrap functionality in Syncfusion Grid, you should set the appropriate [width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) for the columns. The column width defines the maximum width of a column and helps to wrap the content automatically.

To enable auto wrap, set the [allowTextWrap](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property to **true**. You can also configure the wrap mode by setting the [wrapMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode) property.

Grid provides the below three options for configuring:

* **Both** - This is the default value for wrapMode. With this option, both the grid **Header** and **Content** text is wrapped.
* **Header** - With this option, only the grid header text is wrapped.
* **Content** - With this option, only the grid content is wrapped.

The following example demonstrates how to set the `allowTextWrap` property to **true** and specify the wrap mode as **Content** by setting the `wrapMode` property. Also change the `wrapMode` property to **Content** and **Both** on changing the dropdown value using the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the DropDownList component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/autowrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/grid/cell/autowrap/autowrap.cs %}
{% endhighlight %}
{% endtabs %}

![Auto Wrap the content ](images/cell/auto-wrap.png)

> * If a column width is not specified, then the Autowrap of columns will be adjusted with respect to the grid's width.
> * If a column's header text contains no white space, the text may not be wrapped.
> * If the content of a cell contains HTML tags, the Autowrap functionality may not work as expected. In such cases, you can use the `headerTemplate` and `template` properties of the column to customize the appearance of the header and cell content.

## Customize cell styles

Customizing the grid cell styles allows you to modify the appearance of cells in the Grid control to meet your design requirements. You can customize the font, background color, and other styles of the cells. To customize the cell styles in the grid, you can use grid event, css, property or method support.

### Using event

To customize the appearance of the grid cell, you can use the [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event of the grid. This event is triggered when each header cell is rendered in the grid, and provides an object that contains information about the header cell. You can use this object to modify the styles of the header cell.

The following example demonstrates how to add a `queryCellInfo` event handler to the grid. In the event handler, checked whether the current column is **Freight** field and then applied the appropriate CSS class to the cell based on its value.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customize-cell-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/customize-cell-cs1/customize.cs %}
{% endhighlight %}
{% endtabs %}

![Customize cell using event](images/cell/customize-cell-using-event.png)

> * The [queryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event is triggered for every cell of the grid, so it may impact the performance of the grid whether used to modify a large number of cells.

### Using CSS

You can apply styles to the cells using CSS selectors. The Grid provides a class name for each cell element, which you can use to apply styles to that specific cell or cells in a particular column. The `e-rowcell` class is used to style the row cells, and the `e-selectionbackground` class is used to change the background color of the selected row.

```CSS
.e-grid td.e-cellselectionbackground {
  background: #9ac5ee;
  font-style: italic;
}
```

The following example demonstrates how to customize the appearance of a specific row in the grid on selection using `className`. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customize-cell-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/customize-cell-cs2/customize.cs %}
{% endhighlight %}
{% endtabs %}

![Customize cell using css](images/cell/customize-cell-using-css.png)

### Using property

To customize the style of grid cells, define `customAttributes` property to the column definition object. The `customAttributes` property takes an object with the name-value pair to customize the CSS properties for grid cells. You can also set multiple CSS properties to the custom class using the `customAttributes` property.

```CSS
.custom-css {
  background: #d7f0f4;
  font-style: italic;
  color:navy
}
```
Here, setting the `customAttributes` property of the **ShipCity** column to an object that contains the CSS class **'custom-css'**. This CSS class will be applied to all the cells in the **ShipCity** column of the grid.

```html
    <e-grid-column field="ShipCity" headerText="Ship City" width="100" customAttributes=@(new{@class="custom-css"
        })></e-grid-column>
```
The following example demonstrates how to customize the appearance of the **OrderID** and **ShipCity** columns using custom attributes. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customize-cell-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/customize-cell-cs3/customize.cs %}
{% endhighlight %}
{% endtabs %}

![Customize cell using property](images/cell/customize-cell-using-property.png)

> Custom attributes can be used to customize any cell in the grid, including header and footer cells.

### Using methods

The Grid provides below methods to customize the appearance of the grid columns header and cell:

1. **getHeaderContent**: The `getHeaderContent` method is used to customize the appearance of the column header in the grid and accessing the header element using the `querySelector` method and applying the style using the style property of the cell element.

2. **getCellFromIndex**: The `getCellFromIndex` method is used to customize the appearance of a specific cell in the grid by specifying the index of the row and column for which you want to customize the appearance.

The following example demonstrates how to use getColumnHeaderByIndex and getCellFromIndex methods to customize the appearance of the **CustomerID** column header and specific cell inside the [dataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customize-cell-cs4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/customize-cell-cs4/customize.cs %}
{% endhighlight %}
{% endtabs %}

![Customize cell using property](images/cell/customize-cell-using-method.png)

> Make sure to pass the correct row and column indices to `getCellFromIndex` method, or else the appearance of the wrong cell might get customized.

## Clip Mode

The clip mode feature is useful when you have a long text or content in a grid cell, which overflows the cell's width or height. It provides options to display the overflow content by either truncating it, displaying an ellipsis or displaying an ellipsis with a tooltip. You can enable this feature by setting [clipMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) property to one of the below available options.

There are three types of `clipMode` available:

* **Clip**: Truncates the cell content when it overflows its area.
* **Ellipsis**: Displays ellipsis when the cell content overflows its area.
* **EllipsisWithTooltip**: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied. Also it will display the tooltip while hover on ellipsis is applied.

The following example demonstrates, how to set the `clipMode` property to **Clip** , **Ellipsis** and **EllipsisWithTooltip** for the **Main Fields of Invention** column, on changing the dropdown value using the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the `DropDownList` component. The `refresh` method is used to refresh the grid and display the updated content.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/clipmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/grid/cell/clipmode/clipmode.cs %}
{% endhighlight %}
{% endtabs %}

![Clip Mode](images/cell/clip-mode.gif)

> * By default, `clipMode` value is **Ellipsis**.
> * If you set the [width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Width) property of a column, the clip mode feature will be automatically applied to that column if the content exceeds the specified width.
> * Be careful when using the Clip mode, as it may result in important information being cut off. It is generally recommended to use the Ellipsis or EllipsisWithTooltip modes instead.

## Tooltip

The Syncfusion Grid allows you to display information about the grid columns to the user when they hover over them with the mouse.

### Render bootstrap tooltip in grid cells

The Grid control allows rendering Bootstrap tooltips in the cells. To enable this feature, you need to add the Bootstrap CDN link and call the tooltip() method to initialize the tooltip. 

This is demonstrated in the sample code below which shows how to enable Bootstrap tooltip for the **CustomerID** field using `template` property in grid cells,

Step 1: Add the CDN link of Boostrap in the `_Layout.cshtml` file. Place the `link` tag in the `head` for the CSS. 

```html

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

```

Step 2: The following code demonstrates how to render Bootstrap tooltip for the **CustomerID** field with `template` on grid cells.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="tooltip.cs" %}
{% include code-snippet/grid/cell/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

The following screenshot represents the Bootstrap tooltip for the **CustomerID** field,

![ Render bootstrap tooltip in grid](images/cell/render-tooltip.png)

> * The Bootstrap CDN link must be added to the HTML file.

### Display custom tooltip for columns

The Grid provides a feature to display custom tooltips for its columns using the `EJ2 Tooltip` component. This allows you to provide additional information about the columns when the user hovers over them.

To enable custom tooltips for columns in the Grid, you can render the Grid control inside the Tooltip component and set the target as `.e-rowcell`. This will display the tooltip when hovering over the grid cells.

Change the tooltip content for the grid cells by using the following code in the [beforeRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Tooltip.html#Syncfusion_EJ2_Popups_Tooltip_BeforeRender) event.

```typescript
 beforeRender(args): void {
    if (args.target.classList.contains('e-rowcell')) {
        // event triggered before render the tooltip on target element.
        this.tooltip.content = 'This is value "' + args.target.innerText + '" ';
    }
  }

```

The following example demonstrates how to customize the tooltip content for the grid cells by using the `beforeRender` event of the EJ2 Tooltip component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/custom-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="tooltip.cs" %}
{% include code-snippet/grid/cell/custom-tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

![Display custom tooltip](images/cell/custom-tooltip.png)

## Grid lines

The [gridLines](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GridLines) in a grid are used to separate the cells with horizontal and vertical lines for better readability. You can enable the grid lines by setting the `gridLines` property to one of the following values:

| Modes      | Actions                                               |
| ---------- | ----------------------------------------------------- |
| Both       | Displays both the horizontal and vertical grid lines. |
| None       | No grid lines are displayed.                          |
| Horizontal | Displays the horizontal grid lines only.              |
| Vertical   | Displays the vertical grid lines only.                |
| Default    | Displays grid lines based on the theme.               |

The following example demonstrates how to set the `gridLines` property based on changing the dropdown value using the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the DropDownList component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/gridlines/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gridlines.cs" %}
{% include code-snippet/grid/cell/gridlines/gridlines.cs %}
{% endhighlight %}
{% endtabs %}

![Grid Lines](images/cell/grid-lines.gif)
