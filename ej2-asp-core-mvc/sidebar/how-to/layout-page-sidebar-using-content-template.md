---
layout: post
title: Layout Page Sidebar Using Content Template in ##Platform_Name## Sidebar Component
description: Learn here all about Layout Page Sidebar Using Content Template in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Layout Page Sidebar Using Content Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Layout Sidebar using Content Template

In the following example, Menu component  is rendered inside the Sidebar using content template. Initially, the Sidebar renders in the dock state with icons, and expands when the hamburger icon at the top-left corner of the header section is clicked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/content-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/content-template/Index.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/content-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/content-template/Index.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/content_template.png)
