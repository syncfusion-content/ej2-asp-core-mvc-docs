---
layout: post
title: Selection in ##Platform_Name## Gantt Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection

Selection provides an option to highlight a row or a cell. It can be done using arrow keys or by scrolling down the mouse. To disable selection in the Gantt control, set the [`AllowSelection`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowSelection.html) to false.

The Gantt control supports two types of selection that can be set by using the [`SelectionSettings.Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSelectionSettings~Type.html) property. They are:

* `Single`: Sets a single value by default and allows only selection of a single row or a cell.
* `Multiple`: Allows you to select multiple rows or cells. To perform the multi-selection, press and hold the CTRL key and click the desired rows or cells.

## Selection mode

The Gantt control supports three types of selection modes that can be set by using the [`SelectionSettings.Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSelectionSettings~Mode.html). They are:

* `Row`: Allows you to select only rows, and the row value is set by default.
* `Cell`: Allows you to select only cells.
* `Both`: Allows you to select rows and cells at the same time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/bothType/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="BothType.cs" %}
{% include code-snippet/gantt/selection/bothType/bothType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/bothType/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BothType.cs" %}
{% include code-snippet/gantt/selection/bothType/bothType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Row selection

The row selection in the Gantt control can be enabled or disabled using the [`AllowSelection`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~AllowSelection.html) property. You can get the selected row object using the `getSelectedRecords` method. The following code example shows how to disable the row selection in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/disableSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DisableSelection.cs" %}
{% include code-snippet/gantt/selection/disableSelection/disableSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/disableSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisableSelection.cs" %}
{% include code-snippet/gantt/selection/disableSelection/disableSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> `Row` selection is the default type of Gantt selection mode.

### Selecting a row on initial load

You can select a row at the time of loading by setting the index of the row to the [`SelectedRowIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~SelectedRowIndex.html) property. Find the following code example for details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/initialLoadSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InitialLoadSelection.cs" %}
{% include code-snippet/gantt/selection/initialLoadSelection/initialLoadSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/initialLoadSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InitialLoadSelection.cs" %}
{% include code-snippet/gantt/selection/initialLoadSelection/initialLoadSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/initialLoadSelection.png)

### Selecting a row dynamically

You can also select a row dynamically using the `selectRow` method. The following code demonstrates how to select a row dynamically by clicking the custom button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/selectRow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectRow.cs" %}
{% include code-snippet/gantt/selection/selectRow/selectRow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/selectRow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectRow.cs" %}
{% include code-snippet/gantt/selection/selectRow/selectRow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Multiple row selection

You can select multiple rows by setting the [`SelectionSettings.Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.GanttSelectionSettings~Type.html) property to `Multiple`. You can select more than one row by holding down the CTRL key while selecting multiple rows. The following code example explains how to enable multiple selection in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/multipleRowSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleRowSelection.cs" %}
{% include code-snippet/gantt/selection/multipleRowSelection/multipleRowSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/multipleRowSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MultipleRowSelection.cs" %}
{% include code-snippet/gantt/selection/multipleRowSelection/multipleRowSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Selecting multiple rows dynamically

You can also select rows dynamically using the `selectRows` method. The following code demonstrates how to select rows dynamically by clicking the custom button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/selectRows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SelectRows.cs" %}
{% include code-snippet/gantt/selection/selectRows/selectRows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/selectRows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SelectRows.cs" %}
{% include code-snippet/gantt/selection/selectRows/selectRows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/selectRows.png)

### Customize row selection action

While selecting a row in Gantt, the [`RowSelecting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowSelecting.html) and [`RowSelected`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowSelected.html) events will be triggered. The the [`RowSelecting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowSelecting.html) event will be triggered on initialization of row selection, and you can get the previously selected row and current selecting row’s information, which is used to prevent selection of a particular row. The [`RowSelected`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowSelected.html) event will be triggered on completion of row selection action, and you can get the current selected row’s information through this event. The following code example demonstrates how to prevent the selection of a row using the [`RowSelecting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowSelecting.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/rowSelectingEvent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowSelectingEvent.cs" %}
{% include code-snippet/gantt/selection/rowSelectingEvent/rowSelectingEvent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/rowSelectingEvent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowSelectingEvent.cs" %}
{% include code-snippet/gantt/selection/rowSelectingEvent/rowSelectingEvent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



In the Gantt control, when you click an already selected row, selection will be cleared. While deselecting a row in Gantt, the [`RowDeselecting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowDeselecting.html) and [`RowDeselected`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowDeselected.html) events will occur. The [`RowDeselecting`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowDeselecting.html) event will occur on initialization of deselecting row, and you can get the current deselecting row’s information to prevent the deselection of particular row. The [`RowDeselected`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~RowDeselected.html) event will occur on completion of row deselection action, and you can get the current deselected row’s information.

## Toggle selection

The toggle selection allows you to select and deselect a specific row or cell. To enable toggle selection, set the `enableToggle` property of the selectionSettings to `true`. If you click the selected row or cell, then it will be deselected and vice versa.
By default, the `enableToggle` property is set to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/toggleselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/gantt/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/toggleselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/gantt/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Clear selection

You can clear the selected cells and selected rows by using a method called `clearSelection`. The following code example demonstrates how to clear the selected rows in Gantt Chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/clearselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clearselection.cs" %}
{% include code-snippet/gantt/selection/clearselection/clearselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/clearselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clearselection.cs" %}
{% include code-snippet/gantt/selection/clearselection/clearselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Get selected row indexes and records

You can get the selected row indexes by using the [`getSelectedRowIndexes`](../api/gantt/#getselectedrowindexes) method. And by using [`getSelectedRecords`](../api/gantt/#getSelectedRecords) method, you can get the selected record details.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GetSelectedRowIndex.cs" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/getSelectedRowIndex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GetSelectedRowIndex.cs" %}
{% include code-snippet/gantt/selection/getSelectedRowIndex/getSelectedRowIndex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Selection based on condition

You can select multiple rows based on condition by using the [`selectRows`](../api/grid/#selectrows) method.

In the following code, the rows which contains `TaskId` value as 3 and 4 are selected at initial rendering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/conditionalSelection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ConditionalSelection.cs" %}
{% include code-snippet/gantt/selection/conditionalSelection/conditionalSelection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/conditionalSelection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ConditionalSelection.cs" %}
{% include code-snippet/gantt/selection/conditionalSelection/conditionalSelection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/conditionalSelection.png)

## See Also

* [Touch interaction](./touch-interaction/#selection)