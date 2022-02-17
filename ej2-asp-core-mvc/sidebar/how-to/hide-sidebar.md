---
layout: post
title: Hide Sidebar in ##Platform_Name## Sidebar Component
description: Learn here all about Hide Sidebar in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Hide Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hide Sidebar

The following example demonstrates how to hide layout page sidebar. Initially sidebar is rendered with layout page. While navigate to another page, it hides the layout page sidebar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/hide-sidebar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contact.cshtml" %}
{% include code-snippet/sidebar/hide-sidebar/Contact.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/hide-sidebar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contact.cshtml" %}
{% include code-snippet/sidebar/hide-sidebar/Contact.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below in layout page.

![Sidebar Sample](../images/hide_sidebar.png)

Output be like the below, while navigate to other page, it hides the layout page sidebar.

![Sidebar Sample](../images/hide_sidebar1.png)
