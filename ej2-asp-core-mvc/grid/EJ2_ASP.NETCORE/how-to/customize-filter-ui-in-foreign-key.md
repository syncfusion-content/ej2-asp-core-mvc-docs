---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Filter Ui In Foreign Key of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Filter Ui In Foreign Key
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize filter UI in foreign key column

You can create your own filtering UI by using [`filter`](https://helpsyncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Grids.GridColumn~Filter.html) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper. The following example demonstrates the way to create a custom filtering UI in the foreign column.

In the following example, The **Employee Name** is a foreign key column. DropDownList is rendered using Filter UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="filter-ui-foreign" %}
{% include_relative code-snippet/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/filter-ui-foreign/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="filter-ui-foreign" %}
{% include_relative code-snippet/how-to/filter-ui-foreign/filter-ui-foreign.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/filter-ui-foreign/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


