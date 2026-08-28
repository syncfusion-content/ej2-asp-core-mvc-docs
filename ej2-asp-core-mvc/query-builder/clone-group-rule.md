---
layout: post
title: Clone Group and Rule in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to clone groups and rules in ##Platform_Name## Query Builder using built-in UI options and the cloneGroup and cloneRule methods.
platform: ej2-asp-core-mvc
control: Clone Group/Rule
publishingplatform: ##Platform_Name##
documentation: ug
---


# Clone Groups and Rules in ##Platform_Name## Query Builder

The Query Builder functionality extends to cloning both individual rules and entire groups. Using the Clone options will generate an exact duplicate of a rule or group adjacent to the original one. This feature enables users to replicate complex query structures effortlessly. The [`ShowButtons`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_ShowButtons) function offers users the ability to toggle the visibility of these cloning buttons, providing convenient control over the cloning process within the Query Builder interface.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/clone/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/clone/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/clone/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/clone/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



You can clone groups and rules by interacting through the user interface and methods.

* Use the `cloneGroup` method to clone a group.
* Use the `cloneRule` method to clone a rule.