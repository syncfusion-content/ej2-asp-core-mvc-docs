---
layout: post
title: Tab Selection in ##Platform_Name## Tab Component
description: Learn here all about Tab Selection in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Tab Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to find whether the tab is selected programmatically or user interaction

We can able to find the tab selection whether it is selected by user interaction or programmatically way in the `selecting` and `selected` event argument with the field of `isInteracted`. When the user changes the tab through click actions it will return true otherwise, it will return false. The following code example depicts to find the tab selecting the state in selecting and selected events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/tabselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tabselection.cs" %}
{% include code-snippet/tab/tabselection/tabselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/tabselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tabselection.cs" %}
{% include code-snippet/tab/tabselection/tabselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

