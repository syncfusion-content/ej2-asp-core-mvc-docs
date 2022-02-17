---
layout: post
title: Customize Selected Tab Styles in ##Platform_Name## Tab Component
description: Learn here all about Customize Selected Tab Styles in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Customize Selected Tab Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize selected tab styles

You can customize the Tab style by overriding its header and active tab CSS classes. Define HTML string for adding animation and customizing the Tab header and pass it to [text](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TabHeader~Text.html) property. Now you can override the style using custom CSS classes added to the Tab elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/tab/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize.cs" %}
{% include code-snippet/tab/customize/customize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](../images/tab.PNG)