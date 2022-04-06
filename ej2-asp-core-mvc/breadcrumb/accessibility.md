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

The web accessibility makes web content and web applications more accessible for people with disabilities. It especially helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies. Breadcrumb provides built-in compliance with `WAI-ARIA` specifications. The `WAI-ARIA` support is achieved using the attributes such as `aria-disabled`. It helps the people with disabilities by providing information about the widget for assistive technology in the screen readers. Breadcrumb component contains the `breadcrumb` role.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | Indicates the type of input element. |
| aria-disabled | Indicates the state of breadcrumb item whether it is disabled. |

## Keyboard interaction

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>Keyboard shortcuts</b></td>
<td><b>Actions</b></td>
<tr>
<td>
<kbd>Tab</kbd></td><td>
Navigate to the next item.</td></tr>
<tr>
<td>
<kbd>Shift + Tab</kbd></td><td>
Navigate to the previous item.</td></tr>
<tr>
<td>
<kbd>Enter</kbd></td><td>
Click the item.</td></tr>
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


