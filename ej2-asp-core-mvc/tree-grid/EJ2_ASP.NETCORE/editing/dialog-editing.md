---
layout: post
title: Dialog Editing in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Dialog Editing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dialog Editing in ##Platform_Name## Tree Grid Component

In Dialog edit mode, when you start editing the currently selected row, data will be shown on a dialog.
You can change the cell values and save edited data to the data source.
To enable Dialog edit, set the [`mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) property of [`e-treegrid-editsettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings.html) tag helper as **Dialog**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditDialog.cs" %}
{% include code-snippet/tree-grid/editing/edit-dialog/editDialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditDialog.cs" %}
{% include code-snippet/tree-grid/editing/edit-dialog/editDialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.