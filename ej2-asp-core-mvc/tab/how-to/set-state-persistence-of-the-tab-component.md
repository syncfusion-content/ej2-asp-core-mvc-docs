---
layout: post
title: How to set state persistence in ##Platform_Name## Tabs | Syncfusion
description: Persist the Syncfusion ##Platform_Name## Tabs state across page refreshes in browser cookies by enabling the `enablePersistence` property.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set state persistence in ##Platform_Name## Tabs

State persistence allows the Tab to retain the current modal value in the browser cookies for state maintenance. You enable state persistence through the [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_EnablePersistence) property which is set to **false** by default. When it is set to **true**, some of the Tabs control model values will be retained even after refreshing the page.

The following sample demonstrates how to set state persistence of the Tabs control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/persistence/styles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/persistence/styles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![State Persistence](../images/persistence.PNG)