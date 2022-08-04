---
layout: post
title: Row Selection in ##Platform_Name## Tree Grid Component
description: Learn here all about Row Selection in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Row Selection

## Toggle selection

The Toggle selection allows to perform selection and unselection of the particular row or cell. To enable toggle selection, set [`enableToggle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridSelectionSettings~enabletoggle.html) property of the selectionSettings as true. If you click on the selected row or cell then it will be unselected and vice versa.

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



>If multi selection is enabled, then first click on any selected row (without pressing Ctrl key), it will clear the multi selection and in second click on the same row, it will be unselected.
> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.