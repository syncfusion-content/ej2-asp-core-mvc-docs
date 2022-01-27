---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Select Grid Rows Based On Certain Condition of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Select Grid Rows Based On Certain Condition
publishingplatform: ##Platform_Name##
documentation: ug
---


# Select grid rows based on certain condition

You can select the specific row in the grid based on a certain condition by using the **selectRows** method in the [`dataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event of Grid.

In the below demo, we have selected the grid rows only when **EmployeeID** column value greater than **3**.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="databasedselection" %}
{% include_relative code-snippet/how-to/databasedselection/databasedselection.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="databasedselection" %}
{% include_relative code-snippet/how-to/databasedselection/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="databasedselection" %}
{% include_relative code-snippet/how-to/databasedselection/databasedselection.cs %}
{% endhighlight %}
{% highlight razor tabtitle="databasedselection" %}
{% include_relative code-snippet/how-to/databasedselection/razor %}
{% endhighlight %}
{% endtabs %}


