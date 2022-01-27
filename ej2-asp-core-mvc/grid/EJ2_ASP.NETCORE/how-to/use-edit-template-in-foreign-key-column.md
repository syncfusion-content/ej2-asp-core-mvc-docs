---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Use Edit Template In Foreign Key Column of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Use Edit Template In Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Use Edit Template in Foreign Key Column

By default, foreign key column uses dropdown component for editing. You can render other than the dropdown by using the [`edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper. The following example demonstrates the way of using edit template in foreign column.

In the following example, The **Employee Name** is a foreign key column and while editing, AutoComplete component is rendered instead of DropDownList.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="edit-template-foreign" %}
{% include_relative code-snippet/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="edit-template-foreign" %}
{% include_relative code-snippet/how-to/edit-template-foreign/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="edit-template-foreign" %}
{% include_relative code-snippet/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% highlight razor tabtitle="edit-template-foreign" %}
{% include_relative code-snippet/how-to/edit-template-foreign/razor %}
{% endhighlight %}
{% endtabs %}


