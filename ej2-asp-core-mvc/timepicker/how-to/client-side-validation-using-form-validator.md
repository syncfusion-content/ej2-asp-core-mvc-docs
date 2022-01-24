---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Client Side Validation Using Form Validator of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Client Side Validation Using Form Validator
publishingplatform: ##Platform_Name##
documentation: ug
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