---
layout: post
title: How to add toggle button in ##Platform_Name## Toolbar | Syncfusion
description: Add a toggle button to the Syncfusion ##Platform_Name## Toolbar using the `template` property and bind a click event to change icons on state change.
platform: ej2-asp-core-mvc
control: Add Toggle Button
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Add Toggle Button in ##Platform_Name## Toolbar

You can add a toggle button to the Toolbar by using the template property. Follow these steps below.

* By using Toolbar template property, pass the required HTML string to render the toggle button.

```typescript
    template='<button class="e-btn" id="media_btn"></button>'
```

* Render the toggle button into the targeted element in the Toolbar created event handler and bind a click event to it. When the toggle button is clicked, change the required icon and content based on the current active state.

For accessibility, ensure your toggle button includes the appropriate ARIA attributes (such as `aria-pressed`) to properly indicate its state to assistive technologies.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/togglebutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Togglebutton.cs" %}
{% include code-snippet/toolbar/how-to/togglebutton/togglebutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/togglebutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Togglebutton.cs" %}
{% include code-snippet/toolbar/how-to/togglebutton/togglebutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

