---
layout: post
title: Restrict Groups in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to restrict nested group creation in ##Platform_Name## Query Builder using the MaxGroupCount property.
platform: ej2-asp-core-mvc
control: Restrict Groups
publishingplatform: ##Platform_Name##
documentation: ug
---


# Restrict Groups in ##Platform_Name## Query Builder

You can restrict the groups by defining the `MaxGroupCount` property. By default, the value is 5. To limit the number of nested groups, set `MaxGroupCount` to the desired value, for example, 2.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can use this property in the mobile mode to restrict the nested group creation.