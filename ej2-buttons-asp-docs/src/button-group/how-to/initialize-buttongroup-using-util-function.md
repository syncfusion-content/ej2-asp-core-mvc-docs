---
title: "Initialize ButtonGroup using util function"
component: "ButtonGroup"
description: "ButtonGroup how to section, create ButtonGroup using util function, icons, form submit, show selected state on initial render."
---

# Initialize ButtonGroup using util function

Though, it is a CSS component for easy initialization of ButtonGroup `createButtonGroup` util function can be used.

Using `createButtonGroup` method, the Button options, selector, and cssClass is passed and the corresponding classes is added to the
elements.

## Create basic ButtonGroup

To create a basic ButtonGroup, the target element along with the button elements should be created.

## Create radio type ButtonGroup

To create a radio type ButtonGroup, the target element along with the input elements should be created with type `radio`.

## Create checkbox type ButtonGroup

Checkbox type ButtonGroup creation is similar to radio type ButtonGroup, instead the type of the input elements should be `checkbox`.

The following example illustrates how to create ButtonGroup using `createButtonGroup` method for basic, checkbox, and radio
type behaviors.

{% aspTab template="button-group/basic-util/demo", sourceFiles="default.cs", isDefaultActive=true %}

{% endaspTab %}

> If null value is passed in button options, then that particular button will be skipped from processing in `createButtonGroup` util function.