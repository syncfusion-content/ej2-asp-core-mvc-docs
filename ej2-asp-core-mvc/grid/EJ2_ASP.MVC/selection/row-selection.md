---
layout: post
title: Row Selection in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Row Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row selection in ASP.NET MVC Grid component

Row selection in the Grid component allows you to interactively select specific rows or ranges of rows within the grid. This selection can be done effortlessly through mouse clicks or arrow keys (up, down, left, and right). This feature is useful when you want to highlight, manipulate, or perform actions on specific row within the Grid.

> To enable row selection, you should set the [SelectionSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) property to either **Row** or **Both**. This property determines the selection mode of the grid.

## Single row selection 

Single row selection allows you to select a single row at a time within the Grid. This feature is useful when you want to focus on specific rows or perform actions on the data within a particular row.

To enable single row selection, set the [SelectionSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) property to **Row** and the [SelectionSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property to **Single**. This configuration allows you to select a only one row at a time within the grid.

Here's an example of how to enable single row selection using properties:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-single-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-single-selection/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Single row selection](../../images/selection/row-single-selection.png)

## Multiple row selection 

Multiple row selection allows you to select multiple rows within the Grid. This feature is valuable when you need to perform actions on several rows simultaneously or focus on specific data areas.

To enable multiple row selection, set the [SelectionSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) property to **Row** and the [SelectionSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) property to **Multiple**. This configuration allows you to select a multiple rows at a time within the grid.

Here's an example of how to enable multiple rows selection using properties:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-multiple-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-multiple-selection/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Multiple row selection](../../images/selection/row-multiple.png)

## Select row at initial rendering 

You have the ability to select a specific row during the initial rendering of the Grid component. This feature is particularly useful when you want to highlight or pre-select a specific row in the grid. To achieve this, you can utilize the [SelectedRowIndex](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_SelectedRowIndex) property provided by the Grid component.

In the following example, it demonstrates how to select a row at initial rendering:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-initial-rendering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-initial-rendering/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Select row at initial rendering](../../images/selection/row-initail-selection.png)

## Select rows in any page based on index value 

The Grid allows you to select rows in any page based on their index value. This feature is useful when you want to perform specific actions on rows, such as highlighting, applying styles, or executing operations, regardless of their location across multiple pages within the grid.

To achieve this, you can utilize the `selectRow` method and the `goToPage` method of the Grid control. By handling the [Change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of `DropDownList` component, you can implement the logic to navigate to the desired page and select the row based on the index value. 

Additionally, by handling the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the Grid, you can maintain the selection of the desired row after completing the paging action.

The following example demonstrates how to select rows in any page based on index value using `actionComplete` and `Change` event:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-index/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-index/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Select rows in any page based on index value](../../images/selection/row-selected-index.gif)

## Multiple row selection by single click on row 

The Grid component allows you to perform multiple row selection by simply clicking on rows one by one without pressing CTRL or SHIFT keys. This means that when you click on a row, it will be selected, and clicking on another row will add it to the selection without deselecting the previously selected rows. To deselect a previously selected row, you can click on the row again, and it will be unselected.

To enable the simple multiple row selection, you need to set the [SelectionSettings.EnableSimpleMultiRowSelection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_EnableSimpleMultiRowSelection) property to **true**. 

The following example demonstrates how to enable multiple row selection with a single click on the Grid row using `EnableSimpleMultiRowSelection` property:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-single-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-single-click/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Multiple row selection by single click on row](../../images/selection/row-multiple-selection.gif)

## Select rows externally 

You can perform single row selection, multiple row selection, and range of row selection externally in a Grid using built-in methods. This feature allows you to interact with specific rows within the Grid. The following topic demonstrates how you can achieve these selections using methods.

### Single row selection

Single row selection allows you to select a single row at a time within the Grid. This feature is useful when you want to focus on specific rows or perform actions on the data within a particular row.

To achieve single row selection, you can use the `selectRow` method. This method allows you to programmatically select a specific row within the Grid by specifying its index.

The following example demonstrates how to select a single row within the Grid by obtaining the selected row index through a textbox component and passing these row index as argument to the `selectRow` method. When the button event is triggered by clicking the **Select Row** button, a single row is selected within the Grid:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-single-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-single-method/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Single row selection](../../images/selection/row-single-method.png)

### Multiple rows selection

The ASP.NET MVC Grid allows you to select multiple rows within the grid simultaneously. This feature is valuable when you need to perform actions or operations on several rows at once or focus on specific areas of your data.

To achieve multiple row selection, you can use the `selectRows` method. This method allows you to select a collection of rows by specifying their indexes, giving you the ability to interact with multiple rows together.

The following example, demonstrates how to select multiple rows in the Grid by calling the `selectRows` method within the button click event and passing an array of row indexes as arguments.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-multiple-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-multiple-method/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Multiple rows selection](../../images/selection/row-multiple-method.png)

### Range of rows selection 

