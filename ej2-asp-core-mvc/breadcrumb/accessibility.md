---
layout: post
title: Accessibility in ##Platform_Name## Breadcrumb Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Breadcrumb component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The web accessibility makes web content and web applications more accessible for people with disabilities. It especially helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies. Breadcrumb provides built-in compliance with `WAI-ARIA` specifications. The `WAI-ARIA` support is achieved using the attributes such as `aria-label`and `aria-disabled`. It helps the people with disabilities by providing information about the widget for assistive technology in the screen readers. Breadcrumb component contains the `breadcrumb` role.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | Indicates the type of input element. |
| aria-label | Indicates the breadcrumb item text. |
| aria-disabled | Indicates the state of breadcrumb item whether it is disabled. |

## Keyboard interaction

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Keyboard shortcuts</b></td>
<td><b>Actions</b></td></tr>
<tr>
<td>
<kbd>Tab</kbd></td><td>
Navigate to the next item and also next item in the popup of menu type overflow.</td></tr>
<tr>
<td>
<kbd>Shift + Tab</kbd></td><td>
Navigate to the previous item also previous item in the popup of menu type overflow.</td></tr>
<tr>
<td>
<kbd>Enter key in normal mode</kbd></td><td>
 Select the breadcrumb item.</td></tr>
<tr>
<td>
<kbd>Enter key in collapsed mode</kbd></td><td>
 To open the popup of menu type overflow mode when you press enter on collapsed button and It will expand the items of collapsed type overflow mode when you press enter on collapsed button.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/getting-started/enable-disable/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Breadcrumb/BreadcrumbSamples).