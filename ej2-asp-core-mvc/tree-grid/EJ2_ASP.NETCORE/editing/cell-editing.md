---
layout: post
title: Cell Editing in ##Platform_Name## Tree Grid Component
description: Learn here all about Cell Editing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Cell Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Cell Editing

In Cell edit mode, when you double click on a cell, it is changed to edit state.
You can change the cell value and save to the data source.
To enable Cell edit, set the [`mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) property of [`e-treegrid-editsettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings.html) tag helper as **Cell**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditCell.cs" %}
{% include code-snippet/tree-grid/editing/edit-cell/editCell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditCell.cs" %}
{% include code-snippet/tree-grid/editing/edit-cell/editCell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Cell edit mode is default mode of editing.
> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.