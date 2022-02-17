---
layout: post
title: Customize Filter Ui In Foreign Key in ##Platform_Name## Grid Component
description: Learn here all about Customize Filter Ui In Foreign Key in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Customize Filter Ui In Foreign Key
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize filter UI in foreign key column

You can create your own filtering UI by using [`Filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html). The following example demonstrates the way to create a custom filtering UI in the foreign column.

In the following example, The **Employee Name** is a foreign key column. DropDownList is rendered using Filter UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-ui-foreign.cs" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-ui-foreign.cs" %}
{% include code-snippet/grid/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


