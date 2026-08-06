---
layout: post
title: ##Platform_Name## Grid Array of Objects Binding | Syncfusion
description: Learn how to bind arrays of objects and complex fields in ##Platform_Name## Data Grid to display and manage nested data structures effectively.
platform: ej2-asp-core-mvc
control: List Of Array Of Objects
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bind Array of Objects in ##Platform_Name## Data Grid

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

