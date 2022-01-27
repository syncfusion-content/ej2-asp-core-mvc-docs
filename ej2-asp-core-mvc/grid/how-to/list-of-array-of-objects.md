---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about List Of Array Of Objects of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: List Of Array Of Objects
publishingplatform: ##Platform_Name##
documentation: ug
---


# Complex Data Binding with list of Array Of Objects

The following example shows how to set Complex field for datasource having Array Of Objects.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="complexarray" %}
{% include_relative code-snippet/columns/complexarray/complexarray.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/columns/complexarray/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="complexarray" %}
{% include_relative code-snippet/columns/complexarray/complexarray.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/columns/complexarray/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

