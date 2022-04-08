---
layout: post
title: Accessibility in ##Platform_Name## Carousel Control
description: Checkout and learn about accessibility in ##Platform_Name## Carousel control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

The Carousel component has been designed,  keeping in mind the [WAI-ARIA](http://www.w3.org/WAI/PF/aria-practices/) specifications, and applying the WAI-ARIA roles, states and properties along with keyboard support for people who use assistive devices. WAI-ARIA accessibility support is achieved through attributes like `aria-multiselectable`, `aria-disabled`, `aria-expanded`, `aria-selected`, and `aria-hidden`. It provides information about elements in a document for assistive technology.  The component implements keyboard navigation support by following the [WAI-ARIA practices](https://www.w3.org/TR/wai-aria-practices/) and has been tested in major screen readers.

## ARIA attributes

The carousel component is designed by considering [WAI-ARIA](https://www.w3.org/TR/wai-aria-practices/) standard. Carousel is supported with ARIA Accessibility which is accessible by on-screen readers and other assistive technology devices. The following list of attributes is added to the Carousel.

| **Roles and Attributes**      |   **Functionalities**     |
| ------------------------------|---------------------------|
| `aria-roledescription`        | The role description attribute should be added for the root element (carousel) and each carousel slide item (slide). |
| `aria-label`                  | Previous, next and play/pause buttons and all indicator elements. |
| `aria-current`                | To indicator elements, the active item indicator element has `aria-current` to true. |
| `aria-hidden`                 | To all carousel elements have `aria-hidden` has true, except the currently visible item. |
| `aria-live`                   | For carousel items element - `off` - when `autoPlay` is true; `polite` - when `autoPlay` is false |
| `aria-role`                   | For carousel slide item – `aria-role` should be group. |

## Keyboard interaction

By default, keyboard navigation is enabled. This component implements keyboard navigation support by following the WAI-ARIA practices. Once focused on the active Carousel element, you can use the following key combination for interacting with the Carousel.

| Key                   | Description                                                                         |
|-----------------------|-------------------------------------------------------------------------------------|
| <kbd>Alt + J</kbd>    | keys to focus the carousel component (done at application end). |
| <kbd>Arrows</kbd>     | keys to navigate between slides. |
| <kbd>Home</kbd>       | to navigate to the first slide. |
| <kbd>End</kbd>        | to navigate to the last slide. |
| <kbd>Space</kbd>      | to play/pause the slide transitions. |
| <kbd>Enter</kbd>      | to perform the respective action on its focus. |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/carousel-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/carousel-item//carousel-item.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/carousel/populating-items/carousel-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/carousel/populating-items/carousel-item/carousel-item.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}