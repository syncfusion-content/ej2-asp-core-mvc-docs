---
layout: post
title: Accessibility in ##Platform_Name## Query Builder Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Query Builder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

The web accessibility makes web content and web applications more accessible for people with disabilities. It especially helps in dynamic content change and development of advanced user interface controls with AJAX, HTML, JavaScript, and related technologies. Query Builder provides built-in compliance with `WAI-ARIA` specifications. `WAI-ARIA` support is achieved through the attributes such as `aria-label`,`aria-disabled`,`aria-haspopup`,`aria-expanded` and `aria-orientation`. It helps the people with disabilities by providing information about the widget for assistive technology in the screen readers. Query Builder component contains the `query builder` role.

| Properties | Functionality |
| ------------ | ----------------------- |
| role | Indicates the type of input element. |
| aria-label | Indicates the menu item text. |
| aria-disabled | Indicates the state of query builder item whether it is disabled. |
| aria-haspopup | Indicates the availability and type of interactive popup element. |
| aria-expanded | Indicates whether the subtree can be expanded or collapsed, and indicates whether its current state can be expanded or collapsed. |
| aria-orientation | Indicates whether the orientation is horizontal or vertical. |


## Keyboard interaction

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td>
<b>Keyboard shortcuts</b></td><td>
<b>Actions</b></td></tr>
<tr>
<td>
<kbd>Enter/Space</kbd></td><td>
Selects the focused item, and When it is in an open state the popup list closes.</td></tr>
<tr>
<td>
<kbd>Tab</kbd></td><td>
Focuses on the next TabIndex element on the page when the popup is closed. Otherwise, closes the popup list and remains the focus of the component.</td></tr>
<tr>
<td>
<kbd>Shift + Tab</kbd></td><td>
Focuses on the previous TabIndex element on the page when the popup is closed. Otherwise, closes the popup list and remains the focus of the component.</td></tr>
<tr>
<td>
<kbd>Up arrow</kbd></td><td>
Selects the item previous to the currently selected one.</td></tr>
<tr>
<td>
<kbd>Down arrow</kbd></td><td>
Selects the first item in the popup list when no item selected. Otherwise, selects the item next to the currently selected item.</td></tr>
<tr>
<td>
<kbd>Home</kbd></td><td>
Select the first options.</td></tr>
<tr>
<td>
<kbd>End</kbd></td><td>
Select the last options.</td></tr>
</table>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/querybuilder/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/querybuilder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/querybuilder/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


