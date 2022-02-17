---
layout: post
title: List Of Array Of Objects in ##Platform_Name## Grid Component
description: Learn here all about List Of Array Of Objects in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: List Of Array Of Objects
publishingplatform: ##Platform_Name##
documentation: ug
---


# Complex Data Binding with list of Array Of Objects

The following example shows how to set Complex field for datasource having Array Of Objects.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexarray/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complexarray.cs" %}
{% include code-snippet/grid/columns/complexarray/complexarray.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/complexarray/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complexarray.cs" %}
{% include code-snippet/grid/columns/complexarray/complexarray.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

