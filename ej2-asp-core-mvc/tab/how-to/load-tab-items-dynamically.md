---
layout: post
title: How to load Tab items dynamically in ##Platform_Name## Tabs | Syncfusion
description: Add Syncfusion ##Platform_Name## Tabs items dynamically at runtime by passing an array of items and an index value to the `addTab` method.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to load Tab items dynamically in ##Platform_Name##

Tabs can be added dynamically by passing an array of items and an index value to the `addTab` method.

In the following demo, you can add the Tab content by clicking the **+**. Enter the new Tab heading and content details in the available text boxes, click the **Add Tab** button to pass the details as an array and the last index is calculated to append the new Tab at the end.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/dynamic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic.cs" %}
{% include code-snippet/tab/dynamic/dynamic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/dynamic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamic.cs" %}
{% include code-snippet/tab/dynamic/dynamic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


