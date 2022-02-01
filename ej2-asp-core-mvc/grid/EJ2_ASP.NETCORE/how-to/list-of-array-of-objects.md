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
{% include code-snippet/grid/columns/complexarray/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="complexarray" %}
{% include code-snippet/grid/columns/complexarray/complexarray.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="complexarray" %}
{% include code-snippet/grid/columns/complexarray/razor %}
{% endhighlight %}
{% highlight c# tabtitle="complexarray" %}
{% include code-snippet/grid/columns/complexarray/complexarray.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

