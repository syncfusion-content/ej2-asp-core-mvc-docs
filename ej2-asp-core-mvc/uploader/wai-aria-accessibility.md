---
layout: post
title: Wai Aria Accessibility in ##Platform_Name## Uploader Component
description: Learn here all about Wai Aria Accessibility in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Wai Aria Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The uploader control characterized with complete ARIA accessibility support that helps to be accessible by on-screen readers and other assistive technology devices.

## Keyboard interaction

The following are the standard keys that works on uploader control:

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Tab</kbd> | Moves focus to next element. |
| <kbd>Shift + Tab</kbd> | Moves focus to previous element. |
| <kbd>Enter</kbd> | Triggers corresponding action to the button element. |
| <kbd>Esc</kbd> | Closes the file browser dialog alone and cancels the upload on drop the file. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/keyboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Keyboard.cs" %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/keyboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Keyboard.cs" %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% include code-snippet/uploader/keyboard/keyboard.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

