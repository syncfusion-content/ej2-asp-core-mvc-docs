---
layout: post
title: How to detect tab selection in ##Platform_Name## Tabs | Syncfusion
description: Detect whether a Syncfusion ##Platform_Name## Tabs selection was made by user interaction or programmatically using the `isInteracted` field in the `selecting` event.
platform: ej2-asp-core-mvc
control: Tab Selection
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to detect tab selection in ##Platform_Name## Tabs

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

