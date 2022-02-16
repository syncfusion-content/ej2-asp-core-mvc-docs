---
layout: post
title: State Persistence in ##Platform_Name## Query Builder Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence

State persistence allows you to maintain the current state in the browser’s `localStorage` even if the browser is refreshed or if you move to the next page within the browser. State persistence stores the Query Builder’s `Rule` object in the local storage when the `EnablePersistence` is defined to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/state-persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/how-to/state-persistence/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/state-persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/how-to/state-persistence/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

