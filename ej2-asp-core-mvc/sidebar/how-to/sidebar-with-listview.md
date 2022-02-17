---
layout: post
title: Sidebar With Listview in ##Platform_Name## Sidebar Component
description: Learn here all about Sidebar With Listview in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Sidebar With Listview
publishingplatform: ##Platform_Name##
documentation: ug
---


# Initialize the Sidebar with ListView

Any HTML element can be placed in the Sidebar content area. Sidebar supports all types of HTML structures like `TreeView`, `ListView`, etc.

In the following example, the Sidebar is rendered with ListView component in its content area.

* Add the HTML div tag with its id attribute as `default` in your `index.html` file to initialize the Sidebar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/howto/howto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sidebar.cs" %}
{% include code-snippet/sidebar/howto/howto/sidebar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/howto/howto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sidebar.cs" %}
{% include code-snippet/sidebar/howto/howto/sidebar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below in Expanded state, the sidebar width is set as 100%.

![Sidebar Sample](../images/listView.png)

In Collapsed state, the output be like the below.

![Sidebar Sample](../images/listView_collapsed.png)
