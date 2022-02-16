---
layout: post
title: Accessibility in ##Platform_Name## Context Menu Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

## ARIA attributes

The web accessibility makes web content and web applications more accessible for people with disabilities. It especially helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies.
ContextMenu provides built-in compliance with `WAI-ARIA` specifications. `WAI-ARIA` support is achieved through the attributes like `aria-expanded` and `aria-haspopup` applied for menu item in
ContextMenu. It helps the people with disabilities by providing information about the widget for assistive
technology in the screen readers. ContextMenu component contains the `menu` role and `menuItem` role.

| Properties | Functionality |
| ------------ | ----------------------- |
| menu | This role will be specified for an item which have sub menu. |
| menuItem | This role will be specified for an item that do not have sub menus. |
| aria-haspopup | Indicates the availability and type of interactive popup element. |
| aria-expanded | Indicates whether the subtree can be expanded or collapsed, as well as indicates whether its current state is expanded or collapsed. |

## Keyboard interaction

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Esc</kbd></td><td>
Closes the opened ContextMenu.</td></tr>
<tr>
<td>
<kbd>Enter</kbd></td><td>
Selects the focused item.</td></tr>
<tr>
<td>
<kbd>Up</kbd></td><td>
Navigates up or to the previous menu item.</td></tr>
<tr>
<td>
<kbd>Down</kbd></td><td>
Navigates down or to the next menu item.</td></tr>
<tr>
<td>
<kbd>Left</kbd></td><td>
Close the current sub menu and navigates to the parent menu.</td></tr>
<tr>
<td>
<kbd>Right</kbd></td><td>
Navigates and open the next sub menu.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/context-menu/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/context-menu/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

