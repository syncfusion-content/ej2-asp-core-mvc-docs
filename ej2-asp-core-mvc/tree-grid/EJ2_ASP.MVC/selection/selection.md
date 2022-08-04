---
layout: post
title: Selection in ##Platform_Name## Tree Grid Component
description: Learn here all about Selection in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Selection

Selection provides an option to highlight a row or a cell. It can be done through simple mouse down or arrow keys. To disable selection in the TreeGrid, set the [`AllowSelection`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~AllowSelection.html) to false.

The treegrid supports two types of selection that can be set by using the [`Type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~Type.html) property in [`SelectionSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings.html). They are:

* **Single**: The Single value is set by default, and it only allows selection of a single row or a cell.

* **Multiple**: Allows you to select multiple rows or cells.
To perform the multi-selection, press and hold CTRL key and click the desired rows or cells. To select range of rows or cells, press and hold the SHIFT key and click the rows or cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/tree-grid/selection/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/tree-grid/selection/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection mode

The treegrid supports three types of selection mode that can be set by using the [`Mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~Mode.html) property of [`SelectionSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings.html). They are:

* **Row**: The Row value is set by default, and allows you to select only rows.
* **Cell**: Allows you to select only cells.
* **Both**: Allows you to select rows and cells at the same time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/selection-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-mode.cs" %}
{% include code-snippet/tree-grid/selection/selection-mode/selection-mode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/selection-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-mode.cs" %}
{% include code-snippet/tree-grid/selection/selection-mode/selection-mode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.