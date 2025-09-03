---
layout: post
title: Selection in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection in ##Platform_Name## Gantt component

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



## Toggle selection

The toggle selection allows you to select and deselect a specific row or cell. To enable toggle selection, set the `enableToggle` property of the selectionSettings to `true`. If you click the selected row or cell, then it will be deselected and vice versa. By default, the `enableToggle` property is set to `false`.

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

## Hover highlighting

{% if page.publishingplatform == "aspnet-core" %}

The hover highlighting feature in the Syncfusion ##Platform_Name## Gantt Chart enhances user interaction by highlighting **tree grid rows, chart task bars, header cells, and timeline cells** when hovered, making it easier to track tasks in complex project timelines. Enable it by setting the `enableHover` property to **true** in the component.

The following code example shows how to enable the hover highlighting in Gantt.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/hover-highlighting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="hoverHighlighting.cs" %}
{% include code-snippet/gantt/selection/hover-highlighting/hoverHighlighting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The hover highlighting feature in the Syncfusion ##Platform_Name## Gantt Chart enhances user interaction by highlighting **tree grid rows, chart task bars, header cells, and timeline cells** when hovered, making it easier to track tasks in complex project timelines. Enable it by setting the `EnableHover` property to **true** in the component.

The following code example shows how to enable the hover highlighting in Gantt.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/selection/hover-highlighting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="hoverHighlighting.cs" %}
{% include code-snippet/gantt/selection/hover-highlighting/hoverHighlighting.cs %}
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



## Multiple selection based on condition

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

## Touch interaction

The touch interaction feature in the Gantt component allows you to easily interact with the Gantt chart on touch screen devices. This feature is particularly useful for enhancing usability on mobile devices and tablets, making it easier to navigate and interact with the Gantt chart's content using touch gestures.

[`Single Row Selection`](selection/#selection-mode) :  When you tap on a row using a touch screen, the tapped row is automatically selected. This offers a straightforward way to select single rows with a touch interface.

[`Multiple Row Selection`](selection/#multiple-row-selection) : To select multiple rows, you can utilize the multi-row selection feature. When you tap on a row, a popup is displayed, indicating the option for multi-row selection. Tap on the popup, and then proceed to tap on the desired rows you want to select. This allows you to select and interact with multiple rows simultaneously, as shown in the following image:

![Multiple selection](../images/multiple-selection.PNG)
