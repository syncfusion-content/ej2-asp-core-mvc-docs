---
layout: post
title: Highlight Matched Characters in ##Platform_Name## DropDownList | Syncfusion
description: Highlight matched characters in Syncfusion ##Platform_Name## DropDownList filtering by calling the highlightSearch method to bold the typed substring.
platform: ej2-asp-core-mvc
control: Highlight Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Highlight Matching Characters in ##Platform_Name## DropDownList

By using the **highlightSearch** method, you can highlight the matched character in DropDownList filtering.

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

