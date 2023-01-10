---
layout: post
title: Checkbox Selection in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Checkbox Selection in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Checkbox Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Checkbox Selection in ASP.NET MVC Grid Component

Checkbox selection provides an option to select multiple grid records with help of checkbox in each row.

To render the checkbox in each grid row, you need to use checkbox column with type as **checkbox** using the column [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Type) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/grid/selection/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/grid/selection/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, selection is allowed by clicking a grid row or checkbox in that row. To allow selection only through checkbox, you can set the [`CheckboxOnly`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_CheckboxOnly) property of [`SelectionSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html) to true.
> Selection can be persisted in all the operations using the [`PersistSelection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_PersistSelection) property of [`SelectionSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html). For persisting selection on the grid, any one of the columns should be defined as a primary key using the [`IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_IsPrimaryKey) property.

## Checkbox selection mode

In checkbox selection, selection can also be done by clicking on rows. This selection provides two types of Checkbox Selection mode which can be set by using the following API, [`checkboxMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_CheckboxMode). The modes are;

* **Default**: This is the default value of the checkboxMode. In this mode, user can select multiple rows by clicking rows one by one.
* **ResetOnRowClick**: In ResetOnRowClick mode, when user clicks on a row it will reset previously selected row. Also you can perform multiple-selection in this mode by press and hold CTRL key and click the desired rows. To select range of rows, press and hold the SHIFT key and click the rows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/windowslikeselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Windows.cs" %}
{% include code-snippet/grid/selection/windowslikeselection/windows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/windowslikeselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Windows.cs" %}
{% include code-snippet/grid/selection/windowslikeselection/windows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Prevent specific rows from being selected in checkbox selection

You can prevent specific rows from being selected in the checkbox selection mode by hiding the checkboxes using the [RowDataBound](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowDataBound) event. You achieve this by setting the `isSelectable` argument as false in the `RowDataBound` event based on certain conditions as per the needs of the application.

In the following sample, the selection of specific rows has been prevented based on the `isSelectable` argument in the `RowDataBound` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/prevent-checkbox-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-checkbox-selection.cs" %}
{% include code-snippet/grid/selection/prevent-checkbox-selection/prevent-checkbox-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/selection/prevent-checkbox-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-checkbox-selection.cs" %}
{% include code-snippet/grid/selection/prevent-checkbox-selection/prevent-checkbox-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}