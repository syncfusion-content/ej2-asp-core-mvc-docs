---
layout: post
title: Responsive Columns in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Responsive Columns in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Responsive Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Responsive Columns in ##Platform_Name## Tree Grid Component

You can toggle column visibility based on media queries which are defined at the [`HideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html).
The [`HideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html) accepts valid
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



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.