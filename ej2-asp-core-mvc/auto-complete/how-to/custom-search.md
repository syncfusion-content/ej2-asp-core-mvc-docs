---
layout: post
title: Custom Search in ##Platform_Name## Auto Complete Component
description: Learn here all about Custom Search in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Custom Search
publishingplatform: ##Platform_Name##
documentation: ug
---


# Custom highlight search

The AutoComplete has built-in support to highlight the searched characters on suggested list items when
enabled the [highlight](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~Highlight.html) property.

In the below sample, to customize the matched character in suggestion list by `e-highlight` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/autocomplete/how-to/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/autocomplete/how-to/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

