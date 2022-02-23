---
title: "Tooltip Position"
component: "Tooltip"
description: "Tooltip can be displayed in 12 (twelve) different positions of target element that automatically collide based on view port."
---

# Tooltip Positioning

Tooltips can be attached to 12 static locations around the target.
On initializing the Tooltip, you can set the position property with any one of the following values:

* `TopLeft`
* `TopCenter`
* `TopRight`
* `BottomLeft`
* `BottomCenter`
* `BottomRight`
* `LeftTop`
* `LeftCenter`
* `LeftBottom`
* `RightTop`
* `RightCenter`
* `RightBottom`

> By default, Tooltip is placed at the `TopCenter` of the target element.

{% aspTab template="tooltip/tooltip-positions", sourceFiles="tooltippositions.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Position](./images/tooltip-position.png)

## Tip pointer positioning

The Tooltip pointer can be attached or detached from the Tooltip by using the `showTipPointer` property.
Pointer positions can be adjusted using the `tipPointerPosition` property that can be assigned to one of the following values:

* `auto`
* `start`
* `middle`
* `end`

The following code example illustrates how to set the pointer to the start position of the Tooltip.

{% aspTab template="tooltip/tip-pointer", sourceFiles="tippointer.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Tip Pointer Position](./images/tip-pointer.png)

By default, tip pointers are auto adjusted so that the arrow does not point outside the target element.

## Dynamic positioning

The Tooltip and its tip pointer can be positioned dynamically based on the target's location. This can be achieved by using the `refresh`
 method, which auto adjusts the Tooltip over the target.

{% aspTab template="tooltip/dynamic-position", sourceFiles="dynamicposition.cs" %}

{% endaspTab %}

> When mouse trailing option is enabled, the tip pointer position gets auto adjusted based on the target, and
> other position values like start, end, and middle are not applied (to prevent the pointer from moving out of target).

Output be like the below.

![ASP .NET Core - Tooltip - Dynamic Position](./images/dynamic-position.png)

## Mouse Trailing

Tooltips can be positioned relative to the mouse pointer. This behavior can be enabled or disabled by using the `mouseTrail` property. By default, it is set to `false`.

{% aspTab template="tooltip/mouse-trailing", sourceFiles="mousetrailing.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Mouse Trail](./images/mouse-trail.png)

> When mouse trailing option is enabled, the tip pointer position gets auto adjusted based on the target, and other position values like start, end, and middle are not applied (to prevent the pointer from moving out of target).

## Setting offset values

Offset values are set to specify the distance between the target and tooltip element.
`offsetX` and `offsetY` properties are used to specify the offset left and top values.

* `offsetX` specifies the distance between the target and Tooltip element in X axis.
* `offsetY` specifies the distance between the target and Tooltip element in Y axis.

The following code example illustrates how to set offset values.

{% aspTab template="tooltip/offset-values", sourceFiles="offsetvalues.cs" %}

{% endaspTab %}

Output be like the below.

![ASP .NET Core - Tooltip - Offset Value](./images/offset-values.png)

> By default, collision is handled automatically and therefore when collision is detected the Tooltip fits horizontally and flips vertically.
