---
layout: post
title: Grouping in ##Platform_Name## Combo Box Control | Syncfusion
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Combo Box control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping in Combo Box Control

The ComboBox supports wrapping nested elements into a group based on different categories. The category of each list item can be mapped through the [groupBy](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBoxFieldSettings.html#Syncfusion_EJ2_DropDowns_ComboBoxFieldSettings_GroupBy) field in the data table. The group header is displayed both as inline and fixed headers. The fixed group header content is updated dynamically on scrolling the popup list with its category value.

In the following sample, vegetables are grouped according on its category using `groupBy` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class Vegetables
{
    public string Vegetable { get; set; }
    public string Category { get; set; }
    public string Id { get; set; }
}
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

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ComboBox/TemplateUGSample).

## Customization

The grouping header is also provided with customization option. This allows custom designing using the `groupTemplate` property for both inline and fixed headers as referred here:
[Group Template support to ComboBox](./templates).