---
title: "Form submit"
component: "ButtonGroup"
description: "ButtonGroup how to section, create ButtonGroup using util function, icons, form submit, show selected state on initial render."
---

# Form submit

The name attribute of the input element is used to group the radio/checkbox type ButtonGroup. When the radio/checkbox type are grouped
in the form, the checked items value attribute will be posted to the server on form submit that can be retrieved through the name. The disabled
radio/checkbox type value will not be sent to the server on form submit.

In the following code snippet, the radio type ButtonGroup is explained with male value as checked.
Now, the value that is in checked state will be sent on form submit.

{% aspTab template="button-group/form/demo", sourceFiles="default.cs" %}

{% endaspTab %}