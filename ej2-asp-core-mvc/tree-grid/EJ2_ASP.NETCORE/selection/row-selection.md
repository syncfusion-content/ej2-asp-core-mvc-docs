---
layout: post
title: ##Platform_Name## TreeGrid Row Selection | Syncfusion
description: Learn how to use row selection in ##Platform_Name## TreeGrid, including programmatic selection, selected records, row indexes, and persistent selection.
platform: ej2-asp-core-mvc
control: Row Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Row Selection in ##Platform_Name## TreeGrid

## Toggle selection

The Toggle selection allows to perform selection and unselection of the particular row or cell. To enable toggle selection, set [`enableToggle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings.html#Syncfusion_EJ2_TreeGrid_TreeGridSelectionSettings_EnableToggle) property of the selectionSettings as true. If you click on the selected row or cell then it will be unselected and vice versa.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/toggleselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/tree-grid/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/selection/toggleselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toggleselection.cs" %}
{% include code-snippet/tree-grid/selection/toggleselection/toggleselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N>If multi selection is enabled, then first click on any selected row (without pressing Ctrl key), it will clear the multi selection and in second click on the same row, it will be unselected.
<br/> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/treegrid/overview#/fluent2) to knows how to present and manipulate data.