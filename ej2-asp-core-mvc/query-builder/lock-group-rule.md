---
layout: post
title: Lock Group/Rule in ##Platform_Name## Query Builder Component | Syncfusion
description: Learn here all about Lock Group/Rule in Syncfusion ##Platform_Name## Query Builder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Lock Group/Rule
publishingplatform: ##Platform_Name##
documentation: ug
---


# Lock Group/Rule in ##Platform_Name## Query builder control

The Query Builder provides the functionality to lock individual rules or entire groups. When a rule is locked, it prevents users from modifying its field, operator, and value, effectively disabling these components. Similarly, locking a group disables all elements contained within it. This feature offers users greater control over their query configurations, ensuring that specific rules or groups remain unchanged. Additionally, users can manage the visibility of locking buttons through the `ShowButtons` function, allowing for seamless control over the locking mechanism.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/lock/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/lock/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/lock/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/lock/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



You can lock groups and rules by interacting through the user interface and methods.

* Use the `lockGroup` method to lock group.
* Use the `lockRule` method to lock rule.