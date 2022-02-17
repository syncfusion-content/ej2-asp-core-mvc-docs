---
layout: post
title: Accessibility in ##Platform_Name## Progress Button Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Progress Button component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

## ARIA attributes

The web accessibility makes web content and web applications more accessible for people with disabilities. Mostly, it helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies. The ProgressButton provides a built-in compliance with `WAI-ARIA` specifications. The `WAI-ARIA` support is achieved using the `aria-label`, `aria-valuemin`, `aria-valuemax`, and `aria-valuenow` attributes in the ProgressButton. It helps by providing information about the widget for assistive technology in the screen readers.

| Properties | Functionality |
| ------------ | ----------------------- |
| aria-label | Indicates the text content of the ProgressButton. |
| aria-valuemin | Indicates the minimum value for the ProgressButton. |
| aria-valuemax | Indicates the maximum value for the ProgressButton. |
| aria-valuenow | Indicates the current value for the ProgressButton. |

## Keyboard interaction

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Enter / Space</kbd></td><td>
Starts the progress</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/accessibility/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/accessibility/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/accessibility/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/accessibility/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

