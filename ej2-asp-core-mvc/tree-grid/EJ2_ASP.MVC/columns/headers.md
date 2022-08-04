---
layout: post
title: Headers in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Headers in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Headers in ##Platform_Name## Tree Grid Component

## Header Template

You can customize the header element by using the [`HeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderTemplate.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/tree-grid/columns-mvc/header-template/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header text

By default, column header title is displayed from column [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) value. To override the default header title, you have to define the [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/tree-grid/columns-mvc/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If both the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Field.html) and [`HeaderText`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~HeaderText.html) are not defined in the column, the column renders with “empty” header text.
> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.