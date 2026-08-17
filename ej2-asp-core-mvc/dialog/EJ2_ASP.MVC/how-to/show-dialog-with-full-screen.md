---
layout: post
title: How to show Dialog in fullscreen in ASP.NET MVC Dialog | Syncfusion
description: Show the Syncfusion ASP.NET MVC Dialog in fullscreen by passing true as an argument to the show method on the Dialog instance.
platform: ej2-asp-core-mvc
control: Show Dialog With Full Screen
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show Dialog in fullscreen in ASP.NET MVC Dialog

You can show the dialog in fullscreen by passing `true` as argument to the dialog `show` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/fullscreen/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/fullscreen/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/fullscreen/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/fullscreen/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

