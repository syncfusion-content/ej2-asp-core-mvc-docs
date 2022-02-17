---
layout: post
title: Highlight Filtering in ##Platform_Name## Drop Down List Component
description: Learn here all about Highlight Filtering in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Highlight Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Highlight the matched character in filtering

By using the **highlightSearch** method, you can highlight the matched character in DropDownList filtering.

The following example demonstrates about how to highlight the matched character in filtering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/dropdownlist/how-to/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/dropdownlist/how-to/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

