---
layout: post
title: Open Close Sidebar in ##Platform_Name## Sidebar Component
description: Learn here all about Open Close Sidebar in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Open Close Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open and close the Sidebar

Opening and closing the Sidebar can be achieved with built-in public methods.

| Method | Description  |
|------|------|
| `show()`  |  Method to open the Sidebar. |
| `hide()`  |  Method to close the Sidebar. |
| `toggle()`  |  Method to toggle the open/close state of the Sidebar. |

In the following sample, toggle method has been used to show or hide the Sidebar on button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/howto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Open.cs" %}
{% include code-snippet/sidebar/howto/open.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/howto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Open.cs" %}
{% include code-snippet/sidebar/howto/open.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/open_close.png)