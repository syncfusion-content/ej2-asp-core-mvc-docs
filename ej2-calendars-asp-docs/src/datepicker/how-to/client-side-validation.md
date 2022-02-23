---
title: "How To"
component: "DatePicker"
description: "Miscellaneous aspects of customizing the date picker"
---

# Client side validation

To achieve the client side validation in a DatePicker control by using
[Essential JavaScript 2 FormValidator](https://ej2.syncfusion.com/documentation/form-validator). It provides an option to customize the feedback error messages to the corresponding
fields to take action to resolve the issue.

In this below example, the required field validation is implemented by mapping
the name attribute
value to the rules property. It will validate the DatePicker control and display the validation
message when the textbox value is empty during form post back or focus out.

{% aspTab template="datepicker/how-to/validation", sourceFiles="validation.cs" %}

{% endaspTab %}