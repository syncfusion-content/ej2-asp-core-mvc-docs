---
layout: post
title: How to add nested tabs in ##Platform_Name## Tabs | Syncfusion
description: Render nested Syncfusion ##Platform_Name## Tabs by adding a Tab element inside the parent Tab's `content` property and initializing it in a selected event handler.
platform: ej2-asp-core-mvc
control: Add Nested Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add nested tabs in ##Platform_Name## Tabs

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


