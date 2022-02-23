---
title: "Setting Dimension for Tooltip"
component: "Tooltip"
description: "Tooltip component’s dimension can either be assigned auto height and width values or specific pixel values."
---

# Setting Dimension

## Height and width

The Tooltip can either be assigned auto height and width values or specific pixel values. The `width` and `height` properties are used to
 set the outer dimension of the Tooltip element. The default value for both the properties is `auto`.
  It also accepts string and number values in pixels.

The following sample explains how to set dimensions for the Tooltip.

{% aspTab template="tooltip/height-width", sourceFiles="height-width.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Dimension](./images/tooltip-dimension.png)

### Scroll mode

When `height` is specified with a certain pixel value and the Tooltip content overflows, the scrolling mode gets enabled.

{% aspTab template="tooltip/scroll-mode", sourceFiles="scroll-mode.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Scroll Mode](./images/tooltip-scroll.png)

> The scrolling mode can best be seen when the sticky mode of the Tooltip is enabled. To enable sticky mode, set the `isSticky` property to true.
