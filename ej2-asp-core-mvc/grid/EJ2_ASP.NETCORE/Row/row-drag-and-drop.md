---
layout: post
title: Row Drag And Drop in ##Platform_Name## Grid Component
description: Learn here all about Row Drag And Drop in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Row Drag And Drop
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and Drop

The grid row drag and drop allows you to drag and drop grid rows to another grid or custom component. To enable row drag and drop, set the [`allowRowDragAndDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowRowDragAndDrop) property to true.
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



## Limitations of row drag and drop

* Multiple rows can be drag and drop in the row selections basis.
* Single row is able to drag and drop in same grid without enable the row selection.
* Row drag and drop feature is not having built in support with sorting, filtering, hierarchy grid and grouping features of grid.