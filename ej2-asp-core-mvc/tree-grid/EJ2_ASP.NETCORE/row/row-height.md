---
layout: post
title: Row Height in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Row Height in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Row Height
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Height in ##Platform_Name## Tree Grid Component

You can customize the row height of treegrid rows through the [`rowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) property. The [`rowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) property is used to change the row height of entire treegrid rows.

In the below example, the rowHeight is set as **60px**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/tree-grid/row/row-height/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/tree-grid/row/row-height/rowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize row height for particular row

Grid row height for particular row can be customized using the [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event by setting the [`rowHeight`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowHeight.html) in arguments for each row based on the requirement.

In the below example, the row height for the row with Task ID as '3' is set as '90px' using the [`rowDataBound`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~RowDataBound.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-row-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRowHeight.cs" %}
{% include code-snippet/tree-grid/row/customize-row-height/customizeRowHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/row/customize-row-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomizeRowHeight.cs" %}
{% include code-snippet/tree-grid/row/customize-row-height/customizeRowHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.