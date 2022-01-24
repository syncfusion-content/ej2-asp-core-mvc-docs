---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Submit Name And Value In Form of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Submit Name And Value In Form
publishingplatform: ##Platform_Name##
documentation: ug
---


# Submit name and value in form

The name attribute of the Switch is used to group Switches. When the Switches are grouped in form, the checked items value attribute will post to the server on form submit. The disabled and unchecked Switch values will not be sent to the server on form submit.

In the following code snippet, USB and Wi-Fi in the checked state, and Bluetooth is in disabled state.
Values that are in checked state only be sent on form submit.

{% aspTab template="switch/form/demo", sourceFiles="default.cs" %}

{% endaspTab %}