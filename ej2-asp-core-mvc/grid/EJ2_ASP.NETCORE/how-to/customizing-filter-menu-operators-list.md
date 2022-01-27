---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customizing Filter Menu Operators List of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customizing Filter Menu Operators List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing filter menu operators list

You can customize the default filter operator list by defining the [`operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property of [`e-grid-filterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) tag helper.

The available options are:
* `stringOperator`- defines customized string operator list.
* `numberOperator` - defines customized number operator list.
* `dateOperator` - defines customized date operator list.
* `booleanOperator` - defines customized boolean operator list.

In the following sample, we have customized string filter operators.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="customize-filter-menu" %}
{% include_relative code-snippet/how-to/customize-filter-menu/customize-filter-menu.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/customize-filter-menu/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="customize-filter-menu" %}
{% include_relative code-snippet/how-to/customize-filter-menu/customize-filter-menu.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/customize-filter-menu/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


