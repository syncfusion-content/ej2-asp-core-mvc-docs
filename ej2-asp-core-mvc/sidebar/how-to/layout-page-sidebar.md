---
layout: post
title: Layout Page Sidebar in ##Platform_Name## Sidebar Control | Syncfusion
description: Learn here all about Layout Page Sidebar in Syncfusion ##Platform_Name## Sidebar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Layout Page Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Layout Sidebar

The following example demonstrates how to render Sidebar in layout page. Sidebar is displayed in all the view page. While navigate to other view page, main content of Sidebar changes.

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
