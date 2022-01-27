---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Disable Editing For Particular Row Cell of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Disable Editing For Particular Row Cell
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable editing for a particular row/cell

You can disable the editing for a particular row by using the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of Grid.

In the below demo, the rows which are having the value for **ShipCountry** column as Denmark is prevented from editing.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="disable-edit" %}
{% include_relative code-snippet/how-to/disable-edit/disable-edit.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="disable-edit" %}
{% include_relative code-snippet/how-to/disable-edit/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="disable-edit" %}
{% include_relative code-snippet/how-to/disable-edit/disable-edit.cs %}
{% endhighlight %}
{% highlight razor tabtitle="disable-edit" %}
{% include_relative code-snippet/how-to/disable-edit/razor %}
{% endhighlight %}
{% endtabs %}



For batch mode of editing, you can use [`CellEdit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event of Grid. In the below demo, the cells which are having the value as Denmark is prevented from editing.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="disable-edit-batch" %}
{% include_relative code-snippet/how-to/disable-edit-batch/disable-edit-batch.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="disable-edit-batch" %}
{% include_relative code-snippet/how-to/disable-edit-batch/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="disable-edit-batch" %}
{% include_relative code-snippet/how-to/disable-edit-batch/disable-edit-batch.cs %}
{% endhighlight %}
{% highlight razor tabtitle="disable-edit-batch" %}
{% include_relative code-snippet/how-to/disable-edit-batch/razor %}
{% endhighlight %}
{% endtabs %}


