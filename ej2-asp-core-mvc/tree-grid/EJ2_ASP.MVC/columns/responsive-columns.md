---
layout: post
title: ##Platform_Name## TreeGrid Responsive Columns | Syncfusion
description: Learn how to create responsive columns in ##Platform_Name## TreeGrid using media queries to control column visibility and optimize layouts across devices.
platform: ej2-asp-core-mvc
control: Responsive Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Responsive Columns in ##Platform_Name## TreeGrid

You can toggle column visibility based on media queries which are defined at the [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HideAtMedia).
The [`HideAtMedia`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_HideAtMedia) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html ).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Responsive-columns.cs" %}
{% include code-snippet/tree-grid/columns-mvc/responsive-columns/responsive-columns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/responsive-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive-columns.cs" %}
{% include code-snippet/tree-grid/columns-mvc/responsive-columns/responsive-columns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.