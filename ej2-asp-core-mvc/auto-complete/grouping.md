---
layout: post
title: Grouping in ##Platform_Name## Auto Complete Component
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping

The AutoComplete supports wrapping nested elements into a group based on different categories. The
category of each list item can be mapped through the
[groupBy](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings~GroupBy.html) field in the data table. The group
header is displayed as both inline and fixed headers. The fixed group header content
is updated dynamically on scrolling the suggestion list with its category value.

In the following sample, vegetables are grouped according on its category using `groupBy` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/autocomplete/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/autocomplete/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The grouping header is also provided with customization option. This allows custom designing
using the
[groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~GroupTemplate.html) property for both inline and
fixed headers as referred here:

[Group Template support to AutoComplete](./templates).