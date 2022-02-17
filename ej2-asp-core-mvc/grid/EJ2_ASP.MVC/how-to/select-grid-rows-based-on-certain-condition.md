---
layout: post
title: Select Grid Rows Based On Certain Condition in ##Platform_Name## Grid Component
description: Learn here all about Select Grid Rows Based On Certain Condition in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Select Grid Rows Based On Certain Condition
publishingplatform: ##Platform_Name##
documentation: ug
---


# Select grid rows based on certain condition

You can select the specific row in the grid based on a certain condition by using the **selectRows** method in the [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of Grid.

In the below demo, we have selected the grid rows only when **EmployeeID** column value greater than **3**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/databasedselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databasedselection.cs" %}
{% include code-snippet/grid/how-to/databasedselection/databasedselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/databasedselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databasedselection.cs" %}
{% include code-snippet/grid/how-to/databasedselection/databasedselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


