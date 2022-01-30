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
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/disable-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="disable-edit" %}
{% include code-snippet/grid/how-to/disable-edit/disable-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/disable-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="disable-edit" %}
{% include code-snippet/grid/how-to/disable-edit/disable-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



For batch mode of editing, you can use [`CellEdit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CellEdit) event of Grid. In the below demo, the cells which are having the value as Denmark is prevented from editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/disable-edit-batch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="disable-edit-batch" %}
{% include code-snippet/grid/how-to/disable-edit-batch/disable-edit-batch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/disable-edit-batch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="disable-edit-batch" %}
{% include code-snippet/grid/how-to/disable-edit-batch/disable-edit-batch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


