---
layout: post
title: How to customize Tab scroll step in ##Platform_Name## Tabs | Syncfusion
description: Customize the Syncfusion ##Platform_Name## Tab scrolling distance when clicking the left or right navigation icons by setting the `scrollStep` property.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize Tab scroll step in ##Platform_Name## Tabs

The Tabs control supports customizing the scrolling distance when users click the left or right navigation icons. We can customize [ScrollStep](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_ScrollStep) property to control the scrolling distance. Refer to the following code example.

Set the `ScrollStep` property to the desired value to customize the scroll distance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/scrollstep/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/scrollstep/styles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/scrollstep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/scrollstep/styles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

