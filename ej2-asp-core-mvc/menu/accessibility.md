---
layout: post
title: Accessibility in ##Platform_Name## Menu Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

## ARIA attributes

The web accessibility makes web content and web applications more accessible for people with disabilities.
It especially helps in dynamic content change and development of advanced user interface controls with
AJAX, HTML, JavaScript, and related technologies.
The menu provides a built-in compliance with `WAI-ARIA` specifications.
The `WAI-ARIA` support is achieved using the attributes such as `aria-orientation`, `aria-label`,
`aria-expanded`, `aria-disabled`, and `aria-haspopup` applied for menu item in menu.
It helps the people with disabilities by providing information about the widget for assistive technology
in the screen readers. The menu component contains the `menubar`, `menu`, and `menuItem` roles.

| Properties | Functionality |
| ------------ | ----------------------- |
| menubar | This role will be specified for root menu. |
| menu | This role will be specified for an item that have sub menu. |
| menuitem | This role will be specified for an item that do not have sub menus. |
| aria-haspopup | Indicates the availability and type of interactive popup element. |
| aria-expanded | Indicates whether the subtree can be expanded or collapsed, and indicates whether its current state can be expanded or collapsed. |
| aria-orientation | Indicates whether the orientation is horizontal or vertical. The default orientation is horizontal. |
| aria-label | Indicates the menu item text. |
| aria-disabled | Indicates the state of menu item whether it is disabled. |

## User interaction with keyboard

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Esc</kbd></td><td>
Closes the sub menu that contains focus and returns focus to the parent element.</td></tr>
<tr>
<td>
<kbd>Enter</kbd></td><td>
Opens the sub menu if focused menu item has sub menu, and places focus on its first item or activates the item and closes the sub menu.</td></tr>
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
Closes the current sub menu and navigates to the parent menu.</td></tr>
<tr>
<td>
<kbd>Right</kbd></td><td>
Navigates and open the next sub menu.</td></tr>
<tr>
<td>
<kbd>Home</kbd></td><td>
Focuses the first item.</td></tr>
<tr>
<td>
<kbd>End</kbd></td><td>
Focuses the last item.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/menu/accessibility/Accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/menu/accessibility/Accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

