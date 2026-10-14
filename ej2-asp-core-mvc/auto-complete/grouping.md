---
layout: post
title: Grouping in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Grouping in Syncfusion ##Platform_Name## AutoComplete control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grouping in ##Platform_Name## AutoComplete

The AutoComplete supports grouping nested elements into categories. The category of each list item can be mapped through the [groupBy](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings.html#Syncfusion_EJ2_DropDowns_AutoCompleteFieldSettings_GroupBy) field in the data table. The group header is displayed as both inline and fixed headers. The fixed group header content is updated dynamically on scrolling the suggestion list with its category value.

In the following sample, vegetables are grouped according to their category using the `groupBy` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/grouping/tagHelper %}
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
{% include code-snippet/autocomplete/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/autocomplete/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customization

The grouping header also provides customization options. This allows custom designing using the [groupTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_GroupTemplate) property for both inline and fixed headers as shown here:

[Group template support in AutoComplete](./templates#group-template).

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/AutoComplete/GroupingandFilreringSample).