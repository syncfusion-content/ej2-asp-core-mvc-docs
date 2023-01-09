---
layout: post
title: Row Template in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Row Template in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Template in ##Platform_Name## Tree Grid Component

The **RowTemplate** has an option to customise the look and behavior of the treegrid rows. The [`RowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_RowTemplate) property accepts either the **Template** string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/tree-grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/tree-grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`RowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_RowTemplate) property accepts only the TR element.

## Row template with formatting

If the [`RowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_RowTemplate) is used, the value cannot be  formatted  inside the template using the [`Columns.Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Format.html) property. In that case, a function should be defined globally to format the value and invoke it inside the template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rowtemplate-formatting.cs" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/rowtemplate-formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rowtemplate-formatting.cs" %}
{% include code-snippet/tree-grid/row/rowtemplate-formatting/rowtemplate-formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

Row template feature is not compatible with all the features which are available in treegrid and it has limited features support. Here we have listed out the features which are not compatible with row template feature.

* Filtering
* Paging
* Sorting
* Scrolling
* Searching
* Rtl
* Context Menu
* State Persistence



> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.