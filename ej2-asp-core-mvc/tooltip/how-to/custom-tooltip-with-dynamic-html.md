---
layout: post
title: Custom Tooltip With Dynamic Html in ##Platform_Name## Tooltip Component
description: Learn here all about Custom Tooltip With Dynamic Html in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Custom Tooltip With Dynamic Html
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom Tooltip with dynamic HTML

Tooltip loads HTML pages via HTML tags such as iframe, video, and map using the [`content`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#content) property, which supports both string and HTML tags.

To load an `iframe` element in tooltip, set the required iframe in the `content` of tooltip while initializing the tooltip component. Refer to the following code.

```typescript

content: '<iframe src="https://www.syncfusion.com/products/essential-js2"></iframe>

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/html-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html-page.cs" %}
{% include code-snippet/tooltip/html-page/html-page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/html-page/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html-page.cs" %}
{% include code-snippet/tooltip/html-page/html-page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

