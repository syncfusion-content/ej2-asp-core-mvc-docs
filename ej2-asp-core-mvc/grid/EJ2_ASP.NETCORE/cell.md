---
layout: post
title: Cell in ##Platform_Name## Grid Component
description: Learn here all about Cell in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Cell
publishingplatform: ##Platform_Name##
documentation: ug
---


# Cell

## Displaying the HTML content

The HTML tags can be displayed in the Grid header and content by enabling the [`disableHtmlEncode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DisableHtmlEncode) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/html/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/html/html.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/html/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/html/html.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize cell styles

The appearance of cells can be customized by using the [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event.

The [`queryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event triggers for every cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/grid/cell/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/grid/cell/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Auto wrap

The auto wrap allows the cell content of the grid to wrap to the next line when it exceeds the boundary of the cell width. The Cell Content wrapping works based on the position of white space between words.
To enable auto wrap, set the [`allowTextWrap`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property to `true`.
You can configure the auto wrap mode by setting the [`wrapMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode) property of **e-grid-textwrapsettings** tag helper.

There are three types of [`wrapMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode). They are:

* **Both**: Both value is set by default. Auto wrap will be enabled for both the content and the header.
* **Header**: Auto wrap will be enabled only for the header.
* **Content**: Auto wrap will be enabled only for the content.

> When a column width is not specified, then auto wrap of columns will be adjusted with respect to the grid's width.

In the following example, the [`wrapMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridTextWrapSettings.html#Syncfusion_EJ2_Grids_GridTextWrapSettings_WrapMode) is set to **Content**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/autowrap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/grid/cell/autowrap/autowrap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/autowrap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autowrap.cs" %}
{% include code-snippet/grid/cell/autowrap/autowrap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Attributes

You can customize the grid cells by adding a CSS class to the [`customAttribute`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_CustomAttributes) property of **e-grid-column** tag helper.

```CSS
.e-attr {
    background: #d7f0f4;
}
```

In the below example, we have customized the cells of **OrderID** and **ShipCity** columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customAttribute/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomStyle.cs" %}
{% include code-snippet/grid/cell/customAttribute/customStyle.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/customAttribute/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomStyle.cs" %}
{% include code-snippet/grid/cell/customAttribute/customStyle.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Grid Lines

The **GridLines** have option to display cell border and it can be defined by the
[`gridLines`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_GridLines) property.

The available modes of grid lines are:

| Modes | Actions |
|-------|---------|
| Both | Displays both the horizontal and vertical grid lines.|
| None | No grid lines are displayed.|
| Horizontal | Displays the horizontal grid lines only.|
| Vertical | Displays the vertical grid lines only.|
| Default | Displays grid lines based on the theme.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/gridlines/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gridlines.cs" %}
{% include code-snippet/grid/cell/gridlines/gridlines.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/gridlines/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gridlines.cs" %}
{% include code-snippet/grid/cell/gridlines/gridlines.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>By default, the grid renders with **Default** mode.

## Clip Mode

The clip mode provides options to display its overflow cell content and it can be defined by the [`clipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) property of **e-grid-column** tag helper.

There are three types of **ClipMode**. They are:

* **Clip**: Truncates the cell content when it overflows its area.
* **Ellipsis**: Displays ellipsis when the cell content overflows its area.
* **EllipsisWithTooltip**: Displays ellipsis when the cell content overflows its area, also it will display the tooltip while hover on ellipsis is applied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/clipmode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/grid/cell/clipmode/clipmode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/clipmode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clipmode.cs" %}
{% include code-snippet/grid/cell/clipmode/clipmode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>By default, [`clipMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.ClipMode.html) value is **Ellipsis**.