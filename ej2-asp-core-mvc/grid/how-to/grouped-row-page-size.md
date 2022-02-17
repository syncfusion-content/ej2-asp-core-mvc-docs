---
layout: post
title: Grouped Row Page Size in ##Platform_Name## Grid Component
description: Learn here all about Grouped Row Page Size in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/group-page-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group-page-size.cs" %}
{% include code-snippet/grid/how-to/group-page-size/group-page-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/group-page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Group-page-size.cs" %}
{% include code-snippet/grid/how-to/group-page-size/group-page-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

