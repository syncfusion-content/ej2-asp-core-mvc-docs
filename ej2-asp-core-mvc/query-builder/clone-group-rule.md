---
layout: post
title: Clone Group/Rule in ##Platform_Name## Query Builder Component
description: Learn here all about Clone Group/Rule in Syncfusion ##Platform_Name## Query Builder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Clone Group/Rule
publishingplatform: ##Platform_Name##
documentation: ug
---


# Clone Group/Rule

Query Builder allows you to clone rules as well as groups. The Clone options will create an exact replica of a rule or group next to the original. You can use `ShowButtons` to enable/disable these buttons.

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

* Use the `cloneGroup` method to clone group.
* Use the `cloneRule` method to clone rule.