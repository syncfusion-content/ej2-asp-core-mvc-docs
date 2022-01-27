---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Focus of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Focus
publishingplatform: ##Platform_Name##
documentation: ug
---


# Focus the double clicked column in the edit form

You can focus the double clicked column edit form an through an [`recordDoubleClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~recordDoubleClick.html) event. With the help of this event you can focus the double clicked column in inline edit mode.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="focus" %}
{% include_relative code-snippet/how-to/focus/focus.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="focus" %}
{% include_relative code-snippet/how-to/focus/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="focus" %}
{% include_relative code-snippet/how-to/focus/focus.cs %}
{% endhighlight %}
{% highlight razor tabtitle="focus" %}
{% include_relative code-snippet/how-to/focus/razor %}
{% endhighlight %}
{% endtabs %}

