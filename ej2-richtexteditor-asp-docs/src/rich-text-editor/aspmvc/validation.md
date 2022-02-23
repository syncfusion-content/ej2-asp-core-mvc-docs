---
title: "Rich Text Editor Validation"
component: "Rich Text Editor"
description: "This section explains on how to validate the Syncfusion ASP.NET MVC Rich Text Editor control's value by applying validationRules and validationMessage."
---

# Validation

Validate the Rich Text Editor’s value on form submission by applying Validation Rules and Validation Message to the Rich Text Editor.

## Validation Rules

The Rich Text Editor is a textarea control. The Rich Text Editor also provides the functionality of character count and its validation. So, you can validate the Rich Text Editor’s value on form submission by applying Validation Rules and Validation Message to the Rich Text Editor.

| Rules | Description |
|----------------|---------|
| required | Requires value for the Rich Text Editor control.|
| minlength | Requires the value to be of given minimum characters count.|
| maxlength | Requires the value to be of given maximum characters count.|

This sample is used to validate form using the obtrusive Validation. Type the values in Rich Text Editor and the form enables the validation with the formvalidator rules by clicking on the submit externally. All rules are validated by the formvalidator rules.

{% aspTab template="rich-text-editor/default-validation", sourceFiles="controller.cs" %}

{% endaspTab %}

## Validation Message

The default error message for a rule can be customizable by defining it along with concern rule object as follows

{% aspTab template="rich-text-editor/validation-rules", sourceFiles="controller.cs" %}

{% endaspTab %}

## Custom Placement of Validation Message

The FormValidator has an event `customPlacement` which can be used to place the error message from default position to desired custom location.

{% aspTab template="rich-text-editor/custom-placement", sourceFiles="controller.cs" %}

{% endaspTab %}
