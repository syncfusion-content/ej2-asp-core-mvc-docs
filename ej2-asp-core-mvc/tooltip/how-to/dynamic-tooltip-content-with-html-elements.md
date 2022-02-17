---
layout: post
title: Dynamic Tooltip Content With Html Elements in ##Platform_Name## Tooltip Component
description: Learn here all about Dynamic Tooltip Content With Html Elements in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Dynamic Tooltip Content With Html Elements
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dynamic Tooltip content with HTML elements

The Tooltip component loads HTML tags using the [content](https://ej2.syncfusion.com/documentation/tooltip/content.html?lang=typescript) template.

The HTML tags such as `<div>`, `<span>`, `bold`, `italic`, `underline`, etc., can be used. Style attributes can also be applied with HTML tags.

Here, Bold, Italic, Underline, and Anchor tags are used.

When using HTML elements as content to `Tooltip` make the content element `display: none`, then from the
[`beforeRender`](https://ej2.syncfusion.com/documentation/tooltip/api-tooltip.html?lang=typescript#beforerender)
event we can make the element visible again using below code.

```typescript
    document.getElementById('content').style.display = 'block';
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/html-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html-content.cs" %}
{% include code-snippet/tooltip/html-content/html-content.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/html-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html-content.cs" %}
{% include code-snippet/tooltip/html-content/html-content.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

