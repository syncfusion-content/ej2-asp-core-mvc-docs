---
layout: post
title: Immutable Mode in ##Platform_Name## Tree Grid Component
description: Learn here all about Immutable Mode in Syncfusion ##Platform_Name## Tree Grid component and more.
platform: ej2-asp-core-mvc
control: Immutable Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Immutable Mode

The immutable mode optimizes the Tree Grid re-rendering performance by using the object reference and [`deep compare`](https://dmitripavlutin.com/how-to-compare-objects-in-javascript/#4-deep-equality) concept. When performing the Tree Grid actions, it will only re-render the modified or newly added rows and prevent the re-rendering of the unchanged rows.

To enable this feature, you have to set the `EnableImmutableMode` property as **true**.

>* This feature uses the primary key value for data comparison. So, you need to provide the [`IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_IsPrimaryKey) column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/immutable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Immutable.cs" %}
{% include code-snippet/tree-grid/immutable/immutable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/immutable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Immutable.cs" %}
{% include code-snippet/tree-grid/immutable/immutable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

The following features are not supported in the immutable mode:

* Frozen rows and columns
* Row Template
* Detail Template
* Column reorder
* Virtualization

> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.