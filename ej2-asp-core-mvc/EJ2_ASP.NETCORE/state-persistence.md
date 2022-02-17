---
layout: post
title: State Persistence in ##Platform_Name## Ej2_asp.netcore Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Ej2_asp.netcore component and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---

# State Persistence

Essential JS 2 has support for persisting component’s state across page refreshes or navigation. To
enable this feature, set `enablePersistence` property as true to the required component. This will store
the component’s state in browser’s `localStorage` object on page `unload` event. For example, we have
enabled persistence to grid component in the following code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Persistence.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Persistence.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

