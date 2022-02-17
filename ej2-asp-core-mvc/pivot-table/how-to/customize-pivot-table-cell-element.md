---
layout: post
title: Customize Pivot Table Cell Element in ##Platform_Name## Pivot Table Component
description: Learn here all about Customize Pivot Table Cell Element in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Customize Pivot Table Cell Element
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize pivot table cell element

You can customize the pivot table cell element by using the `cellTemplate` property.
The cellTemplate property accepts either an HTML string or the element's ID, which can be used to append additional HTML elements to showcase each cell with custom format.

In this demo, the revenue cost for each year is represented with trend icons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/celltemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CellTemplate.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/celltemplate/CellTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-mvc/celltemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CellTemplate.cs" %}
{% include code-snippet/pivot-table/getting-start-mvc/celltemplate/CellTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


