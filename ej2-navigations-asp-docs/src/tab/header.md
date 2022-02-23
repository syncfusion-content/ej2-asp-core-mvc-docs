---
title: "Tab Header"
component: "Tab"
description: "This section explains how to create the Essential JS 2 tab header with different styles in an ASP.NET application."
---

# Header

This section explains about modifying the style of Tab header, and configuring its icons and positions.

## Styles

You can customize header styles by adding predefined classes in the Tab root element. The pre-defined CSS class names are as follows:

* **e-fill**: The Selected Tab header background is set as solid fill.
* **e-background**: Tab header has a solid fill background, and the selected header has a highlighted border.
* **e-background e-accent**: Tab header has a solid fill background, and the selected header has a highlighted border with accent color.

> If the above custom style classes are not included in the root element, the default style is applied to the Tab items.

{% aspTab template="tab/styles", sourceFiles="styles.cs" %}

{% endaspTab %}

## Icon positions

You can customize the position of the Tab header icons using the icon position property.  This property depends on the header items icon CSS property.  By default, Tab header icon is placed on left position.  The position values are as follows:

* **Left**: Icon is placed on the left of the Tab header item.
* **Right**: Icon is placed on the right of the Tab header item.
* **Top**: Icon is placed on the top of the Tab header item.
* **Bottom**: Icon is placed on the bottom of the Tab header item.

{% aspTab template="tab/positions", sourceFiles="styles.cs" %}

{% endaspTab %}

Output be like the below.

![Icon Positions](./images/position.PNG)

## See Also

* [How to customize selected tab styles](./how-to/customize-selected-tab-styles)