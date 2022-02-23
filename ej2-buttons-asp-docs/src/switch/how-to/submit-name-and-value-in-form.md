---
title: "Submit name and value in form"
component: "Switch"
description: "Switch how to section, customization of Switch bar and handle, change size, name and value in form submit."
---

# Submit name and value in form

The name attribute of the Switch is used to group Switches. When the Switches are grouped in form, the checked items value attribute will post to the server on form submit. The disabled and unchecked Switch values will not be sent to the server on form submit.

In the following code snippet, USB and Wi-Fi in the checked state, and Bluetooth is in disabled state.
Values that are in checked state only be sent on form submit.

{% aspTab template="switch/form/demo", sourceFiles="default.cs" %}

{% endaspTab %}