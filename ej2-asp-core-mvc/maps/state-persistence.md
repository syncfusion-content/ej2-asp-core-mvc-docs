---
layout: post
title: State Persistence in ##Platform_Name## Maps Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---

# State Persistence

## State persistence

For state maintenance, state persistence allows Maps to save the current model value in browser cookies. This action is handled through the `EnablePersistence` property which is set to **false** by default. When this property is set to true, some of the Maps component model values are preserved even after the page is refreshed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Persistence.cs" %}
{% include code-snippet/maps/markers/persistence/persistence.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/markers/persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Persistence.cs" %}
{% include code-snippet/maps/markers/persistence/persistence.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

