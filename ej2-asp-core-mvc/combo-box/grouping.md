---
layout: post
title: Grouping in ##Platform_Name## Combo Box Component
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Combo Box component and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping

The ComboBox supports wrapping nested elements into a group based on different categories. The category
of each list item can be mapped through the [groupBy](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBoxFieldSettings~GroupBy.html) field in
the data table. The group header is displayed both as inline and fixed headers. The fixed group header content
is updated dynamically on scrolling the popup list with its category value.

In the following sample, vegetables are grouped according on its category using `groupBy` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/combobox/grouping/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/combobox/grouping/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The grouping header is also provided with customization option. This allows custom designing using the `groupTemplate` property for both inline and fixed headers as referred here:
[Group Template support to ComboBox](./templates).