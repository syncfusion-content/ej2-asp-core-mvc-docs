---
layout: post
title: Add Nested Tabs in ASP.NET MVC Tab Component
description: Learn here all about Add Nested Tabs in Syncfusion ASP.NET MVC Tab Component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Add Nested Tabs
publishingplatform: ASP.NET MVC
documentation: ug
---


# Add nested Tabs

Tab supports to render the nested level of Tabs by using `content` property. You can add the nested Tab element inside the parent Tab `content` property. To render the nested Tab, initialize the component using the id of Tab from a selected event handler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/nested/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nested.cs" %}
{% include code-snippet/tab/nested/nested.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/nested/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nested.cs" %}
{% include code-snippet/tab/nested/nested.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


