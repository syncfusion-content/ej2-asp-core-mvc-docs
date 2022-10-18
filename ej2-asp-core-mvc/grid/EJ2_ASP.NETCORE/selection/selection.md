---
layout: post
title: Selection in ##Platform_Name## Grid Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection

Selection provides an option to highlight a row or a cell. It can be done through simple mouse down or arrow keys. To disable selection in the Grid, set the [`allowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowSelection) property to false.

The grid supports two types of selection that can be set by using the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property of **e-grid-selectionsettings** tag helper. They are:

* **Single**: The **Single** value is set by default, and it only allows selection of a single row or a cell or a column.
* **Multiple**: Allows you to select multiple rows or cells or columns. To perform the multi-selection, press and hold CTRL key and click the desired rows or cells or columns. To select range of rows or cells or columns, press and hold the SHIFT key and click the rows or cells or columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/grid/selection/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/grid/selection/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection mode

The grid supports three types of selection mode that can be set by using the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) property of **e-grid-selectionsettings** tag helper. They are:

* **Row**: The **Row** value is set by default, and allows you to select only rows.
* **Cell**: Allows you to select only cells.
* **Both**: Allows you to select rows and cells at the same time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-mode.cs" %}
{% include code-snippet/grid/selection/selection-mode/selection-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-mode.cs" %}
{% include code-snippet/grid/selection/selection-mode/selection-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Touch interaction

When you tap a grid row on touchscreen device, the tapped row is selected.
It also shows a popup ![selection](../../images/selection.jpg) for multi-row selection.
To select multiple rows or cells, tap the popup![mselection](../../images/mselection.jpg) and then tap the desired rows or cells.

> Multi-selection requires the selection **type** to be **Multiple**.

The following screenshot represents a grid touch selection in the device.

![Touch interaction](../../images/touch-selection.jpg)