---
layout: post
title: Checkbox Selection in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Checkbox Selection in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Checkbox Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Checkbox Selection in ##Platform_Name## Tree Grid Component

Checkbox selection provides an option to select multiple treegrid records with help of checkbox in each row.

To render the checkbox in each treegrid row, you need to use checkbox column with type as **checkbox** using the column [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Type.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/selection/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Checkbox.cs" %}
{% include code-snippet/tree-grid/selection/checkbox/checkbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> By default, selection is allowed by clicking a treegrid row or checkbox in that row. To allow selection only through checkbox, you can set the
<br/>[`checkboxOnly`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~CheckboxOnly.html) property to true.
<br/> Selection can be persisted in all the operations using the [`persistSelection`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~PersistSelection.html) property.
<br/>For persisting selection on the treegrid, any one of the columns should be defined as a primary key using the [`isPrimaryKey`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsPrimaryKey.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper .

## Checkbox selection mode

In checkbox selection, selection can also be done by clicking on rows. This selection provides two types of Checkbox Selection mode which can be set by using the following API, [`checkboxMode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~CheckboxMode.html). The modes are;

* **Default**: This is the default value of the checkboxMode. In this mode, user can select multiple rows by clicking rows one by one.
* **ResetOnRowClick**: In ResetOnRowClick mode, when user clicks on a row it will reset previously selected row. Also you can perform multiple-selection in this mode by press and hold CTRL key and click the desired rows. To select range of rows, press and hold the SHIFT key and click the rows.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/windowslikeselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Windows.cs" %}
{% include code-snippet/tree-grid/selection/windowslikeselection/windows.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/windowslikeselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Windows.cs" %}
{% include code-snippet/tree-grid/selection/windowslikeselection/windows.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> Checkbox Selection feature is intended for row selection only; it is not compatible with cell selection mode.

## Conditional row selection

The TreeGrid supports conditional row selection through the [isRowSelectable](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.IsRowSelectable.html) property. This feature enables dynamic business logic to determine which rows can be selected, ensuring that only rows meeting specific conditions are selectable. The `isRowSelectable` property accepts a function that evaluates each row’s data and returns **true** to enable selection or **false** to disable it. The function is executed for the entire data source before rendering, making it suitable for scenarios where selection must be restricted based on criteria.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/partial-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Partial.cs" %}
{% include code-snippet/tree-grid/selection/partial-selection/partial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/partial-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Partial.cs" %}
{% include code-snippet/tree-grid/selection/partial-selection/partial.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

In this sample, checkbox selection is disabled for rows where the "Progress" column has the value **"Completed"**.

## Checkbox Selection In Tree Column

1. ### Enable checkboxes in tree column

    To render checkboxes in tree column, you need to set [`showCheckbox`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_ShowCheckbox) property of as **true**.

    It is possible to select rows hierarchically using checkboxes in TreeGrid by enabling the [`AutoCheckHierarchy`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_AutoCheckHierarchy) property. When a parent record’s checkbox is checked, the checkboxes of its child records are automatically selected and vice-versa.

    {% if page.publishingplatform == "aspnet-core" %}

    {% tabs %}
    {% highlight cshtml tabtitle="CSHTML" %}
    {% include code-snippet/tree-grid/columns-core/checkbox/tagHelper %}
    {% endhighlight %}
    {% highlight c# tabtitle="Checkbox.cs" %}
    {% include code-snippet/tree-grid/columns-core/checkbox/checkbox.cs %}
    {% endhighlight %}
    {% endtabs %}

    {% elsif page.publishingplatform == "aspnet-mvc" %}

    {% tabs %}
    {% highlight razor tabtitle="CSHTML" %}
    {% include code-snippet/tree-grid/columns-core/checkbox/razor %}
    {% endhighlight %}
    {% highlight c# tabtitle="Checkbox.cs" %}
    {% include code-snippet/tree-grid/columns-core/checkbox/checkbox.cs %}
    {% endhighlight %}
    {% endtabs %}
    {% endif %}

2. ### Checkbox selection in tree column with virtualization

    The TreeGrid component is designed to handle large datasets while providing flexible checkbox selection with virtualization enabled. The [`ShowCheckbox`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowCheckbox.html) property displays checkboxes in tree column cells, allowing users to select or deselect them directly. This functionality is enabled by setting the property to "**true**". Similarly, the [`EnableVirtualization`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_EnableVirtualization) property enhances performance by rendering only the visible rows and columns during scrolling. This feature is activated by setting the property to "**true**".

    {% if page.publishingplatform == "aspnet-core" %}

    {% tabs %}
    {% highlight cshtml tabtitle="CSHTML" %}
    {% include code-snippet/tree-grid/selection/showCheckbox-Virtualization/tagHelper %}
    {% endhighlight %}
    {% highlight c# tabtitle="Partial.cs" %}
    {% include code-snippet/tree-grid/selection/showCheckbox-Virtualization/groceriesData.cs %}
    {% endhighlight %}
    {% endtabs %}

    {% elsif page.publishingplatform == "aspnet-mvc" %}

    {% tabs %}
    {% highlight razor tabtitle="CSHTML" %}
    {% include code-snippet/tree-grid/selection/showCheckbox-Virtualization/razor %}
    {% endhighlight %}
    {% highlight c# tabtitle="Partial.cs" %}
    {% include code-snippet/tree-grid/selection/showCheckbox-Virtualization/groceriesData.cs%}
    {% endhighlight %}
    {% endtabs %}
    {% endif %}   

N> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.