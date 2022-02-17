---
layout: post
title: Row in ##Platform_Name## Grid Component
description: Learn here all about Row in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Row
publishingplatform: ##Platform_Name##
documentation: ug
---


# Row

The row represents record details fetched from data source.

## Row template

The [`RowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) has an option to customise the look and behavior of the grid rows. The [`RowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property accepts either
the template string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`RowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property accepts only the TR element.

## Detail template

The detail template provides additional information about a particular row by expanding or collapsing detail content. The [`DetailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) property accepts either
the template string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/detail-temp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-temp.cs" %}
{% include code-snippet/grid/row/detail-temp/detail-temp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/detail-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-temp.cs" %}
{% include code-snippet/grid/row/detail-temp/detail-temp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Rendering custom component

To render the custom component inside the detail row, define the template in the [`DetailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) and render the
component in the [`DetailDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailDataBound) event.

For example, to render grid inside the detail row, place an HTML div element as the [`DetailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailTemplate) and render the DIV element as grid component in the [`DetailDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DetailDataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-component/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-component.cs" %}
{% include code-snippet/grid/row/custom-component/custom-component.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-component.cs" %}
{% include code-snippet/grid/row/custom-component/custom-component.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Expand by external button

By default, detail rows render in collapsed state. You can expand a detail row by invoking the **expand** method using the external button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/expand-external/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Expand-external.cs" %}
{% include code-snippet/grid/row/expand-external/expand-external.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/expand-external/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Expand-external.cs" %}
{% include code-snippet/grid/row/expand-external/expand-external.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can expand all the rows by using **expandAll** method.
> If you want to expand all the rows at initial Grid rendering, then use **expandAll** method in [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of the Grid.

## Drag and drop

The grid row drag and drop allows you to drag and drop grid rows to another grid or custom component. To enable row drag and drop, set the [`AllowRowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowRowDragAndDrop) to true.
The target component where the grid rows are to be dropped can be set by using
the **TargetID**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/drag-drop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drag-drop.cs" %}
{% include code-snippet/grid/row/drag-drop/drag-drop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/drag-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drag-drop.cs" %}
{% include code-snippet/grid/row/drag-drop/drag-drop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Selection feature must be enabled for row drag and drop.
> Multiple rows can be selected by clicking and dragging inside the grid.
For multiple row selection, the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property of [`SelectionSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html) must be set to **Multiple**.

## Drag and drop within Grid

The grid row drag and drop allows you to drag and drop grid rows on the same grid using drag icon. To enable row drag and drop, set the [`AllowRowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowRowDragAndDrop) to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/drag-drop-same-grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drag-drop-same-grid.cs" %}
{% include code-snippet/grid/row/drag-drop-same-grid/drag-drop-same-grid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/drag-drop-same-grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drag-drop-same-grid.cs" %}
{% include code-snippet/grid/row/drag-drop-same-grid/drag-drop-same-grid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations of Row Drag and Drop

* Multiple rows can be drag and drop in the row selections basis.
* Single row is able to drag and drop in same grid without enable the row selection.
* Row drag and drop feature is not having built in support with sorting, filtering, hierarchy grid and grouping features of grid.

## Customize rows

You can customize the appearance of a row by using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.
The [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event triggers for every row. In the event handler, you can get the **RowDataBoundEventArgs** that contains details of the row.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-rows.cs" %}
{% include code-snippet/grid/row/custom-rows/custom-rows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/custom-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-rows.cs" %}
{% include code-snippet/grid/row/custom-rows/custom-rows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Styling alternate rows

You can change the grid's alternative rows' background color by overriding the **.e-altrow** class.

```css
.e-grid .e-altrow {
    background-color: #fafafa;
}
```

Please refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/style-alt-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Style-alt-row.cs" %}
{% include code-snippet/grid/row/style-alt-row/style-alt-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/style-alt-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Style-alt-row.cs" %}
{% include code-snippet/grid/row/style-alt-row/style-alt-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Row height

You can customize the row height of grid rows through the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property. The [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) property
is used to change the row height of entire grid rows.

In the below example, the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) is set as 60px.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-height.cs" %}
{% include code-snippet/grid/row/row-height/row-height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-height.cs" %}
{% include code-snippet/grid/row/row-height/row-height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customize row height for particular row

Grid row height for particular row can be customized using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound)
event by setting the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowHeight) in arguments for each row based on the requirement.

In the below example, the row height for the row with OrderID as '10249' is set as '90px' using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rowheight-particular/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowheight-particular.cs" %}
{% include code-snippet/grid/row/rowheight-particular/rowheight-particular.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/rowheight-particular/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowheight-particular.cs" %}
{% include code-snippet/grid/row/rowheight-particular/rowheight-particular.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> In virtual scrolling mode, it is not applicable to set the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) using the [`RowDataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event.

## See Also

* [How to set textbox and Grid in one row in ASP.NET MVC Grid](https://www.syncfusion.com/forums/164975/how-to-set-textbox-and-grid-in-one-row-in-asp-net-mvc-grid)