Range of row selection in the Grid enables you to select a continuous range of rows within the grid. This feature is particularly useful when you want to perform actions on multiple rows simultaneously or focus on a specific range of data.

To achieve range of row selection, you can use the `selectRowsByRange` method. This method selects a range of rows from start and end row indexes.
 
The following example, demonstrates how to select a range of rows within the Grid by obtaining the selected rows start index and end index through textbox components. Then, pass these start index and end index as arguments to the `selectRowsByRange` method. When you trigger the button event by clicking the **Select Rows** button, a range of rows is selected within the Grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-range-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-range-selection/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Range of rows selection](../../images/selection/row-range-selection.png)

## Select grid rows based on certain condition

You can programmatically select specific rows in the ASP.NET MVC Grid component based on a certain condition. This feature is particularly useful when you need to dynamically highlight or manipulate specific rows in the grid based on custom conditions. This functionality can be achieved using the `selectRows` method in the [DataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of Grid and [RowDataBound](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) along with obtaining the index value based on the condition.

In the below demo, we have selected the grid rows only when **EmployeeID** column value greater than **3**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-certain-condition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-certain-condition/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Select grid rows based on certain condition](../../images/selection/row-certain-condition.png)

## How to get selected row indexes 

You can retrieve the indexes of the currently selected rows in the Grid component. This feature is particularly useful when you need to perform actions or operations specifically on the selected rows. 

To achieve this, you can leverage the `getSelectedRowIndexes` method, which returns an array of numbers representing the indexes of the selected rows.

 The following example demonstrates how to get selected row indexes using  `getSelectedRowIndexes` method: 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-get-selected/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-get-selected/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Get selected row indexes](../../images/selection/row-get-selected.png)

## How to get selected records on various pages 

The Grid component allows you to retrieve the selected records even when navigating to different pages. This feature is useful when working with large data sets and allows you to perform actions on the selected records across multiple pages. 

To persist the selection across pages, you need to enable the [Persistselection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_PersistSelection) property. By default, this property is set to **false**. To enable it, set the value to **true** in the `SelectionSettings` property of the Grid component.

To retrieve the selected records from different pages, you can use the  `getSelectedRecords` method. This method returns an array of the selected records.

The following example demonstrates how to retrieve selected records from various pages using the `getSelectedRecords` method and display **OrderID** in a dialog when a button is clicked:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-selected-various-pages/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-selected-various-pages/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Get selected records on various pages](../../images/selection/row-various-page.png)

> To persist the grid selection, it is necessary to define any one of the columns as a primary key using the [Columns](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) property.

## How to get selected records  

The get selected records allows you to retrieve the data of the selected rows from the Grid component. This can be particularly useful when you need to perform actions on the selected data or display specific information based on the selected rows.

To retrieve the selected records, you can use the `getSelectedRecords` method. This method allows you to obtain an array of objects representing the selected records.

Here's an example that displays the selected row count using the `getSelectedRecords` method:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-selected-records/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-selected-records/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Get selected records](../../images/selection/row-selected-records.png)

## Clear row selection programmatically 

Clearing row selection programmatically in the Grid component is a useful feature when you want to remove any existing row selections. To achieve this, you can use the `clearRowSelection` method.

>The `clearRowSelection` method is applicable when the selection [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Type) is set to **Multiple** or **Single**.

The following example demonstrates how to clear row selection by calling the `clearRowSelection` method in the button click event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-clear-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-clear-selection/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Clear row selection programmatically ](../../images/selection/row-clear-selection.gif)

## Row selection events 

The Grid provides several events related to row selection that allow you to respond to and customize the behavior of row selection. These events give you control over various aspects of row selection. Here are the available row selection events:

[RowSelecting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelecting): This event is triggered before any row selection occurs. It provides an opportunity to implement custom logic or validation before a row is selected, allowing you to control the selection process.

[RowSelected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowSelected): This event is triggered after a row is successfully selected. You can use this event to perform actions or updates when a row is selected.

[RowDeselecting](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDeselecting): This event is triggered just before a selected row is deselected. It allows you to perform custom logic or validation to decide whether the row should be deselected or not.

[RowDeselected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDeselected): This event is triggered when a particular selected row is deselected. You can use this event to perform actions or validations when a row is no longer selected.

In the following example, row selection is canceled when the value of **CustomerID** is equal to **VINET** within the `RowSelecting` event. The background color changes to green when the value of **Freight** is greater than 10 and less than or equal to 140, triggering the `RowDeselected` event. The background color changes to red when the value of **Freight** is less than or equal to 10 during the `RowDeselected` event. Furthermore, the background color changes to yellow when the value of **Freight** is greater than 140 during the `RowDeselected` event. A notification message is displayed to indicate which event was triggered whenever a row is selected.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/row-selection-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="row-selection.cs" %}
{% include code-snippet/grid/selection/row-selection-events/row-selection.cs%}
{% endhighlight %}
{% endtabs %}

![Row selection events ](../../images/selection/row-selection-events.gif)