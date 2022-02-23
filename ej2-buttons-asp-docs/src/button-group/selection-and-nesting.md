---
title: "ButtonGroup Selection and Nesting"
component: "ButtonGroup"
description: "ButtonGroup supports single selection, multiple selection, nesting with dropdownbutton and splitbutton components."
---

# Selection and Nesting

## Selection

### Single selection

ButtonGroup supports radio type selection in which only one button can be selected. This can be achieved by adding input element
along with `id` attribute with its corresponding label along with `for` attribute inside the target element. In this ButtonGroup,
the type of the input element should be `radio` and `e-btn` is added to the `label` element.

The following example illustrates the single selection behavior in ButtonGroup.

{% aspTab template="button-group/radio/demo", sourceFiles="default.cs", isDefaultActive=true %}

{% endaspTab %}

### Multiple selection

ButtonGroup supports checkbox type selection in which multiple button can be selected. This can be achieved by adding input element
along with `id` attribute with its corresponding label along with `for` attribute inside the target element. In this ButtonGroup,
the type of the input element should be `checkbox` and `e-btn` is added to the `label` element.

The following example illustrates the multiple selection behavior in ButtonGroup.

{% aspTab template="button-group/checkbox/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## Nesting

Nesting with other components can be possible in ButtonGroup. The following components can be nested in ButtonGroup.
* DropDownButton
* SplitButton

### DropDownButton

To initialize DropDownButton component refer [`DropDownButton Getting Started documentation`](./../../drop-down-button/getting-started).

In the following example, the DropDownButton component is rendered in ButtonGroup.

{% aspTab template="button-group/drop-down-button/demo", sourceFiles="default.cs" %}

{% endaspTab %}

### SplitButton

To initialize SplitButton component refer [`SplitButton Getting Started documentation`](./../../split-button/getting-started).

In the following example, the SplitButton component is rendered in ButtonGroup.

{% aspTab template="button-group/split-button/demo", sourceFiles="default.cs" %}

{% endaspTab %}

## See Also

* [Show ButtonGroup selected state on initial render](./how-to/show-buttongroup-selected-state-on-initial-render)
