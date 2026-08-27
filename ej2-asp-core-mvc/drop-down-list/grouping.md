---
layout: post
title: Grouping in ##Platform_Name## DropDownList | Syncfusion
description: Group Syncfusion ##Platform_Name## DropDownList items by category using the groupBy field and display headers as inline or fixed using groupTemplate.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping in ##Platform_Name## DropDownList

The DropDownList supports grouping list items into categories based on a data field. The category of each list item can be mapped through the [groupBy](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html#Syncfusion_EJ2_DropDowns_DropDownListFieldSettings_GroupBy) field in the data table. The group header is displayed both as inline and fixed headers. The fixed group header updates dynamically as you scroll, displaying the current category.

In the following sample, vegetables are grouped by category using the `groupBy` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/grouping/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/grouping/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The group header can be customized using the [groupTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_GroupTemplate) property for both inline and fixed headers as referred here:

[Group Template support to DropDownList](./templates).