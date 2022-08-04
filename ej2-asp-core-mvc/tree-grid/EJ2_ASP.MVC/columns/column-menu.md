---
layout: post
title: Column Menu in ##Platform_Name## Tree Grid Component
description: Learn here all about Column Menu in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Menu

The column menu has options to integrate features like sorting, filtering, and autofit. It will show a menu with the integrated feature when users click on multiple icon of the column. To enable column menu, you need to define the [`ShowColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ShowColumnMenu.html) property as true.

The default items are displayed in following table.

| Item | Description |
|-----|-----|
| `SortAscending` | Sort the current column in ascending order. |
| `SortDescending` | Sort the current column in descending order. |
| `AutoFit` | Auto fit the current column. |
| `AutoFitAll` | Auto fit all columns. |
| `Filter` | Show the filter option as given in `filterSettings.type` |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/columnmenu/columnmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can disable column menu for a particular column by defining the [`ShowColumnMenu`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ShowColumnMenu.html) in [`Column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) as false.
> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.