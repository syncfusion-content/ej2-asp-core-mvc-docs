---
layout: post
title: ##Platform_Name## TreeGrid Cell Content | Syncfusion
description: Learn how to display HTML content in ##Platform_Name## TreeGrid headers and cells using disableHtmlEncode to render formatted content and custom markup.
platform: ej2-asp-core-mvc
control: Content
publishingplatform: ##Platform_Name##
documentation: ug
---

# HTML Content in ##Platform_Name## TreeGrid

The HTML tags can be displayed in the TreeGrid header and content by enabling the [`DisableHtmlEncode`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_DisableHtmlEncode) property.

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



N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/treegrid/overview#/fluent2) to knows how to present and manipulate data.