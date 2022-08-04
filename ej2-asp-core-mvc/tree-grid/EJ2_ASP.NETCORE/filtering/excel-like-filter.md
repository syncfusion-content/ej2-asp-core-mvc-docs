---
layout: post
title: Excel Like Filter in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Excel Like Filter in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Like Filter
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Like Filter in ##Platform_Name## Tree Grid Component

You can enable Excel like filter by defining.
[`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings~Type.html) as **Excel** using [`e-treegrid-filterSettings`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridFilterSettings.html) tag helper .The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/excelfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/tree-grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/excelfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/tree-grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change default Excel filter Operator

You can change the default excel-filter operator by changing the column operator as `contains` from `startsWith` in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_ActionBegin) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/excelfilter-default-operator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter-default-operator.cs" %}
{% include code-snippet/tree-grid/filtering/excelfilter-default-operator/excelfilter-default-operator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/filtering/excelfilter-default-operator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter-default-operator.cs" %}
{% include code-snippet/tree-grid/filtering/excelfilter-default-operator/excelfilter-default-operator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.