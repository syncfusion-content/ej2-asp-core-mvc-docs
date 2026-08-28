---
layout: post
title: How to Hide Empty Headers in ASP.NET Core Pivot Table | Syncfusion
description: Learn how to hide "Undefined" headers in the ASP.NET Core Pivot Table by setting the showHeaderWhenEmpty property under e-datasourcesettings to false.
platform: ej2-asp-core-mvc
control: Hide Empty Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to hide empty headers in ASP.NET Core Pivot Table

When the raw data for a particular field is not defined, it will be shown as 'Undefined' in the pivot table headers. You can hide those headers by setting the [`showHeaderWhenEmpty`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_ShowHeaderWhenEmpty_System_Boolean_) property to **false** in the pivot table.

For example, when the raw data contains **"United Kingdom"** for the 'Country' field but the **"State"** field is undefined in the data, the header displays as **"United Kingdom >> Undefined"**. Here, you can hide those 'Undefined' headers using the [`showHeaderWhenEmpty`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettingsBuilder.html#Syncfusion_EJ2_PivotView_PivotViewDataSourceSettingsBuilder_ShowHeaderWhenEmpty_System_Boolean_) property.

> By default, this property is set to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hide-headers/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/hide-headers/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/hide-headers/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/hide-headers/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


