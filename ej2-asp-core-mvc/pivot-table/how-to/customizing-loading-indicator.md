---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customizing Loading Indicator of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customizing Loading Indicator
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customizing loading indicator

You can customize the appearance of the loading indicator in the pivot table by using the `spinnerTemplate` property. This property accepts an HTML string which can be used for appearance customization.

> You can also disable the loading indicator by setting `spinnerTemplate` to empty string.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/loading-indicator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/loading-indicator/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/loading-indicator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Fieldlist.cs" %}
{% include code-snippet/pivot-table/loading-indicator/fieldlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

