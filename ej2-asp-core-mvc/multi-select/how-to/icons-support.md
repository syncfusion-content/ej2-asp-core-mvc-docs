---
layout: post
title: How to show ##Platform_Name## MultiSelect items with icons | Syncfusion
description: Render Syncfusion ##Platform_Name## MultiSelect list items with iconCss that creates a styled span mapped from each data source item's icon class name.
platform: ej2-asp-core-mvc
control: Icons Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show ##Platform_Name## MultiSelect items with icons

You can render **icons** to the list items by mapping the `iconCss` field. This `iconCss` field create a span in the list item with mapped class name to allow styling as per your need.

In the following sample, icon classes are mapped with `iconCss` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/multiselect/how-to/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/multiselect/how-to/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


