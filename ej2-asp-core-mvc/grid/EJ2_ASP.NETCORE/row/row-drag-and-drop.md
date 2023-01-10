---
layout: post
title: Row Drag And Drop in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Row Drag And Drop in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and Drop in ASP.NET Core Grid Component

The grid row drag and drop allows you to drag and drop grid rows to another grid or custom component. To enable row drag and drop, set the [`allowRowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowRowDragAndDrop) property to true. The target component where the grid rows are to be dropped can be set by using the **TargetID**.

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



> * Selection feature must be enabled for row drag and drop.
> * Multiple rows can be selected by clicking and dragging inside the grid.
For multiple row selection, the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property of **e-grid-selectionsettings** must be set to **Multiple**.

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



## Drag and drop rows without drag icon

You can hide the drag and drop icon when performing a drag and drop operation within the grid. This can be achieved by setting the [targetID](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridRowDropSettings.html#Syncfusion_EJ2_Grids_GridRowDropSettings_TargetID) of the [rowDropSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDropSettings) as the current Grid’s ID.

By setting the [targetID](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridRowDropSettings.html#Syncfusion_EJ2_Grids_GridRowDropSettings_TargetID), the Grid will render without a helper icon (for row drag). Now you can customize the drag and drop action. To control the drop action, you can bind the [rowDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDrop) event of the Grid. In the [rowDrop](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDrop) event, you can prevent the default action(args.cancel as true) and reorder the rows using `reorderRows` method of the Grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/drag-drop-withouticon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drag-drop-withouticon.cs" %}
{% include code-snippet/grid/row/drag-drop-withouticon/drag-drop-withouticon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/drag-drop-withouticon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Drag-drop-withouticon.cs" %}
{% include code-snippet/grid/row/drag-drop-withouticon/drag-drop-withouticon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations of row drag and drop

* Multiple rows can be drag and drop in the row selections basis.
* Single row is able to drag and drop in same grid without enable the row selection.
* Row drag and drop feature is not having built in support with sorting, filtering, hierarchy grid and grouping features of grid.