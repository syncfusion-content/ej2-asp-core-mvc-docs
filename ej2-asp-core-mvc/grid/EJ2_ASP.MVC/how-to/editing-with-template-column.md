---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Editing With Template Column of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Editing With Template Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing with template column

You can edit the template column value by defining the [`Field`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Field) for that particular column.

In the below demo, the **ShipCountry** column is rendered with the template.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="edit-temp" %}
{% include_relative code-snippet/how-to/edit-temp/edit-temp.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="edit-temp" %}
{% include_relative code-snippet/how-to/edit-temp/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="edit-temp" %}
{% include_relative code-snippet/how-to/edit-temp/edit-temp.cs %}
{% endhighlight %}
{% highlight razor tabtitle="edit-temp" %}
{% include_relative code-snippet/how-to/edit-temp/razor %}
{% endhighlight %}
{% endtabs %}


