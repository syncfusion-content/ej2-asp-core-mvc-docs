---
layout: post
title: Sidebar With Partial View in ##Platform_Name## Sidebar Control
description: Learn here all about Sidebar With Partial View in Syncfusion ##Platform_Name## Sidebar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Sidebar With Partial View
publishingplatform: ##Platform_Name##
documentation: ug
---


# Sidebar with partial view

The following example demonstrates how to render the Sidebar with partial view. Sidebar element is  placed inside the RenderPartialView.cshtml and refer that Sidebar element in layout page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/partial-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TextBox.cshtml" %}
{% include code-snippet/sidebar/partial-view/TextBox.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="_RenderPartialView_core.cshtml" %}
{% include code-snippet/sidebar/partial-view/_RenderPartialView_core.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/partial-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextBox.cshtml" %}
{% include code-snippet/sidebar/partial-view/TextBox.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="_RenderPartialView_mvc.cshtml" %}
{% include code-snippet/sidebar/partial-view/_RenderPartialView_mvc.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below in layout page.

![Sidebar Sample](../images/layout_page.png)
