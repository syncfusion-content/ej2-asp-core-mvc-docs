---
layout: post
title: Limit search results in DropDownList | Syncfusion
description: Limit Syncfusion ##Platform_Name## DropDownList filter result count by overriding the search action handler and limiting the processed items array.
platform: ej2-asp-core-mvc
control: Search On Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to limit search results in ##Platform_Name## DropDownList filtering

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Limitsearch.cs" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/limitsearch.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Limitsearch.cs" %}
{% include code-snippet/dropdownlist/how-to/limitsearch/limitsearch.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

