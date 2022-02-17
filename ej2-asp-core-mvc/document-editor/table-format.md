---
layout: post
title: Table Format in ##Platform_Name## Document Editor Component
description: Learn here all about Table Format in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Table Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Table Formatting

Document editor customizes the formatting of table, or table cells such as table width, cell margins, cell spacing, background color, and table alignment. This section describes how to customize these formatting for selected cells, rows, or table in detail.

## Cell margins

You can customize the cell margins by using the following sample code.

```typescript
//To change the left margin
documenteditor.selection.cellFormat.leftMargin=5.4;
//To change the right margin
documenteditor.selection.cellFormat.rightMargin=5.4;
//To change the top margin
documenteditor.selection.cellFormat.topMargin=5.4;
//To change the bottom margin
documenteditor.selection.cellFormat.bottomMargin=5.4;
```

You can also define the default cell margins for a table. If the specific cell margin value is not defined explicitly in the cell formatting, the corresponding value will be retrieved from default cells margin of the table. Refer to the following sample code.

```typescript
//To change the left margin
documenteditor.selection.tableFormat.leftMargin=5.4;
//To change the right margin
documenteditor.selection.tableFormat.rightMargin=5.4;
//To change the top margin
documenteditor.selection.tableFormat.topMargin=5.4;
//To change the bottom margin
documenteditor.selection.tableFormat.bottomMargin=5.4;
```

## Background color

You can explicitly set the background color of selected cells using the following sample code.

```typescript
documenteditor.selection.cellFormat.background='#E0E0E0';
```

Refer to the following sample code to customize the background color of the table.

```typescript
documenteditor.selection.tableFormat.background='#E0E0E0';
```

## Cell spacing

Refer to the following sample code to customize the spacing between each cell in a table.

```typescript
documenteditor.selection.tableFormat.cellSpacing = 2;
```

## Cell vertical alignment

The content is aligned within a table cell to `Top`, `Center`, or `Bottom`. You can customize this property of selected cells. Refer to the following sample code.

```typescript
documenteditor.selection.cellFormat.verticalAlignment= 'Bottom';
```

## Table alignment

The tables are aligned in document editor to `Left`, `Right`, or `Center`. Refer to the following sample code.

```typescript
documenteditor.selection.tableFormat.tableAlignment='Center';
```

## Cell width

Set the desired width of table cells that will be considered when the table is layouted. Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/cell-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-width.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/cell-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-width.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Table width

You can set the desired width of a table in `Point` or `Percent` type. Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table-width.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table-width.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Apply borders

Document editor exposes API to customize the borders for table cells by specifying the settings. Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/apply-borders/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Apply-borders.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/apply-borders/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Apply-borders.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Working with row formatting

Document editor allows various row formatting such as height and repeat header.

### Row height

You can customize the height of a table row as `Auto`, `AtLeast`, or `Exactly`. Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-height.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-height.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



### Header row

The header row describes the content of a table. A table can optionally have a header row. Only the first row of a table can be the header row. If the cursor position is at first row of the table, then you can define whether it as header row or not, using the following sample code.

```typescript
documenteditor.selection.rowFormat.isHeader=true;
```

### Allow row break across pages

This property is valid if a table row does not fit in the current page during table layout. It defines whether a table row can be allowed to break. If the value is false, the entire row will be moved to the start of next page. You can modify this property for selected rows using the following sample code.

```typescript
documenteditor.selection.rowFormat.allowRowBreakAcrossPages=false;
```

## See Also

* [Table properties dialog](../../document-editor/dialog#table-properties-dialog)