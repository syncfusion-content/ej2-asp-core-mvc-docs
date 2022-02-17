---
layout: post
title: Add Toggle Button in ##Platform_Name## Toolbar Component
description: Learn here all about Add Toggle Button in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Add Toggle Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Toggle Button

Toolbar supports to add a toggle Button by using the template property. Refer below steps

* By using Toolbar template property, pass required HTML String to render toggle button.

```typescript
    template='<button class="e-btn" id="media_btn"></button>'
```

* Now render the toggle Button into the targeted element in Toolbar created event handler and bind click event for it.
On clicking the toggle Button, change the required icon and content based on current active state.

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

