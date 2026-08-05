---
layout: post
title: How to Set Min Height in ##Platform_Name## Pivot Table | Syncfusion
description: Learn how to override the ##Platform_Name## Pivot Table's default 300px minimum height via the minHeight property on the pivot table component.
platform: ej2-asp-core-mvc
control: Changing The Pivotview Component Minimum Height
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Change the Minimum Height in ##Platform_Name## Pivot Table

The `minHeight` property allows you to change the minimum height for the pivot table control. For the pivot table control, the default minimum height is **300px**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/min-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MinHeight.cs" %}
{% include code-snippet/pivot-table/summary-customization/min-height/MinHeight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/summary-customization/min-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MinHeight.cs" %}
{% include code-snippet/pivot-table/summary-customization/min-height/MinHeight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

