---
layout: post
title: Column Selection in ##Platform_Name## Grid Component
description: Learn here all about Column Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Selection in ASP.NET MVC Grid component

Column selection in grid component allows you to select one or more columns using mouse interactions or arrow keys. This feature is useful when you want to highlight, manipulate, or perform actions on specific columns within the Grid.

To enable column selection in the Grid, you need to set the [SelectionSettings.AllowColumnSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_AllowColumnSelection) property to **true**. 

Here's an example of how to enable column selection using `AllowColumnSelection` property in the Grid component:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-selection/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Column Selection](../images/selection/column-selection.png)

## Single column selection 

The ASP.NET MVC Grid allows you to select a single column within the Grid. This feature is particularly useful when you want to focus on specific columns or perform actions on the data within a particular column.

To enable single column selection, set the [SelectionSettings.AllowColumnSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_AllowColumnSelection) property to **true**. This property enables column selection and set the [SelectionSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property to **Single**. This configuration allows you to select a single column at a time within the grid.

Here's an example of how to enable single column selection using `AllowColumnSelection` and `Type` property :

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-single-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-single-selection/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Single column selection](../images/selection/column-single.gif)

## Multiple column selection 

The ASP.NET MVC Grid allows you to select multiple columns within the Grid. This feature is particularly useful when you need to focus on or perform actions on several columns simultaneously.

To enable multiple column selection, set the [SelectionSettings.AllowColumnSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_AllowColumnSelection) property to **true**. This property enables column selection and set the [SelectionSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property to **Multiple**. This configuration allows you to select a multiple column at a time within the grid.

Here's an example of how to enable multiple column selection using `AllowColumnSelection` and `Type` property :

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-multiple-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-multiple-selection/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Multiple column selection](../images/selection/column-multiple.png)

## Select columns externally 

You can perform single column selection, multiple column selection, and range of column selection externally in a Grid using built-in methods. This feature allows you to interact with specific columns within the Grid. The following topic demonstrates how you can achieve these selections using methods.

### Single column selection

The ASP.NET MVC grid allows you to select a single column within the Grid. This feature is particularly useful when you want to focus on specific columns or perform actions on the data within a particular column.

To achieve single column selection, you can use the `selectColumn` method. This method selects the column by passing the column index as a parameter.

> Column selection requires the [SelectionSettings.AllowColumnSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_AllowColumnSelection) property to **true** and [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) should be **Single**.

The following example, demonstrates how to select a single column within the Grid by obtaining the selected column index through a textbox component and passing these column index as argument to the `selectColumn` method. When the button event is triggered by clicking the **Select Column** button, a single column is selected within the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-single-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-single-method/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Single column selection](../images/selection/column-single-method.png)

### Multiple column selection

The ASP.NET MVC Grid allows you to select multiple columns within the Grid. This feature is particularly useful when you need to focus on or perform actions on several columns simultaneously.

To achieve multiple column selection, you can use the `selectColumns` method. This method selects the columns by passing an array of column indexes as a parameter.

> Column selection requires the [SelectionSettings.AllowColumnSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_AllowColumnSelection) property to **true** and [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) should be **Multiple**.

The following example demonstrates how to select multiple columns in the Grid by calling the `selectColumns` method within the button click event and passing an array of column indexes as arguments.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-multiple-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-multiple-method/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Multiple column selection](../images/selection/column-multiple-method.png)

### Range of column selection 

Range of column selection allows you to select a group of columns within the Grid. This feature is particularly useful when you need to perform actions on a consecutive set of columns or focus on specific column ranges.

To achieve range of column selection, you can use the `selectColumnsByRange` method. This method selects the columns by specifying the start and end column indexes.

The following example demonstrates how to select a range of columns within the Grid by obtaining the selected column's start index and end index through textbox components. Then, pass these start index and end index as arguments to the `selectColumnsByRange` method. When you trigger the button event by clicking the **Select Columns** button, a range of columns is selected within the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-range/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Range of column selection](../images/selection/column-range.png)

### Select with existing column 

Select with existing column allows you to add a column to the current selection without clearing the existing column selection in the Grid component. This feature is valuable when you want to expand your selection to include additional columns while preserving previously selected columns.

To achieve this, you can use the `selectColumnWithExisting` method. This method selects a column along with an existing column by specifying the column index as a parameter.

The following example demonstrates how to select a column with an existing column by obtaining the selected column index through a textbox component and passing this column index as an argument to the `selectColumnWithExisting` method. When you trigger the button event by clicking the **Select Columns** button,  it selects the specified column along with any existing selections within the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-existing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-existing/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Select with existing column](../images/selection/column-exisiting.gif)

##  Clear column selection programmatically 

Clearing column selection programmatically in the Grid component is a useful feature when you want to remove any existing column selections. To achieve this, you can use the `clearColumnSelection` method.

>The `clearColumnSelection` method is applicable when the selection [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) is set to **Multiple** or **Single**.

In the following example, it demonstrates how to clear column selection by calling the `clearColumnSelection` method in the button click event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-clear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-clear/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Clear column selection programmatically](../images/selection/column-clear.gif)

## Column selection events 

The Grid provides several events related to column selection that allow you to respond to and customize the behavior of column selection. Here are the available column selection events:

[ColumnSelecting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnSelecting): This event is triggered before any column selection occurs. It provides an opportunity to implement custom logic or validation before a column is selected, allowing you to control the selection process.

[ColumnSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnSelected): This event is triggered after a column is successfully selected. You can use this event to perform actions or updates when a column is selected.

[ColumnDeselecting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnDeselecting): This event is triggered just before a selected column is deselected. It allows you to perform custom logic or validation to decide whether the column should be deselected or not.

[ColumnDeselected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ColumnSelected): This event is triggered when a particular selected column is deselected. You can use this event to perform actions or validations when a column is no longer selected.

In the following example, column selection is canceled when the value of `Field` is equal to **CustomerID** within the `ColumnSelecting` event. The **headerCell** background color changes to green when the `ColumnSelected` event is triggered, and it changes to red when the `ColumnDeselecting` event is triggered. Furthermore, column selection is canceled when the value of `Field` is equal to **CustomerID** within the `ColumnDeselected` event is triggered. A notification message is displayed to indicate which event was triggered whenever a column is selected.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/column-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-selection.cs" %}
{% include code-snippet/grid/selection/column-events/column-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Column selection events](../images/selection/column-events.gif)

