---
layout: post
title: Restrict Groups in ##Platform_Name## Query Builder Component
description: Learn here all about Restrict Groups in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: Restrict Groups
publishingplatform: ##Platform_Name##
documentation: ug
---


# Restrict the groups

You can restrict the groups by defining the `MaxGroupCount` property. By default, the value is 5. In the below demo, the `MaxGroupCount` is set to 2 .

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



> You can use this property in the mobile mode to restrict the nested group creation.