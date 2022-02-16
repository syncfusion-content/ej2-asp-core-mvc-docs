---
layout: post
title: Customizing Filter Menu Operators List in ##Platform_Name## Grid Component
description: Learn here all about Customizing Filter Menu Operators List in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Customizing Filter Menu Operators List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing filter menu operators list

You can customize the default filter operator list by defining the [`Operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property of [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html).

The available options are:
**stringOperator**- defines customized string operator list.
**numberOperator** - defines customized number operator list.
**dateOperator** - defines customized date operator list.
**booleanOperator** - defines customized boolean operator list.

In the following sample, we have customized string filter operators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/customize-filter-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-filter-menu.cs" %}
{% include code-snippet/grid/how-to/customize-filter-menu/customize-filter-menu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/customize-filter-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-filter-menu.cs" %}
{% include code-snippet/grid/how-to/customize-filter-menu/customize-filter-menu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


