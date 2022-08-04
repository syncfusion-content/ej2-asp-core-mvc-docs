---
layout: post
title: Content in ##Platform_Name## Tree Grid Component
description: Learn here all about Content in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Content
publishingplatform: ##Platform_Name##
documentation: ug
---

# Displaying the HTML content

The HTML tags can be displayed in the TreeGrid header and content by enabling the [`DisableHtmlEncode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~DisableHtmlEncode.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/html-encode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HtmlEncode.cs" %}
{% include code-snippet/tree-grid/cell/html-encode/htmlEncode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/cell/html-encode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HtmlEncode.cs" %}
{% include code-snippet/tree-grid/cell/html-encode/htmlEncode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.