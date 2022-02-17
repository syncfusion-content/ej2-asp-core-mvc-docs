---
layout: post
title: Set Scroll Top in ##Platform_Name## Gantt Component
description: Learn here all about Set Scroll Top in Syncfusion ##Platform_Name## Gantt component and more.
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