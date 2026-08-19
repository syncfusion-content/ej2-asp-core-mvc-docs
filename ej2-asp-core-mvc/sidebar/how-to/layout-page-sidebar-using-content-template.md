---
layout: post
title: Sidebar Layout in ##Platform_Name## Sidebar | Syncfusion
description: Learn how to create a layout Sidebar using a content template in Syncfusion ##Platform_Name## Sidebar and render a Menu component within the Sidebar.
platform: ej2-asp-core-mvc
control: Layout Page Sidebar Using Content Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Layout Sidebar Using Content Template in ##Platform_Name## Sidebar

In the following example, Menu component  is rendered inside the Sidebar using content template. Initially, the Sidebar renders in the dock state with icons, and expands when the hamburger icon at the top-left corner of the header section is clicked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/content-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml" %}
{% include code-snippet/sidebar/content-template/Index.cshtml %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/sidebar/content-template/controller.cs %}
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
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/sidebar/content-template/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/content_template.png)
