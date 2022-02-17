---
layout: post
title: Hide Empty Headers in ##Platform_Name## Pivot Table Component
description: Learn here all about Hide Empty Headers in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Hide Empty Headers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Hide empty headers

If the raw data for a particular field is not defined, it will be shown as 'Undefined' in the pivot table headers. You can hide those headers by setting the `showHeaderWhenEmpty` property to **false** in the pivot table.

For example, if the raw data for the field 'Country' is defined as **"United Kingdom"** and **"State"** is not defined means, it will be shown as **"United Kingdom >> Undefined"** in the header section. Here, you can hide those 'Undefined' header using the `showHeaderWhenEmpty` property.

> By default, this property is set as **true**.

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


