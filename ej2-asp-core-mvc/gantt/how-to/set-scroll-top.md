---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set Scroll Top of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set Scroll Top
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the vertical scroll position

In the Gantt control, you can set the vertical scroller position dynamically by clicking the custom button using the `setScrollTop` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/setScrollTop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SetScrollTop.cs" %}
{% include code-snippet/gantt/how-to/setScrollTop/setScrollTop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/setScrollTop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SetScrollTop.cs" %}
{% include code-snippet/gantt/how-to/setScrollTop/setScrollTop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](../images/setScrollTop.png)