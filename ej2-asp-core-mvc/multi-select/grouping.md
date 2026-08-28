---
layout: post
title: Grouping in ##Platform_Name## MultiSelect | Syncfusion
description: Group Syncfusion ##Platform_Name## MultiSelect items by category using the groupBy field, with inline or fixed group headers rendered via groupTemplate.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping MultiSelect items

The MultiSelect supports grouping list items by category. The category of each list item can be mapped through the [groupBy](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelectFieldSettings.html#Syncfusion_EJ2_DropDowns_MultiSelectFieldSettings_GroupBy) field in the data table. The group header is displayed as both inline and fixed headers. The fixed group header content is updated dynamically as the popup list scrolls, showing the current category.

In the following sample, vegetables are grouped by their category using the `groupBy` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/multiselect/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/multiselect/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customization

The grouping header supports customization. You can design custom inline or fixed headers by using the `groupTemplate` property, as described in [Group Template support for MultiSelect](./templates).

## Grouping with checkbox

Earlier releases did not provide a checkbox in group headers. With this feature, you can render a checkbox in the group header to select all items in the group in a single selection. Enable this feature by setting the [`enableGroupCheckBox`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_EnableGroupCheckBox) property to `true` and the `mode` property to `CheckBox`.

Inject the `CheckBoxSelection` module into the MultiSelect to use the checkbox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/grouping-with-checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/multiselect/grouping-with-checkbox/grouping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/grouping-with-checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/multiselect/grouping-with-checkbox/grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below:

![MultiSelect with checkboxes rendered in the group headers](images/grouping-with-checkbox.png)