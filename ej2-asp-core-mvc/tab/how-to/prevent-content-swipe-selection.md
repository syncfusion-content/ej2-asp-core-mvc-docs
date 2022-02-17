---
layout: post
title: Prevent Content Swipe Selection in ##Platform_Name## Tab Component
description: Learn here all about Prevent Content Swipe Selection in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Prevent Content Swipe Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent content swipe selection

We can prevent the tab selection on touch swipe action by using the Tab [selecting](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Tab~Selecting.html) &nbsp;event. Refer the below sample with preventing swipe selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/swipe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Swipe.cs" %}
{% include code-snippet/tab/swipe/swipe.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/swipe/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Swipe.cs" %}
{% include code-snippet/tab/swipe/swipe.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

