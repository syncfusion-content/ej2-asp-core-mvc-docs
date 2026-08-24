---
layout: post
title: Show Custom Tooltip with Dynamic HTML in ##Platform_Name## | Syncfusion
description: Load dynamic HTML such as iframes, videos, and maps inside the Syncfusion ##Platform_Name## Tooltip by using string-based HTML in the content property.
platform: ej2-asp-core-mvc
control: Custom Tooltip With Dynamic Html
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to show custom Tooltip with dynamic HTML in ##Platform_Name## Tooltip

Tooltip loads HTML pages via HTML tags such as iframe, video, and map using the `content` property, which supports both string and HTML tags.

To load an `iframe` element in Tooltip, set the required iframe in the `content` of Tooltip while initializing the Tooltip component. Refer to the following code.

```typescript

content: '<iframe src="https://ej2.syncfusion.com/showcase/typescript/expensetracker/#/dashboard"></iframe>

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

