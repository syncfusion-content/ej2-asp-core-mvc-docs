---
title: "Types Of Badge"
component: "Badge"
description: "Pure CSS Badge component has eight (8) types of badges, namely circle, pill, link, notification, overlap, dot, and position."
---

# Types and Styles

This section explains different styles and types of the badges.

## Badge styles

The Essential JS 2 Badge has the following predefined styles that can be used with `.e-badge` class to change the appearance of a badge.

| Class Name        | Description
| :-------------    |:-------------
| e-badge-primary   | Represents a primary notification.
| e-badge-secondary | Represents a secondary notification.
| e-badge-success   | Represents a positive notification.
| e-badge-danger    | Represents a negative notification.
| e-badge-warning   | Represents notification with caution.
| e-badge-info      | Represents an informative notification.
| e-badge-light     | Represents notification in light variant.
| e-badge-dark      | Represents notification in dark variant.

{% aspTab template="badge/types", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/badgestyles.PNG)

## Badge types

The types of Essential JS 2 badges are as follows:

* Circle
* Pill
* Link
* Notification
* Overlap
* Dot
* Position

### Circle

The circle badge style can be applied by adding the modifier class `.e-badge-circle` to the target element.

{% aspTab template="badge/circle", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/circle.PNG)

### Pill

The pill badge style can be applied by adding the modifier class `.e-badge-pill` to the target element.

{% aspTab template="badge/pill", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/pill.PNG)

### Link

When badge modifier classes are applied to the anchor tag, the badge’s appearance will change from normal state to hover state on mouseover.

{% aspTab template="badge/link", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/link.PNG)

### Notification

The notification badge style can be applied by adding the modifier class `.e-badge-notification` to the target element.
Notification badges are used when a content or a context needs special attention. While using the notification badge,
set the parent element to `position: relative`.

{% aspTab template="badge/notification", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/notification.PNG)

### Dot

Dot can be applied by adding the modifier class `.e-badge-dot` to the target element. Dot badges are similar to notification badges, but in a minimalistic way. While using the dot badge, set the parent element to `position: relative` .

{% aspTab template="badge/dot", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/dot.PNG)

### Overlap

The overlap badge can be used with `notification` or `dot` badge, which overlaps with the target element
by adding the modifier class`.e-badge-overlap`. While using the overlap badge, set the parent element to `position: relative`.

{% aspTab template="badge/overlap", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/overlap.PNG)

### Position

The default position of the `notification` or `dot` badge is top. But, the position can be changed to `bottom` using
the modifier class `.e-badge-bottom`. For example, the bottom class modifier is used with dot badge to display the
status in the avatar as shown in the following sample.

{% aspTab template="badge/position", sourceFiles="HomeController.cs" %}

{% endaspTab %}

Output be like the below.

![Badge Sample](./images/position.PNG)
