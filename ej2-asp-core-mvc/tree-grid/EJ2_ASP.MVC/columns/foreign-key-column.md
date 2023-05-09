---
layout: post
title: Foreign Key Column in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Foreign Key Column in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---

# Foreign Key Column in ASP.NET MVC Tree Grid Component

Since Tree Grid Databinding concept is based on hierarchy relationship, there is no in-built support for foreign key datasource. However, it is possible to display foreign key values in the Tree Grid at initial rendering as well as while Editing.

To display the foreignKey value at initial rendering, use[`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGrid.html#Syncfusion_EJ2_TreeGrid_TreeGrid_QueryCellInfo) event of the Tree Grid and and also for edit action use [`EditType`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_EditType) and [`Column.edit`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.TreeGrid.TreeGridColumn.html#Syncfusion_EJ2_TreeGrid_TreeGridColumn_Edit) properties of Tree Grid Column to render Dropdownlist with foreign datasource.

In the following code example, **EmployeeID** is a foreign column which shows **EmployeeName** from foreign data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Columnmenu.cs" %}
{% include code-snippet/tree-grid/columns-mvc/foreign/foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/columns-mvc/foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ForeignKey.cs" %}
{% include code-snippet/tree-grid/columns-mvc/foreign/foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can refer to our [`ASP.NET MVC Tree Grid`](https://www.syncfusion.com/aspnet-mvc-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our [`ASP.NET MVC Tree Grid example`](https://ej2.syncfusion.com/aspnetmvc/TreeGrid/Overview#/material) to knows how to present and manipulate data.