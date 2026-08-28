---
layout: post
title: How to Set Min Height in ##Platform_Name## Pivot Table | Syncfusion
description: Learn how to override the ##Platform_Name## Pivot Table's default 300px minimum height via the minHeight property on the pivot table component.
platform: ej2-asp-core-mvc
control: Changing The Pivotview Component Minimum Height
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change the minimum height of the ##Platform_Name## Pivot Table

The `minHeight` property allows you to set the minimum height for the ##Platform_Name## Pivot Table component. By default, the component maintains a minimum height of **300px**. This property ensures the component remains visible and functional even when the container height is smaller than the specified minimum value.

When the content exceeds the minimum height, the component automatically adjusts to accommodate the data. This property is particularly useful for responsive layouts where the component needs to maintain usability across different screen sizes.

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

