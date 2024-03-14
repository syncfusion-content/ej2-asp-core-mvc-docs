---
layout: post
title: Lock Group/Rule in ##Platform_Name## Query Builder Component
description: Learn here all about Lock Group/Rule in Syncfusion ##Platform_Name## Query Builder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Lock Group/Rule
publishingplatform: ##Platform_Name##
documentation: ug
---


# Lock Group/Rule

Query Builder allows you to lock rules as well as groups. When a rule is locked, the field, operator, and value will be disabled. When a group is locked, all the elements within the group will be disabled. You can use `ShowButtons` to enable/disable these buttons.

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