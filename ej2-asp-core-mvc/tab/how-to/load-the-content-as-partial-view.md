---
layout: post
title: How to load content as partial view in ##Platform_Name## Tabs | Syncfusion
description: Load Syncfusion ##Platform_Name## Tabs content as partial views by combining dynamic item creation with AJAX or EJ2 DataManager for embedded controls.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to load content as partial view in ##Platform_Name## Tabs

Since Tabs is a navigation control, it does not have built-in support to load content directly or via any DataManager adaptor. However, it supports adding items dynamically. To load content as a partial view, you can use AJAX or the EJ2 DataManager. For more information, refer to the [How to load Tab with data source](./load-tab-with-data-source) documentation.

In the below demo, we have explained on how to create the Tab items dynamically and then to load the other ##Platform_Name## controls in it from partial views.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/partial-view/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Partialview.cs" %}
{% include code-snippet/tab/partial-view/partialview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/partial-view/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Partialview.cs" %}
{% include code-snippet/tab/partial-view/partialview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](../images/grid1.png)

![Alt text](../images/grid2.png)
