---
title: "Cell"
component: "TreeGrid"
description: "Learn how to customize the TreeGrid cells with styling, text wrapping, and tooltips."
---

# Cell

## Displaying the HTML content

The HTML tags can be displayed in the TreeGrid header and content by enabling the [`DisableHtmlEncode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisableHtmlEncode.html) property.

{% aspTab template="tree-grid/cell/html-encode", sourceFiles="htmlEncode.cs" %}

{% endaspTab %}

## Customize cell styles

The appearance of cells can be customized by using the [`QueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~QueryCellInfo.html) event.
The [`QueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~QueryCellInfo.html) event triggers for every cell. In that event handler, you can get **QueryCellInfoEventArgs** that contains the details of the cell.

{% aspTab template="tree-grid/cell/query-cell", sourceFiles="queryCell.cs" %}

{% endaspTab %}

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.

<!--  Auto wrap

The auto wrap allows the cell content of the treegrid to wrap to the next line when it exceeds the boundary of the cell width. The Cell Content wrapping works based on the position of white space between words.
To enable auto wrap, set the [`allowTextWrap`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowTextWrap.html) property to `true`.
You can configure the auto wrap mode by setting the [`textWrapSettings.wrapMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~TextWrapSettings.html) property.

There are three types of `wrapMode`. They are:

* **`Both`**: `Both` value is set by default. Auto wrap will be enabled for both the content and the header.
* **`Header`**: Auto wrap will be enabled only for the header.
* **`Content`**: Auto wrap will be enabled only for the content.

Note: When a column width is not specified, then auto wrap of columns will be adjusted with respect to the treegrid's width.

In the following example, the `textWrapSettings.wrapMode` is set to `Content`.

{% aspTab template="tree-grid/cell/auto-wrap", sourceFiles="autoWrap.cs" %}

{% endaspTab %}

 Custom Attributes

You can customize the treegrid cells by adding a CSS class to the [`customAttribute`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~CustomAttributes.html) property of the column.

```CSS
.e-attr {
    background: '#d7f0f4';
}
```

In the below example, we have customized the cells of `TaskID` and `StartDate` columns.

{% aspTab template="tree-grid/cell/custom-attr", sourceFiles="customAttr.cs" %}

{% endaspTab %}

 Grid Lines

The [`gridLines`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~GridLines.html) have option to display cell border and it can be defined by the
[`gridLines`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~GridLines.html) property.

The available modes of grid lines are:

| Modes | Actions |
|-------|---------|
| Both | Displays both the horizontal and vertical grid lines.|
| None | No grid lines are displayed.|
| Horizontal | Displays the horizontal grid lines only.|
| Vertical | Displays the vertical grid lines only.|
| Default | Displays grid lines based on the theme.|

{% aspTab template="tree-grid/cell/grid-lines", sourceFiles="gridLines.cs" %}

{% endaspTab %}

>By default, the treegrid renders with `Default` mode.

 Clip Mode

The clip mode provides options to display its overflow cell content and it can be defined by the [`columns.clipMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ClipMode.html) property.

There are three types of [`clipMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ClipMode.html). They are:

* **`Clip`**: Truncates the cell content when it overflows its area.
* **`Ellipsis`**: Displays ellipsis when the cell content overflows its area.
* **`EllipsisWithTooltip`**: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied.

{% aspTab template="tree-grid/cell/clip-mode", sourceFiles="clipMode.cs" %}

{% endaspTab %}

>By default, [`columns.clipMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ClipMode.html) value is `Ellipsis`.

-->