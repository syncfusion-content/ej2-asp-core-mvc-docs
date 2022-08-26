---
layout: post
title: Batch Editing in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Batch Editing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Batch Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Batch Editing in ##Platform_Name## Tree Grid Component

In Batch edit mode, when you double-click on the treegrid cell, the target cell goes into edit state.
You can bulk save (added, changed and deleted data in the single request) to data source by clicking on the toolbar's **Update** button or by externally invoking the [`batchSave`](https://ej2.syncfusion.com/documentation/api/treegrid/#batchsave) method.
To enable Batch edit, set the [`EditSettings.mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as **Batch**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/batch-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batchedit.cs" %}
{% include code-snippet/tree-grid/editing/batch-edit/batchedit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/batch-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batchedit.cs" %}
{% include code-snippet/tree-grid/editing/batch-edit/batchedit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.