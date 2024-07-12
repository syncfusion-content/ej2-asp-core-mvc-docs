---
layout: post
title: Prevent Date Navigation in ##Platform_Name## Schedule | Syncfusion
description: Learn here all about Prevent Date Navigation in Syncfusion ##Platform_Name## Schedule component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Prevent Date Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Prevent the Date Navigation

We can prevent navigation while clicking on the date header by simply removing `e-navigate` class from header cells which can be achieved in the [`RenderCell`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_RenderCell) event as shown in the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/navigating/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/navigating/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/navigating/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/navigating/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

