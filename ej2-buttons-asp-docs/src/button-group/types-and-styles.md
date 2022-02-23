---
title: "ButtonGroup Types and Styles"
component: "ButtonGroup"
description: "ButtonGroup CSS control supports outline type and predefined styles."
---

# Types and Styles

This section explains about different types and styles of ButtonGroup.

## ButtonGroup types

### Outline ButtonGroup

An Outline ButtonGroup has a border with transparent background. To create Outline ButtonGroup, `e-outline` class should
be added to the target element and to each button elements using `CssClass` property.

The following sample illustrates how to achieve an Outline ButtonGroup,
{% aspTab template="button-group/types/demo", sourceFiles="default.cs", isDefaultActive=true %}

{% endaspTab %}

> ButtonGroup does not have support for `flat` and `round` types.

## ButtonGroup styles

The Essential JS 2 ButtonGroup has the following predefined styles. This can be achieved by adding corresponding class name
in each button elements using `CssClass` property.

| Class | Description |
| -------- | -------- |
| e-primary | Used to represent a primary action. |
| e-success | Used to represent a positive action. |
| e-info | Used to represent an informative action. |
| e-warning | Used to represent an action with caution. |
| e-danger | Used to represent a negative action. |

The following example illustrates how to achieve predefined styles in ButtonGroup.

{% aspTab template="button-group/styles/demo", sourceFiles="default.cs" %}

{% endaspTab %}

> Predefined ButtonGroup styles provide only the visual indication. So,
ButtonGroup content should define the ButtonGroup style for the users of assistive technologies such as screen readers.

## See Also

* [ButtonGroup with icons](./how-to/create-buttongroup-with-icons)
* [Create ButtonGroup with rounded corner](./how-to/create-buttongroup-with-rounded-corner)