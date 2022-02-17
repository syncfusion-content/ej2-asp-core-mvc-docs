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

## Cell customization

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



## Custom attributes

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



## Grid lines

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
