---
layout: post
title: Selection in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection in ASP.NET MVC Grid component

Selection in the Grid component allows you to interactively select specific cells, rows, or columns within the grid. This selection can be done through mouse clicks or arrow keys (up, down, left, and right) or touch. This feature is useful when you want to highlight, manipulate, or perform actions on specific  cells, rows, or columns within the Grid.

To disable selection in the Grid, set the [AllowSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowSelection) to **false**.

The grid supports two types of selection that can be set by using the [SelectionSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type).They are:

* **Single** - The **Single** value is set by default. Allows you to select only a single row or cell or column.
* **Multiple** - Allows you to select multiple rows or cells or columns.

To perform the multi-selection, press and hold CTRL key and click the desired rows or cells or columns.

To select range of rows or cells or columns, press and hold the SHIFT key and click the rows or cells or columns.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selection.cs" %}
{% include code-snippet/grid/selection/selection/selection.cs%}
{% endhighlight %}
{% endtabs %}

![Column Selection](../images/selection/selection-type.png)

> By default, the Grid will be rendered with only the basic features such as Grid rendering and selection.

## Selection mode

The selection mode feature allows you to choose between different modes for selecting rows or cells or both within the Grid based on your specific requirements. This feature is particularly useful when you want to highlight and manipulate specific rows or cells in the Grid.

To enable selection mode, you can set the [SelectionSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) property. The Grid component supports three types of selection modes:

* **Row** - The row value is set by default. Allows you to select rows only.

* **Cell** - Allows you to select cells only.

* **Both** - Allows you to select rows and cells at the same time.

The following example, demonstrates how to dynamically enable and change the `SelectionSettings.Mode` using the [DropDownList](https://ej2.syncfusion.com/aspnetmvc/documentation/drop-down-list/getting-started) component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selection-mode.cs" %}
{% include code-snippet/grid/selection/selection-mode/selection-mode.cs%}
{% endhighlight %}
{% endtabs %}

![Selection mode](../images/selection/selection-mode.gif)

## Touch interaction

The touch interaction feature in Grid allows you to easily interact with the grid on touch screen devices. This feature is particularly useful for improving the user experience on mobile devices and tablets, making it easier to navigate and interact with the grid's content using touch gestures.

**Single Row Selection**

When you tap on a grid row using a touch screen, the tapped row is automatically selected. This provides a straightforward way to select single rows with a touch interface.

**Multi-Row Selection**

To select multiple rows in the grid, you can utilize the multi-row selection feature. When you tap on a row, a popup is displayed, indicating the option for multi-row selection. You can tap on the popup, and then proceed to tap on the desired rows that you want to select. This allows you to select and interact with multiple rows simultaneously, as shown in the following image:

![Multi row selection](../images/selection.jpg) 

**Multi-Row or Cell Selection**

In addition to selecting multiple rows, you can also perform multi-row or cell selection in the grid. By tapping on the popup, you can choose the option for multi-row or cell selection. Once selected, you can then tap on the desired rows or cells to make the selection, as shown in the following image:

![Multi row or cell selection](../images/mselection.jpg)

> For multi-selection, it requires the selection [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) to be **Multiple**.

The following screenshot represents a Grid touch selection in the device.

![Touch Interaction](../images/touch-selection.jpg)

## Toggle selection

The toggle selection feature in the Grid component allows you to easily select and unselect specific rows, cells, or columns. With toggle selection enabled, you can easily switch the selection state of an item by clicking on it. This means that if you click on a selected row, cell, or column, it will become unselected, and vice versa.

To enable the toggle selection feature, you need to set the [SelectionSettings.EnableToggle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_EnableToggle) property to **true**.

The following example demonstrates how to enable the toggle selection for both cells and rows in a Grid using the `SelectionSettings.EnableToggle` property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/toggleselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="toggleselection.cs" %}
{% include code-snippet/grid/selection/toggleselection/toggleselection.cs%}
{% endhighlight %}
{% endtabs %}

![Toggle selection](../images/selection/selection-toggle.gif)

> * If multi selection is enabled, then first click on any selected row (without pressing Ctrl key), it will clear the multi selection and in second click on the same row, it will be unselected.
>* Toggle selection is a feature that can be applied to all types of selections. When the [CheckboxOnly](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_CheckboxOnly) property is set to **true**, it restricts the ability to select or deselect rows or cells by clicking on them.

## Clear all selection programmatically

The clear selection programmatically feature is particularly useful when you need to remove the selected rows or cells or columns from the Grid component.

To clear the selection in the component programmatically, you can use the `clearSelection` method. 

In the following example, it demonstrates how to clear all selection by calling the `clearSelection` method in the button `onclick` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection-clear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selection.cs" %}
{% include code-snippet/grid/selection/selection-clear/selection.cs%}
{% endhighlight %}
{% endtabs %}

![Clear all selection programmatically](../images/selection/selection-clear.gif)

> In **Both** mode, if you call `clearCellSelection` first, it will clear cell selections, and then if you call `clearRowSelection`, it will clear row selections. The order of method calls determines which type of selection is cleared first.
> To remove a specific selection in a row, cell, or column, utilize the following methods: `clearRowSelection` for clearing row selections, `clearCellSelection` for clearing cell selections, and `clearColumnSelection` for clearing column selections.

## Persist selection 

Persist selection feature in the Grid allows you to retain the selected items even after data manipulation or refreshing the grid. This feature is useful when you want to keep track of the selected items across different grid operations.

To enable persist selection, set the [SelectionSettings.PersistSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_PersistSelection) property to **true**.

> * While using persist selection feature, at least one column in your grid should be enabled as a primary key. This ensures that the grid can identify and persist the selected items correctly.
>* The `PersistSelection` feature is not supported for cell selections in the Syncfusion ASP.NET MVC Grid component.
>* The `PersistSelection` feature is only supported for grid `multiple` type selections.

In the following example, it demonstrates how to enable the persist selection feature for both rows and columns using the `SelectionSettings.PersistSelection` property :

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selection-persist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selection.cs" %}
{% include code-snippet/grid/selection/selection-persist/selection.cs%}
{% endhighlight %}
{% endtabs %}

![Persist selection](../images/selection/selection-persist.gif)