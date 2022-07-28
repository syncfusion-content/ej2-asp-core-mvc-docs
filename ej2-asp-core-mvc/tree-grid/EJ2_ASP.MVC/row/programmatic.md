---
layout: post
title: Programmatic Indent in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Programmatic Indent and Outdent using button in Syncfusion ##Platform_Name## Tree Grid component and much more.
platform: ej2-asp-core-mvc
control: Indent and Outdent
publishingplatform: ##Platform_Name##
documentation: ug
---

# Programmatic Indent in ##Platform_Name## Tree Grid Component

To change hierarchy level of the record programmatically, `indent` and `outdent` methods can be used by passing the record as a parameter.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/programmatic-indent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indent.cs" %}
{% include code-snippet/tree-grid/programmatic-indent/indent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/programmatic-indent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indent.cs" %}
{% include code-snippet/tree-grid/programmatic-indent/indent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>Refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to learn how to present and manipulate data.
