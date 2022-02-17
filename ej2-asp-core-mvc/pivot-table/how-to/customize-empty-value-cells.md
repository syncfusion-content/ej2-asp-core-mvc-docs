---
layout: post
title: Customize Empty Value Cells in ##Platform_Name## Pivot Table Component
description: Learn here all about Customize Empty Value Cells in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Customize Empty Value Cells
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize empty value cells

You can show the custom string in the empty value cells using the `emptyCellsTextContent` string type property in `dataSourceSettings` object of the pivot table. It can be configured through code behind during initial rendering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomText.cs" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/CustomText.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomText.cs" %}
{% include code-snippet/pivot-table/custom-cell-text/custom-cell-text/CustomText.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


