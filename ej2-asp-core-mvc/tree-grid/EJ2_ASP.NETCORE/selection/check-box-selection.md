---
layout: post
title: Checkbox Selection in ##Platform_Name## Tree Grid Component
description: Learn here all about Checkbox Selection in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Checkbox Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Checkbox Selection

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



> By default, selection is allowed by clicking a treegrid row or checkbox in that row. To allow selection only through checkbox, you can set the
[`checkboxOnly`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~CheckboxOnly.html) property to true.
> Selection can be persisted in all the operations using the [`persistSelection`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~PersistSelection.html) property.
For persisting selection on the treegrid, any one of the columns should be defined as a primary key using the [`isPrimaryKey`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsPrimaryKey.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper .

## Checkbox selection Mode

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



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.