---
layout: post
title: How to customize selected Tab styles in ##Platform_Name## | Syncfusion
description: Customize the selected Tab style in Syncfusion ##Platform_Name## Tab by overriding the header and active Tab CSS classes with custom styles.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize selected Tab styles in ##Platform_Name##

You can customize the Tab style by overriding its header and active Tab CSS classes. Define an HTML string to add animation and customize the Tab header and pass it to [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabHeader.html#Syncfusion_EJ2_Navigations_TabHeader_Text) property. Now you can override the style using custom CSS classes added to the Tab elements.

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