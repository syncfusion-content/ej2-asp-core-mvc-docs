---
layout: post
title: Detail Template in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Detail Template in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Detail Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Detail Template in ##Platform_Name## Tree Grid Component

The detail template provides additional information about a particular row. By expanding the parent row the child rows are expanded along with their detail template. The [`detailTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_DetailTemplate) property accepts either the template string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/detailtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Detailtemplate.cs" %}
{% include code-snippet/tree-grid/row/detailtemplate/detailtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/detailtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detailtemplate.cs" %}
{% include code-snippet/tree-grid/row/detailtemplate/detailtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.