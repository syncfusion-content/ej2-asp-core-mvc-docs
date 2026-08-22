---
layout: post
title: Layout Sidebar in ##Platform_Name## Sidebar | Syncfusion
description: Learn how to use the Syncfusion ##Platform_Name## Sidebar as a layout component that remains visible across pages while the page content changes during navigation.
platform: ej2-asp-core-mvc
control: Layout Page Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Layout Sidebar in ##Platform_Name## Sidebar

The following example demonstrates how to render sidebar in layout page. Sidebar is displayed in all the view page. While navigate to other view page, main content of sidebar changes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/layout-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextBox.cshtml" %}
{% include code-snippet/sidebar/layout-page/TextBox.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/layout-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextBox.cshtml" %}
{% include code-snippet/sidebar/layout-page/TextBox.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/layout_page.png)
