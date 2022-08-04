---
layout: post
title: Column Template in ##Platform_Name## Tree Grid Component
description: Learn here all about Column Template in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Column Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Template in ASP.NET Core Tree Grid Component

The column [`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Template.html) has options to display custom element instead of a field value in the column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/column-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columntemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/column-template/columntemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Columntemplate.cs" %}
{% include code-snippet/tree-grid/columns-core/column-template/columntemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> TreeGrid actions such as editing, filtering and sorting etc. will depend upon the column [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html). If the [`field`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) is not specified in the template column, the treegrid actions cannot be performed.

## Using condition template

You can render the template elements based on condition.

In the following code, checkbox is rendered based on **Approved** field value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-core/conditional-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/conditional-template/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/tree-grid/columns-core/conditional-template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.