---
layout: post
title: Real Time Example Using Spinner in ##Platform_Name## Spinner | Syncfusion
description: Learn how to use Syncfusion ##Platform_Name## Spinner to indicate data loading while expanding collapsed swimlane rows in a Kanban control.
platform: ej2-asp-core-mvc
control: Spinner
publishingplatform: ##Platform_Name##
documentation: ug
---

# Real Time Example Using Spinner in ##Platform_Name## Spinner

In the following sample, you can see the Spinner when expanding the collapsed swimlane rows in Kanban control. The Spinner indicates the loading data while fetching the data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spinner/how-to/real-time/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/spinner/how-to/real-time/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spinner/how-to/real-time/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/spinner/how-to/real-time/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output will be like the below.

![spinner](../images/real-spinner.png)
