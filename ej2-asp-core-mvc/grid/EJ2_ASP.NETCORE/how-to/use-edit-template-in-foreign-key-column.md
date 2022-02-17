---
layout: post
title: Use Edit Template In Foreign Key Column in ##Platform_Name## Grid Component
description: Learn here all about Use Edit Template In Foreign Key Column in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-template-foreign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-template-foreign.cs" %}
{% include code-snippet/grid/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/edit-template-foreign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-template-foreign.cs" %}
{% include code-snippet/grid/how-to/edit-template-foreign/edit-template-foreign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


