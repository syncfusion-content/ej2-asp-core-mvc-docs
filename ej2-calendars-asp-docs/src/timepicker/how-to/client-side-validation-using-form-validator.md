---
title: "How To"
component: "TimePicker"
description: "Miscellaneous aspects of customizing the time picker"
---

# Client side validation using FormValidator

To achieve client side validation in a TimePicker component, use
[Essential JavaScript 2 FormValidator](https://ej2.syncfusion.com/documentation/form-validator). It provides an option to customize feedback error messages to the corresponding
fields for taking action and resolving the issue.

In the following example, the required field validation is implemented by mapping the name attribute
value to the rules property. It validates the TimePicker component and displays the validation
message when the textbox value is empty during form post back or focus out.

{% aspTab template="timepicker/how-to/validation", sourceFiles="validation.cs" %}
{% endaspTab %}