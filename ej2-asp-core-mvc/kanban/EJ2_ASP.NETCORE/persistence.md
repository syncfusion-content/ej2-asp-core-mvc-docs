---
layout: post
title: Persistence in ##Platform_Name## Kanban Component
description: Learn here all about Persistence in Syncfusion ##Platform_Name## Kanban component and more.
platform: ej2-asp-core-mvc
control: Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence

State persistence refers to the Kanban state maintained in the browser's [`LocalStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.

State persistence stores Kanban datasource, column or swimlane expand/collapse state in the local storage when the `enablePersistence` is defined as true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/persistence/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/persistence/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


