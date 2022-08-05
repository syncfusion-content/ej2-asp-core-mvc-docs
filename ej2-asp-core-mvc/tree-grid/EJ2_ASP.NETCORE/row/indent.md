---
layout: post
title: Indent and Outdent Feature in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Indent and Outdent Feature in Syncfusion ##Platform_Name## Tree Grid component and much more.
platform: ej2-asp-core-mvc
control: Indent and Outdent
publishingplatform: ##Platform_Name##
documentation: ug
---

# Indent and Outdent in ##Platform_Name## Tree Grid Component

The Indent and Outdent feature will help to change the hierarchy level of rows in tree grid. The indent action moves the selected row as the last child of its previous row, whereas the outdent action moves the selected row as a sibling to its parent row.

To use the indent and outdent feature, inject the `RowDD` module in the Tree Grid. The tree grid toolbar has the built-in items to execute indent and outdent actions. Define this by using the toolbar property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/indent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indent.cs" %}
{% include code-snippet/tree-grid/indent/indent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/indent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indent.cs" %}
{% include code-snippet/tree-grid/indent/indent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## How-to-do-programmatically Indent/Outdent a row

You can change the hierarchy level of record programmatically using `indent` and `outdent` methods.

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



>Refer to our [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to learn how to present and manipulate data.