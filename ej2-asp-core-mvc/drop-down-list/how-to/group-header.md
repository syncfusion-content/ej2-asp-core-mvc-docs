---
layout: post
title: Disable fixed group headers in DropDownList | Syncfusion
description: Disable Syncfusion ##Platform_Name## DropDownList fixed group headers by setting CSS visibility hidden on the e-fixed-group class element.
platform: ej2-asp-core-mvc
control: Group Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable fixed group headers in ##Platform_Name## DropDownList

The following example demonstrates how to disable the fixed group header in the DropDownList through CSS by setting the `visibility` property. Fixed group headers appear when the DropDownList [fields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html) [groupBy](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html#Syncfusion_EJ2_DropDowns_DropDownListFieldSettings_GroupBy) property is configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/disablefixedheader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/how-to/disablefixedheader/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/disablefixedheader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/how-to/disablefixedheader/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

