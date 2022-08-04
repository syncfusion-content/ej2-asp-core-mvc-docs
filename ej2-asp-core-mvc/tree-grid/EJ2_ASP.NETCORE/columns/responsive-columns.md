---
layout: post
title: Responsive Columns in ##Platform_Name## Tree Grid Component
description: Learn here all about Responsive Columns in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Responsive Columns
publishingplatform: ##Platform_Name##
documentation: ug
---

# Responsive Columns

You can toggle column visibility based on media queries which are defined at the [`hideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html).
The [`hideAtMedia`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HideAtMedia.html) accepts valid
[Media Queries]( http://cssmediaqueries.com/what-are-css-media-queries.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/responsive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/tree-grid/columns-core/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/tree-grid/columns-core/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.