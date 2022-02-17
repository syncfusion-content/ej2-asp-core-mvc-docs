---
layout: post
title: Set State Persistence Of The Tab Component in ##Platform_Name## Tab Component
description: Learn here all about Set State Persistence Of The Tab Component in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Set State Persistence Of The Tab Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set state persistence of the Tab component

State persistence allows the Tab to retain the current modal value in the browser cookies for state maintenance. This action is handled through the enablePersistence property which is set to false by default.
When it is set to true, some of the Tab component model values will be retained even after refreshing the page.

The following sample demonstrates how to set state persistence of the Tab component.

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