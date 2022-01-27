---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grouped Row Page Size of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grouped Row Page Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show grouped rows based on the pageSize

By default, we have displayed the no of records based on the `pageSize`. If you want to show grouped column rows based on the `pageSize` then we suggest you to use the below way.

In the below sample, we have overridden the default `generateQuery` to display the grouped rows instead of grid rows based on the `pageSize`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="group-page-size" %}
{% include_relative code-snippet/how-to/group-page-size/group-page-size.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="group-page-size" %}
{% include_relative code-snippet/how-to/group-page-size/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="group-page-size" %}
{% include_relative code-snippet/how-to/group-page-size/group-page-size.cs %}
{% endhighlight %}
{% highlight razor tabtitle="group-page-size" %}
{% include_relative code-snippet/how-to/group-page-size/razor %}
{% endhighlight %}
{% endtabs %}

