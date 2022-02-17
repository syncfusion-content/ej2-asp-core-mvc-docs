---
layout: post
title: Accessibility in ##Platform_Name## Tab Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

## ARIA attributes

Tab component is designed by considering [WAI-ARIA](https://www.w3.org/TR/wai-aria-practices/#Tabpanel) standard. Tab is supported with ARIA Accessibility which is accessible by on-screen readers, and other assistive technology devices.
The following list of attributes are added in the Tab.

| **Roles and Attributes** | **Functionalities** |
| --- | --- |
| `tablist` | This is set to role attribute in the Tab element that describes actual role of the element.|
| `tabpanel` | This is set to role attribute for the Tab content that describes the role for viewing the active content.|
| presentation       | This is set to role attribute for nested elements in the Tab.  |
| aria-orientation    | It indicates the Tab header orientation. Default value of this attribute is `horizontal`. |
| aria-activedescendant    | It indicates the current active child of the Tab component. |
| aria-haspopup       | It indicates the popup mode in the Tab. The default value of this attribute is false. If popup mode is enabled, the attribute value is set to true. |
| aria-disabled       | It indicates the disabled state of the Tab. |
| aria-selected       | It indicates the selection state for Tab items. Active Tab is set to true for this attribute. |
| aria-hidden      | It indicates the hidden element of the Tab. |
| aria-controls       | It indicates the associated `Tabpanel` for the header. |
| aria-labelledby       | It indicates the associated Tab header for the content. |

## Keyboard interaction

By default, keyboard navigation is enabled. This component implements keyboard navigation support by following the WAI-ARIA practices. Once focused on the active Tab element, you can use the following key combination for interacting with the Tab.

| Key           | Description                                                                         |
|---------------|-------------------------------------------------------------------------------------|
| <kbd>Left</kbd>    | Moves focus to the previous Tab. If focus is on the first Tab, the focus will not move to any Tab. |
| <kbd>Right</kbd>   | Moves focus to the next Tab. If focus is on the last Tab element, the focus will not move to any Tab. |
| <kbd>Enter</kbd> or <kbd> Space</kbd>  | Selects the Tab if it is not selected. Opens the popup dropdown icon if it is focussed. Select the Tab item as active when popup item is focussed. |
| <kbd>Esc(Escape)</kbd>           | Closes the popup if popup is in opened state.       |
| <kbd>Down</kbd> or <kbd>Up</kbd>   | When the popup is open and focused, it will move to previous/next Tab items of the popup in the vertical direction. |
|  <kbd>Home</kbd>    | Moves focus to the first Tab. |
|  <kbd>End </kbd>   | Moves focus to the last Tab. |
|  <kbd>Shift + F10 </kbd>   | If popup mode is enabled, it opens the popup when the Tab is focused. |
|  <kbd>Delete</kbd>    | Deletes the Tab, if close button is enabled in Tab header. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/tab/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Accessibility.cs" %}
{% include code-snippet/tab/accessibility/accessibility.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

