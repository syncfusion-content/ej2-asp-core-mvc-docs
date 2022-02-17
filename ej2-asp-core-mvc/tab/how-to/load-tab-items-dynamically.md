---
layout: post
title: Load Tab Items Dynamically in ##Platform_Name## Tab Component
description: Learn here all about Load Tab Items Dynamically in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Load Tab Items Dynamically
publishingplatform: ##Platform_Name##
documentation: ug
---


# Load Tab items dynamically

Tabs can be added dynamically by passing array of items and index value to the addTab method.

In the following demo, you can add the tab content by clicking the **+**. Enter the new Tab heading and  content details in the available text boxes, click 'Add Tab' button to pass the details as an array and here last index is calculated to append the new tab at the end.

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


