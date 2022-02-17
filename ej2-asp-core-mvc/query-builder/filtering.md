---
layout: post
title: Filtering in ##Platform_Name## Query Builder Component
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering

Query Builder allows you to create or delete conditions and groups. You can use `ShowButtons` to enable/disable these buttons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/filtering/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/filtering/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



You can create or delete conditions by interacting through the user interface and methods.

* Use the `addRules` and `deleteRules` methods to create/delete conditions.
* Use the `addGroups` and `deleteGroups` methods to create/delete groups.