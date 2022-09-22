---
layout: post
title: Row Selection in ##Platform_Name## Grid Component
description: Learn here all about Row Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Row Selection

## Select row at Initial rendering

To select a row at initial rendering, set the [`selectedRowIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_SelectedRowIndex) value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/select-row/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Select-row.cs" %}
{% include code-snippet/grid/selection/select-row/select-row.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/select-row/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Select-row.cs" %}
{% include code-snippet/grid/selection/select-row/select-row.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Get selected row indexes

You can get the selected row indexes by using the **getSelectedRowIndexes** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selected-row-index/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-row-index.cs" %}
{% include code-snippet/grid/selection/selected-row-index/selected-row-index.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selected-row-index/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-row-index.cs" %}
{% include code-snippet/grid/selection/selected-row-index/selected-row-index.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Simple multiple row selection

You can select multiple rows by clicking on rows one by one. This will not deselect the previously selected rows. To deselect the previously selected row, you can click on the  selected row. You can enable this behavior by using [`enableSimpleMultiRowSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_EnableSimpleMultiRowSelection) property of **e-grid-selectionsettings** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/simplemultiselect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiselection.cs" %}
{% include code-snippet/grid/selection/simplemultiselect/multiselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/simplemultiselect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiselection.cs" %}
{% include code-snippet/grid/selection/simplemultiselect/multiselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Toggle selection

The Toggle selection allows to perform selection and unselection of the particular row or cell or column. To enable toggle selection, set [`enableToggle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_EnableToggle) property of **e-grid-selectionsettings** as true. If you click on the selected row or cell or column then it will be unselected and vice versa.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/toggleselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/grid/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/toggleselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/grid/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If multi selection is enabled, then first click on any selected row (without pressing Ctrl key), it will clear the multi selection and in second click on the same row, it will be unselected.

## Clear selection programmatically

You can clear the Grid selection programmatically by using the `clearSelection` method.

In the demo below, we initially selected the third row using [selectedRowIndex](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_SelectedRowIndex). You can clear this selection by calling the `clearSelection` method in the button click event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/programmatic-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Programmatic-Selection.cs" %}
{% include code-snippet/grid/selection/programmatic-selection/programmatic-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/programmatic-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Programmatic-Selection.cs" %}
{% include code-snippet/grid/selection/programmatic-selection/programmatic-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Get selected records on various pages

Enabling the [selectionSettings.persistSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_PersistSelection) property will persist the selection in all Grid operations.

So the selection will be maintained on every page even after navigating to another page.

You can get the selected records using the `getSelectedRecords` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selected-records/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GetSelectedRecords.cs" %}
{% include code-snippet/grid/selection/selected-records/selected-records.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/selected-records/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GetSelectedRecords.cs" %}
{% include code-snippet/grid/selection/selected-records/selected-records.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}