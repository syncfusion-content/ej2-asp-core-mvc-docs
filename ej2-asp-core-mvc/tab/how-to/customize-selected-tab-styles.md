---
layout: post
title: How to customize selected tab styles in ##Platform_Name## Tabs | Syncfusion
description: Customize the selected tab style in Syncfusion ##Platform_Name## Tabs by overriding the header and active tab CSS classes with custom styles.
platform: ej2-asp-core-mvc
control: Customize Selected Tab Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize selected tab styles in ##Platform_Name## Tabs

You can customize the Tab style by overriding its header and active tab CSS classes. Define HTML string for adding animation and customizing the Tab header and pass it to [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabHeader.html#Syncfusion_EJ2_Navigations_TabHeader_Text) property. Now you can override the style using custom CSS classes added to the Tab elements.

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