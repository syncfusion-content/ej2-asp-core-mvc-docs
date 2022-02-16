---
layout: post
title: Frozen in ##Platform_Name## Tree Grid Component
description: Learn here all about Frozen in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Frozen
publishingplatform: ##Platform_Name##
documentation: ug
---


# Frozen rows and columns

## Frozen rows and columns

Frozen rows and columns provides an option to make rows and columns always visible in the top and left side of the tree grid while scrolling.

In this demo, the [`FrozenColumns`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~FrozenColumns.html) is set as **2** and the [`FrozenRows`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~FrozenRows.html)
is set as **3**. Hence, the left two columns and top three rows are frozen.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/frozencolumn/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Freezecolumn.cs" %}
{% include code-snippet/tree-grid/scrolling/frozencolumn/freezecolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/frozencolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Freezecolumn.cs" %}
{% include code-snippet/tree-grid/scrolling/frozencolumn/freezecolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Freeze particular columns

To freeze particular column in the tree grid, the [`IsFrozen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsFrozen.html) property can be used.

In this demo, the columns with field name **TaskName** and **StartDate** is frozen using
the [`IsFrozen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~IsFrozen.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/isfreezecol/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Isfreeze.cs" %}
{% include code-snippet/tree-grid/scrolling/isfreezecol/isfreeze.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/isfreezecol/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Isfreeze.cs" %}
{% include code-snippet/tree-grid/scrolling/isfreezecol/isfreeze.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Freeze direction

You can freeze the tree grid columns on the left or right side by using the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Freeze) property and the remaining columns will be movable. The tree grid will automatically move the columns to the left or right position based on the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Freeze) value.

Types of the [`column.freeze`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Freeze) directions:

* **`Left`**: Allows you to freeze the columns at the left.
* **`Right`**: Allows you to freeze the columns at the right.

In this demo, the **Task Name** column is frozen at the left and the **Priority** column is frozen at the right side of the content table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/freeze-direction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-direction.cs" %}
{% include code-snippet/tree-grid/scrolling/freeze-direction/freeze-direction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/scrolling/freeze-direction/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Freeze-direction.cs" %}
{% include code-snippet/tree-grid/scrolling/freeze-direction/freeze-direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Limitations of frozen tree grid

The following features are not supported in frozen rows and columns:

* Row Template
* Detail Template
* Cell Editing

Freeze Direction feature has the below limitations, along with the above mentioned limitations.

* Infinite scroll cache mode
* Freeze direction in the stacked header is not compatible with column reordering.

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.
